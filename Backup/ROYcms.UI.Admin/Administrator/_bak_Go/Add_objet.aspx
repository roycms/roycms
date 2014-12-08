<%@ Page Language="C#" AutoEventWireup="true"  Inherits="ROYcms.UI.Admin.Administrator.go.Add_objet" %>
<!DOCTYPE HTML>
<html>
<head runat="server">
</head>
<body>
<form id="Add_objetForm" runat="server">
  <div>
    <table width="500" border="0">
      <tr>
        <td width="122">标识</td>
        <td width="368">
        <input name="id"  type="hidden" id="id" value='<%=Model.id %>' >
        <input name="ClassKind" type="text" id="ClassKind" value='<%=Model.ClassKind %>' size="16" >
        <a rel="Help" class="SysHelp" href="#ClassKind">?</a> 必须为有效整数</td>
      </tr>
      <tr>
        <td>标题</td>
        <td><input name="Title" type="text" id="Title" value='<%=Model.Title %>' ></td>
      </tr>
      <tr>
        <td>描述</td>
        <td><textarea name="zhaiyao" id="zhaiyao" ><%=Model.zhaiyao%></textarea></td>
      </tr>
      <tr>
        <td>图标</td>
        <td>
        <input name="logo" type="text" id="logo" value='<%=Model.logo%>' size="25" ><img id="logo_example" src="/Administrator/images/nv1.png">
        <table width="147" border="0" cellpadding="1" cellspacing="1" id="add_objet_set_logo">
          <tr>
            <td><a href="javascript:"><img src="/Administrator/images/nv1.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv2.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv3.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv4.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv5.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv6.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv7.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv8.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv9.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv10.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv11.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv12.png"></a></td>
          </tr>
        </table></td>
      </tr>
      <tr>
        <td>配置文件地址</td>
        <td><input name="AppendixConfig" type="text" id="AppendixConfig" value='<%=Model.AppendixConfig%>' >
        <a rel="Help" class="SysHelp" href="#ClassKind">?</a> 
        <a rel=facebox href="#Set_AppendixConfig" title="选择和设置配置文件地址">选择</a></td>
      </tr>
      <tr>
        <td>附件地址</td>
        <td><input name="AppendixPath" type="text" id="AppendixPath" value='<%=Model.AppendixPath%>' >
        <a rel="Help" class="SysHelp" href="#ClassKind">?</a> 
         <a rel=facebox href="#Set_AppendixPath" title="选择和设置附件地址">选择</a></td>
      </tr>
      <tr>
        <td>显示状态</td>
        <td>
<input name="VisibleVal" id="VisibleVal" type="hidden" value='<%=Model.Visible%>' >
          <select name="Visible" id="Visible">
            <option value="1">可见</option>
            <option value="0">隐藏</option>
        </select><a rel="Help" class="SysHelp" href="#ClassKind">?</a></td>
      </tr>
      <tr>
        <td>权限标识</td>
        <td><input name="RoleVal" id="RoleVal" type="hidden" value='<%=Model.Role%>' >
          <select name="Role" id="Role">
            <option value="0">默认权限</option>
            <option value="1">站群可见</option>
            <option value="2">子站可见</option>
        </select><a rel="Help" class="SysHelp" href="#ClassKind">?</a> 
          <a href="#Set_Role" title="设置权限标识" rel=facebox>设置</a></td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td><input type="button" name="Add_objetBT" id="Add_objetBT" value="提交">
        <input type="reset" name="noBT" id="noBT" value="重置"></td>
      </tr>
    </table>
  </div>
    <!--选择配置文件地址-->
  <div id="Set_AppendixConfig" style="display:none; width:320px;" >
  <a href="javascript:">/CMS_UFile/</a>
  </div>
      <!--选择附件地址-->
  <div id="Set_AppendixPath" style="display:none;width:320px;" >
  <a href="javascript:">/Administrator/App_Config/</a>
  </div>
  <!--设置权限标识-->
  <div id="Set_Role" style="display:none;width:320px;" >
  <textarea name="" cols="30" rows="3">默认权限,0;站群可见,1;子站可见,2</textarea>
  <input type="submit" name="Set_Role_Bt" id="Set_Role_Bt" value="提交">
  </div>
</form>
</body>
</html>