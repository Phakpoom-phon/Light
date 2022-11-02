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
    public partial class edittable : Form
    {
        public string txt;
        public static string changeTable;
        public edittable()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void changeTable_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = sender as Button;
            var test1 = button.Text;
            textBox1.Text = test1;
            //Console.WriteLine(test1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            var numbers = new List<string>() { "จ่ายสด", "กะชัง 1", "กะชัง 2", "กะชัง 3", "กะชัง 4",
                "กะชัง 5", "กะชัง 6", "กะชัง 7", "กะชัง 8", "กะชัง 9", "กะชัง 10", "กะชัง 11", "กะชัง 12", "กะชัง 13",
                "กะชัง 14", "กะชัง 15", "กะชัง 16", "กะชัง 17", "กะชัง 18", "กะชัง 19", "กะชัง 20", "กะชัง 21", "กะชัง 22", "กะชัง 23",
                "กะชัง 24", "กะชัง 25", "กะชัง 26", "กะชัง 27", "กะชัง 28", "กะชัง 29", "กะชัง 30" };
            for (int i = 0; i < numbers.Count; i++)
            {
                Button button = new Button();
                button.Text = numbers[i];
                button.Size = new Size(70, 40);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Name = x.ToString();
                x++;
                button.Click += changeTable_Click;
            }
        }

        private void edittable_Load(object sender, EventArgs e)
        {
            textBox1.Text = txt;
            int x = 0;
            var numbers = new List<string>() { "จ่ายสด", "กะชัง 1", "กะชัง 2", "กะชัง 3", "กะชัง 4", 
                "กะชัง 5", "กะชัง 6", "กะชัง 7", "กะชัง 8", "กะชัง 9", "กะชัง 10", "กะชัง 11", "กะชัง 12", "กะชัง 13", 
                "กะชัง 14", "กะชัง 15", "กะชัง 16", "กะชัง 17", "กะชัง 18", "กะชัง 19", "กะชัง 20", "กะชัง 21", "กะชัง 22", "กะชัง 23", 
                "กะชัง 24", "กะชัง 25", "กะชัง 26", "กะชัง 27", "กะชัง 28", "กะชัง 29", "กะชัง 30" };
            for (int i = 0;i < numbers.Count; i++)
            {
                Button button = new Button();
                button.Text = numbers[i];
                button.Size = new Size(70, 40);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Name = x.ToString();
                x++;
                button.Click += changeTable_Click;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            for (int i = 1; i < 8; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Size = new Size(70, 40);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Name = x.ToString();
                x++;
                button.Click += changeTable_Click;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            for (int i = 8; i <= 12; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Size = new Size(70, 40);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Name = x.ToString();
                x++;
                button.Click += changeTable_Click;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            for (int i = 13; i <= 26; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Size = new Size(70, 40);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Name = x.ToString();
                x++;
                button.Click += changeTable_Click;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            for (int i = 27; i <= 34; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Size = new Size(70, 40);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Name = x.ToString();
                x++;
                button.Click += changeTable_Click;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            for (int i = 35; i <= 41; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Size = new Size(70, 40);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Name = x.ToString();
                x++;
                button.Click += changeTable_Click;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            for (int i = 42; i <= 51; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Size = new Size(70, 40);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Name = x.ToString();
                x++;
                button.Click += changeTable_Click;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            for (int i = 52; i <= 68; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Size = new Size(70, 40);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Name = x.ToString();
                x++;
                button.Click += changeTable_Click;
            }
            int y = 0;
            var numbers = new List<string>() {"ซุ่ม 1", "ซุ่ม 2", "ซุ่ม 3", "ซุ่ม 4", "ซุ่ม 5", "ซุ่ม 6" };
            for (int i = 0; i < numbers.Count; i++)
            {
                Button button = new Button();
                button.Text = numbers[i];
                button.Size = new Size(70, 40);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Name = y.ToString();
                y++;
                button.Click += changeTable_Click;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            var numbers = new List<string>() { "VIP" };
            for (int i = 0; i < numbers.Count; i++)
            {
                Button button = new Button();
                button.Text = numbers[i];
                button.Size = new Size(70, 40);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Name = x.ToString();
                x++;
                button.Click += changeTable_Click;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            var numbers = new List<string>() { "ห้องจัดเลี้ยง" };
            for (int i = 0; i < numbers.Count; i++)
            {
                Button button = new Button();
                button.Text = numbers[i];
                button.Size = new Size(70, 40);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Name = x.ToString();
                x++;
                button.Click += changeTable_Click;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            var numbers = new List<string>() { "ห่อกลับบ้าน 1","ห่อกลับบ้าน 2", "ห่อกลับบ้าน 3", "ห่อกลับบ้าน 4", "ห่อกลับบ้าน 5", "ห่อกลับบ้าน 6", "ห่อกลับบ้าน 7", "ห่อกลับบ้าน 8" };
            for (int i = 0; i < numbers.Count; i++)
            {
                Button button = new Button();
                button.Text = numbers[i];
                button.Size = new Size(70, 40);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Name = x.ToString();
                x++;
                button.Click += changeTable_Click;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            var numbers = new List<string>() { "พนักงาน"};
            for (int i = 0; i < numbers.Count; i++)
            {
                Button button = new Button();
                button.Text = numbers[i];
                button.Size = new Size(70, 40);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Name = x.ToString();
                x++;
                button.Click += changeTable_Click;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orderfood.changeTable = textBox1.Text;
            this.Close();
        }
    }
}
