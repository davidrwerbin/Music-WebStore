using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{

    AdminService UA = new AdminService();
    protected void Page_Load(object sender, EventArgs e)
    {
      
        if (!Page.IsPostBack)
        {
            GridViewEditUsers.DataSource = UA.SelectAllUsers();
            GridViewEditUsers.DataBind();
            if ( Session["UserID"] == null|| (bool)Session["IsAdmin"] == false )
            {
                Response.Redirect("NewHomePage.aspx");
            }
        }
    }

    protected void GridViewEditUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        UA.DeleteUserByID(GridViewEditUsers.Rows[e.RowIndex].Cells[0].Text);
        Response.Redirect(Request.RawUrl);
    }
    protected void GridViewEditUsers_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewEditUsers.EditIndex = e.NewEditIndex;
        GridViewEditUsers.DataSource = UA.SelectAllUsers();
        GridViewEditUsers.DataBind();
    }

    protected void GridViewEditUsers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        Response.Redirect(Request.RawUrl);
    }

    protected void GridViewEditUsers_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        GridViewRow row = (GridViewRow)GridViewEditUsers.Rows[e.RowIndex];
        string userid = row.Cells[0].Text;
        TextBox FirstName = (TextBox)row.Cells[1].Controls[0];
        TextBox LastName = (TextBox)row.Cells[2].Controls[0];
        TextBox Password = (TextBox)row.Cells[3].Controls[0];
        TextBox Phone = (TextBox)row.Cells[4].Controls[0];
        string Email = ((TextBox)(row.Cells[5].Controls[0])).Text;
       
        GridViewEditUsers.EditIndex = -1;
        UA.UpdateUserByID(userid, FirstName.Text, LastName.Text, Password.Text, Phone.Text, Email);
        GridViewEditUsers.DataSource = UA.SelectAllUsers();
        GridViewEditUsers.DataBind();
    }
}