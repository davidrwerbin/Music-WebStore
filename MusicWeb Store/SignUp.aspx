<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>



<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="StyleSheet.css">
<html xmlns="http://www.w3.org/1999/xhtml"  style =" background-image: url(Images/home.jpg); background-repeat:no-repeat; background-size:cover">
<head id="Head1" runat="server">
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

    <section class="vh-100 gradient-custom" >
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-12 col-md-8 col-lg-6 col-xl-5">
        <div class="card bg-dark text-white" style="border-radius: 1rem;">
          <div class="card-body p-5 text-center">

            <div class="mb-md-5 mt-md-4 pb-5">
                  <div>
           <section  class="auto-style;" height: "50 px" style="font-size:70px; text-align: center; vertical-align:middle; padding: 40px; color: white; background-image: url(Images/nav.jpg)"> Sign Up  <section/>
       </div>
                <h2 style="color:white; text-align:center" >Please enter all your information in order to join this amazing music community</h2>

	<form id="form1" runat="server">
    <h1 style="color:white" >Sign Up</h1>
        <p style="color:white" >User ID:<asp:TextBox ID="ID" runat="server" Height="24px" Width="267px"></asp:TextBox>
        </p>
      <label for="username" style="color:white" >Username:</label>
        <asp:TextBox ID="TextBoxUserName" runat="server" Height="21px" Width="188px"></asp:TextBox>
        <br>

      <label for="password" style="color:white" >Password:</label>
        <asp:TextBox ID="TextBoxPassword" runat="server" Height="24px" Width="209px"></asp:TextBox>
        <br>

      <label for="userLastName" style="color:white" >Last Name:</label>
        <asp:TextBox ID="TextBoxLastName" runat="server" Height="20px" Width="182px"></asp:TextBox>
        <br>

      <label for="phone" style="color:white" >Phone:</label>
        <asp:TextBox ID="TextBoxPhone" runat="server" Height="22px" Width="316px"></asp:TextBox>
        <br> 

      <label for="email" style="color:white" >Email: </label>
        <asp:TextBox ID="TextBoxEmail" runat="server" Height="17px" Width="317px"></asp:TextBox>
        <br>

      &nbsp;<asp:Button ID="ButtonSignUp" runat="server" OnClick="ButtonSignUp_Click" Text="Sign Up" Height="36px" Width="147px" />

    </form>
             

            </div>

           

          </div>
        </div>
