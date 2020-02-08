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

namespace DataAdapter
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
        SqlDataAdapter da;
        DataSet ds;

        string conString, qryString;

        private void button1_Click(object sender, EventArgs e)
        {
            qryString = "Select ProductID,ProductName,UnitPrice,QuantityPerUnit,CategoryID from Products";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            da = new SqlDataAdapter(sqlcmd);
            ds = new DataSet();
            da.Fill(ds,"ProductsInfo");
            gvProducts.DataSource = ds;
            gvProducts.DataMember = "ProductsInfo";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            qryString = "Select * from Categories";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            da = new SqlDataAdapter(sqlcmd);
            ds = new DataSet();
            da.Fill(ds, "CategoriesInfo");
            gvProducts.DataSource = ds;
            gvProducts.DataMember = "CategoriesInfo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10144\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlCon = new SqlConnection(conString);

        }
    }
}
