using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for BankService
/// </summary>
public class BankService
{
    OleDbConnection MyConn;
    string connstr;
    public BankService()
    {
        this.connstr = Connect.GetConnectionString();
        MyConn = new OleDbConnection(this.connstr);
    }

    public string CheckCreditCard(string CreditNumber, string UserName, string UserID, int CSC)
    {
        OleDbCommand cmd = new OleDbCommand("CheckCreditCard", MyConn);
        cmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        OleDbParameter objParam = new OleDbParameter();


        objParam = cmd.Parameters.Add("@CreditNumber", OleDbType.BSTR);
        objParam.Direction = System.Data.ParameterDirection.Input;
        objParam.Value = CreditNumber;

        objParam = cmd.Parameters.Add("@UserName", OleDbType.BSTR);
        objParam.Direction = System.Data.ParameterDirection.Input;
        objParam.Value = UserName;

        objParam = cmd.Parameters.Add("@UserID", OleDbType.BSTR);
        objParam.Direction = System.Data.ParameterDirection.Input;
        objParam.Value = UserID;

        objParam = cmd.Parameters.Add("@CSC", OleDbType.BSTR);
        objParam.Direction = System.Data.ParameterDirection.Input;
        objParam.Value = CSC;

        //objParam = cmd.Parameters.Add("@ExpiryDate", OleDbType.);
        //objParam.Direction = System.Data.ParameterDirection.Input;
        //objParam.Value = CSC;

        string good = "wrong";
        try
        {
            MyConn.Open();
           good = cmd.ExecuteScalar().ToString();
        }
        catch (Exception ex)
        {
            return "wrong";
        }
        finally
        {
            MyConn.Close();
        }
        return good;
    }

    public void UpdateCreditCardBalance(double NewBalnce, String CreditNumber)
    {
        OleDbCommand cmd = new OleDbCommand("UpdateCreditCardBalance", MyConn);
        cmd.CommandType = CommandType.StoredProcedure;
        OleDbParameter objParam = new OleDbParameter();
         
        objParam = cmd.Parameters.Add("@NewBalance", OleDbType.Double);
        objParam.Direction = System.Data.ParameterDirection.Input;
        objParam.Value = NewBalnce;


        objParam = cmd.Parameters.Add("@CreditNumber", OleDbType.BSTR);
        objParam.Direction = System.Data.ParameterDirection.Input;
        objParam.Value = CreditNumber;
        try
        {
            MyConn.Open();
            cmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            MyConn.Close();
        }
    }

    public double GetCustomerBalnce(string CreditNumber)
    {
        OleDbCommand cmd = new OleDbCommand("GetCustomerBalnce", MyConn);
        cmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        OleDbParameter objParam = new OleDbParameter();

        objParam = cmd.Parameters.Add("@CreditNumber", OleDbType.BSTR);
        objParam.Direction = System.Data.ParameterDirection.Input;
        objParam.Value = CreditNumber;

        double balance = 0;

        try
        {
            MyConn.Open();
            balance = double.Parse(cmd.ExecuteScalar().ToString());
            
        }
        catch (Exception ex)
        {
            return -1;
        }
        finally
        {
            MyConn.Close();
        }
        return balance;
    }

}