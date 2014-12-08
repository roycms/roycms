<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="__header.ascx.cs" Inherits="ROYcms.Blog.Web.App_Blog.__header" %>
 <!--标题开始-->
    <div id="blogTitle">
      <h1>
        <a href="/Blog-<%=this.User_id%>/default.html"><%=___GetBlogValue(this.User_id,"BlogTitle")%></a>
      </h1>
      <h2><%=___GetBlogValue(this.User_id, "SubBlogTitle")%></h2>
    </div>
    <!--标题结束-->
    <!--导航开始-->
    <div id="navigator">
      <ul id="navList">
        <li>
          <a href="/index.html">网站首页</a>
        </li>
        <li>
          <a href="/Blog-<%=this.User_id%>/default.html">博客首页</a>
        </li>
        <li>
          <a href="/app_blog/admin/EditPost.aspx" target=_blank>新建博文</a>
        </li>
         <li>
          <a href="/app_blog/admin/config.aspx" target=_blank>管理博客</a>
        </li>
         <li>
          <a href="/App_Blog/rss.aspx?user_id=<%=this.User_id%>" target=_blank>订阅博文</a>
        </li>
      </ul>
    </div>