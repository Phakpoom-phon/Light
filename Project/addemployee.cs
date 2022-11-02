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
    public partial class addemployee : Form
    {
        localhost con = new localhost();
        MySqlConnection con1 = new MySqlConnection("server=localhost;user id=root;database=sijin;port=4306;persistsecurityinfo=True");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;
        string emp_code, emp_fname, emp_lname, emp_sex, emp_nation, emp_birthday, emp_extraction, emp_add, emp_hire, emp_type, emp_salary, emp_position;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox9.Text = "";
            textBox7.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                
                ListViewItem item = listView1.SelectedItems[0];
                textBox1.Text = item.SubItems[0].Text;
                textBox2.Text = item.SubItems[1].Text;
                textBox3.Text = item.SubItems[2].Text;
                comboBox1.Text = item.SubItems[3].Text;
                textBox5.Text = item.SubItems[6].Text;
                comboBox2.Text = item.SubItems[7].Text;
                textBox6.Text = item.SubItems[5].Text;
                comboBox3.Text = item.SubItems[9].Text;
                textBox7.Text = item.SubItems[8].Text;
                textBox9.Text = item.SubItems[11].Text;
            }
            else
            {
                textBox3.Text = string.Empty;
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                comboBox1.Text = string.Empty;
                textBox5.Text = string.Empty;
                comboBox2.Text = string.Empty;
                textBox6.Text = string.Empty;
                comboBox3.Text = string.Empty;
                textBox7.Text = string.Empty;
                textBox9.Text = string.Empty;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM employee";
            sql = "DELETE FROM employee WHERE emp_code='" + textBox1.Text + "'";
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=sijin;port=4306;persistsecurityinfo=True");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ลบข้อมูลเรียบร้อย");
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox9.Text != ""
                    && textBox7.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
                {

                    string sql = "select * from sijin.employee WHERE emp_fname='" + textBox2.Text + "',emp_lname='" + textBox3.Text + "',emp_sex='" + comboBox1.Text + "'," +
                          "emp_birthday='" + textBox5.Text + "',emp_extraction='" + textBox6.Text + "',emp_add='" + textBox9.Text + "',emp_hire='" + textBox7.Text + "',emp_type='" + comboBox2.Text + "'," +
                          ",emp_position='" + comboBox3.Text + "' " +
                          " WHERE emp_code='" + textBox1.Text + "'";

                    sql = "UPDATE employee SET emp_fname='" + textBox2.Text + "',emp_lname='" + textBox3.Text + "',emp_sex='" + comboBox1.Text + "'," +
                          "emp_birthday='" + textBox5.Text + "',emp_extraction='" + textBox6.Text + "',emp_add='" + textBox9.Text + "',emp_hire='" + textBox7.Text + "',emp_type='" + comboBox2.Text + "'," +
                          ",emp_position='" + comboBox3.Text + "' " +
                          " WHERE emp_code='" + textBox1.Text + "'";
                    MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=sijin;port=4306;persistsecurityinfo=True");
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();

                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            emp_code = dr["รหัส"].ToString();
                            emp_fname = dr["ชื่อ"].ToString();
                            emp_lname = dr["นามสกุล"].ToString();
                            emp_sex = dr["เพศ"].ToString();
                            emp_nation = dr["เชื้อชาติ"].ToString();
                            emp_birthday = dr["วันเกิด"].ToString();
                            emp_extraction = dr["สัญชาติ"].ToString();
                            emp_add = dr["ที่อยู่"].ToString();
                            emp_hire = dr["วันที่จ้าง"].ToString();
                            emp_type = dr["ประเภท"].ToString();
                            emp_salary = dr["ค่าจ้าง"].ToString();
                            emp_position = dr["ตำแหน่ง"].ToString();
                            MessageBox.Show("กรอกรหัสให้ครบถ้วน", "Information");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Data not found", "Information");
                    }

                    cmd.ExecuteNonQuery();
                    con.Close();
                    /*string sql = "SELECT * FROM employee";
                    sql = "UPDATE employee SET emp_fname='" + textBox2.Text + "',emp_lname='" + textBox3.Text + "',emp_sex='" + comboBox1.Text + "',emp_nation='" + textBox4.Text + "'," +
                          "emp_birthday='" + textBox5.Text + "',emp_extraction='" + textBox6.Text + "',emp_add='" + textBox9.Text + "',emp_hire='" + textBox7.Text + "',emp_type='" + comboBox2.Text + "'," +
                          "emp_salary='" + textBox8.Text + "',emp_position='" + comboBox3.Text + "' " +
                          " WHERE emp_code='"+textBox1.Text+"'";
                    MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=sijin;port=4306;persistsecurityinfo=True");
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("แก้ไขข้อมูลเรียบร้อย");*/
                }
                else
                {
                    MessageBox.Show("กรอกรหัสให้ครบถ้วน", "Information");
                }
            }
            catch
            {
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อย");
            }
        }

        private void addemployee_Load_1(object sender, EventArgs e)
        {
            con1.Open();
            cmd.CommandText = "select * from employee";
            cmd.Connection = con1;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                lv.SubItems.Add(dr[4].ToString());
                lv.SubItems.Add(dr[5].ToString());
                lv.SubItems.Add(dr[6].ToString());
                lv.SubItems.Add(dr[7].ToString());
                lv.SubItems.Add(dr[8].ToString());
                lv.SubItems.Add(dr[9].ToString());
                lv.SubItems.Add(dr[10].ToString());
                lv.SubItems.Add(dr[11].ToString());
                listView1.Items.Add(lv);
            }
            con1.Close();
        }

        public addemployee()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
            textBox1.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox9.Text != ""
                    && textBox7.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
                {

                    string sql = "SELECT * FROM employee";
                    sql = "INSERT INTO employee (emp_code,emp_fname,emp_lname,emp_sex,emp_birthday,emp_extraction,emp_add,emp_hire,emp_type,emp_position) " +
                        "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox9.Text + "'" +
                        ",'" + textBox7.Text + "','" + comboBox2.Text + "''" + comboBox3.Text + "')";
                    string user = "SELECT * FROM suer";
                    user = "INSERT INTO user (user_id,user_pass) " +
                        "VALUES ('" + textBox10.Text + "','" + textBox11.Text + "')";
                    try
                    {
                        if (textBox1.Text != "" && textBox2.Text != "")
                        {

                        }
                    }
                    catch
                    {

                    }
                    MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=sijin;port=4306;persistsecurityinfo=True");
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlCommand cmd1 = new MySqlCommand(user, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("ลงทะเบียนเรียบร้อย");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("กรอกรหัสให้ครบถ้วน", "Information");
                }
            }
            catch
            {

            }
        }

    }
}
