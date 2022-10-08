<%@ Page Title="" Language="C#" MasterPageFile="~/home/IndexLogin.Master" AutoEventWireup="true" CodeFile="LoginForm.aspx.cs" Inherits="Online_Food_Order_System.home.LoginForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="body">
        <form id="form1" runat="server">
        <div class="form">
        <h1>LOGIN</h1>
        <asp:Label ID="errMessage" class="Label1" runat="server" Text="ErrMessage" BackColor="White" ForeColor="Red" Visible="False"></asp:Label>
        <asp:TextBox ID="email" class="box" runat="server" placeholder="Enter Email Id" TextMode="Email" required="required"></asp:TextBox>
        <asp:TextBox ID="password" class="box" runat="server" placeholder="Enter Password" TextMode="password" required="required"></asp:TextBox>
        <select id="Select1"  class="box" name="opt" required="required">
            <option value="character" disabled selected>Please Select Ur Character </option>
            <option value="Customer">Customer</option>
            <option value="Admin">Admin</option>
            <option value="Restaurant">Restaurant</option>
        </select>
        <asp:Button ID="submit" class="submit" runat="server" Text="Login" OnClick="submit_Click" /><br />
        <asp:Label ID="Label3" class="Label1" runat="server" Text="Label"><a href="ForgotPasswordForm.aspx">Forgot Password </a></asp:Label>   
        <asp:Label ID="Label1" class="Label1" runat="server" Text="Label">Not Registered ? <a href="CustomerRegForm.aspx">SignUp / Register </a></asp:Label>   
        <asp:Label ID="Label2" class="Label1" runat="server" Text="Label">Not Registered Business? <a href="RestaurantRegForm.aspx">SignUp / Register </a></asp:Label>   
        </div>
         </form>
    </section>
        
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
