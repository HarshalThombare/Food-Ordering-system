using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Food_Order_System.home
{
    public partial class ForgotPasswordForm : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        int flag;
        String nme = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submit_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(strcon);
            try
            {
                string strEmail = getemail.Text;
                string question = Request.Form["question"];
                string ans =  answer.Text;
                string str1 = "";
                con.Open();
                if (Request.Form["opt"] == "Customer")
                {
                    str1 = "select 1 from Customer where Email = '" + strEmail + "' and " + question + "='" + ans + "'";
                    flag = 1;
                }
                else if (Request.Form["opt"] == "Restaurant")
                {
                    str1 = "select 1 from Restaurant where Email = '" + strEmail + "' and "+question + "='" + ans + "'";
                    flag = 2;
                }
                SqlCommand cmd = new SqlCommand(str1, con);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    Session["email"] = strEmail;
                    Session["flag"] = flag;
                    Response.Redirect("ForgotPasswordForm1.aspx");
                }
                else
                {
                    errMessage.Text = "Enter Valid Email Id";
                    errMessage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                errMessage.Text = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}