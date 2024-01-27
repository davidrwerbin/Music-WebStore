﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BowedStringsPage.aspx.cs" Inherits="BowedStringsPage" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="StyleSheet.css">

<html xmlns="http://www.w3.org/1999/xhtml" style =" background-image: url(Images/home.jpg); background-repeat:no-repeat; background-size:cover" >
<head runat="server">
    <title></title>
   
</head>
<body>
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
         <div>
           <section  class="auto-style;" height: "50 px" style="font-size:70px; text-align: center; vertical-align:middle; padding: 70px; color: white; background-image: url(Images/nav.jpg)"> BowedStrings Section <section/>
       </div>
   
           <br /><br />        <br /><br />
         
        <p style="font-size: 20px; font-weight:100; text-align:justify; margin-left: 300px; color: blue; margin-right: 300px; background-color: lightgray">
          <i>Welcome to the Bowed String Section of our online music instrument shop! Here, you'll find a wide range of bowed string instruments to cater to your musical interests and aspirations. Whether you're a beginner, an advancing student, or a professional musician, we offer exceptional instruments crafted with precision and attention to detail. Explore our collection of violins, violas, cellos, and accessories to embark on a captivating musical journey.

</i>
        </p>

        <br /><br />  
    <div style="text-align:center; flex-align: center; margin-left: 700px">
    <form id="form1" runat="server">
    <div>
    
       <asp:DataList ID="DataListBowedStrings" runat="server" CellPadding="4" ForeColor="Black" Height="425px"  Width="500px" OnItemCommand="DataListBowedStrings_ItemCommand" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" GridLines="Both" >
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="White" />
            <ItemTemplate>
                <asp:Label ID="ProductName" runat="server" Text='<%# Bind("ProductName") %>'></asp:Label>
                <asp:Label ID="ProductID" runat="server" Text='<%# Bind("ProductID") %>'></asp:Label>
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("Picture") %>' Height="391px"  Width="470px" />
                <asp:Label ID="Color" runat="server" Text='<%# Bind("Color") %>'></asp:Label>
                <asp:Label ID="Price" runat="server" Text='<%# Bind("Price") %>'></asp:Label>
                <asp:Label ID="Supplier" runat="server" Text='<%# Bind("SupplierName") %>'></asp:Label>
                <asp:Button ID="ButtonBuy" runat="server" CommandName="AddToCart" Text="Add to Cart" Width="100px" />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        </asp:DataList>
    
        <asp:Label ID="Label1" runat="server" Text="The order has been sucsessfully added" Visible="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>
