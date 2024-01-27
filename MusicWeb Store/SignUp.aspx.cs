using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonSignUp_Click(object sender, EventArgs e)
    {
        UserService us = new UserService();
        UserDetails ud = new UserDetails();
        ud.UserID = ID.Text;
        ud.Email = TextBoxEmail.Text;
        ud.UserName = TextBoxUserName.Text;
        ud.Password1 = TextBoxPassword.Text;
        ud.Phone = TextBoxPhone.Text;
        ud.UserLastName = TextBoxLastName.Text;

        us.AddUser(ud);
    }

}