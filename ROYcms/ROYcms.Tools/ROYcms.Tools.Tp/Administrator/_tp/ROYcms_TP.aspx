<%@ Page Language="C#" AutoEventWireup="True" Inherits="ROYcms.Tools.Tp.ROYcms_TP" Codebehind="ROYcms_TP.aspx.cs" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title></title>
<style type="text/css">
<!--
.input {
	border:1px solid #B5B8C9;
	font:normal 12px/18px 'Tahoma';
	margin-top: 4px;
	margin-right: 0;
	margin-bottom: 4px;
	margin-left: 0;
	padding-top: 2px;
	padding-right: 1px;
	padding-bottom: 0;
	padding-left: 1px;
}
.text {
	font-size: 14px;
	color: #555;
}
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	font-size: 12px;
}
.link {
	font-size: 12px;
	color: #3C5899;
}
.huise {
	color: #999999
}
.xm_list {
	font-size: 13px;
	line-height: 20px;
	color: #6295DB;
	margin: 6px;
	border-bottom-width: 1px;
	border-bottom-style: dashed;
	border-bottom-color: #DFDFDF;
	margin-left: 30px;
}
.barbg {
	BACKGROUND-COLOR: #efefef;
	WIDTH: 600px;
	HEIGHT: 20px;
	MARGIN-RIGHT: 10px;
	margin: 10px;
}
.l {
	PADDING-BOTTOM: 0px;
	MARGIN: 0px;
	PADDING-LEFT: 0px;
	PADDING-RIGHT: 0px;
	FLOAT: left;
	PADDING-TOP: 0px
}
.record {
	LINE-HEIGHT: 20px;
	WIDTH: 75px;
	FLOAT: left
}
a:link {
	text-decoration: none;
}
a:visited {
	text-decoration: none;
}
a:hover {
	text-decoration: none;
}
a:active {
	text-decoration: none;
}
#logo {
	height: 18px;
	text-align: left;
	padding: 6px;
	display: table;
	background-color: #EFEFEF;
	border: 1px solid #E4E4E4;
	font-weight: bold;
	margin-top: 10px;
	width: 100%;
}
#content {
	text-align: left;
	padding: 10px;
	display: table;
	background-color: #FAFAFA;
	font-size: 13px;
	color: #465A8E;
	line-height: 23px;
	width: 100%;
}
-->
</style>
<link href="../../images/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
  <asp:Panel ID="Panel_index" runat="server">
    <script src="SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
    <link href="SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css" />
    <table width="100%" border="0" cellspacing="0" cellpadding="0" height="8px">
      <tr>
        <td bgcolor="#9ABBE8"></td>
      </tr>
    </table>
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="69%" height="33" bgcolor="#DFE8F7"></td>
        <td width="10%" bgcolor="#9ABBE8" class="text"><b>&nbsp;&nbsp;&nbsp;&nbsp;投票TOOLS</b></td>
        <td width="21%" bgcolor="#DFE8F7"></td>
      </tr>
    </table>
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td>&nbsp;</td>
      </tr>
    </table>
    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
    <tr>
      <td valign="top"><div id="TabbedPanels1" class="TabbedPanels">
          <ul class="TabbedPanelsTabGroup">
            <li class="TabbedPanelsTab" tabindex="0">
              <%Response.Write(Session["group_name"] == null ? "请初始化..." : Session["group_name"]); %>
            </li>
            <li class="TabbedPanelsTab" tabindex="0">添加项目</li>
            <li class="TabbedPanelsTab" tabindex="0">管理项目</li>
            <li class="TabbedPanelsTab" tabindex="0">全局设置</li>
            <li class="TabbedPanelsTab" tabindex="0">添加项目组</li>
            <li class="TabbedPanelsTab" tabindex="0">管理项目组</li>
            <li class="TabbedPanelsTab" tabindex="0">投票结果示意图</li>
            <li class="TabbedPanelsTab" tabindex="0">评论/报名 管理</li>
          </ul>
          <div class="TabbedPanelsContentGroup">
            <!--选项卡1开始-->
            <div class="TabbedPanelsContent">
              <table width="67%" height="223" border="0" align="center" cellpadding="10" cellspacing="0">
                <tr>
                  <td width="23%" align="right" valign="bottom" nowrap="nowrap" class="text">当前选择的组：</td>
                  <td width="77%" valign="bottom" nowrap="nowrap" class="text"><%Response.Write(Session["group_name"] == null ? "<font color=red>未选择分组</font>" : Session["group_name"]); %></td>
                </tr>
                <tr>
                  <td align="right" valign="top" nowrap="nowrap" class="text">管理分组切换：</td>
                  <td valign="top" nowrap="nowrap" class="text"><asp:DropDownList 
                      ID="DropDownList_group" 
                      runat="server" 
                      CssClass="input" 
                          AutoPostBack="True" 
                          OnSelectedIndexChanged="DropDownList_group_SelectedIndexChanged" >
                    </asp:DropDownList>
                      (
                    <% Response.Write(Session["group_name"] != null ? "<a href='?t=logout' class='link'>退出分组管理</a>||" : "");%>
                    
                    <a href="?t=out" class="link"  onClick="return window.confirm('确定退出管理吗?');" >退出管理</a>
                      )</td>
                </tr>
              </table>
            </div>
            <div class="TabbedPanelsContent">
              <table width="100%" border="0" cellspacing="5" cellpadding="5">
                <tr>
                  <td height="47"><span class="huise">项目添加帮助：项目的添加分 
                      形象图片，项目名称，项目描述，项目的链接地址，可以在发布时根据自己的需要来理解项目的定义。</span></td>
                </tr>
              </table>
              <table width="100%" border="0" align="center" cellpadding="3" cellspacing="0">
                
                
                  <asp:Panel ID="Panel_small" runat="server" Visible="false"> 
                  
                  <tr>
                  <td width="16%" height="41" align="right" nowrap="nowrap" class="text">项目图片：</td>
                  <td width="52%" align="left">
                  <asp:TextBox ID="small_names" runat="server" CssClass="input" Height="18px" 
            Width="278px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
            Display="Dynamic" ErrorMessage="请填写项目名称" ControlToValidate="small_names" ValidationGroup="06"></asp:RequiredFieldValidator>
                  <asp:Button ID="Button4" runat="server" Text="添加该项目" CssClass="bt" 
            Height="29px" Width="121px" OnClick="Button4_Click" ValidationGroup="06" />
                   </td>
                  <td width="32%">&nbsp;</td>
                </tr>
                </asp:Panel>
                  
                <asp:Panel ID="Panel_big" runat="server"> 
                <tr>
                  <td width="16%" height="41" align="right" nowrap="nowrap" class="text">项目图片：</td>
                  <td width="52%" align="left"><asp:FileUpload ID="files" runat="server" CssClass="input"  Width="278px" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            Display="Dynamic" ErrorMessage="请选择项目形象图片" ControlToValidate="Files" 
                      ValidationGroup="01"></asp:RequiredFieldValidator>
                  </td>
                  <td width="32%">&nbsp;</td>
                </tr>
              
                
                
                <tr>
                  <td height="41" align="right" nowrap="nowrap" class="text">项目名称：</td>
                  <td align="left"><asp:TextBox ID="names" runat="server" CssClass="input" Height="18px" 
            Width="278px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            Display="Dynamic" ErrorMessage="请填写项目名称" ControlToValidate="names" ValidationGroup="01"></asp:RequiredFieldValidator>
                  </td>
                  <td>&nbsp;</td>
                </tr>
                
                
                  
                <tr>
                  <td height="41" align="right" nowrap="nowrap" class="text">项目描述：</td>
                  <td align="left"><asp:TextBox ID="characterization" runat="server" Height="105px" TextMode="MultiLine" 
            Width="421px" CssClass="input"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            Display="Dynamic" ErrorMessage="请填写项目描述" 
            ControlToValidate="characterization" ValidationGroup="01"></asp:RequiredFieldValidator>
                  </td>
                  <td>&nbsp;</td>
                </tr>
                
                
                <tr>
                  <td height="41" align="right" nowrap="nowrap" class="text">项目连接地址：</td>
                  <td align="left"><asp:TextBox ID="link_url" runat="server" CssClass="input" Height="18px" 
            Width="278px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            Display="Dynamic" ErrorMessage="请填写项目连接地址" ControlToValidate="link_url" ValidationGroup="01"></asp:RequiredFieldValidator>
                  </td>
                  <td>&nbsp;</td>
                </tr>
                
                
                
                <tr>
                  <td height="41" align="right" nowrap="nowrap" class="text">&nbsp;</td>
                  <td align="left"><asp:Button ID="Button1" runat="server" Text="添加该项目" CssClass="bt" 
            Height="29px" Width="121px" OnClick="Button1_Click" ValidationGroup="01" />
                  </td>
                  <td>&nbsp;</td>
                </tr>
                
                </asp:Panel>
              </table>
            </div>
            <!--选项卡一结束-->
            <div class="TabbedPanelsContent">
            <table width="100%" border="0" cellspacing="5" cellpadding="5">
              <tr>
                <td height="47"><span class="huise">项目管理帮助：请明确每一步操作的情况下进行下一步。每个操作都可能影响到正在进行中的投票结果。</span></td>
              </tr>
            </table>
            
            <asp:Panel ID="Panel_edit_date" runat="server" Visible="false">
              <div class="xm_list">
                <table width="100%" border="0" align="center" cellpadding="3" cellspacing="0">
                 
                  
                  <tr>
                    <td width="16%" height="41" align="right" nowrap="nowrap" class="text">项目图片：</td>
                    <td width="52%" align="left"><asp:TextBox ID="edit_date_img" runat="server" CssClass="input" Height="18px" 
                        Width="278px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        Display="Dynamic" ErrorMessage="请选填写目形象图片"  ControlToValidate="edit_date_img"
                                  ValidationGroup="05"></asp:RequiredFieldValidator>
                    </td>
                    <td width="32%">&nbsp;</td>
                  </tr>
                  
                  
                  <tr>
                    <td height="30" align="right" nowrap="nowrap" class="text">项目名称：</td>
                    <td align="left"><asp:TextBox ID="edit_names" runat="server" CssClass="input" Height="18px" 
                        Width="278px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        Display="Dynamic" ErrorMessage="请填写项目名称" ControlToValidate="edit_names" ValidationGroup="05"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                  </tr>
                  
                  
                  <tr>
                    <td height="30" align="right" nowrap="nowrap" class="text">项目描述：</td>
                    <td align="left"><asp:TextBox ID="edit_characterization" runat="server" Height="68px" TextMode="MultiLine" 
                        Width="360px" CssClass="input"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                        Display="Dynamic" ErrorMessage="请填写项目描述" 
                        ControlToValidate="edit_characterization" ValidationGroup="05"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                  </tr>
                  
                  
                  <tr>
                    <td height="30" align="right" nowrap="nowrap" class="text">项目连接地址：</td>
                    <td align="left"><asp:TextBox ID="edit_link_url" runat="server" CssClass="input" Height="18px" 
                        Width="278px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                        Display="Dynamic" ErrorMessage="请填写项目连接地址" ControlToValidate="edit_link_url" ValidationGroup="05"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                  </tr>
                  
                  
                  <tr>
                    <td height="30" align="right" nowrap="nowrap" class="text">请选择分组：</td>
                    <td align="left">

                        <asp:DropDownList ID="DropDownList_edit_date" runat="server">
                        </asp:DropDownList> 
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                        Display="Dynamic" ErrorMessage="请选择分组" ControlToValidate="DropDownList_edit_date" ValidationGroup="05"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                  </tr>
                  <tr>
                    <td height="30" align="right" nowrap="nowrap" class="text">票数：</td>
                    <td align="left"><asp:TextBox ID="edit_date_p" runat="server" CssClass="input" Height="18px" 
                        Width="60px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                        Display="Dynamic" ErrorMessage="请填写票数" ControlToValidate="edit_date_p" ValidationGroup="05"></asp:RequiredFieldValidator>
                        
        
                    </td>
                    <td>&nbsp;</td>
                  </tr>
                  <tr>
                    <td height="30" align="right" nowrap="nowrap" class="text">&nbsp;</td>
                    <td align="left"><asp:Button ID="Button_edit_date" runat="server" Text="确认编辑" CssClass="bt" 
                        Height="29px" Width="121px" ValidationGroup="05" onclick="Button_edit_date_Click" />
                    </td>
                    <td>&nbsp;</td>
                  </tr>
                </table>
              </div>
            </asp:Panel>
            <asp:Repeater ID="Repeater_xmlist" runat="server">
              <HeaderTemplate>
                <div class="xm_list">
                <table border="0" cellpadding="0" cellspacing="0" width="98%">
              </HeaderTemplate>
              <ItemTemplate>
                <tbody><tbody  ><tbody  ><tbody  ><tbody  ><tbody  ><tbody  ><tbody  ><tbody  ><tbody  ><tbody  ><tbody  ><tbody  ><tr class="xm_list">
                    <td> 项目名称： [
                      <a href='<%#Eval("link_url").ToString().Trim() %>' target="_blank">
                        <span class="text"><%#Eval("names").ToString().Trim() %></span>
                      </a>
                        ] </td>
                    <td> 入库时间： [ <%#Eval("datetime") %>] </td>
                    <td> 票数： <%#Eval("ballot") %>
                    </td>
                    <td> 状态：<%# Eval("y").ToString()=="1"?"已审":"未审" %>
                    </td>
                    <td><a href='?id=<%#Eval("id")%>&t=del' onClick="return window.confirm('确定删除吗?');" >
                        删除</a>
                        |
                      <a href='?id=<%#Eval("id")%>&z_id=<%#Eval("z_id")%>&t=date_edit' >编辑</a>
                        |
                      <a href='?tp_id=<%#Eval("id")%>' target="_blank" >投一票</a>
                      <%# Eval("y").ToString() == "1" ? "" : no(Eval("id").ToString())%>
                    </td>
                  </tr>
              </ItemTemplate>
              <FooterTemplate>
                </table>
                </div>
              </FooterTemplate>
            </asp:Repeater>
            <br />
          </div>
          <div class="TabbedPanelsContent">
            <table width="100%" border="0" cellspacing="5" cellpadding="5">
              <tr>
                <td height="47"><span class="huise">项目添加帮助：项目的添加分 
                    形象图片，项目名称，项目描述，项目的链接地址，可以在发布时根据自己的需要来理解项目的定义。</span></td>
              </tr>
            </table>
            <table width="100%" height="160" border="0" cellpadding="5" cellspacing="0">
              <tr>
                <td width="21%" align="right" nowrap="nowrap">&nbsp;</td>
                <td width="79%" nowrap="nowrap"><asp:CheckBox ID="CheckBox1" runat="server" Text="是否启用参与投票者调查"/></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap">&nbsp;</td>
                <td nowrap="nowrap"><asp:CheckBox ID="CheckBox_IP_Y" runat="server"  Text="是否限制IP重复投票"/></td>
              </tr>
              <tr>
                <td height="38" align="right" nowrap="nowrap" class="text">限制同一IP投票的间隔时间：</td>
                <td nowrap="nowrap"><asp:TextBox ID="config_time" runat="server" 
                CssClass="input" Height="18px" Width="160px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ErrorMessage="请填写限制同一IP投票的间隔时间" ControlToValidate="config_time" 
                      Display="Dynamic" validationgroup="02" ></asp:RequiredFieldValidator>
                  <span class="link">(秒为单位，例：如果是30分钟就填写30*60=1800)</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" class="text">投票的项目图片存放路径：</td>
                <td nowrap="nowrap"><asp:TextBox ID="TP_upfile" runat="server" CssClass="input" Height="18px" Width="160px" ></asp:TextBox></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" class="text">项目缩略图图宽和高：</td>
                <td nowrap="nowrap"><asp:TextBox ID="TP_upfile_w_h" runat="server" CssClass="input" Height="18px" Width="160px"></asp:TextBox></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" class="text">投票之后返回页面：</td>
                <td nowrap="nowrap"><asp:TextBox ID="TP_Redirect" runat="server" CssClass="input" Height="18px" Width="160px"></asp:TextBox></td>
              </tr>
              
              <tr>
                <td align="right" nowrap="nowrap" class="text">管理密码修改：</td>
                <td nowrap="nowrap"><asp:TextBox ID="admin_password" runat="server" CssClass="input" Height="18px" Width="160px"></asp:TextBox></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" class="text">&nbsp;</td>
                <td nowrap="nowrap"><asp:Button ID="Button2" runat="server" Text="确认设置" CssClass="bt" 
                Height="25px" Width="88px" OnClick="Button2_Click" OnClientClick="return window.confirm('确定要更新配置吗?');" validationgroup="02" /></td>
              </tr>
            </table>
          </div>
          <div class="TabbedPanelsContent">
            <table width="100%" border="0" cellspacing="5" cellpadding="5">
              <tr>
                <td height="47"><span class="huise">项目添加帮助：项目的添加分 
                    形象图片，项目名称，项目描述，项目的链接地址，可以在发布时根据自己的需要来理解项目的定义。</span></td>
              </tr>
            </table>
            <table width="100%" height="267" border="0" cellpadding="5" cellspacing="5">
              <tr>
                <td width="16%" height="48" rowspan="2" align="right" nowrap="nowrap" class="text">
                    项目模式设置：</td>
                <td width="84%">
                    &nbsp;<asp:CheckBox ID="CheckBoxA" runat="server" Checked="True" Text="简单(不选)/全能(选择)" />
                </td>
              </tr>
              <tr>
                <td><asp:RadioButtonList ID="RadioButtonListX" runat="server" 
                        RepeatDirection="Horizontal">
                  <asp:ListItem Value="0" Selected="True">多选投票</asp:ListItem>
                  <asp:ListItem Value="1">单选投票</asp:ListItem>
                </asp:RadioButtonList></td>
              </tr>
              <tr>
                <td height="47" align="right" nowrap="nowrap" class="text">项目组名称：</td>
                <td><asp:TextBox ID="group_name" runat="server" 
                CssClass="input" Height="18px" Width="280px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                          ControlToValidate="group_name" Display="Dynamic" 
                          ErrorMessage="请填写项目组名称" validationgroup="03"></asp:RequiredFieldValidator></td>
              </tr>
              <tr>
                <td height="47" align="right" class="text">项目组描述：</td>
                <td><asp:TextBox ID="group_content" runat="server" CssClass="input" Height="79px" 
                Width="280px" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                          ControlToValidate="group_content" Display="Dynamic" 
                          ErrorMessage="请填写项目组描述" validationgroup="03"></asp:RequiredFieldValidator></td>
              </tr>
              <tr>
                <td height="47" align="right" class="text">&nbsp;</td>
                <td><asp:Button ID="Button3" runat="server" Text="确认添加项目组" CssClass="bt" 
                Height="27px" Width="103px" OnClick="Button3_Click" validationgroup="03" /></td>
              </tr>
            </table>
            <br />
          </div>
          <div class="TabbedPanelsContent">
            <table width="100%" border="0" cellspacing="5" cellpadding="5">
              <tr>
                <td height="47"><span class="huise">项目添加帮助：项目的添加分 
                    形象图片，项目名称，项目描述，项目的链接地址，可以在发布时根据自己的需要来理解项目的定义。</span></td>
              </tr>
            </table>
            <asp:Panel ID="Panel_edit_group" runat="server" Visible="false">
              <div class="xm_list">
                <table width="100%" border="0" cellspacing="2" cellpadding="2">
                  <tr>
                    <td width="14%" align="right" class="text">项目组名称：</td>
                    <td width="86%"><asp:TextBox ID="edit_group_name" runat="server" CssClass="input" Height="18px" Width="260px"></asp:TextBox></td>
                  </tr>
                  <tr>
                    <td align="right" class="text">项目组描述：</td>
                    <td><asp:TextBox ID="edit_group_content" runat="server" Height="81px" TextMode="MultiLine"  Width="260px" CssClass="input"></asp:TextBox></td>
                  </tr>
                  <tr>
                    <td align="right" class="text">&nbsp;</td>
                    <td><asp:Button ID="Button_edit_group" runat="server" Text="确认编辑" OnClick="Button_edit_group_Click"  CssClass="bt" Width="65px"/></td>
                  </tr>
                </table>
              </div>
            </asp:Panel>
            <asp:Repeater ID="Repeater_group" runat="server">
              <ItemTemplate>
                <div class="xm_list"><%#Eval("id")%> --项目组名称：[ <%#Eval("group_name") %> ] ----
                  <a href='?id=<%#Eval("id")%>&t=group_del' onClick="return window.confirm('确定删除吗?');"  >
                    删除</a>
                    | 
                  <a href='?id=<%#Eval("id")%>&t=group_edit' > 编辑</a>
                    | 
                  <a href='default.aspx?group=<%#Eval("id")%>' > 查看</a>
                </div>
              </ItemTemplate>
            </asp:Repeater>
          </div>
          <div class="TabbedPanelsContent">
            <!---->
            <table width="100%" border="0" cellspacing="5" cellpadding="5">
              <tr>
                <td height="47"><span class="huise">项目添加帮助：项目的添加分 
                    形象图片，项目名称，项目描述，项目的链接地址，可以在发布时根据自己的需要来理解项目的定义。</span></td>
              </tr>
            </table>
            <asp:Repeater ID="Repeater_tu" runat="server">
              <ItemTemplate>
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td width="12%" align="right" nowrap="nowrap" class="text"><a href='<%#Eval("link_url").ToString().Trim() %>' target="_blank">
                        <span class="text"><%#Eval("names").ToString().Trim() %>：</span>
                      </a>
                    </td>
                    <td><div class="barbg">
                        <div class="l"><img src='SpryAssets/img/b<%# Container.ItemIndex>=10?Container.ItemIndex-10:Container.ItemIndex%>_l.gif' /></div>
                        <div style='WIDTH: <%# ny(Convert.ToInt32(Eval("ballot")ToString()))%>; background-image: url(SpryAssets/img/b<%# Container.ItemIndex>=10?Container.ItemIndex-10:Container.ItemIndex%>.gif);  line-height: 20px;' class="l">
                            &nbsp;</div>
                        <div class="l"><img src='SpryAssets/img/b<%# Container.ItemIndex>=10?Container.ItemIndex-10:Container.ItemIndex%>_r.gif' /></div>
                      </div></td>
                    <td width="20%" align="left" nowrap="nowrap" class="text"><b>票数：<%#Eval("ballot") %> 
                        || <%# ny(Convert.ToInt32(Eval("ballot")))%></b></td>
                  </tr>
                </table>
              </ItemTemplate>
            </asp:Repeater>
            
            
            
      <!--      
            
       <asp:Repeater ID="Repeater_tu_s" runat="server">
       <HeaderTemplate>
       <table width="7%" border="0" cellpadding="10" cellspacing="0">
                            <tr>
       </HeaderTemplate>
              <ItemTemplate>
                           <td>
                            
                              
                              <table width="22" height="200" border="0" cellpadding="0" cellspacing="0" bgcolor="#EFEFEF">
                            <tr>
                              <td valign="bottom">
                              <table width="100%" height='<%# (ny((Convert.ToInt32(Eval("ballot"))*2)).Replace("%","")) %>' border="0" cellpadding="0" cellspacing="0" bgcolor="#F7CA9B">
                            <tr>
                              <td>&nbsp;</td>
                              </tr>
                          </table></td>
                              </tr>
                          </table>
                          
                             
                              </td>
              </ItemTemplate>
              <FooterTemplate>
              
            </tr>
                          </table>
              </FooterTemplate>
            </asp:Repeater>      
            
-->
            
          </div>
          <div class="TabbedPanelsContent">
            <p>
                &nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>评论/留言 管理</asp:ListItem>
                    <asp:ListItem>查看当前组</asp:ListItem>
                    <asp:ListItem>查看所有组</asp:ListItem>
                </asp:DropDownList>
            <asp:Repeater ID="Repeater_user_remark" runat="server">
              <ItemTemplate>
                <div class="xm_list"> 
                标题/名称: [<%#Eval("pl_title").ToString().Trim() %>] || 
                电话: [<%#Eval("tel").ToString().Trim() %>] || 
                card:[<%#Eval("card").ToString().Trim() %>] || 
                
                    内容: [<%#Eval("pl_content").ToString().Trim() %>] ------
                  <a href='?t=remark_del&amp;id=<%#Eval("id")%>'  onClick="return window.confirm('确定删除吗?');">删除</a>
                </div>
              </ItemTemplate>
            </asp:Repeater>
       
           <asp:Repeater ID="Repeater_baoming" runat="server">
              <ItemTemplate>
                <div class="xm_list"> 
                  <br />
                    <%#Eval("contents").ToString().Trim() %> ---
                  <a href='?t=baoming_del&amp;id=<%#Eval("id")%>'  onClick="return window.confirm('确定删除吗?');">删除</a>
                </div>
              </ItemTemplate>
            </asp:Repeater>
       
                <p>
                </p>
       
            </p>
          </div>
        </div>
  </div>
  </td>
  </tr>
  </table>
  <table width="100%" height="60" border="0" cellpadding="2" cellspacing="0" bgcolor="#DFE8F7">
    <tr>
      <td height="36" bgcolor="#FFFFFF">&nbsp;</td>
    </tr>
    <tr>
      <td align="center" nowrap="nowrap" class="huise">
      <% ROYcms.Common.XmlControl Config = new ROYcms.Common.XmlControl(Server.MapPath(ConfigPath));

         Response.Write(Config.GetText("//copyright")); %>
         </td>
    </tr>
  </table>
  <script type="text/javascript">
<!--
var TabbedPanels1 = new Spry.Widget.TabbedPanels("TabbedPanels1");
//-->
</script>
  </asp:Panel>
  <!--项目列表-->
  <asp:Panel ID="Panel_tu" runat="server">
    <asp:Repeater ID="Repeater_user_z" runat="server">
      <ItemTemplate>
        <center>
          <div class="text" id="logo"> 活动：<%#Eval("group_name") %>
          </div>
          <div class="text" id="content"> 描述：<%#Eval("group_content") %>
          </div>
        </center>
      </ItemTemplate>
    </asp:Repeater>
    <asp:Repeater ID="Repeater_user_tu" runat="server">
      <ItemTemplate>
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="12%" align="right" nowrap="nowrap" class="text"><a href='<%#Eval("link_url").ToString().Trim() %>' target="_blank">
                <span class="text"><%#Eval("names").ToString().Trim() %>：</span>
              </a>
            </td>
            <td><div class="barbg">
                <div class="l"><img src='SpryAssets/img/b<%# (Container.ItemIndex+1).ToString().Substring(0,1)%>_l.gif' /></div>
                <div style='WIDTH: <%# ny(Convert.ToInt32(Eval("ballot")))%>; background-image: url(SpryAssets/img/b<%# (Container.ItemIndex+1).ToString().Substring(0,1)%>.gif);  line-height: 20px;' class="l" id='bg<%# (Container.ItemIndex+1).ToString()%>' >
                    &nbsp;</div>
                <div class="l"><img src='SpryAssets/img/b<%# (Container.ItemIndex+1).ToString().Substring(0,1)%>_r.gif' /></div>
              </div></td>
            <td width="20%" align="left" nowrap="nowrap" class="text"><b>票数：<%#Eval("ballot") %> 
                || <%# ny(Convert.ToInt32(Eval("ballot")))%></b></td>
          </tr>
        </table>
      </ItemTemplate>
    </asp:Repeater>
   
</asp:Panel> 
    
    <asp:Panel ID="Panel_administrator" runat="server" Visible="false">
    <center class="link">
      <hr />
      <asp:TextBox ID="password" runat="server" CssClass="input" TextMode="Password"></asp:TextBox>
      <asp:LinkButton ID="LinkButton_password" runat="server" onclick="LinkButton_password_Click" CssClass="link" Height="18px">管理</asp:LinkButton>
    </center>
    </asp:Panel>
</form>
</body>
</html>
