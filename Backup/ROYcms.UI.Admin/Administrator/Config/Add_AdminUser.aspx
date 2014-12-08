<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_AdminUser.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.config.Add_AdminUser" %>

<!DOCTYPE HTML>
<html>
<head runat="server">
    <title></title>
</head>
<body>
<form id="Add_AdminUserForm" runat="server">
<table cellSpacing="0" cellPadding="0" width="360" border="0">
	<tr>
	  <td height="25" width="30%" align="right">
	    用户名
	    ：</td>
	  <td height="25" width="*" align="left">
	    <asp:TextBox id="txtname" runat="server" Width="150px"></asp:TextBox>
	    <asp:Label ID="lblid" runat="server"></asp:Label></td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		密码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpassword" runat="server" Width="136px"  TextMode="Password"></asp:TextBox>
	</td></tr>
	<tr>
	  <td height="25" align="right">再次输入密码：</td>
	  <td height="25" align="left"><asp:TextBox id="txtpassword2" runat="server" Width="136px"  TextMode="Password"></asp:TextBox></td>
	  </tr>
	<tr>
	<td height="25" width="30%" align="right">
		标识
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtclasskind" runat="server" Width="50px"></asp:TextBox>
	</td></tr>
	<tr>
	  <td height="25" align="right">权限
	：</td>
	  <td height="25" align="left"><asp:TextBox ID="txtRol" runat="server" Width="50px"></asp:TextBox></td>
	  </tr>
	<tr>
	<td height="25" width="30%" align="right">&nbsp;</td>
	<td height="25" width="*" align="left"><asp:Button ID="btAdd" runat="server" Text="确认添加" OnClick="btnAdd_Click" ></asp:Button></td></tr>
</table>
</form>
</body>
</html>
