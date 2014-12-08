<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="__Ucenter.ascx.cs" Inherits="ROYcms.Blog.Web.App_Blog.__Ucenter" %>
 <span class="User">
 <%if (___GetUserDate("{pic}", this.User_id) == "")
   { %>
   <img src="/UCenter/images/nophoto.gif" />
 <%}
   else
   { %>
   <img src='<%=___GetUserDate("{pic}", this.User_id) %>' />
 <%} %>

 <span class=username><a><%=___GetUserDate("{name}",this.User_id) %></a></span>
 <span class=useremail><%=___GetUserDate("{email}",this.User_id) %></span>
 </span>