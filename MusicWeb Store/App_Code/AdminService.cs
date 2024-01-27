using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for UserAndAdminsService
/// </summary>
public class AdminService
{

    OleDbConnection MyConn;
    string connstr;
    public AdminService()
    {
        this.connstr = Connect.GetConnectionString();
        MyConn = new OleDbConnection(this.connstr);
    }

    public DataSet SelectAllUsers()
    {
        OleDbCommand cmd = new OleDbCommand("SelectAllUsers", MyConn);
        cmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        try
        {
            MyConn.Open();
            da.Fill(ds, "Users");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            MyConn.Close();
        }
        return ds;
    }

    public DataSet SelectUserByID(int UserID)
    {
        OleDbCommand cmd = new OleDbCommand("SelectUserByID", MyConn);
        cmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);

        OleDbParameter param = cmd.CreateParameter();
        param.Direction = ParameterDirection.Input;
        param.OleDbType = OleDbType.Integer;
        param.ParameterName = "@ID";
        param.Value = UserID;
        cmd.Parameters.Add(param);
        try
        {
            MyConn.Open();
            da.Fill(ds, "Users");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            MyConn.Close();
        }
        return ds;
    }

    public void DeleteUserByID(string UserID)
    {
        OleDbCommand cmd = new OleDbCommand("DeleteUserByID", MyConn);
        cmd.CommandType = CommandType.StoredProcedure;


        OleDbParameter param = cmd.CreateParameter();
        param.Direction = ParameterDirection.Input;
        param.OleDbType = OleDbType.BSTR;
        param.ParameterName = "@UserID";
        param.Value = UserID;
        cmd.Parameters.Add(param);

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

    public DataSet SelectUserByIDAndPassword(int UserID, string Password)
    {
        OleDbCommand cmd = new OleDbCommand("SelectUserByIDAndPassword", MyConn);
        cmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);

        OleDbParameter param = cmd.CreateParameter();
        param.Direction = ParameterDirection.Input;
        param.OleDbType = OleDbType.Integer;
        param.ParameterName = "@ID";
        param.Value = UserID;
        cmd.Parameters.Add(param);
        param = null;

        param = cmd.CreateParameter();
        param.Direction = ParameterDirection.Input;
        param.OleDbType = OleDbType.BSTR;
        param.ParameterName = "@Password";
        param.Value = Password;
        cmd.Parameters.Add(param);

        try
        {
            MyConn.Open();
            da.Fill(ds, "Users");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            MyConn.Close();
        }
        return ds;
    }

    public void CreateNewUser(int UserID, String FirstName, string LastName, string Password, string Phone, string Email, string Address)
    {
        OleDbCommand cmd = new OleDbCommand("CreateUser", MyConn);
        cmd.CommandType = CommandType.StoredProcedure;

        OleDbParameter param = cmd.CreateParameter();
        param.Direction = ParameterDirection.Input;
        param.OleDbType = OleDbType.Integer;
        param.ParameterName = "@ID";
        param.Value = UserID;
        cmd.Parameters.Add(param);

  


        param = cmd.CreateParameter();
        param.OleDbType = OleDbType.BSTR;
        param.ParameterName = "@FirstName";
        param.Value = FirstName;
        cmd.Parameters.Add(param);
        param = null;

        param = cmd.CreateParameter();
        param.OleDbType = OleDbType.BSTR;
        param.ParameterName = "@LastName";
        param.Value = LastName;
        cmd.Parameters.Add(param);
        param = null;

        param = cmd.CreateParameter();
        param.OleDbType = OleDbType.BSTR;
        param.ParameterName = "@Password";
        param.Value = Password;
        cmd.Parameters.Add(param);
        param = null;

        param = cmd.CreateParameter();
        param.OleDbType = OleDbType.BSTR;
        param.ParameterName = "@Phone";
        param.Value = Phone;
        cmd.Parameters.Add(param);
        param = null;

        param = cmd.CreateParameter();
        param.OleDbType = OleDbType.BSTR;
        param.ParameterName = "@Email";
        param.Value = Email;
        cmd.Parameters.Add(param);
        param = null;

        param = cmd.CreateParameter();
        param.OleDbType = OleDbType.BSTR;
        param.ParameterName = "@Address";
        param.Value = Address;
        cmd.Parameters.Add(param);
        param = null;

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

    public void UpdateUserByID(string UserID, string FirstName, string LastName, string Password, string Phone, string Email)
    {
        OleDbCommand cmd = new OleDbCommand("UpdateUserByID", MyConn);
        cmd.CommandType = CommandType.StoredProcedure;

        OleDbParameter param = cmd.CreateParameter();
        param = cmd.CreateParameter();
        param.OleDbType = OleDbType.BSTR;
        param.ParameterName = "@UserName";
        param.Value = FirstName;
        cmd.Parameters.Add(param);
        param = null;

        param = cmd.CreateParameter();
        param.OleDbType = OleDbType.BSTR;
        param.ParameterName = "@UserLastName";
        param.Value = LastName;
        cmd.Parameters.Add(param);
        param = null;

        param = cmd.CreateParameter();
        param.OleDbType = OleDbType.BSTR;
        param.ParameterName = "@Password1";
        param.Value = Password;
        cmd.Parameters.Add(param);
        param = null;

        param = cmd.CreateParameter();
        param.OleDbType = OleDbType.BSTR;
        param.ParameterName = "@Phone";
        param.Value = Phone;
        cmd.Parameters.Add(param);
        param = null;

        param = cmd.CreateParameter();
        param.OleDbType = OleDbType.BSTR;
        param.ParameterName = "@Email";
        param.Value = Email;
        cmd.Parameters.Add(param);
        param = null;

  
        param = cmd.CreateParameter();
        param.Direction = ParameterDirection.Input;
        param.OleDbType = OleDbType.BSTR;
        param.ParameterName = "@UserID";
        param.Value = UserID;
        cmd.Parameters.Add(param);

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
}