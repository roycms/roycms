<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator.UCenter.AddGroup" %>
<html>
<body>
<form id="AddGroupForm" runat="server">
    <table cellSpacing="2" cellPadding="2" width="360" border="0">
      <tr>
        <td width="7%" align="right" nowrap>小组名称： </td>
        <td width="93%" align="left" nowrap>
        <asp:TextBox ID="txtname" runat="server" Width="180px" CssClass="txtInput"></asp:TextBox></td>
      </tr>
      <tr>
        <td height="25" nowrap>小组描述：</td>
        <td  align="left" nowrap>
        <asp:TextBox ID="txtzhaiyao" runat="server" Width="200px" TextMode="MultiLine"></asp:TextBox></td>
      </tr>
      <tr>
        <td nowrap>&nbsp;</td>
        <td align="left" nowrap>
        <asp:Button ID="btnAdd" runat="server" Text="确定添加" OnClick="btnAdd_Click" CssClass="btnSearch"></asp:Button></td>
      </tr>
    </table>
</form>
</body>
</html>
