<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Group_admin.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.UCenter.Group_admin" %>
<%@ Register src="top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html >

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<head runat="server">
<style type="text/css">
	ul li{ list-style-type:none;}
	ul,li{ padding:0px; margin:0px;}
	.kan_img li{ height:20px; line-height:20px; }
	.kan_img li img{ margin-right:3px; margin-left:2px;}

</style>
<title></title>
</head>
<body>
<form id="form12" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
    
  <div style="margin-bottom:5px;margin-top:5px; display:table; width:100%;"  >
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con"><a href='addgroup.aspx' rel="facebox" title="添加用户组" target="_blank"><img align="absmiddle" src="/administrator/images/nv6.png" />添加用户组</a> 
        
   
        
        
        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>

            <asp:Repeater ID="Repeater_list" runat="server">
            <HeaderTemplate>
               <table border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb">
                <tr id="tiao_center">
                  <td width="23"  nowrap><input id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></td>
                  <td width="28" nowrap><span class="line">编号</span></td>
                  <td nowrap><span class="line">用户组名称</span></td>
                  <td nowrap>描述</td>
                  <td nowrap><span class="line">时间</span></td>
                  <td width="100" align="left" nowrap></td>
                </tr>
            </HeaderTemplate>
              <ItemTemplate>
                <tr  onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
                  <td nowrap><asp:CheckBox ID="ID_list" runat="server" /></td>
                  <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("id") %>'></asp:Label></td>
                  <td nowrap>
                    <a href="#zhaiyao<%#Eval("id") %>" title='<%# Eval("name") %>详情' rel='facebox'><%# Eval("name") %> [详情]</a>
                    <div id="zhaiyao<%#Eval("id") %>" style="display:none; width:260px;">
                    <h3><%# Eval("name") %></h3>
					<p><%# Eval("zhaiyao") %></p>
                    </div>
                    </td>
                  <td nowrap><%# Eval("zhaiyao") %></td>
                <td nowrap><%# Eval("time") %></td>
                  <td align="center" nowrap>
                    <a title="编辑用户组" href='group_edit.aspx?id=<%#Eval("id")%>&n=<%#Eval("id")%>'  rel='facebox'>编辑</a>
                    | <a href='#del<%#Eval("id") %>' rel='facebox' title='确实要删除【<%#Eval("name")%>】吗？' >删除</a>
                    | <a title="用户组配置信息" href="UGroupConfig.aspx?UGroup_id=<%#Eval("id")%>&UGroup_name=<%#Server.UrlEncode(Eval("name").ToString())%>&n=<%=DateTime.Now.ToString()%>" rel='facebox'>配置</a>
                     <div id="del<%#Eval("id") %>" style="display:none; width:260px;">
                        <p><asp:CheckBox ID="CheckBox_allUser" Text="同时删除组的所有用户" runat="server" /></p> 
                        <p style="color:Red; margin-bottom:5px;">注意：勾选同时删除组的所有用户后将同步删除。</p>
                        <p><a href='?del=<%#Eval("id")%>'  class="btnSearch" style="padding:3px;">删除</a>
                        <a href='?' class="btnSearch" style="padding:3px;">取消</a></p> 
                    </div>
                   </td>
                </tr>
              </ItemTemplate>
              <FooterTemplate>
                 <%#Repeater_list.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"7\">暂无记录</td></tr>" : ""%>
                 <tr>
                    <td height="25" colspan="7" bgcolor="#F4FBFF">  
                    <input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
                    <img src="/administrator/images/cms-ico12.gif" border="0">
                    <asp:ImageButton ID="ImageButton_all_del" runat="server" ImageUrl="/administrator/images/cms-ico10.gif"  style="width: 63px" OnClientClick="return window.confirm('确定删除多条记录吗?');"  />      
                   <span style="float:right">显示 <asp:TextBox ID="PageSize" OnTextChanged="PageSizeTextChanged" AutoPostBack="True" Text=<%#Application["PageSize"] %> runat="server" Width="30px" CssClass="txtInput"></asp:TextBox>条/页</span>
                        <center>
                          <Script Language="JavaScript" type="text/JavaScript" src="/administrator/js/page.js"></Script>
                          <script language="JavaScript">
                            <!--
                            var pg = new showPages('pg');
                            pg.pageCount =1;  // 定义总页数(必要)
                            pg.argName = 'page';  // 定义参数名(可选,默认为page)
                            //document.write('<br>Show Times: ' + pg.showTimes + ', Mood 1');
                            pg.printHtml(1);
                            //-->
                           </script>
                        </center>
                        <div> 结果总共<% =ViewState["PageContent"]%>条数据</div> 
                        </td>
                    </tr>
                  </table>
              </FooterTemplate>
            </asp:Repeater>

  </div>
</form>
</body>
</html>
