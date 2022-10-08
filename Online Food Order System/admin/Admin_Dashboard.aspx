<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeFile="Admin_Dashboard.aspx.cs" Inherits="Online_Food_Order_System.admin.Admin_Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section id="interface">
        <h2 class="name">Dashboard</h2>
        <div class="line">
            <hr>
        </div>
        <div class="values">
            <div class="val-box">
                <i class="fas fa-hotel"></i>
                <div>
                    <h3><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h3>
                    <span>Register Restro</span>
                </div>
            </div>

            <div class="val-box">
                <i class="fas fa-users"></i>
                <div>
                    
                    <h3><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></h3>
                    <span>Register User</span>
                </div>
            </div>

            <div class="val-box">
                <i class="fas fa-analytics"></i>
                <div>
                    <h3><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></h3>
                    <span>Analysis </span>
                </div>
            </div>

            <div class="val-box">
                <i class="fas fa-comment-alt-smile"></i>
                <div>
                    <h3><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></h3>
                    <span>Request</span>
                </div>
            </div>

        </div>
    </section>
</asp:Content>
