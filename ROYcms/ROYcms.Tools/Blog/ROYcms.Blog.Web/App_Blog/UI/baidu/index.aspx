<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.Blog.Web.App_Blog.index" %>
<%@ Register src="~/app_blog/inc.ascx" tagname="__inc" tagprefix="Inc" %>
<%@ Register src="~/app_blog/end.ascx" tagname="__end" tagprefix="End" %>
<%@ Register src="__Css.ascx" tagname="__Css" tagprefix="Css" %>
<%@ Register src="__Top.ascx" tagname="__Top" tagprefix="Top" %>
<%@ Register src="__Ucenter.ascx" tagname="__Ucenter" tagprefix="Ucenter" %>
<%@ Register src="__calendar.ascx" tagname="__calendar" tagprefix="calendar" %>
<%@ Register src="__flash.ascx" tagname="__flash" tagprefix="flash" %>
<%@ Register src="__search.ascx" tagname="__search" tagprefix="search" %>
<%@ Register src="__pagelink.ascx" tagname="__pagelink" tagprefix="pagelink" %>
<%@ Register src="__Tag.ascx" tagname="__Tag" tagprefix="Tag" %>
<%@ Register src="__comment.ascx" tagname="__comment" tagprefix="comment" %>
<%@ Register src="__header.ascx" tagname="__header" tagprefix="header" %>
<%@ Register src="__footer.ascx" tagname="__footer" tagprefix="footer" %>
<html>
<head runat="server">
    <title><%=___GetBlogValue(this.User_id,"BlogTitle")%></title>
    <meta name="Keywords" content=<%=___GetBlogValue(this.User_id,"KeyWord")%> />
    <meta name="Description" content=<%=___GetBlogValue(this.User_id,"Description")%> />
    <inc:__inc ID="__inc1" runat="server" />
    <Css:__Css ID="__Css1" runat="server" />
</head>
<body>
    <form id="Myform" runat="server" action="/App_Blog/Post.aspx" target="_blank">
    <%if (___GetBlogValue(this.User_id, "BlogTitle") == "")
      { %>
      用户未开通博客请点击开通 <a href="/app_blog/admin/config.aspx?user_id=<%=this.User_id%>" target=_blank>现在开通</a>
    <%}
      else
      { %>
    <%=___GetBlogValue(this.User_id, "TopHtml")%>
    <CENTER>




    <DIV id=usrbar>
    <Top:__Top ID="__Top1" runat="server" />
    </div>
    
    <div  id=main align=left>

<!--[if IE]>
<SCRIPT>
var objmain = document.getElementById("main");
function updatesize(){ var bodyw = window.document.body.offsetWidth; if(bodyw <= 790) objmain.style.width="772px"; else if(bodyw >= 1016) objmain.style.width="996px"; else objmain.style.width="100%"; }
updatesize(); window.onresize = updatesize;
</SCRIPT>
<![endif]-->

  <!--头部开始-->
  <div id="header">
    <header:__header ID="__header1" runat="server" />
  </div>
  <!--导航结束-->
  <!--头部结束-->
  <!--主体开始-->
  <div  class=stage>
  <TABLE id=layout border=0 cellSpacing=0 cellPadding=0 width="100%">
        <TBODY>
          <TR>
            <TD class=c2t1 vAlign=top><DIV id=mod_rss class=mod rel="drag">
                <TABLE class=modth border=0 cellSpacing=0 cellPadding=0 width="100%">
                  <TBODY>
                    <TR>
                      <TD class=modtl width=7></TD>
                      <TD class=modtc><DIV class=modhead><SPAN class=modtit><%=___GetBlogValue(this.User_id, "SubBlogTitle")%></SPAN></DIV></TD>
                      <TD class=modtc noWrap align=right><DIV class=modopt></DIV></TD>
                      <TD class=modtr width=7></TD>
                    </TR>
                  </TBODY>
                </TABLE>
                <DIV id=m_rss class=modbox></DIV>
                <TABLE border=0 cellSpacing=0 cellPadding=0 width="100%" height=8>
                  <TBODY>
                    <TR>
                      <TD class=modbl width=7></TD>
                      <TD class=modbc></TD>
                      <TD class=modbr width=7></TD>
                    </TR>
                  </TBODY>
                </TABLE>
              </DIV>
              <DIV id=mod_bloglist class=mod rel="drag">
                <TABLE class=modth border=0 cellSpacing=0 cellPadding=0 width="100%">
                  <TBODY>
                    <TR>
                      <TD class=modtl width=7></TD>
                      <TD class=modtc noWrap><DIV class=modhead><SPAN class=modtit>博客文章列表</SPAN></DIV></TD>
                      <TD class=modtc noWrap align=right><DIV class=modopt></DIV></TD>
                      <TD class=modtr width=7></TD>
                    </TR>
                  </TBODY>
                </TABLE>
                <DIV style="OVERFLOW-X: hidden;" id=m_blog class=modbox>
                
                <asp:Repeater ID="Repeater_list" runat="server">
    <ItemTemplate>
    
     <DIV class=tit>
                    <a href="blog/<%#Eval("id") %>.html"><%#Eval("Title") %></a>
                  </DIV>
                  <DIV class=date>[<%#ROYcms.Common.TimeParser.TimeNonce( Eval("Time").ToString()) %>前]<%#Eval("Time") %> </DIV>
                  <DIV class=opt>
                    <a href="#del<%#Eval("id") %>" >删除</a>
                     |
                    <a href="/app_blog/admin/EditPost.aspx?edit=<%#Eval("id") %>&user_id=<%=this.User_id%>" target="_blank">编辑</a>
                    <SPAN id=dArea></SPAN> |
                    <a><%# Eval("user_id").ToString() == "" ? "匿名用户" : ___GetUserDate("{name}", Eval("user_id").ToString())%></a>
                    |
                    <a href="blog/<%#Eval("id") %>.html">浏览(<SPAN id=fArea></SPAN> )</a>
                  </DIV>
                  <DIV class=line></DIV>
    </ItemTemplate>
    </asp:Repeater>
                
                 
                  <DIV class=tit>
                    <A class=titlink >更多文章&gt;&gt;</A>
                  </DIV>
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
              </DIV></TD>
            <TD class=c2t2></TD>
            <TD class=c2t3 vAlign=top>
            <DIV id=mod_profile class=mod rel="drag">
    <Ucenter:__Ucenter ID="__Ucenter2" runat="server" />
              </DIV>
              <!-- end mod_profile -->
              <DIV id=mod_artclg class=mod rel="drag">
               <Tag:__Tag ID="__Tag1" runat="server" />
              </DIV>
              <DIV id=mod_mylink4 class=mod rel="drag">
              <comment:__comment ID="__comment1" runat="server" />
              </DIV>
              <DIV id=mod_mylink1 class=mod rel="drag">
                <TABLE class=modth border=0 cellSpacing=0 cellPadding=0 width="100%">
                  <TBODY>
                    <TR>
                      <TD class=modtl width=7></TD>
                      <TD class=modtc><DIV class=modhead><SPAN class=modtit>文章说明</SPAN></DIV></TD>
                      <TD class=modtc noWrap align=right><DIV class=modopt></DIV></TD>
                      <TD class=modtr width=7></TD>
                    </TR>
                  </TBODY>
                </TABLE>
                <DIV id=m_mylink1 class=modbox>
                  <DIV class=item><SPAN id=linkArea>
                    </SPAN></DIV>
                  <DIV class=line></DIV>
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
              </DIV>
              <DIV id=mod_links class=mod rel="drag">
                <TABLE class=modth border=0 cellSpacing=0 cellPadding=0 width="100%">
                  <TBODY>
                    <TR>
                      <TD class=modtl width=7></TD>
                      <TD class=modtc noWrap><DIV class=modhead><SPAN class=modtit>友情链接</SPAN></DIV></TD>
                      <TD class=modtc noWrap align=right><DIV class=modopt></DIV></TD>
                      <TD class=modtr width=7></TD>
                    </TR>
                  </TBODY>
                </TABLE>
                <DIV id=m_links class=modbox>
                  <DIV class=item><SPAN style="MARGIN-LEFT: 18px"></SPAN><SPAN id=linkArea>
                    </SPAN></DIV>
                  <DIV class=line></DIV>
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
              </DIV>
              <DIV id=mod_mylink2 class=mod rel="drag">
                <TABLE class=modth border=0 cellSpacing=0 cellPadding=0 width="100%">
                  <TBODY>
                    <TR>
                      <TD class=modtl width=7></TD>
                      <TD class=modtc><DIV class=modhead><SPAN class=modtit>推荐网站</SPAN></DIV></TD>
                      <TD class=modtc noWrap align=right><DIV class=modopt></DIV></TD>
                      <TD class=modtr width=7></TD>
                    </TR>
                  </TBODY>
                </TABLE>
                <DIV id=m_mylink2 class=modbox>
                  <DIV class=item><SPAN id=linkArea> qwerweretretretre </SPAN></DIV>
                  <DIV class=line></DIV>
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
              </DIV>
              <DIV id=mod_search class=mod rel="drag">
           <search:__search ID="__search1" runat="server" />
              </DIV></TD>
          </TR>
        </TBODY>
      </TABLE>
  </div>
  
</div>
 <BR>
  <BR>
  <CENTER>
    <DIV id=ft> <footer:__footer ID="__footer1" runat="server" /></DIV>
  </CENTER>
  </CENTER>
    <%=___GetBlogValue(this.User_id, "EndHtml")%>
    <%} %>
    </form>
    <end:__end ID="__end1" runat="server" />
</body>
</html>
