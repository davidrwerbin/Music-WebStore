using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{
    private int OrderID;
    private string customerID;
    private int employeeID;
    private DateTime orderDate;
    private DateTime requiredDate;
    private ShoppingBag orderProducts;


    public Order()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Order(string c, int e, DateTime o, DateTime r, ShoppingBag op)
    {
        this.customerID = c;
        this.employeeID = e;
        this.orderDate = o;
        this.requiredDate = r;
        this.orderProducts = op;
    }

    public DateTime orderdate
    {
        get { return this.orderDate; }
        set { this.orderDate = value; }
    }

    public DateTime requireddate
    {
        get { return this.requiredDate; }
        set { this.requiredDate = value; }
    }


    public ShoppingBag orderproducts
    {
        get { return this.orderProducts; }
        set { this.orderProducts = value; }
    }


    public int employeeId
    {
        get { return this.employeeID; }
        set { this.employeeID = value; }
    }


    public int orderID
    {
        get { return this.OrderID; }
        set { this.OrderID = value; }
    }


    public string customerId
    {
        get { return this.customerID; }
        set { this.customerID = value; }
    }
    /// <summary>
    /// Summary description for Order
    /// </summary>
}