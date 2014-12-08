<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPost.aspx.cs" Inherits="ROYcms.Blog.Web.App_Blog.EditPost" ValidateRequest="false" %>
<%@ Register src="Top.ascx" tagname="Top" tagprefix="uc1" %>
<%@ Register src="Footer.ascx" tagname="Footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<title></title>
<script src="/administrator/webui/SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<script src="/administrator/webui/SpryAssets/SpryValidationTextarea.js" type="text/javascript"></script>
<link href="/administrator/webui/SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css" />
<link href="/administrator/webui/SpryAssets/SpryValidationTextarea.css" rel="stylesheet" type="text/css" />
 <script type="text/javascript" charset="utf-8" src="/administrator/webui/kindeditor/kindeditor.js"></script>
 <link rel="stylesheet" type="text/css" href="Admin.css" />
</head>
<body>
<form id="Myform" runat="server">
<%if (ROYcms.Common.Session.Get("user_id") != null)
  { %>
   <script type="text/javascript">
       KE.show({
           id: 'content',
           resizeMode: 1,
           cssPath: '/administrator/webui//skins/default.css',
           items: [
        'fontname', 'fontsize', 'textcolor', 'bgcolor', 'bold', 'italic', 'underline',
        'removeformat', 'justifyleft', 'justifycenter', 'justifyright', 'insertorderedlist',
        'insertunorderedlist', 'emoticons', 'image', 'link']
       });
  </script>
<div id="MainDiv">

    <uc1:Top ID="Top1" runat="server" />

    <br />
    <p><b>新建博客文章</b></p>
    <table cellpadding="0" cellspacing="6" style="width: 600px; border: solid 1px #555555; background-color: #F0F0F0;">
      <tr>
        <td align="right" nowrap="nowrap">标 题</td>
        <td nowrap="nowrap"><span id="sprytextfield1">
          <label>
            <input name="title" type="text" id="title"  value='<%=Show("{title}") %>' size="80" />
          </label>
        <span class="textfieldRequiredMsg">需要提供一个值</span></span></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap">关 键 字</td>
        <td nowrap="nowrap"><span id="sprytextfield3">
          <label>
            <input name="keyword" type="text" id="keyword" value='<%=Show("{keyword}") %>' size="80" />
          </label>
</span></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap">描 述</td>
        <td nowrap="nowrap"><span id="sprytextarea1">
          <label>
            <textarea name="description" id="description" cols="50" rows="3"> <%=Show("{description}")%></textarea>
          </label>
</span></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap">内 容</td>
        <td nowrap="nowrap">
          <label>
            <textarea name="content" id="content" cols="100" rows="20"><%=Show("{content}")%></textarea>
          </label>
          </td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap"><p style="text-align: right;">标 签</p></td>
        <td nowrap="nowrap"><span id="sprytextfield2">
          <label>
            <input name="tag" type="text" id="tag" size="50" value='<%=Show("{tag}") %>' />
          </label>
        </span>请用逗号，隔开</td>
      </tr>
    </table>
    
<p style=" margin:10px 0px 10px 0px;">
<input type="submit" name="button" id="button" value="确认提交" />
<input type="submit" name="btnCancel" value="取消" id="btnCancel" title="点击这里取消更改" />
</p>
  <uc2:Footer ID="Footer1" runat="server" /> 
<script type="text/javascript">
<!--
var sprytextfield1 = new Spry.Widget.ValidationTextField("sprytextfield1");
var sprytextfield2 = new Spry.Widget.ValidationTextField("sprytextfield2", "none", { isRequired: false });
var sprytextfield3 = new Spry.Widget.ValidationTextField("sprytextfield3", "none", {isRequired:false});
//-->
</script>
  </div>
<%}
  else
  { %>
   <p style="margin:20px;"> 你没有登录请先登录才能发表自己的博客文章现在
      <a href="/ucenter/login.aspx?url=app_blog/admin/config.aspx">登录</a>
      或
      <a href="/ucenter/reg.aspx?url=app_blog/admin/config.aspx">注册</a>
    </p>
  
<%} %>
</form>
</body>
</html>
