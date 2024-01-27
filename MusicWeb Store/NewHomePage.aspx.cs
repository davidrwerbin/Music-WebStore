using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewHomePage : System.Web.UI.Page
{
    protected ShoppingBag myShoppingBag;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["myShoppingBag"] == null)
        {
            myShoppingBag = new ShoppingBag();
            ShoppingCart.Visible = false;

        }
        else
        {
            myShoppingBag = (ShoppingBag)Session["myShoppingBag"];
            ShoppingCart.Visible = true;

        }
        if(Session["IsAdmin"]!=null)
        {
            if((bool)Session["IsAdmin"]==true)
            {
                ToAdminPage.Visible = true;
            }
        }
        else
        {
            ToAdminPage.Visible = false; 
        }
    }
    protected void ImageButtonKeyBoards_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("KeyBoardsPage.aspx");
    }

    protected void ImageButtonGuitars_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("GuitarsPage.aspx");
    }

    protected void ImageButtonBowedStrings_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("BowedStringsPage.aspx");
    }

    protected void ImageButtonBrass_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("BrassPage.aspx");
    }

    protected void ImageButtonPercussions_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("PercussionsPage.aspx");
    }


    protected void ImageButtonWoodWind_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("WoodWindPage.aspx");
    }

    protected void ToAdminPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin.aspx");
    }
}