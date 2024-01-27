<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GuitarsPage.aspx.cs" Inherits="GuitarsPage" %>

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
           <section  class="auto-style;" height: "50 px" style="font-size:70px; text-align: center; vertical-align:middle; padding: 70px; color: white; background-image: url(Images/nav.jpg)"> Guitars Section <section/>
       </div>
   
           <br /><br />        <br /><br />
         
        <p style="font-size: 20px; font-weight:100; text-align:justify; margin-left: 300px; color: blue; margin-right: 300px; background-color: lightgray">
          <i>Welcome to the Guitar Section of our online music instrument shop! Here, you'll find a wide selection of guitars to inspire your musical journey. Whether you're a beginner, an intermediate player, or a seasoned professional, we have the perfect guitar for you. Explore our collection and discover the instrument that resonates with your style and musical aspirations.

</i>
        </p>

        <br /><br />  
    <form id="form1" runat="server">
    <div>
    
    </div >
          <asp:DataList ID="DataListGuitars" runat="server" CellPadding="4" ForeColor="#333333" Height="425px"  Width="500px" OnItemCommand="DataListGuitars_ItemCommand" style="text-align:center; flex-align: center; margin-left: 700px">
            <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <ItemTemplate>
                <asp:Label ID="ProductName" runat="server" Text='<%# Bind("ProductName") %>'></asp:Label>
                <asp:Label ID="ProductID" runat="server" Text='<%# Bind("ProductID") %>'></asp:Label>
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("Picture") %>' Height="339px"  Width="361px" />
                <asp:Label ID="Color" runat="server" Text='<%# Bind("Color") %>'></asp:Label>
                <asp:Label ID="Price" runat="server" Text='<%# Bind("Price") %>'></asp:Label>
                <asp:Label ID="Supplier" runat="server" Text='<%# Bind("SupplierName") %>'></asp:Label>
                <asp:Button ID="ButtonBuy" runat="server" CommandName="AddToCart" Text="Add to Cart" Width="100px" />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
    
        <asp:Label ID="Label1" runat="server" Text="The order has been sucsessfully added" Visible="False"></asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Button" />
        </p>
    </form>
</body>
</html>
