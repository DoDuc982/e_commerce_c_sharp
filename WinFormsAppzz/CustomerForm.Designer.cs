namespace WinFormsAppzz
{
    partial class CustomerForm
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
            panel3 = new Panel();
            label12 = new Label();
            cbSex = new ComboBox();
            cbRole = new ComboBox();
            label11 = new Label();
            txtPhoneNum = new TextBox();
            label10 = new Label();
            txtPassword = new TextBox();
            label9 = new Label();
            txtUsername = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnBack = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtId = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            dgvCustomer = new DataGridView();
            label13 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 130);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label12);
            panel3.Controls.Add(cbSex);
            panel3.Controls.Add(cbRole);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtPhoneNum);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(860, 130);
            panel3.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(603, 87);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 35;
            label12.Text = "Email";
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Male", "Female" });
            cbSex.Location = new Point(94, 85);
            cbSex.Margin = new Padding(3, 2, 3, 2);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(100, 23);
            cbSex.TabIndex = 34;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "USER", "ADMIN" });
            cbRole.Location = new Point(279, 86);
            cbRole.Margin = new Padding(3, 2, 3, 2);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(100, 23);
            cbRole.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(214, 88);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 32;
            label11.Text = "Vai trò";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(332, 38);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(100, 23);
            txtPhoneNum.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(247, 43);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 31;
            label10.Text = "Số điện thoại";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(467, 82);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(395, 85);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 29;
            label9.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(527, 40);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(454, 43);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 27;
            label8.Text = "Username";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(662, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(137, 23);
            txtEmail.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 88);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 25;
            label5.Text = "Giới tính";
            // 
            // txtName
            // 
            txtName.Location = new Point(136, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 7);
            label6.Name = "label6";
            label6.Size = new Size(187, 25);
            label6.TabIndex = 14;
            label6.Text = "Quản lý khách hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 43);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 23;
            label7.Text = "Tên khách hàng";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 88);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 25;
            label4.Text = "ID khách hàng";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 14;
            label1.Text = "Quản lý khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 43);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 23;
            label3.Text = "ID khách hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(label13);
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnEdit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 393);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 94);
            panel2.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(727, 29);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 17;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(627, 29);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(530, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(395, 31);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 33);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 21;
            label2.Text = "ID khách hàng";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(13, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 44);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(149, 19);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(104, 44);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.Location = new Point(0, 130);
            dgvCustomer.Margin = new Padding(3, 2, 3, 2);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(860, 263);
            dgvCustomer.TabIndex = 2;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            dgvCustomer.RowEnter += dgvCustomer_RowEnter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(29, 72);
            label13.Name = "label13";
            label13.Size = new Size(224, 13);
            label13.TabIndex = 15;
            label13.Text = "Cần cung cấp đủ các trường khi sửa thông tin";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 487);
            Controls.Add(dgvCustomer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerForm";
            Text = "Customer Form";
            Load += load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvCustomer;
        private Label label1;
        private Button btnBack;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtId;
        private Label label2;
        private Button btnAdd;
        private Button btnEdit;
        private Panel panel3;
        private TextBox txtPassword;
        private Label label9;
        private TextBox txtUsername;
        private Label label8;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtName;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private ComboBox cbRole;
        private Label label11;
        private TextBox txtPhoneNum;
        private Label label10;
        private Label label12;
        private ComboBox cbSex;
        private Label label13;
    }
}