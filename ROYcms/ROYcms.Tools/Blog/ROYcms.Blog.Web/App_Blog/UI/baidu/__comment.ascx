<%@ Control Language="C#" AutoEventWireup="true" Inherits="ROYcms.Blog.Web.App_Blog.__comment" %>


  <TABLE class=modth border=0 cellSpacing=0 cellPadding=0 width="100%">
                  <TBODY>
                    <TR>
                      <TD class=modtl width=7></TD>
                      <TD class=modtc><DIV class=modhead><SPAN class=modtit>最新评论</SPAN></DIV></TD>
                      <TD class=modtc noWrap align=right><DIV class=modopt></DIV></TD>
                      <TD class=modtr width=7></TD>
                    </TR>
                  </TBODY>
                </TABLE>
                <DIV id=m_mylink4 class=modbox>
                
                
                <asp:Repeater ID="Repeater_list" runat="server">
    <ItemTemplate>
    
    
    <DIV class=item>
    <SPAN id=linkArea>
    <a href="/blog-<%=this.User_id %>/blog/<%#Eval("blog_id") %>.html"><%#Eval("title") %></a>
    <a><%#___GetUserDate("{name}", Eval("user_id").ToString())%></a>
                    </SPAN></DIV>
                  <DIV class=line></DIV>
    </ItemTemplate>
</asp:Repeater>
                  
                </DIV>
                <TABLE border=0 cellSpacing=0 cellPadding=0 width="100%" height=8>
                  <TBODY>
                    <TR>
                      <TD class=modbl width=7></TD>
                      <TD class=modbc></TD>
                      <TD class=modbr width=7></TD>
                    </TR>
                  </TBODY>
                </TABLE>