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
    public partial class Form15 : Form
    {
        public string total;
        
        public Form15()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            textBox1.Text = total;
            label4.Text = total;
            textBox3.Text = "-" + total;
            //int txt1 = 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = 1000;
            int num3 = num1 - num2;
            int num4 = int.Parse(textBox2.Text);
            int num5 = num2 + num4;
            int num6 = int.Parse(textBox3.Text);
            int num7 = num6 + num2;
            textBox1.Text = num3.ToString();
            textBox2.Text = num5.ToString();
            textBox3.Text = num7.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = 500;
            int num3 = num1 - num2;
            int num4 = int.Parse(textBox2.Text);
            int num5 = num2 + num4;
            int num6 = int.Parse(textBox3.Text);
            int num7 = num6 + num2;
            textBox1.Text = num3.ToString();
            textBox2.Text = num5.ToString();
            textBox3.Text = num7.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = 100;
            int num3 = num1 - num2;
            int num4 = int.Parse(textBox2.Text);
            int num5 = num2 + num4;
            int num6 = int.Parse(textBox3.Text);
            int num7 = num6 + num2;
            textBox1.Text = num3.ToString();
            textBox2.Text = num5.ToString();
            textBox3.Text = num7.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = 50;
            int num3 = num1 - num2;
            int num4 = int.Parse(textBox2.Text);
            int num5 = num2 + num4;
            int num6 = int.Parse(textBox3.Text);
            int num7 = num6 + num2;
            textBox1.Text = num3.ToString();
            textBox2.Text = num5.ToString();
            textBox3.Text = num7.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = 20;
            int num3 = num1 - num2;
            int num4 = int.Parse(textBox2.Text);
            int num5 = num2 + num4;
            int num6 = int.Parse(textBox3.Text);
            int num7 = num6 + num2;
            textBox1.Text = num3.ToString();
            textBox2.Text = num5.ToString();
            textBox3.Text = num7.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = 10;
            int num3 = num1 - num2;
            int num4 = int.Parse(textBox2.Text);
            int num5 = num2 + num4;
            int num6 = int.Parse(textBox3.Text);
            int num7 = num6 + num2;
            textBox1.Text = num3.ToString();
            textBox2.Text = num5.ToString();
            textBox3.Text = num7.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = 5;
            int num3 = num1 - num2;
            int num4 = int.Parse(textBox2.Text);
            int num5 = num2 + num4;
            int num6 = int.Parse(textBox3.Text);
            int num7 = num6 + num2;
            textBox1.Text = num3.ToString();
            textBox2.Text = num5.ToString();
            textBox3.Text = num7.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = 2;
            int num3 = num1 - num2;
            int num4 = int.Parse(textBox2.Text);
            int num5 = num2 + num4;
            int num6 = int.Parse(textBox3.Text);
            int num7 = num6 + num2;
            textBox1.Text = num3.ToString();
            textBox2.Text = num5.ToString();
            textBox3.Text = num7.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = 1;
            int num3 = num1 - num2;
            int num4 = int.Parse(textBox2.Text);
            int num5 = num2 + num4;
            int num6 = int.Parse(textBox3.Text);
            int num7 = num6 + num2;
            textBox1.Text = num3.ToString();
            textBox2.Text = num5.ToString();
            textBox3.Text = num7.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox1.Text);
            int num3 = num1 - num2;
            int num4 = int.Parse(label4.Text);
            textBox1.Text = num3.ToString();
            textBox2.Text = num4.ToString();
            textBox3.Text = num3.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                Management.E_B_table = "ว่าง";
                this.Close();
                
            }
            else
            {
                MessageBox.Show(textBox1.Text);
                Management.E_B_table = "ว่าง";
                this.Close();
                

            }
        }
    }
}
