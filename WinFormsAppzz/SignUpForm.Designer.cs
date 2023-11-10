namespace WinFormsAppzz
{
    partial class SignUpForm
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
            btnBack = new Button();
            btnSignUp = new Button();
            cbSex = new ComboBox();
            label8 = new Label();
            txtPhoneNum = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(cbSex);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtPhoneNum);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 309);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(633, 227);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(141, 54);
            btnBack.TabIndex = 38;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(442, 227);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(141, 54);
            btnSignUp.TabIndex = 37;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Male", "Female" });
            cbSex.Location = new Point(138, 258);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(114, 28);
            cbSex.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 261);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 35;
            label8.Text = "Giới tính";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(138, 203);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(223, 27);
            txtPhoneNum.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 206);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 14;
            label7.Text = "Phonenum";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(138, 151);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 27);
            txtEmail.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 154);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 12;
            label6.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(551, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(223, 27);
            txtPassword.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 171);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(551, 122);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(223, 27);
            txtUsername.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 125);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 8;
            label3.Text = "Username";
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 27);
            txtName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(464, 13);
            label4.Name = "label4";
            label4.Size = new Size(324, 71);
            label4.TabIndex = 5;
            label4.Text = "NINESHOP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SVN-A Love Of Thunder", 30F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(349, 69);
            label2.TabIndex = 4;
            label2.Text = "Sign Up Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 101);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 309);
            Controls.Add(panel1);
            Name = "SignUpForm";
            Text = "SignUpForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtPhoneNum;
        private Label label7;
        private Button btnBack;
        private Button btnSignUp;
        private ComboBox cbSex;
        private Label label8;
    }
}