using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FinalBuy : System.Web.UI.Page
{
    protected ShoppingBag myShoppingBag;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["myShoppingBag"] == null)
        {
            myShoppingBag = new ShoppingBag();
            ConfirmOrder.Visible = false;

        }
        else
        {
            myShoppingBag = (ShoppingBag)Session["myShoppingBag"];

        }



      
        if (!Page.IsPostBack)
        {
            PopulateGridViewCart();
        }
    }

    private void PopulateGridViewCart()
    {
        GridViewCart.DataSource = myShoppingBag.mProducts;
        GridViewCart.DataBind();
    }

    protected void GridViewCart_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        ShoppingBag myShoppingBag = (ShoppingBag)Session["myShoppingBag"];
        if (e.Row.RowType != DataControlRowType.Header && e.Row.RowType != DataControlRowType.Footer && e.Row.RowType != DataControlRowType.Pager)
        {
            if (e.Row.RowState != (DataControlRowState.Edit | DataControlRowState.Alternate) && e.Row.RowState != (DataControlRowState.Edit | DataControlRowState.Normal))
            {
                int quantity = Convert.ToInt32(e.Row.Cells[2].Text);
                double price = Convert.ToDouble(e.Row.Cells[3].Text);

                Label Price = (Label)e.Row.Cells[4].FindControl("price");
                Price.Text = (quantity * price).ToString();

            }


        }
    }



    protected void Button1_Click1(object sender, EventArgs e)
    {
                Response.Redirect("FinalPayment.aspx");
    }
}
