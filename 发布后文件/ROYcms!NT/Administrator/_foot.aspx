<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="_foot.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator__foot" %>
<HTML>
<HEAD>
<TITLE></TITLE>
<META content="text/html; charset=utf-8" http-equiv=Content-Type>
<LINK rel=stylesheet type=text/css href="/administrator/css/style.css">
</HEAD>
<BODY>
<SCRIPT language=JavaScript src="js/alt.js"></SCRIPT>
<TABLE border=0 cellSpacing=0 cellPadding=0 width="100%" height=55>
  <TBODY>
    <TR>
      <TD vAlign=top background=images/admin-foot1.gif width=230 align=middle>&nbsp;</TD>
      <TD background=images/admin-top2.gif width=15>
      <IMG  src="/administrator/images/admin-foot2.gif" width=15 height=55></TD>
      <TD class=enfont2 background=images/admin-foot4.gif>
      <FONT class=enfont>Powered by：</FONT>
      <FONT class=enfont color=#ff4800>ROYcms!NT</FONT>
       <FONT class=enfont color=#3d9100>ver<CMS:WebConfig Name="version" runat=server /> </FONT>
       &nbsp;&nbsp;机构：<CMS:WebConfig Name="web_name" runat=server /> 
       <FONT  class=enfont>
       &nbsp;URL：<A target=_blank  href='<CMS:WebConfig Name="web_host" runat=server />'><CMS:WebConfig Name="web_host" runat=server /></A>
       </FONT></TD>
      <TD background=images/admin-top2.gif width=19>
      <IMG src="/administrator/images/admin-foot3.gif" width=19 height=55></TD>
    </TR>
  </TBODY>
</TABLE>
</BODY>
</HTML>