<%@ Page Language="C#" AutoEventWireup="True" Inherits="ROYcms.Tools.Tp._Default" Codebehind="Default.aspx.cs" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title></title>
<style type="text/css">
<!--
ul, li {
	margin:0px;
	padding:0px;
}
.box {
	border: 1px solid #E8E8E8;
}
.bg_box {
	background-color: #F7F7F7;
}
.top_lin {
	border-top-width: 1px;
	border-right-width: 0px;
	border-bottom-width: 0px;
	border-left-width: 0px;
	border-top-style: solid;
	border-right-style: solid;
	border-bottom-style: solid;
	border-left-style: solid;
	border-top-color: #94A3C4;
	border-right-color: #94A3C4;
	border-bottom-color: #94A3C4;
	border-left-color: #94A3C4;
	background-color: #ECEFF5;
	font-size: 12px;
	color: #000;
	font-weight: bold;
	margin-top: 10px;
	padding: 6px;
	margin: 12px;
	padding-top: 4px;
	padding-bottom: 4px;
}
.top_lin_q {
	background-color: #F7F7F7;
	border-top-width: 1px;
	border-right-width: 0px;
	border-bottom-width: 0px;
	border-left-width: 0px;
	border-top-style: solid;
	border-right-style: solid;
	border-bottom-style: solid;
	border-left-style: solid;
	border-top-color: #D8DFEA;
	border-right-color: #D8DFEA;
	border-bottom-color: #D8DFEA;
	border-left-color: #D8DFEA;
	font-size: 12px;
	line-height: 22px;
	color: #284188;
	margin-top: 10px;
	padding: 2px;
}
.top_lin_q span {
	float:right;
	font-size: 12px;
	color: #666666;
	margin-right: 5px;
	margin-top: -22px;
}
a {
	font-size: 12px;
	color: #005EAC;
}
a:link {
	text-decoration: none;
}
a:visited {
	text-decoration: none;
	color: #005EAC;
}
a:hover {
	text-decoration: underline;
	color: #005EAC;
}
a:active {
	text-decoration: none;
	color: #005EAC;
}
.top {
	height: 35px;
	width: 960px;
	background-image: url(SpryAssets/index/top.png);
	background-repeat: no-repeat;
	background-position: center;
	margin: auto;
}
#content {
	width: 960px;
	display: table;
	margin: auto;
}
#left {
	width: 680px;
	display: table;
	float: left;
}
#right {
	width: 260px;
	float: left;
	margin-left: -1px;
	padding: 5px;
}
.logo_title {
	background-image: url(SpryAssets/index/logo_title.png);
	background-repeat: no-repeat;
	background-position: 15px;
	width: 960px;
	height: 31px;
	margin: auto;
	margin-top: 30px;
}
.touxiang {
	height: 60px;
	width: 68px;
	margin: 20px;
	background-image: url(SpryAssets/index/toupiao_pic_bg.gif);
}
li {
	list-style-type: none;
}
#fooder {
	width: 960px;
	margin: auto;
	font-size: 12px;
	color: #3B5888;
	line-height: 23px;
}
.liuyan {
	margin: 10px;
	border: 1px solid #94A3C4;
}
.liuyan_content {
	font-size: 12px;
	color: #2D2D2D;
	line-height: 23px;
	padding: 2px;
}
h3 {
	color: #666666;
	font-family: "微软雅黑";
	font-weight: bold;
	font-size: 15px;
	line-height: 25px;
	margin-top: 3px;
	margin-bottom: 2px;
	padding: 0px;
}
.bai_title_13 {
	font-size: 13px;
	color: #FFF;
	line-height: 23px;
}
.list_ {
	height: 100px;
	width: 620px;
	margin: 10px;
	margin-left: 30px;
}
.tou_ {
	height: 61px;
	width: 60px;
	margin: 8px;
	background-image: url(SpryAssets/index/toupiao_num1_bg.gif);
	margin-bottom: 2px;
	font-size: 14px;
	font-weight: bold;
	color: #FFF;
	text-align: center;
	font-family: "微软雅黑";
}
.tou_d_ {
	height: 17px;
	width: 42px;
	margin: 8px;
	margin-bottom: 1px;
	margin-top: 0px;
	background-image: url(SpryAssets/index/toupiao_go_bg.gif);
	padding-left: 18px;
	padding-top: 6px;
}
.huise_12_666 {
	font-size: 12px;
	line-height: 23px;
	color: #666;
}
-->
</style>
<style type="text/css">
<!--
body {
	margin-top: 0px;
}
.list li {
	list-style-image: url(SpryAssets/index/polls.gif);
	list-style-position: inside;
	margin-left: 15px;
	margin-top: 6px;
}
.lins {
	height: 0px;
	width: 96%;
	border-top-width: 1px;
	border-top-style: solid;
	border-right-style: solid;
	border-bottom-style: solid;
	border-left-style: solid;
	border-top-color: #D8DFEA;
	border-right-color: #D8DFEA;
	border-bottom-color: #D8DFEA;
	border-left-color: #D8DFEA;
	border-right-width: 0px;
	border-bottom-width: 0px;
	border-left-width: 0px;
	margin: 10px;
	font-size: 13px;
	font-weight: bold;
	color: #333;
}
.text {
	font-size: 14px;
	font-weight: bold;
	color: #3B5888;
}
.small_text {
	font-size: 12px;
	color: #3B5888;
}
.barbg {
	BACKGROUND-COLOR: #efefef;
	WIDTH: 320px;
	HEIGHT: 20px;
	MARGIN-RIGHT: 10px;
	margin-top: 5px;
	margin-bottom: 5px;
	margin-left: 10px;
}
.l {
	PADDING-BOTTOM: 0px;
	MARGIN: 0px;
	PADDING-LEFT: 0px;
	PADDING-RIGHT: 0px;
	FLOAT: left;
	PADDING-TOP: 0px
}
.record {
	LINE-HEIGHT: 20px;
	WIDTH: 75px;
	FLOAT: left
}
.hei12 {
	font-size: 12px;
	line-height: 18px;
	color: #333;
}
-->
</style>
</head>
<body>
<form id="form1"  runat="server">
  <div class="top"></div>
  <div class="logo_title">
    <table width="731" border="0" cellpadding="5" cellspacing="0">
      <tr>
        <td width="38">&nbsp;</td>
        <td width="120"><a href=Default.aspx><span class="bai_title_13">热门投票</span></a></td>
        <td width="120"><a href=Default.aspx><span class="bai_title_13">最新投票</span></a></td>
        <td width="116"><a href=Default.aspx><span class="bai_title_13">最受关注</span></a></td>
        <td width="138"><a href=Default.aspx><span class="bai_title_13">参与人最多</span></a></td>
        <td width="139">&nbsp;</td>
      </tr>
    </table>
  </div>
  <div id="content">
    <div class="box" id="left">
      <table width="100%" border="0" cellpadding="8" cellspacing="0">
        <tr>
          <td width="83"><img src="SpryAssets/index/logo.gif" width="83" height="73" /></td>
          <td width="234"><h3>
              <asp:Label ID="Label_group_content" runat="server" Text=""></asp:Label>
              </h3></td>
          <td width="146" valign="bottom"><a href="#"><img src="SpryAssets/index/toupiao_invite.gif" width="146" height="36" border="0" /></a></td>
          <td width="155" valign="bottom"><a href="#"><img src="SpryAssets/index/toupiao_create.gif" width="146" height="36" border="0" /></a></td>
        </tr>
      </table>
      <asp:Repeater ID="Repeater_group" runat="server">
        <ItemTemplate>
          <div class="lins"></div>
          <div class="list_">
            <table width="100%" height="60" border="0" cellpadding="0" cellspacing="0">
              <tr>
                <td height="88"><table width="100%" height="81" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                      <td width="74%" height="21"><a href='?group=<%#Eval("id") %>' class="text"><%#Eval("group_name") %></a></td>
                      <td width="26%" class="hei12"><span class="huise_12_666"><%# time_c(Eval("date_time").ToString()) %></span> <span class="text"><img src="SpryAssets/index/toupiao_review_icon.gif" width="11" height="11" /></span> 
                      <a href="?group=<%#Eval("id") %>#pl">评论(<%# sum_pl(Convert.ToInt32( Eval("id"))) %>)</a></td>
                    </tr>
                    <tr>
                      <td height="60" colspan="2" class="huise_12_666"><%#Eval("group_content")%></td>
                    </tr>
                  </table></td>
                <td width="12%"><div class="tou_"  style='background-image: url(SpryAssets/index/toupiao_num<%# (Container.ItemIndex+1).ToString().Substring(0,1)%>_bg.gif);'  ><br />
                   <%# hot_group(Convert.ToInt32( Eval("id"))) %> </div>
                  <div class="tou_d_"><a href='?group=<%#Eval("id") %>' >去投票</a></div></td>
              </tr>
            </table>
          </div>
        </ItemTemplate>
      </asp:Repeater>
      <asp:Panel ID="Panel_show" runat="server">
        <!--plan_show开始-->
        <div class="lins"></div>
        <table width="100%" height="99" border="0" cellpadding="8">
          <tr>
            <td width="35%" height="95" valign="top" class="hei12">
            发起时间：<asp:Label ID="Label_group_date_time" runat="server" Text=""></asp:Label>
                <br />
              总投票数：<asp:Label ID="Label_group_num" runat="server" Text=""></asp:Label>
                <br />
              选择方式：<asp:Label ID="Label_group_x" runat="server" Text=""></asp:Label>
              </td>
            <td width="50%" valign="middle"><span class="text"><img src="SpryAssets/index/statistics.gif" width="23" height="17" /><asp:Label ID="Label_group_name" runat="server" Text=""></asp:Label></span>
                
              </td>
            <td width="15%" valign="bottom">
            <asp:ImageButton 
              ID="ImageButton_tp" runat="server" 
              ImageUrl="SpryAssets/index/vote_btn.gif" onclick="ImageButton_tp_Click" />
            </td>
          </tr>
        </table>
        <asp:Repeater ID="Repeater_tu" runat="server">
          <ItemTemplate>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="21%" align="right" class="text"><span class="small_text"><%#Eval("names").ToString().Trim() %></span></td>
                <td width="50%"><div class="barbg">
                    <div class="l"><img src='SpryAssets/img/b<%# (Container.ItemIndex+1).ToString().Substring(0,1)%>_l.gif' /></div>
                    <div style='WIDTH: <%# ny(Convert.ToInt32(Eval("ballot")))%>; background-image: url(SpryAssets/img/b<%# (Container.ItemIndex+1).ToString().Substring(0,1)%>.gif);  line-height: 20px;' class="l" id='bg<%# (Container.ItemIndex+1).ToString()%>' > &nbsp;</div>
                    <div class="l"><img src='SpryAssets/img/b<%# (Container.ItemIndex+1).ToString().Substring(0,1)%>_r.gif' /></div>
                  </div></td>
                <td width="19%" align="left" nowrap="nowrap" class="small_text">票数：<%#Eval("ballot") %> || <%# ny(Convert.ToInt32(Eval("ballot")))%></td>
                <td width="10%" align="left" nowrap="nowrap" class="small_text"><label>
                    <input type='<%# type() %>'  name="tp_id[]" id="tp_id[]" value='<%#Eval("id") %>'  />
                  </label></td>
              </tr>
            </table>
          </ItemTemplate>
        </asp:Repeater>
        <p>&nbsp;</p>
        <div class="lins">添加评论</div>
        <p>
          <input type="text" name="remark_title" class="liuyan" />
          <a name="pl" id="pl"></a><br />
          <textarea name="remark_content" cols="45" rows="5" class="liuyan"></textarea>
          <asp:ImageButton 
              ID="ImageButton_liuyan" runat="server" 
              ImageUrl="SpryAssets/index/post_btn.gif" onclick="ImageButton_liuyan_Click" />
        </p>
        <asp:Repeater ID="Repeater_pl" runat="server">
          <ItemTemplate>
            <div class="top_lin_q"><%#Eval("pl_title") %><span>时间：<%#Eval("date_time") %> </span></div>
            <div class="liuyan_content"><%#Eval("pl_content") %> </div>
          </ItemTemplate>
        </asp:Repeater>
        <!--plan_show结束-->
        </asp:Panel>
    </div>
    <div class="bg_box box" id="right">
      <div class="top_lin">最新投票</div>
      <ul class="list">
        <asp:Repeater ID="Repeater_right1_group" runat="server">
          <ItemTemplate>
            <li> <a href='?group=<%#Eval("id") %>'><%#Eval("group_name") %></a> </li>
          </ItemTemplate>
        </asp:Repeater>
      </ul>
      <div class="top_lin">热门投票</div>
      <ul class="list">
         <asp:Repeater ID="Repeater_right2_group" runat="server">
          <ItemTemplate>
            <li> <a href='?group=<%#Eval("id") %>'><%#Eval("group_name") %></a> </li>
          </ItemTemplate>
        </asp:Repeater>
      </ul>
      <div class="top_lin"><a href="http://www.roycms.cn" target="_blank"><img src="SpryAssets/img/ads1.gif" alt="" name="" width="225" height="169" border="0" /></a></div>
    </div>
  </div>
  <br />
  <div class="top_lin_q" id="fooder">
   <a href='ROYcms_TP.aspx?administrator=123'>管理入口</a>
  </div>
</form>
</body>
</html>
