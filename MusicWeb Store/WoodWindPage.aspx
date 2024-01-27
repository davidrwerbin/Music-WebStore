<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WoodWindPage.aspx.cs" Inherits="WoodWindPage" %>

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
           <section  class="auto-style;" height: "50 px" style="font-size:70px; text-align: center; vertical-align:middle; padding: 70px; color: white; background-image: url(Images/nav.jpg)"> WoodWind Section <section/>
       </div>
   
           <br /><br />        <br /><br />
         
        <p style="font-size: 20px; font-weight:100; text-align:justify; margin-left: 300px; color: blue; margin-right: 300px; background-color: lightgray">
          <i>Welcome to the Woodwind Section of our online music instrument shop! Here, you'll find a diverse range of woodwind instruments that will allow you to explore different musical expressions and genres. From traditional orchestral instruments to contemporary options, our collection offers instruments suitable for beginners, students, and professional musicians alike. Browse through our selection and find the perfect woodwind instrument to unlock your musical potential.

</i>
        </p>

        <br /><br />  
    <form id="form1" runat="server">
    <div style="text-align:center; flex-align: center; margin-left: 700px">
    
        <asp:DataList ID="DataListWoodWind" runat="server" CellPadding="4" ForeColor="#333333" Height="425px"  Width="500px" OnItemCommand="DataListWoodWind_ItemCommand">
            <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <ItemTemplate>
                <asp:Label ID="ProductName" runat="server" Text='<%# Bind("ProductName") %>'></asp:Label>
                <asp:Label ID="ProductID" runat="server" Text='<%# Bind("ProductID") %>'></asp:Label>
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("Picture") %>' Height="346px"  Width="382px" />
                <asp:Label ID="Color" runat="server" Text='<%# Bind("Color") %>'></asp:Label>
                <asp:Label ID="Price" runat="server" Text='<%# Bind("Price") %>'></asp:Label>
                <asp:Label ID="Supplier" runat="server" Text='<%# Bind("SupplierName") %>'></asp:Label>
                <asp:Button ID="ButtonBuy" runat="server" CommandName="AddToCart" Text="Add to Cart" Width="100px" />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
    
        <asp:Label ID="Label1" runat="server" Text="The order has been sucsessfully added" Visible="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>
