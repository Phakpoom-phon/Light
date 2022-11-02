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
    public partial class ZoneShrimp : UserControl
    {
        public ZoneShrimp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberCustomer f3 = new NumberCustomer();
            f3.ShowDialog();
        }
    }
}
