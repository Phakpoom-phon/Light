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
    public partial class UserControl3 : UserControl
    {
        
        public static string txt;
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            userControl51.Show();
            userControl41.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            userControl41.Show();
            userControl51.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }



        private void UserControl3_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Text = "เวลาเข้างาน : "+DateTime.Now.ToString("h:mm tt");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.Text == "เปิดกะการขาย")
            {
                Form18 f18 = new Form18();
                f18.ShowDialog();
                if (txt == "0.00")
                {
                    //label1.Text = txt;
                    DialogResult withdrawal = MessageBox.Show("คุณต้องการเปิดกะการขายด้วยเงินถอน 0.00 หรือไม่่", "เปิดกะการขาย", MessageBoxButtons.YesNo);
                    if (withdrawal == DialogResult.Yes)
                    {
                        button19.BackColor = Color.FromArgb(255, 128, 128);
                        button19.Text = "ปิดกะการขาย";
                    }
                    else if (withdrawal == DialogResult.No)
                    {
                        button19.BackColor = Color.FromArgb(128, 255, 128);
                        button19.Text = "เปิดกะการขาย";
                    }
                }
                else
                {
                    button19.BackColor = Color.FromArgb(255, 128, 128);
                    button19.Text = "ปิดกะการขาย";
                }
                
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("คุณต้องการปิดกะการขายหรือไม่", "ปิดกะการขาย", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Form17 f17 = new Form17();
                    f17.ShowDialog();
                    f17 = null;
                    this.Show();
                    //button19.BackColor = Color.FromArgb(128, 255, 128);
                    //button19.Text = "เปิดกะการขาย";
                }
                else if (dialogResult == DialogResult.No)
                {
                    //button19.BackColor = Color.FromArgb(255, 128, 128);
                    //button19.Text = "ปิดกะการขาย";
                    
                }
            }
        }
    }
}
