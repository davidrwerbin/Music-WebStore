using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

/// <summary>
/// Summary description for Connect
/// </summary>
public class Connect
{
    const string FILENAME = "MusicShopDataBASE.mdb";
    public static string GetConnectionString()
    {
        string location = HttpContext.Current.Server.MapPath("@../../App_Data/" + FILENAME);
        //  string location = HttpContext.Current.Server.MapPath("~/App_Data/" + FILENAME);
        string ConnectionString = "Provider=Microsoft.jet.OLEDB.4.0; data source=" + location;
        return ConnectionString;
    }
}