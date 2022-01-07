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
    public partial class Form9 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shakil\Documents\MyDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public Form9()
        {
            InitializeComponent();
        }
        public void close()
        {
            this.Hide();
        }
      
        public void item1(string s,string i,string j)
        {
            label7.Text = s;
            label1.Text = i + "$";
            label13.Text = "------ "+j + "$";
        }
        public void item2(string ss, string i, string j)
        {
            label6.Text = ss;
            label1.Text = i + "$";
            label12.Text = "------ " + j + "$";
        }
        public void item3(string ss, string i, string j)
        {
            label5.Text = ss;
            label1.Text = i + "$";
            label11.Text = "------ " + j+"$";
        }
        public void item4(string ss, string i, string j)
        {
            label4.Text = ss;
            label1.Text = i + "$";
            label10.Text = "------ " + j + "$";
        }
        public void item5(string ss, string i, string j)
        {
            label3.Text = ss;
            label1.Text = i + "$";
            label9.Text = "------ " + j + "$";
        }
        public void allclear()
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label7.Text = "";
            label1.Text = "0";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
