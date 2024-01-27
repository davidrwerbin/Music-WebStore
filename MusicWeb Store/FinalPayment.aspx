<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FinalPayment.aspx.cs" Inherits="FinalPayment" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="StyleSheet.css">
<html xmlns="http://www.w3.org/1999/xhtml" style =" background-image: url(Images/home.jpg); background-repeat:no-repeat; background-size:cover"  >
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 86px;
        }
    </style>
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

    
        <section class="vh-100 gradient-custom" >
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-12 col-md-8 col-lg-6 col-xl-5">
        <div class="card bg-dark text-white" style="border-radius: 1rem;">
          <div class="card-body p-5 text-center">

            <div class="mb-md-5 mt-md-4 pb-5">
                  <div>
           <section  class="auto-style;" height: "50 px" style="font-size:70px; text-align: center; vertical-align:middle; padding: 40px; color: white; background-image: url(Images/nav.jpg)">Online Payment <section/>
       </div>
                <h2 style="color:white; text-align:center" >Please introduce the following credit card requirements in order to purchase your desires</h2>

    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="CreditNumber" runat="server" PlaceHolder="credit card" Height="27px" Width="136px"></asp:TextBox>
        <asp:TextBox ID="UserName" runat="server" PlaceHolder="Full Name" Height="29px" Width="141px"></asp:TextBox>
        <asp:TextBox ID="UserID" runat="server" PlaceHolder="ID" Height="29px" Width="149px"></asp:TextBox>
        <asp:TextBox ID="CSC" runat="server" PlaceHolder="CSC" Height="28px" Width="147px"></asp:TextBox>
        <p>
            <asp:Button ID="BuyNow" runat="server" CssClass="auto-style1" OnClick="BuyNow_Click" Text="Confirm" Height="33px" Width="90px" />
        </p>
    </form>
</body>
</html>
