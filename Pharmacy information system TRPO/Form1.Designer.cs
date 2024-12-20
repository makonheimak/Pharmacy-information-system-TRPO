namespace Pharmacy_information_system_TRPO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnGenerateReport = new Button();
            btnDelete = new Button();
            txtProductName = new TextBox();
            panel1 = new Panel();
            nudPrice = new NumericUpDown();
            cmbCategory = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvProducts = new DataGridView();
            nudQuantity = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(231, 243);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(168, 57);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(231, 460);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(168, 57);
            btnGenerateReport.TabIndex = 1;
            btnGenerateReport.Text = "Создать отчет";
            btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(231, 353);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 57);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(13, 40);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(164, 31);
            txtProductName.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(nudPrice);
            panel1.Controls.Add(cmbCategory);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvProducts);
            panel1.Controls.Add(nudQuantity);
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnGenerateReport);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1290, 739);
            panel1.TabIndex = 5;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(231, 149);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(164, 31);
            nudPrice.TabIndex = 12;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(13, 147);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(164, 33);
            cmbCategory.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 121);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 10;
            label4.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 121);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 9;
            label3.Text = "Категория";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 12);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 8;
            label2.Text = "Количество";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 7;
            label1.Text = "Название товара";
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = Color.LightSeaGreen;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(430, 12);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(849, 716);
            dgvProducts.TabIndex = 6;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(231, 40);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(164, 31);
            nudQuantity.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 739);
            Controls.Add(panel1);
            Name = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnGenerateReport;
        private Button btnDelete;
        private TextBox txtProductName;
        private Panel panel1;
        private NumericUpDown nudQuantity;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvProducts;
        private NumericUpDown nudPrice;
        private ComboBox cmbCategory;
    }
}
