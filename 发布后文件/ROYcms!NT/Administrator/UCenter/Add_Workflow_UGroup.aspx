<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Workflow_UGroup.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.UCenter.Add_Workflow_UGroup" %>

<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <table cellSpacing="4" cellPadding="4" width="45%" border="0">
        <tr>
	<td height="25" colspan="2" align="left" nowrap>   <h3>向小组添加工作流关联</h3></td>
	</tr>
	<tr>
	<td width="27%" height="25" align="right" nowrap>用户组：</td>
	<td width="73%" height="25" align="left" nowrap>[
	  <asp:Label ID="Label_GroupName" runat="server"></asp:Label>
	  ] <span style="color:red;"> 关联该小组到下列工作流</span></td></tr>
	<tr>
	  <td height="25" align="right" nowrap>关联到的工作流：</td>
	  <td height="25" nowrap><asp:DropDownList ID="DropDownList_Workflow" runat="server" datasourceid="Workflow_ObjectDataSource" DataTextField="name" DataValueField="id">
	    </asp:DropDownList>
        <asp:ObjectDataSource ID="Workflow_ObjectDataSource" runat="server"  SelectMethod="GetAllList" TypeName="ROYcms.Sys.BLL.ROYcms_Workflow">
        </asp:ObjectDataSource></td>
	</tr>
	<tr>
	  <td height="25" nowrap>&nbsp;</td>
	  <td height="25" nowrap><asp:Button ID="btnAdd" runat="server" Text="确认添加" OnClick="btnAdd_Click" ></asp:Button></td>
	  </tr>
      </table>
    </div>
    </form>
</body>
</html>
