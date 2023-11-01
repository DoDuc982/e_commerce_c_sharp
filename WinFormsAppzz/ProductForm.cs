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
        DataTable? tblCategory;
        public ProductForm()
        {
            InitializeComponent();
            Functions.Function.Connect();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "" || txtImage.Text == "" || txtContent.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Thiếu thông tin sản phẩm");
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
                    MessageBox.Show("Thêm sản phẩm thành công");
                    loadDataGridView();
                    ResetValue();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            string imageUrl = txtImage.Text;
            string content = txtContent.Text;
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int soldQuantity = Convert.ToInt32(txtSoldQuantity.Text);
            decimal discountPrice = Convert.ToDecimal(txtDiscountPrice.Text);
            DateTime updated_on = DateTime.Now;
            try
            {
                string sql = "update product set name= '" + name + "', price = " + price + ", image_url='" + imageUrl + "',content = '" + content + "',quantity = " + quantity + ",sold_quantity = " + soldQuantity + ",discount_price = " + discountPrice + ", updated_on = '" + updated_on + "' where id = " + txtId.Text;
                Functions.Function.RunSQL(sql);
                MessageBox.Show("Sửa sản phẩm thành công");
                loadDataGridView();
                ResetValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                loadDataGridView();
                return;
            }
            else
            {
                int id = Convert.ToInt16(txtId.Text);
                string sql;
                sql = "DELETE FROM product where id = " + id;
                try
                {
                    Functions.Function.RunSQL(sql);
                    MessageBox.Show("Xóa sản phẩm thành công");
                    loadDataGridView();
                    ResetValue();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
            dgvProduct.Columns["id"].HeaderText = "Mã";
            dgvProduct.Columns["name"].HeaderText = "Tên sản phẩm";
            dgvProduct.Columns["price"].HeaderText = "Giá sản phẩm";
            dgvProduct.Columns["image_url"].HeaderText = "Link ảnh";
            dgvProduct.Columns["quantity"].HeaderText = "Số lượng";
            dgvProduct.Columns["content"].HeaderText = "Nội dung";
            dgvProduct.Columns["sold_quantity"].HeaderText = "Số lượng bán";
            dgvProduct.Columns["discount_price"].HeaderText = "Giá giảm";
            dgvProduct.Columns["created_on"].HeaderText = "Tạo ngày";
            dgvProduct.Columns["updated_on"].HeaderText = "Sửa ngày";
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.EditMode = DataGridViewEditMode.EditProgrammatically;

            tblCategory = Functions.Function.GetDataToTable("SELECT id, content FROM category");
            cbCategory.DataSource = tblCategory;
            cbCategory.DisplayMember = "content";
            cbCategory.ValueMember = "id";
        }
        private void findDataGridView()
        {
            if (txtId.Text == "")
            {
                loadDataGridView();
                return;
            }
            else
            {
                int id = Convert.ToInt16(txtId.Text);
                string sql;
                sql = "SELECT * FROM product where id = " + id;
                tblCL = Functions.Function.GetDataToTable(sql);
                dgvProduct.DataSource = tblCL;
                dgvProduct.Columns["id"].HeaderText = "Mã";
                dgvProduct.Columns["name"].HeaderText = "Tên sản phẩm";
                dgvProduct.Columns["price"].HeaderText = "Giá sản phẩm";
                dgvProduct.Columns["image_url"].HeaderText = "Link ảnh";
                dgvProduct.Columns["quantity"].HeaderText = "Số lượng";
                dgvProduct.Columns["content"].HeaderText = "Nội dung";
                dgvProduct.Columns["sold_quantity"].HeaderText = "Số lượng bán";
                dgvProduct.Columns["discount_price"].HeaderText = "Giá giảm";
                dgvProduct.Columns["created_on"].HeaderText = "Tạo ngày";
                dgvProduct.Columns["updated_on"].HeaderText = "Sửa ngày";
                dgvProduct.AllowUserToAddRows = false;
                dgvProduct.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
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



        private void btnFind_Click(object sender, EventArgs e)
        {
            findDataGridView();

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];

                txtId.Text = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtImage.Text = row.Cells["image_url"].Value.ToString();
                txtContent.Text = row.Cells["content"].Value.ToString();
                txtPrice.Text = row.Cells["price"].Value.ToString();
                txtQuantity.Text = row.Cells["quantity"].Value.ToString();
            }
        }

        private void cbCategory_index(object sender, EventArgs e)
        {

        }
    }
}
