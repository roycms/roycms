<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="index.aspx.cs" Inherits="ROYcms.Tools.Tp.Administrator._tp.index" %>
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
var tab_num = 0;var tab_max = 2;var tab_speed = 3000;var tab_play;
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
    <div id="mainnav"><a href="index.aspx">首页</a> | <a href="gaikuang.html">大会概况</a> | <a href="contact.html">联系我们</a> | <a href="jiabin.html">领导嘉宾</a> | <a href="diaocha.html">品牌调查</a> | <a href="toupiao.html">投票须知</a></div>
  </div>
  <div class="w980" style="margin-bottom:10px;">
    <div class="pd10">
      <div id="news">
        <div class="leftbox">
          <div class="flashimg">
            <div class="bigimg">
              <div class="numbar"> <span id="num1" class="hover" onmouseover="mouseTab(1)" onmouseout="mouseTab2()"></span> <span id="num2" onmouseover="mouseTab(2)" onmouseout="mouseTab2()"></span></div>
              <div id="bigimg1" class="bigimgbar">
                <div class="picbox"><a href="news/001.html" target="_blank"><img src="pic/flashpic/01.jpg" width="360" height="244" /></a></div>
                <h3><a href="news/001.html" target="_blank">李克强出席服务业发展改革工作座谈会</a></h3>
              </div>
              <div id="bigimg2" class="bigimgbar" style="display:none;">
                <div class="picbox"><a href="news/003.html" target="_blank"><img src="pic/flashpic/02.jpg" width="360" height="244" /></a></div>
                <h3><a href="news/003.html" target="_blank">温家宝分别召开经济形势座谈会</a></h3>
              </div>
            </div>
          </div>
        </div>
        <div class="midbox">
          <div style="border:solid 1px #ccc; height:268px;">
            <h1 class="hotnews" style="margin-top:5px;"><a href="/news/001.html" target="_blank">李克强出席服务业发展改革工作座谈会</a></h1>
            <ul class="newslist_14">
            
             <asp:Repeater ID="Repeater_new1" runat="server">
              <ItemTemplate>
                 <li>&middot;<a href='/news/new.aspx?id=<%#Eval("id")%>' target="_blank"><%#Eval("title")%></a></li>
              </ItemTemplate>
            </asp:Repeater>
            </ul>
          </div>
        </div>
        <div class="rightbox">
          <h2><span class="more"></span>活动新闻</h2>
          <ul>
                       <asp:Repeater ID="Repeater_new2" runat="server">
              <ItemTemplate>
                 <li>&middot;<a href='/news/new.aspx?id=<%#Eval("id")%>' target="_blank"><%#Eval("title")%></a></li>
              </ItemTemplate>
            </asp:Repeater>
          
          </ul>
        </div>
      </div>
      <div><img src="pic/980.gif" width="960" height="60" /></div>
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
        <h2><span class="ico_1"></span><span class="more"><a href="Search.aspx?t=5" target="_blank">更多餐饮服务行业品牌>></a></span>餐饮服务行业</h2>
        <div class="pinpai_index">
          <ul>
            <asp:Repeater ID="Repeater_tu2" runat="server">
              <ItemTemplate>
                <li>
                  <div class="picbox"> <a href='<%#Eval("link_url")%>' target="_blank"> <img name="" src='/app_pic/tp/<%#Eval("img_path")%>' width="140" height="100" alt='<%#Eval("names").ToString().Trim() %>' /> </a></div>
                  <h3>
                    <input type='checkbox'  name="tp_id[]" id="tp_id[]" value='<%#Eval("id") %>'  />
                    <a href='<%#Eval("link_url")%>' target="_blank"><%#Eval("names").ToString().Trim() %></a></h3>
                </li>
              </ItemTemplate>
            </asp:Repeater>
          </ul>
        </div>
      </div>
      <div class="pinpailist BK">
                <h2><span class="ico_1"></span><span class="more"><a href="Search.aspx?t=4" target="_blank">更多金融服务行业品牌>></a></span>金融服务行业</h2>
                <div class="pinpai_index">
                  <ul>
                    <asp:Repeater ID="Repeater_tu1" runat="server">
                      <ItemTemplate>
                        <%--          <%#Eval("ballot") %>
                          
                         <%#Eval("characterization")%>，
                          <%#Eval("link_url")%>，
                         <%#Eval("datetime")%>，--%>
                        <li>
                          <div class="picbox"> <a href='<%#Eval("link_url")%>' target="_blank"> <img name="" src='/app_pic/tp/<%#Eval("img_path")%>' width="140" height="100" alt='<%#Eval("names").ToString().Trim() %>' /> </a> </div>
                          <h3>
                            <input type='checkbox'  name="tp_id[]" id="tp_id[]" value='<%#Eval("id") %>'  />
                            <a href='<%#Eval("link_url")%>' target="_blank"><%#Eval("names").ToString().Trim() %></a></h3>
                        </li>
                      </ItemTemplate>
                    </asp:Repeater>
                  </ul>
                </div>
              </div>
      <div class="pinpailist BK">
                <h2><span class="ico_1"></span><span class="more"><a href="Search.aspx?t=6" target="_blank">更多酒店服务行业品牌>></a></span>酒店服务行业</h2>
                <div class="pinpai_index">
                  <ul>
                    <asp:Repeater ID="Repeater_tu3" runat="server">
                      <ItemTemplate>
                        <li>
                          <div class="picbox"> <a href='<%#Eval("link_url")%>' target="_blank"> <img name="" src='/app_pic/tp/<%#Eval("img_path")%>' width="140" height="100" alt='<%#Eval("names").ToString().Trim() %>' /> </a></div>
                          <h3>
                            <input type='checkbox'  name="tp_id[]" id="tp_id[]" value='<%#Eval("id") %>'  />
                            <a href='<%#Eval("link_url")%>' target="_blank"><%#Eval("names").ToString().Trim() %></a></h3>
                        </li>
                      </ItemTemplate>
                    </asp:Repeater>
                  </ul>
                </div>
              </div>
      <div class="pinpailist BK">
        <h2><span class="ico_1"></span><span class="more"><a href="Search.aspx?t=7" target="_blank">更多民航服务行业品牌>></a></span>民航服务行业</h2>
        <div class="pinpai_index">
          <ul>
            <asp:Repeater ID="Repeater_tu4" runat="server">
              <ItemTemplate>
                <li>
                  <div class="picbox"> <a href='<%#Eval("link_url")%>' target="_blank"> <img name="" src='/app_pic/tp/<%#Eval("img_path")%>' width="140" height="100" alt='<%#Eval("names").ToString().Trim() %>' /> </a></div>
                  <h3>
                    <input type='checkbox'  name="tp_id[]" id="tp_id[]" value='<%#Eval("id") %>'  />
                    <a href='<%#Eval("link_url")%>' target="_blank"><%#Eval("names").ToString().Trim() %></a></h3>
                </li>
              </ItemTemplate>
            </asp:Repeater>
          </ul>
        </div>
      </div>
      <div class="pinpailist BK">
        <h2><span class="ico_1"></span><span class="more"><a href="Search.aspx?t=8" target="_blank">更多商超服务行业品牌>></a></span>商超服务行业</h2>
        <div class="pinpai_index">
          <ul>
            <asp:Repeater ID="Repeater_tu5" runat="server">
              <ItemTemplate>
                <li>
                  <div class="picbox"> <a href='<%#Eval("link_url")%>' target="_blank"> <img name="" src='/app_pic/tp/<%#Eval("img_path")%>' width="140" height="100" alt='<%#Eval("names").ToString().Trim() %>' /> </a></div>
                  <h3>
                    <input type='checkbox'  name="tp_id[]" id="tp_id[]" value='<%#Eval("id") %>'  />
                    <a href='<%#Eval("link_url")%>' target="_blank"><%#Eval("names").ToString().Trim() %></a></h3>
                </li>
              </ItemTemplate>
            </asp:Repeater>
          </ul>
        </div>
      </div>
      <div class="pinpailist BK">
        <h2><span class="ico_1"></span><span class="more"><a href="Search.aspx?t=9" target="_blank">更多电子商务服务行业品牌>></a></span>电子商务服务行业</h2>
        <div class="pinpai_index">
          <ul>
            <asp:Repeater ID="Repeater_tu6" runat="server">
              <ItemTemplate>
                <li>
                  <div class="picbox"> <a href='<%#Eval("link_url")%>' target="_blank"> <img name="" src='/app_pic/tp/<%#Eval("img_path")%>' width="140" height="100" alt='<%#Eval("names").ToString().Trim() %>' /> </a></div>
                  <h3>
                    <input type='checkbox'  name="tp_id[]" id="tp_id[]" value='<%#Eval("id") %>'  />
                    <a href='<%#Eval("link_url")%>' target="_blank"><%#Eval("names").ToString().Trim() %></a></h3>
                </li>
              </ItemTemplate>
            </asp:Repeater>
          </ul>
        </div>
      </div>
      <div class="pinpailist BK">
        <h2><span class="ico_1"></span><span class="more"><a href="Search.aspx?t=10" target="_blank">更多物流与运输服务行业品牌>></a></span>物流与运输服务行业</h2>
        <div class="pinpai_index">
          <ul>
            <asp:Repeater ID="Repeater_tu7" runat="server">
              <ItemTemplate>
                <li>
                  <div class="picbox"> <a href='<%#Eval("link_url")%>' target="_blank"> <img name="" src='/app_pic/tp/<%#Eval("img_path")%>' width="140" height="100" alt='<%#Eval("names").ToString().Trim() %>' /> </a></div>
                  <h3>
                    <input type='checkbox'  name="tp_id[]" id="tp_id[]" value='<%#Eval("id") %>'  />
                    <a href='<%#Eval("link_url")%>' target="_blank"><%#Eval("names").ToString().Trim() %></a></h3>
                </li>
              </ItemTemplate>
            </asp:Repeater>
          </ul>
        </div>
      </div>
      <div class="pinpailist BK">
        <h2><span class="ico_1"></span><span class="more"><a href="Search.aspx?t=11" target="_blank">更多旅游服务行业品牌>></a></span>旅游服务行业</h2>
        <div class="pinpai_index">
          <ul>
            <asp:Repeater ID="Repeater_tu8" runat="server">
              <ItemTemplate>
                <li>
                  <div class="picbox"> <a href='<%#Eval("link_url")%>' target="_blank"> <img name="" src='/app_pic/tp/<%#Eval("img_path")%>' width="140" height="100" alt='<%#Eval("names").ToString().Trim() %>' /> </a></div>
                  <h3>
                    <input type='checkbox'  name="tp_id[]" id="tp_id[]" value='<%#Eval("id") %>'  />
                    <a href='<%#Eval("link_url")%>' target="_blank"><%#Eval("names").ToString().Trim() %></a></h3>
                </li>
              </ItemTemplate>
            </asp:Repeater>
          </ul>
        </div>
      </div>
      <div class="pinpailist BK">
        <h2><span class="ico_1"></span><span class="more"><a href="Search.aspx?t=12" target="_blank">更多地产服务行业品牌>></a></span>地产服务行业</h2>
        <div class="pinpai_index">
          <ul>
            <asp:Repeater ID="Repeater_tu9" runat="server">
              <ItemTemplate>
                <li>
                  <div class="picbox"> <a href='<%#Eval("link_url")%>' target="_blank"> <img name="" src='/app_pic/tp/<%#Eval("img_path")%>' width="140" height="100" alt='<%#Eval("names").ToString().Trim() %>' /> </a></div>
                  <h3>
                    <input type='checkbox'  name="tp_id[]" id="tp_id[]" value='<%#Eval("id") %>'  />
                    <a href='<%#Eval("link_url")%>' target="_blank"><%#Eval("names").ToString().Trim() %></a></h3>
                </li>
              </ItemTemplate>
            </asp:Repeater>
          </ul>
        </div>
      </div>
      <div class="pinpailist BK">
        <h2><span class="ico_1"></span><span class="more"><a href="Search.aspx?t=13" target="_blank">更多其他行业品牌>></a></span>其他行业</h2>
        <div class="pinpai_index">
          <ul>
            <asp:Repeater ID="Repeater_tu10" runat="server">
              <ItemTemplate>
                <li>
                  <div class="picbox"> <a href='<%#Eval("link_url")%>' target="_blank"> <img name="" src='/app_pic/tp/<%#Eval("img_path")%>' width="140" height="100" alt='<%#Eval("names").ToString().Trim() %>' /> </a></div>
                  <h3>
                    <input type='checkbox'  name="tp_id[]" id="tp_id[]" value='<%#Eval("id") %>'  />
                    <a href='<%#Eval("link_url")%>' target="_blank"><%#Eval("names").ToString().Trim() %></a></h3>
                </li>
              </ItemTemplate>
            </asp:Repeater>
          </ul>
        </div>
      </div>
      
      <div id="toupiao" class="pinpailist BK">
        <h2><span class="ico_1"></span><span class="more" style="color:#fff"><strong>声明：</strong>主办方郑重承诺，以下信息严格保密。</span>投票/留言</h2>
        <div style="padding:10px;">
          <table border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td width="45" height="30">姓名*</td>
              <td width="210"><label>
                  <input type="text" runat="server" name="t_name" class="in_t" id="t_name" />
                </label></td>
              <td width="45">手机*</td>
              <td width="210"><input type="text" runat="server" name="t_tel" class="in_t" id="t_tel" />
                <span style="display:none">
                <input name="t_card" type="text" class="in_t" id="t_card" value="0" runat="server" />
                </span></td>
              <td rowspan="2"><asp:ImageButton  ID="ImageButton_tp" runat="server"  ImageUrl="images/toupiao.gif"  onclick="ImageButton_tp_Click" /></td>
            </tr>
            <tr>
              <td>留言</td>
              <td colspan="3"><textarea name="t_content" runat="server" rows="3" class="in_t" id="t_content" style=" width:450px;"></textarea></td>
            </tr>
          </table>
        </div>
      </div>
    </div>
  </div>
  <div class="w980">
    <div id="hzmt" class="pd10 box">
      <h2><img src="images/fou_ppj_09.jpg" width="156" height="38" /></h2>
      <table width="960" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td><a href="http://www.mofcom.gov.cn/" target="_blank"><img src="pic/meiti/mofcom.gif" alt="商务部" width="90" height="45" /></a></td>
          <td><a href="http://www.sdpc.gov.cn/" target="_blank"><img src="pic/meiti/fazhangaige.gif" width="90" height="45" alt="国家发展和改革委员会" longdesc="http://www.sdpc.gov.cn/" /></a></td>
          <td><a href="http://www.miit.gov.cn/" target="_blank"><img src="pic/meiti/gongxin.gif" width="90" height="45" alt="工业和信息化部" longdesc="http://www.miit.gov.cn/" /></a></td>
          <td><a href="http://www.ccnt.gov.cn/" target="_blank"><img src="pic/meiti/wenhua.gif" width="90" height="45" alt="工业和信息化部" longdesc="http://www.ccnt.gov.cn/" /></a></td>
          <td><a href="http://www.most.gov.cn/" target="_blank"><img src="pic/meiti/keji.gif" width="92" height="45" alt="科学技术部" longdesc="http://www.most.gov.cn/" /></a></td>
          <td><a href="http://www.drc.gov.cn/" target="_blank"><img src="pic/meiti/fazhanyanjiu.gif" width="90" height="45" alt="国务院发展研究中心" longdesc="http://www.drc.gov.cn/" /></a></td>
          <td><a href="http://www.saic.gov.cn/" target="_blank"><img src="pic/meiti/gongshang.gif" width="90" height="45" alt="国家工商行政管理总局" longdesc="http://www.saic.gov.cn/" /></a></td>
          <td><a href="http://www.stats.gov.cn/" target="_blank"><img src="pic/meiti/tongjiju.gif" width="90" height="45" alt="国家统计局" longdesc="http://www.stats.gov.cn/" /></a></td>
          <td><a href="http://www.aqsiq.gov.cn/" target="_blank"><img src="pic/meiti/zhiliangjianyan.gif" width="90" height="45" alt="国家质量检验检疫总局" longdesc="http://www.aqsiq.gov.cn/" /></a></td>
          <td><a href="http://www.sipo.gov.cn/" target="_blank"><img src="pic/meiti/zhishichanquan.gif" width="90" height="45" alt="国家知识产权局" longdesc="http://www.sipo.gov.cn/" /></a></td>
        </tr>
      </table>
    </div>
  </div>
  <div id="footer">版权所有：中华人民共和国商务部研究院&nbsp;&nbsp;&nbsp; 运营管理：北京宾侨国际企业文化发展中心<br />
    Copyright &copy; 2011 by www.brandgov.cn. all rights reserved</div>
  <script type="text/javascript">var _bdhmProtocol = (("https:" == document.location.protocol) ? " https://" : " http://");document.write(unescape("%3Cscript src='" + _bdhmProtocol + "hm.baidu.com/h.js%3F0551539694a7fefe002bbd79096521e3' type='text/javascript'%3E%3C/script%3E"));</script>
</form>
</body>
</html>
