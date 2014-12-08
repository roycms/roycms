<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminUserConfig.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Config.AdminUserConfig" %>

<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title></title>
</head>
<body>
<form id="Edit_AdminUserForm" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <div id="rotate"> 
    <!--工具栏开始-->
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con"> 
        <a href=' /Administrator/config/AdminPassword.aspx'><img align="absmiddle" src="/administrator/images/nv9.png" />返回会员管理</a> </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
    <!--工具栏结束-->
    <div class="tagMenu">
      <ul class="menu1">
        <li>管理员基本信息设置</li>
        <li>管理员操作权限设置</li>
        <li>基于路径的权限设置</li>
      </ul>
    </div>
    <div class="content1" style="padding:0px; margin-top:3px;">
      <div class="layout">
        <table  cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
      <tr>
        <td width="10%" height="25" align="right" bgcolor="#F4FBFF"><strong>登录名：</strong></td>
        <td width="90%" height="25" align="left" bgcolor="#F4FBFF">
        <input name="id"  type="hidden" id="id" value='<%=Model.id %>' >
        <input name="name" type="text" class="txtInput" id="name" value='<%=Model.name %>' size="30">
          <a rel="Help" class="SysHelp" href="#ClassKind">?</a></td>
      </tr>
      <tr>
        <td height="25" align="right" bgcolor="#F4FBFF"><strong>密码：</strong></td>
        <td height="25" align="left" bgcolor="#F4FBFF"><input name="password" type="password"  class="txtInput" id="password" value='<%=Model.password%>' size="30"></td>
      </tr>
      <tr>
        <td width="10%" height="25" align="right" bgcolor="#F4FBFF"><strong>再次输入密码：</strong></td>
        <td width="90%" height="25" align="left" bgcolor="#F4FBFF">
        <input name="password2" type="password"  class="txtInput" id="password2" value='<%=Model.password%>' size="30">
        </td>
      </tr>
      <tr>
        <td width="10%" height="25" align="right" bgcolor="#F4FBFF"><strong> 全局标识：</strong></td>
        <td width="90%" height="25" align="left" bgcolor="#F4FBFF"><input name="classkind" type="text" id="classkind" size="15" value='1'  class="txtInput">
          <a rel="Help" class="SysHelp" href="#ClassKind">?</a> <a href="#Set_classkind" title="设置全局标识" rel=facebox>选择</a></td>
      </tr>
      <tr>
        <td height="25" align="right" bgcolor="#F4FBFF"><strong>权限标识：</strong></td>
        <td height="25" align="left" bgcolor="#F4FBFF">
        <input name="RolVal" id="RolVal" type="hidden" value='<%=Model.Rol %>'  class="txtInput">
        <select name="Rol" id="Rol" class="select" style="width:150px;">
             <option value="0">超级管理员(全权限)</option>
            <option value="1">管理员(部分管理权限)</option>
            <option value="2">新闻发布员(信息管理发布权限)</option>
            <option value="3">审稿员(信息审阅权限)</option>
            <option value="4">来宾用户(只读权限)</option>
          </select>
          <a rel="Help" class="SysHelp" href="#ClassKind">?</a> <a href="#Set_Role" title="设置权限标识" rel=facebox>设置</a>

        </td>
      </tr>
    </table>
  <!--设置权限标识-->
  <div id="Set_Role" style="display:none;width:320px;" >
    <textarea name="" cols="30" rows="3">超级管理员,0;信息管理员,1;审稿员,2</textarea>
    <input type="submit" name="Set_Role_Bt" id="Set_Role_Bt" value="提交">
  </div>
    <div id="Set_classkind" style="display:none;width:320px;" >
    暂无全局标识信息
    </div>
    </div>

      <div class="layout">
       系统管理(超级管理员)(管理员)<hr />
       <asp:CheckBox ID="A001" Text="管理员添加"  Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />
       <asp:CheckBox ID="A002" Text="管理员管理" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A003" Text="管理员删除" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A004" Text="系统配置" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A005" Text="模块管理" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A006" Text="模块添加" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A007" Text="模块删除" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A008" Text="系统日志" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A009" Text="静态生成" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A010" Text="模型管理" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A011" Text="文件管理" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A012" Text="会员管理" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A013" Text="工作组管理" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A014" Text="工作流管理" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A015" Text="会员等级管理" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A016" Text="订单管理" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A017" Text="消费记录管理" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A018" Text="发票管理" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
       <asp:CheckBox ID="A019" Text="支付记录管理" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" />
     频道管理(超级管理员)(管理员)<hr />


            <asp:Repeater ID="Repeater_Objet" runat="server">
                <ItemTemplate>

	<a href="../iframe.aspx?width=640&amp;height=400&amp;url=/administrator/class/SelectIndex.aspx?Classkind=<%#Eval("ClassKind") %>&AdminId=<%=Request["id"] %>" title="设置允许管理访问的频道" rel="facebox">
             <%#Eval("title") %>
	</a>
                </ItemTemplate>
        </asp:Repeater>



      </div>


      <div class="layout">
        <div class="Tools2">
            <a class="btnSearch" style=" padding:4px;">为管理员配置选择可操作的功能模块</a>  
            <a class="btnSearch" href="/Administrator/AdminMap/index.aspx"  style=" padding:4px;">注册和管理功能模块</a>  
       </div> 
       <asp:Repeater ID="Repeater_admin" runat="server">
            <HeaderTemplate>
            <table border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
            <tr id="tiao_center">
              <td width="23" nowrap><input id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></td>
              <td width="38" nowrap><span class="line">编号</span></td>
              <td width="139" ><span class="line">功能模块名称</span></td>
              <td width="139" ><span class="line">功能模块URL地址</span></td>
              <td width="322"><span class="line">功能模块描述</span></td>
            
            </tr>
            </HeaderTemplate>
              <ItemTemplate>
                <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
                  <td nowrap><asp:CheckBox ID="ID_list" runat="server" /></td>
                  <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("Id") %>'></asp:Label></td>
                  <td nowrap="nowrap"><%#Eval("Name")%></td>
                  <td nowrap="nowrap"><%#Eval("Path")%></td>
                  <td nowrap="nowrap"><%#Eval("Description")%></td>
                
                </tr>
              </ItemTemplate>
              <FooterTemplate>
               <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"5\">暂无记录</td></tr>" : ""%>
              </table>
              </FooterTemplate>
            </asp:Repeater>


      </div>
    
    </div> 
     <div style="margin-left:150px; margin-top:10px;">  
        <input type="button" name="Edit_AdminUserBT" id="Edit_AdminUserBT" value="确认提交"  class="btnSubmit" />
        <input type="reset" name="button2" id="button2" value="重置" class="btnSubmit" />
      </div>
  </div>
</form>        
</body>
</html>

