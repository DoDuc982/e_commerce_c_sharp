using System.Data;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsAppzz
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CNFJ930U;Initial Catalog=e_commerce;Integrated Security=True");

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txtUsername.Text;
            password = txtPassword.Text;
            try
            {
                String query = "SELECT * FROM customer WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    AllFunction allFunctionForm = new AllFunction();
                    allFunctionForm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}