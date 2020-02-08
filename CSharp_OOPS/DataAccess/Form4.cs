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
    public partial class Form4 : Form
    {
        SqlConnection sqlCon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
     
        string conString, qryString;
        public Form4()
        {
            InitializeComponent();
        }

        private void cmbcountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            conString = "data source=BLT10144\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlCon = new SqlConnection(conString);

            sqlcmd = new SqlCommand();
           sqlcmd.CommandText = "GetCustomersByCountrys ";
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Connection = sqlCon;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Country";
            param.DbType = DbType.String;
            param.Value = cmbcountries.Text;

            sqlcmd.Parameters.Add(param);
            da = new SqlDataAdapter(sqlcmd);
            ds.Clear();
            da.Fill(ds, "CustomerByCountry");

            gvcustomers.DataSource = ds;
            gvcustomers.DataMember = "CustomerByCountry";

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10144\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlCon = new SqlConnection(conString);
            ds = new DataSet();
            using (sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                qryString = "Select distinct Country from Customers";
                sqlcmd = new SqlCommand(qryString, sqlCon);

                dr = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    cmbcountries.Items.Add(dr["Country"]);
                }
                dr.Close();
            }
           
        }
    }
}
