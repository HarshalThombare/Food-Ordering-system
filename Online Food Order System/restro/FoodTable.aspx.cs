using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Food_Order_System.restro
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //go to add page
            //Response.Redirect("AddFood.aspx");
            Response.Redirect("AddFood.aspx");
            
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            //go view page

            if (checkId())
            {
                Response.Redirect("ViewFood.aspx?f_id=" + TextBox1.Text);
                clear();
            }
            else
            {
                Response.Write("<script>alert('not Exist this Food ID,try other ID ');</script>");
                clear();
            }
        
        }
        protected void LinkButton3_Click2(object sender, EventArgs e)
        {
            if (checkId())
            {
                Response.Redirect("UpdateFood.aspx?f_id=" + TextBox1.Text);
                clear();
            }
            else
            {
                Response.Write("<script>alert('not Exist this Food ID,try other ID ');</script>");
                clear();
            }
        }
        protected void Button4_Click1(object sender, EventArgs e)
        {//delete 
            if (checkId())
            {
                deleteFoodByID();
            }
            else
            {
                Response.Write("<script>alert('not Exist this Food ID,try other ID ');</script>");
            }
        }

        //user defind function
        
        bool checkId()
        {

            Boolean id = false;

            String myquery = "select * from Food where f_id='" + TextBox1.Text.Trim() + "'";

            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(myquery, con);

            /*SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            */
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                id = true;
            }

            return id;
        }

        void deleteFoodByID()
        {
            String myquery = "delete from Food where f_id='" + TextBox1.Text.Trim() + "'";

            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            
            SqlCommand cmd = new SqlCommand(myquery, con);

            cmd.ExecuteNonQuery();
            con.Close();

            GridView1.DataBind();

            Response.Write("<script>alert('Food Deleted Successfully');</script>");

            clear();
        }

        void clear()
        {
            TextBox1.Text = "";
        }
       
    }
}