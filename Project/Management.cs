using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    
    public partial class Management : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=sijin;port=4306;persistsecurityinfo=True");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;
        public static string txt1;
        public static string E_B_table;

        public Management()
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
            NumberCustomer f3 = new NumberCustomer();
            f3.ShowDialog();
            f3 = null;
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            f4 = null;
            this.Show();
        }

        public void Opennum_Customer_Click(object sender, EventArgs e)
        {
            

            NumberCustomer numCus = new NumberCustomer();
            Button button = sender as Button;
            var test1 = button.Text;
            if (button.BackColor == Color.Gainsboro)
            {
                
                numCus.tableName = test1;
                numCus.ShowDialog();
            }
            else if (button.BackColor == Color.FromArgb(255, 128, 128))
            {
                Orderfood of = new Orderfood();
                of.tableName = test1;
                of.ShowDialog();
            }
            

            //label11.Text = E_B_table;
            if (E_B_table == "ไม่ว่าง")
            {
                button.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (E_B_table == "ว่าง")
            {
                button.BackColor = (Color.Gainsboro);
            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            var numbers = new List<string>() { 
                "จ่ายสด", "กะชัง 1", "กะชัง 2", "กะชัง 3", "กะชัง 4",
                "กะชัง 5", "กะชัง 6", "กะชัง 7", "กะชัง 8", "กะชัง 9", "กะชัง 10", "กะชัง 11", "กะชัง 12", "กะชัง 13","กะชัง 14", 
                "กะชัง 15", "กะชัง 16", "กะชัง 17", "กะชัง 18", "กะชัง 19", "กะชัง 20", "กะชัง 21", "กะชัง 22", "กะชัง 23","กะชัง 24", 
                "กะชัง 25", "กะชัง 26", "กะชัง 27", "กะชัง 28", "กะชัง 29", "กะชัง 30" 
            };
            for (int i = 0; i < numbers.Count; i++)
            {
                Button button = new Button();
                button.Text = numbers[i];
                button.BackColor = Color.Gainsboro;
                button.Size = new Size(100, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Opennum_Customer_Click;
                button.Name = x.ToString();
                x++;
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
                button.BackColor = Color.Gainsboro;
                button.Size = new Size(100, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Opennum_Customer_Click;
                button.Name = x.ToString();
                x++;
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
                button.BackColor = Color.Gainsboro;
                button.Size = new Size(100, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Opennum_Customer_Click;
                button.Name = x.ToString();
                x++;
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
                button.BackColor = Color.Gainsboro;
                button.Size = new Size(100, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Opennum_Customer_Click;
                button.Name = x.ToString();
                x++;
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
                button.BackColor = Color.Gainsboro;
                button.Size = new Size(100, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Opennum_Customer_Click;
                button.Name = x.ToString();
                x++;
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
                button.BackColor = Color.Gainsboro;
                button.Size = new Size(100,50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Opennum_Customer_Click;
                button.Name = x.ToString();
                x++;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            for (int i = 27; i <= 34; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.BackColor = Color.Gainsboro;
                button.Size = new Size(100,50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Opennum_Customer_Click;
                button.Name = x.ToString();
                x++;
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
                button.BackColor = Color.Gainsboro;
                button.Size = new Size(100,50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Opennum_Customer_Click;
                button.Name = x.ToString();
                x++;
            }

            var numbers = new List<string>() { "ซุ่ม 1", "ซุ่ม 2", "ซุ่ม 3", "ซุ่ม 4", "ซุ่ม 5", "ซุ่ม 6" };
            for (int i = 0; i < numbers.Count; i++)
            {
                Button button = new Button();
                button.Text = numbers[i];
                button.BackColor = Color.Gainsboro;
                button.Size = new Size(100,50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Opennum_Customer_Click;
                button.Name = x.ToString();
                x++;
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
                button.BackColor = Color.Gainsboro;
                button.Size = new Size(100,50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Opennum_Customer_Click;
                button.Name = x.ToString();
                x++;
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
                button.BackColor = Color.Gainsboro;
                button.Size = new Size(100,50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Opennum_Customer_Click;
                button.Name = x.ToString();
                x++;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            var numbers = new List<string>() { "ห่อกลับบ้าน 1", "ห่อกลับบ้าน 2", "ห่อกลับบ้าน 3", "ห่อกลับบ้าน 4", "ห่อกลับบ้าน 5", "ห่อกลับบ้าน 6", "ห่อกลับบ้าน 7", "ห่อกลับบ้าน 8" };
            for (int i = 0; i < numbers.Count; i++)
            {
                Button button = new Button();
                button.Text = numbers[i];
                button.BackColor = Color.Gainsboro;
                button.Size = new Size(100,50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Opennum_Customer_Click;
                button.Name = x.ToString();
                x++;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int x = 0;
            flowLayoutPanel2.Controls.Clear();
            var numbers = new List<string>() { "พนักงาน" };
            for (int i = 0; i < numbers.Count; i++)
            {
                Button button = new Button();
                button.Text = numbers[i];
                button.BackColor = Color.Gainsboro;
                button.Size = new Size(100,50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Opennum_Customer_Click;
                button.Name = x.ToString();
                x++;
            }
        }

        private void Management_Load(object sender, EventArgs e)
        {
            
            int x = 0;
            var numbers = new List<string>() { "จ่ายสด", "กะชัง 1", "กะชัง 2", "กะชัง 3", "กะชัง 4",
                "กะชัง 5", "กะชัง 6", "กะชัง 7", "กะชัง 8", "กะชัง 9", "กะชัง 10", "กะชัง 11", "กะชัง 12", "กะชัง 13",
                "กะชัง 14", "กะชัง 15", "กะชัง 16", "กะชัง 17", "กะชัง 18", "กะชัง 19", "กะชัง 20", "กะชัง 21", "กะชัง 22", "กะชัง 23",
                "กะชัง 24", "กะชัง 25", "กะชัง 26", "กะชัง 27", "กะชัง 28", "กะชัง 29", "กะชัง 30" };
            for (int i = 0; i < numbers.Count; i++)
            {
                Button button = new Button();
                button.Text = numbers[i];
                button.BackColor = Color.Gainsboro;
                button.Size = new Size(100, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Opennum_Customer_Click;
                button.Name = x.ToString();
                x++;

            }
            var dateToday = DateTime.Now.ToString("yyyy-MM-dd");
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT `ord_d`, `numCustomer` FROM `order` WHERE ord_d = '" + dateToday + "'", con);
            cm.Connection = con;
            dr = cm.ExecuteReader();
            int lb4 = int.Parse(label4.Text);
            while (dr.Read())
            {
                lb4 += int.Parse(dr[1].ToString());
            }
            label4.Text = lb4.ToString();
            con.Close();

            con.Open();
            MySqlCommand cm2 = new MySqlCommand("SELECT COUNT(*) FROM `order` WHERE ord_d = '" + dateToday + "'", con);
            Int32 count = Convert.ToInt32(cm2.ExecuteScalar());

            label3.Text = (count).ToString();
            con.Close();



        }
    }
}
