<%@ Page Language="C#"%>
<!DOCTYPE HTML>
<!--[if lt IE 7]><html class="no-js lt-ie9 lt-ie8 lt-ie7"><![endif]-->
<!--[if IE 7]><html class="no-js lt-ie9 lt-ie8"><![endif]-->
<!--[if IE 8]><html class="no-js lt-ie9"><![endif]-->
<!--[if gt IE 8]><!--><html class="no-js"><!--<![endif]-->
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=7" />
<title><CMS:ClassField ID="ClassField1" Name="ClassName" runat=server /></title>
<meta name="keywords" content='<CMS:ClassField Name="keyword" runat=server />'>
<meta name="description" content='<CMS:ClassField Name="Description" runat=server />'>
<CMS:Include ID="Include1" Path="/App_Templet/Default/Resources.html" runat=server />
</head>
<body>
<!--Header-->
<CMS:Include ID="Include2" Path="/App_Templet/Default/Header.html" runat=server />
<!--/Header-->
<div class="ct2_r wp cl">
  <div class="banner2 mb-10"><img width="980"  src="/update/yingyeting.jpg"></div>
  <!--breadcrumb-->
  <nav class="breadcrumb mb-10"> <a href="/" class="toHome">首页</a> <span class="to">to</span> <CMS:ClassField ID="ClassField2" Name="ClassName" runat=server /></nav>
  <!--/breadcrumb-->
  <div class="cl">
      <article class="mn cl mb-10">
      <section class="ucenter bk_1 bg1">
        <div class="title4">留言<em>Message</em></div>
        <section class="pd-20">
          <form method="post" action="">
            <div class="cl mb-10">
              <div class="inputbar cl">
                <label>&nbsp;&nbsp;&nbsp;&nbsp;</label>
                    <input type="radio" name="RadioGroup1" value="1" id="RadioGroup1_0">
                    咨询
                    <input type="radio" name="RadioGroup1" value="2" id="RadioGroup1_1">
                    投诉
                    <input type="radio" name="RadioGroup1" value="2" id="Radio1">
                    建议
                  <br>
                </p>
              </div>
            </div>
            <div class="cl mb-10">
              <div class="inputbar cl">
                <label for="massage_type" id="lbmassage_type">类型</label>
                <select style="massage_type" id="massage_type" name="">
                  <option value="水质">水质</option>
                  <option value="水压">水压</option>
                  <option value="抄表服务">抄表服务</option>
                  <option value="收费服务">收费服务</option>
                  <option value="管道维修">管道维修</option>
                  <option value="服务质量">服务质量</option>
                  <option value="报装服务">报装服务</option>
                  <option value="安装服务">安装服务</option>
                  <option value="综合">综合</option>
                  <option value="其它">其它</option>
                </select>
              </div>
            </div>
            <div class="cl mb-10">
              <div class="inputbar cl">
                <label for="massage_title" id="lbmassage_title">姓名</label>
                <input name="massage_title" type="text" id="massage_title" size="10" maxlength="" style="width:200px">
              </div>
            </div>
            <div class="cl mb-10">
              <div class="inputbar cl">
                <label for="massage_tel" id="lbmassage_tel">电话</label>
                <input name="massage_tel" type="text" id="massage_tel" size="10" maxlength="" style="width:200px">
              </div>
            </div>
            <div class="cl mb-10">
              <label for="massage_con" id="lbmassage_con">内容</label>
              <div class="inputbar cl">
                <textarea name="massage_con" cols="30" rows="5" id="massage_con" style="width:500px; height:120px"></textarea>
              </div>
            </div>
            <div style="padding-left:37px">
              <button class="btn primary" type="submit">留 言</button>
            </div>
          </form>
        </section>
        <section class="pd-20">
          <div class="bk_1 cl metlist">
            <p class="cl user_title"><span class="l maincolor">李小姐</span><span>[投诉] 服务质量</span><span class="time r">2013-6-10 08:48</span></p>
            <p class="mb-10">你们的客服热线如同虚设，打极都是话务员忙或无人接听，QQ交谈等了大半天都没响应，不想做这方面的服务或人手不够，就把它删了吧！其实我只想问一个很简单的问题，我的房子过户了，改供水户主名，需要什么手续？是否需新旧户主双主到场办理？</p>
            <p class="cl kefu_title"><span class="l maincolor">[5107]客服回复</span><span class="time r">回复时间：2013-6-9 12:26</span></p>
            <p>你好李小姐，你留下的电话号码是空号，我司无法致电给你。房子过户，仅需带新房产证，新产权人身份证，二样（原件，复印件各一份）到西江南路12号就可以办理。无需旧户主到现场。如果疑问请致电客服热线2828226，谢谢你的留言。</p>
          </div>
          <div class="bk_1 cl metlist">
            <p class="cl user_title"><span class="l maincolor">李小姐</span><span>[投诉] 服务质量</span><span class="time r">2013-6-10 08:48</span></p>
            <p class="mb-10">你们的客服热线如同虚设，打极都是话务员忙或无人接听，QQ交谈等了大半天都没响应，不想做这方面的服务或人手不够，就把它删了吧！其实我只想问一个很简单的问题，我的房子过户了，改供水户主名，需要什么手续？是否需新旧户主双主到场办理？</p>
            <p class="cl kefu_title"><span class="l maincolor">[5107]客服回复</span><span class="time r">回复时间：2013-6-9 12:26</span></p>
            <p>你好李小姐，你留下的电话号码是空号，我司无法致电给你。房子过户，仅需带新房产证，新产权人身份证，二样（原件，复印件各一份）到西江南路12号就可以办理。无需旧户主到现场。如果疑问请致电客服热线2828226，谢谢你的留言。</p>
          </div>
          <div class="pageNav"><span class="np">&lt;上一页</span> <a href="#">1</a><span class="mor">...</span><a href="#">3</a><a href="#">4</a> <b>5</b> <a href="#">6</a><a href="#">7</a><span class="mor">...</span><a href="#">10</a> <a href="#" class="f12">下一页&gt;</a></div>
        </section>
      </section>
    </article>
      <aside class="sd">
      <nav class="leftmenu2">
        <p id="leftmenu1"><a href="servers.html">水费查询</a></p>
        <p id="leftmenu2"><a href="Zjsf.aspx">网上缴费</a></p>
        <p id="leftmenu3"><a href="message.html">在线留言</a></p>
        <p id="leftmenu4"><a href="Zyewu.aspx">业务办理</a></p>
        <p id="leftmenu5"><a href="/ucenter/GetPassword.aspx">修改密码</a></p>
        <p id="leftmenu6"><a href="/ucenter/logout.aspx">注销</a></p>
      </nav>
    </aside>
  </div>
</div>
<!--Footer-->
<CMS:Include ID="Include3" Path="/App_Templet/Default/Footer.html" runat=server />
<!--/Footer-->
</body>
</html>