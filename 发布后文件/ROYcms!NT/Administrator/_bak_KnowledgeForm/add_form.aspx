<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add_form.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.knowledgeForm.add_form" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
    <table cellSpacing="4" cellPadding="4" width="98%" border="0">
    <tr>
      <td height="25" colspan="2" align="left" nowrap="nowrap"><h3>添加一个表单</h3></td>
      </tr>
    <tr>
      <td width="7%" height="25" align="right" nowrap="nowrap"> 标题
        ：</td>
      <td width="93%" height="25" align="left" nowrap="nowrap"><asp:TextBox id="txttitle" runat="server" Width="200px"></asp:TextBox></td>
    </tr>
    <tr>
      <td width="7%" height="25" align="right" nowrap="nowrap"> 描述
        ：</td>
      <td width="93%" height="25" align="left" nowrap="nowrap">
          <asp:TextBox id="txtzhaiyao" runat="server" Width="283px" Height="42px" 
              TextMode="MultiLine"></asp:TextBox></td>
    </tr>
    <tr>
      <td width="7%" height="25" align="right" nowrap="nowrap"> 表单集合
        ：</td>
      <td width="93%" height="25" align="left" nowrap="nowrap"><asp:TextBox id="txtSetFrom" runat="server" Width="200px"></asp:TextBox></td>
    </tr>
    <tr>
      <td width="7%" height="25" align="right" nowrap="nowrap"> 地址
        ：</td>
      <td width="93%" height="25" align="left" nowrap="nowrap"><asp:TextBox id="txtPath" runat="server" Width="200px"></asp:TextBox></td>
    </tr>
    <tr>
      <td width="7%" height="25" align="right" nowrap="nowrap"> 内容
        ：</td>
      <td width="93%" height="25" align="left" nowrap="nowrap">
          <asp:FileUpload ID="FileUpload_Form" runat="server" Width="246px" />
        </td>
    </tr>
    <tr>
      <td height="25" nowrap="nowrap">&nbsp;</td>
      <td height="25" nowrap="nowrap"><asp:Button ID="btnAdd" runat="server" Text="确认添加" OnClick="btnAdd_Click" ></asp:Button></td>
    </tr>
  </table>
    </div>
    </form>
</body>
</html>
