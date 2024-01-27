using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FinalPayment : System.Web.UI.Page
{
    mybank.BankWebService myBank = new mybank.BankWebService();
    ShoppingBag myShoppingBag;

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
    }

   


    protected void BuyNow_Click(object sender, EventArgs e)
    {
            if (myBank.CheckCreditCard(CreditNumber.Text, UserName.Text, UserID.Text, int.Parse(CSC.Text)) != "wrong")
            {
                OrderService orderS = new OrderService();
                Order order1 = new Order();
                order1.customerId = UserID.Text;
                order1.orderproducts = (ShoppingBag)Session["myShoppingBag"];
                int orderID = orderS.CreateOrder(order1);
                double currentBalance = myBank.GetCustomerBalnce(CreditNumber.Text);
                myBank.UpdateCreditCardBalanc(currentBalance - double.Parse(myShoppingBag.GetFinalPrice().ToString()), CreditNumber.Text);
                Session["orderID"] = orderID;
            Response.Redirect("FinishOrder.aspx");
            }
            
        
    }
}

