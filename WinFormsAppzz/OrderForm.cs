using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppzz
{
    public partial class OrderForm : Form
    {
        public static Order order;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Nineshop nineshop = new Nineshop();
            nineshop.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            order = new Order();
            order.firstname = txtFirstname.Text;
            order.lastname = txtLastname.Text;
            order.mobile = txtPhoneNumber.Text;
            order.email = txtEmail.Text;
            order.discount = txtDiscount.Text;
            order.address = txtAddress.Text;
            order.district = txtDistrict.Text;
            order.province = txtProvince.Text;
            order.city = txtCity.Text;
            OrderInfoForm orderInfoForm = new OrderInfoForm();
            orderInfoForm.Show();
            this.Hide();
        }
    }
}
