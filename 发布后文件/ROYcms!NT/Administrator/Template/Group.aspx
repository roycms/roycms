<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Group.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.template.Group" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<html>
<head runat="server">
    <title></title>
</head>
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
<body>
    <form id="form1" runat="server">
    <div>
    
    
    
        <Resources:Resources ID="Resources1" runat="server" />
<!--******************************增加页面代码********************************-->

<table width="100%" border="0" cellpadding="10">
  <tr>
    <td>
    
    <fieldset>
        <legend><img name="" src="/administrator/images/bullet_wrench.png" width="16" height="16" alt=""> 模板组方案管理</legend>
        <br>
        <table width="98%" align="center" cellpadding="5" cellspacing="1" bgcolor="#CCCCCC">
	<tr>
	<td width="11%" height="25" align="right" nowrap bgcolor="#F4FBFF">
		名称：
	</td>
	<td width="89%" height="25" align="left" bgcolor="#F4FBFF">
		<asp:TextBox CssClass="input" id="txtz_name" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td width="11%" height="25" align="right" nowrap bgcolor="#F4FBFF">
		模板文件夹地址：
	</td>
	<td width="89%" height="25" align="left" bgcolor="#F4FBFF">
		<asp:TextBox CssClass="input" id="txtz_path" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td width="11%" height="25" align="right" nowrap bgcolor="#F4FBFF">
		绑定域名：
	</td>
	<td width="89%" height="25" align="left" bgcolor="#F4FBFF">
		<asp:TextBox CssClass="input" id="txtz_url" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td width="11%" height="25" align="right" nowrap bgcolor="#F4FBFF">
		模板组描述：
	</td>
	<td width="89%" height="25" align="left" bgcolor="#F4FBFF">
		<asp:TextBox CssClass="input" id="txtz_content" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	  <td height="25" nowrap bgcolor="#F4FBFF">&nbsp;</td>
	  <td height="25" bgcolor="#F4FBFF"><asp:Button CssClass="bt" ID="btnAdd" runat="server" Text="· 添加 ·" 
            OnClick="btnAdd_Click" ></asp:Button>
        <asp:Button CssClass="bt"  ID="ButEdit" runat="server" Text="· 编辑· " OnClick="ButEdit_Click" />        
        <asp:Button CssClass="bt" ID="btnCancel" runat="server" Text="· 重填 ·" OnClick="btnCancel_Click"  ></asp:Button></td>
	</tr>
</table>
        <br>
    </fieldset> 
    </td>
  </tr>
</table>


<br>
<table width="98%"  border="0" align="center" cellpadding="5" cellspacing="1" bgcolor="#CCCCCC">
        <tr>
          <td width="139" height="25" bgcolor="#DDE9FF">模板组名称</td>
          <td width="131" bgcolor="#DDE9FF">模板组文件夹地址</td>
          <td width="322" align="left" bgcolor="#DDE9FF">绑定域名</td>
          <td width="230" align="center" bgcolor="#DDE9FF">组描述</td>
          <td width="147" align="center" bgcolor="#DDE9FF">&nbsp;</td>
          </tr> 
        
   <asp:Repeater ID="Repeater_list" runat="server">

<ItemTemplate>
            <tr>
              <td height="25" bgcolor="#F4FBFF"><%#Eval("z_name") %></td>
              <td bgcolor="#F4FBFF"><%#Eval("z_path") %></td>
              <td align="left" bgcolor="#F4FBFF"><%#Eval("z_url") %></td>
              <td align="center" bgcolor="#F4FBFF"><%#Eval("z_content") %></td>
              <td align="center" nowrap bgcolor="#F4FBFF"><a href='?t=show&bh=<%#Eval("bh")%>'>详细</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a href='?t=edit&bh=<%#Eval("bh")%>'>编辑</a>&nbsp; |&nbsp; <a href='?t=del&bh=<%#Eval("bh")%>' onClick="return window.confirm('确定删除 [<%#Eval("z_name") %>] 吗?');">删除</a></td>
              </tr>
            </ItemTemplate>
          </asp:Repeater>
      </table>
    </div>
    </form>
</body>
</html>
