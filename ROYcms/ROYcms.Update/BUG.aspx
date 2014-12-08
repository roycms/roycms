<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="BUG.aspx.cs" Inherits="ROYcms.Update.BUG" %>
<%@ Register src="_header.ascx" tagname="_header" tagprefix="uc1" %>
<%@ Register src="_foot.ascx" tagname="_foot" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>ROYcms!NT 共享平台</title>
<link href="css/css.css" rel="stylesheet" type="text/css" />
<script src="/Administrator/WebUI/SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<script src="/Administrator/WebUI/SpryAssets/SpryValidationTextarea.js" type="text/javascript"></script>
<link href="/Administrator/WebUI/SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css" />
<link href="/Administrator/WebUI/SpryAssets/SpryValidationTextarea.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" action="administrator/xml/FromXml.aspx">
  <div id="wrap">
   <uc1:_header ID="_header" runat="server" />  
    <div id="list-selected"><img src="Images/page_white_csharp.png" /> 每日一句：</div>
    <h1 class="biaoti">
      <div class="code_name">BUG反馈</div>
    </h1>
    <div class="main">
      <div class="left"><br />
        <br />
        <span id="sprytextfield1">
        <label>BUG名称[给错误起个名字]：
          <input type="text" name="BUG名称" id="BUG名称" />
        </label>
      <span class="textfieldRequiredMsg">需要提供一个值。</span></span><span id="sprytextarea1">
      <label><br />
        BUG错误的内容[详细描述]：
          <textarea name="BUG错误内容[详细描述]" id="BUG错误内容[详细描述]" cols="45" rows="8"></textarea>
      </label>
      <span class="textareaRequiredMsg">需要提供一个值。</span></span>
      <label>
        确认
        <input type="submit" name="确认" id="确认" value="提交" />
      </label>
<br />
      <br />
      <br />
      </div>
      <div class="right"></div>
    </div>
<uc2:_foot ID="_foot1" runat="server" />

  </div>
    </form>
<script type="text/javascript">
<!--
var sprytextfield1 = new Spry.Widget.ValidationTextField("sprytextfield1");
var sprytextarea1 = new Spry.Widget.ValidationTextarea("sprytextarea1");
//-->
</script>
</body>
</html>
