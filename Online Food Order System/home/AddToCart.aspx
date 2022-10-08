<%@ Page Title="" Language="C#" MasterPageFile="~/home/Index.Master" AutoEventWireup="true" CodeFile="AddToCart.aspx.cs" Inherits="Online_Food_Order_System.home.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/addcart.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <scetion id="addcart">
            <center>
                   <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" ShowFooter="True" Height="203px" Width="982px" style="margin: 10%;">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="sno" HeaderText="SR.No" />
                    <asp:BoundField DataField="f_id" HeaderText="Food ID" />
                    <asp:ImageField DataImageUrlField="image" HeaderText="Image">
                        <ControlStyle Height="100px" Width="100px" />
                    </asp:ImageField>
                    <asp:BoundField DataField="food_name" HeaderText="Food Name" />
                    <asp:BoundField DataField="price" HeaderText="Price" />
                    <asp:BoundField DataField="qty" HeaderText="Quantity" />
                    <asp:BoundField DataField="totalprice" HeaderText="Total Price" />
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
                </center>

        
    </scetion></center>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
