<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PercussionsPage.aspx.cs" Inherits="PercussionsPage" %>

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
      <li><a href="#">About Us</a></li>
      <li><a href="#"Contact</a></li>
        
    </ul>
  </nav>

    </header>
      <div>
           <section  class="auto-style;"  style="font-size:70px; text-align: center; vertical-align:middle; padding: 70px; color: white; background-image: url(Images/nav.jpg)"> Percussion Section <section/>
       </div>
   
           <br /><br />        <br /><br />
         
        <p style="font-size: 20px; font-weight:100; text-align:justify; margin-left: 300px; color: blue; margin-right: 300px; background-color: lightgray">
          <i>Welcome to the Percussion Section of our online music instrument shop! Here, you'll find a wide range of percussion instruments to add rhythm, groove, and excitement to your music. Whether you're a drummer, a percussionist, or a music enthusiast, we have an extensive collection of percussion instruments to suit all skill levels and musical styles. Explore our selection and find the perfect beat-making tools for your musical endeavors.

</i>
        </p>

        <br /><br />  
    <form id="form1" runat="server">
    <div style="text-align:center; flex-align: center; margin-left: 700px">
    
          <asp:DataList ID="DataListPercussions" runat="server" CellPadding="4" ForeColor="#333333"   Width="500px" OnItemCommand="DataListPercussions_ItemCommand" >
            <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <ItemTemplate>
                <asp:Label ID="ProductName" runat="server" Text='<%# Bind("ProductName") %>'></asp:Label>
                <asp:Label ID="ProductID" runat="server" Text='<%# Bind("ProductID") %>'></asp:Label>
                <a contact</a="" href="#">
                <asp:Image ID="Image1" runat="server" Height="369px" ImageUrl='<%# Bind("Picture") %>' Width="406px"    /> </a>
                <asp:Label ID="Color" runat="server" Text='<%# Bind("Color") %>'></asp:Label>
                <asp:Label ID="Price" runat="server" Text='<%# Bind("Price") %>'></asp:Label>
                <asp:Label ID="Supplier" runat="server" Text='<%# Bind("SupplierName") %>'></asp:Label>
                <a contact</a="" href="#">
                <asp:Button ID="ButtonBuy" runat="server" CommandName="AddToCart" Text="Add to Cart" Width="100px" />
                </a>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
    
        <asp:Label ID="Label1" runat="server" Text="The order has been sucsessfully added" Visible="False"></asp:Label>
    
    </div>
    </form>
    </body>
</html>
