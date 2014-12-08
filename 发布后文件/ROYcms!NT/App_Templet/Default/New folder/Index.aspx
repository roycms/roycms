<%@ Page Language="C#"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>ROYcms网站管理系统 - _开源cms_NET开源_cms建站</title>
<CMS:Include ID="Include1" Path="/App_Templet/Default/Resources.html" runat=server />
<script type="text/javascript">
    $(function () {
        $("#focusNews").KinSlideshow();
    })
</script>
</head>
<body>
<!--Header-->
<CMS:Include ID="Include2" Path="/App_Templet/Default/Header.html" runat=server />
<!--/Header-->
<div class="boxwrap">
  <div class="left710">
    <div class="pad20">
      <!--Focus-->
      <div class="left300">
        <div id="focusNews" class="ifocus"> 
        
        <CMS:WebRepeater Type="52" Top=6 Tuijian=1 Ding=1 runat="server">
        <ItemTemplate>
       
        <a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'><%#Eval("title") %></a> 
        <img src='<%#Eval("pic") %>' alt='<%#Eval("title") %>' />
        </ItemTemplate>
        </CMS:WebRepeater>
        
        

        
        
        </div>
      </div>
      <!--/Focus-->
      <!--Top News-->
      <div class="right350 icnts">
        <h3 class="tit">
         <CMS:WebRepeater Type="52" Tuijian=1  runat="server">
        <ItemTemplate>
        <a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'><%#Eval("title") %></a> 
       
        </ItemTemplate>
        </CMS:WebRepeater>
        </h3>
        <ul class="list">
        <CMS:WebRepeater Type="52"  runat="server">
        <ItemTemplate>
        <li> <span>[<%#Eval("ChannelName") %>]</span> 
        <a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'><%#Eval("title") %></a> 
        </li>
        </ItemTemplate>
        </CMS:WebRepeater>

        </ul>
        <h3 class="tit">
                <CMS:WebRepeater Type="53" Tuijian=1  runat="server">
        <ItemTemplate>
        <a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'><%#Eval("title") %></a> 
       
        </ItemTemplate>
        </CMS:WebRepeater>
        
       
        
        </h3>
        <ul class="list last">
                <CMS:WebRepeater Type="53"  runat="server">
        <ItemTemplate>
        <li> <span>[<%#Eval("ChannelName") %>]</span> 
        <a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'><%#Eval("title") %></a> 
        </li>
        </ItemTemplate>
        </CMS:WebRepeater>
        </ul>
      </div>
      <!--/Top News-->
      <div class="clear"></div>
    </div>
    <!--Hot Goods-->
    <div class="clear"></div>
    <div class="igoods_box">
      <div class="igoods_list">
        <dl class="head">
          <dt>购物商城</dt>
          <dd>
            <ul class="sub_nav">
              <li class="n1"><a href="goods/2.html">手机数码</a></li>
              <li class="n2"><a href="goods/14.html">电脑办公</a></li>
              <li class="n3"><a href="goods/19.html">家用电器</a></li>
            </ul>
          </dd>
        </dl>
        <ul class="list">
          <li> <a class="pic" href="goods/show-40.html"><img src="upload/201210/21/small_201210210001069890.jpg" alt="飞利浦彩电42PFL3320/T3" /></a>
            <div class="info"> <a class="name" href="goods/show-40.html">飞利浦彩电42PFL3320/T3</a>
              <div class="price"> <span>价格：</span> <strong>￥3580.00</strong> </div>
            </div>
          </li>
          <li> <a class="pic" href="goods/show-37.html"><img src="upload/201210/20/small_201210201055447111.jpg" alt="格力空调KFR-35GW/(35556)FNFa-3(镜面红)" /></a>
            <div class="info"> <a class="name" href="goods/show-37.html">格力空调KFR-35GW/(35556)FNFa-3(镜面红)</a>
              <div class="price"> <span>价格：</span> <strong>￥3580.00</strong> </div>
            </div>
          </li>
          <li> <a class="pic" href="goods/show-34.html"><img src="upload/201210/20/small_201210201048503818.jpg" alt="东芝洗衣机XQG75-ESE" /></a>
            <div class="info"> <a class="name" href="goods/show-34.html">东芝洗衣机XQG75-ESE</a>
              <div class="price"> <span>价格：</span> <strong>￥5308.00</strong> </div>
            </div>
          </li>
          <li> <a class="pic" href="goods/show-32.html"><img src="upload/201210/20/small_201210201044429301.jpg" alt="松下洗衣机XQG60-V63GS" /></a>
            <div class="info"> <a class="name" href="goods/show-32.html">松下洗衣机XQG60-V63GS</a>
              <div class="price"> <span>价格：</span> <strong>￥3870.00</strong> </div>
            </div>
          </li>
          <li> <a class="pic" href="goods/show-30.html"><img src="upload/201210/20/small_201210202357569149.jpg" alt="老板烟灶套餐CXW-200-8210N+9B26N+802N" /></a>
            <div class="info"> <a class="name" href="goods/show-30.html">老板烟灶套餐CXW-200-8210N+9B26N+802N</a>
              <div class="price"> <span>价格：</span> <strong>￥10399.00</strong> </div>
            </div>
          </li>
          <li> <a class="pic" href="goods/show-29.html"><img src="upload/201210/20/small_201210201035354966.jpg" alt="海尔油烟机CXW-219-JT30(SN)(T)" /></a>
            <div class="info"> <a class="name" href="goods/show-29.html">海尔油烟机CXW-219-JT30(SN)(T)</a>
              <div class="price"> <span>价格：</span> <strong>￥1450.00</strong> </div>
            </div>
          </li>
          <li> <a class="pic" href="goods/show-28.html"><img src="upload/201210/20/small_201210202355364762.jpg" alt="帅康烟灶套餐CXW-200-MD01+QA-019-B9" /></a>
            <div class="info"> <a class="name" href="goods/show-28.html">帅康烟灶套餐CXW-200-MD01+QA-019-B9</a>
              <div class="price"> <span>价格：</span> <strong>￥2299.00</strong> </div>
            </div>
          </li>
          <li> <a class="pic" href="goods/show-26.html"><img src="upload/201210/20/small_201210202310110337.jpg" alt="微软平板电脑Surface wWinRT-32GB Bndl SC ChnSimp Hdwr" /></a>
            <div class="info"> <a class="name" href="goods/show-26.html">微软平板电脑Surface wWinRT-32GB Bndl SC ChnSimp Hdwr</a>
              <div class="price"> <span>价格：</span> <strong>￥4388.00</strong> </div>
            </div>
          </li>
        </ul>
      </div>
    </div>
    <!--/Hot Goods-->
  </div>
  <div class="left264">
    <!--Red Download-->
    <div class="idown_list">
      <h3>推荐资源</h3>
      <ul>
      
        <CMS:WebRepeater Type="53"  runat="server">
        <ItemTemplate>
        <li> 
        <a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'>
        <img border="0" alt='<%#Eval("title") %>' src='<%#Eval("pic") %>' />
        </a> 
        <a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'><%#Eval("title") %></a> 
        <br />
          <span class="date">更新：<%#Eval("TIME") %></span> <br />
          <a class="down" href='<%#Eval("ShowLink") %>'>下载</a> 
        </li>
        </ItemTemplate>
        </CMS:WebRepeater>
      

      </ul>
    </div>
    <!--/Red Download-->
    <!--Hot Goods-->
    <div class="isidebar">
      <h3>热门商品</h3>
      <div class="list">
        <ol>
          <li class="active" onmouseover="ToggleProps(this, 'active');"> <i class="num">1</i>
            <div class="photo"> <a title="飞利浦彩电42PFL3320/T3" href="goods/show-40.html"><img src="upload/201210/21/small_201210210001069890.jpg" alt="飞利浦彩电42PFL3320/T3"></a> </div>
            <div class="props">
              <p class="name"><a title="飞利浦彩电42PFL3320/T3" href="goods/show-40.html">飞利浦彩电42PFL3320/T3</a></p>
              <p class="price">¥3580.00</p>
              <p class="button"><a class="ibtn" href="goods/show-40.html">立即购买</a></p>
            </div>
          </li>
          <li onmousemove="ToggleProps(this, 'active');"> <i class="num">2</i>
            <div class="photo"> <a title="东芝洗衣机XQG75-ESE" href="goods/show-34.html"><img src="upload/201210/20/small_201210201048503818.jpg" alt="东芝洗衣机XQG75-ESE"></a> </div>
            <div class="props">
              <p class="name"><a title="东芝洗衣机XQG75-ESE" href="goods/show-34.html">东芝洗衣机XQG75-ESE</a></p>
              <p class="price">¥5308.00</p>
              <p class="button"><a class="ibtn" href="goods/show-34.html">立即购买</a></p>
            </div>
          </li>
          <li onmousemove="ToggleProps(this, 'active');"> <i class="num">3</i>
            <div class="photo"> <a title="微软平板电脑Surface wWinRT-32GB Bndl SC ChnSimp Hdwr" href="goods/show-26.html"><img src="upload/201210/20/small_201210202310110337.jpg" alt="微软平板电脑Surface wWinRT-32GB Bndl SC ChnSimp Hdwr"></a> </div>
            <div class="props">
              <p class="name"><a title="微软平板电脑Surface wWinRT-32GB Bndl SC ChnSimp Hdwr" href="goods/show-26.html">微软平板电脑Surface wWinRT-32GB Bndl SC ChnSimp Hdwr</a></p>
              <p class="price">¥4388.00</p>
              <p class="button"><a class="ibtn" href="goods/show-26.html">立即购买</a></p>
            </div>
          </li>
          <li onmousemove="ToggleProps(this, 'active');"> <i class="num">4</i>
            <div class="photo"> <a title="老板烟灶套餐CXW-200-8210N+9B26N+802N" href="goods/show-30.html"><img src="upload/201210/20/small_201210202357569149.jpg" alt="老板烟灶套餐CXW-200-8210N+9B26N+802N"></a> </div>
            <div class="props">
              <p class="name"><a title="老板烟灶套餐CXW-200-8210N+9B26N+802N" href="goods/show-30.html">老板烟灶套餐CXW-200-8210N+9B26N+802N</a></p>
              <p class="price">¥10399.00</p>
              <p class="button"><a class="ibtn" href="goods/show-30.html">立即购买</a></p>
            </div>
          </li>
          <li onmousemove="ToggleProps(this, 'active');"> <i class="num">5</i>
            <div class="photo"> <a title="帅康烟灶套餐CXW-200-MD01+QA-019-B9" href="goods/show-28.html"><img src="upload/201210/20/small_201210202355364762.jpg" alt="帅康烟灶套餐CXW-200-MD01+QA-019-B9"></a> </div>
            <div class="props">
              <p class="name"><a title="帅康烟灶套餐CXW-200-MD01+QA-019-B9" href="goods/show-28.html">帅康烟灶套餐CXW-200-MD01+QA-019-B9</a></p>
              <p class="price">¥2299.00</p>
              <p class="button"><a class="ibtn" href="goods/show-28.html">立即购买</a></p>
            </div>
          </li>
          <li onmousemove="ToggleProps(this, 'active');"> <i class="num">6</i>
            <div class="photo"> <a title="富士（FUJIFILM） FinePix SL245 数码相机叫板单反！24倍光变，一镜走天下！超有范" href="goods/show-13.html"><img src="upload/201210/20/small_201210201028435944.jpg" alt="富士（FUJIFILM） FinePix SL245 数码相机叫板单反！24倍光变，一镜走天下！超有范"></a> </div>
            <div class="props">
              <p class="name"><a title="富士（FUJIFILM） FinePix SL245 数码相机叫板单反！24倍光变，一镜走天下！超有范" href="goods/show-13.html">富士（FUJIFILM） FinePix SL245 数码相机叫板单反！24倍光变，一镜走天下！超有范</a></p>
              <p class="price">¥1388.00</p>
              <p class="button"><a class="ibtn" href="goods/show-13.html">立即购买</a></p>
            </div>
          </li>
          <li onmousemove="ToggleProps(this, 'active');"> <i class="num">7</i>
            <div class="photo"> <a title="尼康（NIKON） Coolpix L310 便携数码相机（1408万像素 3寸屏 21倍光变 25mm广角 智能人像）" href="goods/show-14.html"><img src="upload/201210/20/small_201210201030215722.jpg" alt="尼康（NIKON） Coolpix L310 便携数码相机（1408万像素 3寸屏 21倍光变 25mm广角 智能人像）"></a> </div>
            <div class="props">
              <p class="name"><a title="尼康（NIKON） Coolpix L310 便携数码相机（1408万像素 3寸屏 21倍光变 25mm广角 智能人像）" href="goods/show-14.html">尼康（NIKON） Coolpix L310 便携数码相机（1408万像素 3寸屏 21倍光变 25mm广角 智能人像）</a></p>
              <p class="price">¥1299.00</p>
              <p class="button"><a class="ibtn" href="goods/show-14.html">立即购买</a></p>
            </div>
          </li>
          <li onmousemove="ToggleProps(this, 'active');"> <i class="num">8</i>
            <div class="photo"> <a title="三星（SAMSUNG）NP3445VC-S01CN 14英寸笔记本电脑" href="goods/show-17.html"><img src="upload/201210/20/small_201210201051542905.jpg" alt="三星（SAMSUNG）NP3445VC-S01CN 14英寸笔记本电脑"></a> </div>
            <div class="props">
              <p class="name"><a title="三星（SAMSUNG）NP3445VC-S01CN 14英寸笔记本电脑" href="goods/show-17.html">三星（SAMSUNG）NP3445VC-S01CN 14英寸笔记本电脑</a></p>
              <p class="price">¥3099.00</p>
              <p class="button"><a class="ibtn" href="goods/show-17.html">立即购买</a></p>
            </div>
          </li>
          <li onmousemove="ToggleProps(this, 'active');"> <i class="num">9</i>
            <div class="photo"> <a title="华为（HUAWEI）Ascend P1 XL U9200E 3G手机（黑）WCDMA/GSM" href="goods/show-12.html"><img src="upload/201210/20/small_201210201027425186.jpg" alt="华为（HUAWEI）Ascend P1 XL U9200E 3G手机（黑）WCDMA/GSM"></a> </div>
            <div class="props">
              <p class="name"><a title="华为（HUAWEI）Ascend P1 XL U9200E 3G手机（黑）WCDMA/GSM" href="goods/show-12.html">华为（HUAWEI）Ascend P1 XL U9200E 3G手机（黑）WCDMA/GSM</a></p>
              <p class="price">¥2199.00</p>
              <p class="button"><a class="ibtn" href="goods/show-12.html">立即购买</a></p>
            </div>
          </li>
          <li onmousemove="ToggleProps(this, 'active');"> <i class="num">10</i>
            <div class="photo"> <a title="东芝（TOSHIBA）C805-S51B 14英寸笔记本电脑（i5-3210M 2G 500G HD 7610M 1G独显 USB3.0 Win7）天籁黑" href="goods/show-18.html"><img src="upload/201210/20/small_201210201033194448.jpg" alt="东芝（TOSHIBA）C805-S51B 14英寸笔记本电脑（i5-3210M 2G 500G HD 7610M 1G独显 USB3.0 Win7）天籁黑"></a> </div>
            <div class="props">
              <p class="name"><a title="东芝（TOSHIBA）C805-S51B 14英寸笔记本电脑（i5-3210M 2G 500G HD 7610M 1G独显 USB3.0 Win7）天籁黑" href="goods/show-18.html">东芝（TOSHIBA）C805-S51B 14英寸笔记本电脑（i5-3210M 2G 500G HD 7610M 1G独显 USB3.0 Win7）天籁黑</a></p>
              <p class="price">¥3599.00</p>
              <p class="button"><a class="ibtn" href="goods/show-18.html">立即购买</a></p>
            </div>
          </li>
        </ol>
      </div>
    </div>
    <!--Hot Goods-->
  </div>
</div>
<div class="clear"></div>
<div class="boxwrap" style="border-top:0;">
  <!--Red Photo-->
  <div class="iphoto_list">
    <dl class="head">
      <dt>图片分享</dt>
      <dd>
        <ul class="sub_nav">
          <li class="n1"><a href="photo/25.html">3C数码</a></li>
          <li class="n2"><a href="photo/26.html">家居生活</a></li>
          <li class="n3"><a href="photo/27.html">旅游摄影</a></li>
          <li class="n4"><a href="photo/28.html">气质美女</a></li>
          <li class="n5"><a href="photo/29.html">趣味休闲</a></li>
        </ul>
      </dd>
    </dl>
    <div class="clear"></div>
    <div class="list">
      <ul>
              <CMS:WebRepeater Type="44" Top=12  runat="server">
        <ItemTemplate>

        <li class='a<%# Container.ItemIndex+1%>'> 
        <img border="0" alt='<%#Eval("title") %>' src='<%#Eval("pic") %>' />
         <a href='<%#Eval("ShowLink") %>' title='<%#Eval("title") %>'><strong><%#Eval("title") %></strong><br>
          <span><%#Eval("title") %></span><br> 查看详情</a><i class="absbg"></i> </li>
        </ItemTemplate>
        </CMS:WebRepeater>
      

      </ul>
    </div>
  </div>
  <!--/Red Photo-->
</div>
<div class="clear"></div>
<div class="boxwrap" style="border-top:0; padding-top:20px; background-color:#FFF">
  <!--Hot Goods2-->
  <div class="clear"></div>
  <div class="igoods_box">
    <div class="igoods_list" style="width:960px;">
      <dl class="head">
        <dt style="background-color:#F00">购物商城</dt>
        <dd>
          <ul class="sub_nav">
            <li class="n1"><a href="goods/2.html">手机数码</a></li>
            <li class="n2"><a href="goods/14.html">电脑办公</a></li>
            <li class="n3"><a href="goods/19.html">家用电器</a></li>
          </ul>
        </dd>
      </dl>
      <ul class="list" style="width:960px;">
        <li style="width:142px;"> <a class="pic" href="goods/show-40.html"><img src="upload/201210/21/small_201210210001069890.jpg" alt="飞利浦彩电42PFL3320/T3" /></a>
          <div class="info"> <a class="name" href="goods/show-40.html">飞利浦彩电42PFL3320/T3</a>
            <div class="price"> <span>价格：</span> <strong>￥3580.00</strong> </div>
          </div>
        </li>
        <li style="width:142px;"> <a class="pic" href="goods/show-40.html"><img src="upload/201210/21/small_201210210001069890.jpg" alt="飞利浦彩电42PFL3320/T3" /></a>
          <div class="info"> <a class="name" href="goods/show-40.html">飞利浦彩电42PFL3320/T3</a>
            <div class="price"> <span>价格：</span> <strong>￥3580.00</strong> </div>
          </div>
        </li>
        <li style="width:142px;"> <a class="pic" href="goods/show-40.html"><img src="upload/201210/21/small_201210210001069890.jpg" alt="飞利浦彩电42PFL3320/T3" /></a>
          <div class="info"> <a class="name" href="goods/show-40.html">飞利浦彩电42PFL3320/T3</a>
            <div class="price"> <span>价格：</span> <strong>￥3580.00</strong> </div>
          </div>
        </li>
        <li style="width:142px;"> <a class="pic" href="goods/show-40.html"><img src="upload/201210/21/small_201210210001069890.jpg" alt="飞利浦彩电42PFL3320/T3" /></a>
          <div class="info"> <a class="name" href="goods/show-40.html">飞利浦彩电42PFL3320/T3</a>
            <div class="price"> <span>价格：</span> <strong>￥3580.00</strong> </div>
          </div>
        </li>
        <li style="width:142px;"> <a class="pic" href="goods/show-40.html"><img src="upload/201210/21/small_201210210001069890.jpg" alt="飞利浦彩电42PFL3320/T3" /></a>
          <div class="info"> <a class="name" href="goods/show-40.html">飞利浦彩电42PFL3320/T3</a>
            <div class="price"> <span>价格：</span> <strong>￥3580.00</strong> </div>
          </div>
        </li>
        <li style="width:142px;"> <a class="pic" href="goods/show-40.html"><img src="upload/201210/21/small_201210210001069890.jpg" alt="飞利浦彩电42PFL3320/T3" /></a>
          <div class="info"> <a class="name" href="goods/show-40.html">飞利浦彩电42PFL3320/T3</a>
            <div class="price"> <span>价格：</span> <strong>￥3580.00</strong> </div>
          </div>
        </li>
        <li style="width:142px;"> <a class="pic" href="goods/show-40.html"><img src="upload/201210/21/small_201210210001069890.jpg" alt="飞利浦彩电42PFL3320/T3" /></a>
          <div class="info"> <a class="name" href="goods/show-40.html">飞利浦彩电42PFL3320/T3</a>
            <div class="price"> <span>价格：</span> <strong>￥3580.00</strong> </div>
          </div>
        </li>
        <li style="width:142px;"> <a class="pic" href="goods/show-40.html"><img src="upload/201210/21/small_201210210001069890.jpg" alt="飞利浦彩电42PFL3320/T3" /></a>
          <div class="info"> <a class="name" href="goods/show-40.html">飞利浦彩电42PFL3320/T3</a>
            <div class="price"> <span>价格：</span> <strong>￥3580.00</strong> </div>
          </div>
        </li>
        <li style="width:142px;"> <a class="pic" href="goods/show-40.html"><img src="upload/201210/21/small_201210210001069890.jpg" alt="飞利浦彩电42PFL3320/T3" /></a>
          <div class="info"> <a class="name" href="goods/show-40.html">飞利浦彩电42PFL3320/T3</a>
            <div class="price"> <span>价格：</span> <strong>￥3580.00</strong> </div>
          </div>
        </li>
        <li style="width:142px;"> <a class="pic" href="goods/show-40.html"><img src="upload/201210/21/small_201210210001069890.jpg" alt="飞利浦彩电42PFL3320/T3" /></a>
          <div class="info"> <a class="name" href="goods/show-40.html">飞利浦彩电42PFL3320/T3</a>
            <div class="price"> <span>价格：</span> <strong>￥3580.00</strong> </div>
          </div>
        </li>
        <li style="width:142px;"> <a class="pic" href="goods/show-40.html"><img src="upload/201210/21/small_201210210001069890.jpg" alt="飞利浦彩电42PFL3320/T3" /></a>
          <div class="info"> <a class="name" href="goods/show-40.html">飞利浦彩电42PFL3320/T3</a>
            <div class="price"> <span>价格：</span> <strong>￥3580.00</strong> </div>
          </div>
        </li>
        <li style="width:142px;"> <a class="pic" href="goods/show-40.html"><img src="upload/201210/21/small_201210210001069890.jpg" alt="飞利浦彩电42PFL3320/T3" /></a>
          <div class="info"> <a class="name" href="goods/show-40.html">飞利浦彩电42PFL3320/T3</a>
            <div class="price"> <span>价格：</span> <strong>￥3580.00</strong> </div>
          </div>
        </li>
      </ul>
    </div>
  </div>
  <!--/Hot Goods2-->
  <!--Links-->
  <div class="ilink_list">
    <h3><span class="graylink"><a href="http://www.roycms.cn/link.html">更多...</a></span>友情链接</h3>
    <p class="txt"> <a target="_blank" href="http://www.tiexue.net/default.htm">铁血军事</a> | <a target="_blank" href="http://www.160.com/default.htm">驱动人生</a> | <a target="_blank" href="http://www.mydrivers.com/default.htm">驱动之家</a> | <a target="_blank" href="http://www.chinaz.com/default.htm">站长之家</a> | <a target="_blank" href="http://www.admin5.com/default.htm">站长网</a> | <a target="_blank" href="http://www.tgbus.com/default.htm">电玩巴士</a> | <a target="_blank" href="http://www.leiphone.com/default.htm">雷锋网</a> | <a target="_blank" href="../tech.ku6.com/default.htm">酷6科技</a> | <a target="_blank" href="http://www.itchaguan.com/default.htm">IT茶馆</a> | <a target="_blank" href="http://www.ccw.com.cn/default.htm">计世网</a> | <a target="_blank" href="http://www.mittrchinese.com/default.htm">麻省理工科技创业</a> | <a target="_blank" href="http://www.ylmf.net/default.htm">雨林木风</a> | <a target="_blank" href="http://www.ckplayer.com/default.htm">ckplayer视频播放器</a> | <a target="_blank" href="www.mymzz.com">移动站长</a></p>
  </div>
  <!--/Links-->
</div>
<!--Footer-->
<CMS:Include ID="Include3" Path="/App_Templet/Default/Footer.html" runat=server />
<!--/Footer-->
</body>
</html>
