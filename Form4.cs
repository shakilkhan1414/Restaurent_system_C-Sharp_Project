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
    public partial class Form4 : Form
    {
        SqlConnection con=new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Shakil\Documents\MyDatabase.mdf;Integrated Security = True; Connect Timeout = 30");
        public Form4()
        {
            InitializeComponent();
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            userControl11.BringToFront();

        }
        Form9 f9 = new Form9();
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            userControl11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
            userControl21.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
            userControl31.BringToFront();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
            userControl41.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Height = button6.Height;
            panel4.Top = button6.Top;
            userControl11.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel4.Height = button7.Height;
            panel4.Top = button7.Top;
            userControl51.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel4.Height = button8.Height;
            panel4.Top = button8.Top;
            userControl61.BringToFront();

        }
        public void clearfunc()
        {
            label6.Text = "0";
            label5.Text = "0";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f22 = new Form2();
            f22.Show();
            this.Hide();
            f9.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("dd-MMM-yyyy  hh:mm:ss tt");

        }
       

        public void hname(string headname)
        {
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name from [dbo].[user] where username='" + headname + "'";
            SqlDataReader sr = cmd.ExecuteReader();
            while(sr.Read())
            {
                string s = sr["name"].ToString();
                name = s;
                label2.Text = "Welcome " + s + " !";

            }
            con.Close();
       
        }

        
        string name;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            panel4.Height = 0;
            userControl71.BringToFront();
    
        }
        public void hidefunc()
        {
            f9.Hide();
        }
        public string dd;
        
        public String id{
           set { dd = value; }
        }
        public void UC2()
        {
            userControl21.BringToFront();
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
            
        }
        public void totalItem()
        {
            int tot = Int32.Parse(label6.Text);
            if(tot==5)
            {
                Form10 f10 = new Form10();
                f10.ShowDialog();
            }
            else
            {
                tot = tot + 1;
                label6.Text = tot.ToString();
                int totPrice = Int32.Parse(label5.Text);
                totPrice = totPrice + Int32.Parse(dd);
                label5.Text = totPrice.ToString();
                checkout();
            }
            
            
        }
        public void checkdata(string a)
        {
            Random r=new Random();
            string s = label5.Text;
           
            
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [dbo].[order] values('" + name + "','" + order + "','" + label5.Text + "','" + a + "','" + time.Text + "','" + r.Next(100000, 900000) +"')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    Form7 f7 = new Form7();
                    f7.ShowDialog();
                }
     
        }

        public void checkdata1(string a)
        {
            Random r = new Random();          
            int i = Int32.Parse(label5.Text);
            var dis = i-((i*10)/100);
            string s = dis.ToString();

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [dbo].[order] values('" + name + "','" + order + "','" + s + "','" + a + "','" + time.Text + "','" + r.Next(100000, 900000) + "')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Form7 f7 = new Form7();
                f7.ShowDialog();
            }

        }



        String getname;
        public String iname
        {
            set { getname = value; }
        }
        
        string order="";
        public void checkout()
        {
            
            if(Int32.Parse(label6.Text)==1)
            {
                string s =getname;
                string i = label5.Text;
                order = order+ getname;
                f9.item1(s,i,dd); 
                f9.Show();

            }
            else if (Int32.Parse(label6.Text) == 2)
            {
                string s = getname;
                string i = label5.Text;
                order = order + "+" + getname;
                f9.item2(s,i, dd);
                f9.Show();
            }
            else if (Int32.Parse(label6.Text) == 3)
            {
                string s = getname;
                string i = label5.Text;
                order = order + "+" + getname;
                f9.item3(s,i, dd);
                f9.Show();
            }
            else if (Int32.Parse(label6.Text) == 4)
            {
                string s = getname;
                string i = label5.Text;
                order = order + "+" + getname;
                f9.item4(s,i, dd);
                f9.Show();
            }
            else if (Int32.Parse(label6.Text) == 5)
            {
                string s = getname;
                string i = label5.Text;
                order = order + "+" + getname;
                f9.item5(s,i, dd);
                f9.Show();
            }
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.j = name;
            
            f13.ShowDialog();
            
        }
        public void all()
        {
            clearfunc();
            order = "";
            f9.allclear();
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            all();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel4.Height = button11.Height;
            panel4.Top = button11.Top;
            userControl111.loadorder(name);
            userControl111.BringToFront();

        }
    }
}
