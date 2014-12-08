<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ask.aspx.cs" Inherits="ROYcms.Ask.Web.Ask" %>
<%@ Register src="/app_ask/Top.ascx" tagname="Top" tagprefix="uc1" %>
<%@ Register src="/app_ask/Footer.ascx" tagname="Footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>问题 - <%=___GetConfigValue("Title")%></title>
<meta name="Keywords" content='<%=___GetConfigValue("Keyword")%>' />
<meta name="Description" content='<%=___GetConfigValue("Description")%>' />
<link href="/app_ask/css/ROYcmsAsk.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
  <uc1:Top ID="Top1" runat="server" />
  <div id="wrap">
    <div class="box">
      <h1 style="font-size:20px;">
        <asp:Literal ID="title" runat="server"></asp:Literal>
        <span style=" font-size:12px; font-weight:100; color:#008400;"> [游戏 电脑游戏]</span>
      </h1>
      <span>1个回答 63次浏览 </span>
      <div class="content">
        <div class="content_left">
          <div class="content_box"> 0</div>
          <div class="shang_xia">
            <div class="shang_xia_a">
              <a href="#"><img src="/app_ask/images/thumbs-down-enable.gif" width="18" height="18" /></a>
            </div>
            <div class="shang_xia_b">
              <a href="#"><img src="/app_ask/images/thumbs-up-enable.gif" width="18" height="18" /></a>
            </div>
          </div>
        </div>
        <div class="content_right">
          <div class="content_title">
          <strong><asp:Literal ID="username" runat="server"></asp:Literal></strong>
          <asp:Literal ID="time" runat="server"></asp:Literal>
          Ip:<asp:Literal ID="ip" runat="server"></asp:Literal>
            <a href="#"> 举报</a>
          </div>
          <p>
            <asp:Literal ID="content" runat="server"></asp:Literal>
          </p>
          <div class="bt">
            <a rel=facebox href="/app_ask/Answer.aspx?question_id=<%=Request["id"] %>">我来回答</a>
          </div>
        </div>
      </div>
    </div>
  </div>
  <div class="huida_list">
    <div class="huida_title">回答</div>
    <asp:Repeater ID="Repeater_list" runat="server">
      <ItemTemplate>
        <div class="content">
          <div class="content_left">
            <div class="content_box"> 0</div>
            <div class="shang_xia">
              <div class="shang_xia_a">
                <a href="#"><img src="/app_ask/images/thumbs-down-enable.gif" width="18" height="18" /></a>
              </div>
              <div class="shang_xia_b">
                <a href="#"><img src="/app_ask/images/thumbs-up-enable.gif" width="18" height="18" /></a>
              </div>
            </div>
          </div>
          <div class="content_right">
            <div class="content_title"><strong>
              <a href="#"><%#Eval("user_id").ToString() =="" ?"游客回答": ___GetUserDate("{name}", Eval("user_id").ToString())%></a>
              </strong>
              <%#Eval("star_time") %> Ip:<%#Eval("ip") %>
              <a href="#"> 举报</a>
              <%if (ROYcms.Common.Session.Get("user_id") != null)
                {%>
              <%#Eval("user_id").ToString() == ROYcms.Common.Session.Get("user_id") ? "<a href='#'> 很好!是最佳答案</a>" : ""%>
              <%} %>
              <%if(ROYcms.Common.Session.Get("administrator")!=null){ %>
              <a rel=facebox href='#del<%#Eval("bh") %>' > 删除 </a>
              <%} else{%>
              <%#Eval("user_id").ToString() == ROYcms.Common.Session.Get("user_id") ? "<a rel=facebox href='#del" + Eval("bh") + "' > 删除 </a>" : ""%>
              <%} %>
              <div id="del<%#Eval("bh") %>" style=" display:none;">
                <h3>确实要删除吗？</h3>
                <p>
                  <a href='ask-<%=Request["id"] %>.html?del=<%#Eval("bh") %>'>删除</a>
                </p>
              </div>
            </div>
            <p>
              <%#Eval("content") %>
            </p>
          </div>
          <div class="line_1"></div>
        </div>
      </ItemTemplate>
    </asp:Repeater>
    <div class="bt" style="margin-left:80px;">
      <a rel=facebox href="/app_ask/Answer.aspx?question_id=<%=Request["id"] %>">我来回答</a>
    </div>
  </div>
  <uc2:Footer ID="Footer1" runat="server" />
</form>
</body>
</html>