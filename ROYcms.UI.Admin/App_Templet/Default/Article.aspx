<%@ Page Language="C#" %>
<!DOCTYPE HTML>
<!--[if lt IE 7]><html class="no-js lt-ie9 lt-ie8 lt-ie7"><![endif]-->
<!--[if IE 7]><html class="no-js lt-ie9 lt-ie8"><![endif]-->
<!--[if IE 8]><html class="no-js lt-ie9"><![endif]-->
<!--[if gt IE 8]><!--><html class="no-js"><!--<![endif]-->

<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=7" />
<title><CMS:WebField ID="WebField2" Name="title" runat=server /></title>
<meta name="keywords" content='<CMS:WebField ID="WebField93" Name="keyword" runat=server />'>
<meta name="description" content='<CMS:WebField ID="WebField91" Name="zhaiyao" runat=server />'>
<CMS:Include ID="Include1" Path="/App_Templet/Default/Resources.html" runat=server />
</head>
<body>
<!--Header-->
<CMS:Include ID="Include2" Path="/App_Templet/Default/Header.html" runat=server />
<!--/Header-->
<div class="ct2_r wp cl">
  <div class="banner2 mb-10"><img width="980" src="/update/banner_company.jpg"></div>
  <!--breadcrumb-->
  <nav class="breadcrumb mb-10"> <a href="/" class="toHome">首页</a> <span class="to">to</span> <CMS:ClassField ID="ClassField882" Name="ClassName" runat=server /></nav>
  <!--/breadcrumb-->
  <div class="cl">
    <article class="mn cl mb-10">
      <section class="bk_1 bg1 content">
        <div class="title4"><center><CMS:WebField ID="WebField4" Name="title" runat=server /></center></div>
             <center>
                 作者：<CMS:WebField ID="WebField1" Name="author" runat=server />  
                 时间：<CMS:WebField ID="WebField3" Name="time" runat=server />   
                 浏览数：<CMS:WebField ID="WebField6" Name="hits" runat=server />   
                 <CMS:Hot runat=server />
             </center>
        <div class="newsdetal">
        <CMS:WebField ID="WebField5" Name="contents" runat=server />
        </div>
      </section>
    </article>
    <aside class="sd">
      <nav class="leftmenu">
        <p><a href="news.html">公司新闻</a></p>
        <p><a href="news2.html">行业新闻</a></p>
      </nav>
    </aside>
  </div>
</div>
<!--Footer-->
<CMS:Include ID="Include3" Path="/App_Templet/Default/Footer.html" runat=server />
<!--/Footer-->

</body>
</html>