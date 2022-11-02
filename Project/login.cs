using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{



    public partial class login : Form
    {
        localhost con = new localhost();
        string user_id,user_pass ;
       

        public login()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
            textBox1.Focus();
            textBox2.PasswordChar = '*';
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {

                    string query = "select user_id,user_pass from sijin.user WHERE user_id ='" + textBox1.Text + "' AND user_pass ='" + textBox2.Text + "'";
                    MySqlDataReader row;
                    ///MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=sijin") ;
                    ///MySqlCommand cmd = new MySqlCommand(query);
                    con.Open();
                    ///MySqlDataReader row = cmd.ExecuteReader();
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            user_id = row["username"].ToString();
                            user_pass = row["password"].ToString();
                            MessageBox.Show("Data not found1111", "Information");
                        }
                        //userControl31.BringToFront();
                        
                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                textBox1.Text = "";
                textBox2.Text = "";

                userControl31.BringToFront();
                //loadform(new Form2());

            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button23_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // localhost.openConnection();

        }
        /*
        public void loadform(object Form)
        {
            if (this.panel4.Controls.Count > 0)
                this.panel4.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            this.panel4.Controls.Add(f);
            this.panel4.Tag = f;
            f.Show();
        }
        */
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
           
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                button2.PerformClick();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "User Name") {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "User Name";

                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";

                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";

                textBox2.ForeColor = Color.Silver;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
