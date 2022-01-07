using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Food_Delivery
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shakil\Documents\MyDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [dbo].[user] where username='"+ jMaterialTextbox1.TextName+ "' and password='"+ jMaterialTextbox2.TextName+ "'";
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    if(jMaterialTextbox1.TextName=="admin")
                    {
                        Form5 f55 = new Form5();
                        f55.Show();
                        this.Hide();
                    }
                    else
                    {
                        Form4 f4 = new Form4();
                        f4.Show();
                        f4.hname(jMaterialTextbox1.TextName);
                        this.Hide();
                    }
                    
                }
                else
                {
                    Form11 f11 = new Form11();
                    f11.ShowDialog();
                }
                
                con.Close();
            }
            catch (Exception ex)
            {
                Form7 f7 = new Form7();
                f7.ShowDialog();
            }
            

        }
    }
}
