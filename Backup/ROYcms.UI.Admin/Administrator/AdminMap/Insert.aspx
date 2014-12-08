<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.AdminMap.Insert" %>
<!DOCTYPE HTML>
<html>
<body>
<form id="AdminMapForm" runat="server">
    <table width="360" border="0">
      <tr>
        <td>功能模块名称</td>
        <td>
        <input name="Id" type="hidden" id="Id" value="<%=Model.Id %>" />
        <input name="Name" type="text" id="Name" class="txtInput" value="<%=Model.Name %>" /></td>
      </tr>
      <tr>
        <td>功能模块后台URL地址</td>
        <td><input type="text" name="Path" id="Path" class="txtInput" value="<%=Model.Path %>" /></td>
      </tr>
     
      <tr>
        <td>功能模块描述</td>
        <td><textarea name="Description" id="Description" ><%=Model.Description%></textarea></td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td><input type=button name="AdminMapBT" id="AdminMapBT" value="提交" class="btnSearch" />          
        <input type="reset" name="noBT" id="noBT" value="重置" class="btnSearch"  /></td>
      </tr>
    </table>

</form>
</body>
</html>
