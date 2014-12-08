<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ROYcms.UI.Admin.Shop.Index" %>
<%@ Register src="Header.ascx" tagname="Header" tagprefix="Header" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>礼品商城</title>
<CMS:Include ID="Include1" Path="/App_Templet/Default/Resources.html" runat=server />
</head>
<body>
    <form id="form1" runat="server">
<!--Header-->
<Header:Header ID="Header1" runat="server" />
<!--/Header-->

<div class="boxwrap">
  <div class="left710">
   <!--Content-->
    <div class="main_box">
      <dl class="head green">
        <dt>购物商城</dt>
          
        <dd>
          <ul class="sub_nav">
            
            <li class="n1"><a href="goods/2.aspx">手机数码</a></li>
            
            <li class="n2"><a href="goods/14.aspx">电脑办公</a></li>
            
            <li class="n3"><a href="goods/19.aspx">家用电器</a></li>
            
          </ul>
        </dd>
      </dl>
      <div class="clear"></div>
      <div class="pro_list">
        <ul>
          
       <asp:Repeater ID="Repeater_admin" runat="server">
       <ItemTemplate>
          <li>
            <a class="pic" href="/Goods-<%#Eval("Id")%>.aspx" title="<%#Eval("goods_name")%>">
            <img src="<%#Eval("goods_thumb")%>" alt="<%#Eval("goods_name")%>" />
            </a>
            <div class="info">
              <a class="name" href="/Goods-<%#Eval("Id")%>.aspx" title="<%#Eval("goods_name")%>"><%#Eval("goods_name")%></a>
              <div class="price">
                <span>价格：</span>
                <strong>￥<%#Eval("shop_price")%>.00</strong>
              </div>
            </div>
          </li>
       </ItemTemplate>
       </asp:Repeater>
          
        </ul>
      </div>
      
    </div>
    <!--/Content-->
  </div>
  
  <div class="left264">
    <!--Sidebar-->
    <div class="sidebar">
      <h3>商品类别</h3>
      <ul class="navbar">
        
        <li>
          <h4><a href="goods/2.aspx">手机数码</a></h4>
          <div class="list">
            
            <a href="goods/11.aspx">智能手机</a>
            
            <a href="goods/12.aspx">数码相机</a>
            
            <a href="goods/13.aspx">存储卡</a>
            
          </div>
        </li>
        
        <li>
          <h4><a href="goods/14.aspx">电脑办公</a></h4>
          <div class="list">
            
            <a href="goods/15.aspx">笔记本</a>
            
            <a href="goods/16.aspx">超极本</a>
            
            <a href="goods/17.aspx">平板电脑</a>
            
            <a href="goods/18.aspx">外设产品</a>
            
          </div>
        </li>
        
        <li>
          <h4><a href="goods/19.aspx">家用电器</a></h4>
          <div class="list">
            
            <a href="goods/20.aspx">平板电视</a>
            
            <a href="goods/21.aspx">空调</a>
            
            <a href="goods/22.aspx">冰箱</a>
            
            <a href="goods/23.aspx">洗衣机</a>
            
            <a href="goods/24.aspx">烟机/灶具</a>
            
          </div>
        </li>
        
      </ul>
      <div class="clear"></div>
      <h3><a class="arrow" href="goods.aspx" title="查看更多">&gt;</a>推荐商品</h3>
      <div class="focus_list">
        <ul>
          
          <li>
            <a title="飞利浦彩电42PFL3320/T3" href="goods/show-40.aspx">
              <img src="upload/201210/21/small_201210210001069890.jpg" width="100" height="100" alt="飞利浦彩电42PFL3320/T3" />
              <span>飞利浦彩电42PFL3320/T3</span>
            </a>
          </li>
          
          <li>
            <a title="格力空调KFR-35GW/(35556)FNFa-3(镜面红)" href="goods/show-37.aspx">
              <img src="upload/201210/20/small_201210201055447111.jpg" width="100" height="100" alt="格力空调KFR-35GW/(35556)FNFa-3(镜面红)" />
              <span>格力空调KFR-35GW/(35556)FNFa-3(镜面红)</span>
            </a>
          </li>
          
          <li>
            <a title="东芝洗衣机XQG75-ESE" href="goods/show-34.aspx">
              <img src="upload/201210/20/small_201210201048503818.jpg" width="100" height="100" alt="东芝洗衣机XQG75-ESE" />
              <span>东芝洗衣机XQG75-ESE</span>
            </a>
          </li>
          
          <li>
            <a title="松下洗衣机XQG60-V63GS" href="goods/show-32.aspx">
              <img src="upload/201210/20/small_201210201044429301.jpg" width="100" height="100" alt="松下洗衣机XQG60-V63GS" />
              <span>松下洗衣机XQG60-V63GS</span>
            </a>
          </li>
          
          <li>
            <a title="老板烟灶套餐CXW-200-8210N+9B26N+802N" href="goods/show-30.aspx">
              <img src="upload/201210/20/small_201210202357569149.jpg" width="100" height="100" alt="老板烟灶套餐CXW-200-8210N+9B26N+802N" />
              <span>老板烟灶套餐CXW-200-8210N+9B26N+802N</span>
            </a>
          </li>
          
          <li>
            <a title="海尔油烟机CXW-219-JT30(SN)(T)" href="goods/show-29.aspx">
              <img src="upload/201210/20/small_201210201035354966.jpg" width="100" height="100" alt="海尔油烟机CXW-219-JT30(SN)(T)" />
              <span>海尔油烟机CXW-219-JT30(SN)(T)</span>
            </a>
          </li>
          
        </ul>
        <div class="clear"></div>
      </div>
      <h3><a class="arrow" href="goods.aspx" title="查看更多">&gt;</a>人气排行</h3>
      <ul class="rank_list">
        
        <li class="active">
        
          <span>10-20</span>
          <i class="num">1</i><a href="goods/show-40.aspx">飞利浦彩电42PFL3320/T3</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">2</i><a href="goods/show-37.aspx">格力空调KFR-35GW/(35556)FNFa-3(镜面红)</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">3</i><a href="goods/show-34.aspx">东芝洗衣机XQG75-ESE</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">4</i><a href="goods/show-32.aspx">松下洗衣机XQG60-V63GS</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">5</i><a href="goods/show-26.aspx">微软平板电脑Surface wWinRT-32GB Bndl SC ChnSimp Hdwr</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">6</i><a href="goods/show-30.aspx">老板烟灶套餐CXW-200-8210N+9B26N+802N</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">7</i><a href="goods/show-28.aspx">帅康烟灶套餐CXW-200-MD01+QA-019-B9</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">8</i><a href="goods/show-29.aspx">海尔油烟机CXW-219-JT30(SN)(T)</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">9</i><a href="goods/show-13.aspx">富士（FUJIFILM） FinePix SL245 数码相机叫板单反！24倍光变，一镜走天下！超有范</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">10</i><a href="goods/show-14.aspx">尼康（NIKON） Coolpix L310 便携数码相机（1408万像素 3寸屏 21倍光变 25mm广角 智能人像）</a>
        </li>
        
      </ul>
    </div>
    <!--/Sidebar-->
  </div>
</div>

<div class="clear"></div>

<!--Footer-->
<CMS:Include ID="Include3" Path="/App_Templet/Default/Footer.html" runat=server />
<!--/Footer-->
    </form>
</body>
</html>
