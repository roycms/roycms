<%@ Page Language="C#" AutoEventWireup="true" Inherits="createTable" Codebehind="createTable.aspx.cs" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>


<html>
<head runat="server">
    <title>SQL_Management_createTable</title>
    <link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server"><Resources:Resources ID="Resources1" runat="server" />
    <div >
        <table cellpadding="2" cellspacing="8" border="0" width="98%">
            <tr>
                <td></td>
            </tr>
            <tr>
                <td align="left">
                    &nbsp;&nbsp;&nbsp;服务器:&nbsp;<asp:Label ID="txtSqlName" runat="server"></asp:Label>
                    &nbsp;&nbsp;使用账号:&nbsp;<asp:Label ID="txtUserName" runat="server"></asp:Label>
                    &nbsp;&nbsp;当前数据库:&nbsp;<asp:Label ID="txtDBName" runat="server"></asp:Label>
                    &nbsp;&nbsp;<a href="mainServer.aspx" class="bt">放弃创建返回</a>
                </td>
            </tr>
            <tr>
                <td align="left">
                    <table width="100%" cellpadding="8" cellspacing="1" bgcolor="#CCCCCC">
                        <tr>
                            <td colspan="2" align="center" bgcolor="#F4FBFF">
                            <h4>创建新表 </h4></td>
                        </tr>
                        <tr>
                            <td width="9%" nowrap bgcolor="#F4FBFF">
                                请输入新表名字:
                            </td>
                            <td width="91%" bgcolor="#F4FBFF">
                              <asp:TextBox ID="txtNewTBName" runat="server" CssClass="input"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNewTBName" Display="None" ErrorMessage="请输入新表的名称"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td nowrap bgcolor="#F4FBFF">
                                请输入新表列值:
                            </td>
                            <td bgcolor="#F4FBFF">
                            <asp:TextBox ID="txtNumber" runat="server" CssClass="input"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入新表列字段的个数" Display="None" ControlToValidate="txtNumber"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" bgcolor="#F4FBFF">
                                <asp:Button ID="TBCreate" runat="server" CssClass="bt" Text="创建新表" OnClick="DBOK_Click" />
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
                <td colspan="2" bgcolor="#BDD6E1" align="center" style="color:Black; height:34px;">&nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
