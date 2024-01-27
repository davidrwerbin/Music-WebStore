using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUpPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //protected void ButtonLogIn_Click(object sender, EventArgs e)
    //{
    //    UserService us = new UserService();


    //    if (us.LoginFunction(TextBoxUserID.Text, TextBoxPassword.Text)
    //            == -1)
    //    {
    //        LabelFinish.Text = "שם המשתמש או הסיסמה אינם נכונים";

    //    }
    //    else
    //    {

    //        Session["UserID"] = TextBoxUserID.Text;
    //        us.GetUsersByID(TextBoxUserID.Text);
    //        UserDetails ud = new UserDetails();
    //        ud = us.GetUserDetailsByPhoneNumber(TextBoxPhoneNumber.Text);
    //        Session["UserFirstName"] = ud.UserFirstName;
    //        Session["UserLastName"] = ud.UserLastName;
    //        Session["UserPassword"] = ud.UserPassword;
    //        Session["UserEmail"] = ud.UserEmail;
    //        Session["UserType"] = us.GetUserType(TextBoxPhoneNumber.Text);
    //        Session["UserID"] = ud.UserID;
    //        LabelUserID.Text = Session["UserID"].ToString();
    //        if (Session["UserType"].ToString() == "משתמש")
    //        {

    //            LabelFinish.Text = "ההתחברות הושלמה בהצלחה! ברוך הבא " + Session["UserFirstName"].ToString();

    //        }

    //        if (Session["UserType"].ToString() == "מנהל")
    //        {
    //            es.GetEmployeeDetails(Session["UserID"].ToString());
    //            Session["EmployeeJob"] = ed.EmployeeJob;
    //            Session["EmployeeID"] = ed.EmployeeID;
    //            LabelFinish.Text = "התחברות מנהל הושלמה בהצלחה! ברוך הבא " + Session["UserFirstName"].ToString();

    //        }
    //        ButtonHome.Visible = true;

    //        LabelFinish.Visible = true;
    //    }
    //}


        protected void ButtonLogIn_Click(object sender, EventArgs e)
        {
            UserService us = new UserService();


            if (us.LoginFunction(TextBoxUserID.Text, TextBoxPassword.Text)
                    == -1)
            {
                LabelFinish.Text = "your password or your ID are not matching";

            }
            else
            {

                Session["UserID"] = TextBoxUserID.Text;

                UserDetails ud = new UserDetails();
                ud = us.GetUserByID(TextBoxUserID.Text);
                Session["UserName"] = ud.UserName;
                Session["UserLastName"] = ud.UserLastName;
                //Session["Password"] = ud.Password;
                Session["Email"] = ud.Email;
                //Session["Phone"] = us.GetUserType(TextBoxPhone.Text);
                Session["UserID"] = ud.UserID;
                Session["IsAdmin"] = ud.IsAdmin;

                //   LabelUserID.Text = Session["UserID"].ToString();
                if ((bool)Session["IsAdmin"] == false)
                {
                    //ingles
                    LabelFinish.Text = "The LogIn was succesful, Welcome! " ;

                }
          //  Session["UserFirstName"].ToString()

                if ((bool)Session["IsAdmin"] == true)
                {


                    LabelFinish.Text = "The Admin conection was succesful, Welcome! " + Session["UserName"].ToString();

                }
                ButtonHome.Visible = true;

                LabelFinish.Visible = true;
            }
        }



        protected void ButtonHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewHomePage.aspx");
        }

     
        protected void ButtonSignUp_Click1(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
}


