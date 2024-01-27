<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewHomePage.aspx.cs" Inherits="NewHomePage" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="StyleSheet.css">

<html xmlns="http://www.w3.org/1999/xhtml" style =" background-image: url(Images/home.jpg); background-repeat:no-repeat; background-size:cover" >

<head>

  <link rel="stylesheet" type="text/css" href="styles.css">
    <title> David Music Shop</title>

</head>

   <body>

        <header>
      <nav>
    <ul>
      <li><a href="NewHomePage.aspx">Home</a></li>
      <li><a href="LogIn.aspx">Log in</a></li>
      <li><a href="SignUp.aspx">Sign Up</a></li>
       <li><a href="#"><i>About Us</i></a></li>
      <li><a href="#"><i>Contact</i></a></li>
        <li><a href="FinalBuy.aspx"><asp:Label ID="ShoppingCart" runat="server" Text="My Cart"></asp:Label></a></li>
    </ul>
  </nav>
  </header>


   
        
  
       <div>
           <section  class="auto-style;" height: "50 px" style="font-size:70px; text-align: center; vertical-align:middle; padding: 70px; color: white; background-image: url(Images/nav.jpg)"> Werbin - Music Shop <section/>
       </div>
         

    </section>

        

    <section class="categories" style="margin-left:400px" >
      <form id="form1" runat="server">
          <div >
          

              <asp:ImageButton ID="ImageButtonKeyBoards" runat="server" Height="321px" ImageUrl="~/Images/Keyboards.jpg" OnClick="ImageButtonKeyBoards_Click" Width="447px" Style="margin-bottom: 0px; border-radius: 15px" />
              <asp:ImageButton ID="ImageButtonBowedStrings" runat="server" Height="319px" ImageUrl="~/Images/Bowedstrings.jpg" OnClick="ImageButtonBowedStrings_Click" Width="410px" Style="margin-right: 14px; border-radius: 15px" />
              <asp:ImageButton ID="ImageButtonBrass" runat="server" Height="321px" ImageUrl="~/Images/Brass.jpeg" OnClick="ImageButtonBrass_Click" Style="margin-right: 100px; border-radius: 15px" Width="361px" />
              <br />
              <asp:ImageButton ID="ImageButtonPercussions" runat="server" BorderWidth="0px" Height="345px" ImageUrl="~/Images/Percussions.jpg" OnClick="ImageButtonPercussions_Click" Style="margin-bottom: 0px; border-radius: 15px" Width="448px" />
              <asp:ImageButton ID="ImageButtonGuitars" runat="server" Height="336px" ImageUrl="~/Images/Guitars.jpeg" OnClick="ImageButtonGuitars_Click" Width="420px" Style="border-radius: 15px" />
              <asp:ImageButton ID="ImageButtonWoodWind" runat="server" Height="331px" ImageUrl="~/Images/WoodWinds.jpg" OnClick="ImageButtonWoodWind_Click" Width="363px" Style="border-radius: 15px" />
          </div>

           <asp:Button ID="ToAdminPage" runat="server" OnClick="ToAdminPage_Click" Text="Admin" Visible="False" Height="45px" Width="128px" />
    </form>
    </section>

    <section class="testimonials">
    </section>

  <footer margin-top="auto" aria-checked="false">
    <!-- Footer content -->
  </footer>
   

        
         
    </body>
</html>
