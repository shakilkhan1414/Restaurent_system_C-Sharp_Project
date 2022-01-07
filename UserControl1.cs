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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        //public String id { get { return "ddd"; } }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form4;
            
            parent.UC2();
        }
    }
}
