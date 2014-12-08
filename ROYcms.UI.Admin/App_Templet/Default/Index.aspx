<%@ Page Language="C#"%>

<!DOCTYPE HTML>
<!--[if lt IE 7]><html class="no-js lt-ie9 lt-ie8 lt-ie7"><![endif]-->
<!--[if IE 7]><html class="no-js lt-ie9 lt-ie8"><![endif]-->
<!--[if IE 8]><html class="no-js lt-ie9"><![endif]-->
<!--[if gt IE 8]><!--><html class="no-js"><!--<![endif]-->
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=7" />
<title>肇庆市水务集团有限公司官网网站-容纳百川 惠泽人间</title>
<meta name="keywords" content="肇水集团,肇庆市水务集团有限公司">
<meta name="description" content="肇庆市水务集团有限公司（简称肇水集团）是肇庆市国资委全资控股的国有中型水务企业。">
<CMS:Include ID="Include1" Path="/App_Templet/Default/Resources.html" runat=server />
</head>
<body>
<!--Header-->
<CMS:Include ID="Include2" Path="/App_Templet/Default/Header.html" runat=server />
<!--/Header-->
<div class="wp cl">
  <section class="banner cl mb-10">
    <ul class="tabcon">
      <li><img name="" src="../update/banner_1.jpg" width="980" height="300" alt=""></li>
      <li><img name="" src="../update/banner_2.jpg" width="980" height="300" alt=""></li>
      <li><img name="" src="../update/banner_3.jpg" width="980" height="300" alt=""></li>
    </ul>
  </section>
  <section class="eventbar mb-10"><span class="ico">三标方针：</span><marquee width="865" valign="bottom" scrollamount="4" onmouseout="this.start()" onmouseover="this.stop()" style="color:red">凝聚生命之源 确保安全优质 营造绿色人文 科学和谐发展</marquee></section>
  <article class="cl mb-10">
    <div style="width:710px; float:left;">
      <div style="width:260px;float:left; margin-right:10px; margin-bottom:10px;">
        <section id="yingyeting" class="bk_1 cl radius" style=" height:315px;">
          <div class="section_title mb-10">
            <h2 class="l">网上服务厅</h2>
          </div>
          <nav class="leftmenu2" style="width: 240px; margin:auto;">
            <p id="leftmenu1"><a href="servers.html">服务承诺</a></p>
            <p id="leftmenu2"><a href="Zjsf.aspx">水费查询/缴费</a></p>
            <p id="leftmenu3"><a href="message.html">在线留言</a></p>
            <p id="leftmenu4"><a href="Zyewu.aspx">业务办理</a></p>
          </nav>
        </section>
      </div>
      <div style="width:440px; float:left; margin-bottom:10px;">
        <section id="index_news" class="bk_1 radius" style="height:315px;">
          <div class="section_title">
            <h2 class="l tabbar"><span>公司新闻</span> <span>行业新闻</span></h2>
            <span class="r more"><a href="news.html">更多&gt;&gt;</a></span></div>
          <div class="pd-10 tabcon">
            <div class="cl mb-10">

                <CMS:WebRepeater ID="WebRepeater2" Type="14" Top=1 Tuijian=0 Ding=0 runat="server">
                <ItemTemplate>
                  <div class="picbox">
                      <a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'>
                          <img src='<%#Eval("pic") %>' alt='<%#Eval("title") %>' width="160" height="120" />
                      </a>
                     </div>
                  <div class="textbox">
                    <h2><%#(Eval("title").ToString()+"                                                ").Substring(0,35) %></h2>
                    <p><%#(Eval("zhaiyao").ToString()+"                                                                                                                                                                                                                                                                                                                                                                        ").Substring(0,55) %>… <a href='<%#Eval("ShowLink") %>'>[详细]</a></p>
                  </div>
               
                </ItemTemplate>
                </CMS:WebRepeater>

            </div>
            <ul class="news_1">
                <CMS:WebRepeater ID="WebRepeater1" Type="14" Top=5 Tuijian=0 Ding=1 runat="server">
                <ItemTemplate>
             <li><a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'><%#(Eval("title").ToString()+"                                        ").Substring(0,30) %></a> </li>
                </ItemTemplate>
                </CMS:WebRepeater>
              
            </ul>
          </div>
          <div class="pd-10 tabcon">
            <div class="cl mb-10">
           <CMS:WebRepeater ID="WebRepeater4" Type="15" Top=1 Tuijian=0 Ding=0 runat="server">
                <ItemTemplate>
                  <div class="picbox">
                      <a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'>
                          <img src='<%#Eval("pic") %>' alt='<%#Eval("title") %>' width="160" height="120" />
                      </a>
                     </div>
                  <div class="textbox">
                    <h2><%#Eval("title") %></h2>
                    <p><%#Eval("zhaiyao") %>… <a href='<%#Eval("ShowLink") %>'>[详细]</a></p>
                  </div>
               
                </ItemTemplate>
                </CMS:WebRepeater>
            </div>
            <ul class="news_1">
              <CMS:WebRepeater ID="WebRepeater3" Type="15" Top=5 Tuijian=0 Ding=1 runat="server">
                <ItemTemplate>
                <li><a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'><%#(Eval("title").ToString()+"                                        ").Substring(0,30) %></a> </li>
                </ItemTemplate>
                </CMS:WebRepeater>
            </ul>
          </div>
        </section>
      </div>
      <section class="l mb-10" style="width:710px;"> <img src="../images/710x98.jpg" width="710" height="98"> </section>
      <div style="width:350px; margin-right:10px; float:left">
        <section class="bk_1 cl radius" id="zcfg" style="height:234px">
          <div class="section_title mb-10">
            <h2 class="l">政策法规</h2>
            <span class="r more"><a href="/rule.html">更多&gt;&gt;</a></span> </div>
          <ul class="news_1 pd-10" style="padding-top:0px">
              <CMS:WebRepeater ID="WebRepeater5" Type="4" Top=7 Tuijian=0 Ding=1 runat="server">
                <ItemTemplate>
                <li><a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'><%#(Eval("title")+"                                         ").Substring(0,25) %></a> </li>
                </ItemTemplate>
                </CMS:WebRepeater>
          </ul>
        </section>
      </div>
      <div style="width:350px;float:left">
        <section class="bk_1 cl radius" id="djgz" style="height:234px">
          <div class="section_title mb-10">
            <h2 class="l">党建工作</h2>
            <span class="r more"><a href="/dang.html">更多&gt;&gt;</a></span> </div>
          <ul class="news_1 pd-10" style="padding-top:0px">
                        <CMS:WebRepeater ID="WebRepeater6" Type="6" Top=7 Tuijian=0 Ding=1 runat="server">
                <ItemTemplate>
                <li><a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'><%#(Eval("title")+"                                         ").Substring(0,25) %></a> </li>
                </ItemTemplate>
                </CMS:WebRepeater>
          </ul>
        </section>
      </div>
    </div>
    <div style="width:260px; float:right">
      <section class="mb-10"><img src="../images/hotline.jpg" width="260" height="133"></section>
      <section id="inform" class="bk_1 mb-10 radius" style="height:172px;">
        <div class="section_title">
          <h2 class="l tabbar"><span>通知公告</span> <span>水压公告</span><span>水质公告</span></h2>
        </div>
        <div class="tabcon cl pd-10">
          <p class="f14 l22" style="text-indent:2em">
            <CMS:WebRepeater ID="WebRepeater006" Type="22" Top=1 Tuijian=0 Ding=1 runat="server">
                <ItemTemplate>
				<%#Eval("zhaiyao") %>
                <a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'>点击了解详情&gt;&gt;</a>
                </ItemTemplate>
            </CMS:WebRepeater>
           
              
          </p>
        </div>
        <div class="tabcon cl pd-10">
            <a href="/sy.html"> 
          <table class="shuizhi_table" width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <th scope="col">水厂</th>
              <th scope="col"></th>
              <th scope="col"></th>
            </tr>
            <tr>
              <td>厂排基围头</td>
              <td colspan="2">人民中草场路</td>
            </tr>
            <tr>
              <td>柑园市场</td>
              <td colspan="2">城东建设二路</td>
            </tr>
            <tr>
              <td>安居东湖居</td>
              <td colspan="2">北岭加压站</td>
            </tr>
            <tr>
              <td>翠星路星荷豪苑</td>
              <td colspan="2">大冲马头岗村</td>
            </tr>
          </table>
                </a>
        </div>
        <div class="tabcon cl pd-10">
             <a href="/sz.html"> 
          <table class="shuizhi_table" width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <th scope="col" class="c_999">水厂</th>
              <th scope="col" class="maincolor"></th>
              <th scope="col" class="maincolor"></th>
            </tr>
             <tr>
              <td>厂排基围头</td>
              <td colspan="2">人民中草场路</td>
            </tr>
            <tr>
              <td>柑园市场</td>
              <td colspan="2">城东建设二路</td>
            </tr>
            <tr>
              <td>安居东湖居</td>
              <td colspan="2">北岭加压站</td>
            </tr>
            <tr>
              <td>翠星路星荷豪苑</td>
              <td colspan="2">大冲马头岗村</td>
            </tr>
          </table>
                 </a>
        </div>
      </section>
      <section class="mb-10"><a href="/18da/index.html"><img src="../update/18da.jpg" width="260" height="44"></a></section>
      <section class="mb-10"><a href="/jljy/index.html"><img src="../update/zuofeng.jpg" width="260" height="44"></a></section>
      <section>
      <div class="section_title">
            <h2 class="l">肇水视频</h2>
            <span class="r more"><a href="/mov.html">更多&gt;&gt;</a></span> </div>

          <iframe height=202 width=260 src="http://player.youku.com/embed/XMTkyMDAxNzY0" frameborder=0 allowfullscreen></iframe>

      </section>
    </div>
  </article>
  
  <!--Flink-->
  <nav class="flink_pic bk_1 radius">
    <ul class="ul cl">
      <li><a href="#"><img src="../update/flink01.png" width="122" height="44" longdesc=""></a></li>
      <li><a href="#"><img src="../update/flink02.png" width="122" height="44" longdesc=""></a></li>
      <li><a href="#"><img src="../update/flink03.png" width="122" height="44" longdesc=""></a></li>
      <li><a href="#"><img src="../update/flink04.png" width="122" height="44" longdesc=""></a></li>
      <li><a href="#"><img src="../update/flink05.png" width="122" height="44" longdesc=""></a></li>
      <li><a href="#"><img src="../update/flink06.png" width="122" height="44" longdesc=""></a></li>
      <li><a href="#"><img src="../update/flink07.png" width="122" height="44" longdesc=""></a></li>
    </ul>
  </nav>
  <!--/Flink--> 
</div>
<!--Footer-->
<CMS:Include ID="Include3" Path="/App_Templet/Default/Footer.html" runat=server />
<!--/Footer-->
</body>
</html>