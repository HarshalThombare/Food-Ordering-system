using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Food_Order_System.home
{
    public partial class FoodForm : System.Web.UI.Page
    {
        String strcon = "Data Source=DESKTOP-HV70BJ3\\SQLEXPRESS;Initial Catalog=foodOrderDB;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["cat"] != null)

            {
                DataList1.DataSourceID = null;
                DataList1.DataSource = SqlDataSource2;
                DataList1.DataBind();
            }
            else
            {
                DataList1.DataSourceID = null;
                DataList1.DataSource = SqlDataSource1;
                DataList1.DataBind();

            }

            
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DataList1_SelectedIndexChanged1(object sender, EventArgs e)
        {


        }

       
        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            //addToCart();

            Response.Write("<script>alert('Food Added Successfully');</script>");
        }
        //user defined function
         void addId()
         {
            


        }



        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }

        }

}