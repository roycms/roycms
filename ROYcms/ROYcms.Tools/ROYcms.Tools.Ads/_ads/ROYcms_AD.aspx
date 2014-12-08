<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.Tools.Ads.addAd" Codebehind="ROYcms_AD.aspx.cs" %>


<html>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<link href="../../images/style.css" rel="stylesheet" type="text/css">
<head runat="server">
    <title>ROYcms_AD</title>    
</head>
<body>
    <form id="form1" runat="server">
    
    <table width="100%" border="0" cellpadding="10">
      <tr>
        <td>
        <div>
    <fieldset>
      <legend><img name="" src="../../images/bullet_wrench.png" width="16" height="16" alt="">&nbsp;广告管理</legend>
    
      <br>
      <table width="98%" border="0" align="center" cellpadding="6" cellspacing="1" bgcolor="#CCCCCC">
      <tr>
            <td width="84" align="right" nowrap bgcolor="#F4FBFF">所属栏目：</td>
          <td bgcolor="#F4FBFF" ><asp:DropDownList ID="ddSort" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" nowrap bgcolor="#F4FBFF" >广告标题：</td>
          <td bgcolor="#F4FBFF"><asp:TextBox CssClass="input" ID="txtTitle" runat="server" Width="220px" />
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtTitle" ErrorMessage="广告标题必须输入" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td align="right" nowrap bgcolor="#F4FBFF" >广告类型：</td>
            <td bgcolor="#F4FBFF">            
            <asp:RadioButtonList ID="radType" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
            <asp:ListItem Value="0">图片</asp:ListItem>
            <asp:ListItem Value="1">FLASH动画</asp:ListItem>
            </asp:RadioButtonList> 
            </td>
        </tr>
        <tr>
            <td align="right" nowrap="nowrap" bgcolor="#F4FBFF" >广告文件地址：</td>
          <td bgcolor="#F4FBFF"><asp:TextBox CssClass="input" ID="txtPic" runat="server" Width="220px" />
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtPic" ErrorMessage="广告图片或动画地址" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>            
        </tr>
        <tr>
            <td align="right" nowrap bgcolor="#F4FBFF" >链接地址：</td>
          <td bgcolor="#F4FBFF"><asp:TextBox CssClass="input" ID="txtUrl" runat="server" Width="220px" />
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtUrl" ErrorMessage="请输入链接地址" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td align="right" nowrap bgcolor="#F4FBFF" >宽度和高度：</td>
          <td bgcolor="#F4FBFF">宽度：<asp:TextBox CssClass="input" ID="txtWidth" runat="server" Width="40px" />&nbsp; <asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtWidth" 
                    Display="Dynamic" ErrorMessage="请输入宽度" SetFocusOnError="True"></asp:RequiredFieldValidator>
                高度：<asp:TextBox CssClass="input" ID="txtHeight" runat="server" Width="42px" />
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtHeight" ErrorMessage="请输入高度" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td align="center" bgcolor="#F4FBFF">
            <asp:HiddenField ID="hiddJs" runat="server" /></td>
            <td bgcolor="#F4FBFF"><asp:Button CssClass="bt" ID="btnAddAd" runat="server" Text="添加广告" 
                    OnClick="btnAddAd_Click" /></td>           
        </tr>
        
    </table>
      <br>
    </fieldset>
    
     <asp:Repeater ID="RepAdList" runat="server">
    <ItemTemplate>
    <%#DataBinder.Eval(Container.DataItem, "adname")%>&nbsp;&nbsp;&nbsp;<a href="addAd.aspx?action=edit&id=<%#DataBinder.Eval(Container.DataItem, "id")%>">[修改]</a>
    </ItemTemplate>
    </asp:Repeater>
    
    </div></td>
      </tr>
    </table>
        </form>
</body>
</html>

