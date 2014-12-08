<%@ Page Language="C#" AutoEventWireup="True" Inherits="ROYcms.UI.Admin.Administrator_user_edit_ss" %>
<html>
<body>
<form id="user_edit_form" runat="server" >
  <table width="360" border="0" align="left" cellPadding="2" cellSpacing="2"  >
    <tr>
      <td> 登录名 </td>
      <td height="25" align="left"><asp:TextBox  id="txtname" runat="server" Width="116px" CssClass="txtInput"  ReadOnly="True"></asp:TextBox>        
      <script language="javascript" type="text/javascript">
       function GET_IMG_pic(returnVal){document.getElementById("txtpic").value=returnVal; }
       </script></td>
    </tr>
    <tr>
      <td>密码 </td>
      <td height="25" align="left"><asp:TextBox  ID="txtpassword" runat="server" Width="116px"  TextMode="Password"  CssClass="txtInput"></asp:TextBox></td>
    </tr>
    <tr>
      <td>重复密码</td>
      <td height="25" align="left"><asp:TextBox  ID="txtpassword2" runat="server" Width="116px"  TextMode="Password" CssClass="txtInput" ></asp:TextBox></td>
    </tr>
    <tr>
      <td width="10%" height="25">昵称 </td>
      <td height="25" align="left"><asp:TextBox  ID="txtusername" runat="server" Width="116px" CssClass="txtInput"  ></asp:TextBox></td>
    </tr>
    <tr>
      <td height="25" nowrap="nowrap">所属工作组</td>
      <td height="25" align="left" nowrap="nowrap"><asp:DropDownList ID="UGroup_DropDownList" runat="server" CssClass="select" Width="100px" ></asp:DropDownList></td>
    </tr>
    <tr>
      <td height="25" nowrap="nowrap">邮箱</td>
      <td height="25" nowrap="nowrap"><asp:TextBox  ID="txtemail"  runat="server" Width="164px"  CssClass="txtInput"  ></asp:TextBox></td>
    </tr>
    <tr>
      <td height="25" nowrap="nowrap">qq</td>
      <td height="25" nowrap="nowrap"><asp:TextBox  ID="txtqq" runat="server" Width="111px"  CssClass="txtInput" ></asp:TextBox></td>
    </tr>
    <tr>
      <td height="25" nowrap="nowrap">&nbsp;</td>
      <td height="25" nowrap="nowrap"><asp:Button  ID="Edit"  runat="server" Text="确认编辑"  OnClick="Edit_Click"  CssClass="btnSearch" /></td>
    </tr>
  </table>
</form>
</body>
</html>
