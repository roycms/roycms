<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update_password.aspx.cs" Inherits="ROYcms.UI.Admin.UCenter.update_password" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>更改密码</title>
</head>
<body>
    <form id="form1" runat="server">
    <div><br />
      <br />
      <table width="400" border="0" align="center" cellpadding="4" cellspacing="4" style="font-size:14px; color:#333;">
      <tr>
        <td colspan="2" align="left">+修改密码<hr style="height:1px;" /></td>
        </tr>
      <tr>
            <td align="right">原密码：</td>
            <td><asp:TextBox ID="old_password" runat="server" TextMode="Password"></asp:TextBox></td>
          </tr>
          <tr>
            <td align="right">新密码： </td>
            <td><asp:TextBox ID="password1" runat="server" TextMode="Password"></asp:TextBox></td>
          </tr>
          <tr>
            <td align="right">确认密码：</td>
            <td><asp:TextBox ID="password2" runat="server" TextMode="Password"></asp:TextBox></td>
          </tr>
          <tr>
            <td align="right">&nbsp;</td>
            <td><asp:Button ID="Button_update_password" runat="server" 
            OnClick="Button_update_password_Click" Text="确认更改" /></td>
          </tr>
        </table>
<br />
        <br />
    </div>
    </form>
</body>
</html>
