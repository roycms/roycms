<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator_admin_index"  %>
<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title><CMS:WebConfig Name="web_name" runat=server />[<CMS:WebConfig Name="web_host" runat=server />] - ROYcms stage door </title>
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
</head>
<frameset name="full" rows="71,*,55" cols="*" framespacing="0" frameborder="0" border="0">
  <frame src="_top.aspx" name="topFrame" frameborder="0" scrolling="NO" noresize marginwidth="0" >
  <frameset name="cen" cols="229,*" frameborder="0" border="0" framespacing="0">
    <frame src="_left.aspx" name="leftFrame" frameborder="0" noresize>
    <frame src="_main.aspx" name="main" frameborder="0">
  </frameset>
  <frame src="_foot.aspx" name="footFrame" frameborder="0" scrolling="NO" noresize >
</frameset>
<noframes></noframes>
</html>
