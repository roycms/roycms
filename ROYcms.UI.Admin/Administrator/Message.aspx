<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator_Message" ValidateRequest="false" Codebehind="Message.aspx.cs" %>

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
</head>
<body>
<table width="496" border="0" align="center" cellpadding="0" cellspacing="10" style="margin-top:100px">
  <tr>
    <td width="140" rowspan="3"><asp:Image ID="image_mes" runat="server" ImageUrl="/administrator/images/what.png" /></td>
    <td width="326"><font class="enfont" color="#FF4800">ROY.CMS</font>&nbsp;&nbsp;<font class="enfont" color="#3D9100">ver1.0 </font><b>网站后台协作平台！</b></td>
  </tr>
  <tr>
    <td colspan="2">
    <table width="620px" height="70" border="0" cellpadding="0" cellspacing="0">
        <tr>
          <td width="70">消息提示：</td>
          <td width="550" align=left><font color="#FF0000">
          <asp:Label ID="Label_message" runat="server" Text=""></asp:Label></font></td>
        </tr>
        <tr>
          <td>来源URL：</td>
          <td align=left><font color="#FF0000"><asp:HyperLink ID="HyperLink_url" runat="server" ></asp:HyperLink></font></td>
        </tr>
        <tr>
          <td>操作结果：</td>
          <td align=left><font color="#FF0000"><asp:Label ID="Label_z" runat="server" Text=""></asp:Label></font></td>
        </tr>
      </table></td>
  </tr>
  <tr>
    <td colspan="2"><a href="help.aspx"><img src="/administrator/images/qu-bt.gif" width="56" height="19" border="0" title="QQ对话"></a> 
    <a href="http://www.roycms.cn" target="_blank"><img src="/administrator/images/link-bt.gif" width="106" height="19" border="0"> </a> 
      <b> <asp:HyperLink ID="HyperLink_host" runat="server"><img src="/administrator/images/link-History.gif" border="0"></asp:HyperLink></b> 
        <asp:Literal ID="New_group" runat="server"></asp:Literal> </td>
  </tr>
</table>
</body>
</html>