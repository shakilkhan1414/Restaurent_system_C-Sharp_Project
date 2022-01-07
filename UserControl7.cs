using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Food_Delivery
{
    public partial class UserControl7 : UserControl
    {
        public string it3;
        public UserControl7()
        {
            InitializeComponent();
           
        }

        private void UserControl7_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                if(bunifuMetroTextbox1.Text=="")
                {
                    MessageBox.Show("Enter Address!");
                }
                else
                {
                    var parent = this.Parent as Form4;
                    parent.checkdata(bunifuMetroTextbox1.Text);
                    parent.hidefunc();
                    parent.all();
                    Form6 f6 = new Form6();
                    f6.ShowDialog();
                }
            }
            else if(radioButton2.Checked==true)
            {
                if (bunifuMetroTextbox1.Text == "")
                {
                    MessageBox.Show("Enter Address!");
                }
                else
                {
                    var parent = this.Parent as Form4;
                    parent.checkdata1(bunifuMetroTextbox1.Text);
                    parent.hidefunc();
                    parent.all();
                    Form8 f8 = new Form8();
                    f8.ShowDialog();
                }
            }
        }
    }
}
