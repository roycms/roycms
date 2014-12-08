<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewList.aspx.cs" Inherits="ROYcms.UI.Admin.NewList" %>
<!DOCTYPE HTML>
<html >
<body>
<form id="KNewHtmlForm" runat="server">
  <table width="100%" border="0" cellspacing="3" cellpadding="0">
    <tr>
      <td align="right" nowrap="nowrap">
          
          生成选项 <input type="hidden" name="DdClass" id="DdClass" value="<%=ROYcms.Common.Request.GetQueryInt("Id") %>" /> </td>
      <td align="left" nowrap="nowrap"><label>
          <input name="StaticHtmlType1" type="checkbox" id="StaticHtmlType1" style="vertical-align:middle;" value="1" checked />
          封面频道</label>
        <label>
          <input type="checkbox" name="StaticHtmlType2" value="2" id="StaticHtmlType1" style="vertical-align:middle;" />
          列表频道</label>
        <label>
          <input type="checkbox" name="StaticHtmlType3" value="3" id="StaticHtmlType3" style="vertical-align:middle;" />
          频道内文章</label></td>
    </tr>
    <tr>
      <td align="right" nowrap="nowrap">列表数</td>
      <td align="left" nowrap="nowrap"><input type="text" name="ListCon" id="ListCon" class="txtInput" value="10" />分页的页数</td>
    </tr>
    <tr>
      <td align="right" nowrap="nowrap">文章数</td>
      <td align="left" nowrap="nowrap"><input type="text" name="ArticleCon" id="ArticleCon" class="txtInput" value="0" />0 生成全部</td>
    </tr>
    <tr>
      <td align="right" nowrap="nowrap">文章开始结束ID</td>
      <td align="left" nowrap="nowrap"><input name="ArticleStar" type="text" id="ArticleStar" size="6"  class="txtInput"  />
        -
        <input name="ArticleEnd" type="text" id="ArticleEnd" size="6"  class="txtInput"  />
        <input type="button" name="KNewHtmlBT" id="KNewHtmlBT" value="生成"  class="btnSearch" /></td>
    </tr>
  </table>
</form>
</body>
</html>
