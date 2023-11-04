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
            panel1.Location = new Point(0, 675);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1273, 81);
            panel1.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(391, 27);
            label10.Name = "label10";
            label10.Size = new Size(98, 20);
            label10.TabIndex = 21;
            label10.Text = "Mã sản phẩm";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1109, 23);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 3;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(768, 23);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(199, 8);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(129, 59);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(51, 8);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 59);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(495, 23);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(166, 27);
            txtId.TabIndex = 1;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(677, 23);
            btnFind.Margin = new Padding(3, 4, 3, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(86, 31);
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
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1273, 269);
            panel2.TabIndex = 0;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(782, 61);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(166, 28);
            cbCategory.TabIndex = 20;
            cbCategory.SelectedIndexChanged += cbCategory_index;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(691, 133);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 19;
            label9.Text = "Nội dung";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(691, 65);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 18;
            label8.Text = "Danh mục";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(392, 200);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 17;
            label7.Text = "Số lượng bán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 133);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 16;
            label6.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 200);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 15;
            label5.Text = "Link ảnh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 65);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 14;
            label4.Text = "Giá giảm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 133);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 13;
            label3.Text = "Giá sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 65);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 12;
            label2.Text = "Tên sản phẩm";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(782, 129);
            txtContent.Margin = new Padding(3, 4, 3, 4);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(166, 27);
            txtContent.TabIndex = 10;
            // 
            // txtSoldQuantity
            // 
            txtSoldQuantity.Location = new Point(495, 196);
            txtSoldQuantity.Margin = new Padding(3, 4, 3, 4);
            txtSoldQuantity.Name = "txtSoldQuantity";
            txtSoldQuantity.Size = new Size(166, 27);
            txtSoldQuantity.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(495, 129);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(166, 27);
            txtQuantity.TabIndex = 8;
            // 
            // txtDiscountPrice
            // 
            txtDiscountPrice.Location = new Point(495, 61);
            txtDiscountPrice.Margin = new Padding(3, 4, 3, 4);
            txtDiscountPrice.Name = "txtDiscountPrice";
            txtDiscountPrice.Size = new Size(166, 27);
            txtDiscountPrice.TabIndex = 7;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(179, 196);
            txtImage.Margin = new Padding(3, 4, 3, 4);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(166, 27);
            txtImage.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(179, 129);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(166, 27);
            txtPrice.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(179, 61);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 27);
            txtName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 0;
            label1.Text = "Quản lý sản phẩm";
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.Location = new Point(0, 269);
            dgvProduct.Margin = new Padding(3, 4, 3, 4);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 25;
            dgvProduct.Size = new Size(1273, 406);
            dgvProduct.TabIndex = 1;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            dgvProduct.RowEnter += dgv_productRowEnter;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 756);
            Controls.Add(dgvProduct);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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