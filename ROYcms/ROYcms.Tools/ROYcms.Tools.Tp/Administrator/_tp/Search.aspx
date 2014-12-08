<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="ROYcms.Tools.Tp.Administrator._tp.Search" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>服务中国-满意度品牌调查</title>
<meta name="keywords" content="服务中国-满意度品牌调查" />
<meta name="description" content="服务中国-满意度品牌调查" />
<link href="css/main.css" rel="stylesheet" type="text/css" />
<script language="javascript" type="text/javascript">
function tabOver(objId,objContId,Num,TotalNum,classNameOn,classNameOff) { 
var tabNum = TotalNum;for (var i = 1; i <= tabNum; i++){
var tab = document.getElementById(objId+i);
var tabCont = document.getElementById(objContId+i);
if (i == Num){tabCont.style.display = 'block';tab.className = classNameOn;}
else {tabCont.style.display = 'none';tab.className = classNameOff;}}}
// 当前播放位置
var tab_num = 0;var tab_max = 3;var tab_speed = 3000;var tab_play;
// 自动播放
function changeTab(){if (tab_num == tab_max) {tab_num = 1;} else {tab_num++;}tabOver('num','bigimg',tab_num,tab_max,'hover','');}
function autoTab(){tab_play = setInterval('changeTab()',tab_speed);}
function mouseTab(tab_index) {window.clearInterval(tab_play);tabOver('num','bigimg',tab_index,tab_max,'hover','');	tab_num = tab_index;}
function mouseTab2(){autoTab();}
</script>
</head>
<body onload="autoTab()">
<form id="form1" runat =server>
<div class="banner_1 w980"></div>
<div class="banner_2 w980"></div>
<div class="banner_3 w980">
  <div id="mainnav"><a href="index.html">首页</a> | <a href="gaikuang.html">大会概况</a> | <a href="contact.html">联系我们</a> | <a href="jiabin.html">领导嘉宾</a> | <a href="diaocha.html">品牌调查</a> | <a href="toupiao.html">投票须知</a> </div>
</div>
<div class="w980" style="margin-bottom:10px;">
  <div class="pd10">
    <div id="news">
      <div class="leftbox">
        <div class="flashimg">
          <div class="bigimg">
            <div class="numbar"> <span id="num1" class="hover" onmouseover="mouseTab(1)" onmouseout="mouseTab2()"></span> <span id="num2" onmouseover="mouseTab(2)" onmouseout="mouseTab2()"></span> <span id="num3" onmouseover="mouseTab(3)" onmouseout="mouseTab2()"></span> </div>
            <div id="bigimg1" class="bigimgbar">
              <div class="picbox"><a href="http://www.72xuan.com/article-qita-201103-09-17168.html" target="_blank"><img src="pic/flashpic/01.jpg" width="360" height="244" /></a></div>
              <h3><a href="http://www.72xuan.com/article-qita-201103-09-17168.html" target="_blank">建材选购指南：买建材省钱窍门</a></h3>
            </div>
            <div id="bigimg2" class="bigimgbar" style="display:none;">
              <div class="picbox"><a href="http://www.72xuan.com/article-hot-201103-10-17173.html" target="_blank"><img src="pic/flashpic/02.jpg" width="360" height="244" /></a></div>
              <h3><a href="http://www.72xuan.com/article-hot-201103-10-17173.html" target="_blank">购买家用电器须慎重谨慎</a></h3>
            </div>
            <div id="bigimg3" class="bigimgbar" style="display:none;">
              <div class="picbox"><a href="http://www.72xuan.com/article-hot-201103-09-17157.html" target="_blank"><img src="pic/flashpic/03.jpg" width="360" height="244" /></a></div>
              <h3><a href="http://www.72xuan.com/article-hot-201103-09-17157.html" target="_blank">家具质量最重要 消费者买家具首看性价比</a></h3>
            </div>
          </div>
        </div>
      </div>
      <div class="midbox">
        <div style="border:solid 1px #ccc; height:268px;">
          <h1 class="hotnews" style="margin-top:5px;"><a href="#" target="_blank">这是显示重要新闻通知一条</a></h1>
          <ul class="newslist_14">
            <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
            <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
            <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
            <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
            <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
            <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
            <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
            <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a> </li>
            <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
          </ul>
        </div>
      </div>
      <div class="rightbox">
        <h2><span class="more"><a href="#" target="_blank">更多&gt;&gt;</a></span>活动新闻</h2>
        <ul>
          <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
          <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
          <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
          <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
          <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
          <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
          <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
          <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a> </li>
          <li>&middot;<a href="#" target="_blank">新闻标题新闻标题新闻标</a></li>
        </ul>
      </div>
    </div>
    <div><a href="#" target="_blank"><img src="pic/980.gif" width="960" height="60" /></a></div>
  </div>
</div>
<div id="searchbar" class="w980">

    <table border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td height="5" colspan="3"></td>
      </tr>
      <tr>
        <td width="100" height="28" style="color:#fff; font-size:14px; font-weight:bold;">行业品牌搜索</td>
        <td width="410"><label>
            <input runat=server type="text" name="keyword" id="keyword" style="width:400px; height:19px; font-size:14px; border:solid 1px #ccc; background-color:#fff;cursor:text; padding-left:5px; padding-top:4px;" />
          </label></td>
        <td><label>
            
            
            <asp:ImageButton  ID="SearchImageButton" runat="server"  
                ImageUrl="images/btn_search.gif" onclick="SearchImageButton_Click"  />
          </label></td>
      </tr>
    </table>

</div>
<div class="w980" style="margin-bottom:10px;">
  <div class="pd10">

     <div class="pinpailist BK">
      <h2><span class="ico_1"></span><span class="more"></span>搜索结果</h2>
      <div class="pinpai_index">
        <ul>
          <asp:Repeater ID="Repeater_tu" runat="server">
          <ItemTemplate>
          <li><div class="picbox">
            <a href='<%#Eval("link_url")%>' target="_blank">
            <img name="" src='/app_pic/tp/<%#Eval("img_path")%>' width="140" height="100" alt='<%#Eval("names").ToString().Trim() %>' />
            </a></div><h3>
             <input type='checkbox'  name="tp_id[]" id="tp_id[]" value='<%#Eval("id") %>'  />
             <a href='<%#Eval("link_url")%>' target="_blank"><%#Eval("names").ToString().Trim() %></a></h3></li>
          </ItemTemplate>
        </asp:Repeater>
        </ul>
      </div>
    </div>
    
    <div id="toupiao" class="pinpailist BK">
      <h2><span class="ico_1"></span><span class="more" style="color:#fff"><strong>声明：</strong>主办方郑重承诺，以下信息严格保密。</span>投票/留言</h2>
      <div style="padding:10px;">
        <table border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="40" height="30">姓名*</td>
            <td width="210"><label>
                <input type="text" runat="server" name="t_name" class="in_t" id="t_name" />
              </label></td>
            <td width="40">手机*</td>
            <td width="210"><label>
              <input type="text" runat="server" name="t_tel" class="in_t" id="t_tel" />
              </label></td>
            <td width="100">身份证/护照号*</td>
            <td width="210"><label>
                <input type="text" runat="server" name="t_card" class="in_t" id="t_card" />
              </label></td>
            <td rowspan="2" valign="bottom">
            <label>      
             <asp:ImageButton  ID="ImageButton_tp" runat="server"  ImageUrl="images/toupiao.gif"  onclick="ImageButton_tp_Click" />
              </label></td>
          </tr>
          <tr>
            <td height="30" valign="top">留言</td>
            <td colspan="5"><label>
                <textarea name="t_content" runat="server" rows="3" class="in_t" id="t_content" style=" width:760px;"></textarea>
                </label></td>
          </tr>
        </table>
      </div>
    </div>
  </div>
</div>
<div class="w980">
  <div id="hzmt" class="pd10 box">
    <h2><img src="images/fou_ppj_09.jpg" width="156" height="38" /></h2>
    <ul>
      <li><a href="http://www.news.cn/" target="_blank"><img src="pic/meiti/newhua.jpg" width="92" height="68" /></a></li>
      <li><a href="http://www.163.com/" target="_blank"><img src="pic/meiti/163.jpg" width="92" height="68" /></a></li>
      <li><a href="http://www.sina.com.cn/" target="_blank"><img src="pic/meiti/sina.jpg" width="92" height="68" /></a></li>
    </ul>
  </div>
</div>
<div id="footer"> brandgov.cn 版 权 所 有 ，未 经 书 面 授 权 禁 止 使 用 <br />
  Copyright © 2011 by www.brandgov.cn. all rights reserved</div>
<script type="text/javascript">var _bdhmProtocol = (("https:" == document.location.protocol) ? " https://" : " http://");document.write(unescape("%3Cscript src='" + _bdhmProtocol + "hm.baidu.com/h.js%3F5e1d6a27ceb87911bd8688a2c5388ee7' type='text/javascript'%3E%3C/script%3E"));</script>
</form></body>
</html>
