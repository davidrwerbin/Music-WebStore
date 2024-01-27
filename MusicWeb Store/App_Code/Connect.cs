using System;
using System.Web;
public class Connect
{
    const string FILENAME = "MusicShop.mdb";
    public static string GetConnectionString()
    {
        //string location = HttpContext.Current.Server.MapPath("@../../App_Data/" + FILENAME);
        string location = HttpContext.Current.Server.MapPath("~/App_Data/" + FILENAME);
        string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; data source=" + location;
        return ConnectionString;
    }
}
