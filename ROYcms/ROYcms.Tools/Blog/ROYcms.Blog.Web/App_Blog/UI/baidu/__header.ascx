<%@ Control Language="C#" AutoEventWireup="true" Inherits="ROYcms.Blog.Web.App_Blog.__header" %>

<DIV class=lc>
  <DIV class=rc></DIV>
</DIV>
<DIV class=tit>
  <a class=titlink href="/Blog-<%=this.User_id%>/default.html"><%=___GetBlogValue(this.User_id,"BlogTitle")%></a>
</DIV>
<DIV class=desc><%=___GetBlogValue(this.User_id, "SubBlogTitle")%></DIV>
<DIV id=tabline></DIV>
<DIV id=tab>
  <!--个人档案页-->
  <!--首页-->
  <a class=on  href="/index.html">网站首页</a>
  <a href="/Blog-<%=this.User_id%>/default.html">博客首页</a>
  <SPAN>|</SPAN>
  <a href="/app_blog/admin/EditPost.aspx" target=_blank>新建博文</a>
  <SPAN>|</SPAN>
  <a href="/app_blog/admin/config.aspx" target=_blank>管理博客</a>
  <SPAN>|</SPAN>
  <a href="/App_Blog/rss.aspx?user_id=<%=this.User_id%>" target=_blank>订阅博文</a>
</DIV>
