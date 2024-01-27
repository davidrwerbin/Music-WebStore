using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for BankWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class BankWebService : System.Web.Services.WebService
{

    public BankWebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string CheckCreditCard(string CreditNumber, string UserName, string UserID, int CSC)
    {
        BankService bs = new BankService();
        return bs.CheckCreditCard(CreditNumber, UserName, UserID, CSC);
    }
    [WebMethod]
    public void UpdateCreditCardBalanc  (double NewBalnce, String CreditNumber)
    {
        BankService bs = new BankService();
        bs.UpdateCreditCardBalance(NewBalnce, CreditNumber);
    }
    [WebMethod]
    public double GetCustomerBalnce(string CreditNumber)
    {
        BankService bs = new BankService();
        return bs.GetCustomerBalnce(CreditNumber);
    }

}
