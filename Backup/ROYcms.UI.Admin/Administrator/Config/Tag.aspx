<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tag.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.config.Tag" %>


<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>        

<!DOCTYPE HTML>
<html>
<head id="Head1" runat="server">
<title></title>
</head>
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
<script language="JavaScript"  src="/administrator/js/alt.js"></script>
<body>
<form id="form1" runat="server">
<Resources:Resources ID="Resources1" runat="server" />
  <div>
  <table width="100%" border="0" class="tiao_top" style="margin-bottom:10px;">
      <tr>
        <td width="77%" nowrap><div class="tiao_con"><a href="#"><img align="absmiddle" src="/administrator/images/nv6.png" />添加信息</a> <a href="#"><img align="absmiddle" src="/administrator/images/nv8.png" />批量删除</a> <a href="#"><img align="absmiddle" src="/administrator/images/nv9.png" />批量验证</a> <a href="#"><img align="absmiddle" src="/administrator/images/pill.png" />批量置顶</a> <a href="#"><img align="absmiddle" src="/administrator/images/rosette.png" />批量验证</a>
         <a href="#toclass" onClick="toclassdiv()"><img align="absmiddle" src="/administrator/images/rosette.png" />批量转移</a>
        
        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
  
    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td><fieldset>
          <legend><img name="" src="/administrator/images/shape_rotate_clockwise.png" width="16" height="16" alt="">&nbsp;&nbsp;系统标签云</legend>
          <table width="98%"  border="0" align="center" cellpadding="0" cellspacing="10">
            <tr>
              <td>
     <asp:Repeater ID="Repeater_tag" runat="server">
                  <ItemTemplate>
                    <img name="" src="/administrator/images/bullet_feed.png" width="16" height="16" alt="">
                    <a href="?<%#Eval("Tag")%>"><%#Eval("Tag")%></a>
                  <a href="?del=<%#Eval("id")%>"><img src="/administrator/images/cms-ico6.gif" alt="删除该标签" name="" width="8" height="7" border="0"></a>
                  </ItemTemplate>
     </asp:Repeater>
              </td>
            </tr>
          </table>
        </fieldset></td>
      </tr>
    </table>
  </div>
</form>
</body>
</html>
