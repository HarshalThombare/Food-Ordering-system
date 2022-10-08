using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Food_Order_System.restro
{
    public partial class R_admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Session["name"].ToString();
            Label2.Text = name;

        }

        

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../home/HomePage.aspx");

        }
    }
}