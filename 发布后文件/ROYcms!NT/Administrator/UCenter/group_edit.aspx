<%@ Page Language="C#" AutoEventWireup="true"  Inherits="ROYcms.UI.Admin.Administrator.UCenter.group_edit" %>
<!DOCTYPE HTML>
<html >
<body>
    <form id="group_editForm" runat="server">
    <div>
    <table cellSpacing="2" cellPadding="2" width="100%" border="0">
	<tr>
	  <td width="4%" align="right" nowrap="nowrap">小组名称：</td>
	  <td width="96%" align="left" nowrap="nowrap">
	    <asp:TextBox id="txtname" runat="server" Width="200px"  CssClass="txtInput" ></asp:TextBox>
      </td></tr>
	<tr>
	<td width="4%" align="right" nowrap="nowrap">描述：</td>
	<td width="96%" align="left" nowrap="nowrap">
		<asp:TextBox id="txtzhaiyao" runat="server" Width="200px" TextMode="MultiLine"></asp:TextBox>
	</td></tr>
	<tr>
	<td width="4%" align="right" nowrap="nowrap">权限标识：</td>
	<td width="96%" align="left" nowrap="nowrap">
		<asp:TextBox id="txtRoleID" runat="server" Width="50px"  CssClass="txtInput"></asp:TextBox>
	</td></tr>
	<tr>
	  <td  nowrap="nowrap">&nbsp;</td>
	  <td  nowrap="nowrap"><asp:Button ID="btnUpdate" runat="server" Text="确认编辑" OnClick="btnUpdate_Click"  CssClass="btnSearch" ></asp:Button></td>
	  </tr>
</table>
    </div>
    </form>
</body>
</html>
