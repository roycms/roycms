<%@ Page Language="C#" AutoEventWireup="true" Inherits="createDB" Codebehind="createDB.aspx.cs" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>


<html >
<head runat="server">
    <title>SQL_Management_createDB</title>
    <link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <table cellpadding="2" cellspacing="8" border="0" width="98%">
            <tr>
                <td><Resources:Resources ID="Resources1" runat="server" /></td>
            </tr>
            <tr>
                <td align="left">&nbsp;&nbsp;&nbsp;服务器: &nbsp;&nbsp;&nbsp<asp:Label ID="txtSqlName" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;使用账号:&nbsp;&nbsp;&nbsp;<asp:Label ID="txtUserName" runat="server"></asp:Label>&nbsp;
                </td>
            </tr>
            <tr>
                <td align="left">
                    <table width="100%" cellspacing="8">
                        <tr>
                            <td colspan="2" align="center">创建数据库</td>
                        </tr>
                        <tr>
                            <td width="12%" nowrap>请输入数据库的名字:</td>
                            <td width="88%">
                            <asp:TextBox ID="txtDB" runat="server" CssClass="input"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="None" ErrorMessage="请输入新建数据库名称" ControlToValidate="txtDB"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="DBOK" runat="server" CssClass="bt" Text="创建数据库" OnClick="DBOK_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="normal" />
                </td>
            </tr>
            <tr>
                <td colspan="2" bgcolor="#BDD6E1" align="center" style="color:Black; height:29px;">&nbsp;</td>
            </tr>
            
        </table>
    
    </div>
    </form>
</body>
</html>
