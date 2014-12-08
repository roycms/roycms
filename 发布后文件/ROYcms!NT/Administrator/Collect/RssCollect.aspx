<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RssCollect.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.App_Api.RssApi" ValidateRequest="false" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title></title>
</head>
<body>
<form id="InsertObjetForm" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <div id="rotate"> 
    <!--工具栏开始-->
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con"> 
        <a href='index.aspx'><img align="absmiddle" src="/administrator/images/nv9.png" />返回管理</a> </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
    <!--工具栏结束-->
    <div class="tagMenu">
      <ul class="menu1">
        <li>采集基本信息设置</li>
      </ul>
    </div>
    <div class="content1" style="padding:0px; margin-top:3px;">
      <div class="layout">

      <asp:Repeater ID="Repeater_Rss" runat="server">
                <ItemTemplate>
                      <a href='<%#Eval("Link")%>'><%#Eval("title")%></a><br />
                </ItemTemplate>
      </asp:Repeater>
        <table   cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
          <tr>
            <td width="11%" align="right" bgcolor="#F4FBFF">采集的RSS地址</td>
            <td width="89%" bgcolor="#F4FBFF"><asp:TextBox ID="TextBox_RssPath" runat="server" Width="450px" CssClass="txtInput"></asp:TextBox></td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF">RSS源编码</td>
            <td bgcolor="#F4FBFF"><asp:DropDownList ID="DropDownList_Encod" runat="server"  CssClass="select" Width="200px">
              <asp:ListItem Value="null">自动检测</asp:ListItem>
              <asp:ListItem>UTF-8</asp:ListItem>
              <asp:ListItem>GB2312</asp:ListItem>
            </asp:DropDownList></td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF">开始HTML标记</td>
            <td bgcolor="#F4FBFF"><asp:TextBox ID="TextBox_star" runat="server" Height="84px" TextMode="MultiLine" Width="450px">内容页面的内容部分的开始标记</asp:TextBox></td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF">结束HTML标记</td>
            <td bgcolor="#F4FBFF"><asp:TextBox ID="TextBox_end" runat="server" Height="84px" TextMode="MultiLine"  Width="450px">内容页面的内容部分的结束标记</asp:TextBox></td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF">&nbsp;</td>
            <td bgcolor="#F4FBFF">
            <asp:Button ID="Button_RssbT" runat="server" OnClick="Button_RssbT_Click" Text="采集内容" Width="82px" CssClass="btnSubmit" /></td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF">采集内容发布到</td>
            <td bgcolor="#F4FBFF">
              <asp:DropDownList CssClass="select" ID="DdClassKind" runat="server" Width="120" 
                    AutoPostBack="True" onselectedindexchanged="DdClassKind_SelectedIndexChanged"></asp:DropDownList>
            <asp:DropDownList CssClass="select" ID="DdClass" runat="server" Width="160"></asp:DropDownList>
                <asp:Button ID="Button_fabu" runat="server" OnClick="Button_fabu_Click" Text="发布"  CssClass="btnSubmit"  />
</td>
          </tr>
        </table>
      </div>
    </div> 

  </div>
</form>        
</body>
</html>

