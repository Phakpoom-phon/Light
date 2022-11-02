using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    internal class Center
    {

        // Conecting String.


        private static string GetConnectionString()
        {
            String conString = "Data Source=DESKTOP-INO3CT4\\SQLEXPRESS;Initial Catalog=Sijin;Persist Security Info=True;User ID=jamegool;Password=1108";
            return conString;
        }
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand("", con);
        public static SqlDataAdapter rd;
        public static DataSet ds;
        public static SqlDataAdapter da;
        public static BindingSource bs;
        //SELECT , INSERT , UPDATE , DELETE
        public static string sql;

        public static void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = GetConnectionString();
                con.Open();
                MessageBox.Show("con is " + con.State.ToString());
            }
        }

        public static void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Open();
                MessageBox.Show("con is " + con.State.ToString());
            }
        }

    }
}
