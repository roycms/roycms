<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XClass.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator_Objet_XClass" ValidateRequest="false"  %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>

<!DOCTYPE HTML>
<html >
<head runat="server">
<title></title>
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css" />

<link href="/administrator/WebUI/SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css">



</head>
<body>
<form id="form1" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  
  <table width="100%" border="0" align="center" cellpadding="0" cellspacing="4">
    <tr>
      <td>
            <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con">
        <a href="/administrator/objet/xclass.aspx?Classkind=<% =this.ClassKind %>"><img align="absmiddle" src="/administrator/images/nv6.png" />添加信息</a> 
        <a href="/administrator/objet/admin.aspx?Classkind=<% =this.ClassKind %>"><img align="absmiddle" src="/administrator/images/nv8.png" />管理信息</a> 
        <a href='/administrator/class/index.aspx?ClassKind=<% =ClassKind %>'><img align="absmiddle" src="/administrator/images/nv9.png" />分类管理</a> 

        
        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
      <fieldset>
          
          <span class="licss"></span>
          <table width="98%" height="63" border="0" align="center" cellpadding="0" cellspacing="10">
            <tr>
              <td> <br>
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td width="8%" nowrap><img name="" src="/administrator/images/funnel.png" width="16" height="16" alt="">
                    <strong>筛选分类</strong></td>
                    <td width="92%" nowrap><asp:DropDownList AutoPostBack="True" CssClass="TabbedPanelsTab" ID="DdlMenu" runat="server" 
                      Width="320" OnSelectedIndexChanged="DdlMenu_SelectedIndexChanged"></asp:DropDownList></td>
                  </tr>
                </table>
                <br>
                <span style="color:#F00">在需要发布的频道里打钩√</span><img name="" src="/administrator/images/lightbulb_add.gif" width="16" height="16" alt=""><br>
                <br>
                  <asp:Repeater ID="Repeater_XClass" runat="server">
                    <ItemTemplate>
  
                     
             <!--         <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                          <td nowrap  style="margin:2px;">
                              </td>
                        </tr>
                      </table>-->
                      <div style="display:table; float:left; width:180px; padding-bottom:10px;">
                       <img name="" src="/administrator/images/bullet_feed.png" width="16" height="16" alt="">
                       <asp:CheckBox ID="ID_list" runat="server" Text='<%#Eval("ClassName") %>' Enabled='<%#(Eval("ColumnsType").ToString()=="0")?true:false %>' />                     
                        [
                        <asp:Label ID="Label_id" runat="server" Text='<%#Eval("Id") %>'></asp:Label>
                        ] 
                        </div>
               
                    </ItemTemplate>
                  </asp:Repeater>
              </td>
            </tr>
            <tr>
              <td colspan="2" ><table width="100%" border="0" cellspacing="0" cellpadding="10">
                  <tr>
                    <td><asp:Button ID="Button_add" runat="server" Text="转到下一步 [录入信息]" CssClass="TabbedPanelsTabHover" 
            OnClick="Button_add_Click" /></td>
                  </tr>
              </table></td>
            </tr>
          </table>
        </fieldset></td>
    </tr>
  </table>
</form>
</body>
</html>
