<%@ Page Language="C#" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
<script src="/administrator/webui/SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<link href="css/ROYcmsUcenter.css" rel="stylesheet" type="text/css" />
<link href="/administrator/webui/SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css" />
  <script src="/administrator/webui/SpryAssets/SpryValidationTextarea.js" type="text/javascript"></script>
  <link href="/administrator/webui/SpryAssets/SpryValidationTextarea.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #contents
        {
            height: 248px;
            width: 580px;
        }
    </style>
<form id="form1" action="/add.ashx" >
<table width="560" border="0" align="center" cellpadding="10" cellspacing="0">
    <tr>
      <td align="center" valign="top"><fieldset>
          <legend> 投递信息</legend>
          <table cellspacing="10" cellpadding="0" width="100%" border="0">
            <tr>
              <td width="81" height="25" align="right" nowrap="nowrap"> 标题
                ：</td>
            <td width="467" height="25" align="left" nowrap="nowrap"><table width="98%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td width="49%"><span id="sprytextfield1">
                  <label>
                    <input name="title" type="text" class="input_css" id="title" size="28" />
                  </label>
                  <span class="textfieldRequiredMsg">必填</span></span></td>
                  <td width="8%" nowrap="nowrap">作者 </td>
                  <td width="8%" nowrap="nowrap"><input name="author" type="text" id="author" size="5"  class="input_css" /> </td>
                  <td width="8%" nowrap="nowrap"> 出处 </td>
                  <td width="27%" nowrap="nowrap"><input name="infor" type="text" id="infor" size="5"  class="input_css" />
                    <input name="classname" type="hidden" id="classname" value="<%=Request["Class"]%>" />
                    <input name="ClassKind" type="hidden" id="ClassKind" value="<%=Request["ClassKind"]%>" /></td>
                </tr>
              </table></td>
            </tr>
            <tr>
              <td width="81" height="25" align="right" nowrap="nowrap"> 关键字：</td>
              <td width="467" height="25" align="left" nowrap="nowrap"><span id="sprytextfield2">
                <input name="keyword" type="text"  class="input_css" id="keyword" size="28" />
              <span class="textfieldRequiredMsg">必填</span></span></td>
            </tr>
            <tr>
              <td width="81" height="25" align="right" nowrap="nowrap"> 摘要
                ：</td>
              <td width="467" height="25" align="left" nowrap="nowrap"><span id="sprytextarea1">
                <textarea name="zhaiyao" id="zhaiyao" cols="45" rows="3" class="input_css"></textarea>
              <span class="textareaRequiredMsg">必填</span></span></td>
            </tr>
            <tr>
              <td width="81" height="25" align="right" nowrap="nowrap"> 标签TAG：</td>
              <td width="467" height="25" align="left" nowrap="nowrap"><span id="sprytextfield3">
                <input type="text" name="tag" id="tag"  class="input_css" />
              <span class="textfieldRequiredMsg">必填</span></span></td>
            </tr>
            <tr>
              <td width="81" height="25" align="right" nowrap="nowrap"> 内容
                ：</td>
              <td width="467" height="25" align="left" nowrap="nowrap"><textarea name="contents"  id="contents"></textarea></td>
            </tr>
            <tr>
              <td height="7" align="right" nowrap="nowrap">验证码：</td>
              <td height="7" align="left" nowrap="nowrap"><input name="code" type="text" id="code" size="5"  class="input_css" />
              
             <img id="validateCode" src="~/Administrator/Img.ashx"  width="69" height="28"  onClick="this.src=this.src+'?1'"  alt="验证码" runat="server" /> <a  onClick="validateCode.src=validateCode.src+'?1'" title="看不清我要换一张">看不清？</a> 
                </td>
            </tr>
            <tr>
              <td height="8" nowrap="nowrap">&nbsp;</td>
              <td height="8" align="left" nowrap="nowrap"><input type="submit" name="button_get" id="button_get" value="确认提交" /></td>
            </tr>
          </table>
        </fieldset></td>
    </tr>
  </table>
  <script type="text/javascript">
<!--
var sprytextfield2 = new Spry.Widget.ValidationTextField("sprytextfield2");
var sprytextarea1 = new Spry.Widget.ValidationTextarea("sprytextarea1", {isRequired:false});
var sprytextfield3 = new Spry.Widget.ValidationTextField("sprytextfield3");
var sprytextfield1 = new Spry.Widget.ValidationTextField("sprytextfield1");
//-->
  </script>
</form>

</body>
</html>