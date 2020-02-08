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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        string conString, qryString;
        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10144\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
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

        private void button1_Click(object sender, EventArgs e)
        {
            qryString = "Select c.CustomerID,c.CompanyName,c.ContactName,c.Address,c.Country,o.OrderID,o.OrderDate," +
                "o.ShippedDate from Customers c JOIN Orders o ON o.CustomerID = c.CustomerID";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            da = new SqlDataAdapter(sqlcmd);

            da.Fill(ds, "CustomersOrderInfo");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CustomersOrderInfo";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            qryString = "Select p.ProductID,p.ProductName,p.UnitPrice,p.QuantityPerUnit,p.CategoryID," +
                "c.CategoryName from Products p JOIN Categories c ON p.CategoryID = c.CategoryID";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            da = new SqlDataAdapter(sqlcmd);

            da.Fill(ds, "ProductCategoryInfo");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ProductCategoryInfo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            qryString = "Select count(orderid) from orders ";
            sqlcmd = new SqlCommand(qryString, sqlCon);
            MessageBox.Show("Total order " + sqlcmd.ExecuteScalar().ToString());
            sqlCon.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            qryString = "Select * from products";
            // using (sqlCon = new SqlConnection(conString)
            sqlCon.Open();
            sqlcmd = new SqlCommand(qryString, sqlCon);
           
            da = new SqlDataAdapter(sqlcmd);
            ds.Clear();
            da.Fill(ds, "productsinfo");
            DataTable dt = ds.Tables["productsinfo"];
            var products = from product in dt.AsEnumerable()
                           where product.Field<decimal>("unitprice") >= 50
                           select new
                           {
                               productid = product["productid"],
                               productname = product["productname"],
                               price = product["unitprice"],
                               quantity = product["quantityperunit"]
                           };
            foreach (var product in products)
            {
                MessageBox.Show("productid =" + product.productid + "productname = " +
                    product.productname + "price = " + product.price + "quantity = " + product.quantity);
            }
            sqlCon.Close();
        }
    
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "Select * from Customers where country ='"+ comboBox1.Text+"'";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            da = new SqlDataAdapter(sqlcmd);
            ds = new DataSet();
            da.Fill(ds, "CustomersInfo");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CustomersInfo";

        }
    }
}
