<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AskList.aspx.cs" Inherits="ROYcms.Ask.Web.AskList" %>
<%@ Register src="/app_ask/Top.ascx" tagname="Top" tagprefix="uc1" %>
<%@ Register src="/app_ask/Footer.ascx" tagname="Footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>所有问题 - <%=___GetConfigValue("Title")%></title>
<meta name="Keywords" content='<%=___GetConfigValue("Keyword")%>' />
<meta name="Description" content='<%=___GetConfigValue("Description")%>' />
<link href="/app_ask/css/ROYcmsAsk.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
  <uc1:Top ID="Top1" runat="server" />
  <div id="wrap">
    <div class="box">
      <div>
        <div id="question_list">
          <div class="neirong">
            <div class="question_title2">
              <div class="question_time"><img src="/app_ask/images/column_time_grey.gif" width="16" height="16" /></div>
              <div class="huida_num"><img src="/app_ask/images/column_reply_grey.gif" width="16" height="16" /></div>
              <div class="xuanshang"><img src="/app_ask/images/column_point_grey.gif" width="16" height="16" /></div>
              <div class="question_name">问题 [ 标签 ] </div>
            </div>
            <ul>
              <asp:Repeater ID="Repeater_list" runat="server">
                <ItemTemplate>
                  <li>
                    <div class="question_time">
                    <%#ROYcms.Common.TimeParser.TimeNonce( Eval("star_time").ToString()) %>
                    </div>
                    <div class="huida_num">&nbsp;3</div>
                    <div class="xuanshang">&nbsp;5</div>
                    <div class="question_name">
                      <img src="/app_ask/images/topic_open.gif" width="14" height="14" />
                      <a href="ask-<%#Eval("bh") %>.html"><%#Eval("title") %></a>
                      <span class="tag"><%#Eval("tag") %></span>
                      <span class="ip">Ip: <%#Eval("ip") %></span>
                      <span class="huida">
                      <a rel=facebox href='/app_ask/Answer.aspx?question_id=<%#Eval("bh") %>'> 回答</a>
                      </span>
                      <%if(ROYcms.Common.Session.Get("administrator")!=null){ %>
                      <a rel=facebox href='#del<%#Eval("bh") %>' > 删除 </a>
                      <%} else{%>
                      <%#Eval("user_id").ToString() == ROYcms.Common.Session.Get("user_id") ? "<a rel=facebox href='#del" + Eval("bh") + "' > 删除 </a>" : ""%>
                      <%} %>
                      <div id="del<%#Eval("bh") %>" style=" display:none;">
                        <h3>确实要删除吗？</h3>
                        <p>
                          <a href='?del=<%#Eval("bh") %>'>删除</a>
                        </p>
                      </div>
                    </div>
                  </li>
                </ItemTemplate>
              </asp:Repeater>
            </ul>
          </div>
        </div>
      </div>
    </div>
  </div>
  <uc2:Footer ID="Footer1" runat="server" />
</form>
</body>
</html>
