<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ROYcms.Blog.Web.App_Blog.index" %>
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
<%@ Register src="__Related.ascx" tagname="__Related" tagprefix="Related" %>
<%@ Register src="__header.ascx" tagname="__header" tagprefix="header" %>
<%@ Register src="__footer.ascx" tagname="__footer" tagprefix="footer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
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
      <div class="calendar">
      <calendar:__calendar ID="__calendar1" runat="server" />
          </div>
      <!--闪存-->
      <div class="flash">
      <flash:__flash ID="__flash1" runat="server" />
          </div>
      <!--搜索-->
      <div class="search">
      <search:__search ID="__search1" runat="server" />
          </div>
      <!--常用链接-->
      <div class="pagelink">
      <pagelink:__pagelink ID="__pagelink1" runat="server" />
          </div>
      <!--标签-->
      <div class="Tag">
      <Tag:__Tag ID="__Tag1" runat="server" />
          </div>
      <!--评论-->
      <div class="comment">
      <comment:__comment ID="__comment1" runat="server" />
          </div>
    </DIV>
    <!--左侧结束-->
    <!--右侧-->
    <DIV id="RightContent">
<ul id="NewList">
    <asp:Repeater ID="Repeater_list" runat="server">
    <ItemTemplate>
    <li>
	<span class="dayTitle"><%#Eval("Time") %></span>
	<span class="Title"><a href="blog/<%#Eval("id") %>.html"><%#Eval("Title") %></a></span>
	<span class="description">摘要:<%#Eval("Description") %><a href="blog/<%#Eval("id") %>.html">阅读全文</a></span>
    <span class="postDesc">posted @ <%#Eval("Time") %>  [<%#ROYcms.Common.TimeParser.TimeNonce( Eval("Time").ToString()) %>前]
    <a><%# Eval("user_id").ToString() == "" ? "匿名用户" : ___GetUserDate("{name}", Eval("user_id").ToString())%></a>
     阅读() | <a href="#FeedBack">评论 ()</a></span>
	<span class="clear"></span>
    </li>
    </ItemTemplate>
    </asp:Repeater>
</ul>
    </DIV>
    <div id="RelatedList">
    <Related:__Related ID="__Related1" runat="server" />
    </div>
    <!--右侧结束-->
  </div>
  <!--主体结束-->
  <!--底部开始-->
  <div id="footer">
  <footer:__footer ID="__footer1" runat="server" />
  </div>
  <!--底部结束-->
</div>
    <%=___GetBlogValue(this.User_id, "EndHtml")%>
    <%} %>
    </form>
    <end:__end ID="__end1" runat="server" />
</body>
</html>
