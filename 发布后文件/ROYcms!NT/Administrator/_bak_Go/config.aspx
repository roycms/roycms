<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="config.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator_Objet_config" EnableEventValidation="true" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<html>
<head runat="server">
<title></title>
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css" />
<script src="/administrator/WebUI/SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<link href="/administrator/WebUI/SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css">
</head>
<link rel="stylesheet" type="text/css" href="/administrator/WebUI/subModal/subModal.css" />
<script type="text/javascript" src="/administrator/WebUI/subModal/common.js"></script>
<script type="text/javascript" src="/administrator/WebUI/subModal/subModal.js"></script>
<script src="/administrator/WebUI/SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
<link href="/administrator/WebUI/SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css">
<body>
<form id="form1" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <div>
    <table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td height="5px"></td>
      </tr>
      <tr>
        <td><div id="TabbedPanels1" class="TabbedPanels">
            <ul class="TabbedPanelsTabGroup">
<li class="TabbedPanelsTab" tabindex="0"><img name="" src="/administrator/images/nv10.png" width="16" height="16" alt=""> 基本表单定义</li>
              <li class="TabbedPanelsTab" tabindex="0"><img name="" src="/administrator/images/nv2.png" width="16" height="16" alt=""> 表单字段扩展</li>
<li class="TabbedPanelsTab" tabindex="0"><img name="" src="/administrator/images/nv5.png" width="16" height="16" alt=""> 权限角色设定</li>
            </ul>
            <div class="TabbedPanelsContentGroup">
<div class="TabbedPanelsContent">
                <div>
                  <table width="98%" border="0" align="center" cellpadding="0" cellspacing="1">
                    <tr>
                      <td>
                       <!-- <span class="licss"></span>-->
                        <table width="100%" height="63" border="0" align="center" cellpadding="0" cellspacing="5">
                          <tr>
                            <td ><table width="100%" border="0" align="center" cellpadding="3" cellspacing="1"  id="add_table">
                              <tr>
                                <td colspan="2" align="left" valign="middle" nowrap="nowrap" bgcolor="#F4FBFF"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td width="5%" valign="middle"><img name="" src="/administrator/images/cms-gif.gif" width="32" height="32" alt=""></td>
                                    <td width="95%"><span class="yahei">
                                      <span class="hh4" style="font-size:18px; font-weight: bolder;">基本表单显示定义</span></span></td>
                                  </tr>
                                </table></td>
                                <td align="left" valign="middle" nowrap="nowrap" bgcolor="#F4FBFF" class="yahei">&nbsp;</td>
                                </tr>
                              <tr>
                                <td width="7%" align="right" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:CheckBox  ID="N1" runat="server"  Checked="True" Enabled="False" Text=" 信息标题：" />                                
                                  &nbsp;</td>
                                <td width="91%" bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="txttitle" runat="server" Width="400px" CssClass="input"></asp:TextBox>
                                  <asp:CheckBox Checked="false" ID="ding" runat="server" Text="置顶" title="新闻置顶" />                  
                                  <asp:CheckBox Checked="false" ID="tuijian" runat="server" Text="推荐" title="新闻推荐" />                  
                                  <asp:CheckBox Checked="true" ID="switchs" runat="server" Text="发布" title="新闻发布" /></td>
                                <td width="91%" align="center" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><span class="yahei"><strong>显示状态</strong></span></td>
                                </tr>
                              <tr>
                                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:CheckBox  ID="N2" runat="server" Text=" 属性：" />                                
                                  &nbsp;</td>
                                <td valign="top" bgcolor="#F4FBFF" class="TabbedPanelsTab"><table width="500" border="0" cellpadding="3" cellspacing="0">
                                  <tr>
                                    <td nowrap="nowrap">出处:
                                      <asp:TextBox ID="txtinfor" runat="server" CssClass="input" Width="50px" Height="20px">原创</asp:TextBox></td>
                                    <td nowrap="nowrap">作者:
                                      <asp:TextBox ID="txtauthor" runat="server" CssClass="input" Width="50px" Height="20px"></asp:TextBox></td>
                                    <td nowrap="nowrap">阅读次数:
                                      <asp:TextBox ID="txthits" runat="server" CssClass="input" Width="40px" Height="20px" Text="0"></asp:TextBox></td>
                                    <td nowrap="nowrap">顶次数:
                                      <asp:TextBox ID="txtdig" runat="server" CssClass="input" Width="40px" Height="20px" Text="0"></asp:TextBox></td>
                                    <td rowspan="2" nowrap="nowrap">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(可选属性) </td>
                                    </tr>
                                  <tr>
                                    <td nowrap="nowrap"> 权重:
                                      <select name="orders" class="drw_list" id="orders" style="height:18px" runat="server">
                                        <option value="">选择</option>
                                        <option value="1">001</option>
                                        <option value="2">002</option>
                                        <option value="3">003</option>
                                        <option value="4">004</option>
                                        <option value="5">005</option>
                                        <option value="6">006</option>
                                        <option value="7">007</option>
                                        <option value="8">008</option>
                                        <option value="9">009</option>
                                        <option value="10">010</option>
                                        </select></td>
                                    <td nowrap="nowrap">样式:
                                      <select name="styles" class="drw_list" id="styles" style="height:18px" runat="server">
                                        <option value="">选择</option>
                                        <option value="1">字+1</option>
                                        <option value="2">字+2</option>
                                        <option value="3">字+3</option>
                                        <option value="4">字+4</option>
                                        <option value="5">字+5</option>
                                        </select></td>
                                    <td nowrap="nowrap">颜色:
                                      <select name="colors" class="drw_list" id="colors" style="height:18px" runat="server">
                                        <option value="">选择</option>
                                        <option value="red">红色</option>
                                        <option value="blue">蓝色</option>
                                        <option value="green">绿色</option>
                                        <option value="black">黑色</option>
                                        </select></td>
                                    <td nowrap="nowrap">&nbsp;</td>
                                    <td nowrap="nowrap">&nbsp;</td>
                                    </tr>
                                  </table></td>
                                <td width="91%" align="center" valign="middle" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><img src='/administrator/images/<%Response.Write(IS_IN("属性")==true?"tick":"help");%>.gif' alt="选择可用TAG [每个标签请用英文的逗号隔开例“,”] (可选) " name="" width="16" height="16" border="0" /></td>
                                </tr>
                              <tr>
                                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:CheckBox  ID="N3" runat="server" Text="关键字：" />                                
                                   &nbsp;</td>
                                <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="keyword" runat="server" Width="400px" CssClass="input"></asp:TextBox>
                                  <span class="_help"> [关键字用英文的逗号隔开例“,”]</span></td>
                                <td align="center" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><img src="/administrator/images/<%Response.Write(IS_IN("关键字")==true?"tick":"help");%>.gif" alt="该项状态 " name="" width="16" height="16" border="0" /></td>
                                </tr>
                              <tr>
                                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:CheckBox  ID="N4" runat="server" Text="摘要：" />                                
                                   &nbsp;</td>
                                <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="txtzhaiyao" runat="server" Width="400px" 
                            CssClass="input" Height="45px" TextMode="MultiLine"></asp:TextBox>
                                  (可选)</td>
                                <td align="center" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><img src="/administrator/images/<%Response.Write(IS_IN("摘要")==true?"tick":"help");%>.gif" alt="该项状态 " name="" width="16" height="16" border="0" /></td>
                                </tr>
                              <tr>
                                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:CheckBox  ID="N5" runat="server" Text="形象图片：" />                                
                                   &nbsp;</td>
                                <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="txtpic" CssClass="input" runat="server" Width="1px" >no</asp:TextBox>
                                  &nbsp;
                                  <asp:FileUpload ID="FileUpload1" runat="server" Width="220px" CssClass="input" />
                                  (可选)&nbsp;
                                  尺寸
                                  <asp:DropDownList ID="DropDownList_ImgSize" runat="server" 
                            DataSourceID="XmlDataSource_ImgSize" DataTextField="name" DataValueField="size">
                                    </asp:DropDownList>
                                  <asp:XmlDataSource ID="XmlDataSource_ImgSize" runat="server" 
                            DataFile="~/App_Config/ImgSize.xml"></asp:XmlDataSource>
                                  <asp:Button ID="Button_add_img" runat="server"  Text="上传" CssClass="bt" /></td>
                                <td align="center" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><img src="/administrator/images/<%Response.Write(IS_IN("形象图")==true?"tick":"help");%>.gif" alt="该项状态 " name="" width="16" height="16" border="0" /></td>
                                </tr>
                              <tr>
                                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:CheckBox  ID="N6" runat="server" Text="链接：" />                                
                                   &nbsp;</td>
                                <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="txturl" runat="server"  CssClass="input" Width="320px"></asp:TextBox>
                                  (可选)</td>
                                <td align="center" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><img src="/administrator/images/<%Response.Write(IS_IN("链接")==true?"tick":"help");%>.gif" alt="该项状态 " name="" width="16" height="16" border="0" /></td>
                                </tr>
                              <tr>
                                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:CheckBox  ID="N7" runat="server" Text="跳转URL：" />                                
                                   &nbsp;</td>
                                <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="jumpurl" runat="server"   CssClass="input" Width="320px"></asp:TextBox>
                                  (可选)
                                  <asp:CheckBox Checked="false" ID="jumpurl_on_of" runat="server" Text="启用跳转" title="新闻跳转" /></td>
                                <td align="center" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><img src="/administrator/images/<%Response.Write(IS_IN("跳转")==true?"tick":"help");%>.gif" alt="该项状态 " name="" width="16" height="16" border="0" /></td>
                                </tr>
                              <tr>
                                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:CheckBox  ID="N8" runat="server" Text="标签TAG：" />                                
                                   &nbsp;</td>
                                <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:TextBox ID="txttag" runat="server"   CssClass="input" Width="320px"></asp:TextBox>
                                  <span class="_help">[每个标签请用英文的逗号隔开例“,”] </span>(可选) </td>
                                <td align="center" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab"><img src="/administrator/images/<%Response.Write(IS_IN("标签")==true?"tick":"help");%>.gif" alt="该项状态 " name="" width="16" height="16" border="0" /></td>
                                </tr>
                              <tr>
                                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab">&nbsp;</td>
                                <td bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:Button ID="Button_Z_From" runat="server" 
                      Text="确定提交使应用生效" CssClass="TabbedPanelsTabHover"
                          onclientclick="return window.confirm('确定要修改这些配置信息吗？');" 
                                    OnClick="Button_Z_From_Click"   /></td>
                                <td align="center" nowrap="nowrap" bgcolor="#F4FBFF" class="TabbedPanelsTab">&nbsp;</td>
                              </tr>
                            </table></td>
                          </tr>
                          <tr>
                            <td >&nbsp;</td>
                          </tr>
                        </table>
                      </td>
                    </tr>
                  </table>
                </div>
              </div>
              <div class="TabbedPanelsContent">
                <table width="100%" border="0" cellspacing="0" cellpadding="10">
                  <tr>
                    <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                          <td width="5%" valign="middle"><img name="" src="/administrator/images/FreeBI_006.gif" width="32" height="32" alt=""></td>
                          <td width="95%"><span class="yahei">
                            <span class="hh4" style="font-size:18px; font-weight: bolder;">自定义扩展表单</span></span></td>
                        </tr>
                      </table>
                      <br>
                      <table width="100%" border="0" cellpadding="3" cellspacing="0" class="TabbedPanelsTabHover">
                        <tr>
                          <td width="16%" height="23" nowrap><img src="/administrator/images/pencil_add.gif" alt="" name="" width="16" height="16" border="0"> <asp:FileUpload 
                                  ID="FileUpload_From" runat="server" Width="201px" />
                              <asp:Button ID="Button_From_add" runat="server" Text="导入表单HTML" 
                                  onclick="Button_From_add_Click" />&nbsp;</td>
                          <td width="84%" nowrap><img src="/administrator/images/nv6.png" alt="" name="" width="16" height="16" border="0">
                          <a style="color:#FFF;"  class="submodal-520-360" href='from.aspx?ClassKind=<%=this.ClassKind%>'> 导入示例表单模版</a></td>
                        </tr>
                      </table>
                    </td>
                  </tr>
                  <tr>
                    <td height="69">
                    
                  <img name="" src="/administrator/images/nv6.png" width="16" height="16" alt=""> <strong>预览效果</strong><br>
                  <table width="100%" border="0" cellspacing="0" cellpadding="8">
                    <tr>
                      <td><%=From_Out()%></td>
                      </tr>
                  </table></td>
</tr>
                </table>
              </div>
<div class="TabbedPanelsContent">
  <table width="100%" border="0" cellspacing="5" cellpadding="0">
                  <tr>
                    <td><table width="100%" cellpadding="10" cellspacing="1">
                      <tr>
                        <td colspan="2" nowrap class="yahei"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="5%" valign="middle"><img name="" src="/administrator/images/FreeBI_006.gif" width="32" height="32" alt=""></td>
                            <td width="95%"><span class="hh4 yahei" style="font-size:18px; font-weight: bolder;">权限角色设定</span></td>
                          </tr>
                        </table></td>
                        </tr>
                      <tr>
                        <td width="8%" nowrap class="TabbedPanelsTab">权限设置</td>
                        <td width="92%" nowrap class="TabbedPanelsTab"><asp:CheckBox ID="CheckBox26" runat="server" Text="角色" />                    
                          <asp:CheckBox ID="CheckBox27" runat="server" Text="角色" />                      
                          <asp:CheckBox ID="CheckBox28" runat="server" Text="角色" />                      
                          <asp:CheckBox ID="CheckBox29" runat="server" Text="角色" />                      
                          <asp:CheckBox ID="CheckBox30" runat="server" Text="角色" />                      
                          <asp:CheckBox ID="CheckBox31" runat="server" Text="角色" /></td>
                      </tr>
                      <tr>
                        <td nowrap class="TabbedPanelsTab">角色选择</td>
                        <td nowrap class="TabbedPanelsTab"><asp:CheckBox ID="CheckBox32" runat="server" Text="角色" />                    
                          <asp:CheckBox ID="CheckBox33" runat="server" Text="角色" />                      
                          <asp:CheckBox ID="CheckBox34" runat="server" Text="角色" />                      
                          <asp:CheckBox ID="CheckBox35" runat="server" Text="角色" />                      
                          <asp:CheckBox ID="CheckBox36" runat="server" Text="角色" />                      
                          <asp:CheckBox ID="CheckBox37" runat="server" Text="角色" />                      
                          <asp:CheckBox ID="CheckBox38" runat="server" Text="角色" />                      
                          <asp:CheckBox ID="CheckBox39" runat="server" Text="角色" /></td>
                        </tr>
                      <tr>
                        <td nowrap class="TabbedPanelsTab">&nbsp;</td>
                        <td nowrap bgcolor="#F4FBFF" class="TabbedPanelsTab"><asp:Button ID="Button_stup_Role" runat="server" 
                      Text="确定提交使应用生效" CssClass="TabbedPanelsTabHover"
                          onclientclick="return window.confirm('确定要修改这些配置信息吗？');" 
                      OnClick="Button_stup_Role_Click"  /></td>
                        </tr>
                    </table></td>
                  </tr>
                </table>
</div>
            </div>
          </div></td>
      </tr>
    </table>
  </div>
</form>
<script type="text/javascript">
<!--
var TabbedPanels1 = new Spry.Widget.TabbedPanels("TabbedPanels1");
//-->
</script>
</body>
</html>
