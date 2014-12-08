<%@ Control Language="C#" AutoEventWireup="true"  Inherits="ROYcms.Blog.Web.App_Blog.__Tag" %>
<%string[] Tag = ___GetBlogValue(this.User_id,"Class").Split('|');%>

 <TABLE class=modth border=0 cellSpacing=0 cellPadding=0 width="100%">
                  <TBODY>
                    <TR>
                      <TD class=modtl width=7></TD>
                      <TD class=modtc noWrap><DIV class=modhead><SPAN class=modtit>博客分类[标签云]</SPAN></DIV></TD>
                      <TD class=modtc noWrap align=right><DIV class=modopt></DIV></TD>
                      <TD class=modtr width=7></TD>
                    </TR>
                  </TBODY>
                </TABLE>
                <DIV id=m_artclg class=modbox>
                <%for(int i=0;i<Tag.Length;++i){ %>
 <DIV class=item>
                    <a href='/blog-<%=this.User_id %>/default.html?Tag=<%=Tag[i]%>'><%=Tag[i]%></a>
                    </DIV>
                  <DIV class=line></DIV>
<%} %>
                 
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