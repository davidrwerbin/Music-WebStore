using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserDetails
/// </summary>
public class UserDetails
{
	
    private string userID;
    private string userName;
    private string userLastName;
    private string password1;
    private string email;
    private string phone;
    private bool isAdmin;

	public UserDetails()
	{
		
	}

    public UserDetails(string userID, string userName)
    {
        this.userID = userID;
        this.userName = userName;
    }

    public UserDetails(string userID)
    {
        this.userID = userID;
    }

    public string UserID
    {
        get { return this.userID; }
        set { this.userID = value; }
    }

    public bool IsAdmin
    {
        get { return this.isAdmin; }
        set { this.isAdmin = value; }
    }

    public string UserName
    {
        get { return this.userName; }
        set { this.userName = value; }
    }

    public string UserLastName
    {
        get { return this.userLastName; }
        set { this.userLastName = value; }
    }

    public string Password1
    {
        get { return this.password1; }
        set { this.password1 = value; }
    }

    public string Email
    {
        get { return this.email; }
        set { this.email = value; }
    }

    public string Phone
    {
        get { return this.phone; }
        set { this.phone = value; }
    }
}