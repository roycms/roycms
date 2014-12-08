<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator.UCenter.send_mail" %>
<!DOCTYPE HTML>
<html >
<body>
<form id="form1" runat="server">
  <table width="600" border="0">
    <tr>
      <td>标题</td>
      <td><asp:TextBox ID="Email_title" runat="server" Width="426px"></asp:TextBox></td>
    </tr>
    <tr>
      <td>邮件内容</td>
      <td><asp:TextBox ID="Email_content" runat="server" Height="185px" 
            TextMode="MultiLine" Width="558px"  ></asp:TextBox></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
      <td><asp:Button ID="Button_send_mail" runat="server" Text="立即发送" OnClick="Button_send_mail_Click" />
        群发邮件比较耗费资源请慎重操作</td>
    </tr>
  </table>
</form>
</body>
</html>
