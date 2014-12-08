<%@ Control Language="C#" AutoEventWireup="true" Inherits="ROYcms.Blog.Web.App_Blog.__Ucenter" %>
 
 
             <TABLE class=modth border=0 cellSpacing=0 cellPadding=0 width="100%">
                  <TBODY>
                    <TR>
                      <TD class=modtl width=7></TD>
                      <TD class=modtc noWrap><DIV class=modhead><SPAN class=modtit>个人档案</SPAN></DIV></TD>
                      <TD class=modtc noWrap align=right><DIV class=modopt></DIV></TD>
                      <TD class=modtr width=7></TD>
                    </TR>
                  </TBODY>
                </TABLE>
                <DIV id=m_pro class=modbox>
                  <DIV class=wrapper>
                    <DIV class=portrait>
                     <%if (___GetUserDate("{pic}", this.User_id) == "")
   { %>
   <img src="/UCenter/images/nophoto.gif" />
 <%}
   else
   { %>
   <img src='<%=___GetUserDate("{pic}", this.User_id) %>' />
 <%} %></DIV>
                    <DIV class="userinfo clearfix"><NOBR><B><%=___GetUserDate("{name}",this.User_id) %></B></NOBR><BR>
                      <NOBR><%=___GetUserDate("{email}",this.User_id) %></NOBR><BR>
                    </DIV>
                  </DIV>
                  <DIV style="LINE-HEIGHT: 5px; MARGIN-TOP: 5px" class=line></DIV>
                  <DIV id=hostFollowerNum></DIV>
                  <DIV style="MARGIN-TOP: 0px" class=act>
                    <A >查看资料</A>
                  </DIV>
                  <!-- end act-->
                </DIV>
                <!-- end m_pro -->
                <TABLE border=0 cellSpacing=0 cellPadding=0 width="100%" height=8>
                  <TBODY>
                    <TR>
                      <TD class=modbl width=7></TD>
                      <TD class=modbc></TD>
                      <TD class=modbr width=7></TD>
                    </TR>
                  </TBODY>
                </TABLE>