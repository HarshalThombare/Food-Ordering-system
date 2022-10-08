<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeFile="RestaurantRequestForm.aspx.cs" Inherits="Online_Food_Order_System.admin.RestaurantRequestForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <span style="margin-left:50%;">My Request</span>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="10" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="10px" CellSpacing="10" style="margin-left:7%; width:117%;">
        <Columns>
            <asp:TemplateField HeaderText="Restro Name">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Address">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Address") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="City">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("City") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Contact">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("Contact") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email ID">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Operations">
                <ItemTemplate>
                    <asp:Button ID="Button1" class="Button1" runat="server" ForeColor="White" Text="Accept" BackColor="Lime" CommandName="Accept" OnClick="Button1_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" class="Button2" runat="server" ForeColor="White" Text="Decline"  BackColor="Red" CommandName="Decline" OnClick="Button2_Click"/>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
        </Columns>
        <EmptyDataTemplate>
        </EmptyDataTemplate>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView> 
<!--   
    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Accept">Accept</asp:LinkButton>
                    
    <section id="tableView" style="width:190%">
        <span>My Request</span>
        <div class="line">
            <hr>
        </div>

        
        
        <div class="table">

            <table width="90%">
                <thead>
                    <tr style="background: #ec7bdf;">
                        <td>Sr.No.</td>
                        <td>Name</td>
                        <td>Location</td>
                        <td></td>
                        <td></td>
                    </tr>
                </thead>

                <tbody>
                    <tr>
                        <td>
                            <h3><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h3>
                        </td>
                        <td>
                            <h3><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></h3>
                        </td>

                        <td>
                            <h3><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></h3>
                        </td>

                        <td><a href="ViewRestroInfoForm2.aspx">View</a></td>

                        <td><a href="#">Accept</a></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </section>-->
</asp:Content>
