<%@ Page Language="C#" AutoEventWireup="True" Inherits="ROYcms.UI.Admin.Administrator_config_config" Codebehind="config.aspx.cs" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<!DOCTYPE HTML>
<html>
<head runat="server">
<title></title>
<script src="/administrator/WebUI/SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
<link href="/administrator/WebUI/SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css">
</head>
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
<script language="JavaScript"  src="/administrator/js/alt.js"></script>
<body>
<form id="form1" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <div>
  <%if(1==2){%>
    <table width="98%"  border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td>
            <table width="100%" border="0" cellspacing="0" cellpadding="6">
              <tr>
                <td align="left"><div id="TabbedPanels1" class="TabbedPanels">
                    <ul class="TabbedPanelsTabGroup">
                      <li class="TabbedPanelsTab" tabindex="0"><img name="" src="/administrator/images/nv4.png" width="16" height="16" alt="网站基本信息设置"> 系统全局基本设置</li>
                      <li class="TabbedPanelsTab" tabindex="0"><img name="" src="/administrator/images/asterisk_orange.png" width="16" height="16" alt="网站基本信息设置"> 系统高级设置</li>
                      <li class="TabbedPanelsTab" tabindex="0"><img name="" src="/administrator/images/asterisk_orange.png" width="16" height="16" alt="网站基本信息设置"> <a href="CMS_config.aspx" target="_blank">扩展设置[CMS.config]</a></li>
                  </ul>
                    <div class="TabbedPanelsContentGroup">
                      <div class="TabbedPanelsContent">
                        <table width="98%" height="159" border="0" align="center" cellpadding="5" cellspacing="1" >

                          <tr>
                            <td width="145" align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">网站名称:</td>
                            <td width="1040" bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox CssClass="input" ID="TextBox_web_name" runat="server" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                      ErrorMessage="网站名称不能为空" ControlToValidate="TextBox_web_name"></asp:RequiredFieldValidator></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">网站域名:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="TextBox_web_host" runat="server" CssClass="input" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ErrorMessage="网站域名不能为空" ControlToValidate="TextBox_web_host"></asp:RequiredFieldValidator></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">系统管理员密码:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="TextBox_web_password" runat="server" CssClass="input" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                      ErrorMessage="系统密码不能为空" ControlToValidate="TextBox_web_password"></asp:RequiredFieldValidator></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">网页扩展名:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="TextBox_web_forge" runat="server" CssClass="input" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                      ErrorMessage="网页扩展名不能为空" ControlToValidate="TextBox_web_forge"></asp:RequiredFieldValidator></td>
                          </tr>
                          
                           <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">新闻页面URL重写模式:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="TextBox_web_NewUrlModel" runat="server" CssClass="input" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="新闻页面URL重写模式设置">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                      ErrorMessage="新闻页面URL重写模式不能为空" ControlToValidate="TextBox_web_NewUrlModel"></asp:RequiredFieldValidator></td>
                          </tr>
                          
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">文件上传文件夹:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="TextBox_WEBSITE_UP_FILES" runat="server" CssClass="input" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                      ErrorMessage="文件上传文件夹不能为空" ControlToValidate="TextBox_WEBSITE_UP_FILES"></asp:RequiredFieldValidator></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">模板编码:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="TextBox_templet_language" runat="server" CssClass="input" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                      ErrorMessage="模板编码不能为空" ControlToValidate="TextBox_templet_language"></asp:RequiredFieldValidator></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">模板所在目录:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="TextBox_templet_root" runat="server" CssClass="input" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                      ErrorMessage="模板所在目录不能为空" ControlToValidate="TextBox_templet_root"></asp:RequiredFieldValidator></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">当前模板组:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="TextBox_templet_file" runat="server" CssClass="input" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                      ErrorMessage="当前模板组不能为空" ControlToValidate="TextBox_templet_file"></asp:RequiredFieldValidator></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">文件管理目录:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="FileManager_root" runat="server" CssClass="input" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                      ErrorMessage="模板编码不能为空" ControlToValidate="FileManager_root"></asp:RequiredFieldValidator></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">允许编辑文件扩展名:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="FileManager_file_type" runat="server" CssClass="input" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                      ErrorMessage="模板编码不能为空" ControlToValidate="FileManager_file_type"></asp:RequiredFieldValidator></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">网站静态生成:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:CheckBox ID="CheckBox_HTML" runat="server" Text="启用静态生成" /></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">网页压缩输出;</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:CheckBox ID="CheckBox2" runat="server" Text="是否压缩输出" /></td>
                          </tr>
                          <tr>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab">&nbsp;</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:Button BackColor="#F4FBFF" CssClass="bt" ID="Button_update" runat="server" Text="更新设置" OnClick="Button_update_Click" OnClientClick="return window.confirm('确定要设置吗?');" /></td>
                          </tr>
                        </table>
                      </div>
                      <div class="TabbedPanelsContent">
                        <table width="98%" height="159" border="0" align="center" cellpadding="5" cellspacing="1" >
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">站点唯一标识GUID:</td>
                            <td width="1040" bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox CssClass="input" ID="TextBox_GUID" runat="server" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置"></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">用户中心站地址:</td>
                            <td width="1040" bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox CssClass="input" ID="TextBox_UcenterWebserver" runat="server" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置"></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">用户中心站密码:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox CssClass="input" ID="TextBox_UcenterPassword" runat="server" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置"></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">网站LOGO:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox CssClass="input" ID="TextBox_logo" runat="server" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置"></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">网站title:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="TextBox_title" runat="server" CssClass="input" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置"></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">网站首页 关键字:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="TextBox_keyword" 
                                    runat="server" CssClass="input" Width="262px" Height="36px" 
                                    TextMode="MultiLine"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置"></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">网站首页描述:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="TextBox_Description" 
                                    runat="server" CssClass="input" Width="306px" Height="67px" 
                                    TextMode="MultiLine"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置"></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">网站版权信息:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="TextBox_Copyright" 
                                    runat="server" CssClass="input" Width="308px" Height="52px" 
                                    TextMode="MultiLine"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置"></td>
                          </tr>
                          <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab">系统版本:</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="TextBox_Version" runat="server" CssClass="input" Width="200"></asp:TextBox>
                              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置"></td>
                          </tr>
                          <tr>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab">&nbsp;</td>
                            <td bgcolor="#F4FBFF" class="TabbedPanelsTab">&nbsp;</td>
                          </tr>
                        </table>
                      </div>
                      <div class="TabbedPanelsContent"><!--内容 3--></div>
                  </div>
                  </div></td>
              </tr>
            </table>
          </td>
      </tr>
    </table>
	<script type="text/javascript">
<!--
var TabbedPanels1 = new Spry.Widget.TabbedPanels("TabbedPanels1");
//-->
</script>
  <%}%>
  
  <a href="CMS_config.aspx" target="_blank"> 全局配置</a></div>
</form>

</body>
</html>
