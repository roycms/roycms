<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRss.aspx.cs" Inherits="ROYcms.UCenter.AddRss" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
</head>
<body>
    <form id="form1" runat="server" style="margin:0px; padding:0px;">
      <table width="400" border="0" cellspacing="5" cellpadding="4">
          <tr>
            <td align="right">订阅标题</td>
            <td><asp:TextBox CssClass="txtInput"  ID="TextBox_rss_name" runat="server"  Width="260px"></asp:TextBox></td>
          </tr>
          <tr>
            <td align="right">订阅地址</td>
            <td><asp:TextBox CssClass="txtInput"  ID="TextBox_rss_url" runat="server"  Width="260px"></asp:TextBox></td>
          </tr>
          <tr>
            <td align="right">订阅描述</td>
            <td><asp:TextBox CssClass="txtInput"  ID="TextBox_rss_zhaiyao" runat="server"  Width="260px"></asp:TextBox></td>
          </tr>
          <tr>
            <td align="right">&nbsp;</td>
            <td><asp:Button ID="Button_ADDrss" runat="server" Text="订阅" Width="90px" OnClick="Button_ADDrss_Click" CssClass="btnSearch" /></td>
          </tr>
        </table>
    </form>
</body>
</html>
