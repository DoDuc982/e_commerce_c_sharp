﻿namespace WinFormsAppzz
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
            label1 = new Label();
            panel2 = new Panel();
            btnBack = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtId = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            dgvCustomer = new DataGridView();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            panel3 = new Panel();
            label5 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtUsername = new TextBox();
            label8 = new Label();
            txtPassword = new TextBox();
            label9 = new Label();
            txtPhoneNum = new TextBox();
            label10 = new Label();
            label11 = new Label();
            cbRole = new ComboBox();
            cbSex = new ComboBox();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel3.SuspendLayout();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 174);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 32);
            label1.TabIndex = 14;
            label1.Text = "Quản lý khách hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnEdit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 524);
            panel2.Name = "panel2";
            panel2.Size = new Size(983, 125);
            panel2.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(827, 67);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 17;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(713, 67);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(602, 67);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(448, 69);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 72);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 21;
            label2.Text = "ID khách hàng";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 53);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 59);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(167, 53);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(119, 59);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.Location = new Point(0, 174);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(983, 350);
            dgvCustomer.TabIndex = 2;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            dgvCustomer.RowEnter += dgvCustomer_RowEnter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 54);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 57);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 23;
            label3.Text = "ID khách hàng";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 114);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 117);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 25;
            label4.Text = "ID khách hàng";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(757, 113);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(156, 27);
            txtEmail.TabIndex = 24;
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
            panel3.Name = "panel3";
            panel3.Size = new Size(983, 174);
            panel3.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 117);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 25;
            label5.Text = "Giới tính";
            // 
            // txtName
            // 
            txtName.Location = new Point(155, 54);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(239, 32);
            label6.TabIndex = 14;
            label6.Text = "Quản lý khách hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 57);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 23;
            label7.Text = "Tên khách hàng";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(602, 54);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(114, 27);
            txtUsername.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(519, 57);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 27;
            label8.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(534, 110);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(114, 27);
            txtPassword.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(451, 113);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 29;
            label9.Text = "Password";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(380, 51);
            txtPhoneNum.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(114, 27);
            txtPhoneNum.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(282, 57);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 31;
            label10.Text = "Số điện thoại";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(245, 117);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 32;
            label11.Text = "Vai trò";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "USER", "ADMIN" });
            cbRole.Location = new Point(319, 114);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(114, 28);
            cbRole.TabIndex = 33;
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Male", "Female" });
            cbSex.Location = new Point(108, 113);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(114, 28);
            cbSex.TabIndex = 34;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(689, 116);
            label12.Name = "label12";
            label12.Size = new Size(46, 20);
            label12.TabIndex = 35;
            label12.Text = "Email";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 649);
            Controls.Add(dgvCustomer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomerForm";
            Text = "Customer Form";
            Load += load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
    }
}