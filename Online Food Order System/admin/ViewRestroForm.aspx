<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeFile="ViewRestroForm.aspx.cs" Inherits="Online_Food_Order_System.admin.ViewRestroForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <section id="tableView">
        <span>My Restro</span>
        <div class="line">
            <hr>
        </div>

        <div class="find">
            <div class="search">
                <i class="far fa-search"></i>
                <input type="text" placeholder="Search Here">
            </div>

            <!-- <div class="dropdown">
                <select name="" id=""></select>
            </div> -->
        </div>
        <div class="table">

            <table width="90%">
                <thead>
                    <tr style="background: #7b7cec;">
                        <td>Sr.No.</td>
                        <td>Name</td>
                        <td>Type</td>
                        <td>Location</td>
                        <td>Contact</td>
                        <td></td>
                    </tr>
                </thead>

                <tbody>
                    <tr>
                        <td>
                            <h3>1</h3>
                        </td>
                        <td>
                            <h3>Home Made</h3>
                        </td>
                        <!-- <td><img src="img/home.jpeg" alt=""></td> -->
                        <td>
                            <h3>Veg</h3>
                        </td>
                        <td>
                            <h3>Pune</h3>
                        </td>
                        <td>
                            <h3>9988776600</h3>
                        </td>
                        <td><a href="#">Delete</a></td>
                    </tr>

                    <tr>
                        <td>
                            <h3>1</h3>
                        </td>
                        <td>
                            <h3>Home Made</h3>
                        </td>
                        <!-- <td><img src="img/home.jpeg" alt=""></td> -->
                        <td>
                            <h3>Veg</h3>
                        </td>
                        <td>
                            <h3>Pune</h3>
                        </td>
                        <td>
                            <h3>9988776600</h3>
                        </td>
                        <td><a href="#">Delete</a></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </section>
</asp:Content>
