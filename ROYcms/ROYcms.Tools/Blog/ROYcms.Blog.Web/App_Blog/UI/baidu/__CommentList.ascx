<%@ Control Language="C#" AutoEventWireup="true" Inherits="ROYcms.Blog.Web.App_Blog.__CommentList1" %>
<asp:Repeater ID="Repeater_list" runat="server">
    <ItemTemplate>


<table width="100%" border="0" cellspacing="0" cellpadding="0" class="item" style="table-layout:fixed;word-wrap:break-word;overflow:hidden;";>
<tr>
<td valign="top" class="index" width="5%">#<%# Container.ItemIndex+1%></td>
<td valign="top" width="10%">
<div class="user" style="overflow:hidden;">
<div id="userphoto">
 <%if (___GetUserDate("{pic}", this.User_id) == "")
   { %>
   <img src="/UCenter/images/nophoto.gif" width="55" height="55" />
 <%}
   else
   { %>
   <img src='<%# ___GetUserDate("{pic}", Eval("user_id").ToString())%>' width="55" height="55" />
 <%} %>

</div>
 <a><%# ___GetUserDate("{name}", Eval("user_id").ToString())%></a>
</div>
</td>
<td class="cnt" style="padding-left:20px;"><span class="date">
<a href="/blog-<%=this.User_id %>/blog/<%#Eval("blog_id") %>.html"><%#Eval("title") %></a> | <%#Eval("Time") %> | <a href="#" >回复</a>

</span>
<div class="desc" style="overflow:hidden;word-break:normal;"  name='cmtcontent'>
	<%#Eval("content") %>
    </div></td></tr>

</table>
    </ItemTemplate>
</asp:Repeater>