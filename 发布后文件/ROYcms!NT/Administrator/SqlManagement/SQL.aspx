<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SQL.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.config.SQL" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html>
<body>
<form id="form1" runat="server">
    <table width="100%"  border="0" align="center" cellpadding="0" cellspacing="10">
    <tr>
        <td>
        <asp:TextBox ID="TextBox_SQL" runat="server" Height="123px" TextMode="MultiLine" Width="480px"></asp:TextBox>
        </td>
       
    </tr>
    <tr>
     <td>
        <asp:Button ID="Button_star" CssClass="btnSubmit" runat="server" onclick="Button_star_Click" Text="执 行" Width="100px" Height="30px" />
        </td>
    </tr>
    </table> 
</form>
</body>
</html>

