<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebGroup.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator_go_WebGroup" %>


<html>
<head runat="server">
    <title>站群管理</title>
    <link href="/administrator/css/style.css" rel="stylesheet" type="text/css" />
    <script src="/administrator/WebUI/SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
<link href="/administrator/WebUI/SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css">
</head>
<body>
<div id="TabbedPanels1" class="TabbedPanels">
  <ul class="TabbedPanelsTabGroup">
    <li class="TabbedPanelsTab" tabindex="0"><img name="" src="/administrator/images/plus-.gif" width="6" height="5" alt=""> 子站及共享信息管理 </li>
    <li class="TabbedPanelsTab" tabindex="0"><img name="" src="/administrator/images/plus-.gif" width="6" height="5" alt=""> 站群通行证配置 </li>
    <li class="TabbedPanelsTab" tabindex="0"><img name="" src="/administrator/images/plus-.gif" width="6" height="5" alt=""> 访问权限设置</li>
    <li class="TabbedPanelsTab" tabindex="0"><img name="" src="/administrator/images/plus-.gif" width="6" height="5" alt=""> 数据共享设置</li>
  </ul>
  <div class="TabbedPanelsContentGroup">
    <div class="TabbedPanelsContent">无</div>
    <div class="TabbedPanelsContent">
      <table width="100%" border="0" align="center" cellpadding="8" cellspacing="0">
        <tr>
          <td width="33%">未开通</td>
        </tr>
      </table>
    </div>
    <div class="TabbedPanelsContent">无访问权限</div>
    <div class="TabbedPanelsContent">无共享内容</div>
  </div>
</div>
<script type="text/javascript">
<!--
var TabbedPanels1 = new Spry.Widget.TabbedPanels("TabbedPanels1", {defaultTab:1});
//-->
</script>
</body>
</html>
