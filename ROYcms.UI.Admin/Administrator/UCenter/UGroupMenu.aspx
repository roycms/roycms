<%@ Page Language="C#" AutoEventWireup="true"  Inherits="ROYcms.UI.Admin.Administrator.UCenter.UGroupMenu" ValidateRequest="false" %>

<!DOCTYPE HTML>
<html >

<body>
<form id="form1" runat="server">
  <table width="600" border="0">
      <tr>
        <td nowrap="nowrap">菜单内容</td>
        <td><asp:TextBox ID="TextBox_UGroupMenu" runat="server" Height="203px" TextMode="MultiLine"  Width="547px"></asp:TextBox></td>
    </tr>
      <tr>
        <td>&nbsp;</td>
        <td><asp:Button ID="Button_Edit" runat="server" Text="确认修改"  OnClick="Button_Edit_Click" /></td>
      </tr>
  </table>
</form>
</body>
</html>
