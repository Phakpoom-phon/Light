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
    public partial class Form14 : Form
    {
        public string txt_listview1;
        public Form14()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+ไข่ดาว";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+ไข่เจียว";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+เผ็ดน้อย";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+เผ็ดมาก";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+ไม่ใส่พริก";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+ไม่ใส่ผงชูรส";
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            label4.Text = txt_listview1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orderfood.update_listview = textBox1.Text;
            this.Close();
        }
    }
}
