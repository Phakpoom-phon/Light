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
    public partial class Form7 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=sijin;port=4306;persistsecurityinfo=True");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;
        string menu_code, menu_name, menu_type, menu_price;
        public Form7()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem item = listView2.SelectedItems[0];
                textBox3.Text = item.SubItems[0].Text;
                textBox4.Text = item.SubItems[1].Text;
                textBox5.Text = item.SubItems[2].Text;
                textBox6.Text = item.SubItems[3].Text;
            }
            else
            {
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "select * from menu where menu_type='กุ้ง'";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[2].ToString());
                lv.SubItems.Add(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[4].ToString());
                listView2.Items.Add(lv);
            }
            con.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "select * from menu where menu_type='ปู'";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[2].ToString());
                lv.SubItems.Add(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[4].ToString());
                listView2.Items.Add(lv);
            }
            con.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "select * from menu where menu_type='หอย'";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[2].ToString());
                lv.SubItems.Add(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[4].ToString());
                listView2.Items.Add(lv);
            }
            con.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "select * from menu where menu_type='ปลาหมึก'";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[2].ToString());
                lv.SubItems.Add(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[4].ToString());
                listView2.Items.Add(lv);
            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM menu";
            sql = "INSERT INTO menu (menu_code,menu_name,menu_type,menu_price) " +
                "VALUES ('" + textBox4.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + textBox6.Text + "')";
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=sijin;port=4306;persistsecurityinfo=True");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("เพิ่มอาหารรียบร้อย");
            listView2.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM menu";
            sql = "DELETE FROM menu WHERE menu_code='" + textBox4.Text + "'";
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=sijin;port=4306;persistsecurityinfo=True");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ลบอาหารเรียบร้อย");
            listView2.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text != "" && textBox5.Text != "" && textBox3.Text != "" && textBox6.Text != "")
                {
                    //string sql = "select * from sijin.menu WHERE menu_code='" + textBox4.Text + "',menu_name='" + textBox5.Text + "'," +
                    string sql = "select * from menu WHERE " +
                        "menu_code='" + textBox4.Text + 
                        "',menu_name='" + textBox5.Text + "'," +
                        "menu_type='" + textBox3.Text + 
                        "',menu_price='" + textBox6.Text + 
                        "' WHERE menu_code='" + textBox4.Text + "' ";
                    sql = "UPDATE menu SET menu_code='" + textBox4.Text + "',menu_name='" + textBox5.Text + "'," +
                        "menu_type='" + textBox3.Text + "',menu_price='" + textBox6.Text + "' WHERE menu_code='" + textBox4.Text + "' ";
                    MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=sijin;port=4306;persistsecurityinfo=True");
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            menu_code = dr["รหัส"].ToString();
                            menu_name = dr["ชื่อ"].ToString();
                            menu_type = dr["หมวดหมู่"].ToString();
                            menu_price = dr["ราคา"].ToString();
                            MessageBox.Show("กรอกรหัสให้ครบถ้วน", "Information");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Data not found", "Information");
                    }
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("กรอกรหัสให้ครบถ้วน", "Information");
                }
            }
            catch
            {
                MessageBox.Show("แก้ไขอาหารเรียบร้อย");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "select * from menu where menu_name='" + textBox2.Text + "'";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[2].ToString());
                lv.SubItems.Add(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[4].ToString());
                listView2.Items.Add(lv);
            }
            con.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                String selData = this.listView1.SelectedItems[0].Text;

                if (selData == "         เมนูแนะนำ")
                {
                    con.Open();
                    cmd.CommandText = "SELECT * FROM menu WHERE menu_type ='เมนูแนะนำ'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    listView2.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[2].ToString());
                        lv.SubItems.Add(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        listView2.Items.Add(lv);
                    }
                    con.Close();
                }
                else if (selData == "         เมนูกุ้ง")
                {
                    con.Open();
                    cmd.CommandText = "SELECT * FROM menu WHERE menu_type ='เมนูกุ้ง'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    listView2.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[2].ToString());
                        lv.SubItems.Add(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        listView2.Items.Add(lv);
                    }
                    con.Close();
                }
                else if (selData == "         เมนูปลา")
                {
                    con.Open();
                    cmd.CommandText = "SELECT * FROM menu WHERE menu_type ='เมนูปลา'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    listView2.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[2].ToString());
                        lv.SubItems.Add(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        listView2.Items.Add(lv);
                    }
                    con.Close();
                }
                else if (selData == "         เมนูปู")
                {
                    con.Open();
                    cmd.CommandText = "SELECT * FROM menu WHERE menu_type ='เมนูปู'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    listView2.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[2].ToString());
                        lv.SubItems.Add(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        listView2.Items.Add(lv);
                    }
                    con.Close();
                }
                else if (selData == "         เมนูหอย")
                {
                    con.Open();
                    cmd.CommandText = "SELECT * FROM menu WHERE menu_type ='เมนูหอย'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    listView2.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[2].ToString());
                        lv.SubItems.Add(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        listView2.Items.Add(lv);
                    }
                    con.Close();
                }
                else if (selData == "         เมนูปลาหมึก")
                {
                    con.Open();
                    cmd.CommandText = "SELECT * FROM menu WHERE menu_type ='เมนูปลาหมึก'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    listView2.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[2].ToString());
                        lv.SubItems.Add(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        listView2.Items.Add(lv);
                    }
                    con.Close();
                }
                else if (selData == "         เมนูต้ม")
                {
                    con.Open();
                    cmd.CommandText = "SELECT * FROM menu WHERE menu_type ='เมนูต้ม'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    listView2.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[2].ToString());
                        lv.SubItems.Add(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        listView2.Items.Add(lv);
                    }
                    con.Close();
                }
                else if (selData == "         เมนูตำ/ยำ")
                {
                    con.Open();
                    cmd.CommandText = "SELECT * FROM menu WHERE menu_type ='เมนูตำ/ยำ'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    listView2.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[2].ToString());
                        lv.SubItems.Add(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        listView2.Items.Add(lv);
                    }
                    con.Close();
                }
                else if (selData == "         เมนูผัด")
                {
                    con.Open();
                    cmd.CommandText = "SELECT * FROM menu WHERE menu_type ='เมนูผัด'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    listView2.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[2].ToString());
                        lv.SubItems.Add(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        listView2.Items.Add(lv);
                    }
                    con.Close();
                }
                else if (selData == "         เมนูทอด")
                {
                    con.Open();
                    cmd.CommandText = "SELECT * FROM menu WHERE menu_type ='เมนูทอด'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    listView2.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[2].ToString());
                        lv.SubItems.Add(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        listView2.Items.Add(lv);
                    }
                    con.Close();
                }
                else if (selData == "         เมนูอาหารจานด่วน")
                {
                    con.Open();
                    cmd.CommandText = "SELECT * FROM menu WHERE menu_type ='เมนูอาหารจานด่วน'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    listView2.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[2].ToString());
                        lv.SubItems.Add(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        listView2.Items.Add(lv);
                    }
                    con.Close();
                }
                else if (selData == "         เมนูเครื่องดื่ม")
                {
                    con.Open();
                    cmd.CommandText = "SELECT * FROM menu WHERE menu_type ='เมนูเครื่องดื่ม'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    listView2.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[2].ToString());
                        lv.SubItems.Add(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        listView2.Items.Add(lv);
                    }
                    con.Close();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "select * from menu where menu_type='ปลา'";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[2].ToString());
                lv.SubItems.Add(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[4].ToString());
                listView2.Items.Add(lv);
            }
            con.Close();
        }
    }
}
