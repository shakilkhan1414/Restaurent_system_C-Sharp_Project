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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shakil\Documents\MyDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form2 f3 = new Form2();
            f3.Show();
            this.Hide();
        }
        string gender;
        public void getGender()
        {
            if (radioButton1.Checked == true)
            {
                gender = "Male";
            }
            else if (radioButton3.Checked == true)
            {
                gender = "Female";
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            getGender();
            if (jMaterialTextbox1.TextName == "Enter Name"|| jMaterialTextbox2.TextName== "Enter Username"|| jMaterialTextbox3.TextName== "Enter Password"|| jMaterialTextbox4.TextName== "Enter Email"|| bunifuDropdown1.selectedValue== "---Select Division---" || jMaterialTextbox1.TextName == "" || jMaterialTextbox2.TextName == "" || jMaterialTextbox3.TextName == "" || jMaterialTextbox4.TextName == "")
            {
                Form7 f7 = new Form7();
                f7.ShowDialog();
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [dbo].[user] values('" + jMaterialTextbox1.TextName + "','" + jMaterialTextbox2.TextName + "','" + jMaterialTextbox3.TextName + "','" + jMaterialTextbox4.TextName + "','" + gender + "','" + bunifuDatepicker1.Value + "','" + bunifuDropdown1.selectedValue + "')";
                    cmd.ExecuteNonQuery();
                    Form6 f6 = new Form6();
                    f6.ShowDialog();
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
}
