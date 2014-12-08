<%@ Page Language="C#" AutoEventWireup="true"  Inherits="ROYcms.UI.Admin.Administrator.Model.AddModel" %>
<!DOCTYPE HTML>
<html>
<body>
<form id="AddModeForm" runat="server">
    <table width="360" border="0">
      <tr>
        <td>模型名称</td>
        <td><input name="Name" type="text" id="Name" class="txtInput" /></td>
      </tr>
      <tr>
        <td>表格名字（英文）</td>
        <td><input type="text" name="TableName" id="TableName" class="txtInput"  /></td>
      </tr>
      <tr>
        <td>应用类别</td>
        <td><select name="ModelType" id="ModelType"  class="select" style=" width:200px;">
          <option value="0">通用类型</option>
          <option value="1">新闻类</option>
          <option value="2">下载类</option>
          <option value="3">视频类</option>
        </select></td>
      </tr>
      <tr>
        <td>模型描述</td>
        <td><textarea name="ModelDescription" id="ModelDescription" ></textarea></td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td><input type=button name="AddModelBT" id="AddModelBT" value="提交" class="btnSearch" />       
           <input type="reset" name="noBT" id="noBT" value="重置" class="btnSearch" /></td>
      </tr>
    </table>

</form>
</body>
</html>
