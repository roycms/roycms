<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Top.ascx.cs" Inherits="ROYcms.Ask.Web.Top1" %>
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.2.6/jquery.min.js" type="text/javascript"></script>
<link href="/administrator/webui/facebox/facebox.css" media="screen" rel="stylesheet" type="text/css"/>
<script src="/administrator/webui/facebox/facebox.js" type="text/javascript"></script>
<SCRIPT type=text/javascript>
    jQuery(document).ready(function($) {
      $('a[rel*=facebox]').facebox({
      loading_image: '/administrator/webui/facebox/loading.gif',
      close_image: '/administrator/webui/facebox/closelabel.gif'
      }) 
    })
  </SCRIPT>
<div id="topnav">
  <span id="UCLoginBar">
  <%if (ROYcms.Common.Session.Get("user_id") != null)
    { %>
  <a>欢迎 <%= ROYcms.Common.Session.Get("user")%> </a>
  <a href=/ucenter/PeopleDate.aspx >个人信息</a>
  <a href=/ucenter/logout.aspx?url=ask/default.html >注销</a>
  <%}
    else
    { %>
  <a href="/ucenter/login.aspx?url=ask/default.html">登录</a>
  <a href="/ucenter/Reg.aspx?url=ask/default.html">注册</a>
  <%} %>
  </span>
  <%=___GetConfigValue("Menu")%>
</div>
<div id="Header">
  <div id="logo">
    <a href="/ask/default.html"><img src='<%=___GetConfigValue("Logo")%>' /></a>
  </div>
  <div id="SearchKuang">
  <form action=index.aspx>
    <input class="SearchBDtext" name="" type="text" class="" />
    <input type="submit" name="button" id="button" value="搜索答案" />
    <span class="font_s12">
    <a href="/ask/addask.html">我要提问</a>
    </span></form>
    </div>
</div>
<div id="CurrentLocation">
  <a href="/ask/default.html">首页</a>
  &gt;
  <a href="/ask/asklist.html">问题列表</a>
  &gt;
  <a href="?">详细问题</a>
</div>
