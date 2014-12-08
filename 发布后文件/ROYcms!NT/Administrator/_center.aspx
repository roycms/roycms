<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.admin_admin_center" Codebehind="_center.aspx.cs" %>
<%@ Register src="Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
</head>
<body>
<form id="form1" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <div>
    <table width="100%" border="0" class="tiao_top" >
      <tr>
        <td width="77%" nowrap><div class="tiao_con"> <a href="/Administrator/config/AdminPassword.aspx"><img align="absmiddle" src="/administrator/images/rosette.png" />系统账户</a> <a href="/administrator/log/index.aspx "><img align="absmiddle" src="/administrator/images/rosette.png" />系统日志</a> <a href="/administrator/_center.aspx"><img align="absmiddle" src="/administrator/images/nv6.png" />系统状态</a> <a rel="facebox" title="DLL版本信息" href="/administrator/config/dll.aspx"><img align="absmiddle" src="/administrator/images/nv8.png" />DLL版本信息</a> <a rel="facebox" title="缓存管理" href="/administrator/config/Caching.aspx"><img align="absmiddle" src="/administrator/images/nv9.png" />缓存管理</a> </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td><table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:5px;">
            <tr>
              <td width="8%"><strong class="_help"><img name="" src="/administrator/images/083.png" width="64" height="64" alt=""></strong></td>
              <td width="92%"><h2><strong class="yahei">[<%=Request.ServerVariables.Get("Local_Addr").ToString()%>]<span style="vertical-align: middle;"></span>服务器信息 </strong></h2></td>
            </tr>
          </table></td>
      </tr>
      <tr>
        <td><table width="100%" cellpadding="3" cellspacing="2" bgcolor="#F4FBFF" class="style60">
            <tr>
              <td width="9%" align="left" nowrap bgcolor="#F4FBFF" class="style2"><strong class="_help"><img name="" src="/administrator/images/bricks.png" width="16" height="16" alt=""></strong> 文章总数:</td>
              <td width="8%" bgcolor="#F4FBFF" nowrap="nowrap"><asp:Label ID="Label001" runat="server"></asp:Label></td>
              <td width="11%" bgcolor="#F4FBFF" nowrap="nowrap"><strong class="_help"><img name="" src="/administrator/images/bricks.png" width="16" height="16" alt=""></strong> 服务器信息:</td>
              <td width="72%" bgcolor="#F4FBFF" nowrap="nowrap"><asp:Label ID="Label2" runat="server"></asp:Label>
                <strong class="_help"><img name="" src="/administrator/images/control_play_blue.png" width="16" height="16" alt=""></strong></td>
            </tr>
            <tr>
              <td align="left" nowrap bgcolor="#F4FBFF" class="style2"><strong class="_help"><img name="" src="/administrator/images/bricks.png" width="16" height="16" alt=""></strong> 频道总数:</td>
              <td nowrap bgcolor="#F4FBFF"><asp:Label ID="Label002" runat="server"></asp:Label></td>
              <td nowrap bgcolor="#F4FBFF"><span class="style61"><strong class="_help"><img name="" src="/administrator/images/bricks.png" width="16" height="16" alt=""></strong> 服务器域名: </span></td>
              <td nowrap bgcolor="#F4FBFF"><asp:Label ID="Label3" runat="server"></asp:Label></td>
            </tr>
            <tr>
              <td align="left" nowrap bgcolor="#F4FBFF" class="style2"><strong class="_help"><img name="" src="/administrator/images/bricks.png" width="16" height="16" alt=""></strong> 待审文章总数:</td>
              <td nowrap bgcolor="#F4FBFF"><asp:Label ID="Label003" runat="server"></asp:Label></td>
              <td nowrap bgcolor="#F4FBFF"><span class="style61"><strong class="_help"><img name="" src="/administrator/images/bricks.png" width="16" height="16" alt=""></strong> 虚拟服务绝对路径:</span></td>
              <td nowrap bgcolor="#F4FBFF"><asp:Label ID="Label4" runat="server" Height="16px"></asp:Label></td>
            </tr>
            <tr>
              <td align="left" nowrap bgcolor="#F4FBFF" class="style2"><strong class="_help"><img name="" src="/administrator/images/bricks.png" width="16" height="16" alt=""></strong> 会员总数:</td>
              <td nowrap bgcolor="#F4FBFF"><asp:Label ID="Label004" runat="server"></asp:Label></td>
              <td nowrap bgcolor="#F4FBFF"><span class="style61"><strong class="_help"><img name="" src="/administrator/images/bricks.png" width="16" height="16" alt=""></strong>.NET版本信息: </span></td>
              <td nowrap bgcolor="#F4FBFF"><asp:Label ID="Label5" runat="server"></asp:Label></td>
            </tr>
            <tr>
              <td align="left" nowrap bgcolor="#F4FBFF" class="style2"><strong class="_help"><img name="" src="/administrator/images/bricks.png" width="16" height="16" alt=""></strong> 今天更新文章:</td>
              <td nowrap bgcolor="#F4FBFF"><asp:Label ID="Label007" runat="server"></asp:Label></td>
              <td colspan="2" nowrap bgcolor="#F4FBFF"><span class="style61"><strong class="_help"><img name="" src="/administrator/images/bricks.png" width="16" height="16" alt=""></strong> CPU总数:
                <asp:Label ID="Label8" runat="server"></asp:Label>
                &nbsp;&nbsp;Application总数:
                <asp:Label ID="Label6" runat="server"></asp:Label>
                &nbsp;&nbsp;已经运行时间:
                <asp:Label ID="Label9" runat="server"></asp:Label>
                &nbsp;&nbsp;应用程序缓存总数:
                <asp:Label ID="Label10" runat="server"></asp:Label>
                </span></td>
            </tr>
        </table></td>
      </tr>
      <tr>
        <td>
        <span class="btnSearch" style="padding:3px;"> 官方公告 </span><br />
          <iframe width="480px" frameborder="0"  height="180px" src="http://www.roycms.cn/api/index.aspx" scrolling="no"></iframe>
         </td>
      </tr>
    </table>
  </div>
</form>
</body>
</html>
