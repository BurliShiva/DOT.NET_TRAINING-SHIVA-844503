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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlcmd;
        SqlDataReader dr;

        string conString, qryString;

        private void Form3_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10144\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();

            qryString = "Select ProductName from Products";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
            comboBox1.Text = "all products";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "Select UnitPrice from products where productName ='" + comboBox1.Text + "'";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            sqlCon.Open(); label1.Text = "Unit Price: " + sqlcmd.ExecuteScalar().ToString();
            sqlCon.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            qryString = "update Products Set Unitprice = "+Convert.ToDouble(textBox1.Text) +
                "where ProductName = '" + comboBox1.Text + "'";
            sqlcmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Product Update", "New Product Price");
            sqlCon.Close();
        }
    }
}
