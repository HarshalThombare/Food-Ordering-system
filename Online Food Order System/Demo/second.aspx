<%@ Page Language="C#" AutoEventWireup="true" CodeFile="second.aspx.cs" Inherits="Online_Food_Order_System.Demo.second" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 453px;
        }
        .auto-style3 {
            width: 287px;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="id"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br/>
       
         <asp:Label ID="Label3" runat="server" Text="name"></asp:Label>
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label><br/>
       
         <asp:Label ID="Label5" runat="server" Text="desc"></asp:Label>
        <asp:Label ID="Label6" runat="server" Text=""></asp:Label><br/>
       
         <asp:Label ID="Label7" runat="server" Text="price"></asp:Label>
        <asp:Label ID="Label8" runat="server" Text=""></asp:Label><br/>
       
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
                </td>
            </tr>
            <tr>
                <td class="auto-style2">image</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
        </table>
        
         <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
       
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:foodOrderDBConnectionString %>" SelectCommand="SELECT * FROM [demo]"></asp:SqlDataSource>
       
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">id</td>
                <td>
                    <asp:Label ID="Label12" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">name</td>
                <td>
                    <asp:Label ID="Label13" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">price</td>
                <td>
                    <asp:Label ID="Label14" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">decs</td>
                <td>
                    <asp:Label ID="Label15" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click1" Text="add" />
       
    </form>
</body>
</html>
