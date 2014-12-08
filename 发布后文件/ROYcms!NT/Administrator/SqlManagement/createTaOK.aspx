<%@ Page Language="C#" AutoEventWireup="True" Inherits="createTaOK" Codebehind="createTaOK.aspx.cs" %>

<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>

<html>
<head runat="server">
    <title>SQL_Management_createTbOK</title>
    <link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <Resources:Resources ID="Resources1" runat="server" />
        <table cellpadding="2" cellspacing="8" border="0" width="98%">
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td align="left">
                   
                   
                   新表:<asp:Label ID="txtTB" runat="server" ></asp:Label>
                    
                </td>
            </tr>
            <tr>
                <td align="left">
                
          服务器:<asp:Label ID="txtSqlName" runat="server"></asp:Label> 
      
          
          使用账号:<asp:Label ID="txtUserName" runat="server"></asp:Label>
         
          当前数据库:<asp:Label ID="txtDBName" runat="server"></asp:Label>
          
          放弃创建新表返回:<asp:Button ID="backMana" runat="server" CssClass="bt" OnClick="backMana_Click" Text="返回管理页" />
                </td>
            </tr>
            <tr>
                <td align="left">
                    <asp:Table ID="Tbinfo" runat="server" Width="60%"></asp:Table>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
           
        </table>
    </div>
    </form>
</body>
</html>
