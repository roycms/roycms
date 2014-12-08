<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Issue.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator_go_Issue" %>

<html>
<head runat="server">
    <title>发布</title>
    <link href="/administrator/css/style.css" rel="stylesheet" type="text/css" />
    <script src="/administrator/WebUI/SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
<link href="/administrator/WebUI/SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <div id="TabbedPanels1" class="TabbedPanels">
      <ul class="TabbedPanelsTabGroup">
        <li class="TabbedPanelsTab" tabindex="0"><strong><img name="" src="/administrator/images/plus-.gif" width="6" height="5" alt=""></strong>当前左侧菜单模块</li>
        <li class="TabbedPanelsTab" tabindex="0"><strong><img name="" src="/administrator/images/plus-.gif" width="6" height="5" alt=""></strong>添加一个新模块到左侧菜单</li>
</ul>
      <div class="TabbedPanelsContentGroup">
        <div class="TabbedPanelsContent">
          <table width="100%" border="0" align="center" cellpadding="8" cellspacing="0">
            <tr>
              <td width="33%" height="74"><h4><img name="" src="/administrator/images/go_1.png" width="64" height="64" alt="">
                <span class="yahei">添加左侧菜单 [添加模块]</span></h4></td>
            </tr>
            <tr>
              <td><table width="100%" border="0" cellspacing="3" cellpadding="2">
                <tr>
                  <td width="17%" nowrap class="TabbedPanelsTab"> 全局标识</td>
                  <td width="83%" nowrap class="TabbedPanelsTab"><asp:TextBox ID="TextBox_Classkind" runat="server" 
            CssClass="input"  ReadOnly="True"   ></asp:TextBox>
                    <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="">
                    <asp:CheckBox ID="CheckBox15" runat="server" Text="是否显示" /></td>
                </tr>
                <tr>
                  <td nowrap class="TabbedPanelsTab">名称</td>
                  <td nowrap class="TabbedPanelsTab"><asp:TextBox ID="TextBox_name" runat="server" CssClass="input" 
            Width="160px"></asp:TextBox>
                    <img name="" src="/administrator/images/tick.png" width="16" height="16" alt=""></td>
                </tr>
                <tr>
                  <td nowrap class="TabbedPanelsTab">描述</td>
                  <td nowrap class="TabbedPanelsTab"><asp:TextBox ID="TextBox_description" runat="server" CssClass="input" Width="160px" ></asp:TextBox>
                    <img name="" src="/administrator/images/tick.png" width="16" height="16" alt=""></td>
                </tr>
                <tr>
                  <td nowrap class="TabbedPanelsTab">LOGO地址</td>
                  <td nowrap class="TabbedPanelsTab"><asp:TextBox ID="TextBox_logo" runat="server" CssClass="input"   Width="160px"></asp:TextBox>
                    <img name="" src="/administrator/images/tick.png" width="16" height="16" alt=""></td>
                </tr>
                <tr>
                  <td nowrap class="TabbedPanelsTab">自定义表单配置文件地址</td>
                  <td nowrap class="TabbedPanelsTab"><asp:TextBox ID="TextBox_TemplateFrom" runat="server" CssClass="input"  Width="160px" ></asp:TextBox>
                    <img name="" src="/administrator/images/tick.png" width="16" height="16" alt=""></td>
                </tr>
                <tr>
                  <td nowrap class="TabbedPanelsTab">附件配置文件地址</td>
                  <td nowrap class="TabbedPanelsTab"><asp:TextBox ID="TextBox_AppendixConfig" runat="server" CssClass="input"  Width="160px" ></asp:TextBox>
                    <img name="" src="/administrator/images/tick.png" width="16" height="16" alt=""></td>
                </tr>
                <tr>
                  <td nowrap class="TabbedPanelsTab">附件存放地址</td>
                  <td nowrap class="TabbedPanelsTab"><asp:TextBox ID="TextBox_AppendixPath" runat="server" CssClass="input"  Width="160px"></asp:TextBox>
                    <img name="" src="/administrator/images/tick.png" width="16" height="16" alt=""></td>
                </tr>
                <tr>
                  <td nowrap class="TabbedPanelsTab">权限设置</td>
                  <td nowrap class="TabbedPanelsTab"><asp:CheckBox ID="CheckBox1" runat="server" Text="角色" />          
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="角色" />            
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="角色" />            
                    <asp:CheckBox ID="CheckBox4" runat="server" Text="角色" />            
                    <asp:CheckBox ID="CheckBox5" runat="server" Text="角色" />            
                    <asp:CheckBox ID="CheckBox6" runat="server" Text="角色" /></td>
                </tr>
                <tr>
                  <td nowrap class="TabbedPanelsTab">角色选择</td>
                  <td nowrap class="TabbedPanelsTab"><asp:CheckBox ID="CheckBox7" runat="server" Text="角色" />          
                    <asp:CheckBox ID="CheckBox8" runat="server" Text="角色" />            
                    <asp:CheckBox ID="CheckBox9" runat="server" Text="角色" />            
                    <asp:CheckBox ID="CheckBox10" runat="server" Text="角色" />            
                    <asp:CheckBox ID="CheckBox11" runat="server" Text="角色" />            
                    <asp:CheckBox ID="CheckBox13" runat="server" Text="角色" />            
                    <asp:CheckBox ID="CheckBox14" runat="server" Text="角色" /></td>
                </tr>
              </table></td>
            </tr>
            <tr>
              <td><asp:Button ID="Button_add_objet" runat="server" Text="添加新模块" 
                          onclick="Button_add_objet_Click" CssClass="TabbedPanelsTabHover"  OnClientClick="return window.confirm('在操作前确定已经了解该操作，确定要这样操作吗？');"  /></td>
            </tr>
          </table>
        </div>
        <div class="TabbedPanelsContent"></div>
</div>
    </div>
    </div>
    </form>
    <script type="text/javascript">
<!--
var TabbedPanels1 = new Spry.Widget.TabbedPanels("TabbedPanels1");
//-->
</script>
</body>
</html>
