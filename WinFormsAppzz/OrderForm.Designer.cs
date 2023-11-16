namespace WinFormsAppzz
{
    partial class OrderForm
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
            label2 = new Label();
            txtFirstname = new TextBox();
            btnOrder = new Button();
            txtLastname = new TextBox();
            label3 = new Label();
            txtPhoneNumber = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            txtDistrict = new TextBox();
            label7 = new Label();
            txtProvince = new TextBox();
            label8 = new Label();
            txtCity = new TextBox();
            label9 = new Label();
            txtDiscount = new TextBox();
            label10 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 3;
            label1.Text = "Nhập thông tin hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 60);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 4;
            label2.Text = "Họ";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(137, 57);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(100, 23);
            txtFirstname.TabIndex = 5;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(270, 263);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(129, 36);
            btnOrder.TabIndex = 6;
            btnOrder.Text = "Xuất hóa đơn";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(137, 103);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(100, 23);
            txtLastname.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 106);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 7;
            label3.Text = "Tên";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(137, 158);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 161);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 9;
            label4.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(137, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 214);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(367, 57);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(282, 60);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 13;
            label6.Text = "Địa chỉ";
            // 
            // txtDistrict
            // 
            txtDistrict.Location = new Point(367, 106);
            txtDistrict.Name = "txtDistrict";
            txtDistrict.Size = new Size(100, 23);
            txtDistrict.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(282, 109);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 15;
            label7.Text = "Thị trấn";
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(367, 158);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(100, 23);
            txtProvince.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(282, 161);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 17;
            label8.Text = "Quận/Huyện";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(367, 214);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(282, 217);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 19;
            label9.Text = "Thành phố";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(137, 271);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(100, 23);
            txtDiscount.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(52, 274);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 21;
            label10.Text = "Mã giảm giá";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(417, 274);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(85, 25);
            btnBack.TabIndex = 23;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 331);
            Controls.Add(btnBack);
            Controls.Add(txtDiscount);
            Controls.Add(label10);
            Controls.Add(txtCity);
            Controls.Add(label9);
            Controls.Add(txtProvince);
            Controls.Add(label8);
            Controls.Add(txtDistrict);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label4);
            Controls.Add(txtLastname);
            Controls.Add(label3);
            Controls.Add(btnOrder);
            Controls.Add(txtFirstname);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstname;
        private Button btnOrder;
        private TextBox txtLastname;
        private Label label3;
        private TextBox txtPhoneNumber;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtDistrict;
        private Label label7;
        private TextBox txtProvince;
        private Label label8;
        private TextBox txtCity;
        private Label label9;
        private TextBox txtDiscount;
        private Label label10;
        private Button btnBack;
    }
}