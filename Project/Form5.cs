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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "ค้นหารายการอาหาร")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "ค้นหารายการอาหาร";

                textBox1.ForeColor = Color.Silver;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calcu f9 = new calcu();
            f9.ShowDialog();
            f9 = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edittable f10 = new edittable();
            f10.ShowDialog();
            f10 = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addnumber f11 = new addnumber();
            f11.ShowDialog();
            f11 = null;
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addedit f12 = new addedit();
            f12.ShowDialog();
            f12 = null;
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.ShowDialog();
            f14 = null;
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.ShowDialog();
            f15 = null;
            this.Show();
        }
    }
}
