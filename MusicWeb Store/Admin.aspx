<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="StyleSheet.css">
<html xmlns="http://www.w3.org/1999/xhtml" style =" background-image: url(Images/home.jpg); background-repeat:no-repeat; background-size:cover" >
<head runat="server">
    <title></title>
</head>
     <header>

          <nav class="hola">
    <ul>
      <li><a href="NewHomePage.aspx">Home</a></li>
      <li><a href="LogIn.aspx">Log in</a></li>
      <li><a href="SignUp.aspx">Sign Up</a></li>
       <li><a href="#"><i>About Us</i></a></li>
      <li><a href="#"><i>Contact</i></a></li>
        
    </ul>
  </nav>
    </header>
<body>
      <div>
           <section  class="auto-style;" height: "50 px" style="font-size:70px; text-align: center; vertical-align:middle; padding: 70px; color: white; background-image: url(Images/nav.jpg)">Admin Page<section/>
       </div>
   
           <br /><br />        <br /><br />
         
        <p style="font-size: 20px; font-weight:100; text-align:center; margin-left: 300px; color: blue; margin-right: 300px; background-color: lightgray">
          <i> Here you can control and see the information of every single user registered as a new musc family

</i>
        </p>

        <br /><br />  

    <div style="text-align:center; flex-align: center; margin-left: 700px">
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridViewEditUsers" style="text-align:center; margin-left:50px" runat="server" GridLines="Horizontal" CssClass="table table-hover col-lg-12  col-lg-offset-0"  AutoGenerateColumns="False" HorizontalAlign="Center" OnRowCancelingEdit="GridViewEditUsers_RowCancelingEdit" OnRowDeleting="GridViewEditUsers_RowDeleting" OnRowEditing="GridViewEditUsers_RowEditing" OnRowUpdating="GridViewEditUsers_RowUpdating" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4">
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="User ID" ReadOnly="true"/>
            <asp:BoundField DataField="UserName" HeaderText="UserName" />
            <asp:BoundField DataField="UserLastName" HeaderText="Last Name" />
            <asp:BoundField DataField="Password1" HeaderText="Password" />
            <asp:BoundField DataField="Phone" HeaderText="Phone" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
         
            <asp:CommandField ShowEditButton="True" ButtonType="Button">
            <ControlStyle CssClass="btn btn-md" />
            </asp:CommandField>
            <asp:CommandField ShowDeleteButton="True" ButtonType="Button">
            <ControlStyle CssClass="btn btn-md" />
            </asp:CommandField>
        </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
         </asp:GridView>


    </div>
    </form>
</body>
</html>
