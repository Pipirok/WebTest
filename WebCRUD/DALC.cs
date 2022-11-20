using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebCRUD
{
    public class DALC
    {
        private static SqlConnection conn = new SqlConnection(DALS.conn);

        public static DataSet GetAllCustomers()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers;", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public static DataSet GetAllOrdersByCustomerCompanyName(string CompanyName)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers WHERE CompanyName=@CompanyName", conn);
            cmd.Parameters.AddWithValue("CompanyName", CompanyName);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }
    }
}