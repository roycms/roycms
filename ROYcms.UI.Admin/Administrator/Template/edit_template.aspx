<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator_template_edit_template" ValidateRequest="false"  Codebehind="edit_template.aspx.cs" %>

<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>

<html>
<head runat="server">
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
    <title></title>
</head>
<style type="text/css">
<!--
#GridView1 {
	font-size: 13px;
}
#GridView1 td,th{
padding:5px;
padding-left:15px;
}
-->
</style>
<body>
    <form id="form1" runat="server">
    <Resources:Resources ID="Resources1" runat="server" />
    
    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="10">
      <tr>
        <td><fieldset>
        <legend><img name="" src="/administrator/images/bullet_wrench.png" width="16" height="16" alt="">&nbsp;&nbsp;模板管理</legend>
        
    
                      <table width="100%" border="0" cellspacing="5" cellpadding="0">
                        <tr>
                          <td height="74"><table width="98%" border="0" align="center">
                        <tr>
                                  <td>切换模板方案 
                                    <asp:DropDownList ID="template_f" runat="server" AutoPostBack="True" 
                                          onselectedindexchanged="template_f_SelectedIndexChanged" CssClass="input" > </asp:DropDownList> 
                                    &nbsp;当前方案
                                    
                                     【<font color=red><%Response.Write(Session["template_z_name"]); %></font>】
                                    文件夹：【<font color=red><%Response.Write(Session["template_z_path"]); %></font>】
                                    绑定地址：【<font color=red><%Response.Write(Session["template_z_url"]); %></font>】
                                    </td>
                                </tr>
                              </table>
                              <br>
                            <table width="98%" height="131" border="0" align="center" cellpadding="5" cellspacing="1" bgcolor="#CCCCCC">
             <tr>
                                   <td width="123" height="25" bgcolor="#DDE9FF">模板名称</td>
                                   <td width="432" bgcolor="#DDE9FF">描述</td>
                                   <td width="93" bgcolor="#DDE9FF">模板类型</td>
                                   <td width="181" bgcolor="#DDE9FF">模板路径</td>
                                   <td width="127" bgcolor="#DDE9FF">访问路径</td>
                                   <td width="38" bgcolor="#DDE9FF">&nbsp;</td>
                                   <td width="35" bgcolor="#DDE9FF">&nbsp;</td>
                                 </tr>
                                 <tr>
                                   <td height="25" bgcolor="#F4FBFF">主页模板</td>
                                   <td bgcolor="#F4FBFF">资讯主页模板(默认模板)</td>
                                   <td bgcolor="#F4FBFF">default</td>
                                   <td bgcolor="#F4FBFF">
            <a href='../../templet/<%Response.Write(Session["template_z_path"]); %>/Default.html' target="_blank">~/templet/<%Response.Write(Session["template_z_path"]); %>/Default.html</a></td>
                                   <td bgcolor="#F4FBFF"><img src="/administrator/images/page_white_go.png" alt="" name="" width="16" height="16" border="0">&nbsp;<a href="../../<%Response.Write(Session["template_z_path"]=="default"?null:Session["template_z_path"]+"/"); %>Articls.aspx" target="_blank"><%Response.Write(Session["template_z_path"]=="default"?null:Session["template_z_path"]+"/"); %>Articls.aspx</a>
                                   </td>
                                   <td bgcolor="#F4FBFF"><a href ='edit.aspx?type=default'>编辑</a></td>
                                   <td bgcolor="#F4FBFF">&nbsp;</td>
                                 </tr>
                                 <tr>
                                   <td height="25" bgcolor="#F4FBFF">列表页模板</td>
                                   <td bgcolor="#F4FBFF">资讯列表模板(默认模板)</td>
                                   <td bgcolor="#F4FBFF">list</td>
                                   <td bgcolor="#F4FBFF"><a href='../../templet/<%Response.Write(Session["template_z_path"]); %>/list.html' target="_blank">~/templet/<%Response.Write(Session["template_z_path"]); %>/list.html</a></td>
                                   <td bgcolor="#F4FBFF"><img src="/administrator/images/page_white_go.png" alt="" name="" width="16" height="16" border="0"><a href='../../<%Response.Write(Session["template_z_path"]=="default"?null:Session["template_z_path"]+"/"); %>list.aspx' target="_blank">
                                   
                                   
                                   <%Response.Write(Session["template_z_path"]=="default"?null:Session["template_z_path"]+"/"); %>list.aspx</a></td>
                                   <td bgcolor="#F4FBFF"><a href ='edit.aspx?type=list'>编辑</a></td>
                                   <td bgcolor="#F4FBFF">&nbsp;</td>
                                 </tr>
                                 <tr>
                                   <td height="25" bgcolor="#F4FBFF">子页模板</td>
                                   <td bgcolor="#F4FBFF">资讯子页模板(默认模板)</td>
                                   <td bgcolor="#F4FBFF">show</td>
                                   <td bgcolor="#F4FBFF"><a href='../../templet/<%Response.Write(Session["template_z_path"]); %>/show.html' target="_blank">~/templet/<%Response.Write(Session["template_z_path"]); %>/show.html</a></td>
                                   <td bgcolor="#F4FBFF"><img src="/administrator/images/page_white_go.png" alt="" name="" width="16" height="16" border="0"><a href='../../<%Response.Write(Session["template_z_path"]=="default"?null:Session["template_z_path"]+"/"); %>show-1.aspx' target="_blank">
                                   
                                   <%Response.Write(Session["template_z_path"]=="default"?null:Session["template_z_path"]+"/"); %>show.aspx</a></td>
                                   <td bgcolor="#F4FBFF"><a href ='edit.aspx?type=show'>编辑</a></td>
                                   <td bgcolor="#F4FBFF">&nbsp;</td>
                                 </tr>
                                 
                                 
                                 
                                  <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
       
  <tr>
    <td  height="25" bgcolor="#F4FBFF"><img name="" src="/administrator/images/plus-.gif" width="6" height="5" alt=""> <%#Eval("name").ToString().Trim()%></td>
    <td bgcolor="#F4FBFF"><%#Eval("tag").ToString().Trim() %></td>
    <td bgcolor="#F4FBFF"><%# Eval("class_name").ToString().Trim()%></td>
    <td bgcolor="#F4FBFF"  nowrap >
    <a href='../../templet/<%Response.Write(Session["template_z_path"]); %>/<%# Eval("class_name").ToString().Trim() %><%# Eval("bh") %>.html'
     target=_blank>
    ~/templet/<%Response.Write(Session["template_z_path"]); %>/<%# Eval("class_name").ToString().Trim() %><%# Eval("bh") %>.html    </a>    </td>
    <td bgcolor="#F4FBFF" nowrap >
    
        <img src="/administrator/images/page_white_go.png" alt="" name="" width="16" height="16" border="0">
        <a href='../../<%Response.Write(Session["template_z_path"]=="default"?null:Session["template_z_path"]+"/"); %><%# Eval("class_name").ToString().Trim()%><%# Eval("bh") %>.aspx' target=_blank>
		<%Response.Write(Session["template_z_path"]=="default"?null:Session["template_z_path"]+"/"); %><%# Eval("class_name").ToString().Trim()%><%# Eval("bh") %>.aspx    </a> 
        
        </td>
    <td bgcolor="#F4FBFF">
    <a href ='edit.aspx?id=<%#Eval("bh") %>&type=<%#Eval("class_name").ToString().Trim() %>&z_id=<%#Eval("z_id").ToString().Trim() %>'>编辑</a></td>
    <td bgcolor="#F4FBFF"> <a href ='?id=<%#Eval("bh") %>&type=<%#Eval("class_name").ToString().Trim() %>&z_id=<%#Eval("z_id").ToString().Trim() %>&del=del' onClick="return window.confirm('确定删除吗?');">删除</a></td>
  </tr>
        </ItemTemplate>
        </asp:Repeater>
                                 
                          </table>
                          <br></td>
                        </tr>
                      </table>
        </fieldset>        </td>
      </tr>
    </table>
<div></div>
</form>
</body>
</html>
