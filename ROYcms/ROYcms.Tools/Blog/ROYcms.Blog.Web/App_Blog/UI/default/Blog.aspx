<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="ROYcms.Blog.Web.App_Blog.Blog" EnableViewStateMac="false" %>
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
<%@ Register src="__header.ascx" tagname="__header" tagprefix="header" %>
<%@ Register src="__footer.ascx" tagname="__footer" tagprefix="footer" %>
<%@ Register src="__PostComment.ascx" tagname="__PostComment" tagprefix="PostComment" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title><%=Show("{title}")%> - <%=___GetBlogValue(this.User_id,"BlogTitle")%></title>
    <meta name="Keywords" content=<%=Show("{keyword}")%> />
    <meta name="Description" content=<%=Show("{description}")%> />
    <inc:__inc ID="__inc1" runat="server" />
    <Css:__Css ID="__Css1" runat="server" />
</head>
<body>
    <form id="Myform" runat="server" action="/App_Blog/Post.aspx" target="_blank">
    <%=___GetBlogValue(this.User_id,"TopHtml")%>
        <div id="Top">
    <Top:__Top ID="__Top1" runat="server" />
    </div>
    <div id="home">
  <!--头部开始-->
  <div id="header">
    <header:__header ID="__header1" runat="server" />
  </div>
  <!--导航结束-->
  <!--头部结束-->
  <!--主体开始-->
  <div id="main">
    <!--左侧-->
    <DIV id="LeftContent">
            <!--用户资料-->
      <div class="Ucenter">
      <Ucenter:__Ucenter ID="__Ucenter2" runat="server" />
      </div>
      <!--日历控件-->
      <div class="calendar"><calendar:__calendar ID="__calendar1" runat="server" />
          </div>
      <!--闪存-->
      <div class="flash"><flash:__flash ID="__flash1" runat="server" />
          </div>
      <!--搜索-->
      <div class="search"><search:__search ID="__search1" runat="server" />
          </div>
      <!--常用链接-->
      <div class="pagelink"><pagelink:__pagelink ID="__pagelink1" runat="server" />
          </div>
      <!--标签-->
      <div class="Tag"><Tag:__Tag ID="__Tag1" runat="server" />
          </div>
      <!--评论-->
      <div class="comment"><comment:__comment ID="__comment1" runat="server" />
          </div>
    </DIV>
    <!--左侧结束-->
    <!--右侧-->
    <DIV id="RightContent">
	<h2 class="Title">
	<%=Show("{title}")%>
	</h2>
	<span class="dayTitle"><%=Show("{time}")%></span>
	<div class="description">摘要:<%=Show("{description}")%></div>
	<div id="con"><%=Show("{content}")%></div>
    <div class="postDesc">posted @ <% =___GetUserDate("{email}",Show("{user_id}"))%> 
    <a>
     <% =___GetUserDate("{name}",Show("{user_id}"))%>
     </a>
     阅读(180) | <a href="#FeedBack">评论 (2)</a> | <a href="/app_blog/admin/EditPost.aspx?edit=<%=Request["id"] %>&user_id=<%=this.User_id%>">编辑</a></div>
     
     <div id="NextPage"></div>
     <div id="CommentList">
     <CommentList:__CommentList ID="__CommentList2" runat="server" />
     </div>
     <div id="PostComment">
     <PostComment:__PostComment ID="__PostComment1" runat="server" />
     </div>
     
    </DIV>
    <!--右侧结束-->
  </div>
  <!--主体结束-->
  <!--底部开始-->
  <div id="footer">
  <footer:__footer ID="__footer1" runat="server" />
  </div>
  <!--底部结束-->
</div>
    
    <%=___GetBlogValue(this.User_id,"EndHtml")%>
    </form>
    <end:__end ID="__end1" runat="server" />
</body>
</html>

