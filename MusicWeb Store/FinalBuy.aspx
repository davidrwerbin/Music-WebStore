<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FinalBuy.aspx.cs" Inherits="FinalBuy" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="StyleSheet.css">
<html xmlns="http://www.w3.org/1999/xhtml" style =" background-image: url(Images/home.jpg); background-repeat:no-repeat; background-size:cover" >
<head runat="server">
    <title></title>
</head>

     <header class="hola">
  
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
    <form id="form1" runat="server">
    <div>


        <section class="vh-100 gradient-custom" >
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-12 col-md-8 col-lg-6 col-xl-5">
        <div class="card bg-dark text-white" style="border-radius: 1rem;">
          <div class="card-body p-5 text-center">

            <div class="mb-md-5 mt-md-4 pb-5">
                  <div>
           <section  class="auto-style;" height: "50 px" style="font-size:70px; text-align: center; vertical-align:middle; padding: 40px; color: white; background-image: url(Images/nav.jpg)"> Your order  <section/>
       </div>
                <h2 style="color:white; text-align:center" >Welcome to your shopping cart, please dont fotget to check your order. You can confirm and proceed to the payment</h2>

    </a>
    </div>
            <asp:GridView ID="GridViewCart" runat="server" AutoGenerateColumns="False" AllowSorting="True" DataKeyNames="ProductID" CellPadding="4" ForeColor="#333333" GridLines="None" Height="156px" Width="524px" >
                <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" SortExpression="ProductID" ReadOnly="True" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" ReadOnly="True" />
                <asp:BoundField DataField="mquantity" HeaderText="Quantity" SortExpression="mquantity" />
                <asp:BoundField DataField="mPrice" HeaderText="UnitPrice" SortExpression="mPrice" ReadOnly="True" />
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
            </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:Button ID="ConfirmOrder" runat="server" OnClick="Button1_Click1" Text="Confirm Order" Height="43px" Width="157px" />
    </form>
</body>
</html>
