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
    public partial class Form2 : Form
    {
        public static string txt1;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form6 f6 = new Form6();
            f6.ShowDialog();
            if (txt1 == "")
            {
                //ยกเลิก(form6)
            }
            else
            {
            Button button = new Button();
            button.Text = txt1;
            button.Size = new Size(200, 50);// the size might be a bit small. You might want to increase it.
            button.Location = new Point();
            button.Visible = true;
            flowLayoutPanel1.Controls.Add(button);
            button.Click += createpanel_Click;
            }
        }

        public void createpanel_Click(object sender, EventArgs e)
        {
            //Panel panel = new Panel();
            //panel.Location = new Point(231, 136);
            //panel.Visible = true;
            //this.Controls.Add(panel);

            Button button1 = new Button();
            button1.Text = "เพิ่มโต๊ะ";
            button1.Size = new Size(100, 50);// the size might be a bit small. You might want to increase it.
            button1.Location = new Point(531, 360);
            button1.Visible = true;
            panel2.Controls.Add(button1);
            button1.Click += createbutton_Click;
            //panel.Controls.Add(createbutton_Click); 

        }
        int count = 1;
        int name = 1;
        int x = 0;
        int y = 0;
        public void createbutton_Click(object sender, EventArgs e)
        {
            if (count == 6)
            {
                y += 60;
                x -= 480;
                Button button2 = new Button();
                button2.Text = name.ToString();
                button2.Size = new Size(100, 50);// the size might be a bit small. You might want to increase it.
                button2.Location = new Point(22 , 15 + y );
                
                count++;
                name++;
                panel2.Controls.Add(button2);
                count -= 5;
                button2.Click += Customer_num;

            }
            else
            {
                Button button2 = new Button();
                button2.Text = name.ToString();
                button2.Size = new Size(100, 50);// the size might be a bit small. You might want to increase it.
                button2.Location = new Point(22 + x, 15 + y);
                x += 120;
                count++;
                name++;
                button2.Visible = true;
                panel2.Controls.Add(button2);
                button2.Click += Customer_num;
            }
            

        }
        public void Customer_num(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            f3 = null;
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            f4 = null;
            this.Show();
        }
    }
    }
