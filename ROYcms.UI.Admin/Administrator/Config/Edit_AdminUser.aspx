<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator.config.Edit_AdminUser" %>
<!DOCTYPE HTML>
<html>
<body>
<form id="Edit_AdminUserForm" runat="server">
    <table cellSpacing="2" cellPadding="2" width="360" border="0">
      <tr>
        <td height="25" width="30%" align="right">登录名：</td>
        <td height="25" width="*" align="left">
        <input name="id"  type="hidden" id="id" value='<%=Model.id %>' >
        <input name="classkind" type="hidden" type="text" id="classkind" size="15" value='1'>
        <input name="name" id="name" type="text" value='<%=Model.name %>' class="txtInput">
        </td>
      </tr>
      <tr>
        <td height="25" align="right">密码：</td>
        <td height="25" align="left"><input name="password" id="password" type="password" value='<%=Model.password%>' class="txtInput"></td>
      </tr>
      <tr>
        <td height="25" width="30%" align="right">再次输入密码：</td>
        <td height="25" width="*" align="left">
        <input name="password2" id="password2" type="password" value='<%=Model.password%>'  class="txtInput">
        </td>
      </tr>
     
      <tr>
        <td height="25" align="right">权限标识：</td>
        <td height="25" align="left">
        <input name="RolVal" id="RolVal" type="hidden" value='<%=Model.Rol %>' >
        <select name="Rol" id="Rol" class="select" style=" width:200px;">
          <option value="0">超级管理员(全权限)</option>
            <option value="1">管理员(部分管理权限)</option>
            <option value="2">新闻发布员(信息管理发布权限)</option>
            <option value="3">审稿员(信息审阅权限)</option>
            <option value="4">来宾用户(只读权限)</option>
          </select>
         </td>
      </tr>
      <tr>
        <td height="25" width="30%" align="right">&nbsp;</td>
        <td height="25" width="*" align="left">
        <input type="button" name="Edit_AdminUserBT" id="Edit_AdminUserBT" value="提交" class="btnSearch">
        <input type="reset" name="noBT" id="noBT" value="重置" class="btnSearch"></td>
      </tr>
    </table>
</form>
</body>
</html>
