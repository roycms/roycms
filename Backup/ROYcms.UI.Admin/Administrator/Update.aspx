<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Update.aspx.cs" Inherits="ROYcms.UI.Admin.Update" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="robots" content="all" />
<meta name="author" content="roycms@qq.com" />
<meta name="Copyright" content="roycms CopyRight 2008" />
<meta name="keywords" content="roycms,社会化网络" />
<meta name="description" content="roycms基于许多优秀的开源软件开发，为企业提供全方位的社交网络解决方案" />
<title>ROYCMS 系统更新升级 </title>
<link rel="shortcut icon" href="favicon.ico" />
<style type="text/css">
body{ font-family:"宋体"; color:#000; font-size:12px;}
*{margin:0; padding:0}
ul,ol{list-style:none}
img{border:none}
p {
	margin: 0px;
	padding: 0px;
}

.clear{height:1px; line-height:1px; font-size:1px; clear:both;}
a{
	text-decoration:none;
	color:#3b5998;
}
a:hover{
text-decoration:underline;
}
.container{ width:680px; margin:0 auto;}
.content{ margin:30px;}
	.tit_cj{ border-bottom:2px solid #b8bdc1; color:#3a5999;   line-height:30px; height:30px;  background:url(images/jiantou_cj.png) left center no-repeat; padding-left:10px; font-size:16px; font-weight:bold;}
	.content ul{ line-height:24px; margin-top:20px; margin-bottom:20px;}
	.zhichi{ color:#3c599b; margin-bottom:20px;}
	.content h1{ font-size:14px; color:#729bdb; font-weight:bold; padding-top:10px;padding-bottom:20px;}
	.border_cona{ background:url(images/update1.jpg) left center no-repeat; height:72px; border:1px solid #808080; margin-bottom:20px; }
	.con_img{ padding-left:36px; float:left; margin-right:16px; display:inline;}
	.con_tent{ float:left; line-height:24px; padding-top:6px; width:200px;}
	.con_tenta{ float:left; margin-top:16px; height:28px; border-left:1px solid #818181; line-height:28px; padding-left:16px;}
	.con_tenta span{ font-weight:bold;}
	.a{ font-weight:bold; }
	.b{ color:#01007f; }
	.border_conb{
	background:url(images/update2.jpg) left center no-repeat;
	height:95px;
	border:1px solid #808080;
	position:relative;
	margin-bottom:20px;
}
	.anzhuang{ position:absolute; top:60px; right:20px;}
</style>
<base target="_parent" />
</head>

<body>
<form runat=server>
<div class="container">
	<div class="content">
      <div class="tit_cj" style="color:#F00; font-size:18px; font-family:微软雅黑;">产品更新注意事项及须知</div> 
      <ul>
      	<li>1.更新前请备份站点目录的文件。</li>
        <li>2.确保站点目录有写入和创建文件的权限。<br />
        （注意：安全期间服务器通常会关闭不必要的目录写入权限，可以针对更新期间开启该权限更新完毕后关闭）      </li>
      </ul>
      <h1>系统更新检测结果</h1>
      
            <asp:Panel ID="Panel_noupdate" runat="server"> 
       <div class="border_cona">
   		<div class="con_img"><img src="images/updatea.jpg" /></div>
        <p class="con_tent"><span class="a">您的CMS版本是最新的 V<% =ROYcms.Common.GetUrlText.GetText(___CmsConfigValue("UpdateServer") + "api/Update.ashx?i=Version", "utf-8")%></span><br/><span class="b">查看官方更新报告</span></p>
        <p class="con_tenta">当前未没有任何更新和补丁</p>
      </div>
      <table width="621" border="0" cellpadding="0" cellspacing="0" style="line-height:22px;">
      	<tr>
        	<td width="129">最近检查更新的时间：</td>
            <td width="492">今天9：25</td>
        </tr>
        <tr>
        	<td width="129">安装更新的时间：</td>
            <td>2010/05/28 18：01 <a href="#">查看更新历史记录</a></td>
        </tr>
        <tr>
        	<td width="129">接收更新：</td>
            <td>适用于<a href="http://www.roycms.cn" title="http://www.roycms.cn" target="_blank">ROYcms</a>产品和其他来自<a href="http://www.langziwenhua.cn" title="郎子科技" target="_blank">郎子科技</a>的产品</td>
        </tr>
      </table>
            </asp:Panel>

      
      <asp:Panel ID="Panel_update" runat="server"> 
     <div class="border_conb">
			<div class="con_img"><img src="images/updateb.jpg" /></div>
            <p class="con_tent"><span class="a">检测到可用的CMS更新 </span><br/><span class="b">版本从<%=___CmsConfigValue("Version") %>到<% =ROYcms.Common.GetUrlText.GetText(___CmsConfigValue("UpdateServer") + "api/Update.ashx?i=Version", "utf-8")%>的升级<br /></span></p>
            <p class="con_tenta"><span>更新可修复高危错误</span></p>
        	<asp:Button ID="Button_ZIP" CssClass="anzhuang" runat="server" Text="立即更新升级CMS" onclick="Button_ZIP_Click" OnClientClick="return window.confirm('确定要这样操作吗？');" />
      </div> 
	   <table width="621" border="0" cellpadding="0" cellspacing="0" style="line-height:22px;">
      	<tr>
        	<td width="129">最近检查更新的时间：</td>
            <td width="492">今天9：25</td>
        </tr>
        <tr>
        	<td width="129">安装更新的时间：</td>
            <td>2010/05/28 18：01。<a href="#">查看更新历史记录</a></td>
        </tr>
        <tr>
        	<td width="129">接收更新：</td>
            <td>适用于<a href="http://www.roycms.cn" title="http://www.roycms.cn" target="_blank">ROYcms</a>产品和其他来自<a href="http://www.langziwenhua.cn" title="郎子科技" target="_blank">郎子科技</a>的产品</td>
        </tr>
      </table>
      </asp:Panel>
            <asp:Panel ID="Panel_error" runat="server"> 
     <div class="border_conb" style=" height:75px;">
			<div class="con_img"><img src="images/updateb.jpg" /></div>
          <p class="con_tent"><span class="a">未知错误</span><br/><span class="b">请确保你已<a href="/administrator/config/cms_config.aspx"><font color="#F70214">配置</font></a>了更新服务器地址</span></p>
     </div> 
      </asp:Panel>
    </div>               
</div>       
<div style="clear:both"></div>
</form>
</body>
</html>
