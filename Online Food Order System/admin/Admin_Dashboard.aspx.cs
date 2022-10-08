using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Food_Order_System.admin
{
    public partial class Admin_Dashboard : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            try
            {
                string str1 = "";
                string str2 = "";
                string str3 = "";
                string cust = "";
                string rest = "";
                string req = "";
                con.Open();
                    str1 = "select count(*) from Customer";
                    str2 = "select count(*) from Restaurant";
                    str3 = "SELECT count(*) from Restaurant where Status='deactivate'";
                SqlCommand cmd = new SqlCommand(str1, con);
                var custcount = cmd.ExecuteScalar();
                cust = custcount.ToString();
                Label2.Text = cust;
                cmd = new SqlCommand(str2, con);
                var restcount = cmd.ExecuteScalar();
                rest = restcount.ToString();
                Label1.Text = rest;
                cmd = new SqlCommand(str3, con);
                var reqcount = cmd.ExecuteScalar();
                req = reqcount.ToString();
                Label4.Text = req;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
            finally
            {
                con.Close();
            }
        }
    }
}