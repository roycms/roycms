<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="__CommentList.ascx.cs" Inherits="ROYcms.Blog.Web.App_Blog.__CommentList1" %>
<h3>评论</h3>
<asp:Repeater ID="Repeater_list" runat="server">
    <ItemTemplate>
    <a><%# ___GetUserDate("{name}", Eval("user_id").ToString())%></a>
	<span class="Title"><a href="/blog-<%=this.User_id %>/blog/<%#Eval("blog_id") %>.html"><%#Eval("title") %></a></span>
	<span class="Content"><%#Eval("content") %></span>
	<span class="time"><%#Eval("Time") %></span>
    
	<span class="clear"></span>
    </ItemTemplate>
</asp:Repeater>