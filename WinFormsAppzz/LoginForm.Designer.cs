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
            label1.Location = new Point(211, 12);
            label1.Name = "label1";
            label1.Size = new Size(566, 69);
            label1.TabIndex = 0;
            label1.Text = "Welcome to our store";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 204);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 281);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(310, 87);
            label4.Name = "label4";
            label4.Size = new Size(324, 71);
            label4.TabIndex = 3;
            label4.Text = "NINESHOP";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(358, 193);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(267, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(358, 271);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(267, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(211, 346);
            btnSignIn.Margin = new Padding(3, 4, 3, 4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(145, 61);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(467, 348);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(158, 56);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 481);
            Controls.Add(btnSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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