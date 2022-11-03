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
    public partial class Form4 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=sijin;port=4306;persistsecurityinfo=True");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;

        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
            var dateToday = DateTime.Now.ToString("yyyy-MM-dd");
            
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `tableNumber`, `ord_d`, `tableName` , `ord_status` FROM `order` WHERE ord_status = 'สิ้นสุดการขาย' && ord_d = '" + dateToday + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "testTable");
            con.Close();

            dt = ds.Tables["testTable"];
            int x;
            for (x = 0; x <= dt.Rows.Count - 1; x++)
            {
                listView1.Items.Add(dt.Rows[x].ItemArray[0].ToString());
                listView1.Items[x].SubItems.Add(dt.Rows[x].ItemArray[1].ToString());
                listView1.Items[x].SubItems.Add(dt.Rows[x].ItemArray[2].ToString());
            }

          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            //textBox2.Text = DateTime.Now.ToString("dMyy");
            //textBox8.Text = DateTime.Now.ToString("d/M/yyyy");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (this.listView1.SelectedItems.Count > 0)
            {
                
                String selData = this.listView1.SelectedItems[0].Text;
                String selData1 = this.listView1.SelectedItems[0].SubItems[1].Text;
                String selData2 = this.listView1.SelectedItems[0].SubItems[2].Text;
                
                textBox3.Text = selData;
                textBox6.Text = selData2;
                textBox8.Text = textBox2.Text;

                listView2.Items.Clear();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT `tableNumber`, `orderMenu_name`, `orderMenu_price`, `orderMenu_amt` FROM `ordermenu` WHERE tableNumber = '"+ selData +"'", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds, "testTable");
                con.Close();

                dt = ds.Tables["testTable"];
                int x;
                for (x = 0; x <= dt.Rows.Count - 1; x++)
                {
                    listView2.Items.Add(dt.Rows[x].ItemArray[1].ToString());
                    listView2.Items[x].SubItems.Add(dt.Rows[x].ItemArray[2].ToString());
                    listView2.Items[x].SubItems.Add(dt.Rows[x].ItemArray[3].ToString());
                    int price = int.Parse(listView2.Items[x].SubItems[1].Text);
                    int num = int.Parse(listView2.Items[x].SubItems[2].Text);
                    int total = price * num;
                    
                    listView2.Items[x].SubItems.Add(total.ToString());
                    listView2.Items[x].SubItems.Add("0");
                    listView2.Items[x].SubItems.Add("0");
                    listView2.Items[x].SubItems.Add(total.ToString());
                }
                


                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView2.Items)
                {
                    
                    gtotal += decimal.Parse(lstItem.SubItems[6].Text);
                }
                label8.Text = Convert.ToString(gtotal);



                //String selData1 = this.listView1.SelectedItems[0].Text;
                //MessageBox.Show(selData);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
