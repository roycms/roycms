<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewList.aspx.cs" Inherits="ROYcms.UI.Admin.NewList" %>
<!DOCTYPE HTML>
<html >
<body>
<form id="KNewHtmlForm" runat="server">
  <table width="100%" border="0" cellspacing="3" cellpadding="0">
    <tr>
      <td align="right" nowrap="nowrap">生成选项 <input type="hidden" name="Class" id="Class" value="<%=ROYcms.Common.Request.GetQueryInt("Id") %>" /> </td>
      <td align="left" nowrap="nowrap"><label>
          <input name="StaticHtmlType" type="checkbox" id="StaticHtmlType_1" style="vertical-align:middle;" value="1" checked />
          封面频道</label>
        <label>
          <input type="checkbox" name="StaticHtmlType_" value="2" id="StaticHtmlType_2" style="vertical-align:middle;" />
          列表频道</label>
        <label>
          <input type="checkbox" name="StaticHtmlType_" value="3" id="StaticHtmlType_3" style="vertical-align:middle;" />
          频道内文章</label></td>
    </tr>
    <tr>
      <td align="right" nowrap="nowrap">列表数</td>
      <td align="left" nowrap="nowrap"><input type="text" name="textfield4" id="textfield4" class="txtInput" /></td>
    </tr>
    <tr>
      <td align="right" nowrap="nowrap">文章数</td>
      <td align="left" nowrap="nowrap"><input type="text" name="textfield" id="textfield" class="txtInput" /></td>
    </tr>
    <tr>
      <td align="right" nowrap="nowrap">文章开始结束ID</td>
      <td align="left" nowrap="nowrap"><input name="textfield2" type="text" id="textfield2" size="6"  class="txtInput"  />
        -
        <input name="textfield3" type="text" id="textfield3" size="6"  class="txtInput"  />
        <input type="button" name="KNewHtmlBT" id="KNewHtmlBT" value="生成"  class="btnSearch" /></td>
    </tr>
  </table>
</form>
</body>
</html>
