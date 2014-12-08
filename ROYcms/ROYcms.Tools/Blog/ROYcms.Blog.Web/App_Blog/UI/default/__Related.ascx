<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="__Related.ascx.cs" Inherits="ROYcms.Blog.Web.App_Blog.__Related" %>
 <table cellpadding="0" cellspacing="3" border="0">
                  <tr>
                  <asp:Repeater ID="Repeater_list" runat="server">
    <ItemTemplate>

                    <td width="15px"><a style="font-size:25px" >&#8226;</a></td>
                    <td><a href="/blog-<%#Eval("user_id") %>/blog/<%#Eval("id") %>.html"><%#Eval("Title") %></a> 
                    
                    <%#ROYcms.Common.TimeParser.TimeNonce( Eval("Time").ToString()) %>前
                    </td>
                <%# Container.ItemIndex+1 == 2 ? "<tr></tr>" : ""%>
                <%# Container.ItemIndex + 1 == 4 ? "<tr></tr>" : ""%>
                <%# Container.ItemIndex + 1 == 6 ? "<tr></tr>" : ""%>
                <%# Container.ItemIndex + 1 == 8 ? "<tr></tr>" : ""%>

    </ItemTemplate>
</asp:Repeater>  
</tr>
                  <tr>
                    <td colspan="4"><a>更多&gt;&gt;</a></td>
                  </tr>
</table>