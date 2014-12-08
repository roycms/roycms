<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminRol.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Config.AdminRol" %>


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
        <li>管理员操作权限设置</li>
        <li>基于路径的权限设置</li>
      </ul>
    </div>
    <div class="content1" style="padding:0px; margin-top:3px;">


      <div class="layout">
      <h4>系统管理(超级管理员)(管理员)</h4>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A1"  Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />管理员添加</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A2" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />管理员管理</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A3" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />管理员删除</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A4" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />系统配置</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A5" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />模块管理</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A6" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />模块添加</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A7" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />模块删除</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A8" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />系统日志</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A9" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />静态生成</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A10" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />模型管理</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A11" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />文件管理</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A12" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />会员管理</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A13" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />工作组管理</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A14" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />工作流管理</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A15" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />会员等级管理</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A16" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />订单管理</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A17" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />消费记录管理</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A18" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />发票管理</div>
          <div style="float:left;margin:4px;"><asp:CheckBox ID="A19" Text="" Checked="true" runat="server" OnCheckedChanged="A_CheckedChanged" AutoPostBack="True" />支付记录管理</div>




            <h4 style=" clear:both"><br />频道管理(超级管理员)(管理员)</h4>


            <asp:Repeater ID="Repeater_Objet" runat="server">
                <ItemTemplate>

	              <a href="../iframe.aspx?width=640&amp;height=400&amp;url=/administrator/class/SelectIndex.aspx?Classkind=<%#Eval("ClassKind") %>&amp;AdminId=<% = Request["Id"] %>" title="设置允许管理访问的频道" rel="facebox">
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
