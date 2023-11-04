namespace WinFormsAppzz
{
    partial class DiscountForm
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
            txtDecrease = new TextBox();
            label8 = new Label();
            label6 = new Label();
            cbType = new ComboBox();
            txtQuantity = new TextBox();
            label5 = new Label();
            txtContent = new TextBox();
            label4 = new Label();
            txtCode = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            txtId = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvDiscount = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiscount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 2;
            label1.Text = "Quản lý mã giảm giá";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtDecrease);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbType);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtContent);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCode);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 168);
            panel1.TabIndex = 3;
            // 
            // txtDecrease
            // 
            txtDecrease.Location = new Point(459, 112);
            txtDecrease.Margin = new Padding(3, 4, 3, 4);
            txtDecrease.Name = "txtDecrease";
            txtDecrease.Size = new Size(114, 27);
            txtDecrease.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(384, 115);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 23;
            label8.Text = "Giảm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 110);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 21;
            label6.Text = "Kiểu giảm giá";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "%", "đ" });
            cbType.Location = new Point(168, 107);
            cbType.Name = "cbType";
            cbType.Size = new Size(151, 28);
            cbType.TabIndex = 19;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(459, 59);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(114, 27);
            txtQuantity.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 62);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 18;
            label5.Text = "Số lượng";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(711, 59);
            txtContent.Margin = new Padding(3, 4, 3, 4);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(114, 27);
            txtContent.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(634, 62);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 16;
            label4.Text = "Nội dung";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(169, 61);
            txtCode.Margin = new Padding(3, 4, 3, 4);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(114, 27);
            txtCode.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 64);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 14;
            label3.Text = "Mã giảm giá";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 455);
            panel2.Name = "panel2";
            panel2.Size = new Size(911, 105);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 45);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 13;
            label2.Text = "ID mã giảm giá";
            // 
            // txtId
            // 
            txtId.Location = new Point(423, 40);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(557, 40);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(668, 40);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(780, 40);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 9;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(168, 26);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(119, 59);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(24, 25);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 59);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvDiscount
            // 
            dgvDiscount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscount.Dock = DockStyle.Fill;
            dgvDiscount.Location = new Point(0, 168);
            dgvDiscount.Name = "dgvDiscount";
            dgvDiscount.RowHeadersWidth = 51;
            dgvDiscount.RowTemplate.Height = 29;
            dgvDiscount.Size = new Size(911, 287);
            dgvDiscount.TabIndex = 5;
            dgvDiscount.CellContentClick += discount_cellContentClick;
            dgvDiscount.RowEnter += discount_rowEnter;
            // 
            // DiscountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 560);
            Controls.Add(dgvDiscount);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DiscountForm";
            Text = "DiscountForm";
            Load += load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiscount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvDiscount;
        private Label label2;
        private TextBox txtId;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnBack;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtContent;
        private Label label4;
        private TextBox txtCode;
        private Label label3;
        private Label label6;
        private ComboBox cbType;
        private TextBox txtQuantity;
        private Label label5;
        private TextBox txtDecrease;
        private Label label8;
    }
}