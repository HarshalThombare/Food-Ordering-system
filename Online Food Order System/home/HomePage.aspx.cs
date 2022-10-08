using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Food_Order_System.home
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("FoodForm.aspx?cat=Home Style");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("FoodForm.aspx?cat=Sandwich");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("FoodForm.aspx?cat=Ice-Cream");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("FoodForm.aspx?cat=Biryani");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("FoodForm.aspx?cat=Burger");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("FoodForm.aspx?cat=Pizza");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("FoodForm.aspx?cat=Momos");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("FoodForm.aspx?cat=Noodles");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("FoodForm.aspx?cat=Rolls");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("FoodForm.aspx?cat=Chat");
        }
    }
    
    
}