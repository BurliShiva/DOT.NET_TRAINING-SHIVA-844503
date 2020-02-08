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

namespace DataAccessprgmApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlcmd;
        SqlDataReader dr;

        string conString, qryString;

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10144\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();

            qryString = "Select ProductName from Products";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                cmdProducts.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
            cmdProducts.Text = "all products";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sqlCon.Open();

            qryString = "Select ProductName from Products";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
        }

        private void cmdProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "Select UnitPrice from products where productName ='" + cmdProducts.Text + "'";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            sqlCon.Open();lblPrice.Text = "Unit Price: " + sqlcmd.ExecuteScalar().ToString();
            sqlCon.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sqlCon.Open();

            //qryString = "Select ProductName from Products";
            //sqlcmd = new SqlCommand(qryString, sqlCon);

            //dr = sqlcmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    listBox1.Items.Add(dr["ProductName"]);
            //}
            //dr.Close();
            //sqlCon.Close();
        }

    }
}
