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
            label1 = new Label();
            btnCategory = new Button();
            btnProduct = new Button();
            btnDiscount = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDiscount);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnProduct);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 451);
            panel1.TabIndex = 0;
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
            // btnCategory
            // 
            btnCategory.Location = new Point(272, 133);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(192, 63);
            btnCategory.TabIndex = 1;
            btnCategory.Text = "Quản lý danh mục";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += button1_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(34, 133);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(192, 63);
            btnProduct.TabIndex = 0;
            btnProduct.Text = "Quản lý sản phẩm";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(514, 133);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(192, 63);
            btnDiscount.TabIndex = 3;
            btnDiscount.Text = "Quản lý mã giảm giá";
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // AllFunction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
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
        private Button btnCategory;
        private Label label1;
        private Button btnDiscount;
    }
}