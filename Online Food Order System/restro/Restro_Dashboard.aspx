<%@ Page Title="" Language="C#" MasterPageFile="~/restro/R_admin.Master" AutoEventWireup="true" CodeBehind="Restro_Dashboard.aspx.cs" Inherits="Online_Food_Order_System.restro.WebForm1" %>
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
                <i class="fas fa-utensils"></i>
                <div>
                    <h3>10</h3>
                    <span>Dishes</span>
                </div>
            </div>

            <div class="val-box">
                <i class="fas fa-utensil-fork"></i>               
                <div>
                    <h3>100</h3>
                    <span>Orders</span>
                </div>
            </div>



            <div class="val-box">
                <i class="fas fa-analytics"></i>
                <div>
                    <h3>100</h3>
                    <span>Analysis </span>
                </div>
            </div>

            <div class="val-box">
                <i class="fas fa-user-friends"></i>
                <div>
                    <h3>100</h3>
                    <span>Users</span>
                </div>
            </div>

        </div>
    </section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
