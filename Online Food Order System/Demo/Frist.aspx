<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frist.aspx.cs" Inherits="Online_Food_Order_System.Demo.Frist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link href="//cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 216px;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">View</asp:LinkButton>
        <br />
        <br />
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">id</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">name</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="find" />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="update" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">decs</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">price</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">image</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
        </table>
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="decs" HeaderText="decs" SortExpression="decs" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                <asp:ImageField DataImageUrlField="image" HeaderText="pic">
                </asp:ImageField>
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
        <br />
        <asp:FormView ID="FormView1" runat="server" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" ForeColor="#333333">
            <EditItemTemplate>
                id:
                <asp:Label ID="idLabel1" runat="server" Text='<%# Eval("id") %>' />
                <br />
                name:
                <asp:TextBox ID="nameTextBox" runat="server" Text='<%# Bind("name") %>' />
                <br />
                decs:
                <asp:TextBox ID="decsTextBox" runat="server" Text='<%# Bind("decs") %>' />
                <br />
                price:
                <asp:TextBox ID="priceTextBox" runat="server" Text='<%# Bind("price") %>' />
                <br />
                image:
                <asp:TextBox ID="imageTextBox" runat="server" Text='<%# Bind("image") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <InsertItemTemplate>
                id:
                <asp:TextBox ID="idTextBox" runat="server" Text='<%# Bind("id") %>' />
                <br />
                name:
                <asp:TextBox ID="nameTextBox" runat="server" Text='<%# Bind("name") %>' />
                <br />
                decs:
                <asp:TextBox ID="decsTextBox" runat="server" Text='<%# Bind("decs") %>' />
                <br />
                price:
                <asp:TextBox ID="priceTextBox" runat="server" Text='<%# Bind("price") %>' />
                <br />
                image:
                <asp:TextBox ID="imageTextBox" runat="server" Text='<%# Bind("image") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                id:
                <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                <br />
                name:
                <asp:Label ID="nameLabel" runat="server" Text='<%# Bind("name") %>' />
                <br />
                decs:
                <asp:Label ID="decsLabel" runat="server" Text='<%# Bind("decs") %>' />
                <br />
                price:
                <asp:Label ID="priceLabel" runat="server" Text='<%# Bind("price") %>' />
                <br />
                image:
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("image") %>' />
                <br />


            </ItemTemplate>
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        </asp:FormView>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:foodOrderDBConnectionString %>" SelectCommand="SELECT * FROM [demo]"></asp:SqlDataSource>
        
    </form>
</body>
   
    <script src="//cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js"></script>
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js">     </script>
    
    <script type="text/javascript">

        $(document).ready(function () {
            $("#<%=GridView1.ClientID%>").prepend($("<thead></thead>").append//..($(this).find("tr:first"))).dataTable();
           // $('#<%=GridView1.ClientID%>').DataTable();
       });

    </script>
</html>
