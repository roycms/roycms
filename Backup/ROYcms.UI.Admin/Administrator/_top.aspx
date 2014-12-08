<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator__top" %>
<!DOCTYPE HTML>
<HTML>
<HEAD>
<TITLE></TITLE>
<META content="text/html; charset=utf-8" http-equiv=Content-Type>
<LINK rel=stylesheet type=text/css href="/administrator/css/style.css">
</HEAD>
<BODY>
<SCRIPT language=JavaScript src="js/alt.js"></SCRIPT>
<TABLE border=0 cellSpacing=0 cellPadding=0 width="100%">
  <TBODY>
    <TR>
      <TD id="t1" width=230>
      <IMG src="/administrator/images/gc.gif" alt="ROYcms!NT 最佳ASP.NET开源CMS" width=230 height=71 border=0 usemap="#Map">
      </TD>
      <TD id="t2" vAlign=top background=images/admin-top2.gif width=15>
      <a href="#"><IMG id="im"src="/administrator/images/admin-top1.gif" alt="点击展开左侧" border="0"  onClick="shleft();" ></a>
      </TD>
      <TD nowrap background=images/admin-top2.gif>
      <A target=_blank href="http://update.ROYcms.cn/">
      <IMG title=点击这里修复登录错误 border=0 align=absMiddle  src="/administrator/images/admin-ico.gif">
      </A>
      欢迎 
      <B><FONT class=enfont2  color=#ff4800><% =Session["administrator"]%></FONT></B>
      登录到 <FONT class=enfont><CMS:WebConfig Name="web_name" runat=server /></FONT>
      后台协作平台！
        <FONT>
        <SCRIPT language=javascript> 
                function isnArray()
                {
                argnr=isnArray.arguments.length
                for(var i=0;i<argnr;i++)
                {
                this[i+1]=isnArray.arguments[i];
                }
                }
                var isnDays=new isnArray("星期一","星期二","星期三","星期四","星期五","星期六","星期日");isnDays[0]="星期日";
                mydate = new Date();
                myyear = mydate.getFullYear();
                mymonth = mydate.getMonth()+1;
                today = mydate.getDate();
                //document.write(myyear + "年" + mymonth + "月" + today + "日");
                document.write(mymonth+"月"+today+"日");
                document.write(isnDays[mydate.getDay()]);
                </SCRIPT>
        </FONT>
       
        <!--<B><SPAN title=您看到的是农历日期时间 >{农历}</SPAN></B>-->
        </TD>
      <TD align="center" background=images/admin-top2.gif>
      <table width="80%" border="0" cellspacing="5" cellpadding="0">
          <tr>
            <td nowrap><IMG title=回到首页 border=0 align=absMiddle  src="/administrator/images/rainbow.png">
              <a href="Welcome.html" title=到欢迎界面开始您的建站之旅 target="mainFrame">开始</a></td>
            <td nowrap><IMG src="/administrator/images/chart_bar.png" width="16" height="16" border=0 align=absMiddle title=学习>
              <a href="http://www.ROYcms.cn/?i=xuexi" title=学习ROYcms target="_blank">学习</a></td>
            <td nowrap><IMG  title=关注我们 border=0 align=absMiddle src="/administrator/images/pill.png">
              <a href="http://www.ROYcms.cn/?i=BUG"  title=BUG反馈 target="_blank">BUG</a></td>
            <td nowrap><IMG title=技术支持 border=0 align=absMiddle src="/administrator/images/lightbulb_add.png">
              <a href="http://www.ROYcms.cn/?i=zhichi"  title=技术支持 target="_blank">支持</a></td>
            <td nowrap><IMG title=系统更新 border=0 align=absMiddle src="/administrator/images/layers.png">
              <a href="#" onclick="window.open('/administrator/update.aspx','Sample','toolbar=no,location=no,directories=no,status=no,menubar=no,scrollbars=no,resizable=yes,copyhistory=yes,width=700,height=500,left=200,top=100')"  title=系统更新 >更新</a>
             </td>
          </tr>
        </table>
        </TD>
      <TD align=right nowrap background=images/admin-top2.gif>
      <TABLE border=0 cellSpacing=0 cellPadding=0>
          <TBODY>
            <TR>
              <TD width=65><A target=mainFrame href="help.aspx">
              <IMG src="/administrator/images/help-bt.gif" alt="查看官方帮助信息，帮你解决操作中遇到的问题。" width=56 height=19 border=0></A>
              </TD>
              <TD>
              <A target=_parent href="index.aspx?admin=out">
              <IMG title=20分钟无操作自动退出 border=0 src="/administrator/images/quit-bt.gif" width=46 height=19></A>
              </TD>
            </TR>
          </TBODY>
        </TABLE>
        </TD>
      <TD vAlign=top background=images/admin-top2.gif width=19>
      <IMG src="/administrator/images/admin-top3.gif" width=19 height=71>
      </TD>
    </TR>
  </TBODY>
</TABLE>
<map name="Map">
  <area shape="rect" coords="87,-1,229,73" href="#" alt="点击关闭左侧" onClick="shleft();">
  <area shape="circle" coords="39,36,31" href="http://www.roycms.cn" target="_blank" alt="最佳ASP.NET开源cms">
</map>
<SCRIPT LANGUAGE="JavaScript">
<!--
    function shleft(){
    if (parent.cen.cols=="0,*"){
      parent.cen.cols="229,*,";
      parent.full.rows=parent.full.rows.split(",")[0]+",*,55";
      /* parent.full.rows="55,*,"+parent.full.rows.split(",")[2];*/
      document.getElementById("t1").style.display = "block";   
      /* document.getElementById("t2").style.display = "block";  */ 
      im.src = "/administrator/images/admin-top1.gif";
     }
    else{
      parent.cen.cols="0,*";
      parent.full.rows=parent.full.rows.split(",")[0]+",*,0"; 
      /*parent.full.rows="54,*,"+parent.full.rows.split(",")[2];*/
       document.getElementById("t1").style.display = "none";   
      /*document.getElementById("t2").style.display = "none";   */
      im.src = "/administrator/images/admin-topEnd.gif";
     }
    }
//-->
</SCRIPT>
</BODY>
</HTML>
