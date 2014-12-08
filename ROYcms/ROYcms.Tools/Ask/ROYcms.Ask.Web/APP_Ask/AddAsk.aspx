<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAsk.aspx.cs" Inherits="ROYcms.Ask.Web.AddAsk" %>

<%@ Register src="/app_ask/Top.ascx" tagname="Top" tagprefix="uc1" %>

<%@ Register src="/app_ask/Footer.ascx" tagname="Footer" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>我要提问 - <%=___GetConfigValue("Title")%></title>
    <meta name="Keywords" content='<%=___GetConfigValue("Keyword")%>' />
<meta name="Description" content='<%=___GetConfigValue("Description")%>' />
    <link href="/app_ask/css/ROYcmsAsk.css" rel="stylesheet" type="text/css" />
<script src="/administrator/webui/SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<script src="/administrator/webui/SpryAssets/SpryValidationTextarea.js" type="text/javascript"></script>
<script src="/administrator/webui/SpryAssets/SpryValidationSelect.js" type="text/javascript"></script>
<link href="/administrator/webui/SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css" />
<link href="/administrator/webui/SpryAssets/SpryValidationTextarea.css" rel="stylesheet" type="text/css" />
<link href="/administrator/webui/SpryAssets/SpryValidationSelect.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server"><uc1:Top ID="Top1" runat="server" />
    <div style="margin-left:15px;">
    <table cellSpacing="5" cellPadding="5" width="98%" border="0">
	<tr>
	<td width="11%" height="25" align="right" nowrap="nowrap">提问的标题：<span style="color:#F30;"> * </span></td>
	<td height="25" width="89%" align="left"><span id="sprytextfield1">
	  <label>
	    <input name="title" type="text" id="title" size="100" style="height:32;" />
	    </label>
	  <span class="textfieldRequiredMsg">必须填写问题的标题</span></span><br />
		<span style="font-size:12px; color:#999; margin-top:3px;">例如：为什么天空是蓝色的？小狗拉肚子怎么办？</span> 
        
        </td></tr>
	<tr>
	<td width="11%" height="25" align="right" nowrap="nowrap">
详细描述（选填） </td>
	<td height="25" width="89%" align="left"><span id="sprytextarea1">
	  <label>
	    <textarea name="content" id="content" cols="100" rows="6"></textarea>
	    </label>
</span></td></tr>
	<tr>
	  <td width="11%" height="25" align="right" nowrap="nowrap">悬赏问答分：</td>
	  <td height="25" width="89%" align="left"><label><span id="spryselect1">
	    <select name="select1" id="select1">
	      <option>10分</option>
	      <option>20分</option>
	      <option>30分</option>
	      <option>40分</option>
	      <option>50分</option>
	      <option>60分</option>
	      <option>70分</option>
	      <option>80分</option>
	      <option>100分</option>
	      </select>
</span>  你目前的问答分：24 </label></td></tr>
	<tr>
	  <td height="3" nowrap="nowrap">&nbsp;</td>
	  <td height="3">为方便网友找到你的问题，请添加1~5个与问题相关的标签。（多个标签之间用逗号隔开）<br />
	    <span id="sprytextfield2">
	    <label>
	      <input name="tag" type="text" id="tag" size="100" />
	      </label>
</span></td>
	  </tr>
	<tr>
	  <td height="3" nowrap="nowrap">&nbsp;</td>
	  <td height="3"><input type="submit" name="button" id="button" value="发表提问" /></td>
	  </tr>
	<tr>
	  <td height="11" align="right" nowrap="nowrap">服务条款：</td>
	  <td height="11">请注意，根据中国法律，该服务会将有关您发帖内容、发帖时间以及您发帖时的IP地址、电子邮箱地址等记录保留至少 60   天，并且只要接到合法请求，即会将这类信息提供给政府机构。点击“发表提问”表示您接受服务条款。
        <a href="/help.ashx?ask" target="_blank">服务条款全文» </a></td>
	  </tr>
    </table>
    </div>
<script type="text/javascript">
<!--
var sprytextfield1 = new Spry.Widget.ValidationTextField("sprytextfield1");
var sprytextarea1 = new Spry.Widget.ValidationTextarea("sprytextarea1", {isRequired:false});
var spryselect1 = new Spry.Widget.ValidationSelect("spryselect1", {isRequired:false});
var sprytextfield2 = new Spry.Widget.ValidationTextField("sprytextfield2", "none", {isRequired:false});
//-->
</script>
    <uc2:Footer ID="Footer1" runat="server" />
    </form>
</body>
</html>
