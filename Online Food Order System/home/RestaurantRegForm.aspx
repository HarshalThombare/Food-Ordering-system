<%@ Page Title="" Language="C#" MasterPageFile="~/home/Index.Master" AutoEventWireup="true" CodeFile="RestaurantRegForm.aspx.cs" Inherits="Online_Food_Order_System.home.RestaurantRegForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/registration.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="body">
                <div class="layout">
                    <asp:Label ID="Label1" class="Lbl" runat="server" Text="Label">BUSINESS REGISTRATION</asp:Label><br/><br/><br/>
                    <asp:TextBox ID="email" class="email" runat="server" placeholder="Enter Email Id" TextMode="Email" required="required"></asp:TextBox><sup style="color:red"><b>*</b></sup>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" Display="None" ErrorMessage="Please Enter Valid Email Id" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <br/><br/>
                    <asp:TextBox ID="pwd" class="pwd" runat="server" placeholder="Enter Password" TextMode="Password" min-length="6" max-length="15" required="required"></asp:TextBox><sup style="color:red"><b>*</b></sup>&nbsp;<img src="../img/information-image.png" width="20px" height="20px" onmouseover="alert('Password must contain: Minimum 6 and Maximum 15 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character');"></img>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="pwd" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{6,15}" ErrorMessage="Password must contain: Minimum 6 and Maximum 15 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character" ForeColor="Red" Display="None" />   
                    <br /><br/>
                    <asp:CheckBox ID="CheckBox1" runat="server" />            
                    <big>Terms & Conditions <sup style="color:red">*</sup></big><br />
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Please Check Terms & Conditions" ForeColor="red" onservervalidate="CustomValidator1_ServerValidate" Display="static"></asp:CustomValidator><br /><br />
                    <asp:Button ID="Button1" class="Button1" runat="server" ForeColor="White" Text="Next Page" OnClick="Button1_Click" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ForeColor="Red" ShowMessageBox="True" ShowSummary="False" />
                    <br />
                    &nbsp;&emsp;<asp:Label ID="Label2" class="Label2" runat="server" Text="Label">Already Registered ? <a href="LoginForm.aspx"> SignIn / LogIn </a></asp:Label>
                </div>
        </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
