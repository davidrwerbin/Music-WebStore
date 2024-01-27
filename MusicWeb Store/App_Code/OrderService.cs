using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for OrderService
/// </summary>
public class OrderService
{
    private OleDbTransaction myTrans;
    private OleDbConnection conn;
    protected int NEWorderid;



    public OrderService()
    {
        //
        // TODO: Add constructor logic here
        //
        this.conn = new OleDbConnection(Connect.GetConnectionString());
    }


    public int CreateOrder(Order order)
    {
        OleDbCommand cmd = new OleDbCommand("InsertOrderYES", this.conn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        OleDbParameter objParam;

        objParam = cmd.Parameters.Add("@UserID", OleDbType.BSTR);
        objParam.Direction = System.Data.ParameterDirection.Input;
        objParam.Value = order.customerId;

        objParam = cmd.Parameters.Add("@OrderDate", OleDbType.DBDate);
        objParam.Direction = System.Data.ParameterDirection.Input;
        objParam.Value = order.orderdate;

        OleDbCommand cmd2 = new OleDbCommand("SELECT OrderID from Orders ORDER BY OrderID DESC", this.conn);
        int orderid = 0;

        try
        {
            this.conn.Open();
            //this.myTrans = this.conn.BeginTransaction();
            cmd.Transaction = this.myTrans;
            cmd.ExecuteNonQuery();
            cmd2.Transaction = this.myTrans;
            orderid = Convert.ToInt32(cmd2.ExecuteScalar());
            foreach (ProductInBag pb in order.orderproducts.MProducts)
                AddOrderDetail(orderid, pb.ProductID, pb.mprice, pb.mquantity, 0);
            //  this.myTrans.Commit();
        }
        catch (Exception ex)
        {
            //    this.myTrans.Rollback();
            throw ex;
        }
        finally
        {
            this.conn.Close();
        }
        NEWorderid = orderid;
        return orderid;
    }


    private void AddOrderDetail(int orderid, int productid, double unitprice, int quantity, decimal discount)
    {
        OleDbCommand myCmd3 = this.conn.CreateCommand();
        myCmd3.CommandText = "insert into OrderDetails(OrderID,ProductID, UnitPrice,Quantity,Discount) values ([@orderid],[@productid],[@unitprice],[@quantity],[@discount])";

        OleDbParameter para1 = myCmd3.Parameters.Add("@orderid", OleDbType.Integer);
        para1.Direction = ParameterDirection.Input;
        para1.Value = orderid;

        OleDbParameter para2 = myCmd3.Parameters.Add("@productid", OleDbType.Integer);
        para2.Direction = ParameterDirection.Input;
        para2.Value = productid;

        OleDbParameter para3 = myCmd3.Parameters.Add("@unitprice", OleDbType.BSTR);
        para3.Direction = ParameterDirection.Input;
        para3.Value = unitprice;

        OleDbParameter para4 = myCmd3.Parameters.Add("@quantity", OleDbType.Integer);
        para4.Direction = ParameterDirection.Input;
        para4.Value = quantity;

        OleDbParameter para5 = myCmd3.Parameters.Add("@discount", OleDbType.Integer);
        para5.Direction = ParameterDirection.Input;
        para5.Value = discount;


        try
        {
            myCmd3.Transaction = myTrans;
            myCmd3.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }


    public DataSet GetOrderBy(int OrderId, string CustomerId)
    {
        OleDbCommand objCmd = new OleDbCommand("GetOrderByID", this.conn);
        objCmd.CommandType = System.Data.CommandType.StoredProcedure;
        OleDbDataAdapter adapter = new OleDbDataAdapter(objCmd);
        DataSet ds = new DataSet();

        OleDbParameter param1;
        param1 = objCmd.Parameters.Add("@OrderID", OleDbType.BSTR);
        param1.Direction = ParameterDirection.Input;
        param1.Value = OrderId;

        OleDbParameter param2;
        param2 = objCmd.Parameters.Add("@CustomerID", OleDbType.BSTR);
        param2.Direction = ParameterDirection.Input;
        param2.Value = CustomerId;

        try
        {
            this.conn.Open();
            adapter.Fill(ds, "Orders");
            return ds;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            this.conn.Close();
        }
        return null;
    }
}