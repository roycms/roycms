<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tag.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Objet.tag" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<!DOCTYPE HTML>
<html >
<head runat="server">
<title></title>
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <table width="98%" border="0" align="center" cellpadding="0" cellspacing="4">
    <tr>
      <td><fieldset>
          <legend>
          <img name="" src="/administrator/images/image_edit.png" width="16" height="16" alt="">&nbsp;&nbsp;选择已存在标签</legend>
          <span class="licss"></span>
          <table width="98%" height="63" border="0" align="center" cellpadding="0" cellspacing="10">
            <tr>
              <td> 选择标签
                <asp:Repeater ID="Repeater_Tag" runat="server">
                  <ItemTemplate>
                    <img name="" src="/administrator/images/bullet_feed.png" width="16" height="16" alt="">
                    <a href="?<%#Eval("Tag")%>"><%#Eval("Tag")%></a>
                  <a href="?del=<%#Eval("id")%>"><img src="/administrator/images/cms-ico6.gif" alt="删除该标签" name="" width="8" height="7" border="0"></a></ItemTemplate>
                </asp:Repeater></td>
            </tr>
          </table>
        </fieldset></td>
    </tr>
  </table>
</form>
</body>
</html>
