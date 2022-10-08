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
    public partial class RestaurantRequestForm : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            try
            {
                string str1 = "";
                con.Open();
                str1 = "SELECT Name,Address,City,Contact,Email from Restaurant where Status='deactivate'";
                SqlCommand cmd = new SqlCommand(str1, con);
                reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();

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

        /* protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
         {
             Label Email = GridView1.Rows[e.RowIndex].Findcontrol("Label5") as Label;
             string updatedata = "update Restaurant set Status='activate' where Email='" + Email.Text + "'";
             SqlConnection con = new SqlConnection(strcon);
             con.Open();
             SqlCommand cmd = new SqlCommand(updatedata, con);
             int success = cmd.ExecuteNonQuery();
             System.Windows.Forms.MessageBox.Show("Restro Has Been Activated Successfully");
             GridView1.EditIndex = -1;
             string str1 = "SELECT Name,Address,City,Contact,Email from Restaurant where Status='deactivate'";
             SqlCommand cmd2 = new SqlCommand(str1, con);
             reader = cmd2.ExecuteReader();
             GridViewl.Datasource = reader;
             Gridview1.DataBind();
         }*/

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Button Email = GridView1.Rows[e.RowIndex].Findcontrol("Accept") as Button;
        }

    }
}