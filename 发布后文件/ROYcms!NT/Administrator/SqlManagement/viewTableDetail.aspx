<%@ Page Language="C#" AutoEventWireup="true" Inherits="viewTableDetail" Codebehind="viewTableDetail.aspx.cs" %>

<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>

<html>
<head runat="server">
    <title>SQL_Management_viewTableDetail</title>
    <link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server"><Resources:Resources ID="Resources1" runat="server" />
    <div>
        
        <table cellpadding="2" cellspacing="8" border="0" width="98%">
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td align="center"></td>
            </tr>
            <tr>
                <td align="left">
                    &nbsp;&nbsp;&nbsp;数据库: &nbsp;&nbsp;<asp:Label ID="txtDB" runat="server"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;数据表:&nbsp;&nbsp;<asp:Label ID="txtTB" runat="server"></asp:Label>
                    &nbsp;&nbsp;&nbsp;<asp:Button ID="back" runat="server" Text="返回管理页" CssClass="bt" OnClick="back_Click" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <p>数据表详情</p>
                    <p>
                    <asp:GridView ID="myGW" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="60%">
                    <FooterStyle BackColor="#507CD1" Font-Bold="true" ForeColor="white" />
                    <RowStyle BackColor="#EFF3FB" />
                    <EditRowStyle BackColor="#2461BF" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="true" ForeColor="#333333" />
                    <PagerStyle BackColor="#2461BF" ForeColor="white" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="true" ForeColor="white" />
                    <AlternatingRowStyle BackColor="white" />
                    
                    </asp:GridView>
                    &nbsp;</p>
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
