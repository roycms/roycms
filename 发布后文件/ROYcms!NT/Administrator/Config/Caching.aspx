<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator_config_Caching" Codebehind="Caching.aspx.cs" %>

<!DOCTYPE HTML>
<html>

<body>
<form id="form1" runat="server">


         
          <table width="360px" height="87" border="0" align="center" cellpadding="0" cellspacing="10">
            <tr>
              <td>
              
              <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br /> <br />
        <asp:Button CssClass="bt" ID="Button_del" runat="server" Text=" 清除所有缓存 " onclick="Button_delete" />

              
              </td>
            </tr>
          </table>
      
</form>
</body>
</html>

