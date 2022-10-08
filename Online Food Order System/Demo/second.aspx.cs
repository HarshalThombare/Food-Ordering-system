using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Food_Order_System.Demo
{
    public partial class second : System.Web.UI.Page
    {
        String strcon = "Data Source=DESKTOP-HV70BJ3\\SQLEXPRESS;Initial Catalog=foodOrderDB;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<script>alert('done ');</script>");
            //if (Request.QueryString["id"] != null)
            //{
            
                //String mycon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
               
                
                SqlConnection con = new SqlConnection(strcon);
                con.Open();

                String myquery = "select * from demo where id=" + Request.QueryString["id"].ToString();

                SqlCommand cmd = new SqlCommand(myquery,con);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
             
            DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    Label2.Text = dt.Rows[0]["id"].ToString();
                    Label4.Text = dt.Rows[0]["name"].ToString();
                    Label6.Text = dt.Rows[0]["decs"].ToString();
                    Label8.Text = dt.Rows[0]["price"].ToString();
                //Image1 = dt.Rows[0]["image"].ToString();
               
                }
                
            cmd.ExecuteNonQuery();
                con.Close();
            //}
            //else
            //{
              //  Label11.Text = "No Roll Number Found in Query String";
                //Response.Write("<script>alert('not found ');</script>");
            //}

        
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String myquery = "Select * from demo where id=" + TextBox2.Text;
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(myquery, con);
            // cmd.CommandText = myquery;
            // cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                TextBox5.Text = ds.Tables[0].Rows[0]["price"].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0]["name"].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0]["decs"].ToString();
                // FileUpload1 = ds.Tables[0].Rows[0]["image"].ToString();
            }
            else
            {

                Response.Write("<script>alert('not found ');</script>");

            }
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String updatedata = "Update demo set name='" + TextBox3.Text + "', decs='" +TextBox3.Text + "', price='" + TextBox5.Text + "' where id=" + TextBox2.Text;

           // String updatedata = "UPDATE demo set name = @name,decs = @decs,price = @price where id = '" + TextBox2.Text;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(updatedata, con);


            //cmd.CommandText = updatedata;
            // cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Updated ');</script>");
           // GridView1.DataBind();
            con.Close();
        }

       

        protected void Button4_Click1(object sender, EventArgs e)
        {
            String myquery = "Select * from demo1 where id=" + TextBox2.Text;
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(myquery, con);
            // cmd.CommandText = myquery;
            // cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                TextBox5.Text = ds.Tables[0].Rows[0]["price"].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0]["name"].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0]["decs"].ToString();
                // FileUpload1 = ds.Tables[0].Rows[0]["image"].ToString();
            }
            else
            {

                Response.Write("<script>alert('not found ');</script>");

            }
            con.Close();

            //add
            String updatedata = "Update demo set name='" + TextBox3.Text + "', decs='" + TextBox3.Text + "', price='" + TextBox5.Text + "' where id=" + TextBox2.Text;

            // String updatedata = "UPDATE demo set name = @name,decs = @decs,price = @price where id = '" + TextBox2.Text;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(updatedata, con);


            //cmd.CommandText = updatedata;
            // cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Updated ');</script>");
            // GridView1.DataBind();
            con.Close();

        }
    }
}