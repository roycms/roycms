<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Go.Insert" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title></title>
</head>
<body>
<form id="InsertObjetForm" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <div id="rotate"> 
    <!--工具栏开始-->
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con"> 
        <a href='/administrator/go/admin_objet.aspx'><img align="absmiddle" src="/administrator/images/nv9.png" />返回模块管理</a> </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
    <!--工具栏结束-->
    <div class="tagMenu">
      <ul class="menu1">
        <li>模块基本信息设置</li>
        <li>模块数据模型设置</li>
       
      </ul>
    </div>
    <div class="content1" style="padding:0px; margin-top:3px;">
      <div class="layout">
      <table   cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
      <tr>
        <td width="111" align="right" bgcolor="#F4FBFF"><strong>标识</strong></td>
        <td width="1020" bgcolor="#F4FBFF">
        <input name="id"  type="hidden" id="id" value='<%=Model.id %>' >
        <input name="ClassKind" type="text" class="txtInput" id="ClassKind" value='<%= ROYcms.Common.Request.GetQueryInt("id") != 0?Model.ClassKind.ToString():ROYcms.Common.StringPlus.GetRamTimeCode() %>' size="10" readonly="readonly"  style="background-color:#F3F3F3" >
        不允许修改 <a rel="Help" class="SysHelp" href="#ClassKind">?</a></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>标题</strong></td>
        <td bgcolor="#F4FBFF">
        <input name="Title" type="text" class="txtInput" id="Title" value='<%=Model.Title %>' size="40" >
        </td>
      </tr>
           <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>模块显示状态</strong></td>
        <td bgcolor="#F4FBFF">
<input name="VisibleVal" id="VisibleVal" type="hidden" value='<%=Model.Visible%>' >
          <select name="Visible" id="Visible" class="select" style="width:80px;">
            <option value="1">可见</option>
            <option value="0">隐藏</option>
        </select>
          站群备用(可默认)<a rel="Help" class="SysHelp" href="#ClassKind">?</a></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>权限状态</strong></td>
        <td bgcolor="#F4FBFF"><input name="RoleVal" id="RoleVal" type="hidden" value='<%=Model.Role%>' >
          <select name="Role" id="Role" class="select" style="width:150px;">
            <option value="0">默认权限</option>
            <option value="1">站群可见</option>
            <option value="2">子站可见</option>
        </select><a rel="Help" class="SysHelp" href="#ClassKind">?</a> 
          <a href="#Set_Role" title="设置权限标识" rel=facebox>设置</a></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>图标</strong></td>
        <td bgcolor="#F4FBFF">
        <input name="logo" type="text" id="logo" value='<%=Model.logo%>' size="40" class="txtInput" >
        <table width="147" border="0" cellpadding="1" cellspacing="1" id="add_objet_set_logo">
          <tr>
            <td><a href="javascript:"><img src="/Administrator/images/nv1.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv2.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv3.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv4.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv5.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv6.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv7.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv8.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv9.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv10.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv11.png"></a></td>
            <td><a href="javascript:"><img src="/Administrator/images/nv12.png"></a></td>
          </tr>
      </table></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>配置文件地址</strong></td>
        <td bgcolor="#F4FBFF"><input name="AppendixConfig" type="text" class="txtInput" id="AppendixConfig" value='<%=Model.AppendixConfig%>' size="40" >
        <a rel="Help" class="SysHelp" href="#ClassKind">?</a> 
        <a rel=facebox href="#Set_AppendixConfig" title="选择和设置配置文件地址">选择</a></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>附件地址</strong></td>
        <td bgcolor="#F4FBFF"><input name="AppendixPath" type="text" class="txtInput" id="AppendixPath" value='<%=Model.AppendixPath%>' size="40" >
        <a rel="Help" class="SysHelp" href="#ClassKind">?</a> 
         <a rel=facebox href="#Set_AppendixPath" title="选择和设置附件地址">选择</a></td>
      </tr>

       <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>描述</strong></td>
        <td bgcolor="#F4FBFF"><textarea name="zhaiyao" cols="40" rows="3" id="zhaiyao" ><%=Model.zhaiyao%></textarea></td>
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

         <div style="margin-left:150px; margin-top:10px;">  
        <input type="button" name="InsertObjetBT" id="InsertObjetBT" value="确认提交"  class="btnSubmit" />
        <input type="reset" name="button2" id="button2" value="重置" class="btnSubmit" />
      </div>


      </div>
      <div class="layout">

      <div class="Tools2">
         <a class="btnSearch" href="/administrator/model/adminmodel.aspx" style=" padding:4px;">管理数据模型</a>
         <a>当模块数据扩展模型：
          <%if (ROYcms.Common.Request.GetQueryInt("id") != 0)
            {
                string ModelName = null;
                string Modelid = new ROYcms.Sys.BLL.ROYcms_Class_Model().CidGetP("Mid", "Cid=" + Request["Id"]);
                if (Modelid != null)
                {
                    ModelName = new ROYcms.Sys.BLL.ROYcms_Model().GetModel(Convert.ToInt32(Modelid)) == null ? "" : new ROYcms.Sys.BLL.ROYcms_Model().GetModel(Convert.ToInt32(Modelid)).Name;        
          %> 
          [<%=ModelName%>]
           <a href="javascript:" id='<%=Request["Id"]%>' class="Class_ModelDelBT btnSearch" style=" padding:4px;">取消关联</a>
          <%}
                else
                {%>无关联的扩展模型<%}
            }%>
          </a>
       </div>

           <asp:Repeater ID="Repeater_admin" runat="server">
            <HeaderTemplate>
            <table border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
            <tr id="tiao_center">
              <td width="38" nowrap><span class="line">编号</span></td>
              <td width="139" ><span class="line">自定义模型名称</span></td>
              <td width="139" ><span class="line">表格名称</span></td>
              <td width="322"><span class="line">自定义模型描述</span></td>
              <td width="139" ><span class="line">初始化状态</span></td>
              <td width="139" ><span class="line"></span></td>
            </tr>
            </HeaderTemplate>
              <ItemTemplate>
                <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
                  <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("Id") %>'></asp:Label></td>
                  <td nowrap="nowrap"><%#Eval("Name")%></td>
                  <td nowrap="nowrap"><%#Eval("TableName")%></td>
                  <td nowrap="nowrap"><%#Eval("ModelDescription")%></td>
                  <td nowrap="nowrap"><%# new ROYcms.Sys.BLL.CMS().Exists(Eval("TableName").ToString())==true?"成功":"未初始化"%></td>
                  <td>
                  <a href="javascript:" id='<%#Eval("Id")%>,<%=Request["Id"]%>' class="Class_ModelBT btnSearch" style=" padding:4px;">应用关联</a>
                  </td> 
                </tr>
              </ItemTemplate>
              <FooterTemplate>
                <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"6\">暂无记录</td></tr>" : ""%>
              </table>
              </FooterTemplate>
            </asp:Repeater>
      </div>
    
    </div> 

  </div>
</form>        
</body>
</html>

