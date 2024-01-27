using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Collections;
/// <summary>
/// Summary description for ShoppingBug
/// </summary>
public class ShoppingBag
{
    public ArrayList mProducts;

    public ShoppingBag()
    {
        this.mProducts = new ArrayList();
        //
        // TODO: Add constructor logic here
        //
    }

    public ArrayList MProducts
    {
        get { return this.mProducts; }
        set { this.mProducts = value; }
    }

    public double GetFinalPrice()
    {
        double sum = 0;
        foreach (ProductInBag P in mProducts)
        {
            ProductInBag x = (ProductInBag)P;
            sum = sum + (x.mprice * x.mquantity);
        }
        return sum;
    }

    public int NumOfProducts(ProductInBag product)
    {
        foreach (ProductInBag pb in mProducts)
            if (pb.ProductID == product.ProductID)
            {
                return pb.mquantity;
            }
        return 0;
    }

    public void AddProduct(ProductInBag InProduct)
    {
        bool done = false;
        foreach (ProductInBag pb in mProducts)
            if (pb.ProductID == InProduct.ProductID)
            {
                pb.mquantity += InProduct.mquantity;
                done = true;
                break;
            }
        if (!done)
            mProducts.Add(InProduct);
    }

    public void DeleteProduct(ProductInBag InProduct)
    {
        foreach (ProductInBag pb in mProducts)
            if (pb.ProductID == InProduct.ProductID)
            {
                mProducts.Remove(pb);
                break;
            }
    }

    public void UpdateProduct(ProductInBag InProduct)
    {
        foreach (ProductInBag P in mProducts)
        {
            if (P.ProductID == InProduct.ProductID)
            {
                P.mquantity = InProduct.mquantity;
                break;
            }
        }
    }

    public DataSet ConvertToViewDataTable()
    {
        DataTable dt = new DataTable();
        DataColumn[] dtcol = new DataColumn[] { new DataColumn("ProductID"), new DataColumn("ProductName"), new DataColumn("mPrice"), new DataColumn("mQuantity") };
        dt.Columns.AddRange(dtcol);
        foreach (ProductInBag pb in mProducts)
        {
            DataRow dr = dt.NewRow();
            dr["ProductID"] = pb.ProductID;
            dr["ProductName"] = pb.ProductName;
            dr["mPrice"] = pb.mprice;
            dr["mQuantity"] = pb.mquantity;
            dt.Rows.Add(dr);
        }
        DataSet ds = new DataSet();
        ds.Tables.Add(dt);
        ds.Tables[0].TableName = "ShoppingBag";
        return ds;
    }
}