<%@ Page Title="" Language="C#" MasterPageFile="~/home/Index.Master" AutoEventWireup="true" CodeFile="RestaurantRegForm2.aspx.cs" Inherits="Online_Food_Order_System.home.RestaurantRegForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/registration.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="body">             
                <div class="layout1">
                    <asp:Label ID="Label1" class="Lbl" runat="server" Text="Label">BUSINESS REGISTRATION</asp:Label><br/><br/>
                    <asp:TextBox ID="fathername" class="name" runat="server" placeholder="Enter Father Name" required="required"></asp:TextBox><sup style="color:red"><b>*</b></sup>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="fathername" ErrorMessage="Please Enter Valid Name" ForeColor="Red" Display="None" ValidationExpression="^[a-zA-Z\s]+$" />   
                    <br/><br/>
                    <asp:TextBox ID="bornplace" class="name" runat="server" placeholder="Enter Born Place"></asp:TextBox><sup style="color:red"><b>*</b></sup>  
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="bornplace" ErrorMessage="Please Enter Valid Name" ForeColor="Red" Display="None" ValidationExpression="^[a-zA-Z\s]+$" />   
                    <br/><br/>
                    <asp:TextBox ID="fvrteplace" class="name" runat="server" placeholder="Enter Favourite Place" required="required"></asp:TextBox><sup style="color:red"><b>*</b></sup>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="fvrteplace" ErrorMessage="Please Enter Valid Name" ForeColor="Red" Display="None" ValidationExpression="^[a-zA-Z\s]+$"/>   
                    <br /><br/>
                    <asp:Button ID="Button1" class="Button1" runat="server" ForeColor="White" Text="Submit" OnClick="Button1_Click" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ForeColor="Red" ShowMessageBox="True" ShowSummary="False" />
                    <br />
                </div>
        </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
