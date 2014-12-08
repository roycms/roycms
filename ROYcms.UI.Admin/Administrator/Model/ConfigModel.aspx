<%@ Page Language="C#" AutoEventWireup="true"  Inherits="ROYcms.UI.Admin.Administrator.Model.ConfigModel" CodeBehind="ConfigModel.aspx.cs" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<title></title>
</head>
<body>
<form id="ConfigModelForm" >
  <Resources:Resources ID="Resources1" runat="server" />
  <script language="JavaScript" type="text/JavaScript" src="/administrator/js/ConfigModel.js"></script>
  <script language="JavaScript" type="text/JavaScript" src="/administrator/js/jquery.dragsort-0.5.1.min.js"></script>
        <script type="text/javascript" charset="utf-8" src="/administrator/editor/kindeditor.js"></script>
        <script type="text/javascript" charset="utf-8" src="/administrator/editor/lang/zh_CN.js"></script>
  
  <!--工具栏开始-->
  <table width="100%" border="0" class="tiao_top">
    <tr>
      <td width="77%" nowrap><div class="tiao_con"> 
      <a><img align="absmiddle" src="/administrator/images/nv6.png" />
      
      当前初始化状态：<%= new ROYcms.Sys.BLL.CMS().Exists(Request["TableName"]) == true ? "成功" : "未初始化"%>
      </a>  </div>
      </td>
      <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
    </tr>
  </table>
  <!--工具栏结束-->
  <table width="100%" border="0">
    <tr>
      <td width="822" height="235" valign="top">
      <table width="100%" border="0" cellpadding="3" cellspacing="1" bgcolor="#FF3300" style="margin-bottom:5px; margin-top:5px;">
        <tr>
          <td bgcolor="#FFFFCC">下面为默认的模型和您已经定义的模型</td>
        </tr>
      </table>
      <div id="FieldHtml"></div>
        
        
        
        </td>
      <td width="160" valign="top"><table width="100%" border="0" cellpadding="2" cellspacing="1" bgcolor="#999999" style=" margin-top:5px;">
          <tr>
            <td bgcolor="#E1E1E1"><label>
                <input name="InputType" type="radio" id="InputType_0" value="1" checked="checked" />
                文本框</label>
                 <label>
                <input type="radio" name="InputType" value="2" id="InputType_1" />
                多行文本</label>
              <label>
                <input type="radio" name="InputType" value="3" id="InputType_2" />
                单选</label>
                <label>
                <input type="radio" name="InputType" value="4" id="InputType_3" />
                复选框</label>
                 <label>
                <input type="radio" name="InputType" value="5" id="InputType_4" />
                下拉列表</label>
                <label>
                 <input type="radio" name="InputType" value="6" id="InputType_5" />
                Editor编辑器</label>
                 <label>
                 <input type="radio" name="InputType" value="7" id="InputType_6" />
                上传图片</label>
                 <label>
                 <input type="radio" name="InputType" value="8" id="InputType_7" />
                上传文件</label>
                 
            </td>
          </tr>
        </table>
        <table width="100%" border="0" cellpadding="2" cellspacing="1" style="border:1px;" bgcolor="#999999">
          <tr>
            <td bgcolor="#FCFCFC">标签</td>
            <td bgcolor="#FCFCFC"><input type="hidden" name="Rid" value='<%= Request["Rid"] %>' id="Rid" />
            <input name="Expression" type="hidden" id="Expression"  />
            <input name="Lable" type="text" id="Lable" size="15" class="txtInput"   /></td>
          </tr>
          <tr>
            <td bgcolor="#FCFCFC">名称</td>
            <td bgcolor="#FCFCFC"><input name="Name" type="text" id="Name" size="15" class="txtInput"  /></td>
          </tr>
          <tr>
            <td bgcolor="#FCFCFC">可输入字数</td>
            <td bgcolor="#FCFCFC"><input name="Len" type="text" id="Len" value="50" size="8" class="txtInput"  /></td>
          </tr>
          <tr>
            <td bgcolor="#FCFCFC">默认值</td>
            <td bgcolor="#FCFCFC"><input name="DefaultVal" type="text" id="DefaultVal" size="15" class="txtInput"   /></td>
          </tr>
          <tr>
            <td bgcolor="#FCFCFC">排序</td>
            <td bgcolor="#FCFCFC"><input name="OrderBy" type="text" id="OrderBy" value="1" size="8" class="txtInput"  /></td>
          </tr>
          <tr>
            <td bgcolor="#FCFCFC">显示长度</td>
            <td bgcolor="#FCFCFC"><input name="InputLen" type="text" id="InputLen" value="200" size="8" class="txtInput"   />
              px</td>
          </tr>
          <tr>
            <td bgcolor="#FCFCFC">&nbsp;</td>
            <td bgcolor="#FCFCFC"><label>
                <input name="FieldType" type="checkbox" id="FieldType" value="1" />
            是否是数字</label></td>
          </tr>
          <tr>
            <td bgcolor="#FCFCFC">&nbsp;</td>
            <td bgcolor="#FCFCFC"><label>
                <input name="Display" type="checkbox" id="Display" value="1" checked="checked" />
            是否在页面显示</label></td>
          </tr>
          <tr>
            <td bgcolor="#FCFCFC">&nbsp;</td>
            <td bgcolor="#FCFCFC"><label>
                <input name="IsKey" type="checkbox" id="IsKey" value="1" />
            是否为主键</label></td>
          </tr>
          <tr>
            <td bgcolor="#FCFCFC"></td>
            <td bgcolor="#FCFCFC"><label>
                <input name="IsNull" type="checkbox" id="IsNull" value="1" checked="checked" />
            是否为空</label></td>
          </tr>
          <tr>
            <td bgcolor="#FCFCFC"></td>
            <td bgcolor="#FCFCFC"><input type="button" name="ConfigModelBT" id="ConfigModelBT" value="保存"  class="btnSubmit"  />
              <input type="reset" name="noBT" id="noBT" value="重置"   class="btnSubmit"  /></td>
          </tr>
        </table>
        <table width="100%" border="0" cellpadding="2" cellspacing="1" bgcolor="#999999" style="margin-top:15px;">
          <tr>
            <td bgcolor='<%= new ROYcms.Sys.BLL.CMS().Exists(Request["TableName"]) == true ? "#009933" : "#FF9999"%>'>
            <input type="hidden" name="ModelId" id="ModelId" value='<%=Request["Rid"]%>' />
              <input type="hidden" name="TableName" id="TableName" value='<%=Request["TableName"]%>' />
            当前初始化状态：<%= new ROYcms.Sys.BLL.CMS().Exists(Request["TableName"]) == true ? "成功" : "未初始化"%>
            <input type="button" name="GreatTableBT" id="GreatTableBT" value="生成数据模型"   class="btnSubmit"  />
            </td>
          </tr>
        </table></td>
    </tr>
  </table>
</form>
	<script type="text/javascript">
		$(".FieldHtml").dragsort({ dragSelector: "tr"});
		
	</script>
</body>
</html>
