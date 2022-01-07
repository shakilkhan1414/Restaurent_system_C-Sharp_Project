using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Food_Delivery
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            userControl91.BringToFront();
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("dd-MMM-yyyy  hh:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f22 = new Form2();
            f22.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl91.BringToFront();
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl101.BringToFront();
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl81.BringToFront();
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
        }

        
    }
}
