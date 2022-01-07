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
    public partial class Form13 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shakil\Documents\MyDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public Form13()
        {
            InitializeComponent();
        }
        public string j;
        

        public void loadusername()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select username from [dbo].[user] where name='" + j + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                string s = sr["username"].ToString();
                jMaterialTextbox4.TextName = s;

            }
            con.Close();
        }
        public void loademail()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select email from [dbo].[user] where name='" + j + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                string s = sr["email"].ToString();
                jMaterialTextbox2.TextName = s;

            }
            con.Close();

        }
        public void loadpass()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select password from [dbo].[user] where name='" + j + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                string s = sr["password"].ToString();
                jMaterialTextbox3.TextName = s;

            }
            con.Close();

        }

        public void loadgender()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select gender from [dbo].[user] where name='" + j + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                string s = sr["gender"].ToString();
                if(s=="Male")
                {
                    radioButton1.Checked=true;
                }
                else if(s=="Female")
                {
                    radioButton3.Checked = true;
                }

            }
            con.Close();

        }

        public void loadDOB()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select DOB from [dbo].[user] where name='" + j + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                string s = sr["DOB"].ToString();
                bunifuDatepicker1.Value = Convert.ToDateTime(s);
 
            }
            con.Close();

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            jMaterialTextbox1.TextName = j;
            loadusername();
            loademail();
            loadpass();loadgender();
            loadDOB();
        }
        public void setname()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [dbo].[user] set name='" + jMaterialTextbox1.TextName + "' where username='" + jMaterialTextbox4.TextName + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                
            }
        }
        public void setemail()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [dbo].[user] set email='" + jMaterialTextbox2.TextName + "' where username='" + jMaterialTextbox4.TextName + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void setpass()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [dbo].[user] set password='" + jMaterialTextbox3.TextName + "' where username='" + jMaterialTextbox4.TextName + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void setDOB()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [dbo].[user] set DOB='" + bunifuDatepicker1.Value + "' where username='" + jMaterialTextbox4.TextName + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void setgender()
        {
            if(radioButton1.Checked==true)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update [dbo].[user] set gender='" + "Male" + "' where username='" + jMaterialTextbox4.TextName + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {

                }
            }
            else if(radioButton3.Checked==true)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update [dbo].[user] set gender='" + "Female" + "' where username='" + jMaterialTextbox4.TextName + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            setname();
            setemail();
            setpass();
            setDOB();
            setgender();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
