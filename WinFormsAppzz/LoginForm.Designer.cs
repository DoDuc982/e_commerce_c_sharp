namespace WinFormsAppzz
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SVN-A Love Of Thunder", 30F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(185, 9);
            label1.Name = "label1";
            label1.Size = new Size(453, 56);
            label1.TabIndex = 0;
            label1.Text = "Welcome to our store";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 153);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 211);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(271, 65);
            label4.Name = "label4";
            label4.Size = new Size(260, 57);
            label4.TabIndex = 3;
            label4.Text = "NINESHOP";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(313, 145);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(234, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(313, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(271, 252);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(75, 23);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(432, 252);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 23);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 361);
            Controls.Add(btnSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSignIn;
        private Button btnSignUp;
    }
}