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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuProgressBar1.Value += 1;
            if(bunifuProgressBar1.Value==100)
            {
                timer1.Stop();
                Form2 f1 = new Form2();
                f1.Show();
                this.Hide();
            }
        }
    }
}
