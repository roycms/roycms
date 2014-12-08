<%@ Page Language="C#" AutoEventWireup="true" Inherits="mainServer" Codebehind="mainServer.aspx.cs" %>

<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<html>
<head id="Head1" runat="server">
    <title>SQL_Management_mainServer</title>
        <link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
</head>
<body topmargin="50">
    <form id="form1" runat="server">
    <div>
        <Resources:Resources ID="Resources1" runat="server" />
        <table  cellpadding="2" cellspacing="8" border="0" width="98%"%>
            <tr>
                <td >&nbsp;</td>
            </tr>
            <tr>
                <td>
                    </td>
            </tr>
            <tr>
               <td  align="left">
                   &nbsp;&nbsp;&nbsp;用户：&nbsp;<asp:Label ID="txtUser" runat="server" ></asp:Label>
                   &nbsp;&nbsp; 服务器名称： &nbsp;&nbsp;<asp:Label ID="txtname" runat="server"></asp:Label>
              &nbsp; &nbsp;&nbsp;
              <asp:Button ID="CreateDB" runat="server" Text="创建数据库" CssClass="input" OnClick="CreateDB_Click" /></td>
            </tr>
            <tr>
               <td >
                   <table width="100%" cellpadding="8" cellspacing="1" bgcolor="#CCCCCC">
                       <tr>
                           <td width="15%" align="right" nowrap bgcolor="#F4FBFF">
                               本服务器中的数据库：</td>
                           <td width="19%" align="left" bgcolor="#F4FBFF">
                               <asp:DropDownList ID="databaseList" runat="server" CssClass="input">
                               </asp:DropDownList></td>
                           <td width="66%" rowspan="2" bgcolor="#F4FBFF">
                               <asp:ListBox ID="tableList" runat="server" CssClass="textbox" Visible="False" Rows="10"></asp:ListBox></td>
                       </tr>
                       <tr>
                           <td width="15%" align="right" nowrap bgcolor="#F4FBFF">
                               查看选定数据库中的表：</td>
                           <td width="19%" align="left" bgcolor="#F4FBFF">
                               <asp:Button ID="viewTable" runat="server" Text="查看数据表" CssClass="bt" OnClick="viewTable_Click" /></td>
                       </tr>
                       <tr>
                           <td align="right" nowrap bgcolor="#F4FBFF">
                               在该数据库中添加新表：</td>
                           <td align="left" bgcolor="#F4FBFF">
                               <asp:Button ID="addNewTable" runat="server" CssClass="bt" Text=" 创建数据表" OnClick="addNewTable_Click" /></td>
                           <td bgcolor="#F4FBFF" >
                               <asp:Button ID="detail" runat="server" CssClass="bt" Text="数据表详情" Visible="False" OnClick="detail_Click" /></td>
                       </tr>
                       <tr>
                       <td colspan="3" bgcolor="#F4FBFF">
                           (注意：在查看数据库中的表时，以sys开头的是系统表，非用户创建表)</td>
                       </tr>
                   </table>
              </td>
            </tr>
            <tr>
               <td colspan="2" bgcolor="#BDD6E1" align="center" style="color:Black; height: 34px;">&nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
