namespace WinFormsAppzz
{
    partial class Nineshop
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
            label4 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnCart = new Button();
            btnAdd = new Button();
            txtQuantity = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 13);
            label4.Name = "label4";
            label4.Size = new Size(324, 71);
            label4.TabIndex = 5;
            label4.Text = "NINESHOP";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SVN-A Love Of Thunder", 30F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 69);
            label1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCart);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 194);
            panel2.TabIndex = 7;
            // 
            // btnCart
            // 
            btnCart.Location = new Point(495, 108);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(151, 62);
            btnCart.TabIndex = 11;
            btnCart.Text = "Xem giỏ hàng";
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += btnCart_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(313, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 62);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm vào giỏ hàng";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(153, 126);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 129);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 8;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 30);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 7;
            label2.Text = "Danh mục sản phẩm";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(561, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 28);
            comboBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(800, 313);
            dataGridView1.TabIndex = 8;
            // 
            // Nineshop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Name = "Nineshop";
            Text = "Nineshop - Welcome";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox txtQuantity;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Button btnCart;
        private Button btnAdd;
    }
}