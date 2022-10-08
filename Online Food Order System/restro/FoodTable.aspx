<%@ Page Title="" Language="C#" MasterPageFile="~/restro/R_admin.Master" AutoEventWireup="true" CodeFile="FoodTable.aspx.cs" Inherits="Online_Food_Order_System.restro.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/demo.css" rel="stylesheet" />
    <!--datatable css cdn-->
    <link href="../datatables/css/jquery.dataTables.min.css" rel="stylesheet" />
    <link rel="style" href="https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css"/>
    <!--jquery-->
    <script src="https://code.jquery.com/jquery-3.5.1.js"></script>
     <!--datatable cdn-->
    <script src="../datatables/js/jquery.dataTables.min.js"></script>
    <script src="https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="tableView">
        <center><span>Food List</span></center>
        <div class="line">
            <hr>
        </div>
 
        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="b1" OnClick="LinkButton1_Click">ADD NEW</asp:LinkButton>
        <span>
        <asp:Label ID="Label1" runat="server" Text="Food ID :" CssClass="l1"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="t1" PlaceHolder="ID"></asp:TextBox>
            <asp:LinkButton ID="LinkButton2" runat="server" CssClass="b2" OnClick="LinkButton2_Click" >VIEW</asp:LinkButton>
             
            <asp:LinkButton ID="LinkButton3" runat="server" CssClass="b3" OnClick="LinkButton3_Click2">UPDATE</asp:LinkButton>

            <asp:Button ID="Button4" runat="server" Text="DELETE" CssClass="b4" OnClick="Button4_Click1" />
        <br />
            </span>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:foodOrderDBConnectionString %>" SelectCommand="SELECT [f_id], [food_name], [type], [category], [availability], [image] FROM [Food]"></asp:SqlDataSource>
     
   
    
        <br />
     
   
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="f_id" DataSourceID="SqlDataSource1" CssClass="table table-striped table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1142px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="f_id" HeaderText="Food ID" ReadOnly="True" SortExpression="f_id" />
                <asp:BoundField DataField="food_name" HeaderText="Food Name" SortExpression="food_name" />
                <asp:BoundField DataField="type" HeaderText="Type" SortExpression="type" />
                <asp:BoundField DataField="category" HeaderText="Category" SortExpression="category" />
                <asp:BoundField DataField="availability" HeaderText="Availability" SortExpression="availability" />
                <asp:BoundField DataField="image" HeaderText="Image" SortExpression="image" />
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
     
   
    
    </section>

    

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <script src="../datatables/js/jquery.dataTables.min.js"></script>

     <script type="text/javascript">
        
         $(document).ready(function () {
             $('.table').prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable();
             //  $('.table').DataTable();
         });
       

     </script>
    

     

     </asp:Content>
