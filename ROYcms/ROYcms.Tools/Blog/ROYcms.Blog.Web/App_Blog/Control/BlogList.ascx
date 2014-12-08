<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BlogList.ascx.cs" Inherits="ROYcms.Blog.Web.App_Blog.Control.BlogList" %>
<ul id="NewList">
    <asp:Repeater ID="Repeater_list" runat="server">
    <ItemTemplate>
    <li>
	<span class="Title"><a href="/blog-<%#Eval("user_id") %>/default.html"><%#Eval("BlogTitle") %></a></span>
	<span class="description">摘要:<%#Eval("Description") %></span>
	<span class="clear"></span>
    </li>
    </ItemTemplate>
    </asp:Repeater>
</ul>