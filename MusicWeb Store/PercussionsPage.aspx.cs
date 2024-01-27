using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PercussionsPage : System.Web.UI.Page
{
    protected ShoppingBag myShoppingBag;
    int x = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["myShoppingBag"] == null)
        {
            myShoppingBag = new ShoppingBag();

        }
        else
        {
            myShoppingBag = (ShoppingBag)Session["myShoppingBag"];

        }
        if (!Page.IsPostBack)
        {

            PopulateDataListPercussions();
        }
    }

    protected void PopulateDataListPercussions()
    {
        ProductService ps = new ProductService();
        this.DataListPercussions.DataSource = ps.GetProductsByCategory(4);
        this.DataListPercussions.DataBind();
    }
    protected void DataListPercussions_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "AddToCart")
        {
            x++;
            int productID = int.Parse(((Label)e.Item.FindControl("ProductID")).Text);
            //int quantity = int.Parse(((Label)e.Item.FindControl("Quantity")).Text);
            string productName = ((Label)e.Item.FindControl("ProductName")).Text;
            //string color = ((Label)e.Item.FindControl("Color")).Text;
            //string picture = ((Label)e.Item.FindControl("Picture")).Text;
            //int leftInStore = int.Parse(((Label)e.Item.FindControl("LeftInStore")).Text);
            double price = double.Parse(((Label)e.Item.FindControl("Price")).Text);
            //int countryID = int.Parse(((Label)e.Item.FindControl("CountryID")).Text);
            //int categoryID = int.Parse(((Label)e.Item.FindControl("CategoryID")).Text);
            ProductInBag p = new ProductInBag(productID, productName, 1, price); // add as much details
            myShoppingBag.AddProduct(p);
            Page.Session["myShoppingBag"] = myShoppingBag;
            Label1.Visible = true;

        }
    }
}