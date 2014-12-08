<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertBrand.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.MyShop.InsertBrand" %>

<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title></title>
</head>
<body>
<form id="InsertBrandForm" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <link rel="stylesheet" href="/administrator/editor/themes/default/default.css" />
  <script type="text/javascript" charset="utf-8" src="/administrator/editor/kindeditor.js"></script> 
  <script type="text/javascript" charset="utf-8" src="/administrator/editor/lang/zh_CN.js"></script>
  <div id="rotate"> 
    <!--工具栏开始-->
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con"> <a href='/administrator/myshop/AdminBrand.aspx'><img align="absmiddle" src="/administrator/images/nv9.png" />返回品牌列表</a> </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
    <!--工具栏结束-->
    <div class="tagMenu">
      <ul class="menu1">
        <li>品牌基本信息</li>
      </ul>
    </div>
    <div class="content1" style="padding:0px; margin-top:3px;">
      <div class="layout">
        <table  cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
            <tr>
            <td width="11%" align="right" bgcolor="#F4FBFF"><strong>品牌名称</strong></td>
            <td width="89%" bgcolor="#F4FBFF"><input name="Name" type="text" class="txtInput" id="Name" value="<% =Model.Name%>" size="35" />
              <input type="hidden" name="Id" id="Id" value="<% =Model.Id%>"  /></td>
            </tr>
            <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>品牌Logo</strong></td>
            <td bgcolor="#F4FBFF"><input name="Logo" type="text" id="Logo" size="35" class="txtInput" value="<% =Model.Logo%>"  />
              <a id="BrandLogoclick" href="#" class="btnSearch" style="padding:2px;"> 选择 </a>
              
                          <script>
                              KindEditor.ready(function (K) {
                                  var editor = K.editor({
                                      cssPath: '/Administrator/Editor/plugins/code/prettify.css',
                                      uploadJson: '/Administrator/Editor/C/upload_json.ashx?root=Brand,All',
                                      fileManagerJson: '/Administrator/Editor/C/file_manager_json.ashx?root=Brand,All',
                                      allowFileManager: true
                                  });
                                  K('#BrandLogoclick').click(function () {
                                      editor.loadPlugin('image', function () {
                                          editor.plugin.imageDialog({
                                              imageUrl: K('#Logo').val(),
                                              clickFn: function (url, title, width, height, border, align) {
                                                  K('#Logo').val(url);
                                                  editor.hideDialog();
                                              }
                                          });
                                      });
                                  });
                              });	
		                        </script>
              
              </td>
            </tr>
            <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>品牌介绍</strong></td>
            <td bgcolor="#F4FBFF"><textarea name="brand_desc" cols="40" rows="2" id="brand_desc"><% =Model.brand_desc%></textarea></td>
            </tr>
            <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>网址</strong></td>
            <td bgcolor="#F4FBFF"><input name="site_url" type="text" id="site_url" size="35" class="txtInput"  value="<% =Model.site_url%>"  /></td>
            </tr>
            <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>排序 </strong></td>
            <td bgcolor="#F4FBFF">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="8%"><input name="sort_order" type="text" id="sort_order" size="10" class="txtInput"  value="<% =Model.sort_order%>"  /></td>
                <td width="92%"> <div id="slide_sort_order" style=" width:180px; margin-left:20px;"></div>
                
                 <script>
                              $(function () {
                                  $("#slide_sort_order").slider(
								  { Max: 100 },
								  { Min: 1 },
								  { slide: function (event, ui) { $("#sort_order").val(ui.value); } }

			                       );
                              });    
                  </script>
                </td>
              </tr>
            </table>

                         
              
              </td>
            </tr>
            <tr>
            <td align="right" bgcolor="#F4FBFF">&nbsp;</td>
            <td bgcolor="#F4FBFF">
              
              <label><input name="is_show" type="checkbox" id="is_show" value="1" checked="checked" /><strong>是否前端显示</strong></label>
              该品牌是否显示，0，否；1，显示</td>
            </tr>
        </table>
      </div>
    </div>
    <div style="margin-left:100px; margin-top:10px;">
      <input type="button" name="InsertBrandBT" id="InsertBrandBT" value="确认提交"  class="btnSubmit" />
      <input type="reset" name="button2" id="button2" value="重置" class="btnSubmit" />
    </div>
  </div>
</form>
</body>
</html>
