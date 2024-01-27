<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FinishOrder.aspx.cs" Inherits="FinishOrder" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="StyleSheet.css">
<html xmlns="http://www.w3.org/1999/xhtml"  style =" background-image: url(Images/home.jpg); background-repeat:no-repeat; background-size:cover" >
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

      <section class="vh-100 gradient-custom">
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-12 col-md-8 col-lg-6 col-xl-5">
        <div class="card bg-dark text-white" style="border-radius: 1rem;">
          <div class="card-body p-5 text-center">

            <div class="mb-md-5 mt-md-4 pb-5">
                  <div>
           <section  class="auto-style;" height: "50 px" style="font-size:70px; text-align: center; vertical-align:middle; padding: 40px; color: white; background-image: url(Images/nav.jpg)"> THE PAYMENT GOT ACCEPTED SUCCESFULLY !  <section/>
       </div>
                <h2 style="color:orange; text-align: center" ><i>Thanks for trusting in us. You are free to keep searching more </i></h2>
   
        <div>
        </div>
   
    <p>
        &nbsp;</p>
    
   
      </section>
     <form id="form1" runat="server">
      <p>
          <asp:Button ID="Button1" runat="server" Style="margin-left:850px" Height="33px" OnClick="Button1_Click" Text="To return Home" Width="242px" />
      </p>
         </form>
</body>
</html>
