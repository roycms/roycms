<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="new.aspx.cs" Inherits="ROYcms.Tools.Tp.Administrator._tp._new" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title><%=title %></title>
<meta name="keywords" content="服务中国-满意度品牌调查" />
<meta name="description" content="服务中国-满意度品牌调查" />
<link href="../css/main.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div class="banner_1 w980"></div>
<div class="banner_2 w980"></div>
<div class="banner_3 w980">
  <div id="mainnav"><a href="../index.html">首页</a> | <a href="../gaikuang.html">大会概况</a> | <a href="../contact.html">联系我们</a> | <a href="../jiabin.html">领导嘉宾</a> | <a href="../diaocha.html">品牌调查</a> | <a href="../toupiao.html">投票须知</a> </div>
</div>
<div class="w980" style="margin-bottom:10px;">
  <div class="box pd10">
    <div class="leftbox" style="width:700px; margin-right:10px;">
      <div class="newsdetal BK">
        <h1><%=title %></h1>
        <div class="titbar"> <%=time %></div>
        <div id="cnt_main_article">
          <%=content %>
        </div>
      </div>
    </div>
    <div class="rightbox" style="width:250px;background-color:#fff5e1;">
      <div class="huodong_news">
        <h2>热点新闻</h2>
        <ul>
          <asp:Repeater ID="Repeater_new1" runat="server">
              <ItemTemplate>
                 <li>&middot;<a href='/news/new.aspx?id=<%#Eval("id")%>' target="_blank"><%#Eval("title")%></a></li>
              </ItemTemplate>
            </asp:Repeater>
         
        </ul>
      </div>
    </div>
  </div>
</div>
<div id="footer"> brandgov.cn 版 权 所 有 ，未 经 书 面 授 权 禁 止 使 用 <br />
  Copyright © 2011 by www.brandgov.cn. all rights reserved</div>
<script type="text/javascript">var _bdhmProtocol = (("https:" == document.location.protocol) ? " https://" : " http://");document.write(unescape("%3Cscript src='" + _bdhmProtocol + "hm.baidu.com/h.js%3F5e1d6a27ceb87911bd8688a2c5388ee7' type='text/javascript'%3E%3C/script%3E"));</script>
</body>
</html>
