<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrator.aspx.cs" Inherits="ROYcms.Community.Web.App_Community.Admin.Administrator" ValidateRequest="false" %>

<%@ Register src="Top.ascx" tagname="Top" tagprefix="uc1" %>
<%@ Register src="Footer.ascx" tagname="Footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title></title>
<link rel="stylesheet" type="text/css" href="Admin.css" />
<script src="/administrator/webui/SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<script src="/administrator/webui/SpryAssets/SpryValidationTextarea.js" type="text/javascript"></script>
<link href="/administrator/webui/SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css" />
<link href="/administrator/webui/SpryAssets/SpryValidationTextarea.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="ConfigForm" runat="server">
<%if (ROYcms.Common.Session.Get("administrator") != null)
  { %>
<div id="MainDiv">

    <uc1:Top ID="Top1" runat="server" />

    <br />
    <p><b>常规选项</b></p>
    <table cellpadding="0" cellspacing="6" style="width: 600px; border: solid 1px #555555; background-color: #F0F0F0;">
      <tr>
        <td nowrap="nowrap"><p style="text-align: right;">论坛首页标题</p></td>
        <td nowrap="nowrap"><span id="sprytextfield1">
          <label>
            <input name="Title" type="text" id="Title" value="<%=___GetConfigValue("Title")%>" size="60" />
          </label>
        <span class="textfieldRequiredMsg">需要提供一个值。</span></span></td>
      </tr>
      <tr>
        <td nowrap="nowrap"><p style="text-align: right;">LOGO地址</p></td>
        <td nowrap="nowrap"><span id="sprytextfield2">
          <label>
            <input name="Logo" type="text" id="Logo" value="<%=___GetConfigValue("Logo")%>" size="60" />
          </label>
        <span class="textfieldRequiredMsg">需要提供一个值。</span></span></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap">关键字</td>
        <td nowrap="nowrap"><span id="sprytextfield3">
          <label>
            <input name="Keyword" type="text" id="Keyword" value="<%=___GetConfigValue("Keyword")%>" size="60" />
          </label>
</span></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap"><p>摘要</p></td>
        <td nowrap="nowrap"><span id="sprytextfield4">
          <label>
            <input name="Description" type="text" id="Description" value="<%=___GetConfigValue("Description")%>" size="60" />
          </label>
</span></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap">底部版权HTML</td>
        <td nowrap="nowrap"><span id="sprytextarea3">
          <label>
            <textarea name="Copyright" id="Copyright" cols="60" rows="5"><%=___GetConfigValue("Copyright")%></textarea>
          </label>
</span></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap">菜单HTML</td>
        <td nowrap="nowrap"><span id="sprytextarea1">
          <label>
            <textarea name="Menu" id="Menu" cols="60" rows="5"><%=___GetConfigValue("Menu")%></textarea>
          </label>
</span></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap">广告HTML</td>
        <td nowrap="nowrap"><span id="sprytextarea2">
          <label>
            <textarea name="Ads" id="Ads" cols="60" rows="5"><%=___GetConfigValue("Ads")%></textarea>
          </label>
</span></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap">根目录</td>
        <td nowrap="nowrap"><span id="sprytextfield6">
          <label>
            <input name="Root" type="text" id="Root" value="<%=___GetConfigValue("Root")%>" size="45" />
          </label>
</span></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap">标签类型</td>
        <td nowrap="nowrap"><span id="sprytextfield7">
          <label>
            <input name="TagType" type="text" id="TagType" value="<%=___GetConfigValue("TagType")%>" size="45" />
          </label>
</span></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap">用户数据中心地址</td>
        <td nowrap="nowrap"><span id="sprytextfield8">
          <label>
            <input name="GetUserDateUrl" type="text" id="GetUserDateUrl" value="<%=___GetConfigValue("GetUserDateUrl")%>" size="45" />
          </label>
        <span class="textfieldRequiredMsg">需要提供一个值。</span></span></td>
      </tr>
    </table>
 <p>
      <b><br />
      插件高级选项</b> （谨慎对待） </p>
 <table cellpadding="0" cellspacing="6" style="width: 600px; border: solid 1px #FF0000; background-color: #FEF693;">
   <tr>
     <td width="84" align="right" nowrap="nowrap">插件名称</td>
     <td width="496" nowrap="nowrap"><span id="sprytextfield_api_name">
       <label>
         <input type="text" name="api_name" id="api_name" value="<%=___GetConfigValue("api_name")%>" size="45" />
         </label>
       <span class="textfieldRequiredMsg">需要提供一个值。</span></span></td>
</tr>
   <tr>
     <td align="right" nowrap="nowrap">配置地址</td>
     <td nowrap="nowrap"><span id="sprytextfieldapi_config_path">
       <label>
         <input type="text" name="api_config_path" id="api_config_path" value="<%=___GetConfigValue("api_config_path")%>" size="45" />
         </label>
       <span class="textfieldRequiredMsg">需要提供一个值。</span></span></td>
</tr>
   <tr>
     <td align="right" nowrap="nowrap">卸载地址</td>
     <td nowrap="nowrap"><span id="sprytextfieldapi_del">
       <label>
         <input type="text" name="api_del" id="api_del" value="<%=___GetConfigValue("api_del")%>" size="45" />
         </label>
       <span class="textfieldRequiredMsg">需要提供一个值。</span></span></td>
</tr>
   <tr>
     <td nowrap="nowrap"><p style="text-align: right;">查看地址</p></td>
     <td nowrap="nowrap"><span id="sprytextfieldapi_see">
       <label>
         <input type="text" name="api_see" id="api_see" value="<%=___GetConfigValue("api_see")%>" size="45" />
         </label>
       <span class="textfieldRequiredMsg">需要提供一个值。</span></span></td>
</tr>
   <tr>
     <td nowrap="nowrap"><p style="text-align: right;">插件描述</p></td>
     <td nowrap="nowrap"><span id="sprytextareaapi_description">
       <label>
         <textarea name="api_description" id="api_description" cols="45" rows="5"><%=___GetConfigValue("api_description")%></textarea>
         </label>
       <span class="textareaRequiredMsg">需要提供一个值。</span></span></td>
</tr>
   <tr> </tr>
   <tr> </tr>
   <tr> </tr>
   <tr> </tr>
   <tr> </tr>
 </table>
 <p>
      <asp:Button ID="SAVE" runat="server" Text="保存" onclick="SAVE_Click" />
      <input type="submit" name="btnCancel" value="取消" id="btnCancel" title="点击这里取消更改" />
      <span id="lblConfigResult"></span>
    </p>
<uc2:Footer ID="Footer1" runat="server" />
  </div>
  <script type="text/javascript">
<!--
var sprytextfield1 = new Spry.Widget.ValidationTextField("sprytextfield1");
var sprytextfield2 = new Spry.Widget.ValidationTextField("sprytextfield2");
var sprytextfield3 = new Spry.Widget.ValidationTextField("sprytextfield3", "none", {isRequired:false});
var sprytextfield4 = new Spry.Widget.ValidationTextField("sprytextfield4", "none", {isRequired:false});
var sprytextarea1 = new Spry.Widget.ValidationTextarea("sprytextarea1", {isRequired:false});
var sprytextarea2 = new Spry.Widget.ValidationTextarea("sprytextarea2", {isRequired:false});
var sprytextfield6 = new Spry.Widget.ValidationTextField("sprytextfield6", "none", {isRequired:false});
var sprytextfield7 = new Spry.Widget.ValidationTextField("sprytextfield7", "none", {isRequired:false});
var sprytextfield8 = new Spry.Widget.ValidationTextField("sprytextfield8");
var sprytextarea3 = new Spry.Widget.ValidationTextarea("sprytextarea3", {isRequired:false});
var sprytextfield5 = new Spry.Widget.ValidationTextField("sprytextfield_api_name");
var sprytextfield9 = new Spry.Widget.ValidationTextField("sprytextfieldapi_config_path");
var sprytextfield10 = new Spry.Widget.ValidationTextField("sprytextfieldapi_del");
var sprytextfield11 = new Spry.Widget.ValidationTextField("sprytextfieldapi_see");
var sprytextarea4 = new Spry.Widget.ValidationTextarea("sprytextareaapi_description");
//-->
</script>
<%}
  else
  { %>
   <p style="margin:20px;"> 你没有权限操作！
     <a href="/admin/index.aspx?url=app_blog/admin/administrator.aspx">登录</a>
   </p>
  
<%} %>
</form>
<script type="text/javascript">
<!--
var sprytextarea4 = new Spry.Widget.ValidationTextarea("sprytextareaapi_description");
var sprytextfield11 = new Spry.Widget.ValidationTextField("sprytextfieldapi_see");
var sprytextfield10 = new Spry.Widget.ValidationTextField("sprytextfieldapi_del");
var sprytextfield5 = new Spry.Widget.ValidationTextField("sprytextfield_api_name");
var sprytextfield9 = new Spry.Widget.ValidationTextField("sprytextfieldapi_config_path");
//-->
</script>
</body>
</html>
