<%@ Page Title="" Language="C#" MasterPageFile="~/home/IndexLogin.Master" AutoEventWireup="true" CodeFile="ForgotPasswordForm.aspx.cs" Inherits="Online_Food_Order_System.home.ForgotPasswordForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="body">
        <form id="form1" runat="server">
        <div class="form">
        <h1>Change Password</h1>
        <asp:Label ID="errMessage" class="Label1" runat="server" Text="ErrMessage" BackColor="White" ForeColor="Red" Visible="False"></asp:Label>        
        <asp:TextBox ID="getemail" class="box" runat="server" placeholder="Enter Email Id" TextMode="Email" required="required"></asp:TextBox>
        <select id="Select1"  class="box" name="opt" required="required">
            <option value="character" disabled selected>Please Select Ur Character </option>
            <option value="Customer">Customer</option>
            <option value="Restaurant">Restaurant</option>
        </select>
        <select id="Select2"  class="box" name="question" required="required">
            <option value="character" disabled selected>Please Select Questions To Verfiy its U </option>
            <option value="Fathername">What's Your Father Name ?</option>
            <option value="bornplace">What's Your Born Place ?</option>
            <option value="fvrteplace">What's Your Favourite Place ?</option> 
        </select>
        <asp:TextBox ID="answer" class="box" runat="server" placeholder="Enter Your Answer" required="required"></asp:TextBox>
        <asp:Button ID="submit" class="submit" runat="server" Text="Validate" OnClick="submit_Click" /><br />
        </div>
         </form>
    </section>
        
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
