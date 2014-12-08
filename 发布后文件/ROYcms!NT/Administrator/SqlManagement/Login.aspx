<%@ Page Language="C#" AutoEventWireup="true" Inherits="Login" Codebehind="Login.aspx.cs" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>

<!DOCTYPE HTML>
<html>
<head id="Head1" runat="server">
    <title>Sql_Management_Login</title>
</head>
<body topmargin="50">
    <form id="form1" runat="server">
     <Resources:Resources ID="Resources1" runat="server" />
    <div align =center>
        <table  cellpadding="2" cellspacing="2" border="0" width="100%">
            <tr>
               <td align="left" >        
             <table width="100%" border="0" class="tiao_top">
                  <tr>
                    <td width="77%" nowrap><div class="tiao_con">
                    <a href="/administrator/SqlManagement/Login.aspx"><img align="absmiddle" src="/administrator/images/nv6.png" />SqlManagement </a> 
                    <a href="/administrator/SqlManagement/DbBackup.aspx"><img align="absmiddle" src="/administrator/images/nv8.png" />备份/还原</a> 
                    <a  rel="facebox" title="执行SQL语句"  href="/administrator/SqlManagement/sql.aspx"><img align="absmiddle" src="/administrator/images/nv9.png" />执行SQL语句</a> 
                    </div></td>
                    <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
                  </tr>
                </table>
               
                   <table width="100%" cellpadding="8" cellspacing="1" bgcolor="#cccccc">
                       <tr>
                           <td width="15%" align="right" bgcolor="#F4FBFF" style="height: 19px"> SQL SERVER服务器：</td>
                           <td width="85%" align="left" bgcolor="#F4FBFF" style="height: 19px">
                               <asp:TextBox ID="txtSQL" runat="server" CssClass="txtInput">(local)</asp:TextBox>
                               <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置"></td>
                       </tr>
                       <tr>
                           <td align="right" bgcolor="#F4FBFF">
                               数据库帐号：</td>
                           <td align="left" bgcolor="#F4FBFF">
                               <asp:TextBox ID="txtUid" runat="server" CssClass="txtInput"></asp:TextBox>
                               <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置"></td>
                       </tr>
                       <tr>
                           <td align="right" bgcolor="#F4FBFF">
                               PASSWORD：</td>
                           <td align="left" bgcolor="#F4FBFF">
                               <asp:TextBox ID="txtPwd" runat="server" CssClass="txtInput" TextMode="Password"></asp:TextBox>
                               <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置"></td>
                       </tr>
                       <tr>
                           <td align="center" bgcolor="#F4FBFF">&nbsp;</td>
                           <td align="left" bgcolor="#F4FBFF"><asp:Button ID="loginOk" runat="server" CssClass="btnSubmit" Text="登录服务器" OnClick="loginOk_Click" /></td>
                       </tr>
                       <tr>
                           <td colspan="2" bgcolor="#F4FBFF">
                               (SQL SERVER默认为本地服务器，可以填入网络上存在的一个服务器名称)</td>
                       </tr>
                   </table>
               </td>
            </tr>
            <tr>
               <td colspan=2 bgcolor="#BDD6E1" align="center" style="color:Black; height: 34px;">&nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
