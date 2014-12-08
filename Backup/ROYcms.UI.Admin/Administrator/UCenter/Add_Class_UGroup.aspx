<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Class_UGroup.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.UCenter.Add_Class_UGroup" %>



<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <table cellSpacing="4" cellPadding="4" width="100%" border="0">
        <tr>
	<td height="25" colspan="2" align="left" nowrap><h3>向用户组关联发布权限 </h3></td>
	</tr>
	<tr>
	<td width="5%" height="25" align="right" nowrap>小组：</td>
	<td width="95%" height="25" align="left" nowrap>[
      <asp:Label ID="Label_GroupName" runat="server"></asp:Label>
]<span style="color:red;"> 授权添加该小组到下列分类里投递信息</span></td></tr>
	<tr>
	  <td height="25" nowrap>分类标识
	：</td>
	  <td height="25" align="left" nowrap><asp:TextBox ID="txtClass_id" runat="server" Width="200px"></asp:TextBox>
        <a href="?">选择</a>
分类的ID </td>
	</tr>
	<tr>
	  <td height="25" nowrap>&nbsp;</td>
	  <td height="25" align="left" nowrap><asp:Button ID="btnAdd" runat="server" Text="确认添加" OnClick="btnAdd_Click" ></asp:Button></td>
	  </tr>
      </table>
    </div>
    </form>
</body>
</html>
