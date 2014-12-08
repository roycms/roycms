<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator_template_ADD_template"  ValidateRequest="false" Codebehind="ADD_template.aspx.cs" %>


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
        <legend><img name="" src="/administrator/images/add.png" width="16" height="16" alt="">&nbsp;&nbsp;创建模板</legend>
        
    
                      <table width="100%" border="0" cellspacing="5" cellpadding="0">
                        <tr>
                          <td height="74">
                      
                                  <div>
                                    <table width="98%" height="159" border="0" align="center" cellpadding="6" cellspacing="1" bgcolor="#CCCCCC">
             <tr>
            <td width="12%" height="16" align="right" nowrap bgcolor="#F4FBFF">当前模板组方案： </td>
            <td width="88%" bgcolor="#F4FBFF">
                
               
                【<font color=red><%Response.Write(Session["template_z_name"]); %></font>】
                                    文件夹：【<font color=red><%Response.Write(Session["template_z_path"]); %></font>】
                                    绑定地址：【<font color=red><%Response.Write(Session["template_z_url"]); %></font>】
               
            <a href="Group.aspx"> 管理模板组</a></td>
          </tr><tr>
            <td width="12%" height="16" align="right" bgcolor="#F4FBFF">模板名称： </td>
            <td width="88%" bgcolor="#F4FBFF"><asp:TextBox CssClass="input" ID="TextBox_title" runat="server" Width="300"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox_title" ErrorMessage="请填写模板标题"></asp:RequiredFieldValidator>
                    </td>
          </tr>
          <tr>
            <td height="16" align="right" bgcolor="#F4FBFF">模板说明：</td>
            <td bgcolor="#F4FBFF"><asp:TextBox CssClass="input" ID="TextBox_miaoshu" runat="server" Width="300"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox_miaoshu" ErrorMessage="请填写描述"></asp:RequiredFieldValidator>
                    </td>
          </tr>
          <tr>
            <td height="20" align="right" bgcolor="#F4FBFF">模板类型：</td>
            <td bgcolor="#F4FBFF"><asp:DropDownList ID="DropDownList_type" runat="server" CssClass="input">
                <asp:ListItem Value="">请选择模板类型</asp:ListItem>
              <asp:ListItem Value="list">列表页模板</asp:ListItem>
              <asp:ListItem Value="show">子页模板</asp:ListItem>
              <asp:ListItem Value="Dissertation">专题页面</asp:ListItem>
            </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="DropDownList_type" ErrorMessage="请选择新建模板的类型"></asp:RequiredFieldValidator>
                    </td>
          </tr>
          <tr>
            <td height="15" align="right" bgcolor="#F4FBFF">模板HTML内容：</td>
            <td bgcolor="#F4FBFF">复制粘贴HTML源代码到下面的文本区域</td>
          </tr>
          <tr>
            <td height="29" colspan="2" bgcolor="#F4FBFF"><asp:TextBox ID="TextBox_htmlContent" runat="server" Height="300px" TextMode="MultiLine" Width="100%" CssClass="input"></asp:TextBox></td>
            </tr>
          <tr>
            <td height="21" colspan="2" bgcolor="#F4FBFF"><asp:Button ID="add_Button" runat="server" Text="创建模板"  OnClick="add_Button_Click" CssClass="bt" /></td>
            </tr>
        </table>
        <br />
                            </div>
                          </td>
                        </tr>
                      </table>
        </fieldset>        </td>
      </tr>
    </table>
<div></div>
</form>
</body>
</html>
