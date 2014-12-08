<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Appendix.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Objet.Appendix" %>
<!DOCTYPE HTML>
<head runat="server">
<title>附件管理</title>
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css" />
<script src="/administrator/WebUI/SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
<link href="/administrator/WebUI/SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css">
</head>
<style type="text/css">
.sec1 {
	background-color:  #F4F4F4;
	cursor:  hand;
	color:  #000000;
	border-left:  1px solid #FFFFFF;
	border-top:  1px solid #FFFFFF;
	border-right:  1px solid gray;
	border-bottom:  1px solid #FFFFFF
}
.sec2 {
	background-color:  #EAEAEA;
	cursor:  hand;
	color:  #58A200;
	border-left:  1px solid #FFFFFF;
	border-top:  1px solid #FFFFFF;
	border-right:  1px solid gray;
	font-weight:  bold;
	margin: 5px;
	padding: 5px;
}
</style>
<body>
<form id="form1" runat="server">
  <div style="padding:10px;"><br />
    <div id="TabbedPanels1" class="TabbedPanels">
      <ul class="TabbedPanelsTabGroup">
        <li class="TabbedPanelsTab" tabindex="0"><strong><img name="" src="/administrator/images/plus-.gif" width="6" height="5" alt=""></strong>上传本地文件到服务器</li>
        <li class="TabbedPanelsTab" tabindex="0"><strong><img name="" src="/administrator/images/plus-.gif" width="6" height="5" alt=""></strong>远程图片链接</li>
        <li class="TabbedPanelsTab" tabindex="0"><strong><img name="" src="/administrator/images/plus-.gif" width="6" height="5" alt=""></strong>浏览上传的文件</li>
      </ul>
      <div class="TabbedPanelsContentGroup">
        <div class="TabbedPanelsContent">
          <table width="98%" border="0" align="center" cellpadding="10" cellspacing="0">
            <tr>
              <td colspan="2"><img name="" src="/administrator/images/page_white_go.png" width="16" height="16" alt=""> 当前附件内容</td>
            </tr>
            <tr>
              <td width="7%" align="left" valign="top" nowrap><asp:ListBox ID="ListBox_img" runat="server" Height="80px" Width="232px" 
            CssClass="input" AutoPostBack="True" 
                    onselectedindexchanged="ListBox_img_SelectedIndexChanged">
              </asp:ListBox></td>
              <td width="93%" align="left" valign="top" nowrap><font color="#FF0000"><img name="" src="/administrator/images/lightbulb_add.png" width="16" height="16" alt=""> 双击项删除附件</font></td>
            </tr>
            <tr>
              <td colspan="2" nowrap><asp:FileUpload ID="FileUpload1" runat="server" 
                        Width="240px" /></td>
            </tr>
            <tr>
              <td colspan="2" nowrap><img name="" src="/administrator/images/lightbulb_add.png" width="16" height="16" alt=""> (图片则)尺寸
                <asp:DropDownList CssClass="input" DataTextField="name" DataValueField="size" ID="DropDownList_ImgSize" runat="server" 
            datasourceid="XmlDataSource_size">
                </asp:DropDownList>
                <asp:XmlDataSource ID="XmlDataSource_size" runat="server" 
            DataFile="~/App_Config/ImgSize.xml"></asp:XmlDataSource>
                <asp:Button ID="Button_add" runat="server" Text="上传到服务器" CssClass="bt" 
            OnClick="Button_add_Click" /></td>
            </tr>
          </table>
        </div>
        <div class="TabbedPanelsContent">
          <table width="98%" border="0" align="center" cellpadding="10" cellspacing="0">
            <tr>
              <td width="8%" nowrap>远程文件地址</td>
              <td width="88%" nowrap><asp:TextBox ID="TextBox_web_url" runat="server" 
                        CssClass="input"></asp:TextBox>
                <img name="" src="/administrator/images/tick.png" width="16" height="16" alt=""></td>
              <td width="4%">&nbsp;</td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td><asp:Button ID="Button_add_web" runat="server" Text="添加到服务器" 
                        onclick="Button_add_web_Click" CssClass="bt" /></td>
              <td>&nbsp;</td>
            </tr>
          </table>
        </div>
        <div class="TabbedPanelsContent">
          <asp:Xml ID="Xml_liulan" runat="server"></asp:Xml>
        </div>
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
