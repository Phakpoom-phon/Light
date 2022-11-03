using MySql.Data.MySqlClient;
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
    public partial class Orderfood : Form
    {
        public string NewtableName;
        public string NewCustomer;
        public string Newtype;
        public string Newname;
        public string Newamt;
        public string Newprice;

        public string tableName;
        public static string changeTable;
        public static string update_listview;
        public string txt;
        public string Food_name { get; set; }
        public string Food_num { get; set; }
        public decimal Food_price { get; set; }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=sijin;port=4306;persistsecurityinfo=True");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;

        public Orderfood()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel4.Visible = true;
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
            calcu cal = new calcu();
            cal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            edittable f10 = new edittable();
            f10.txt = button2.Text;
            f10.ShowDialog();

            button2.Text = changeTable;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            addnumber f11 = new addnumber();
            f11.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            addedit f12 = new addedit();
            f12.ShowDialog();

        }

        public void button6_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            if (this.listView1.SelectedItems.Count > 0)
            {

                String selData0 = this.listView1.SelectedItems[0].Text;
                //String selData1 = this.listView1.SelectedItems[1].Text;
                //String selData2 = this.listView1.SelectedItems[2].Text;
                //MessageBox.Show(selData);
                f14.txt_listview1 = selData0;
            
                var ls = new List<Orderfood>();
                ls.Add(new Orderfood { Food_name = selData0 + "("+update_listview+")", Food_num = "1", Food_price = 50 });

                foreach (var item in ls)
                {
                    var lvi = new ListViewItem(item.Food_name);
                    lvi.SubItems.Add(item.Food_num);
                    lvi.SubItems.Add(item.Food_price.ToString());
                    this.listView1.Items.Add(lvi);
                }
            }
            f14.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.total = textBox4.Text;
           
            f15.ShowDialog();

        }

        private void Orderfood_Load(object sender, EventArgs e)
        {
            // NewtableName;
            // NewCustomer;
            // Newtype;
            // Newname;
            // Newamt;
            // Newprice;


            button2.Text = tableName;
            label4.Text = "จำนวนลูกค้า : " + txt;

            //button2.Text = NewtableName;
            //label4.Text = "จำนวนลูกค้า : " + NewCustomer;

            timer1.Start();
            timer1.Stop();
            timer2.Start();

            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูแนะนำ' ");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            //var ls = new List<Orderfood>();
            int i = 0;
            while (dr.Read())
            {
                Button button = new Button();
                //button.Name = "button "+ (i+1).
                button.Text = dr[1].ToString();
                button.Size = new Size(138, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Itemlistview_Click;
                button.Name = i.ToString();
                i++;
            }
            con.Close();

            con.Open();
            MySqlCommand cmd = new MySqlCommand(
            "SELECT `order`.tableName,`order`.numCustomer,ordermenu.orderMenu_type,ordermenu.orderMenu_name,ordermenu.orderMenu_amt,ordermenu.orderMenu_price FROM `order` " +
            "INNER JOIN ordermenu on `order`.tableNumber = ordermenu.tableNumber WHERE ord_status ='กำลังทำงานอยู่' && orderMenu_type = 'อาหาร' && `order`.tableName = '" + tableName + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "testTable");
            con.Close();

            dt = ds.Tables["testTable"];
            int x ;
            for (x = 0; x <= dt.Rows.Count - 1; x++)
            {
                listView1.Items.Add(dt.Rows[x].ItemArray[3].ToString());
                listView1.Items[x].SubItems.Add(dt.Rows[x].ItemArray[4].ToString());
                listView1.Items[x].SubItems.Add(dt.Rows[x].ItemArray[5].ToString());
                listView1.Items[x].SubItems[0].BackColor = Color.FromArgb(128, 255, 128);
                //listView1.BackColor = Color.FromArgb(128, 255, 128);
            }

            con.Open();
            MySqlCommand cmd2 = new MySqlCommand(
            "SELECT `order`.tableName,`order`.numCustomer,ordermenu.orderMenu_type,ordermenu.orderMenu_name,ordermenu.orderMenu_amt,ordermenu.orderMenu_price FROM `order` " +
            "INNER JOIN ordermenu on `order`.tableNumber = ordermenu.tableNumber WHERE ord_status ='กำลังทำงานอยู่' && orderMenu_type = 'เครื่องดื่ม' && `order`.tableName = '" + tableName + "'", con);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            DataTable dt2 = new DataTable();
            da2.Fill(ds2, "testTable");
            con.Close();

            dt2 = ds2.Tables["testTable"];
            int y;
            for (y = 0; y <= dt2.Rows.Count - 1; y++)
            {
                listView2.Items.Add(dt2.Rows[y].ItemArray[3].ToString());
                listView2.Items[y].SubItems.Add(dt2.Rows[y].ItemArray[4].ToString());
                listView2.Items[y].SubItems.Add(dt2.Rows[y].ItemArray[5].ToString());
                listView2.Items[y].SubItems[0].BackColor = Color.FromArgb(128, 255, 128);
            }

        }

        //public string txt;
        //public string txt1;
        public void Itemlistview_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            var Food_name1 = new List<string>();
            var Food_price1 = new List<decimal>();
            //var Food_price1 = new List<decimal>();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูแนะนำ' ");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Food_name1.Add(dr[1].ToString());
                Food_price1.Add(decimal.Parse(dr[4].ToString()));
                //ls.Add(new Orderfood { Food_name = dr[1].ToString(), Food_num = "1", Food_price = decimal.Parse(dr[4].ToString()) });
            }

            Button button = sender as Button;
            var test = button.Name;
            ls.Add(new Orderfood { Food_name = Food_name1[Int32.Parse(test)], Food_num = "1", Food_price = Food_price1[Int32.Parse(test)]});

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView1.Items.Add(lvi);
                label1.Text = "รวม " + listView1.Items.Count.ToString() + " รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox2.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
            }
            con.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                String selData = this.listView1.SelectedItems[0].Text;
                //MessageBox.Show(selData);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView2.SelectedItems.Count > 0)
            {
                String selData = this.listView2.SelectedItems[0].Text;
                //MessageBox.Show(selData);
            }
        }
        //decimal total_price = 0;
        private void button19_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            ls.Add(new Orderfood { Food_name = "ข้าวกะเพรา", Food_num = "1", Food_price = 50 });

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView1.Items.Add(lvi);
                label1.Text = "รวม "+listView1.Items.Count.ToString()+" รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox2.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
                
            }
        }

        
        private void button8_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
                label1.Text = "รวม " + listView1.Items.Count.ToString() + " รายการ";
                //// 
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox2.Text = Convert.ToString(gtotal);
                ////
            }
            ////
            foreach (ListViewItem eachItem in listView2.SelectedItems)
            {
                listView2.Items.Remove(eachItem);
                label2.Text = "รวม " + listView2.Items.Count.ToString() + " รายการ";
                //// 
                decimal gtotal1 = 0;
                foreach (ListViewItem lstItem in listView2.Items)
                {
                    gtotal1 += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox3.Text = Convert.ToString(gtotal1);
            }
            decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
            textBox4.Text = i.ToString();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            ls.Add(new Orderfood { Food_name = "ข้าวผัด", Food_num = "1", Food_price = 30 });

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView1.Items.Add(lvi);
                label1.Text = "รวม " + listView1.Items.Count.ToString() + " รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox2.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            ls.Add(new Orderfood { Food_name = "น้ำแข็ง", Food_num = "1", Food_price = 20 });

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView2.Items.Add(lvi);
                label2.Text = "รวม " + listView2.Items.Count.ToString() + " รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView2.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox3.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm:ss");
            //DateTime.Now.ToString("d/M/yyyy");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel1.Visible = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel4.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูแนะนำ'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            //var ls = new List<Orderfood>();
            int i = 0;
            while (dr.Read())
            {
                Button button = new Button();
                //button.Name = "button "+ (i+1).
                button.Text = dr[1].ToString();
                button.Size = new Size(138, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Itemlistview_Click;
                button.Name = i.ToString();
                i++;
            }
            con.Close();
        }


        private void button11_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูกุ้ง'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            //var ls = new List<Orderfood>();
            int i = 0;
            while (dr.Read())
            {
                Button button = new Button();
                //button.Name = "button "+ (i+1).
                button.Text = dr[1].ToString();
                button.Size = new Size(138, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Itemfoodshrimp_Click;
                button.Name = i.ToString();
                i++;
            }
            con.Close();
        }

        public void Itemfoodshrimp_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            var Food_name1 = new List<string>();
            var Food_price1 = new List<decimal>();
            //var Food_price1 = new List<decimal>();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูกุ้ง'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Food_name1.Add(dr[1].ToString());
                Food_price1.Add(decimal.Parse(dr[4].ToString()));
                //ls.Add(new Orderfood { Food_name = dr[1].ToString(), Food_num = "1", Food_price = decimal.Parse(dr[4].ToString()) });
            }

            Button button = sender as Button;
            var test = button.Name;
            ls.Add(new Orderfood { Food_name = Food_name1[Int32.Parse(test)], Food_num = "1", Food_price = Food_price1[Int32.Parse(test)] });

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView1.Items.Add(lvi);
                label1.Text = "รวม " + listView1.Items.Count.ToString() + " รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox2.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
            }
            con.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูปลา'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            //var ls = new List<Orderfood>();
            int i = 0;
            while (dr.Read())
            {
                Button button = new Button();
                //button.Name = "button "+ (i+1).
                button.Text = dr[1].ToString();
                button.Size = new Size(138, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Itemfoodfish_Click;
                button.Name = i.ToString();
                i++;
            }
            con.Close();
        }

        public void Itemfoodfish_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            var Food_name1 = new List<string>();
            var Food_price1 = new List<decimal>();
            //var Food_price1 = new List<decimal>();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูปลา'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Food_name1.Add(dr[1].ToString());
                Food_price1.Add(decimal.Parse(dr[4].ToString()));
                //ls.Add(new Orderfood { Food_name = dr[1].ToString(), Food_num = "1", Food_price = decimal.Parse(dr[4].ToString()) });
            }

            Button button = sender as Button;
            var test = button.Name;
            ls.Add(new Orderfood { Food_name = Food_name1[Int32.Parse(test)], Food_num = "1", Food_price = Food_price1[Int32.Parse(test)] });

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView1.Items.Add(lvi);
                label1.Text = "รวม " + listView1.Items.Count.ToString() + " รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox2.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
            }
            con.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูปู'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            //var ls = new List<Orderfood>();
            int i = 0;
            while (dr.Read())
            {
                Button button = new Button();
                //button.Name = "button "+ (i+1).
                button.Text = dr[1].ToString();
                button.Size = new Size(138, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Itemfoodcrab_Click;
                button.Name = i.ToString();
                i++;
            }
            con.Close();
        }

        public void Itemfoodcrab_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            var Food_name1 = new List<string>();
            var Food_price1 = new List<decimal>();
            //var Food_price1 = new List<decimal>();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูปู'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Food_name1.Add(dr[1].ToString());
                Food_price1.Add(decimal.Parse(dr[4].ToString()));
                //ls.Add(new Orderfood { Food_name = dr[1].ToString(), Food_num = "1", Food_price = decimal.Parse(dr[4].ToString()) });
            }

            Button button = sender as Button;
            var test = button.Name;
            ls.Add(new Orderfood { Food_name = Food_name1[Int32.Parse(test)], Food_num = "1", Food_price = Food_price1[Int32.Parse(test)] });

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView1.Items.Add(lvi);
                label1.Text = "รวม " + listView1.Items.Count.ToString() + " รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox2.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
            }
            con.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูหอย'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            //var ls = new List<Orderfood>();
            int i = 0;
            while (dr.Read())
            {
                Button button = new Button();
                //button.Name = "button "+ (i+1).
                button.Text = dr[1].ToString();
                button.Size = new Size(138, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Itemfoodshell_Click;
                button.Name = i.ToString();
                i++;
            }
            con.Close();
        }

        public void Itemfoodshell_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            var Food_name1 = new List<string>();
            var Food_price1 = new List<decimal>();
            //var Food_price1 = new List<decimal>();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูหอย'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Food_name1.Add(dr[1].ToString());
                Food_price1.Add(decimal.Parse(dr[4].ToString()));
                //ls.Add(new Orderfood { Food_name = dr[1].ToString(), Food_num = "1", Food_price = decimal.Parse(dr[4].ToString()) });
            }

            Button button = sender as Button;
            var test = button.Name;
            ls.Add(new Orderfood { Food_name = Food_name1[Int32.Parse(test)], Food_num = "1", Food_price = Food_price1[Int32.Parse(test)] });

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView1.Items.Add(lvi);
                label1.Text = "รวม " + listView1.Items.Count.ToString() + " รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox2.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
            }
            con.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูปลาหมึก'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            //var ls = new List<Orderfood>();
            int i = 0;
            while (dr.Read())
            {
                Button button = new Button();
                //button.Name = "button "+ (i+1).
                button.Text = dr[1].ToString();
                button.Size = new Size(138, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Itemfoodsquid_Click;
                button.Name = i.ToString();
                i++;
            }
            con.Close();
        }

        public void Itemfoodsquid_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            var Food_name1 = new List<string>();
            var Food_price1 = new List<decimal>();
            //var Food_price1 = new List<decimal>();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูปลาหมึก'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Food_name1.Add(dr[1].ToString());
                Food_price1.Add(decimal.Parse(dr[4].ToString()));
                //ls.Add(new Orderfood { Food_name = dr[1].ToString(), Food_num = "1", Food_price = decimal.Parse(dr[4].ToString()) });
            }

            Button button = sender as Button;
            var test = button.Name;
            ls.Add(new Orderfood { Food_name = Food_name1[Int32.Parse(test)], Food_num = "1", Food_price = Food_price1[Int32.Parse(test)] });

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView1.Items.Add(lvi);
                label1.Text = "รวม " + listView1.Items.Count.ToString() + " รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox2.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
            }
            con.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูต้ม'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            //var ls = new List<Orderfood>();
            int i = 0;
            while (dr.Read())
            {
                Button button = new Button();
                //button.Name = "button "+ (i+1).
                button.Text = dr[1].ToString();
                button.Size = new Size(138, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Itemfoodboiled_Click;
                button.Name = i.ToString();
                i++;
            }
            con.Close();
        }

        public void Itemfoodboiled_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            var Food_name1 = new List<string>();
            var Food_price1 = new List<decimal>();
            //var Food_price1 = new List<decimal>();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูต้ม'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Food_name1.Add(dr[1].ToString());
                Food_price1.Add(decimal.Parse(dr[4].ToString()));
            }

            Button button = sender as Button;
            var test = button.Name;
            ls.Add(new Orderfood { Food_name = Food_name1[Int32.Parse(test)], Food_num = "1", Food_price = Food_price1[Int32.Parse(test)] });

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView1.Items.Add(lvi);
                label1.Text = "รวม " + listView1.Items.Count.ToString() + " รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox2.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
            }
            con.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูตำ/ยำ'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            //var ls = new List<Orderfood>();
            int i = 0;
            while (dr.Read())
            {
                Button button = new Button();
                //button.Name = "button "+ (i+1).
                button.Text = dr[1].ToString();
                button.Size = new Size(138, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Itemfoodyum_Click;
                button.Name = i.ToString();
                i++;
            }
            con.Close();
        }
        public void Itemfoodyum_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            var Food_name1 = new List<string>();
            var Food_price1 = new List<decimal>();
            //var Food_price1 = new List<decimal>();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูตำ/ยำ'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Food_name1.Add(dr[1].ToString());
                Food_price1.Add(decimal.Parse(dr[4].ToString()));
                //ls.Add(new Orderfood { Food_name = dr[1].ToString(), Food_num = "1", Food_price = decimal.Parse(dr[4].ToString()) });
            }

            Button button = sender as Button;
            var test = button.Name;
            ls.Add(new Orderfood { Food_name = Food_name1[Int32.Parse(test)], Food_num = "1", Food_price = Food_price1[Int32.Parse(test)] });

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView1.Items.Add(lvi);
                label1.Text = "รวม " + listView1.Items.Count.ToString() + " รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox2.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
            }
            con.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูผัด'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            //var ls = new List<Orderfood>();
            int i = 0;
            while (dr.Read())
            {
                Button button = new Button();
                //button.Name = "button "+ (i+1).
                button.Text = dr[1].ToString();
                button.Size = new Size(138, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Itemfoodpuff_Click;
                button.Name = i.ToString();
                i++;
            }
            con.Close();
        }
        public void Itemfoodpuff_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            var Food_name1 = new List<string>();
            var Food_price1 = new List<decimal>();
            //var Food_price1 = new List<decimal>();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูผัด'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Food_name1.Add(dr[1].ToString());
                Food_price1.Add(decimal.Parse(dr[4].ToString()));
                //ls.Add(new Orderfood { Food_name = dr[1].ToString(), Food_num = "1", Food_price = decimal.Parse(dr[4].ToString()) });
            }

            Button button = sender as Button;
            var test = button.Name;
            ls.Add(new Orderfood { Food_name = Food_name1[Int32.Parse(test)], Food_num = "1", Food_price = Food_price1[Int32.Parse(test)] });

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView1.Items.Add(lvi);
                label1.Text = "รวม " + listView1.Items.Count.ToString() + " รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox2.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
            }
            con.Close();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูทอด'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            //var ls = new List<Orderfood>();
            int i = 0;
            while (dr.Read())
            {
                Button button = new Button();
                //button.Name = "button "+ (i+1).
                button.Text = dr[1].ToString();
                button.Size = new Size(138, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Itemfoodfried_Click;
                button.Name = i.ToString();
                i++;
            }
            con.Close();
        }

        public void Itemfoodfried_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            var Food_name1 = new List<string>();
            var Food_price1 = new List<decimal>();
            //var Food_price1 = new List<decimal>();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูทอด'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Food_name1.Add(dr[1].ToString());
                Food_price1.Add(decimal.Parse(dr[4].ToString()));
                //ls.Add(new Orderfood { Food_name = dr[1].ToString(), Food_num = "1", Food_price = decimal.Parse(dr[4].ToString()) });
            }

            Button button = sender as Button;
            var test = button.Name;
            ls.Add(new Orderfood { Food_name = Food_name1[Int32.Parse(test)], Food_num = "1", Food_price = Food_price1[Int32.Parse(test)] });

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView1.Items.Add(lvi);
                label1.Text = "รวม " + listView1.Items.Count.ToString() + " รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox2.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
            }
            con.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูอาหารจานด่วน'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            //var ls = new List<Orderfood>();
            int i = 0;
            while (dr.Read())
            {
                Button button = new Button();
                //button.Name = "button "+ (i+1).
                button.Text = dr[1].ToString();
                button.Size = new Size(138, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Itemfoodfast_Click;
                button.Name = i.ToString();
                i++;
            }
            con.Close();
        }
        public void Itemfoodfast_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            var Food_name1 = new List<string>();
            var Food_price1 = new List<decimal>();
            //var Food_price1 = new List<decimal>();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูอาหารจานด่วน'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Food_name1.Add(dr[1].ToString());
                Food_price1.Add(decimal.Parse(dr[4].ToString()));
                //ls.Add(new Orderfood { Food_name = dr[1].ToString(), Food_num = "1", Food_price = decimal.Parse(dr[4].ToString()) });
            }

            Button button = sender as Button;
            var test = button.Name;
            ls.Add(new Orderfood { Food_name = Food_name1[Int32.Parse(test)], Food_num = "1", Food_price = Food_price1[Int32.Parse(test)] });

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView1.Items.Add(lvi);
                label1.Text = "รวม " + listView1.Items.Count.ToString() + " รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox2.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
            }
            con.Close();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูเครื่องดื่ม'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            //var ls = new List<Orderfood>();
            int i = 0;
            while (dr.Read())
            {
                Button button = new Button();
                //button.Name = "button "+ (i+1).
                button.Text = dr[1].ToString();
                button.Size = new Size(138, 50);
                button.Location = new Point();
                button.Visible = true;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Itemdrink_Click;
                button.Name = i.ToString();
                i++;
            }
            con.Close();
        }
        public void Itemdrink_Click(object sender, EventArgs e)
        {
            var ls = new List<Orderfood>();
            var Food_name1 = new List<string>();
            var Food_price1 = new List<decimal>();
            //var Food_price1 = new List<decimal>();
            con.Open();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM menu WHERE menu_type ='เมนูเครื่องดื่ม'");
            cm.Connection = con;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Food_name1.Add(dr[1].ToString());
                Food_price1.Add(decimal.Parse(dr[4].ToString()));
                //ls.Add(new Orderfood { Food_name = dr[1].ToString(), Food_num = "1", Food_price = decimal.Parse(dr[4].ToString()) });
            }

            Button button = sender as Button;
            var test = button.Name;
            ls.Add(new Orderfood { Food_name = Food_name1[Int32.Parse(test)], Food_num = "1", Food_price = Food_price1[Int32.Parse(test)] });

            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.Food_name);
                lvi.SubItems.Add(item.Food_num);
                lvi.SubItems.Add(item.Food_price.ToString());
                this.listView2.Items.Add(lvi);
                label2.Text = "รวม " + listView2.Items.Count.ToString() + " รายการ";
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView2.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[2].Text);
                }
                textBox3.Text = Convert.ToString(gtotal);
                decimal i = decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text);
                textBox4.Text = i.ToString();
            }
            con.Close();
        }
        int i = Convert.ToInt32(DateTime.Now.ToString("dMyy001"));
        private void button16_Click(object sender, EventArgs e)
        {
            
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `order`(`tableNumber`, `ord_d`, `ord_time`, `tableName`, `numCustomer`,`ord_status`) " +
                                                 "VALUES (@tableNumber,@ord_d,@ord_time,@tableName,@numCustomer,@ord_status)", con);

            cmd.Parameters.AddWithValue("tableNumber", i);
            cmd.Parameters.AddWithValue("ord_d", DateTime.Now.ToString("yyyy/M/d"));
            cmd.Parameters.AddWithValue("ord_time", DateTime.Now.ToString("h:mm:ss"));
            cmd.Parameters.AddWithValue("tableName", tableName);
            cmd.Parameters.AddWithValue("numCustomer", Convert.ToInt32(txt));
            cmd.Parameters.AddWithValue("ord_status", "กำลังทำงานอยู่");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();




            cmd = new MySqlCommand("Insert Into `ordermenu`(`tableNumber`, `orderMenu_type`, `orderMenu_name`, `orderMenu_amt`, `orderMenu_price`) " +
                                                "VALUES(@tableNumber,@orderMenu_type,@orderMenu_name,@orderMenu_amt,@orderMenu_price)", con);
            
            foreach (ListViewItem lvi in listView1.Items)
            {
                if (lvi.BackColor == Color.White)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("tableNumber", i);
                    cmd.Parameters.AddWithValue("orderMenu_type", "อาหาร");
                    cmd.Parameters.AddWithValue("orderMenu_name", lvi.SubItems[0].Text);
                    cmd.Parameters.AddWithValue("orderMenu_amt", lvi.SubItems[1].Text);
                    cmd.Parameters.AddWithValue("orderMenu_price", Convert.ToInt32(lvi.SubItems[2].Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    lvi.SubItems[0].BackColor = Color.FromArgb(128, 255, 128);
                }
                
            }
            
            foreach (ListViewItem lvi in listView2.Items)
            {
                if (lvi.BackColor == Color.White)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("tableNumber", i);
                    cmd.Parameters.AddWithValue("orderMenu_type", "เครื่องดื่ม");
                    cmd.Parameters.AddWithValue("orderMenu_name", lvi.SubItems[0].Text);
                    cmd.Parameters.AddWithValue("orderMenu_amt", lvi.SubItems[1].Text);
                    cmd.Parameters.AddWithValue("orderMenu_price", Convert.ToInt32(lvi.SubItems[2].Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    lvi.SubItems[0].BackColor = Color.FromArgb(128, 255, 128);
                }
            }
            i++;
            MessageBox.Show("เพิ่มอาหารรียบร้อย");
            Management.E_B_table = "ไม่ว่าง";
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
