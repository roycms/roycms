<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator_config_faucet" Codebehind="faucet.aspx.cs" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
        
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html>
<head id="Head1" runat="server">
<title></title>
<style type="text/css">
<!--
.API {
	font-family: "微软雅黑";
	margin-left:10px;
	margin-top:15px;
	margin-bottom:15px;
}
.API h2 {
	font-size:16px;
	margin:4px;
}
.API h3 {
	font-size:13px;
	margin:2px;
}
.API p {
	color:#989898;
}
-->
</style>
</head>
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
<script language="JavaScript"  src="/administrator/js/alt.js"></script>
<body>
<form id="form1" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <div><br>
    <table width="100%"  border="0" cellpadding="0" cellspacing="4">
      <tr>
        <td>
        
           <table width="100%" border="0" class="tiao_top" >
      <tr>
        <td width="77%" nowrap><div class="tiao_con"> <a href="/Administrator/config/AdminPassword.aspx"><img align="absmiddle" src="/administrator/images/rosette.png" />系统账户</a>
        <a href="/administrator/_center.aspx"><img align="absmiddle" src="/administrator/images/nv6.png" />系统状态</a> 
        <a href="/administrator/config/dll.aspx"><img align="absmiddle" src="/administrator/images/nv8.png" />DLL版本</a> 
        <a href="/administrator/config/Caching.aspx"><img align="absmiddle" src="/administrator/images/nv9.png" />缓存管理</a> 
        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
        
        <fieldset>
            
            <div  class="API">
              <h2>插件名称</h2>
              <h3><a href="#" target="_blank">配置</a> <a href="#" target="_blank">卸载</a> <a href="#" target="_blank">查看</a></h3>
              <p>插件描述</p>
            </div>
          </fieldset></td>
      </tr>
    </table>
  </div>
</form>
</body>
</html>
