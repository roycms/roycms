<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASKAdmin.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Ask.ASKAdmin" %>

<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>商品管理</title>
</head>
<body>
   <form id="form1" runat="server">

          <Resources:Resources ID="Resources1" runat="server" />

          <div style="margin-right:5px;margin-bottom:5px;margin-top:5px; display:table; width:100%"  >
    <table width="100%" border="0" class="tiao_top">
      <tr>
       <td width="77%" nowrap><div class="tiao_con">
        <a href="?"><img align="absmiddle" src="/administrator/images/rosette.png" />会员等级管理</a>
     
        </div></td>
       <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>

               


           <table  border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb">
                   <asp:Repeater ID="Repeater_admin" runat="server">
                    <HeaderTemplate>
    <thead>
  <tr  id="tiao_center">
    <td>编号</td>
    <td>工单标题</td>
    <td>工单内容</td>
    <td>状态</td>
   <td>时间</td>
    <td>操作</td>
  </tr>
  </thead>
  <tbody>
  </HeaderTemplate>
                         <ItemTemplate>
  <tr>
    <td><%#Eval("Id")%></td>
    <td><%#Eval("Title")%></td>
    <td><%#Eval("Contents")%></td>
    <td><%#Eval("State")%></td>
      <td><%#Eval("CreateTime")%></td>
   
      <td>

           <a   href='askshow.aspx?id=<%#Eval("Id") %>' >
        
      处理

       </a>
     <a   href='#del<%#Eval("Id") %>' rel='facebox' title='确定删除 [<%#Eval("Title")%>] 吗?'>
        
      删除

       </a>
     <div id='del<%#Eval("Id") %>' style="display:none; width:260px;">
               <p style="color:Red; margin-bottom:5px;">注意：将级联删除相关信息。</p>
           <a  class="btnSearch" style="padding:3px;"  href='?id=<%# Eval("Id") %>&State=-1'>删除</a>
   
                  <a  href='?' class="btnSearch" style="padding:3px;">取消</a>
            </div>


    </td>
  </tr>
</ItemTemplate>
                       <FooterTemplate>
                             <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"6\">暂无记录</td></tr>" : ""%>
  </tbody>
                       </FooterTemplate>
                       </asp:Repeater>

</table>
    </div>
</form>
    </body>
    </html>
