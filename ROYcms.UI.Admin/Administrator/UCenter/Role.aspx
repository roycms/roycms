<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Role.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.UCenter.Role" %>

<%@ Register src="top.ascx" tagname="top" tagprefix="uc1" %>

<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>

<!DOCTYPE HTML>
<html >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <Resources:Resources ID="Resources1" runat="server" />
    
        <Resources:Resources ID="Resources1" runat="server" />
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
            DataKeyNames="id" DataSourceID="Role_SqlDataSource" ForeColor="#333333" 
            GridLines="None">
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="zhaiyao" HeaderText="zhaiyao" 
                    SortExpression="zhaiyao" />
                <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
                <asp:BoundField DataField="GUID" HeaderText="GUID" SortExpression="GUID" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
        <asp:SqlDataSource ID="Role_SqlDataSource" runat="server" 
            ConnectionString="Data Source=ROY;Initial Catalog=ROYcms;Integrated Security=True" 
            DeleteCommand="DELETE FROM [ROYcms_Role] WHERE [id] = @id" 
            InsertCommand="INSERT INTO [ROYcms_Role] ([name], [zhaiyao], [Time], [GUID]) VALUES (@name, @zhaiyao, @Time, @GUID)" 
            ProviderName="System.Data.SqlClient" 
            SelectCommand="SELECT * FROM [ROYcms_Role]" 
            UpdateCommand="UPDATE [ROYcms_Role] SET [name] = @name, [zhaiyao] = @zhaiyao, [Time] = @Time, [GUID] = @GUID WHERE [id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="zhaiyao" Type="String" />
                <asp:Parameter Name="Time" Type="DateTime" />
                <asp:Parameter Name="GUID" Type="String" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="zhaiyao" Type="String" />
                <asp:Parameter Name="Time" Type="DateTime" />
                <asp:Parameter Name="GUID" Type="String" />
            </InsertParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
