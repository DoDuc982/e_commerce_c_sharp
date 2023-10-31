using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsAppzz.Functions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppzz
{
    public partial class ProductForm : Form
    {
        DataTable? tblCL;
        public ProductForm()
        {
            InitializeComponent();
            Functions.Function.Connect();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "" || txtImage.Text == "" || txtContent.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Thiếu thông tin");
            }
            else
            {
                string name = txtName.Text;
                decimal price = Convert.ToDecimal(txtPrice.Text);
                string imageUrl = txtImage.Text;
                string content = txtContent.Text;
                int quantity = Convert.ToInt32(txtQuantity.Text);
                DateTime createdOn = DateTime.Now;
                try
                {
                    string sql = "INSERT INTO product(name, price, image_url, content, quantity, created_on) VALUES ('" + name + "', " + price + ",'" + imageUrl + "','" + content + "'," + quantity + ",'" + createdOn + "')";
                    Functions.Function.RunSQL(sql);
                    loadDataGridView();
                    ResetValue();
                }
                catch
                {
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Functions.Function.Disconnect();
            AllFunction allFunctionForm = new AllFunction();
            allFunctionForm.Show();
            this.Hide();
        }

        private void load(object sender, EventArgs e)
        {
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM product";
            tblCL = Functions.Function.GetDataToTable(sql);
            dgvProduct.DataSource = tblCL;         
            dgvProduct.Columns[0].HeaderText = "Mã";
            dgvProduct.Columns[1].HeaderText = "Tên sản phẩm";
            dgvProduct.Columns[2].HeaderText = "Giá sản phẩm";
            dgvProduct.Columns[3].HeaderText = "Link ảnh";
            dgvProduct.Columns[4].HeaderText = "Số lượng";
            dgvProduct.Columns[5].HeaderText = "Nội dung";
            dgvProduct.Columns[6].HeaderText = "Số lượng bán";
            dgvProduct.Columns[7].HeaderText = "Giá giảm";
            dgvProduct.Columns[8].HeaderText = "Tạo ngày";
            dgvProduct.Columns[9].HeaderText = "Sửa ngày";
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValue()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtImage.Text = "";
            txtContent.Text = "";
            txtDiscountPrice.Text = "";
            txtQuantity.Text = "";
        }

    }
}
