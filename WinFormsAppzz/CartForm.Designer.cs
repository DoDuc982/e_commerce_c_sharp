namespace WinFormsAppzz
{
    partial class CartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            btnBack = new Button();
            btnOut = new Button();
            txtQuantity = new TextBox();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvProduct = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 2;
            label1.Text = "Giỏ hàng";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnOut);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 94);
            panel1.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(410, 53);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 22);
            btnBack.TabIndex = 13;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(564, 27);
            btnOut.Margin = new Padding(3, 2, 3, 2);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(131, 49);
            btnOut.TabIndex = 6;
            btnOut.Text = "Xuất hóa đơn";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(143, 56);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(110, 23);
            txtQuantity.TabIndex = 5;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(46, 56);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Thay đổi";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(308, 54);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Loại bỏ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.Location = new Point(0, 94);
            dgvProduct.Margin = new Padding(3, 2, 3, 2);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(737, 258);
            dgvProduct.TabIndex = 4;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            dgvProduct.RowEnter += dgvProduct_RowEnter;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 352);
            Controls.Add(dgvProduct);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CartForm";
            Text = "Cart";
            Load += CartForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnOut;
        private TextBox txtQuantity;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvProduct;
        private Button btnBack;
    }
}