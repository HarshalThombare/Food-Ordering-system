
<%@ Page Title="" Language="C#" MasterPageFile="~/home/Index.Master" AutoEventWireup="true" CodeFile="FoodForm.aspx.cs" Inherits="Online_Food_Order_System.home.FoodForm" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        
        .pro-container {
        display: flex;
        /* justify-content: space-between; */
        padding-top: 20px;
        flex-wrap: wrap;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   <section id="allfood" class="section-p1">
  <div class="pro-container">
      
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource2" RepeatColumns="5" RepeatDirection="Horizontal" OnItemCommand="DataList1_ItemCommand" DataKeyField="f_id"  >
            <ItemTemplate>
               <div class="prod">
                <asp:Image ID="Image1" runat="server" Height="250px" ImageUrl='<%# Eval("image") %>' Width="100%" />
                
                <div class="desc">
                <h5><asp:Label ID="Label3" runat="server" Text='<%# Eval("food_name") %>' Font-Bold="True" Font-Size="20px" ForeColor="#CC0000"></asp:Label></h5>
                
                <asp:Label ID="Label4" runat="server" Text='<%# Eval("type") %>'></asp:Label>
               
                <asp:Label ID="Label5" runat="server" Text='<%# Eval("category") %>'></asp:Label>
               
               <h4><i class="fas fa-rupee-sign"><asp:Label ID="Label6" runat="server" Text='<%# Eval("price") %>' Font-Bold="True" Font-Size="18px" ForeColor="Black"></asp:Label></i></h4>
                
                 <div class="cart" style="display:flex; justify-content:space-between;">
                    <a href="viewDetails.aspx?f_id=<%# Eval("f_id") %>"><img  src="../images/info.jpeg" style="width:40px;height:40px"/></a>
       
                     <a href="AddToCart.aspx?f_id=<%# Eval("f_id") %>"><img  src="../images/addcart.jpeg" style="width:40px;height:40px"/></a>
       
                     

                     </div>
                    </div>

                </div>
             </ItemTemplate>
        </asp:DataList>
             
       </div>
        </section>
        
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:foodOrderDBConnectionString %>" SelectCommand="SELECT * FROM [Food]"></asp:SqlDataSource>
    </p>
    <p>
        </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:foodOrderDBConnectionString %>" SelectCommand="SELECT * FROM [Food] WHERE ([category] = @category)">
            <SelectParameters>
                <asp:QueryStringParameter Name="category" QueryStringField="cat" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
   


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
