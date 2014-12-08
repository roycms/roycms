<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.NewHtml.Index" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title></title>
</head>
<body>
<form id="NewHtmlForm" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <div> 
    <!--工具栏开始-->
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con"> <a href=' /Administrator/config/AdminPassword.aspx'><img align="absmiddle" src="/administrator/images/nv9.png" />返回会员管理</a> </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
    <!--工具栏结束-->
    <div class="tagMenu">
      <ul class="menu1">
        <li>频道生成</li>
        <li>一键快捷生成</li>
      </ul>
    </div>
    <div class="content1" style="padding:0px; margin-top:3px;">
      <div class="layout">
        <table  cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
          <tr>
            <td width="13%" height="25" align="right" bgcolor="#F4FBFF"><strong>生成选项 </strong></td>
            <td width="87%" height="25" align="left" bgcolor="#F4FBFF"><label>
                <input name="StaticHtmlType0" type="checkbox" id="StaticHtmlType0" style="vertical-align:middle;" value="0" checked="checked" />
                首页</label>
              <label>
                <input name="StaticHtmlType1" type="checkbox" id="StaticHtmlType1" style="vertical-align:middle;" value="1" checked="checked" />
                封面频道</label>
              <label>
                <input type="checkbox" name="StaticHtmlType2" value="2" id="StaticHtmlType2" style="vertical-align:middle;" />
                列表频道</label>
              <label>
                <input type="checkbox" name="StaticHtmlType3" value="3" id="StaticHtmlType3" style="vertical-align:middle;" />
                频道内文章</label></td>
          </tr>
          <tr>
            <td height="25" align="right" bgcolor="#F4FBFF"><strong>生成对象</strong></td>
            <td height="25" align="left" bgcolor="#F4FBFF">
            <asp:DropDownList CssClass="select" ID="DdClassKind" runat="server" Width="120" 
                    AutoPostBack="True" onselectedindexchanged="DdClassKind_SelectedIndexChanged"></asp:DropDownList>
            <asp:DropDownList CssClass="select" ID="DdClass" runat="server" Width="160"></asp:DropDownList>
            
            </td>
          </tr>
          <tr>
            <td width="13%" height="25" align="right" bgcolor="#F4FBFF"><strong>列表数</strong></td>
            <td width="87%" height="25" align="left" bgcolor="#F4FBFF">
              <input type="text" name="ListCon" id="ListCon" class="txtInput" value="10" /></td>
          </tr>
          <tr>
            <td width="13%" height="25" align="right" bgcolor="#F4FBFF"><strong>生成文章数</strong></td>
            <td width="87%" height="25" align="left" bgcolor="#F4FBFF">
              <input type="text" name="ArticleCon" id="ArticleCon"  class="txtInput"  value="0"  />
              0生成全部（信息量较大时选择择一个有效的值可以降低生成的成本）</td>
          </tr>
          <tr>
            <td height="25" align="right" bgcolor="#F4FBFF"><strong>文章开始结束ID</strong></td>
            <td height="25" align="left" bgcolor="#F4FBFF">
            <input name="ArticleStar" type="text" id="ArticleStar" size="6"  class="txtInput"  />
              -
            <input name="ArticleEnd" type="text" id="ArticleEnd" size="6"  class="txtInput"  />
            </td>
          </tr>
        </table>
        

        <div style="margin-left:140px; margin-top:10px;">
          <input type="button" name="NewHtmlBT" id="NewHtmlBT" value="确认提交"  class="btnSubmit" />
          <input type="reset" name="button2" id="button2" value="重置" class="btnSubmit" />
        </div>
      </div>
      <div class="layout">
      <span id="ONE">
        <table  cellspacing="1" cellpadding="5" width="100%" border="0" bgcolor="#CCCCCC">
          <tr>
            <td width="13%" height="25" align="right" bgcolor="#F4FBFF"><strong>一键生成首页</strong></td>
            <td width="87%" height="25" align="left" bgcolor="#F4FBFF">
              <input type="button" name="ONEIndexBT" id="ONEIndexBT" value="点击生成"  class="btnSearch" />
           </td>
          </tr>
          <tr>
            <td height="25" align="right" bgcolor="#F4FBFF"><strong>一键生成站点所有文件</strong></td>
            <td height="25" align="left" bgcolor="#F4FBFF">
            <input type="button" name="ONEAllBT" id="ONEAllBT" value="点击生成"  class="btnSearch" /></td>
          </tr>
          <tr>
            <td width="13%" height="25" align="right" bgcolor="#F4FBFF"><strong>一键生成所有频道</strong></td>
            <td width="87%" height="25" align="left" bgcolor="#F4FBFF">
            <input type="button" name="ONEChannelBT" id="ONEChannelBT" value="点击生成"  class="btnSearch" /></td>
          </tr>
          <tr>
            <td width="13%" height="25" align="right" bgcolor="#F4FBFF"><strong>一键生成所有文章</strong></td>
            <td width="87%" height="25" align="left" bgcolor="#F4FBFF"><label for="textfield2"></label>
            <input type="button" name="ONEArticleBT" id="ONEArticleBT" value="点击生成"  class="btnSearch" /></td>
          </tr>
        </table>
        </span>
      </div>
    </div>
  </div>
</form>
</body>
</html>
