using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCRUD
{
    public partial class Index : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = DALC.GetAllCustomers();
                DropDownList1.Items.Clear();
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "CompanyName";
                DropDownList1.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = DropDownList1.SelectedItem.ToString();
            Label1.Text = selectedItem;
            DataSet ds = DALC.GetAllOrdersByCustomerCompanyName(selectedItem);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            GridView1.Visible = true;
        }
    }
}