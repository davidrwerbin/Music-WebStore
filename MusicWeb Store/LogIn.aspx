<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="SignUpPage" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="StyleSheet.css">
<html xmlns="http://www.w3.org/1999/xhtml"  style =" background-image: url(Images/home.jpg); background-repeat:no-repeat; background-size:cover">
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
           <section  class="auto-style;" height: "50 px" style="font-size:70px; text-align: center; vertical-align:middle; padding: 40px; color: white; background-image: url(Images/nav.jpg)"> Log In  <section/>
       </div>
                <h2 style="color:white; text-align: center" >Please enter your ID and secret code</h2>
	<form id="form1" runat="server">
		<label for="userid "  style="color:white" >UserID:</label>
        <asp:TextBox ID="TextBoxUserID" runat="server" Height="31px" Width="213px"></asp:TextBox>
        <br><br/>
		<label for="password"  style="color:white">Password:</label>
        <asp:TextBox ID="TextBoxPassword" runat="server" Height="28px" Width="195px"></asp:TextBox>
        <br />
        <br />
        <asp:Label style="color:white" ID="LabelFinish" runat="server" Text="Label"></asp:Label>
        <br><br/>
		<asp:Button ID="ButtonLogIn" runat="server" OnClick="ButtonLogIn_Click" Text="Log In" Height="35px" Width="111px" />
&nbsp;<asp:Button ID="ButtonHome" runat="server" OnClick="ButtonHome_Click" Text="Return" Visible="False" Height="35px" Width="132px" />
        <p>
            &nbsp;</p>
         <div>
              <p class="mb-0"  style="color:white">Don't have an account?&nbsp; <asp:Button ID="ButtonSignUp" runat="server" Text="Sign Up" OnClick="ButtonSignUp_Click1" Height="30px" Width="115px" />
              </p>
            </div>
    </form>
             

            </div>

           

          </div>
        </div>
      </div>
    </div>
  </div>
</section>

	
</body>
</html>
