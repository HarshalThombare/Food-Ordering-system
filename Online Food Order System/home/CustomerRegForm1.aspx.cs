using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Food_Order_System.home
{
    public partial class CustomerRegForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"] = name.Text;
            Session["phone"] = phone.Text;
            Session["address"] = add.Text;
            Button1.PostBackUrl = "~/home/CustomerRegForm2.aspx";
        }
    }
}
