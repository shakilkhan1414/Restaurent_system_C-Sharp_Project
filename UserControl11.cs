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
    public partial class UserControl11 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shakil\Documents\MyDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public UserControl11()
        {
            InitializeComponent();
        }

        
        public void loadorder(string a)
        {
    
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [dbo].[order] where Customer_name='"+ a+ "' ";
            
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
                con.Close();
           

        }

        private void UserControl11_Load(object sender, EventArgs e)
        {
        
        }
    }
}
