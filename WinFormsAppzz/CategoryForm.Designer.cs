namespace WinFormsAppzz
{
    partial class CategoryForm
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
            txtContent = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            txtId = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvCategory = new DataGridView();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 25);
            label1.TabIndex = 1;
            label1.Text = "Quản lý danh mục sản phẩm";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtContent);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 113);
            panel1.TabIndex = 2;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(447, 56);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(100, 23);
            txtContent.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(181, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 59);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Nội dung";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 59);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 7;
            label3.Text = "Tên danh mục";
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 368);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 87);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 31);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 6;
            label2.Text = "Mã danh mục";
            // 
            // txtId
            // 
            txtId.Location = new Point(385, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(502, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(599, 27);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(697, 27);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(181, 16);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(104, 44);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(36, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 44);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Dock = DockStyle.Fill;
            dgvCategory.Location = new Point(0, 113);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.RowTemplate.Height = 25;
            dgvCategory.Size = new Size(800, 255);
            dgvCategory.TabIndex = 4;
            dgvCategory.CellContentClick += dgvCategoryCellContentClick;
            dgvCategory.RowEnter += dgvCategoryRowEnter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(51, 63);
            label7.Name = "label7";
            label7.Size = new Size(224, 13);
            label7.TabIndex = 15;
            label7.Text = "Cần cung cấp đủ các trường khi sửa thông tin";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(dgvCategory);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CategoryForm";
            Text = "Category Form";
            Load += load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvCategory;
        private Button btnBack;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnDelete;
        private Label label2;
        private TextBox txtId;
        private Button btnSearch;
        private TextBox txtContent;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label7;
    }
}