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


    public partial class WebForm4 : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        //String strcon = "Data Source=DESKTOP-HV70BJ3\\SQLEXPRESS;Initial Catalog=foodOrderDB;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            getfoodID();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // add button click
            if (checkFoodExists())
            {
                Response.Write("<script>alert(' already Exist with this  ID,try other ID ');</script>");
            }
            else
            {
                addNewFood();
              //  addNewFood1();
            }
        }
        //user difined funtion

        void getfoodID()
        {
            SqlConnection con = new SqlConnection(strcon);
            String myquery = "select f_id from Food";
            SqlCommand cmd = new SqlCommand(myquery, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count < 1)
            {
                Label1.Text = "101";
            }
            else
            {
                SqlConnection con1 = new SqlConnection(strcon);
                String myquery1 = "select max(f_id) from Food";
                SqlCommand cmd1 = new SqlCommand(myquery1, con);

                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.SelectCommand = cmd1;

                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                Label1.Text = ds1.Tables[0].Rows[0][0].ToString();
                int a;
                a = Convert.ToInt16(Label1.Text);
                a = a + 1;
                Label1.Text = a.ToString();

            }

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

                SqlCommand cmd = new SqlCommand("SELECT * from Food where f_id ='" + int.Parse(Label1.Text.Trim()) + "' ;", con);
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

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }

        }

        void addNewFood()
        {
            FileUpload1.SaveAs(Request.PhysicalApplicationPath + "/images/" + FileUpload1.FileName.ToString());
            String link = "/images/" + FileUpload1.FileName.ToString();

            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }



            SqlCommand cmd = new SqlCommand("INSERT INTO Food(f_id,food_name,food_desc,price,image,type,availability,category) values (@f_id,@food_name,@food_desc,@price,@image,@type,@availability,@category)", con);


            cmd.Parameters.AddWithValue("@f_id", Label1.Text);
            cmd.Parameters.AddWithValue("@food_name", TextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@food_desc", TextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@price", TextBox4.Text.Trim());
            //cmd.Parameters.AddWithValue("@qty", TextBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@category", TextBox7.Text.Trim());
            cmd.Parameters.AddWithValue("@type", TextBox8.Text.Trim());
            cmd.Parameters.AddWithValue("@availability", DropDownList1.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@image", link);


            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Food Added Successfully');</script>");
            clearForm();
            getfoodID();


        }

        /* void addNewFood1()
         {
             FileUpload1.SaveAs(Request.PhysicalApplicationPath + "/images/" + FileUpload1.FileName.ToString());
             String link = "/images/" + FileUpload1.FileName.ToString();

             SqlConnection con = new SqlConnection(strcon);
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }


             SqlCommand cmd = new SqlCommand("INSERT INTO Food1(Fid,Name,Description,Price,Image,Type,Availability,Category) values (@Fid,@Name,@Description,@Price,@Image,@Type,@Availability,@Category)", con);


             cmd.Parameters.AddWithValue("@f_id", TextBox1.Text.Trim());
             cmd.Parameters.AddWithValue("@food_name", TextBox2.Text.Trim());
             cmd.Parameters.AddWithValue("@food_desc", TextBox3.Text.Trim());
             cmd.Parameters.AddWithValue("@price", TextBox4.Text.Trim());
             //cmd.Parameters.AddWithValue("@qty", TextBox5.Text.Trim());
             cmd.Parameters.AddWithValue("@category", TextBox7.Text.Trim());
             cmd.Parameters.AddWithValue("@type", TextBox8.Text.Trim());
             cmd.Parameters.AddWithValue("@availability", DropDownList1.SelectedItem.Value);
             cmd.Parameters.AddWithValue("@image", link);


             cmd.ExecuteNonQuery();
             con.Close();
             Response.Write("<script>alert('Food Added Successfully');</script>");
             clearForm();


         }
        */
        void clearForm()
        {
           // TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            //TextBox5.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";


        }


    }
}