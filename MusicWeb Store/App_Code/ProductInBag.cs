using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductInBag
/// </summary>
public class ProductInBag:ProductDetails
{
	private double mPrice;
    private System.Int32 mQuantity;

    public ProductInBag(int productID, string productName)
        : base(productID, productName)
    {
        this.mPrice = 0;
        this.mQuantity = 1;
    }

	public ProductInBag(int productID, string productName, System.Int32 mQuantity, double mPrice) :base(productID, productName)
	{
		//
		// TODO: Add constructor logic here
		//
        this.mPrice = mPrice;
        this.mQuantity = mQuantity;
	}

    public ProductInBag()
        : base()
    {
    }


    public ProductInBag(int productID)
        : base(productID)
    {
    }

    public double mprice
    {
        get { return this.mPrice; }
        set { this.mPrice = value; }
    }

    public System.Int32 mquantity
    {
        get { return this.mQuantity; }
        set { this.mQuantity = value; }
    }
}