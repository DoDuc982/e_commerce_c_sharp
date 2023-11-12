using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsAppzz
{
    public partial class CartForm : Form
    {
        private DataTable dt;
        private CartItem ci;
        public CartForm()
        {
            InitializeComponent();
            Functions.Function.Connect();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Nineshop nineshop = new Nineshop();
            nineshop.Show();
            this.Hide();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Hide();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            string sql;
            sql = "  SELECT p.name, p.price, p.discount_price, c.quantity, ca.content FROM cart_item c inner join (product p inner join category ca on p.category_id = ca.id)  on c.product_id = p.id";
            dt = Functions.Function.GetDataToTable(sql);
            dgvProduct.DataSource = dt;
            dgvProduct.Columns[0].HeaderText = "Tên sản phẩm";
            dgvProduct.Columns[1].HeaderText = "Giá sản phẩm";
            dgvProduct.Columns[2].HeaderText = "Gía giảm";
            dgvProduct.Columns[3].HeaderText = "Số lượng";
            dgvProduct.Columns[4].HeaderText = "Danh mục";
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            retrieveCurrentRow(e);
        }

        private void dgvProduct_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            retrieveCurrentRow(e);
        }

        private void retrieveCurrentRow(DataGridViewCellEventArgs e)
        {
        }
    }
}
