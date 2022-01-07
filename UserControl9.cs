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
    public partial class UserControl9 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shakil\Documents\MyDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public UserControl9()
        {
            InitializeComponent();
        }
        public void changePrice1(string s)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [dbo].[item] set availibility='" + 1 + "' where item_name='" + s + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Change Failed");
            }
        }
        public void changePrice2(string s)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [dbo].[item] set availibility='" + 0 + "' where item_name='" + s + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Change Failed");
            }
        }

        public void burger()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label1.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch1.Value = true;
                }
                else if(s=="0")
                {
                    bunifuiOSSwitch1.Value = false;
                }

            }
            con.Close();
        }


        public void crispy()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label6.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch2.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch2.Value = false;
                }

            }
            con.Close();
        }

        public void french()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label8.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch3.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch3.Value = false;
                }

            }
            con.Close();
        }

        public void sandwich()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label14.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch4.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch4.Value = false;
                }

            }
            con.Close();
        }

        public void pizza()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label4.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch5.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch5.Value = false;
                }

            }
            con.Close();
        }

        public void fried()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label10.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch6.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch6.Value = false;
                }

            }
            con.Close();
        }

        public void pasta()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label12.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch7.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch7.Value = false;
                }

            }
            con.Close();
        }

        public void beef()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label16.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch8.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch8.Value = false;
                }

            }
            con.Close();
        }

        public void pudding()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label3.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch9.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch9.Value = false;
                }

            }
            con.Close();
        }

        public void cake()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label2.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch10.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch10.Value = false;
                }

            }
            con.Close();
        }

        public void sweet()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label7.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch11.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch11.Value = false;
                }

            }
            con.Close();
        }
        public void ice()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label5.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch12.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch12.Value = false;
                }

            }
            con.Close();
        }
        public void tea()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label9.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch13.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch13.Value = false;
                }

            }
            con.Close();
        }
        public void cold()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label11.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch14.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch14.Value = false;
                }

            }
            con.Close();
        }
        public void juice()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label15.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch15.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch15.Value = false;
                }

            }
            con.Close();
        }
        public void coffie()
        {
            string s;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select availibility from [dbo].[item] where item_name='" + label15.Text + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                s = sr["availibility"].ToString();
                if (s == "1")
                {
                    bunifuiOSSwitch16.Value = true;
                }
                else if (s == "0")
                {
                    bunifuiOSSwitch16.Value = false;
                }

            }
            con.Close();
        }


        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if(bunifuiOSSwitch1.Value==true)
            {
                changePrice1(label1.Text);
            }
            else if(bunifuiOSSwitch1.Value == false)
            {
                changePrice2(label1.Text);
            }
        }

        private void bunifuiOSSwitch2_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch2.Value == true)
            {
                changePrice1(label6.Text);
            }
            else if (bunifuiOSSwitch2.Value == false)
            {
                changePrice2(label6.Text);
            }
        }

        private void bunifuiOSSwitch3_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch3.Value == true)
            {
                changePrice1(label8.Text);
            }
            else if (bunifuiOSSwitch3.Value == false)
            {
                changePrice2(label8.Text);
            }
        }

        private void bunifuiOSSwitch4_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch4.Value == true)
            {
                changePrice1(label14.Text);
            }
            else if (bunifuiOSSwitch4.Value == false)
            {
                changePrice2(label14.Text);
            }
        }

        private void bunifuiOSSwitch5_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch5.Value == true)
            {
                changePrice1(label4.Text);
            }
            else if (bunifuiOSSwitch5.Value == false)
            {
                changePrice2(label4.Text);
            }
        }

        private void bunifuiOSSwitch6_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch6.Value == true)
            {
                changePrice1(label10.Text);
            }
            else if (bunifuiOSSwitch6.Value == false)
            {
                changePrice2(label10.Text);
            }
        }

        private void bunifuiOSSwitch7_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch7.Value == true)
            {
                changePrice1(label12.Text);
            }
            else if (bunifuiOSSwitch7.Value == false)
            {
                changePrice2(label12.Text);
            }
        }

        private void bunifuiOSSwitch8_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch8.Value == true)
            {
                changePrice1(label16.Text);
            }
            else if (bunifuiOSSwitch8.Value == false)
            {
                changePrice2(label16.Text);
            }
        }

        private void bunifuiOSSwitch9_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch9.Value == true)
            {
                changePrice1(label3.Text);
            }
            else if (bunifuiOSSwitch9.Value == false)
            {
                changePrice2(label3.Text);
            }
        }

        private void bunifuiOSSwitch10_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch10.Value == true)
            {
                changePrice1(label2.Text);
            }
            else if (bunifuiOSSwitch10.Value == false)
            {
                changePrice2(label2.Text);
            }
        }

        private void bunifuiOSSwitch11_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch11.Value == true)
            {
                changePrice1(label7.Text);
            }
            else if (bunifuiOSSwitch11.Value == false)
            {
                changePrice2(label7.Text);
            }
        }

        private void bunifuiOSSwitch12_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch12.Value == true)
            {
                changePrice1(label5.Text);
            }
            else if (bunifuiOSSwitch12.Value == false)
            {
                changePrice2(label5.Text);
            }
        }

        private void bunifuiOSSwitch13_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch13.Value == true)
            {
                changePrice1(label9.Text);
            }
            else if (bunifuiOSSwitch13.Value == false)
            {
                changePrice2(label9.Text);
            }
        }

        private void bunifuiOSSwitch14_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch14.Value == true)
            {
                changePrice1(label11.Text);
            }
            else if (bunifuiOSSwitch14.Value == false)
            {
                changePrice2(label11.Text);
            }
        }

        private void bunifuiOSSwitch15_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch15.Value == true)
            {
                changePrice1(label15.Text);
            }
            else if (bunifuiOSSwitch15.Value == false)
            {
                changePrice2(label15.Text);
            }
        }

        private void bunifuiOSSwitch16_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch16.Value == true)
            {
                changePrice1(label13.Text);
            }
            else if (bunifuiOSSwitch16.Value == false)
            {
                changePrice2(label13.Text);
            }
        }

        private void UserControl9_Load(object sender, EventArgs e)
        {
            burger();
            crispy();
            french();
            sandwich();
            fried();
            pizza();
            pasta();
            beef();
            pudding();
            cake();
            sweet();
            ice();
            tea();
            cold();
            juice();
            coffie();
        }
    }
}
