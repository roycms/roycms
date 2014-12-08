<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="__Tag.ascx.cs" Inherits="ROYcms.Blog.Web.App_Blog.__Tag" %>
<%string[] Tag = ___GetBlogValue(this.User_id,"Class").Split('|');%>
<h3>博客分类[标签云]</h3>
<ul>
<%for(int i=0;i<Tag.Length;++i){ %>
<li><a href='/blog-<%=this.User_id %>/default.html?Tag=<%=Tag[i]%>'><%=Tag[i]%></a></li>
<%} %>
</ul>