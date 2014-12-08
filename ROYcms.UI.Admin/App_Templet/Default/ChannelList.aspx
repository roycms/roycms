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
  <div class="banner2 mb-10"><img width="980"  src="../update/banner_company.jpg"></div>
  <!--breadcrumb-->
  <nav class="breadcrumb mb-10"> <a href="/" class="toHome">首页</a> <span class="to">to</span> <CMS:ClassField ID="ClassField2" Name="ClassName" runat=server /></nav>
  <!--/breadcrumb-->
  <div class="cl">
        <article class="mn cl mb-10">
      <section class="bk_1 bg1">
        <div class="title4"><CMS:ClassField ID="ClassField3" Name="ClassName" runat=server /><em></em></div>
        <ul class="textlist2">

               <CMS:WebPageRepeater ID="WebPageRepeater" Type="{type}" PageSize=3 FiledOrder="time DESC" runat="server">
                <ItemTemplate>
                <li class="cl"><span class="l">·<a target="_blank" href='<%#Eval("ShowLink") %>'>
                    <%#Eval("title") %>
                    </a></span><span class="time r"><%#Eval("TIME") %></span></li>
                </ItemTemplate>
                </CMS:WebPageRepeater>
        </ul>
     
      </section>
    </article>
    <aside class="sd">
      <nav class="leftmenu">
        <p><a class="cur" href="news.html">公司新闻</a></p>
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