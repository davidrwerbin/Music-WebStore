using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;    
    
/// <summary>
/// Summary description for UserService
/// </summary>
public class UserService
{
    private OleDbConnection objConn;
    private OleDbCommand objCmd;
    private OleDbTransaction objTrans;
    private string connectionString;

	public UserService()
	{
        this.connectionString = Connect.GetConnectionString();
        objConn = new OleDbConnection(this.connectionString);
	}
    public DataSet GetUsers()
    {
        OleDbCommand objCmd = new OleDbCommand("GetUsers", objConn);
        objCmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        try
        {
            this.objConn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(objCmd);
            da.Fill(ds);
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            this.objConn.Close();
        }
        return ds;
    }


    //INSERT INTO Users ( UserID, UserName, UserLastName, Password1, Phone, Email )
//VALUES ([@UserID ], [@UserName], [@UserLastName ], [@Password], [@Phone ], [@Email ]);


    public void AddUser(UserDetails user)
    {
        OleDbCommand objCmd = new OleDbCommand("AddUser", objConn);
        objCmd.CommandType = CommandType.StoredProcedure;

        OleDbParameter param6;
        param6 = objCmd.Parameters.Add("@UserID", OleDbType.Integer);
        param6.Direction = ParameterDirection.Input;
        param6.Value = user.UserID;

        OleDbParameter param1;
        param1 = objCmd.Parameters.Add("@UserName", OleDbType.BSTR);
        param1.Direction = ParameterDirection.Input;
        param1.Value = user.UserName;

        OleDbParameter param2;
        param2 = objCmd.Parameters.Add("@UserLastName", OleDbType.BSTR);
        param2.Direction = ParameterDirection.Input;
        param2.Value = user.UserLastName;

        OleDbParameter param3;
        param3 = objCmd.Parameters.Add("@Password1", OleDbType.BSTR);
        param3.Direction = ParameterDirection.Input;
        param3.Value = user.Password1;

        OleDbParameter param4;
        param4 = objCmd.Parameters.Add("@Phone", OleDbType.BSTR);
        param4.Direction = ParameterDirection.Input;
        param4.Value = user.Phone;

        OleDbParameter param5;
        param5 = objCmd.Parameters.Add("@Email", OleDbType.BSTR);
        param5.Direction = ParameterDirection.Input;
        param5.Value = user.Email;

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

    public int LoginFunction(string userID, string password)
    {
        objCmd = new OleDbCommand("Login", this.objConn);
        objCmd.CommandType = System.Data.CommandType.StoredProcedure;
        OleDbParameter objParam;

        objParam = objCmd.Parameters.Add("@UserID", OleDbType.BSTR);
        objParam.Direction = System.Data.ParameterDirection.Input;
        objParam.Value = userID;

        OleDbParameter objParam2;
        objParam2 = objCmd.Parameters.Add("@password1", OleDbType.BSTR);
        objParam2.Direction = System.Data.ParameterDirection.Input;
        objParam2.Value = password;



        int found = -1;
        try
        {
            this.objConn.Open();
            found = int.Parse(objCmd.ExecuteScalar().ToString());
        }
        catch (Exception)
        {

            return -1;
        }
        finally
        {
            this.objConn.Close();
        }
        return found;
    }

    public UserDetails GetUserByID(string userID)
    {
        UserDetails ud = new UserDetails();
        objCmd = new OleDbCommand("GetUserDetails", this.objConn);
        objCmd.CommandType = System.Data.CommandType.StoredProcedure;

        OleDbParameter objParam;
        objParam = objCmd.Parameters.Add("@UserID", OleDbType.BSTR);
        objParam.Direction = System.Data.ParameterDirection.Input;
        objParam.Value = userID;

        DataSet ds = new DataSet();
        try
        {
            this.objConn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(objCmd);
            da.Fill(ds, "UserDetails");
            ud.UserID = ds.Tables["UserDetails"].Rows[0]["UserID"].ToString();
            ud.UserName = ds.Tables["UserDetails"].Rows[0]["UserName"].ToString();
            ud.UserLastName = ds.Tables["UserDetails"].Rows[0]["UserLastName"].ToString();
            ud.Phone = ds.Tables["UserDetails"].Rows[0]["Phone"].ToString();
            ud.Email = ds.Tables["UserDetails"].Rows[0]["Email"].ToString();
            ud.IsAdmin = bool.Parse(ds.Tables["UserDetails"].Rows[0]["IsAdmin"].ToString());


        }
        catch (Exception ex) { throw ex; }
        finally
        {
            objCmd.Connection.Close();
        }
        return ud;
    }
}

