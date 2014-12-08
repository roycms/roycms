<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Config.aspx.cs" Inherits="ROYcms.Blog.Web.App_Blog.Admin.Config" ValidateRequest="false" %>
<%@ Register src="Top.ascx" tagname="Top" tagprefix="uc1" %>
<%@ Register src="Footer.ascx" tagname="Footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<title></title>
<script src="/administrator/webui/SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<script src="/administrator/webui/SpryAssets/SpryValidationTextarea.js" type="text/javascript"></script>
<script src="/administrator/webui/SpryAssets/SpryValidationSelect.js" type="text/javascript"></script>
<link href="/administrator/webui/SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="Admin.css" />

<link href="/administrator/webui/SpryAssets/SpryValidationTextarea.css" rel="stylesheet" type="text/css" />
<link href="/administrator/webui/SpryAssets/SpryValidationSelect.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="ConfigForm" runat="server">
<%if (ROYcms.Common.Session.Get("user_id") != null)
  { %>
<div id="MainDiv">

    <uc1:Top ID="Top1" runat="server" />

    <br />
    <p><b>常规选项</b></p>
    <table cellpadding="0" cellspacing="6" style="width: 600px; border: solid 1px #555555; background-color: #F0F0F0;">
      <tr>
        <td nowrap="nowrap"><p style="text-align: right;">博客访问地址</p></td>
        <td nowrap="nowrap">
        <input name="Url" type="text" id="Url" style="width:300px;" value="/blog-<%=ROYcms.Common.Session.Get("user_id") %>/default.html" readonly="readonly" />
        只读不可修改</td>
      </tr>
      <tr>
        <td nowrap="nowrap"><p style="text-align: right;">博客标题</p></td>
        <td nowrap="nowrap"><span id="sprytextfield1">
          <label>
            <input name="BlogTitle" type="text" id="BlogTitle" size="60" value='<%=___GetBlogValue(ROYcms.Common.Session.Get("user_id"),"BlogTitle")%>' />
          </label>
          <span class="textfieldRequiredMsg">需要提供一个值</span></span></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap">博客副标题</td>
        <td nowrap="nowrap"><span id="sprytextfield4">
          <label>
            <input name="SubBlogTitle" type="text" id="SubBlogTitle" size="60" value='<%=___GetBlogValue(ROYcms.Common.Session.Get("user_id"),"SubBlogTitle")%>'  />
          </label>
</span></td>
      </tr>
      <tr>
        <td nowrap="nowrap"><p style="text-align: right;">关键字</p></td>
        <td nowrap="nowrap"><span id="sprytextfield2">
          <label>
            <input name="KeyWord" type="text" id="KeyWord" size="60"  value='<%=___GetBlogValue(ROYcms.Common.Session.Get("user_id"),"KeyWord")%>'   />
          </label>
        <span class="textfieldRequiredMsg">需要提供一个值</span></span></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap"><p>摘要</p></td>
        <td nowrap="nowrap"><span id="sprytextfield3">
          <label>
            <textarea name="Description" cols="60" rows="4" id="Description" ><%=___GetBlogValue(ROYcms.Common.Session.Get("user_id"),"Description")%></textarea>
          </label>
        <span class="textfieldRequiredMsg">需要提供一个值</span></span></td>
      </tr>
      <tr>
        <td nowrap="nowrap"><p style="text-align: right;">联系人EMail</p></td>
        <td nowrap="nowrap"><input name="ContactEmail" type="text" value='<%=___GetBlogValue(ROYcms.Common.Session.Get("user_id"),"ContactEmail")%>'  id="ContactEmail" title="输入联系人Email地址" style="width:300px;" /></td>
      </tr>
      <tr>
        <td nowrap="nowrap"><p style="text-align: right;">发件人Email</p></td>
        <td nowrap="nowrap"><input name="SenderEmail" type="text"  value='<%=___GetBlogValue(ROYcms.Common.Session.Get("user_id"),"SenderEmail")%>'  id="SenderEmail" title="这里输入发件人Email地址" style="width:300px;" /></td>
      </tr>
      <tr>
        <td nowrap="nowrap"><p style="text-align: right;">HTML布局模版</p></td>
        <td nowrap="nowrap"><span id="spryselect1">
          <label>
            <select name="BlogUi" id="BlogUi">
              <option value="default" selected="selected">default默认</option>
              <option value="baidu">百度空间HTML</option>
              <option value="sina">新浪博客HTNL</option>
            </select>
            
          </label>
        <span class="selectRequiredMsg">请选择一个项目。</span></span>
        CSS样式模版
         <label>
            <select name="CssUi" id="CssUi">
              <option value="red">red</option>
              <option value="small">small</option>
              <option value="huise">huise</option>
              <option value="news_red">news_red</option>
              
            </select>
            
          </label>
          
          <script language="JavaScript">
<!--
for (i=0;i<document.ConfigForm.BlogUi.options.length;i++)
{ 
     if(document.ConfigForm.BlogUi.options[i].value=="<%=___GetBlogValue(ROYcms.Common.Session.Get("user_id"),"BlogUi")%>")
     {
         document.ConfigForm.BlogUi.options[i].selected=true;break;
     }
}
for (i=0;i<document.ConfigForm.CssUi.options.length;i++)
{ 
     if(document.ConfigForm.CssUi.options[i].value=="<%=___GetBlogValue(ROYcms.Common.Session.Get("user_id"),"CssUi")%>")
     {
         document.ConfigForm.CssUi.options[i].selected=true;break;
     }
}
//-->
</script>

        </td>
      </tr>
    </table>
    <br />
    <p>
      <b>高级选项</b> （谨慎对待） </p>
    <table cellpadding="0" cellspacing="6" style="width: 600px; border: solid 1px #FF0000; background-color: #FEF693;">
      <tr>
        <td width="84" nowrap="nowrap">&nbsp;</td>
        <td width="496" nowrap="nowrap"><span title="点击这里禁用管理主页的版本自动检查">
          <input id="UiCheck" type="checkbox" name="UiCheck" />
          <label for="UiCheck">关闭自动模版更新检查</label>
          </span></td>
      </tr>
      <tr>
        <td nowrap="nowrap">&nbsp;</td>
        <td nowrap="nowrap"><input id="CacheCheck" type="checkbox" name="CacheCheck" />
          <label for="CacheCheck">禁用缓存</label></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap">顶部HTML</td>
        <td nowrap="nowrap"><span id="sprytextarea2">
          <label>
            <textarea name="TopHtml" id="TopHtml" cols="60" rows="5"><%=___GetBlogValue(ROYcms.Common.Session.Get("user_id"),"TopHtml")%></textarea>
          </label>
        </span></td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap">底部HTML</td>
        <td nowrap="nowrap"><span id="sprytextarea3">
          <label>
            <textarea name="EndHtml" id="EndHtml" cols="60" rows="5" ><%=___GetBlogValue(ROYcms.Common.Session.Get("user_id"),"EndHtml")%></textarea>
          </label>
</span></td>
      </tr>
      <tr>
        <td nowrap="nowrap"><p style="text-align: right;">博客分类</p></td>
        <td nowrap="nowrap"><span id="sprytextarea1">
          <label>
            <textarea name="Class" id="Class" cols="60" rows="3" ><%=___GetBlogValue(ROYcms.Common.Session.Get("user_id"),"Class")%></textarea>请用竖线|分开
          </label>
</span></td>
      </tr>
       <tr>
        <td nowrap="nowrap"><p style="text-align: right;">博客CSS样式</p></td>
        <td nowrap="nowrap">
          <label>
            <textarea name="BlogCss" id="BlogCss" cols="60" rows="6" ><%=___GetBlogValue(ROYcms.Common.Session.Get("user_id"),"BlogCss")%></textarea>
          </label>
      </td>
      </tr>
    </table>
    <br />
    <p>
        <asp:Button ID="SAVE" runat="server" Text="保存" onclick="SAVE_Click" />
      <input type="submit" name="btnCancel" value="取消" id="btnCancel" title="点击这里取消更改" />
      <span id="lblConfigResult"></span>
    </p>
    
    
    
<script type="text/javascript">
<!--
var sprytextfield1 = new Spry.Widget.ValidationTextField("sprytextfield1");
var sprytextfield2 = new Spry.Widget.ValidationTextField("sprytextfield2");
var sprytextfield3 = new Spry.Widget.ValidationTextField("sprytextfield3");
var sprytextarea1 = new Spry.Widget.ValidationTextarea("sprytextarea1", {isRequired:false});
var spryselect1 = new Spry.Widget.ValidationSelect("spryselect1");
//-->
</script>
<uc2:Footer ID="Footer1" runat="server" />
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
