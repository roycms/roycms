<%@ Page Language="C#" AutoEventWireup="True" Inherits="ROYcms.UI.Admin.Administrator.config.AdminPassword" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>

<!DOCTYPE HTML>
<html>
<head runat="server">
<title></title>
</head>

<body>
<form id="form1" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <div style="margin-bottom:5px;margin-top:5px; display:table; width:100%;" > 
	<table width="100%" border="0" class="tiao_top" >
        <tr>
        <td width="77%" nowrap><div class="tiao_con">
        <a  href='edit_AdminUser.aspx' rel="facebox"  title="添加用户" target="_blank"><img align="absmiddle" src="/administrator/images/nv6.png" />添加管理员</a> 
        <a href="/Administrator/config/AdminPassword.aspx"><img align="absmiddle" src="/administrator/images/rosette.png" />系统账户</a>
        <a href="/administrator/log/index.aspx "><img align="absmiddle" src="/administrator/images/rosette.png" />系统日志</a>
        <a href="/administrator/_center.aspx"><img align="absmiddle" src="/administrator/images/nv6.png" />系统状态</a> 
        <a rel="facebox" title="DLL版本信息" href="/administrator/config/dll.aspx"><img align="absmiddle" src="/administrator/images/nv8.png" />DLL版本信息</a> 
        <a rel="facebox" title="缓存管理" href="/administrator/config/Caching.aspx"><img align="absmiddle" src="/administrator/images/nv9.png" />缓存管理</a> 
        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
        </tr>
      </table>
            <asp:Repeater ID="Repeater_admin" runat="server">
            <HeaderTemplate>
              <table border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
                <tr id="tiao_center">
                  <td width="23" nowrap><input id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></td>
                  <td width="28" nowrap><span class="line">编号</span></td>
                  <td nowrap><span class="line">管理员名称</span></td>
                  <td nowrap><span class="line">密码</span></td>
                  <td nowrap><span class="line">权限标识</span></td>
                  <td width="100"></td>
                </tr>
            </HeaderTemplate>
              <ItemTemplate>
                <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
                  <td nowrap><asp:CheckBox ID="ID_list" runat="server" /></td>
                  <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("id") %>'></asp:Label></td>
                  <td nowrap="nowrap"><%#Eval("name")%></td>
                  <td nowrap="nowrap"><%#Eval("password")%></td>
                  <td nowrap><%# Eval("rol").ToString()=="0"?"超级管理员":(Eval("rol").ToString()=="1"?"信息管理员":"审稿员") %></td>
                  <td nowrap  align="center"> 
                  <a href='Edit_AdminUser.aspx?id=<%#Eval("id")%>&n=<%=DateTime.Now.ToString()%>' rel="facebox" title='变更<%#Eval("name")%>的登录信息'>便捷设置</a> | 
                  <a href='AdminUserConfig.aspx?id=<%#Eval("id")%>&n=<%=DateTime.Now.ToString()%>'>设置</a> | 
                       <a href='AdminRol.aspx?Id=<%#Eval("id")%>&ClassId=<%#Eval("id")%>&ClassKind=<%#Eval("ClassKind")%>&n=<%=DateTime.Now.ToString()%>'>权限</a> | 
                  <a href='#del<%#Eval("id")%>' rel="facebox" title='确实要删除管理员 [<%#Eval("name")%>] 吗?'>删除 </a>
                  </td>
                  <div id="del<%#Eval("id")%>" style="display:none; width:260px;">
                   
                  <a href="?del=<%#Eval("id")%>" class="btnSearch" style="padding:3px;">删除</a> 
                  <a href="?" class="btnSearch" style="padding:3px;">取消</a>  
                  </div>
                </tr>
              </ItemTemplate>
                          <FooterTemplate>
              <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"7\">暂无记录</td></tr>" : ""%>

                  <TR>
                      <TD bgColor=#E2F1FC colSpan=7><input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
                        <img src="/administrator/images/cms-ico12.gif" border="0">
                        <asp:ImageButton ID="ImageButton_all_del" runat="server" ImageUrl="/administrator/images/cms-ico10.gif"  style="width: 63px" OnClientClick="return window.confirm('确定删除多条记录吗?');"  />
                       
                        <span style="float:right">显示 <asp:TextBox ID="PageSize" OnTextChanged="PageSizeTextChanged" AutoPostBack="True" Text=<%#Application["PageSize"] %> runat="server" Width="30px" CssClass="txtInput"></asp:TextBox>条/页</span>
                          <center>
                          <Script Language="JavaScript" type="text/JavaScript" src="/Administrator/js/page.js"></Script> 
                              <script language="JavaScript">
						                    <!--
						                    var pg = new showPages('pg');
						                    pg.pageCount =<% =ViewState["PageCon"] %>;  // 定义总页数(必要)
						                    pg.argName = 'page';  // 定义参数名(可选,默认为page)
						                    //document.write('<br>Show Times: ' + pg.showTimes + ', Mood 1');
						                    pg.printHtml(1);
						                    //
						                    -->
                              </script> 
          
                           </center> 
                        
                        <div> 结果总共<% =ViewState["PageContent"]%>条数据</div> 
                        </TD>
                    </TR>
                  </TBODY>
                </TABLE>
            </FooterTemplate>
            </asp:Repeater>

          
  </div>
</form>
</body>
</html>
