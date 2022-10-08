using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Online_Food_Order_System.home
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                Response.Redirect("LoginForm.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    DataTable dt = new DataTable();
                    DataRow dr;
                    dt.Columns.Add("sno");
                    dt.Columns.Add("f_id");
                    dt.Columns.Add("food_name");
                    dt.Columns.Add("qty");
                    dt.Columns.Add("price");
                    dt.Columns.Add("totalprice");
                    dt.Columns.Add("image");


                    if (Request.QueryString["f_id"] != null)
                    {
                        if (Session["Buyitems"] == null)
                        {

                            dr = dt.NewRow();
                            SqlConnection scon = new SqlConnection(strcon);
                            String myquery = "select * from Food where f_id=" + Request.QueryString["f_id"];
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandText = myquery;
                            cmd.Connection = scon;
                            SqlDataAdapter da = new SqlDataAdapter();
                            da.SelectCommand = cmd;
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            dr["sno"] = 1;
                            dr["f_id"] = ds.Tables[0].Rows[0]["f_id"].ToString();
                            dr["food_name"] = ds.Tables[0].Rows[0]["food_name"].ToString();
                            dr["image"] = ds.Tables[0].Rows[0]["image"].ToString();
                            dr["quantity"] = ds.Tables[0].Rows[0]["qty"].ToString();
                            dr["price"] = ds.Tables[0].Rows[0]["price"].ToString();
                            int price = Convert.ToInt16(ds.Tables[0].Rows[0]["price"].ToString());
                            int quantity = Convert.ToInt16(Request.QueryString["qty"].ToString());
                            int totalprice = price * quantity;
                            dr["totalprice"] = totalprice;
                            savecartdetail(1, ds.Tables[0].Rows[0]["f_id"].ToString(), ds.Tables[0].Rows[0]["food_name"].ToString(), ds.Tables[0].Rows[0]["image"].ToString(), ds.Tables[0].Rows[0]["qty"].ToString(), ds.Tables[0].Rows[0]["price"].ToString(), totalprice.ToString());
                            dt.Rows.Add(dr);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();

                            Session["buyitems"] = dt;
                            GridView1.FooterRow.Cells[5].Text = "Total Amount";
                            GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                            Response.Redirect("AddToCart.aspx");

                        }
                        else
                        {

                            dt = (DataTable)Session["buyitems"];
                            int sr;
                            sr = dt.Rows.Count;

                            dr = dt.NewRow();
                            SqlConnection scon = new SqlConnection(strcon);
                            String myquery = "select * from Food where f_id=" + Request.QueryString["f_id"];
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandText = myquery;
                            cmd.Connection = scon;
                            SqlDataAdapter da = new SqlDataAdapter();
                            da.SelectCommand = cmd;
                            DataSet ds = new DataSet();
                            da.Fill(ds);

                            dr["sno"] = sr + 1;
                            dr["f_id"] = ds.Tables[0].Rows[0]["f_id"].ToString();
                            dr["food_name"] = ds.Tables[0].Rows[0]["food_name"].ToString();
                            dr["image"] = ds.Tables[0].Rows[0]["image"].ToString();
                            dr["qty"] = ds.Tables[0].Rows[0]["qty"].ToString();
                            dr["price"] = ds.Tables[0].Rows[0]["price"].ToString();
                            int price = Convert.ToInt16(ds.Tables[0].Rows[0]["price"].ToString());
                            int qty = 1;
                            int totalprice = price * qty;
                            dr["totalprice"] = totalprice;
                            savecartdetail(sr + 1, ds.Tables[0].Rows[0]["f_id"].ToString(), ds.Tables[0].Rows[0]["food_name"].ToString(), ds.Tables[0].Rows[0]["image"].ToString(), ds.Tables[0].Rows[0]["qty"].ToString(), ds.Tables[0].Rows[0]["price"].ToString(), totalprice.ToString());
                            dt.Rows.Add(dr);

                            GridView1.DataSource = dt;
                            GridView1.DataBind();

                            Session["buyitems"] = dt;
                            GridView1.FooterRow.Cells[5].Text = "Total Amount";
                            GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                            Response.Redirect("AddToCart.aspx");
                        }
                    }

                    else
                    {
                        // DataTable dt = new DataTable();
                        dt = (DataTable)Session["buyitems"];
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        if (GridView1.Rows.Count > 0)
                        {
                            GridView1.FooterRow.Cells[5].Text = "Total Amount";
                            GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();

                        }


                    }
                    //Label1.Text = GridView1.Rows.Count.ToString();

                }
            }
            //user fuction
                  int grandtotal()
                {
                    DataTable dt = new DataTable();
                    dt = (DataTable)Session["buyitems"];
                    int nrow = dt.Rows.Count;
                    int i = 0;
                    int gtotal = 0;
                    while (i < nrow)
                    {
                        gtotal = gtotal + Convert.ToInt32(dt.Rows[i]["totalprice"].ToString());

                        i = i + 1;
                    }
                    return gtotal;
                }

                void savecartdetail(int sno, String f_id, String food_name, String image, String qty, String price, String totalprice)
                {
                    String query = "insert into savedcartdetail(sno,f_id,food_name,image,qty,price,totalprice,name) values(" + sno + ",'" + f_id + "','" + food_name + "','" + image + "','" + qty + "','" + price + "','" + totalprice + "','" + Session["name"].ToString() + "')";
                    SqlConnection con = new SqlConnection(strcon);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    // cmd.ExecuteNonQuery();
                }

            }
        }
    }
