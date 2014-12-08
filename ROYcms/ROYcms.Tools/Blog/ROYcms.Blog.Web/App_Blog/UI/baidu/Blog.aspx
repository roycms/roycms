<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.Blog.Web.App_Blog.Blog" EnableViewStateMac="false" %>
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
<%@ Register src="__CommentList.ascx" tagname="__CommentList" tagprefix="CommentList" %>
<%@ Register src="__Related.ascx" tagname="__Related" tagprefix="Related" %>
<%@ Register src="__header.ascx" tagname="__header" tagprefix="header" %>
<%@ Register src="__footer.ascx" tagname="__footer" tagprefix="footer" %>
<%@ Register src="__PostComment.ascx" tagname="__PostComment" tagprefix="PostComment" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title><%=Show("{title}")%>-<%=___GetBlogValue(this.User_id,"BlogTitle")%></title>
<meta name="Keywords" content=<%=Show("{keyword}")%> />
<meta name="Description" content=<%=Show("{description}")%> />
<inc:__inc ID="__inc1" runat="server" />
<Css:__Css ID="__Css1" runat="server" />
</head>
<body>
<form id="Myform" runat="server" action="/App_Blog/Post.aspx" target="_blank">
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
      <div class="stage">
        <div class="stagepad">
          <div style="width:100%">
            <table width="100%" border="0" cellspacing="0" cellpadding="0" class="modth">
              <tr>
                <td class="modtl" width="7"></td>
                <td class="modtc" nowrap><div class="modhead"><span class="modtit">查看文章</span></div></td>
                <td class="modtc" nowrap align="right"><div class="modopt">
                    <a href="/app_blog/admin/EditPost.aspx" target="_blank" class="modact">写新文章</a>
                  </div></td>
                <td class="modtr" width="7"></td>
              </tr>
            </table>
            <div id="m_blog" class="modbox" style="overflow-x:hidden;">
              <div class="tit"><%=Show("{title}")%></div>
              <div class="date"> <%=Show("{time}")%></div>
              <table style="table-layout:fixed;width:100%">
                <tr>
                  <td><div id="blog_text" class="cnt"  >
                      <%=Show("{content}")%>
                    </div></td>
                </tr>
              </table>
              <br>
              <div class="opt"> posted @
                <% =___GetUserDate("{email}",Show("{user_id}"))%>
                <a>
                <% =___GetUserDate("{name}",Show("{user_id}"))%>
                </a>
                阅读(180) |
                <a href="#FeedBack">评论 (2)</a>
                |
                <a href="/app_blog/admin/EditPost.aspx?edit=<%=Request["id"] %>&user_id=<%=this.User_id%>" target="_blank">编辑</a>
              </div>
              <div class="line">&nbsp;</div>
              <style type="text/css">

/*<![CDATA[*/

#in_related_doc a { text-decoration:none; }

/*]]>*/

</style>
              <div id="in_related_tmp"></div>
              <div id="in_related_doc">
                <div class="tit">相关文章：</div>
                 <Related:__Related ID="__Related1" runat="server" />
              </div>
              <div class="line">&nbsp;</div>
              <div id="in_comment">
                <a name="send"></a>
                <div class="tit">发表评论：</div>
                <CommentList:__CommentList ID="__CommentList2" runat="server" />
                <div id="page"></div>
              </div>
              <div id="in_send">
                <a name="FeedBack" id="FeedBack"></a>
                <PostComment:__PostComment ID="__PostComment1" runat="server" />
              </div>
              <br>
            </div>
            <table width="100%" border="0" cellspacing="0" cellpadding="0" height="8">
              <tr>
                <td class="modbl" width="7"></td>
                <td class="modbc"></td>
                <td class="modbr" width="7"></td>
              </tr>
            </table>
          </div>
        </div>
      </div>
    </div>
    <BR>
    <BR>
    <CENTER>
      <DIV id=ft>
        <footer:__footer ID="__footer1" runat="server" />
      </DIV>
    </CENTER>
  </CENTER>
  <%=___GetBlogValue(this.User_id, "EndHtml")%>
</form>
<end:__end ID="__end1" runat="server" />
</body>
</html>
