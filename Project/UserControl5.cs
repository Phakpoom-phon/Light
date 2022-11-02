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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();

        }

        int count = 0;
        public void button17_Click(object sender, EventArgs e)
        {
            /*login login = new login();
            login.Size = new Size(1200, 700);
            login.Show();*/
            //login.Resize
            //Form1 f1 = new Form1();
            //f1.Hide();
            //(Form2)

            //if (count == 0)
            //{
                Management f2 = new Management();
                f2.ShowDialog();
            //    count += 1;
            //}
            //else 
            //{
                
            //}

            
            

        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

        }
    }
}
