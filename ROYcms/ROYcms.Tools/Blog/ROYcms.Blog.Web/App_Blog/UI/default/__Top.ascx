<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="__Top.ascx.cs" Inherits="ROYcms.Blog.Web.__Top" %>
 <span class="UCLoginBar">
  <%if (ROYcms.Common.Session.Get("user_id") != null)
    { %>
  <a>欢迎 <%= ROYcms.Common.Session.Get("user")%> </a>
  <a href=/ucenter/PeopleDate.aspx >个人信息</a>
  <a href="/ucenter/logout.aspx?url=blog-<%=ROYcms.Common.Session.Get("user_id") %>/default.html" >注销</a>
  <%}
    else
    { %>
  <a href="/ucenter/login.aspx?url=blog-<%=Request["user_id"] %>/default.html">登录</a>
  <a href="/ucenter/Reg.aspx?url=blog-<%=Request["user_id"] %>/default.html">注册</a>
  <%} %>
  </span>