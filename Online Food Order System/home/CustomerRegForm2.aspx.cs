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
    public partial class CustomerRegForm2 : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            /* con = new MySqlConnection("Data Source=localhost;Database=FOS;User ID=root;Password=root@123");
             con.Open();
             //Response.Write("connect");
             string nme = name.Text;
             string add = Request.Form["address"];
             string pho = phone.Text;
             Random rnd = new Random();
             int id1 = rnd.Next(1000000);
             int id2 = rnd.Next(1000);
             int id3 = rnd.Next(100);
             int id = id1 + id2 + id3;
             if (Session["email"] != null && Session["pwd"] != null)
             {
                 str = "insert into Customer values (" + id + ",'" + nme + "','" + add + "','" + pho + "','" + Session["email"] + "','" + Session["pwd"] + "')";
                 cmd = new MySqlCommand(str, con);
                 cmd.ExecuteNonQuery();
             }
             con.Close();
             Session.Abandon();*/
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
                if (Session["email"] != null && Session["pwd"] != null)
                {
                    String myquery = "insert into Customer values (" + id + ",'" + Session["name"] + "','" + Session["address"] + "','" + Session["phone"] + "','" + Session["email"] + "','" + Session["pwd"] + "','" + fnme + "','" + bplace + "','" + fplace + "')"; ;

                    SqlCommand cmd = new SqlCommand(myquery, con);
                    cmd.ExecuteNonQuery();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Register Successfully')", true);
                    //Response.Write("<script>alert('Register Successfully');</script>");
                }
            }
            catch (Exception er)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('"+er.Message+"')", true);
            }
            finally {
                con.Close();
                Session.Abandon();
                Response.Redirect("LoginForm.aspx");
            }
        }
    }
}