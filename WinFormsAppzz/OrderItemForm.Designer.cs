namespace WinFormsAppzz
{
    partial class OrderItemForm
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
            label1 = new Label();
            dgvOrderItem = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItem).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 85);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(572, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 34);
            btnBack.TabIndex = 4;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 25);
            label1.TabIndex = 3;
            label1.Text = "Các mặt hàng có trong đơn";
            // 
            // dgvOrderItem
            // 
            dgvOrderItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItem.Dock = DockStyle.Fill;
            dgvOrderItem.Location = new Point(0, 85);
            dgvOrderItem.Name = "dgvOrderItem";
            dgvOrderItem.RowTemplate.Height = 25;
            dgvOrderItem.Size = new Size(800, 365);
            dgvOrderItem.TabIndex = 1;
            // 
            // OrderItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvOrderItem);
            Controls.Add(panel1);
            Name = "OrderItemForm";
            Text = "OrderItemForm";
            Load += OrderItemForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvOrderItem;
        private Button btnBack;
        private Label label1;
    }
}