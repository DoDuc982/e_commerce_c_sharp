namespace WinFormsAppzz
{
    partial class OrderInfoForm
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
            sub = new Label();
            ship = new Label();
            label4 = new Label();
            grand = new Label();
            label8 = new Label();
            button1 = new Button();
            label2 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 64);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Giá trị đơn hàng:";
            // 
            // sub
            // 
            sub.AutoSize = true;
            sub.Location = new Point(228, 64);
            sub.Name = "sub";
            sub.Size = new Size(38, 15);
            sub.TabIndex = 1;
            sub.Text = "label2";
            // 
            // ship
            // 
            ship.AutoSize = true;
            ship.Location = new Point(228, 101);
            ship.Name = "ship";
            ship.Size = new Size(38, 15);
            ship.TabIndex = 3;
            ship.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 101);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 2;
            label4.Text = "Giá ship:";
            // 
            // grand
            // 
            grand.AutoSize = true;
            grand.Location = new Point(228, 137);
            grand.Name = "grand";
            grand.Size = new Size(38, 15);
            grand.TabIndex = 7;
            grand.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 137);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 6;
            label8.Text = "Tổng giá trị đơn hàng:";
            // 
            // button1
            // 
            button1.Location = new Point(77, 168);
            button1.Name = "button1";
            button1.Size = new Size(100, 37);
            button1.TabIndex = 8;
            button1.Text = "Đặt hàng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(107, 9);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 9;
            label2.Text = "Giá trị hóa đơn";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(188, 168);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(96, 37);
            btnBack.TabIndex = 10;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // OrderInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 226);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(grand);
            Controls.Add(label8);
            Controls.Add(ship);
            Controls.Add(label4);
            Controls.Add(sub);
            Controls.Add(label1);
            Name = "OrderInfoForm";
            Text = "OrderInfoForm";
            Load += OrderInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label sub;
        private Label ship;
        private Label label4;
        private Label grand;
        private Label label8;
        private Button button1;
        private Label label2;
        private Button btnBack;
    }
}