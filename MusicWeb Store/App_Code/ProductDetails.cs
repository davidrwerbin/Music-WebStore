using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductDetails
/// </summary>
public class ProductDetails
{

    private int productID;
    private string productName;
    private double price;
    private string color;
    private int countryID;
    private int categoryID;
    private string picture;
    private int leftInStore;
    private int supplierID;


	public ProductDetails()
	{
		
	}

    public ProductDetails(int productID, string productName)
    {
        this.productID = productID;
        this.productName = productName;
    }

    public ProductDetails(int productID)
    {
        this.productID = productID;
    }

    public int ProductID
    {
        get { return this.productID; }
        set { this.productID = value; }
    }

    public string ProductName
    {
        get { return this.productName; }
        set { this.productName = value; }
    }

    public double Price
    {
        get { return this.price; }
        set { this.price = value; }
    }

    public string Color
    {
        get { return this.color; }
        set { this.color = value; }
    }

    public int CountryID
    {
        get { return this.countryID; }
        set { this.countryID = value; }
    }

    public string Picture
    {
        get { return this.picture; }
        set { this.picture = value; }
    }

    public int LeftInStore
    {
        get { return this.leftInStore; }
        set { this.leftInStore = value; }
    }

    public int SupplierID
    {
        get { return this.supplierID; }
        set { this.supplierID = value; }
    }

    public int CategoryID
    {
        get { return this.categoryID; }
        set { this.categoryID = value; }
    }
}