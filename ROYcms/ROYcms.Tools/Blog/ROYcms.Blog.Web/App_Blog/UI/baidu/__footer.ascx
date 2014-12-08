<%@ Control Language="C#" AutoEventWireup="true" Inherits="ROYcms.Blog.Web.App_Blog.__footer" %>
<span>
<%=___GetBlogValue(this.User_id,"BlogTitle")%> 
<%=___GetUserDate("{name}",this.User_id) %> 
URL:/blog-<%=this.User_id %>/default.html
</span>