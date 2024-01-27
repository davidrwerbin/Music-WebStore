using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.OleDb;
/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    [WebMethod]
    public DataSet GetProducts()
    {
        ProductService pd = new ProductService();
        return pd.GetProducts();
    }
    [WebMethod]
    public void UpdateProductPrice()
    {
        ProductDetails pt = new ProductDetails();
        pt.ProductID = 2;
        pt.Price = 50;
        ProductService ps = new ProductService();
        ps.UpdateProductPrice(pt);
    }
     [WebMethod]
    public void DeleteProduct(int productID)
    {
        ProductService pd = new ProductService();
        pd.DeleteProduct(productID);
    }
     [WebMethod]
     public void DeleteUser(int userID)
     {
         ProductService pd = new ProductService();
         pd.DeleteUser(userID);
     }
     [WebMethod]
     public DataSet GetUsers()
     {
         UserService USE = new UserService();
         return USE.GetUsers();
     }
     //[WebMethod]
     //public void AddUser()
     //{
     //    UserDetails user = new UserDetails();
     //    user.UserID = 58;
     //    user.UserName = "pedro";
     //    user.UserLastName = "Dayan";
     //    user.Password1 = "1234";
     //    user.Phone = "7438920";
     //    user.Email = "ILAYDAYAN@HDF";
     //    UserService USE = new UserService();
     //    USE.AddUser(user);
     //}
     [WebMethod]
     public void AddProduct()
     {
         ProductDetails product = new ProductDetails();
         product.ProductName = "tt";
         product.Price = 2000;
         product.Color = "Brue";
         product.Picture = "Img2";
         product.CategoryID = 2;
         product.CountryID = 1;
         product.SupplierID = 1;
         product.LeftInStore = 45;
         ProductService producto = new ProductService();
         producto.AddProduct(product);
     }

     [WebMethod]
     public int LoginFunction()
     {
         UserService US = new UserService();
         return US.LoginFunction("Ilay", "1234"); 
     }
     [WebMethod]
     public DataSet GetProductsByCategoryName()
     {
         ProductService pd = new ProductService();
         return pd.GetProductsByCategoryName("Keyboard");
     }
}
