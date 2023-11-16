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
            btnOrders = new Button();
            btnSignOut = new Button();
            btnOrder = new Button();
            btnCustomer = new Button();
            btnDiscount = new Button();
            label1 = new Label();
            btnCategory = new Button();
            btnProduct = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(btnOrder);
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(btnDiscount);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnProduct);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 338);
            panel1.TabIndex = 0;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(238, 261);
            btnOrders.Margin = new Padding(3, 2, 3, 2);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(168, 47);
            btnOrders.TabIndex = 7;
            btnOrders.Text = "Quản lý đơn hàng";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.Location = new Point(562, 280);
            btnSignOut.Margin = new Padding(3, 2, 3, 2);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(128, 42);
            btnSignOut.TabIndex = 6;
            btnSignOut.Text = "Đăng xuất";
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(348, 180);
            btnOrder.Margin = new Padding(3, 2, 3, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(168, 47);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "Quản lý hóa đơn";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(133, 180);
            btnCustomer.Margin = new Padding(3, 2, 3, 2);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(168, 47);
            btnCustomer.TabIndex = 4;
            btnCustomer.Text = "Quản lý người dùng";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(450, 100);
            btnDiscount.Margin = new Padding(3, 2, 3, 2);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(168, 47);
            btnDiscount.TabIndex = 3;
            btnDiscount.Text = "Quản lý mã giảm giá";
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(142, 19);
            label1.Name = "label1";
            label1.Size = new Size(391, 28);
            label1.TabIndex = 2;
            label1.Text = "Chương trình quản lý dành cho Admin";
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(238, 100);
            btnCategory.Margin = new Padding(3, 2, 3, 2);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(168, 47);
            btnCategory.TabIndex = 1;
            btnCategory.Text = "Quản lý danh mục";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += button1_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(30, 100);
            btnProduct.Margin = new Padding(3, 2, 3, 2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(168, 47);
            btnProduct.TabIndex = 0;
            btnProduct.Text = "Quản lý sản phẩm";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // AllFunction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnOrder;
        private Button btnSignOut;
        private Button btnOrders;
        private Button btnCustomer;
    }
}