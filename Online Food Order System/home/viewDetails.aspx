<%@ Page Title="" Language="C#" MasterPageFile="~/home/Index.Master" AutoEventWireup="true" CodeFile="viewDetails.aspx.cs" Inherits="Online_Food_Order_System.home.viewDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/viewDetails.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
<section id="viewFood" style="width:80vw; height:100vh;">
      
      <div class="image" style=" margin-left: 5%;">
        &nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:foodOrderDBConnectionString %>" SelectCommand="SELECT [image] FROM [Food] WHERE ([f_id] = @f_id)">
              <SelectParameters>
                  <asp:QueryStringParameter Name="f_id" QueryStringField="f_id" Type="Int32" />
              </SelectParameters>
          </asp:SqlDataSource>
            <asp:FormView ID="FormView1" runat="server" DataSourceID="SqlDataSource1">
                <EditItemTemplate>
                    image:
                    <asp:TextBox ID="imageTextBox" runat="server" Text='<%# Bind("image") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    image:
                    <asp:TextBox ID="imageTextBox" runat="server" Text='<%# Bind("image") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    <br />

                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("image") %>' />
                </ItemTemplate>
          </asp:FormView>
            
            <br />

        </div>
        <div class="foodInfo">
            <div class="desc" style="margin-top:8%">
                <span><asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </span>
                <p>
                    <asp:Label ID="Label2" runat="server" CssClass="desc" Font-Size="20px" ForeColor="Black"></asp:Label>
                </p>
                <h5>
                    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                    
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                
                </h5>
                <h5>
                    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                </h5>
                <center>
                    
                    <h6><a href="AddToCart.aspx?f_id=<%# Eval("f_id") %>"><lable style="font-size:30px">ADD CART</lable></a></h6>
                   <!--<h6> <asp:Button ID="Button1" runat="server" Text="ADD CART" BorderStyle="None" style="font-size:30px; background:#ba99ac"  /></h6>
                    -->
                    </center>
                
            </div>
        </div>
    </section>
</center>
        
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
