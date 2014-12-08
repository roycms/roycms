<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Attribute.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Objet.Attribute" %>

<!DOCTYPE HTML>
<html>
<head runat="server">
    <title>扩展属性 自定义表单</title>
    <link href="/administrator/css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <table width="98%" border="0" align="center" cellpadding="0" cellspacing="4">
        <tr>
            <td><fieldset>
              <legend> <img name="" src="/administrator/images/image_edit.png" width="16" height="16" alt="">&nbsp;&nbsp;发布信息 [自定义属性, 
                  <a href="from.aspx?ClassKind=<%=Request["ClassKind"] %>">自定义表单</a>]</legend>
              <span class="licss"></span>
              <table width="98%" height="63" border="0" align="center" cellpadding="0" cellspacing="10">
            <tr>
              <td> <asp:Xml ID="Xml_From" runat="server"></asp:Xml>
                <br>
                  <asp:Repeater ID="Repeater_XClass" runat="server"></asp:Repeater>
              </td>
            </tr>
            <tr>
              <td colspan="2" ><table width="100%" border="0" cellspacing="0" cellpadding="10">
                  <tr>
                    <td><asp:Button CssClass="bt" ID="Button_Attribute" runat="server" Text="确认完善提交信息" 
            OnClick="Button_Attribute_Click" /></td>
                  </tr>
              </table></td>
            </tr>
          </table>
              </fieldset></td>
        </tr>
      </table>
    </div>
    </form>
</body>
</html>
