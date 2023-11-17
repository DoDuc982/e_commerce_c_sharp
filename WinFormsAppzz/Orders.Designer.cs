namespace WinFormsAppzz
{
    partial class Orders
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
            label2 = new Label();
            txtId = new TextBox();
            btnSearchInfo = new Button();
            btnSearch = new Button();
            label1 = new Label();
            dgvOrders = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnSearchInfo);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1158, 79);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(959, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(123, 41);
            btnBack.TabIndex = 7;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 29);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 6;
            label2.Text = "Mã đơn hàng";
            // 
            // txtId
            // 
            txtId.Location = new Point(362, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            // 
            // btnSearchInfo
            // 
            btnSearchInfo.Location = new Point(675, 12);
            btnSearchInfo.Name = "btnSearchInfo";
            btnSearchInfo.Size = new Size(126, 44);
            btnSearchInfo.TabIndex = 4;
            btnSearchInfo.Text = "Xem thông tin đơn";
            btnSearchInfo.UseVisualStyleBackColor = true;
            btnSearchInfo.Click += btnSearchInfo_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(512, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 44);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm đơn hàng";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 2;
            label1.Text = "Quản lý đơn hàng";
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(0, 79);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowTemplate.Height = 25;
            dgvOrders.Size = new Size(1158, 371);
            dgvOrders.TabIndex = 1;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            dgvOrders.RowEnter += dgvOrders_RowEnter;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 450);
            Controls.Add(dgvOrders);
            Controls.Add(panel1);
            Name = "Orders";
            Text = "Quản lý hóa đơn";
            Load += Orders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvOrders;
        private Label label2;
        private TextBox txtId;
        private Button btnSearchInfo;
        private Button btnSearch;
        private Label label1;
        private Button btnBack;
    }
}