<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Search.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.App_Api.search"  EnableViewState="false"   %>
<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title></title>
<meta name="description" content="">
<meta name="keywords" content="">
<meta name="author" content="jackying">
<link href="../css/search.css" rel="stylesheet" type="text/css" />
<style type="text/css">
<!--
.chekbox {
	border: 1px solid #F3F3F3;
	padding: 3px;
}
.bt {
	margin-left:3px;
}
.thumbImage {max-width: 200px;max-height: 100px;} /* for Firefox & IE7 */
* html .thumbImage { /* for IE6 */
width: expression(this.width > 200 && this.width > this.height ? 200 : auto);
height: expression(this.height > 100 ? 100 : auto);
}
-->
</style>
</head>
<body>
<form method="get" id="form1" runat="server">
  <div id="header" style="margin-top:3px;">
    <div id="logo">
      <a href='<CMS:WebConfig Name="web_host" runat=server />' target="_blank"><img src='<CMS:WebConfig Name="logo" runat=server />' width="200" height="65" border="0"  /></a>
    </div>
    <div>
      <div id="SearchKuang">
        <div style="margin-top:10px; font-size:14px;">
          <a href="/Search.ashx">首页</a>
          <a href="#">信息</a>
          <a href="#">图片</a>
          <a href="#">评论</a>
          <a href="#">用户</a>
          <a href="#">全部</a>
        </div>
        <div>
          <table width="98%" border="0" cellspacing="0" cellpadding="2">
            <tr>
              <td width="6%" valign="bottom" nowrap="nowrap"><asp:DropDownList ID="DropDownList_type" runat="server" >
                  <asp:ListItem Value="title">标题</asp:ListItem>
                  <asp:ListItem Value="keyword">关键字</asp:ListItem>
                  <asp:ListItem Value="zhaiyao">描述</asp:ListItem>
                  <asp:ListItem Value="contents">内容</asp:ListItem>
                  <asp:ListItem>全部</asp:ListItem>
                </asp:DropDownList></td>
              <td width="20%" valign="bottom" nowrap="nowrap"><asp:TextBox ID="TextBox_keyword" runat="server"  Width="320px" 
                Height="21px"></asp:TextBox></td>
              <td width="8%" valign="bottom" nowrap="nowrap"><asp:Button ID="Button_Search" runat="server" Text="开始搜索" 
           onclick="Button_Search_Click" /></td>
              <td width="66%" valign="bottom" nowrap="nowrap"><span class="font_s12">
                <a href="?Config=ROYcms_Search">设置</a>
                |
                <a href='<CMS:WebConfig Name="web_host" runat=server />'>网站首页</a>
                </span></td>
            </tr>
          </table>
        </div>
      </div>
    </div>
  </div>
  <table width="100%" border="0" align="center" cellpadding="4" cellspacing="0" height="25px">
    <tr>
      <td width="2" bgcolor="#FF0000" style="color:#FFF; font-family:微软雅黑;"></td>
      <td width="790"  bgcolor="#0066B3" style="color:#FFF; font-family:微软雅黑;"><span style=" margin-left:10px;">搜索到的结果信息</span></td>
      <td width="329" nowrap  bgcolor="#0066B3" style="color:#FFF; font-family:微软雅黑;">搜索一下，找到相关信息约
        <% if (PageCont != null)
           {%>
        <% = (PageCont * 30)%>
        <% }%>
        篇，用时 0.0000021 秒</td>
    </tr>
  </table>
  <div id="KJ_SearchList" class="clean">
    <div id="SearchJJ">
      <ul>
        <li>
          <table width="80%" border="0" cellspacing="0" cellpadding="5">
            <tr>
              <td width="2%" height="24" bgcolor="#E5ECF9"></td>
              <td width="98%" bgcolor="#E5ECF9"><h4>相关信息</h4></td>
            </tr>
          </table>
          <a href='http://www.baidu.com/s?wd=<% =this.keyword%>' target="_blank"> 到百度搜索 <span class="keyword">[
          <% =this.keyword%>
          ]</span></a>
        </li>
        <li>
          <a href='http://search.cn.yahoo.com/s?p=<% =this.keyword%>&v=web&pid=ysearch' target="_blank"> 到雅虎搜索 <span class="keyword">[
          <% =this.keyword%>
          ] </span></a>
        </li>
        <li>
          <a href='http://www.google.cn/search?hl=zh-CN&newwindow=1&q=<% =this.keyword%>&btnG=Google+%E6%90%9C%E7%B4%A2&aq=f&oq=' target="_blank"> 到谷歌搜索 <span class="keyword">[
          <% =this.keyword%>
          ]</span></a>
        </li>
        <li>
          <a href='http://www.sogou.com/web?query=<% =this.keyword%>&_ast=1259731840&_asf=www.sogou.com&w=01029901&num=10&p=40040100&dp=1' target="_blank"> 到搜狗搜索 <span class="keyword">[
          <% =this.keyword%>
          ] </span></a>
        </li>
        <li>
          <a href='http://so.hudong.com/s/doc/<% =this.keyword%>' target="_blank"> 到互动百科编辑 <span class="keyword">[
          <% =this.keyword%>
          ]</span> 词条 </a>
        </li>
        <li>
          <a href='http://baike.baidu.com/w?ct=17&lm=0&tn=baiduWikiSearch&pn=0&rn=10&word=<% =this.keyword%>&submit=search' target="_blank"> 到百度百科创建 <span class="keyword">[
          <% =this.keyword%>
          ]</span> 词条 </a>
        </li>
      </ul>
    </div>
    <div id="SearchListContent">
      <dl class="SearchList">
        <asp:Repeater ID="Repeater_list" runat="server">
          <ItemTemplate>
            <dt>
              <a href='<CMS:Link Rid=<%#Eval("bh") %> runat="server" />' target="_blank"><%#Eval("title").ToString().Replace(this.keyword == null ? "null" : this.keyword, "<span class=keyword>" + this.keyword + "</span>")%>...</a>
            </dt>
            <dd>
            <%#Eval("pic").ToString()!="no"?"<img  border='1' src='/app_pic/"+Eval("author")+"/s_"+Eval("pic")+"'   class='thumbImage' alt='ROYcms!NT检索结果 ' style='border-color:#000; margin:3px;' /><br>":"" %>
			<%#ROYcms.Common.input.GetSubString(ROYcms.Common.input.ForTXT(Eval("contents").ToString()), 200).Replace(this.keyword == null ? "null" : this.keyword, "<span class=keyword>" + this.keyword + "</span>")%>...
              <p><span class="website"><CMS:WebConfig ID="WebConfig1" Name="web_host" runat=server /><CMS:Link ID="Link1" Rid=<%#Eval("bh") %> runat="server" /></span>
                <span class="datetime"><%#Eval("time") %></span>
                <span class="kuaizhao">
                <a href='<CMS:Link Rid=<%#Eval("bh") %> runat="server" />'>访问</a>
                </span></p>
            </dd>
          </ItemTemplate>
        </asp:Repeater>
      </dl>
      <div class="page">
      <% if (PageCont != null)
         {%>
        <center>
          <Script Language="JavaScript" type="text/JavaScript" src="/Administrator/js/page.js"></Script>
          <script language="JavaScript">
            <!--
            var pg = new showPages('pg');
            pg.pageCount =<% =PageCont %>;  // 定义总页数(必要)
            pg.argName = 'page';  // 定义参数名(可选,默认为page)
            //document.write('<br>Show Times: ' + pg.showTimes + ', Mood 1');
            pg.printHtml(1);
            //-->
      </script>
          总 [ <span class="TabbedPanelsTabHover">
          <% = (PageCont * 30)%>
          </span>] 条数据
        </center>
        <%} %>
      </div>
    </div>
  </div>
  <div style="margin-bottom:15px; margin-top: 30px; color:#999; background-color: #F7F7F7;">
    <center>
      <CMS:WebConfig ID="WebConfig2" Name="web_name" runat=server /> 版权所有 2009 <CMS:WebConfig ID="WebConfig3" Name="web_host" runat=server />
    </center>
  </div>
</form>
</body>
</html>
