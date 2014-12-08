<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Comment.aspx.cs" Inherits="ROYcms.UI.Admin.Comment" %>
<html>
<head runat="server">
<title><%=GetTitle() %>的相关评论信息</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<style type="text/css">
<!--
body, td, th {
	color: #333;
}
.lins {
	border: 1px solid #CCC;
}
.index {
	width: 100%;
	display: table;
	margin: auto;
	border: 1px solid #EAEAEA;
}
body {
	margin-left: 5px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
}
.inputs {
}
-->
</style>
</head>
<script src="/administrator/webui/SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<script src="/administrator/webui/SpryAssets/SpryValidationTextarea.js" type="text/javascript"></script>
<link href="/administrator/webui/SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css" />
<link href="/administrator/webui/SpryAssets/SpryValidationTextarea.css" rel="stylesheet" type="text/css" />
<body>
<form id="form1" runat="server" action="/_Remark.aspx">
  <div class="index">
    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="1142" style="font-size:10px; font-family:微软雅黑; color:#CCC"><a href="<%= ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host") %>" target="_blank"><img src='<%= ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("logo") %>' alt="国内最佳ASP.NET开源CMS" name="" border="0" /></a></td>
      </tr>
    </table>
    <table width="100%" border="0" align="center" cellpadding="2" cellspacing="0">
      <tr>
        <td width="2px" bgcolor="#FF0000" style="color:#FFF;"></td>
        <td width="946" bgcolor="#0066B3" style="color:#FFF; "><span style=" margin-left:10px;">
          <a style="color:#FFF;" href="<%= ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host") %>">首页</a>
          <a href="/ask/default.html" target="_blank" style="color:#FFF;">问答</a>
          <a style="color:#FFF;" href="<%= ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host") %>"></a>
          </span></td>
      </tr>
    </table>
    <table width="100%" border="0" cellspacing="0" cellpadding="3" style="margin:10px">
      <tr>
        <td width="29%" nowrap><h2><%=GetTitle() %> <span style="font-size:12px; font-weight:100;">标识
        [<% =Request["NewsId"] %>]
        </span></h2></td>
      </tr>
    </table>
    <asp:Repeater ID="Repeater_list" runat="server">
      <ItemTemplate>
        <div class="lins" style="">
          <h5  style="margin:3px;">
            <strong><img name="" src="/Administrator/images/admin-ico.gif" width="13" height="11" alt="">
            <%#Eval("userName")%></strong>
            <em>
            <strong>
            <img name="" src="/Administrator/images/direction.png" width="16" height="16" alt=""></strong> IP:[<%#Eval("Ip")%>] </em></h5>
        </div>
        <div class="lins" style="margin:10px; padding: 5px;"><%#Eval("contents")%></div>
      </ItemTemplate>
    </asp:Repeater>
    <div style="margin-left:20px; margin-bottom:10px;">
      <h4>我要评论 </h4>
      <span id="sprytextfield1">姓名
      <input name="userName" type="text" class="inputs" id="userName" />
      <span class="textfieldRequiredMsg">请填写您的姓名</span></span>
      <input name="NewsId" type="hidden" id="NewsId" value='<% =Request["NewsId"] %>' />
      <br />
      <br />
      <span id="sprytextarea1">
      <label> 内容
        <textarea name="contents" cols="45" rows="5" class="inputs" id="contents"></textarea>
      </label>
      <span class="textareaRequiredMsg">必须填写内容</span>
      </span>
      <br />
      <br />
      <label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input name="button" type="submit" class="inputs" id="button" value="确认提交" />
      </label>
    </div>
  </div>
  </ItemTemplate>
  </asp:Repeater>
  </div>
</form>
<script type="text/javascript">
<!--
var sprytextfield1 = new Spry.Widget.ValidationTextField("sprytextfield1");
//var sprytextarea1 = new Spry.Widget.ValidationTextarea("sprytextarea1");
//-->
</script>
</body>
</html>

