<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ROYcms.Blog.Web.App_Blog.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>roycms</title>
<link href="basic.css" rel="stylesheet" type="text/css" />
</head>

<body>
<div id="top">
  <div class="m1"><a href="/"><img src="logo.gif" border="0" /></a></div>
  <div class="m2">
    <div style="margin-top:5px;">
 <form action="/index.php" method="get">
<input name="key" class="input1" type="text">&nbsp;&nbsp;<input name="submit" value="空间搜索" type="submit" class="input2" ><input name="module" value="user" type="hidden"><input name="act" value="search" type="hidden">
</form>
    </div>
  </div>
</div>
<div class="bian"></div> 
<div id="main">
<div class="right">
    <div class="r1" id="showMain">
        <form name="form1" id="form1" action="/?module=user&amp;act=login" method="post" onsubmit="return checkfrm(this)" target="_self">

      <div class="c0">登录到你的空间</div>
      <div class="c1">
        <div style="float:left; width:40px; height:24px; line-height:24px;">用户名</div>
        <div style="float:left; width:175px; height:24px; line-height:24px;">
          <input id="username" name="username" style="width: 175px;" type="text">
        </div>
      </div>
      <div class="c1">

        <div style="float:left; width:40px; height:24px; line-height:24px; margin-top:10px;">密  码</div>
        <div style="float:left; width:175px; height:24px; line-height:24px; margin-top:10px;">
          <input name="password" id="password" value="" style="width: 175px;" type="password">
        </div>
      </div>
      <div class="c2">
        <div style="float:right;"><a href="http://pass.kingsoft.com/ksgweb/jsp/login/passwordmail.jsp">忘记密码</a></div>
        <input type="checkbox" name="checkbox" value="checkbox" style="border:none;" />

        下次自动登录</div>
      <div class="c3">
        <div style="float:right;"><a href="/?module=user&amp;act=register" target="_self">立即注册</a></div>
        <input name="loginsubmit" type="submit" value="登录" style="width:60px; height:24px;" />
      </div></form>
          </div>
    
    <div class="r2" style="display:none">
      <div style="float:right; width:165px;height:42px;overflow:hidden;display:none" id="tbNews">

<ul>
<li style="width:142px;word-break:nowrap;white-space:nowrap;overflow:hidden">
 - <a href="http://my.iciba.com/blog-3622740-417625.html">【“午夜惊魂”】--- 夜里的黑衣男子</a><br></li><li style="width:142px;word-break:nowrap;white-space:nowrap;overflow:hidden"> - <a href="http://my.iciba.com/blog-3533323-417621.html">寺、庙、祠、观、庵的区别</a><br> - <a href="http://my.iciba.com/blog-4111979-417615.html">中国四大震撼人心的废墟</a><br></li><li style="width:142px;word-break:nowrap;white-space:nowrap;overflow:hidden"> - <a href="http://my.iciba.com/blog-1903539-417606.html">求助高手翻译：公司简介</a><br> - <a href="http://my.iciba.com/blog-3641222-417591.html">【励志佳句】...(090923)</a><br></li><li style="width:142px;word-break:nowrap;white-space:nowrap;overflow:hidden"> - <a href="http://my.iciba.com/blog-3233738-417589.html">爱要有礼才完美！</a><br> - <a href="http://my.iciba.com/blog-3159062-417585.html">天天读图: 首尔一日游 (9.24)</a><br></li><li style="width:142px;word-break:nowrap;white-space:nowrap;overflow:hidden"> - <a href="http://my.iciba.com/blog-4162159-417579.html">谁可以帮我找几篇关于海洋奉献的英文诗歌或者散文</a><br> - <a href="http://my.iciba.com/blog-3641222-417578.html">亚运献歌英文歌词首曝光</a><br></li><li style="width:142px;word-break:nowrap;white-space:nowrap;overflow:hidden"> - <a href="http://my.iciba.com/blog-4088325-417576.html">笑掉大牙的小图</a><br></li>

</ul></div>
      <div style="width:74px;">日志总篇数:<br />
        </div>
    </div>
	<div class="r3">
      <div class="t"><div style="float:left;widht:70px">最新日志(<span style="font-family:Georgia;text-align:center" id="cknum"></span>)</div><div style="float:left:width:150px;font-weight:normal;font-size:12px;text-align:right"><a href="/new1.html">更多>></a></div></div>
      <div class="c">

           <ul>
                     <li style="overflow:hidden; white-space:nowrap; text-overflow:ellipsis;width:247px;">- <a href="http://my.iciba.com/blog-3622740-417625.html">【“午夜惊魂”】--- 夜里的黑衣男子</a><span> | <span><a href="http://my.iciba.com/u-3622740.html">styoyo529</a></span></li>
                    <li style="overflow:hidden; white-space:nowrap; text-overflow:ellipsis;width:247px;">- <a href="http://my.iciba.com/blog-3533323-417621.html">寺、庙、祠、观、庵的区别</a><span> | <span><a href="http://my.iciba.com/u-3533323.html">cathyji</a></span></li>
                    <li style="overflow:hidden; white-space:nowrap; text-overflow:ellipsis;width:247px;">- <a href="http://my.iciba.com/blog-4111979-417615.html">中国四大震撼人心的废墟</a><span> | <span><a href="http://my.iciba.com/u-4111979.html">bcgrz01</a></span></li>

                    <li style="overflow:hidden; white-space:nowrap; text-overflow:ellipsis;width:247px;">- <a href="http://my.iciba.com/blog-1903539-417606.html">求助高手翻译：公司简介</a><span> | <span><a href="http://my.iciba.com/u-1903539.html">一克拉の泪</a></span></li>
                    <li style="overflow:hidden; white-space:nowrap; text-overflow:ellipsis;width:247px;">- <a href="http://my.iciba.com/blog-3641222-417591.html">【励志佳句】...(090923)</a><span> | <span><a href="http://my.iciba.com/u-3641222.html">Joshua_Yang</a></span></li>
                    <li style="overflow:hidden; white-space:nowrap; text-overflow:ellipsis;width:247px;">- <a href="http://my.iciba.com/blog-3233738-417589.html">爱要有礼才完美！</a><span> | <span><a href="http://my.iciba.com/u-3233738.html">Holy_Che</a></span></li>

                    <li style="overflow:hidden; white-space:nowrap; text-overflow:ellipsis;width:247px;">- <a href="http://my.iciba.com/blog-3159062-417585.html">天天读图: 首尔一日游 (9.24)</a><span> | <span><a href="http://my.iciba.com/u-3159062.html">xiaonuanlumao</a></span></li>
                    <li style="overflow:hidden; white-space:nowrap; text-overflow:ellipsis;width:247px;">- <a href="http://my.iciba.com/blog-4162159-417579.html">谁可以帮我找几篇关于海洋奉献的英文诗歌或者散文</a><span> | <span><a href="http://my.iciba.com/u-4162159.html"></a></span></li>
                    <li style="overflow:hidden; white-space:nowrap; text-overflow:ellipsis;width:247px;">- <a href="http://my.iciba.com/blog-3641222-417578.html">亚运献歌英文歌词首曝光</a><span> | <span><a href="http://my.iciba.com/u-3641222.html">Joshua_Yang</a></span></li>

                    <li style="overflow:hidden; white-space:nowrap; text-overflow:ellipsis;width:247px;">- <a href="http://my.iciba.com/blog-4088325-417576.html">笑掉大牙的小图</a><span> | <span><a href="http://my.iciba.com/u-4088325.html">我的名字叫小有</a></span></li>
                  </ul>     
      </div>
    </div>
    <div class="r3">
      <div class="t">精彩日志推荐</div>

      <div class="c">
        <ul>
                <li>- <a href="http://my.iciba.com/blog-4019933-392634.html">百科：地道的英语IQ测验题</a><span> | <a href="http://my.iciba.com/u-4019933.html">释迦牟尼学英语</a></span></li>
                <li>- <a href="http://my.iciba.com/blog-3870878-392418.html">史上最强双关语“脑残”</a><span> | <a href="http://my.iciba.com/u-3870878.html">Henrymvp</a></span></li>

                <li>- <a href="http://my.iciba.com/blog-3749565-293397.html">教你一眼就能识破单词的意思</a><span> | <a href="http://my.iciba.com/u-3749565.html">demon123456789</a></span></li>
	        <li>- <a href="http://my.iciba.com/blog-2094108-289563.html">七大原则让你的文章更加出彩</a><span> | <a href="http://my.iciba.com/u-2094108.html">nevergo</a></span></li>  
		<li>- <a href="http://my.iciba.com/blog-3393222-286960.html">突破听译笔译与口译的方略</a><span> | <a href="http://my.iciba.com/u-3393222.html">海边的小贝壳</a></span></li>

                <li>- <a href="http://my.iciba.com/blog-4082299-392101.html">美国街头常用的五星级句子</a><span> | <a href="http://my.iciba.com/u-4082299.html">MasterAdonis</a></span></li>
                 <li>- <a href="http://my.iciba.com/blog-2108665-289552.html">研究：“离婚”会让人容颜变老</a><span> | <span><a href="http://my.iciba.com/u-2108665.html">长风落日</a></span></li>
                <li>- <a href="http://my.iciba.com/blog-4034311-389483.html">误区：英文影片最易误解的词</a><span> | <a href="http://my.iciba.com/u-4034311.html">枕着星光晒月亮</a></span></li>

                <li>- <a href="http://my.iciba.com/blog-3899514-291916.html">如何将“谢谢”说的多姿多彩</a><span> | <span><a href="http://my.iciba.com/u-3899514.html">乐其俗</a></span></li>
                <li>- <a href="http://my.iciba.com/blog-4077852-389781.html">如何高效地激活你的英语</a><span> | <a href="http://my.iciba.com/u-4077852.html">娜嗒纱</a></span></li>
         </ul>			  		        </div>

    </div>
    <div class="r4">
      <div class="t">空间活跃排行榜</div>
      <div class="c">
        <div class="b1">
          <div class="r">
          
            <div class="name"><a href="http://my.iciba.com/u-.html"></a></div>访问量：</div>
          <div class="l" style="width:60px;height:60px;overflow:hidden"><span class="l" style="width:60px;height:60px;overflow:hidden"><a href="http://my.iciba.com/u-.html"><img src="http://photo.sl.iciba.com/images/photo/d4/1d/d41d8cd98f00b204e9800998ecf8427e.gif" width="60" border="0" onerror="ImgError(this,'images/cn/defalut_pp.jpg')"/></a></span></div>

        </div>
		<ul>
				</ul>
		</div>
    </div>
        <div class="r6">
      <div class="t">英语名师日志</div>
      <div class="c">

        <ul>
          <li><a href="http://my.iciba.com/chenke">新东方陈科</a></li>
          <li><a href="http://my.iciba.com/meixue">新东方梅雪</a></li>
          <li><a href="http://my.iciba.com/wangjiangtao"> 新东方王江涛 </a></li>
          <li><a href="http://my.iciba.com/liuyinan">新东方刘一男</a></li>
          <li><a href="http://my.iciba.com/lijian">新东方李剑</a></li>

		  <li><a href="http://my.iciba.com/u-3060792.html">新航道颜炜</a></li>
          <li><a href="http://my.iciba.com/u-3060794.html">新航道李鑫</a></li>
		  <li><a href="http://my.iciba.com/u-3060790.html">新航道张登</a></li>
          <li><a href="http://my.iciba.com/u-3061369.html">世纪雅思kim</a></li>
		  <li><a href="http://my.iciba.com/blog-3052228-97574.html">查看更多教师&gt;&gt;</a></li>
        </ul>

      </div>
	  <div style=" clear:left;"></div>
    </div>		      
    <div class="r5">
      <div class="t" style="display:none">
        <div style="float:right;"><a href="javascript:refresh();" target="_self">刷新一下</a></div>
        <span></span>在线词友</div>
      <div class="c">

      <!--[online]-->
   	 </div>
    </div>
  </div>


<div class="left">
    <div><script language="javascript">
var widths=624;
var heights=170;
var counts=4;
img1=new Image ();img1.src='images/01.jpg';
img2=new Image ();img2.src='images/02.jpg';
img3=new Image ();img3.src='images/03.jpg';
img4=new Image ();img4.src='images/04.jpg';
img5=new Image ();img5.src='images/01.jpg';
img6=new Image ();img6.src='images/02.jpg';
url1=new Image ();url1.src='images/03.jpg';
url2=new Image ();url2.src='images/04.jpg';
url3=new Image ();url3.src='images/01.jpg';
url4=new Image ();url4.src='images/02.jpg';
url5=new Image ();url5.src='images/03.jpg';
url6=new Image ();url6.src='images/04.jpg';
//网页地址
var nn=1;
var key=0;
function change_img()
{if(key==0){key=1;}
else if(document.all)
{document.getElementById("pic").filters[0].Apply();document.getElementById("pic").filters[0].Play(duration=2);}
eval('document.getElementById("pic").src=img'+nn+'.src');
eval('document.getElementById("url").href=url'+nn+'.src');
for (var i=1;i<=counts;i++){document.getElementById("xxjdjj"+i).className='axx';}
document.getElementById("xxjdjj"+nn).className='bxx';
nn++;if(nn>counts){nn=1;}
tt=setTimeout('change_img()',4000);}
function changeimg(n){nn=n;window.clearInterval(tt);change_img();}
document.write('<style>');
document.write('.axx{padding:1px 7px;border-left:#cccccc 1px solid;}');
document.write('a.axx:link,a.axx:visited{text-decoration:none;color:#fff;line-height:12px;font:9px sans-serif;background-color:#666;}');
document.write('a.axx:active,a.axx:hover{text-decoration:none;color:#fff;line-height:12px;font:9px sans-serif;background-color:#999;filter:}');
document.write('.bxx{padding:1px 7px;border-left:#cccccc 1px solid;}');
document.write('a.bxx:link,a.bxx:visited{text-decoration:none;color:#fff;line-height:12px;font:9px sans-serif;background-color:#D34600;}');
document.write('a.bxx:active,a.bxx:hover{text-decoration:none;color:#fff;line-height:12px;font:9px sans-serif;background-color:#D34600;}');
document.write('</style>');
document.write('<div style="width:'+widths+'px;height:'+heights+'px;overflow:hidden;text-overflow:clip;">');
document.write('<div><a id="url"><img id="pic" style="border:0px;filter:progid:dximagetransform.microsoft.wipe(gradientsize=1.0,wipestyle=4, motion=forward)" width='+widths+' height='+heights+' /></a></div>');
document.write('<div style="filter:alpha(style=1,opacity=10,finishOpacity=70);-moz-opacity:0.7;background: #888888;width:100%-2px;text-align:right;top:-12px;position:relative;margin:1px;height:12px;padding:0px;margin:0px;border:0px;">');
for(var i=1;i<counts+1;i++){document.write('<a href="javascript:changeimg('+i+');" id="xxjdjj'+i+'" class="axx" target="_self">'+i+'</a>');}
document.write('</div></div>');
change_img();
</script>		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  </div>
    <div class="l1">
     <div class="t"><a href="http://e.iciba.com/space.php?uid=436510&do=thread&id=1"><font color="red">公告：ROYCMS22日上线 邀请大家抢先激活账号</font></a> <sup><img src="http://e.iciba.com/image/hot2.gif" /></sup></div>

      <div class="c">
        <ul>
          <li>- <a href="http://my.iciba.com/blog-3993766-383752.html">印第安纳真人版越狱大逃亡</a><span> | <a href="http://my.iciba.com/u-2108665.html">长风落日</a></span></li>
          <li>- <a href="http://my.iciba.com/blog-3772214-370586.html">F1车王舒马赫宣布放弃复出</a><span> | <span><a href="http://my.iciba.com/u-3993766.html">メ花小錯</a></span></li> 
          <li>- <a href="http://my.iciba.com/blog-4077852-389778.html">商务英语：十种职场“潜规则”</a><span> | <a href="http://my.iciba.com/u-4077852.html">娜嗒纱</a></span></li>

          <li>- <a href="http://my.iciba.com/blog-3927109-382869.html">百科：2009最新流行雷人语录</a><span> | <span><a href="http://my.iciba.com/u-3927109.html">Emma_dyj</a></span></li>
           <li>- <a
href="http://my.iciba.com/blog-3155985-300174.html">揭秘：全英文环境就能学好英语吗</a><span> | <a href="http://my.iciba.com/u-3155985.html">词霸007</a></span></li>
            <li>- <a href="http://my.iciba.com/blog-3336287-360872.html">你对妈妈的子宫还有印象吗</a><span> | <a href="http://my.iciba.com/u-3336287.html">克里斯蒂亚诺</a></span></li>

          <li>- <a href="http://my.iciba.com/blog-3952864-394997.html">独家：金喜善首次公开女儿的照片</font></a><span> | <a href="http://my.iciba.com/u-3952864.html">词霸大黄蜂</a></span></li>   
          <li>- <a href="http://my.iciba.com/blog-3000138-303322.html">大学英语四级阅读常见“信号词”</a><span> | <a href="http://my.iciba.com/u-3000138.html">lk9055</a></span></li>
          <li>- <a href="http://my.iciba.com/blog-4002756-359616.html">如何做到五官并用学英语 </a><span> | <a href="http://my.iciba.com/u-4002756.html">寒冰20080212</a></span></li>

          <li>- <a href="http://my.iciba.com/blog-3758387-360385.html">如何让写作的措辞更优雅</a><span> | <span><a href="http://my.iciba.com/u-3758387.html">zbaby13</a></span></li>
        </ul>
        <div class="line"></div>
      </div>	 		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		  		      </div>
    <div class="l1">
       <div class="t">名师讲堂：<a href="http://my.iciba.com/blog-3333332-355712.html">老罗回答：什么样的男人是优秀的</a></div>

      <div class="c">
        <ul>
          <li>- <a href="http://my.iciba.com/u-3053142.html">李剑</a>&nbsp;&nbsp;&nbsp;<a href="http://my.iciba.com/blog-3053142-233900.html">考研大纲词汇真经：背单词常见问题</a></li>
          <li>- <a href="http://my.iciba.com/blog-3030181.html">周雷</a>&nbsp;&nbsp;&nbsp;<a href="http://my.iciba.com/blog-3030181-192809.html">事后诸葛：2008年12月四级作文范文</a></li>
	   <li>- <a href="http://my.iciba.com/u-3045977.html">王江涛</a>&nbsp;&nbsp;&nbsp;<a href="http://my.iciba.com/blog-3045977-184550.html">2009年研究生考试9篇必背范文</a></li>

           <li>- <a href="http://my.iciba.com/u-3053138.html">刘一男</a>&nbsp;&nbsp;&nbsp;<a href="http://my.iciba.com/blog-3053138-184552.html">中字先形后音与西字先音后形</a></li> 
          <li>- <a href="http://my.iciba.com/u-3060794.html">李鑫</a>&nbsp;&nbsp;&nbsp;<a href="http://my.iciba.com/blog-3060794-97370.html">雅思口语应试策略和训练方法</a></li>
          <li>- <a href="http://my.iciba.com/u-3060792.html">颜炜</a>&nbsp;&nbsp;&nbsp;<a href="http://my.iciba.com/blog-3060792-201446.html">2009年雅思写作趋势及写作高分技巧</a></li>
          <li>- <a href="http://my.iciba.com/u-3030189.html">赵建昆</a>&nbsp;&nbsp;&nbsp;<a href="http://my.iciba.com/blog-3030189-176722.html">2008年6月四级考试真题-听力卷</a></li>

          <li>- <a href="http://my.iciba.com/u-3053147.html">梅雪</a>&nbsp;&nbsp;&nbsp;<a href="http://my.iciba.com/blog-3053147-216341.html">学英语一样要有像小沈阳的模仿力</a></li>
        </ul>
        <div style="clear:left;"></div>
      </div>			  		  		  		  		  		  		      </div>
    <div class="l2">
     <div class="t">名师空间</div>

<div class="c">
<script language="JavaScript">
<!--
today=new Date();
aliang=today.getTime();
function rnd() {
    ia=1234;
    ic=3456;
    im=5678;
    aliang = (aliang*ia+ic) % im;
    return aliang/(im*1.0);
};
function rand(number) {
    return Math.ceil(rnd()*number);
};
for(i=1;i<=1;i++) {
myNum=(rand(3));

if(myNum == 1) document.write("<div class='u1'><div class='r'><div class='name'><a href='http://my.iciba.com/u-3333332.html'>罗永浩</a></div>2001年至2006年在新东方学校任教。2006年6月辞去新东方的工作，同年8月创立博客网站“牛博网” 。目前，老罗已和朋友们建立了一所英语培训学校“老罗培训”。</div><div class='l'><a href='http://my.iciba.com/u-3333332.html'><img src='http://attach.sl.iciba.com/images/thread/f1/80/f180ccb27fc4bf25ca2d6ccc3b6e91ca.jpg' width='120' height='150' border='0' /></a></div></div><div class='u1'><div class='r'><div class='name'><a href='http://my.iciba.com/zhaojiankun'>赵建昆</a></div>北京新东方优秀的大学英语四级教师，主教四级听力部分，全国公共英语四级和五级听力部分。用积极的态度、清晰的思路、超强的双语能力和独特的个人风格征服数万学员。</div><div class='l'><a href='http://my.iciba.com/zhaojiankun'><img src='images/cn/space_zhaojiankun1.jpg'  width='120' height='150' border='0'/></a></div></div>");

if(myNum == 2 || myNum == 3) document.write("<div class='u1'><div class='r'><div class='name'><a href='http://my.iciba.com/blog-3333332-233118.html'>许可/许岑</a></div>许岑，老罗培训美国听力口语主讲。北影毕业，英国波恩茅斯大学影视传媒管理硕士。许可，老罗英语培训听力口语部主管，中戏毕业，后赴哥伦比亚大学攻读电影导演。</div><div class='l'><a href='http://my.iciba.com/blog-3333332-233118.html'><img src='http://attach.sl.iciba.com/images/thread/5d/40/5d40cc9c9f24c6f337417d75eae730c0.jpg' width='120' height='150' border='0' /></a></div></div><div class='u1'><div class='r'><div class='name'><a href='http://my.iciba.com/zenglijuan'>曾丽娟</a></div>上海环球雅思培训中心听力、口语首席主讲。精通雅思听说读写各科教学，具有非常丰富的教学经验和深厚的学术功底。资料准备全面、更新快速，善于捕捉考试动态。</div><div class='l'><a href='http://my.iciba.com/zenglijuan'><img src='images/space_zenglijuan.jpg'  width='120' height='150' border='0'/></a></div></div>");
};
//-->
</script>
  <div style="clear:left;"></div>
</div>		  		  		  		  		  		  		      </div>
    <div class="l2">
      <div class="t">空间精选</div>
      <div class="c">
	          <div class="u2"><a href="http://my.iciba.com/blog-3098828.html"><img src="http://attach.sl.iciba.com/images/thread/07/86/0786d89d5cf7782b8c1d639125811747.jpg" border="0" width="60" height="60" /></a><br><a href="http://my.iciba.com/u-3098828.html">itshyorish</a></div>

        <div class="u2"><a href="http://my.iciba.com/u-3138546.html"><img src="http://attach.sl.iciba.com/images/thread/37/cc/37ccdf9e5b102078e4883c78e5dccd1a.jpg" width="60" height="60" border="0"/></a><br />
        <a href="http://my.iciba.com/u-3138546.html">我好喜欢词霸</a></div>
        <div class="u2"><a href="http://my.iciba.com/u-3643168.html"><img src="http://attach.sl.iciba.com/images/thread/2f/bf/2fbf0347260308859dddb8d8c764077d.gif" width="60" height="60" border="0"/></a><br />
          <a href="http://my.iciba.com/u-3643168.html">winichase</a></div>
        <div class="u2"><a href="http://my.iciba.com/u-3170028.html"><img src="http://attach.sl.iciba.com/images/thread/39/c1/39c1ad6d5a7d43122251396500a95886.jpg"  width="60" height="60" border="0"/></a><br />
        <a href="http://my.iciba.com/u-3170028.html">依依y_一</a></div>
        <div class="u2"><a href="http://my.iciba.com/blog-3022793.html"><img src="http://attach.sl.iciba.com/images/thread/1a/3b/1a3bc3ed2b98825693778e6428767811.jpg"  width="60" height="60" border="0"/></a><br />

          <a href="http://my.iciba.com/blog-3022793.html">原来就是你</a></div>
        <div class="u2" style="margin-right:0;"><a href="http://my.iciba.com/u-3238259.html"><img src="http://attach.sl.iciba.com/images/thread/c8/ab/c8ab1591d14b0c0a288acf7a41cc7048.jpg"  width="60" height="60" border="0"/></a><br />
          <a href="http://my.iciba.com/u-3238259.html">Eric♡</a></div>
        <div style="clear:left;"></div>
      </div>		  		  		  		  		  		  		  		  		  		  		  		  		  		      </div>
    <div class="l3">
      <div class="t" style="margin-right:18px; width:294px;">优秀日记</div>

      <div class="c">
        <div class="u1">
          <div class="r">
            <div class="name"><a href="http://my.iciba.com/blog-3393222-286962.html">如何做个好翻译</a></div>
            很多人以为翻译就是熟练掌握一门外语，对它存在诸多误解……</div>
          <div class="l"><a href="http://my.iciba.com/blog-3393222-286962.html"><img src="http://attach.sl.iciba.com/images/thread/21/0f/210ffd4d0a5e2e0f4ea99ccc9f205717.gif"  width="86" height="66" border="0"/></a></div>
        </div>
        <div style="clear:left;"></div>

        <ul>
	  <li>- <a href="http://my.iciba.com/blog-1594497-286453.html">经验点滴：英语学习的五大妙法</a><span> | <span><a href="http://my.iciba.com/u-1594497.html">Jakey1973</a></span></li>
          <li>- <a href="http://my.iciba.com/blog-2240740-145897.html">突破听译笔译与口译的方略</a><span> | <a href="http://my.iciba.com/u-2240740.html">Candyyu</a></span></li>
          <li>- <a href="http://my.iciba.com/blog-3857420-286062.html">2010年考研英语暑期备战全攻略</a><span> | <span><a href="http://my.iciba.com/u-3857420.html">外教先锋</a></span></li>

          <li>- <a href="http://my.iciba.com/blog-3739556-286074.html">指点迷津： 美国待客的方式</a><span> | <a href="http://my.iciba.com/u-3739556.html">舍我其谁倩</a></span></li>
        </ul>
      </div>    </div>
    <div class="l3">
      <div class="t">学习笔记</div>

      <div class="c">
        <div class="u1">
          <div class="r">
            <div class="name"><a href="http://my.iciba.com/blog-3185433-285523.html">不同地方人心目中的地图</a></div>
            每个人、每个地区的人，都对地球有着不同的解释...</div>
          <div class="l"><a href="http://my.iciba.com/blog-3185433-285523.html"><img src="http://attach.sl.iciba.com/images/thread/84/ae/84aeb62b81cab5d0e6635ecea300a7a1.jpg" width="86" height="66" border="0"/></a></div>
        </div>
        <div style="clear:left;"></div>

        <ul>
	  <li>- <a href="http://my.iciba.com/blog-3880996-286001.html">白骨精法则：职场MM必读26个字母</a><span> | <span><a href="http://my.iciba.com/u-3880996.html">完美契约</a></span></li>
          <li>- <a href="http://my.iciba.com/blog-150188-300110.html">支招：工作中怎样向别人请求帮助</a><span> | <a href="http://my.iciba.com/u-150188.html">缇拉米苏</a></span></li>
          <li>- <a href="http://my.iciba.com/blog-965919-137439.html">妙招提供：应对英语四六级短文听力</a><span> | <a href="http://my.iciba.com/u-965919.html">garoson</a></span></li>

          <li>- <a href="http://my.iciba.com/blog-3000145-300109.html">世博会吉祥物 “海宝”亮相日本</a><span> | <span><a href="http://my.iciba.com/u-3000145.html">lavivi</a></span></li>
        </ul>
      </div>	  		      </div>
    <div style="clear:left;"></div>
  </div>
  
  <div id="footer"><a href="http://web.iciba.com/adv/index.htm" target="_blank">在线广告</a> | <a href="http://web.iciba.com/wap.html" target="_blank">roycms</a> | <a href="http://web.iciba.com/sitemap.html" target="_blank">网站地图</a> | <a href="http://web.iciba.com/adv/iciba.htm" target="_blank">关于roycms</a> | <a href="http://sl.iciba.com/" onclick="return AddFavorite('http://sl.iciba.com','ROYCMS_互动的程序学习社区网站');" rel="sidebar" id="btn" title="ROYCMS_互动的程序学习社区网站">加入收藏</a> <br />
  &copy; 2009 <a href="http://www.kingsoft.com/" target="_blank">roycms</a> roycms 京ICP备06025896号 <span>找朋友、<a href="http://my.iciba.com">做程序</a>，来ROYCMS！</span></div>
</div>
<script>var _kds2_p = 243;</script><script src="http://goto.www.iciba.com/kds2/kds2_record.js" type="text/javascript" charset="utf-8"></script><noscript><img width="0" height="0" src="http://counter.kds.iciba.com/kds2_userinfo_record.php?p=243" style="border:none"></noscript>

<script type="text/javascript">
function checkfrm(f){if($("#username").val().length==0){alert('用户名不能为空！');return false;}if($("#password").val().length==0){alert('密码不能为空！');return false;}}
$(function() {
	$('#tbNews').jdNewsScroll({divWidth:166,divHeight:40,fontSize:'10.5pt'});
	var min = 326933-Math.floor(Math.random()*10);var max = 326948;
	if(min<0)min=0;
	setInterval(countNum,1000);
	function countNum()
	{
		if(min>=max)min = max;
		if(min>=max)return false;
		min++;
		$('#cknum').html(min);
	}
});
</script>
<script type="text/javascript">
var gaJsHost = (("https:" == document.location.protocol) ? "https://ssl." : "http://www.");
document.write(unescape("%3Cscript src='" + gaJsHost + "google-analytics.com/ga.js' type='text/javascript'%3E%3C/script%3E"));
</script>
<script type="text/javascript">
var pageTracker = _gat._getTracker("UA-6103165-1");
pageTracker._trackPageview();
</script>
</body>
</html>
