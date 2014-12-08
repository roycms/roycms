<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminNews.aspx.cs" Inherits="ROYcms.Tools.Tp.Administrator._tp.AdminNews" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>admin</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        新闻标题：<asp:DropDownList ID="DropDownList_type" runat="server" 
            Width="80px" Height="32px">
            <asp:ListItem Value="1">头条信息</asp:ListItem>
            <asp:ListItem Value="2">活动信息</asp:ListItem>
            <asp:ListItem Value="3">轮番图片</asp:ListItem>
        </asp:DropDownList>
    
        <asp:TextBox ID="TextBox_title" runat="server" Width="476px" Height="28px" ></asp:TextBox>
        
        &nbsp;<asp:Button ID="Button_add" runat="server" Text="确认添加信息" 
            onclick="Button_add_Click" />
        
          <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" EditorAreaCSS="/App_Templet/SystemCss/FckCss.css" BasePath="/administrator/FCKedit/" Height="400px" ToolbarSet="Basic" Width="100%" Value=""></FCKeditorV2:FCKeditor>
       
        <hr />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
            BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" 
            CellSpacing="1" DataKeyNames="id" DataSourceID="SqlDataSource_news" 
            GridLines="None" Height="74px" Width="883px">
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" 
                    SortExpression="id" />
                <asp:BoundField DataField="title" HeaderText="标题" SortExpression="title" />
                <asp:BoundField DataField="time" HeaderText="时间" SortExpression="time" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        </asp:GridView>
        
        <br />
        <asp:SqlDataSource ID="SqlDataSource_news" runat="server" 
            ConnectionString="<%$ ConnectionStrings:nw33107_dbConnectionString %>" 
            DeleteCommand="DELETE FROM [ROYcms_New] WHERE [id] = @id" 
            InsertCommand="INSERT INTO [ROYcms_New] ([id], [title], [content], [time]) VALUES (@id, @title, @content, @time)" 
            SelectCommand="SELECT [id], [title], [content], [time] FROM [ROYcms_New] ORDER BY [id] DESC" 
            UpdateCommand="UPDATE [ROYcms_New] SET [title] = @title, [content] = @content, [time] = @time WHERE [id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="title" Type="String" />
                <asp:Parameter Name="content" Type="String" />
                <asp:Parameter DbType="Date" Name="time" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="id" Type="Int32" />
                <asp:Parameter Name="title" Type="String" />
                <asp:Parameter Name="content" Type="String" />
                <asp:Parameter DbType="Date" Name="time" />
            </InsertParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
