namespace WinFormsAppzz
{
    partial class AllFunction
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
            button1 = new Button();
            btnProduct = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnProduct);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(272, 134);
            button1.Name = "button1";
            button1.Size = new Size(192, 63);
            button1.TabIndex = 1;
            button1.Text = "Quản lý danh mục";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(34, 134);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(192, 63);
            btnProduct.TabIndex = 0;
            btnProduct.Text = "Quản lý sản phẩm";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(162, 25);
            label1.Name = "label1";
            label1.Size = new Size(485, 35);
            label1.TabIndex = 2;
            label1.Text = "Chương trình quản lý dành cho Admin";
            // 
            // AllFunction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "AllFunction";
            Text = "AllFunction";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnProduct;
        private Button button1;
        private Label label1;
    }
}