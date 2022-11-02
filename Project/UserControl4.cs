using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
            addmenu f7 = new addmenu();
            f7.ShowDialog();
            f7 = null;
            this.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            addemployee f8 = new addemployee();
            f8.ShowDialog();
            f8 = null;
            this.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.ShowDialog();
            f16 = null;
            this.Show();
        }
    }
}
