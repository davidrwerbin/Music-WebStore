using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;    
    


/// <summary>
/// Summary description for ProductService
/// </summary>
public class ProductService
{
    private OleDbConnection objConn;
    private OleDbCommand objCmd;
    private OleDbTransaction objTrans;
    private string connectionString;

    public ProductService()
    {
        this.connectionString = Connect.GetConnectionString();
        objConn = new OleDbConnection(this.connectionString);
    }

    public DataSet GetProducts()
    {
        objCmd = new OleDbCommand("GetProducts", objConn);
        objCmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        try
        {
            this.objConn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(objCmd);
            da.Fill(ds);
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            objCmd.Connection.Close();
        }
        return ds;
    }

    public void UpdateProductPrice(ProductDetails product)
    {
        OleDbCommand objCmd = new OleDbCommand("UpdateProductPrice", objConn);
        objCmd.CommandType = CommandType.StoredProcedure;

        OleDbParameter param6;
        param6 = objCmd.Parameters.Add("@NewPrice", OleDbType.Double);
        param6.Direction = ParameterDirection.Input;
        param6.Value = product.Price;

        OleDbParameter param;
        param = objCmd.Parameters.Add("@ProductID", OleDbType.Integer);
        param.Direction = ParameterDirection.Input;
        param.Value = product.ProductID;

        try
        {
            this.objConn.Open();
            objCmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            this.objConn.Close();
        }
    }

    public void DeleteProduct(int productID)
    {
        OleDbCommand objCmd = new OleDbCommand("DeleteProduct", objConn);
        objCmd.CommandType = CommandType.StoredProcedure;

        OleDbParameter param;
        param = objCmd.Parameters.Add("@ProductID", OleDbType.Integer);
        param.Direction = ParameterDirection.Input;
        param.Value = productID;

        try
        {
            this.objConn.Open();
            objCmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            this.objConn.Close();
        }
    }

    public void DeleteUser(int userID)
    {
        OleDbCommand objCmd = new OleDbCommand("DeleteUser", objConn);
        objCmd.CommandType = CommandType.StoredProcedure;

        OleDbParameter param;
        param = objCmd.Parameters.Add("@userID", OleDbType.Integer);
        param.Direction = ParameterDirection.Input;
        param.Value = userID;

        try
        {
            this.objConn.Open();
            objCmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            this.objConn.Close();
        }
    }

    //    INSERT INTO Products ( ProductName, CategoryID, Price, Color, CountryID, Picture, LeftInStore, SupplierID )
    //VALUES ([@ProductName ], [@CategoryID ], [@Price ], [@Color], [@CountryID ], [@Picture ], [@LeftInStore ], [@SupplierID]);

    public void AddProduct(ProductDetails product)
    {
        OleDbCommand objCmd = new OleDbCommand("AddProduct", objConn);
        objCmd.CommandType = CommandType.StoredProcedure;

        OleDbParameter param1;
        param1 = objCmd.Parameters.Add("@ProductName", OleDbType.BSTR);
        param1.Direction = ParameterDirection.Input;
        param1.Value = product.ProductName;

        OleDbParameter param9;
        param9 = objCmd.Parameters.Add("@CategoryID", OleDbType.Integer);
        param9.Direction = ParameterDirection.Input;
        param9.Value = product.CategoryID;


        OleDbParameter param2;
        param2 = objCmd.Parameters.Add("@Price", OleDbType.Double);
        param2.Direction = ParameterDirection.Input;
        param2.Value = product.Price;

        OleDbParameter param3;
        param3 = objCmd.Parameters.Add("@Color", OleDbType.BSTR);
        param3.Direction = ParameterDirection.Input;
        param3.Value = product.Color;


        OleDbParameter param4;
        param4 = objCmd.Parameters.Add("@CountryID", OleDbType.Integer);
        param4.Direction = ParameterDirection.Input;
        param4.Value = product.CountryID;

        OleDbParameter param5;
        param5 = objCmd.Parameters.Add("@Picture", OleDbType.BSTR);
        param5.Direction = ParameterDirection.Input;
        param5.Value = product.Picture;

        OleDbParameter param7;
        param7 = objCmd.Parameters.Add("@LeftInStore", OleDbType.Integer);
        param7.Direction = ParameterDirection.Input;
        param7.Value = product.LeftInStore;

        OleDbParameter param8;
        param8 = objCmd.Parameters.Add("@SupplierID", OleDbType.Integer);
        param8.Direction = ParameterDirection.Input;
        param8.Value = product.SupplierID;


        try
        {
            this.objConn.Open();
            objCmd.Transaction = this.objTrans;
            objCmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            this.objConn.Close();
        }
    }
    public DataSet GetProductsByCategoryName(string CategoryName)
    {
        objCmd = new OleDbCommand("ShowProductsByCategory", objConn);
        objCmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        try
        {
            this.objConn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(objCmd);
            da.Fill(ds);
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            objCmd.Connection.Close();
        }
        return ds;
    }

    public DataSet GetProductsByCategory(int categoryiD)
    {
        objCmd = new OleDbCommand("GetProductsByCategory", objConn);
        objCmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();

        OleDbParameter param7;
        param7 = objCmd.Parameters.Add("@CategoryID", OleDbType.Integer);
        param7.Direction = ParameterDirection.Input;
        param7.Value = categoryiD;
        try
        {
            this.objConn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(objCmd);
            da.Fill(ds);
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            objCmd.Connection.Close();
        }
        return ds;
    }
}


