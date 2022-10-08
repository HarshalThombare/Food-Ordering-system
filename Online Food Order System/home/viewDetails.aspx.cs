using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Food_Order_System.home
{
    public partial class viewDetails : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            String myquery = "select * from Food where f_id=" + Request.QueryString["f_id"].ToString();

            SqlCommand cmd = new SqlCommand(myquery, con);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;


            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                Label1.Text = dt.Rows[0]["food_name"].ToString();
                Label2.Text = dt.Rows[0]["food_desc"].ToString();
                Label3.Text = dt.Rows[0]["category"].ToString();
                Label4.Text = dt.Rows[0]["type"].ToString();
                Label5.Text = dt.Rows[0]["availability"].ToString();

            }

            cmd.ExecuteNonQuery();
            con.Close();
        }

        
    }
}