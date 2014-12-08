<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BatchSendEmailaspx.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Email.BatchSendEmailaspx" %>

<!DOCTYPE HTML>

<html >
<head>
    <style type="text/css">
        .auto-style1 {
            width: 175px;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <h3>群发邮件</h3>
  <table border="0" style="width: 759px">
    <tr>
      <td class="auto-style1">导入邮件地址</td>
      <td>
          <asp:FileUpload ID="FileUpload_index" runat="server" />
          <asp:Button ID="Button_add_email" runat="server" Text="导入邮件" OnClick="Button_add_email_Click" />
&nbsp;<a href="/App_Templet/SystemTemplate/email_template.xls">下载邮件列表模板</a></td>
    </tr>
    <tr>
      <td class="auto-style1">&nbsp;</td>
      <td><asp:Button ID="Button_send_mail" runat="server" Text="立即发送" OnClick="Button_send_mail_Click" />
        群发邮件比较耗费资源请慎重操作</td>
    </tr>
  </table>
</form>
</body>
</html>
