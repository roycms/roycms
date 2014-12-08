<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCHeader.ascx.cs" Inherits="ROYcms.UI.Admin.UCenter.UCHeader" %>
<!--UCmainNav begin-->

<div id="UCmainNav">
   <span id="UCLoginBar">
  <%if (ROYcms.Common.Session.Get("user_id") != null)
    { %>
  <a href=/ucenter/PeopleDate.aspx >欢迎 <b><%= ROYcms.Common.Session.Get("user")%></b> </a>
  <a href=/ucenter/logout.aspx >注销</a>
  <%}
    else
    {
        Response.Redirect("/ucenter/login.aspx");
    }%>
 
  </span>
  <span id="nav">
  <a href="/ucenter/default.aspx">首页</a>
  <a href="/ucenter/default.aspx">工作台</a>
  <a href="/ucenter/PeopleDate.aspx">账户设置</a>
  <a href="/ucenter/Recharge.aspx">充值</a>
  </span>
</div>
<!--UCmainNav end-->
<!--UCHeader begin-->
<div id="UCHeader">
  <div id="UChotNews">
   <!-- <A href="http://www.roycms.cn/" target=_blank>看IT新闻，上圈子新闻频道</A>
    <br />
    <A href="http://www.roycms.cn" target=_blank>.net招聘信息</A>
    <A href="http://www.roycms.cn" target=_blank>程序员招聘</A>-->
  </div>
  <div id="UClogo">
    <a href="/ucenter/default.aspx">
    <img src='<CMS:WebConfig Config="Ucenter.config"  Name="ucenter_logo" runat=server  />' border="0" />
    </a>
  </div>
  <div id="UCbanner"><!--<img src="uploadpic/UCbanner.gif" width="468" height="60" />--></div>
</div>
<div class="UCHeaderbottom_1"></div>
<div class="UCHeaderbottom_2"></div>
<div class="UCHeaderbottom_3"></div>
<!--UCHeader end-->
