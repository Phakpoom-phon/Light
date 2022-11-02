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
        public int salesNumber { get; set; }
        public string salesDate { get; set; }
        public int table { get; set; }

        //
        public string Food_name { get; set; }
        public int Food_price { get; set; }
        public int Food_num { get; set; }
        public int Food_total { get; set; }
        public int Food_discount { get; set; }
        public int Food_tax { get; set; }
        public decimal Food_alltotal { get; set; }


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
            var date = DateTime.Now.ToString("d/M/yyyy");
            var salesNumber4 = DateTime.Now.ToString("dMyy004");
            var salesNumber3 = DateTime.Now.ToString("dMyy003");
            var salesNumber2 = DateTime.Now.ToString("dMyy002");
            var salesNumber1 = DateTime.Now.ToString("dMyy001");
            var ls = new List<Form4>();
            ls.Add(new Form4 { salesNumber = Convert.ToInt32(salesNumber4), salesDate = date, table = 1 });
            ls.Add(new Form4 { salesNumber = Convert.ToInt32(salesNumber3), salesDate = date, table = 60 });
            ls.Add(new Form4 { salesNumber = Convert.ToInt32(salesNumber2), salesDate = date, table = 2 });
            ls.Add(new Form4 { salesNumber = Convert.ToInt32(salesNumber1), salesDate = date, table = 8 });
            foreach (var item in ls)
            {
                var lvi = new ListViewItem(item.salesNumber.ToString());
                lvi.SubItems.Add(item.salesDate);
                lvi.SubItems.Add(item.table.ToString());
                this.listView1.Items.Add(lvi);
            }

            //var date = DateTime.Now.ToString("d/M/yyyy");
            /*
            public string Food_name { get; set; }
            public int Food_price { get; set; }
            public int Food_num { get; set; }
            public int Food_total { get; set; }
            public int Food_discount { get; set; }
            public int Food_tax { get; set; }
            public decimal Food_alltotal { get; set; }
            */

            var lvs = new List<Form4>();
            int price = 20;
            int num = 2;
            int total = price * num;

            lvs.Add(new Form4 { Food_name = "ข้าวเปล่า (จาน)", Food_price = 20 , Food_num = 2, Food_total = total , Food_discount = 0, Food_tax = 0, Food_alltotal = total });
            //lvs.Add(new Form4 { Food_name = "ข้าวเปล่า (โถ)", Food_price = 40, Food_num = 2, Food_total = total, Food_discount = 0, Food_tax = 0, Food_alltotal = total });

            foreach (var item in lvs)
            {
                var lvis = new ListViewItem(item.Food_name.ToString());
                lvis.SubItems.Add(item.Food_price.ToString());
                lvis.SubItems.Add(item.Food_num.ToString());
                lvis.SubItems.Add(item.Food_total.ToString());
                lvis.SubItems.Add(item.Food_discount.ToString());
                lvis.SubItems.Add(item.Food_tax.ToString());
                lvis.SubItems.Add(item.Food_alltotal.ToString());
                //lvis.SubItems.Add(item.table.ToString());

                this.listView2.Items.Add(lvis);
            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString("d/M/yyyy");
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
                textBox8.Text = selData1;


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
