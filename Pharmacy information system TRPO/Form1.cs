using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Pharmacy_information_system_TRPO
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Максим\Desktop\Pharmacy information system TRPO\Pharmacy information system TRPO\Database.accdb";

        public Form1()
        {
            InitializeComponent();
            LoadData();
            btnAdd.Click += new EventHandler(btnAdd_Click);
            btnGenerateReport.Click += new EventHandler(btnDelete_Click);

            // категории ComboBox
            cmbCategory.Items.Add("Витамин");
            cmbCategory.Items.Add("Анальгетик");
            cmbCategory.Items.Add("Антибиотик");
            cmbCategory.Items.Add("Противовирусное");

            // макс Price
            nudPrice.Maximum = 1000000;

            btnDelete.Click += new EventHandler(btnGenerateReport_Click);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "INSERT INTO Products (ProductName, Quantity, Category, Price) VALUES (@ProductName, @Quantity, @Category, @Price)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                    command.Parameters.AddWithValue("@Quantity", nudQuantity.Value);
                    command.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Price", nudPrice.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "DELETE FROM Products WHERE ProductID = @ProductID";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Выберите товар для удаления.");
            }
        }

        private void LoadData()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM Products";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvProducts.DataSource = dataTable;
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM Products";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                string filePath = @"C:\Users\Максим\Desktop\ProductsReport.xlsx";

                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Products");

                    // Заголовки столбцов
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                    }

                    // Данные
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dataTable.Rows[i][j];
                        }
                    }

                    package.SaveAs(new FileInfo(filePath));
                }

                MessageBox.Show("Отчет успешно создан на рабочем столе.");
            }
        }
    }
}
