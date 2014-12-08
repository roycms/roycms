<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="__comment.ascx.cs" Inherits="ROYcms.Blog.Web.App_Blog.__comment" %>
<h3>最新评论</h3>
<ul>
<asp:Repeater ID="Repeater_list" runat="server">
    <ItemTemplate>
    <li class="RightCommentList">
	<span class="Title"><a href="/blog-<%=this.User_id %>/blog/<%#Eval("blog_id") %>.html"><%#Eval("title") %></a></span>
    <a><%#___GetUserDate("{name}", Eval("user_id").ToString())%></a>
    </li>
    </ItemTemplate>
</asp:Repeater>
</ul>