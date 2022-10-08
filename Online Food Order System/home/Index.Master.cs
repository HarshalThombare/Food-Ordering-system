using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Food_Order_System.home
{
    public partial class Index : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinkButton3.Visible = false;


            if (Session["name"] == null)
            {
               
                LinkButton1.Visible = true;
                LinkButton2.Visible = true;
                HyperLink1.Visible = false;
                Label1.Visible = false;
                              
            }
            else
            {
                string name = Session["name"].ToString();
                Label2.Text = "Welcome "+ name;
                LinkButton1.Visible = false;
                LinkButton2.Visible = false;
                LinkButton3.Visible = true;
                HyperLink1.Visible = true;
            }

            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];
            if (dt != null)
            {

                Label1.Text = dt.Rows.Count.ToString();
            }
            else
            {
                Label1.Text = "0";

            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("RestaurantRegForm.aspx");
            
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginForm.aspx");

        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("HomePage.aspx");
        }
    }
}