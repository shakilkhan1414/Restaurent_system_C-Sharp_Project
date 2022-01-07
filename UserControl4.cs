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
    public partial class UserControl4 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shakil\Documents\MyDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public UserControl4()
        {
            InitializeComponent();
        }
        string avl;
        public void available(string s)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + s + "'";
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    avl = srd["availibility"].ToString();

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Availibility check error!!");
            }

        }
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            available(label8.Text);
            if (avl == "1")
            {
                var parent = this.Parent as Form4;
                parent.id = label7.Text;
                parent.iname = label8.Text;
                parent.totalItem();
            }
            else if (avl == "0")
            {
                Form12 f12 = new Form12();
                f12.ShowDialog();
            }

            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            available(label6.Text);
            if (avl == "1")
            {
                var parent = this.Parent as Form4;
                parent.id = label5.Text;
                parent.iname = label6.Text;
                parent.totalItem();
            }
            else if (avl == "0")
            {
                Form12 f12 = new Form12();
                f12.ShowDialog();
            }

            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            available(label2.Text);
            if (avl == "1")
            {
                var parent = this.Parent as Form4;
                parent.id = label1.Text;
                parent.iname = label2.Text;
                parent.totalItem();
            }
            else if (avl == "0")
            {
                Form12 f12 = new Form12();
                f12.ShowDialog();
            }

            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            available(label3.Text);
            if (avl == "1")
            {
                var parent = this.Parent as Form4;
                parent.id = label3.Text;
                parent.iname = label4.Text;
                parent.totalItem();
            }
            else if (avl == "0")
            {
                Form12 f12 = new Form12();
                f12.ShowDialog();
            }

            
        }
    }
}
