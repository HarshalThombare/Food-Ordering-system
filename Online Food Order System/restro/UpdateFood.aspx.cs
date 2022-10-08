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

namespace Online_Food_Order_System.restro
{
    public partial class UpdateFood : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        public object GridView1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            getInfo();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            updateFood();
            
        }

        //user defined funtion

        void getInfo()
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();

           

            /*FileUpload1.SaveAs(Server.MapPath("/images/") + Path.GetFileName(FileUpload1.FileName));
            String link = "/images/" + Path.GetFileName(FileUpload1.FileName);
            */
            String myquery = "select * from Food where f_id=" + int.Parse(Request.QueryString["f_id"].ToString());

            SqlCommand cmd = new SqlCommand(myquery, con);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            FileUpload1.SaveAs(Request.PhysicalApplicationPath + "/images/" + FileUpload1.FileName.ToString());
            String link = "/images/" + FileUpload1.FileName.ToString();

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                link = dt.Rows[0]["image"].ToString();
                TextBox1.Text = dt.Rows[0]["f_id"].ToString();
                TextBox2.Text = dt.Rows[0]["food_name"].ToString();
                TextBox3.Text = dt.Rows[0]["food_desc"].ToString();
                TextBox4.Text = dt.Rows[0]["price"].ToString();
                TextBox7.Text = dt.Rows[0]["category"].ToString();
                TextBox8.Text = dt.Rows[0]["type"].ToString();
                TextBox5.Text = dt.Rows[0]["qty"].ToString();
                DropDownList1.Text = dt.Rows[0]["availability"].ToString();


            }

            cmd.ExecuteNonQuery();
            con.Close();
        }

        void updateFood()
        {

            SqlConnection con = new SqlConnection(strcon);
            con.Open();
           

            FileUpload1.SaveAs(Request.PhysicalApplicationPath + "/images/" + FileUpload1.FileName.ToString());
            String link = "/images/" + FileUpload1.FileName.ToString();

             String query = "Update Food set food_name='" + TextBox2.Text + "', food_desc='" + TextBox3.Text + "', price='" + TextBox4.Text + "', qty='" + TextBox5.Text + "',image='" + link+ "', type='" + TextBox8.Text + "', availability='" + DropDownList1.SelectedItem.Value + "', category='" + TextBox7.Text + "' where f_id=" + TextBox1.Text;


           // String query = "Update Food set food_name='" + TextBox2.Text + "',food_desc='" + TextBox3.Text + "',price='" + TextBox4.Text + "'where f_id=" + TextBox1.Text;
            SqlCommand cmd = new SqlCommand(query,con); 

            cmd.ExecuteNonQuery();
            con.Close();
           
            Response.Write("<script>alert('Food Updated Successfully');</script>");
           //GridView1.DataBind();
        }
    }
}