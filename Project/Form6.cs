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
    public partial class Form6 : Form
    {
        //public static Form6 instance;
        //public TextBox tb1;
        public Form6()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Management.txt1 = textBox1.Text;
            if (textBox1.Text == "")
            {
                MessageBox.Show("กรุณาใส่ชื่อโซน");
            }
            else
            {
                this.Close();
            }
            
            
        }

        
    }
}
