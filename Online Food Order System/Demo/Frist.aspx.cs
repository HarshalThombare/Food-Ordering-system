using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Food_Order_System.Demo
{
    public partial class Frist : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        //String strcon = "Data Source=DESKTOP-HV70BJ3\\SQLEXPRESS;Initial Catalog=foodOrderDB;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

       
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (checkId())
            {
                Response.Redirect("second.aspx?id=" + TextBox1.Text);
               
            }
            else
            {
                Response.Write("<script>alert('not Exist with this  ID,try other ID ');</script>");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkFoodExists())
            {
                Response.Write("<script>alert(' already Exist with this  ID,try other ID ');</script>");
            }
            else
            {
                add();
            }
            
        }
        
        bool checkId() {
            
            Boolean id = false;

            String myquery = "select * from demo where id='"+TextBox1.Text.Trim()+"'";

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
        
        bool checkFoodExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from demo where id ='" + int.Parse(TextBox2.Text.Trim()) + "' ;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {

                   
                    return true;
                }
                else
                {
                    return false;
                }


                //
                //con.Close();
                // Response.Write("<script>alert('Added Successfully');</script>");

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }

        }

        void add()
        {
            
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            FileUpload1.SaveAs(Server.MapPath("~/pic/")+Path.GetFileName(FileUpload1.FileName));
            
           // FileUpload1.SaveAs(Request.PhysicalApplicationPath+"/images/"+FileUpload1.FileName.ToString());

            String link = "/pic/"+ Path.GetFileName(FileUpload1.FileName);
          //  String link = "images/" + FileUpload1.FileName.ToString();

            SqlCommand cmd = new SqlCommand("INSERT INTO demo(id,name,decs,price,image) values (@id,@name,@decs,@price,@image)", con);


            cmd.Parameters.AddWithValue("@id", TextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@name", TextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@decs", TextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@price", TextBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@image", link);


            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('done ');</script>");


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String myquery = "Select * from demo where id=" + TextBox2.Text;
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(myquery,con);
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
            String updatedata = "Update demo set name='" + TextBox3.Text + "', decs='" +
TextBox3.Text + "', price='" + TextBox5.Text + "' where id=" + TextBox2.Text;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(updatedata,con);
            //cmd.CommandText = updatedata;
           // cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Updated ');</script>");
           GridView1.DataBind();
            con.Close();
        }
    }
}