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
    public partial class RestaurantRegForm2 : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            try
            {
                con.Open();
                string fnme = fathername.Text;
                string bplace = bornplace.Text;
                string fplace = fvrteplace.Text;
                Random rnd = new Random();
                int id1 = rnd.Next(1000000);
                int id2 = rnd.Next(1000);
                int id3 = rnd.Next(100);
                int id = id1 + id2 + id3;
                if (Session["email"] != null && Session["pwd"] != null && Session["name"] != null && Session["phone"] != null && Session["address"] != null && Session["city"] != null)
                {
                    String myquery = "insert into Restaurant values (" + id + ",'" + Session["name"] + "','" + Session["address"] + "','" + Session["city"] +"','"+ Session["phone"] + "','" + Session["email"] + "','" + Session["pwd"] + "','" + fnme + "','" + bplace + "','" + fplace + "','deactivate')"; ;

                    SqlCommand cmd = new SqlCommand(myquery, con);
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('Register Successfully');</script>");
                }
                else
                {
                    Response.Redirect("RestaurantRegForm.aspx");
                }
            }
            catch (Exception er)
            {
                Response.Write("<script>alert('" + er.Message + "');</script>");
            }
            finally {
                con.Close();
                Session.Abandon();
                Response.Redirect("LoginForm.aspx");
            }
        }
    }
}