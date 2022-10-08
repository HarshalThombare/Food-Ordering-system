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
    public partial class LoginForm1 : System.Web.UI.Page
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
                string strEmail = email.Text;
                string strPass = password.Text;
                string str1 = "";
                string str2 = "";
                con.Open();
                   if (Request.Form["opt"] == "Customer")
                   { 
                        str1 = "select 1 from Customer where Email = '" + strEmail + "' and Password= '" + strPass + "'";
                        str2 = "select Name from Customer where Email = '" + strEmail +"'";//+ "' and Password= '" + strPass + "'";
                        flag = 1;
                   }
                   else if (Request.Form["opt"] == "Admin")
                    {
                        str1 = "select 1 from Admin where Email = '" + strEmail + "' and Password= '" + strPass + "'";
                        str2 = "select Name from Admin where Email = '" + strEmail + "' and Password= '" + strPass + "'";
                        flag = 2;
                    }
                    else if (Request.Form["opt"] == "Restaurant")
                    {
                        str1 = "select 1 from Restaurant where Email = '" + strEmail + "' and Password= '" + strPass + "'";
                        str2 = "select Name from Restaurant where Email = '" + strEmail + "' and Password= '" + strPass + "'";
                        flag = 3;
                    }
                    SqlCommand cmd = new SqlCommand(str1, con);
                    var result = cmd.ExecuteScalar();
                    cmd = new SqlCommand(str2, con);
                    var name = cmd.ExecuteScalar();
                    nme = name.ToString();
                    if (result != null)
                    {
                        Session["name"] = nme;
                        if (flag==1)
                        Response.Redirect("HomePage.aspx");
                        if(flag==2)
                        Response.Redirect("../admin/Admin_Dashboard.aspx");
                        if(flag==3)
                        Response.Redirect("../restro/Restro_Dashboard.aspx");
                    }
                    else
                    {
                        errMessage.Text = "User Email Id or Password Incorrect";
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