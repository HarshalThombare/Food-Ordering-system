<%@ Page Title="" Language="C#" MasterPageFile="~/home/Index.Master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="Online_Food_Order_System.home.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="home">
       
        <h2>Order favourite food from restaurants near you.</h2>
        

        <div class="search-box">
            <input type="text" placeholder="Search for Dishes...">
            <button>Search</button>

        </div>
    </section>
        <h2 style="padding: 20px 0px 0px 80px; margin-bottom:-20px;">Select Your Favourite Food.</h2>
     <section id="food" class="section-p1">
        
        <div class="fo-box">
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">
            <img src="/img/home.jpeg" alt="">
            <h6>Home Style</h6>
            </asp:LinkButton>
        </div>

         
        <div class="fo-box">
            <img src="/img/sandwich.jpeg" alt="" style="width: 100%;">
           <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click"> <h6>Sandwich</h6>  </asp:LinkButton>
        </div>
      

        <div class="fo-box">
            <img src="/img/ice-cream.jpeg" />
            
            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click"><h6>Ice-Cream</h6></asp:LinkButton>
        </div>

        <div class="fo-box">
            <img src="/img/biryani.jpeg" alt="">
            <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click"><h6>Biryani</h6></asp:LinkButton> 
        </div>

        <div class="fo-box">
            <img src="/img/burger.jpeg" alt="">
            <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click"><h6>Burger</h6></asp:LinkButton>
        </div>

        <div class="fo-box">
            <img src="/img/pizza.jpeg" alt="">
            <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click"><h6>Pizza</h6></asp:LinkButton> 
        </div>

        <div class="fo-box">
            <img src="/img/momos.jpeg" alt="">
            <asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click"> <h6>Momos</h6></asp:LinkButton>
        </div>

        <div class="fo-box">
            <img src="/img/noodles.jpeg" alt="">
            <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click"><h6>Noodles</h6></asp:LinkButton>  
        </div>

        <div class="fo-box">
            <img src="/img/roll.jpeg" alt="">
            <asp:LinkButton ID="LinkButton8" runat="server" OnClick="LinkButton8_Click"><h6>Rolls</h6></asp:LinkButton>  
        </div>

        <div class="fo-box">
            <img src="/img/chaat.jpeg" alt="">
            <asp:LinkButton ID="LinkButton9" runat="server" OnClick="LinkButton9_Click"><h6>Chaat</h6></asp:LinkButton>
        </div>

    </section>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
