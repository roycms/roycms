<%@ Page Language="C#" AutoEventWireup="True" Inherits="ROYcms.UI.Admin.Administrator_template_edit" ValidateRequest="false" Codebehind="edit.aspx.cs" %>

<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>



<html>
<head runat="server">
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
    <title></title>
</head>
<style type="text/css">
<!--
#GridView1 {
	font-size: 13px;
}
#GridView1 td,th{
padding:5px;
padding-left:15px;
}
-->
</style>
<body>
    <form id="form1" runat="server">
    <Resources:Resources ID="Resources1" runat="server" />
    
    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="10">
      <tr>
        <td><fieldset>
        <legend><img name="" src="/administrator/images/add.png" width="16" height="16" alt=""> 模板管理</legend>
        
    
                      <table width="100%" border="0" cellspacing="5" cellpadding="0">
                        <tr>
                          <td height="74">
                      
                                  <div>
                                    <table width="98%" border="0" align="center" cellpadding="0" cellspacing="10">
                                      <tr>
                                        <td width="10%">当前模板组方案： </td>
                                  <td width="90%">
                                  
                                  
                                    【<font color=red><%Response.Write(Session["template_z_name"]); %></font>】
                                    文件夹：【<font color=red><%Response.Write(Session["template_z_path"]); %></font>】
                                    绑定地址：【<font color=red><%Response.Write(Session["template_z_url"]); %></font>】
                                    <a href="Group.aspx"> 管理模板组</a></td>
                                      </tr>
                                      <tr>
                                        <td><asp:Label ID="Label1" runat="server" Text="模板名称:"></asp:Label>
                                        <asp:Label ID="Label_title" runat="server" Text=""></asp:Label></td>
                                        <td width="90%"><asp:TextBox CssClass="input" ID="TextBox_title" runat="server" Width="300"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                ControlToValidate="TextBox_title" ErrorMessage="请填写模板名称"></asp:RequiredFieldValidator></td>
                                      </tr>
                                      <tr>
                                        <td height="21">
                                        <asp:Label ID="Label_title_content" runat="server" Text=""></asp:Label>
                                        
                                        
                                        <asp:Label ID="Label2" runat="server" Text="模板说明:"></asp:Label>
                                                  </td>
                                      <td><asp:TextBox CssClass="input" ID="TextBox_miaoshu" runat="server" Width="300"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                ControlToValidate="TextBox_miaoshu" ErrorMessage="请填写描述"></asp:RequiredFieldValidator>
                                                  </td>
                                      </tr>
                                      <tr>
                                        <td height="38" colspan="2">
                                        <asp:TextBox ID="TextBox_HTML" Width="100%" Height="400px" runat="server" TextMode="MultiLine" CssClass="input"></asp:TextBox>
                                        
                                        
                                        </td>
                                      </tr>
                                      <tr>
                                        <td><asp:ImageButton ID="ImageButton1"  runat="server" ImageUrl="~/Administrator/images/edit-bt.gif" OnClick="ImageButton1_Click"/></td>
                                        <td>&nbsp;</td>
                                      </tr>
                                    </table>
                                    
                                   
                          </div>                          </td>
                        </tr>
                      </table>
        </fieldset>        </td>
      </tr>
    </table>
<div></div>
</form>
</body>
</html>
