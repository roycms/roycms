<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.FileManager_edit"  ValidateRequest="false" Codebehind="edit.aspx.cs" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server"><Resources:Resources ID="Resources1" runat="server" />
    
  <div> 
     
    <table width="98%" border="0" align="center">
      <tr>
        <td>
           <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con">
        <a href="Default.aspx"><img align="absmiddle" src="/administrator/images/nv6.png" />返回文件管理器</a> 
        
        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
        <asp:TextBox Height="400px" ID="TextBox_HTML" Font-Size="14px" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
        <br />
     
        <asp:Button ID="btnEdit" runat="server" Text="确认编辑"  onclick="btnEdit_Click" CssClass="btnSubmit" ></asp:Button>
        </td>
      </tr>
    </table>

       
        
      </div>
    </form>
</body>
</html>
