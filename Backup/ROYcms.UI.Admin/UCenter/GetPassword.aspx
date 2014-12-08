<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetPassword.aspx.cs" Inherits="ROYcms.UCenter.GetPassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        请输入用户名<asp:TextBox ID="TextBox_username" runat="server"></asp:TextBox>
        <asp:Button ID="Button_getpassword"  runat="server" Text="找回密码" onclick="Button_getpassword_Click" />
    </div>
    </form>
</body>
</html>
