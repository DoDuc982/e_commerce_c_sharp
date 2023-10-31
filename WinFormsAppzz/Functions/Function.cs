using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsAppzz.Functions
{
    internal class Function
    {
        public static SqlConnection Con;       

        public static void Connect()
        {
            Con = new SqlConnection(@"Data Source=LAPTOP-CNFJ930U;Initial Catalog=e_commerce;Integrated Security=True"); 
            Con.Open();       
            if (Con.State == ConnectionState.Open) MessageBox.Show("Kết nối thành công");
            else MessageBox.Show("Không thể kết nối với dữ liệu");

        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
                Con.Dispose(); 	
                Con = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = Function.Con;
            dap.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
        public static void RunSQL(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
    }
}
