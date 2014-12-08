<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Goods.aspx.cs" Inherits="ROYcms.UI.Admin.Shop.Goods" %>
<%@ Register src="Header.ascx" tagname="Header" tagprefix="Header" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title><%=Model.goods_name %><%=Model.goods_sn %>/ROYcms内容管理系统</title>
<CMS:Include ID="Include1" Path="/App_Templet/Default/Resources.html" runat=server />
<script type="text/javascript">
    $(function () {
        bindDigg('../default.htm', '28');
        tabs('#goodsTabs', 'click');
        //智能浮动层
        $("#tab_head").smartFloat();
    });
</script>
</head>

<body>
<!--Header-->
<Header:Header ID="Header1" runat="server" />
<!--/Header-->

<div class="boxwrap">
  <div class="left710">
   <!--Left-->
    <div class="main_box">
      
      <dl class="head green">
        <dt>购物商城</dt>
        <dd>
          <span>当前位置：<a href="../index.aspx">首页 </a>&gt;<a href="../goods.aspx">购物商城</a>&nbsp;&gt;&nbsp;<a href="19/1.aspx">家用电器</a>&nbsp;&gt;&nbsp;<a href="24/1.aspx">烟机/灶具</a></span>
        </dd>
      </dl>
      <div class="line20"></div>
      
      <!--商品图片-->
      <div class="left294">
        <!--幻灯片开始-->
        <div class="pictureDIV">
          <div id="preview" class="spec-preview">
            <span class="jqzoom"><img /></span>
          </div>
          <!--缩图开始-->
          <div class="spec-scroll">
            <a class="prev">&lt;</a>
            <a class="next">&gt;</a>
            <div class="items">
              <ul>
                 <asp:Repeater ID="Repeater_Gallery" runat="server">
                         <ItemTemplate> 
                          <li>
                          <a href="javascript:;"><img bimg="<%#Eval("URL")%>" src="<%#Eval("thumb_url")%>" onmousemove="preview(this);" /></a>
                          </li>
                         </ItemTemplate>
                </asp:Repeater>
                
              </ul>
            </div>
          </div>
          <!--缩图结束-->
        </div>
        <!--幻灯片结束-->
      </div>
       <!--/商品图片-->
      
      <!--商品属性-->
      <div class="pro-attr right356">
        <h1><%=Model.goods_name %></h1>
        <div class="pro-items">
          <dl>
            <dt>商品货号：</dt>
            <dd><%=Model.goods_sn %></dd>
          </dl>
          <dl>
            <dt>库存情况：</dt>
            <dd><%=Model.goods_number %>件</dd>
          </dl>
          <dl>
            <dt>销售价格：</dt>
            <dd><b class="red">￥<%=Model.shop_price %>.00</b></dd>
          </dl>
          <dl>
            <dt>会员价格：</dt>
            <dd>
              
              登录可见
              
            </dd>
          </dl>
          <dl>
            <dt>上架时间：</dt>
            <dd><%=Model.add_time %></dd>
          </dl>
          <!--扩展属性开始-->
          
          <!--扩展属性结束-->
        </div>
        <div class="pro-btns">
		  <div class="input-box">
              购买数量：
              <input name="goods_id" id="goods_id" type="hidden" value="<%=Model.Id %>" />
              <input type="text" name="goods_quantity" id="goods_quantity" value="1" class="txt" style="ime-mode:disabled" />
          </div>
          <div class="btn-box">
            
            <a href="javascript:void(0);" class="add" onclick="CartAdd(this, 0);">加入购物车</a>
            <a href="javascript:void(0);" class="buy" onclick="CartAdd(this, 1);">立即购买</a>
            
          </div>
          
        </div>
        <div class="line10"></div>
        <!--分享-->
        <!-- JiaThis Button BEGIN --> 
     
        <!-- JiaThis Button END -->
      
        <!--/分享-->
      </div>
      <!--/商品属性-->
      
      <div class="line20"></div>
      <!--商品介绍-->
      <div id="goodsTabs">
        <div id="tab_head" class="pro-tabs">
          <ul>
            <li><a class="current" href="javascript:;">商品介绍</a></li>
            <li><a href="javascript:;">商品评论</a></li>
          </ul>
        </div>
        <div class="line10"></div>
        <div class="tab_inner entry" style="display:block;">

        <%=Model.goods_desc %>

          <div class="line10"></div>
          <!--顶踩-->
            <div class="newdigg" id="newdigg">
            <div id="digg_good" class="diggbox digg_good">
              <div class="digg_act">顶一下</div>
              <div class="digg_num">(4)</div>
              <div class="digg_percent">
        
                <div class="digg_percent_bar"><span style="width:66.7_25"></span></div>
                <div class="digg_percent_num">66.7%</div>
              </div>
            </div>
            <div id="digg_bad" class="diggbox digg_bad">
              <div class="digg_act">踩一下</div>
              <div class="digg_num">(2)</div>
              <div class="digg_percent">
        
                <div class="digg_percent_bar"><span style="width:33.3_25"></span></div>
                <div class="digg_percent_num">33.3%</div>
              </div>
            </div>
          </div>
          <!--/项踩-->
        </div>
        
        <div class="tab_inner">
          <!--评论-->
          <!--取得评论总数-->
  <link rel="stylesheet" href="../css/validate.css" />
  <link rel="stylesheet" href="../css/pagination.css" />
  <script type="text/javascript" src="../scripts/jquery/jquery.form.js"></script>
  <script type="text/javascript" src="../scripts/jquery/jquery.validate.min.js"></script>
	  <script type="text/javascript" src="../scripts/jquery/messages_cn.js"></script>
      <script type="text/javascript" src="../scripts/jquery/jquery.pagination.js"></script>
      <script type="text/javascript">
          $(function () {
              //初始化评论列表
              //AjaxPageList('#comment_list', '#pagination', 10, 3, '../tools/submit_ajax.ashx@action=comment_list&article_id=28', '../templates/green/images/user_avatar.png');
              //初始化发表评论表单
              //AjaxInitForm('comment_form', 'btnSubmit', 1);
          });
      </script>
      <div class="comment_box">
        <h3 class="base_tit"><span><a href="#Add">发表评论</a></span>共有3访客发表了评论</h3>
        <ol id="comment_list" class="comment_list">
          <p style="line-height:35px;">暂无评论，快来抢沙发吧！</p>
          <!--
          <li>
            <div class="floor">#3</div>
            <div class="avatar">
              <img src="images/user_avatar.png" width="36" height="36" />
            </div>
            <div class="inner">
              <p>你这个评论的模块是怎么实现的，能不能写一下哇，觉得很好看</p>
              <div class="meta">
                <span class="blue">匿名用户</span>
                <span class="time">2012-08-13 00:45</span>
              </div>
            </div>
            <div class="answer">
              <div class="meta">
                <span class="right time">2012-11-15 00:21:05</span>
                <span class="blue">管理员回复：</span>
              </div>
              <p>我晕，我什么时候购买博主的模板了？？首先声明的是 我的微之恋是用大前端的html页面，HTML页面我也是Ctrl+s进行另存为下来的，然后我用wordpress的程序改了改就发布了，很多bug我也懒得改，功能也没有大前段的主题功能强大，也就可以认为一个演示版吧，首先说的是本人木有购买，再者更没有购买后无耻进行发布，我只是靠的自己的双手收获我想要的成功，我想这就是开源精神吧？我把自己写的代码进行开源有何不可？况且我只是另存为了3个页面其他的PHP程序还不是都是我写的，大家爱用就用，不爱用也不要冷嘲热讽好不好?拿着我的免费主题说我的坏话，我真的很无语！</p>
            </div>
          </li>
          -->
        </ol>
      </div>
      <div class="line20"></div>
      <div id="pagination" class="flickr"></div><!--放置页码-->
      <div class="comment_add">
        <h3 class="base_tit">我来说几句吧<a name="Add"></a></h3>
        <form id="comment_form" name="comment_form" url="/tools/submit_ajax.ashx?action=comment_add&article_id=28">
        <div class="comment_editor">
          <textarea id="txtContent" name="txtContent" class="input" style="width:658px;height:70px;"></textarea>
        </div>
        <div class="subcon">
          <input id="btnSubmit" name="submit" class="btn right" type="submit" value="提交评论（Ctrl+Enter）" />
          <span>验证码：</span>
          <input id="txtCode" name="txtCode" type="text" class="input small required" onkeydown="if(event.ctrlKey&&event.keyCode==13){document.getElementById('btnSubmit').click();return false};"  />
          <a href="javascript:;" onclick="ToggleCode(this, '../tools/verify_code.ashx');return false;"><img src="../tools/verify_code.ashx" width="80" height="22" style="vertical-align:middle;" /> 看不清楚？</a>
        </div>
        </form>
      </div>
          <!--/评论-->
        </div>
        
      </div>
      <!--/商品介绍-->
      
      <!--同类推荐-->
      <div class="related">
        <h3 class="base_tit">本类推荐</h3>
        <ul class="img_list">
          
          <li><a title="飞利浦彩电42PFL3320/T3" href="show-40.aspx"><img alt="飞利浦彩电42PFL3320/T3" src="../upload/201210/21/small_201210210001069890.jpg"><span>飞利浦彩电42PFL3320/T3</span></a></li>
           
          <li><a title="格力空调KFR-35GW/(35556)FNFa-3(镜面红)" href="show-37.aspx"><img alt="格力空调KFR-35GW/(35556)FNFa-3(镜面红)" src="../upload/201210/20/small_201210201055447111.jpg"><span>格力空调KFR-35GW/(35556)FNFa-3(镜面红)</span></a></li>
           
          <li><a title="东芝洗衣机XQG75-ESE" href="show-34.aspx"><img alt="东芝洗衣机XQG75-ESE" src="../upload/201210/20/small_201210201048503818.jpg"><span>东芝洗衣机XQG75-ESE</span></a></li>
           
          <li><a title="松下洗衣机XQG60-V63GS" href="show-32.aspx"><img alt="松下洗衣机XQG60-V63GS" src="../upload/201210/20/small_201210201044429301.jpg"><span>松下洗衣机XQG60-V63GS</span></a></li>
           
          <li><a title="老板烟灶套餐CXW-200-8210N+9B26N+802N" href="show-30.aspx"><img alt="老板烟灶套餐CXW-200-8210N+9B26N+802N" src="../upload/201210/20/small_201210202357569149.jpg"><span>老板烟灶套餐CXW-200-8210N+9B26N+802N</span></a></li>
           
          <li><a title="海尔油烟机CXW-219-JT30(SN)(T)" href="show-29.aspx"><img alt="海尔油烟机CXW-219-JT30(SN)(T)" src="../upload/201210/20/small_201210201035354966.jpg"><span>海尔油烟机CXW-219-JT30(SN)(T)</span></a></li>
           
          <li><a title="微软平板电脑Surface wWinRT-32GB Bndl SC ChnSimp Hdwr" href="show-26.aspx"><img alt="微软平板电脑Surface wWinRT-32GB Bndl SC ChnSimp Hdwr" src="../upload/201210/20/small_201210202310110337.jpg"><span>微软平板电脑Surface wWinRT-32GB Bndl SC ChnSimp Hdwr</span></a></li>
           
          <li><a title="索尼（SONY）Tablet SGPT112CN/S 9.4英寸平板电脑（Android 3.2 32GB 蓝牙 WIFI 双摄像头 扩展插槽 银）" href="show-22.aspx"><img alt="索尼（SONY）Tablet SGPT112CN/S 9.4英寸平板电脑（Android 3.2 32GB 蓝牙 WIFI 双摄像头 扩展插槽 银）" src="../upload/201210/20/small_201210201013178785.jpg"><span>索尼（SONY）Tablet SGPT112CN/S 9.4英寸平板电脑（Android 3.2 32GB 蓝牙 WIFI 双摄像头 扩展插槽 银）</span></a></li>
           
          <li><a title="闪迪至尊高速Micro-SDHC移动存储卡" href="show-21.aspx"><img alt="闪迪至尊高速Micro-SDHC移动存储卡" src="../upload/201210/20/small_201210201011047116.jpg"><span>闪迪至尊高速Micro-SDHC移动存储卡</span></a></li>
           
          <li><a title="索尼（SONY）SVT13117ECS 13.3英寸超极本（i5-3317U 4G 500G+32GSSD 蓝牙 USB3.0 WIN7 银）" href="show-20.aspx"><img alt="索尼（SONY）SVT13117ECS 13.3英寸超极本（i5-3317U 4G 500G+32GSSD 蓝牙 USB3.0 WIN7 银）" src="../upload/201210/20/small_201210201036462871.jpg"><span>索尼（SONY）SVT13117ECS 13.3英寸超极本（i5-3317U 4G 500G+32GSSD 蓝牙 USB3.0 WIN7 银）</span></a></li>
           
        </ul>
      </div>
      <!--/同类推荐-->
      
    </div>
    <!--/Left-->
  </div>
  
  <div class="left264">
    <!--Sidebar-->
    <div class="sidebar">
      <h3>商品类别</h3>
      <ul class="navbar">
        
        <li>
          <h4><a href="2.aspx">手机数码</a></h4>
          <div class="list">
            
            <a href="11.aspx">智能手机</a>
            
            <a href="12.aspx">数码相机</a>
            
            <a href="13.aspx">存储卡</a>
            
          </div>
        </li>
        
        <li>
          <h4><a href="14.aspx">电脑办公</a></h4>
          <div class="list">
            
            <a href="15.aspx">笔记本</a>
            
            <a href="16.aspx">超极本</a>
            
            <a href="17.aspx">平板电脑</a>
            
            <a href="18.aspx">外设产品</a>
            
          </div>
        </li>
        
        <li>
          <h4><a href="19.aspx">家用电器</a></h4>
          <div class="list">
            
            <a href="20.aspx">平板电视</a>
            
            <a href="21.aspx">空调</a>
            
            <a href="22.aspx">冰箱</a>
            
            <a href="23.aspx">洗衣机</a>
            
            <a href="24.aspx" class="current">烟机/灶具</a>
            
          </div>
        </li>
        
      </ul>
      <div class="clear"></div>
      <h3><a class="arrow" href="../goods.aspx" title="查看更多">&gt;</a>推荐商品</h3>
      <div class="focus_list">
        <ul>
          
          <li>
            <a title="飞利浦彩电42PFL3320/T3" href="show-40.aspx">
              <img src="../upload/201210/21/small_201210210001069890.jpg" width="100" height="100" alt="飞利浦彩电42PFL3320/T3" />
              <span>飞利浦彩电42PFL3320/T3</span>
            </a>
          </li>
          
          <li>
            <a title="格力空调KFR-35GW/(35556)FNFa-3(镜面红)" href="show-37.aspx">
              <img src="../upload/201210/20/small_201210201055447111.jpg" width="100" height="100" alt="格力空调KFR-35GW/(35556)FNFa-3(镜面红)" />
              <span>格力空调KFR-35GW/(35556)FNFa-3(镜面红)</span>
            </a>
          </li>
          
          <li>
            <a title="东芝洗衣机XQG75-ESE" href="show-34.aspx">
              <img src="../upload/201210/20/small_201210201048503818.jpg" width="100" height="100" alt="东芝洗衣机XQG75-ESE" />
              <span>东芝洗衣机XQG75-ESE</span>
            </a>
          </li>
          
          <li>
            <a title="松下洗衣机XQG60-V63GS" href="show-32.aspx">
              <img src="../upload/201210/20/small_201210201044429301.jpg" width="100" height="100" alt="松下洗衣机XQG60-V63GS" />
              <span>松下洗衣机XQG60-V63GS</span>
            </a>
          </li>
          
          <li>
            <a title="老板烟灶套餐CXW-200-8210N+9B26N+802N" href="show-30.aspx">
              <img src="../upload/201210/20/small_201210202357569149.jpg" width="100" height="100" alt="老板烟灶套餐CXW-200-8210N+9B26N+802N" />
              <span>老板烟灶套餐CXW-200-8210N+9B26N+802N</span>
            </a>
          </li>
          
          <li>
            <a title="海尔油烟机CXW-219-JT30(SN)(T)" href="show-29.aspx">
              <img src="../upload/201210/20/small_201210201035354966.jpg" width="100" height="100" alt="海尔油烟机CXW-219-JT30(SN)(T)" />
              <span>海尔油烟机CXW-219-JT30(SN)(T)</span>
            </a>
          </li>
          
        </ul>
        <div class="clear"></div>
      </div>
      <h3><a class="arrow" href="../goods.aspx" title="查看更多">&gt;</a>人气排行</h3>
      <ul class="rank_list">
        
        <li class="active">
        
          <span>10-20</span>
          <i class="num">1</i><a href="show-40.aspx">飞利浦彩电42PFL3320/T3</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">2</i><a href="show-37.aspx">格力空调KFR-35GW/(35556)FNFa-3(镜面红)</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">3</i><a href="show-34.aspx">东芝洗衣机XQG75-ESE</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">4</i><a href="show-32.aspx">松下洗衣机XQG60-V63GS</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">5</i><a href="show-26.aspx">微软平板电脑Surface wWinRT-32GB Bndl SC ChnSimp Hdwr</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">6</i><a href="show-30.aspx">老板烟灶套餐CXW-200-8210N+9B26N+802N</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">7</i><a href="show-28.aspx">帅康烟灶套餐CXW-200-MD01+QA-019-B9</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">8</i><a href="show-29.aspx">海尔油烟机CXW-219-JT30(SN)(T)</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">9</i><a href="show-13.aspx">富士（FUJIFILM） FinePix SL245 数码相机叫板单反！24倍光变，一镜走天下！超有范</a>
        </li>
        
        <li>
        
          <span>10-20</span>
          <i class="num">10</i><a href="show-14.aspx">尼康（NIKON） Coolpix L310 便携数码相机（1408万像素 3寸屏 21倍光变 25mm广角 智能人像）</a>
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
</body>
</html>
