using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Food_Order_System.home
{
    public partial class CustomerRegForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = CheckBox1.Checked;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*Response.Redirect("RegistrationForm1_1.aspx"); these 2 directly redirect to other page without checking
            //or
            Server.Transfer("RegistrationForm1_1.aspx");*/
            Session["email"] = email.Text;
            Session["pwd"] = pwd.Text;
            Button1.PostBackUrl = "~/home/CustomerRegForm1.aspx";
        }
    }
}