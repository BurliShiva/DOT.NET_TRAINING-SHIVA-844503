using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dataaccesApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon;
        SqlCommand sqlcmd;
        SqlDataReader dr;

        string conString, qryString;


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlCon.Open();
            qryString = "Select ContactName from Customers where country ='" + comboBox1.Text + "'";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            dr = sqlcmd.ExecuteReader();
            listBox1.Items.Clear();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["ContactName"]);
            }
            dr.Close();
            sqlCon.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10144\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated                          Security=True";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();

            qryString = "Select distinct Country from Customers";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Country"]);
            }
            dr.Close();
            sqlCon.Close();
        }
    }
}
