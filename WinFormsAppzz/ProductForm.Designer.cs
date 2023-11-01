namespace WinFormsAppzz
{
    partial class ProductForm
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
            panel1 = new Panel();
            label10 = new Label();
            btnBack = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtId = new TextBox();
            btnFind = new Button();
            panel2 = new Panel();
            cbCategory = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtContent = new TextBox();
            txtSoldQuantity = new TextBox();
            txtQuantity = new TextBox();
            txtDiscountPrice = new TextBox();
            txtImage = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            dgvProduct = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnFind);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 506);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 61);
            panel1.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(342, 20);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 21;
            label10.Text = "Mã sản phẩm";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(970, 17);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(672, 17);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(174, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 44);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(45, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 44);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(433, 17);
            txtId.Name = "txtId";
            txtId.Size = new Size(146, 23);
            txtId.TabIndex = 1;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(592, 17);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 2;
            btnFind.Text = "Tìm kiếm";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbCategory);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtContent);
            panel2.Controls.Add(txtSoldQuantity);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtDiscountPrice);
            panel2.Controls.Add(txtImage);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1114, 202);
            panel2.TabIndex = 0;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(684, 46);
            cbCategory.Margin = new Padding(3, 2, 3, 2);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(146, 23);
            cbCategory.TabIndex = 20;
            cbCategory.SelectedIndexChanged += cbCategory_index;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(605, 100);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 19;
            label9.Text = "Nội dung";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(605, 49);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 18;
            label8.Text = "Danh mục";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(343, 150);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 17;
            label7.Text = "Số lượng bán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 100);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 16;
            label6.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 150);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 15;
            label5.Text = "Link ảnh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 49);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 14;
            label4.Text = "Giá giảm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 100);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 13;
            label3.Text = "Giá sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 49);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 12;
            label2.Text = "Tên sản phẩm";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(684, 97);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(146, 23);
            txtContent.TabIndex = 10;
            // 
            // txtSoldQuantity
            // 
            txtSoldQuantity.Location = new Point(433, 147);
            txtSoldQuantity.Name = "txtSoldQuantity";
            txtSoldQuantity.Size = new Size(146, 23);
            txtSoldQuantity.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(433, 97);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(146, 23);
            txtQuantity.TabIndex = 8;
            // 
            // txtDiscountPrice
            // 
            txtDiscountPrice.Location = new Point(433, 46);
            txtDiscountPrice.Name = "txtDiscountPrice";
            txtDiscountPrice.Size = new Size(146, 23);
            txtDiscountPrice.TabIndex = 7;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(157, 147);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(146, 23);
            txtImage.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(157, 97);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(146, 23);
            txtPrice.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(157, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(146, 23);
            txtName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 0;
            label1.Text = "Quản lý sản phẩm";
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.Location = new Point(0, 202);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 25;
            dgvProduct.Size = new Size(1114, 304);
            dgvProduct.TabIndex = 1;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 567);
            Controls.Add(dgvProduct);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ProductForm";
            Text = "Product";
            Load += load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnBack;
        private Panel panel2;
        private TextBox txtId;
        private Button btnFind;
        private Label label1;
        private DataGridView dgvProduct;
        private TextBox txtDiscountPrice;
        private TextBox txtImage;
        private TextBox txtPrice;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtContent;
        private TextBox txtSoldQuantity;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbCategory;
        private Label label10;
    }
}