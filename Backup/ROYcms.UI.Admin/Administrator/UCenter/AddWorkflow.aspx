<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator.Workflow.AddWorkflow" %>
<html>
<body>
<form id="AddWorkflowForm" runat="server">

    <table cellSpacing="2" cellPadding="2" width="360" border="0">
      <tr>
        <td width="9%" height="25" align="right" nowrap>标识：</td>
        <td width="91%" height="25" align="left" nowrap><asp:TextBox ID="txtkeyId" runat="server" Width="50px" CssClass="txtInput"></asp:TextBox></td>
      </tr>
      <tr>
        <td width="9%" height="25" align="right" nowrap>工作流名称：</td>
        <td width="91%" height="25" align="left" nowrap><asp:TextBox ID="txtname" runat="server" Width="160px" CssClass="txtInput"></asp:TextBox></td>
      </tr>
      <tr>
        <td height="25" align="right" nowrap>工作流描述：</td>
        <td height="25" nowrap><asp:TextBox ID="txtzhaiyao" runat="server" Width="200px" TextMode="MultiLine"></asp:TextBox></td>
      </tr>
      <tr>
        <td height="25" nowrap></td>
        <td height="25" nowrap><asp:Button ID="btnAdd" runat="server" Text="确认添加" OnClick="btnAdd_Click" CssClass="btnSearch"></asp:Button></td>
      </tr>
    </table>
</form>
</body>
</html>
