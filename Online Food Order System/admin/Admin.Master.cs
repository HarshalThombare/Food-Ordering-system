using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Food_Order_System.admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Session["name"].ToString();
            Label2.Text = "Welcome "+name;

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../home/HomePage.aspx");
        }
    }
}