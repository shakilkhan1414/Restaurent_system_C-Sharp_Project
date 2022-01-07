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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(jMaterialTextbox1.TextName== "Enter Account no" || jMaterialTextbox2.TextName == "Enter Password")
            {
                MessageBox.Show("Enter account no and password!");
            }
            else
            {
                this.Hide();
                Form6 f6 = new Form6();
                f6.ShowDialog();

            }
        }
    }
}
