using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Food_Delivery
{
    public partial class UserControl8 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shakil\Documents\MyDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public UserControl8()
        {
            InitializeComponent();
        }

        public void loadcustomer()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [dbo].[order] ";
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void UserControl8_Load(object sender, EventArgs e)
        {
            loadcustomer();
        }
    }
}
