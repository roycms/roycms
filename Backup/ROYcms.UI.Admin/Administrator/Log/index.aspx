<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="index.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator_log" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html>
<head runat="server">
<title>系统日志</title>
</head>
<body>
<form id="form1" runat="server">
<Resources:Resources ID="Resources1" runat="server" />
  <div style="margin-right:5px;margin-bottom:5px;margin-top:5px; display:table; width:100%"  >
    <table width="100%" border="0" class="tiao_top">
      <tr>
       <td width="77%" nowrap><div class="tiao_con">
        <a href="/Administrator/config/AdminPassword.aspx"><img align="absmiddle" src="/administrator/images/rosette.png" />系统账户</a>
        <a href="/administrator/log/index.aspx "><img align="absmiddle" src="/administrator/images/rosette.png" />系统日志</a>
        <a href="/administrator/_center.aspx"><img align="absmiddle" src="/administrator/images/nv6.png" />系统状态</a> 
        <a rel="facebox" title="DLL版本信息" href="/administrator/config/dll.aspx"><img align="absmiddle" src="/administrator/images/nv8.png" />DLL版本信息</a> 
        <a rel="facebox" title="缓存管理" href="/administrator/config/Caching.aspx"><img align="absmiddle" src="/administrator/images/nv9.png" />缓存管理</a> 
        </div></td>
       <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
        <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-bottom:0px; margin-top:5px;">
        <tr>
         <td width="15%" align="left" nowrap>
          <img src="/administrator/images/funnel.png" width="16" height="16" align="absmiddle">
              <asp:DropDownList ID="Type_DropDownList" runat="server"  onselectedindexchanged="Type_DropDownList_SelectedIndexChanged" AutoPostBack="True" CssClass="select">
                  <asp:ListItem Value="0">所有系统日志</asp:ListItem>
                  <asp:ListItem Value="1">管理员登录日志</asp:ListItem>
                  <asp:ListItem Value="2">普通会员登录日志</asp:ListItem>
                  <asp:ListItem Value="3">管理员操作日志</asp:ListItem>
                  <asp:ListItem Value="4">会员操作日志</asp:ListItem>
                  <asp:ListItem Value="5">系统错误日志</asp:ListItem>
              </asp:DropDownList>
          </td>
          <td width="60%" align="left" nowrap></td>
          <td width="25%" align="right" nowrap><table border="0" cellpadding="0" cellspacing="0">
            <tr>
              <td nowrap></td>
              <td nowrap><input name="keywords" id="keywords" type="text" class="txtInput" style="width:120px;height:21px" title="输入用户名进行搜索！" runat="server"></td>
              <td align="right" width="40"> 
              <asp:Button ID="Submit" CssClass="btnSearch" runat="server" Text="搜索" onclick="Submit_Click"  /></td>
            </tr>
          </table></td>
        </tr>
      </table>
    
  
        <asp:Repeater ID="Repeater_admin" runat="server">
        <HeaderTemplate>
            <TABLE border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
              <TBODY>
                <TR id="tiao_center">
                  <TD width=23 noWrap><input id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></TD>
                  <TD width="28" nowrap><span class="line">编号</span></TD>
                  <TD nowrap><span class="line">事件操作人</span></TD>
                  <TD><span class="line">事件</span></TD>
                  <TD><span class="line">内容</span></TD>
                  <TD><span class="line">IP地址</span></TD>
                  <TD><span class="line">发生时间</span></TD>
                </TR>
        </HeaderTemplate>
          <ItemTemplate>
            <tr  onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
              <td nowrap ><asp:CheckBox ID="ID_list" runat="server" /></td>
              <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("id") %>'></asp:Label></td>
              <td><%# GetEventPepole(Convert.ToString(Eval("Admin_id")), Convert.ToString(Eval("user_id")))%></td>
              <td><%#Eval("Event")%></td>
              <td><%#Eval("Content")%></td>
              <td><a rel="facebox" href='/app_api/AJAXIP.aspx?ip=<%#Eval("Ip")%>'><%#Eval("Ip")%></a></td>
              <td><%#Eval("Time")%></td>
            </tr>
          </ItemTemplate>
          <FooterTemplate>
          <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"7\">暂无记录</td></tr>" : ""%>
                    <TR>
                      <TD bgColor=#E2F1FC colSpan=7><input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
                        <img src="/administrator/images/cms-ico12.gif" border="0">
                        <asp:ImageButton ID="ImageButton_all_del" runat="server" ImageUrl="/administrator/images/cms-ico10.gif" onclick="ImageButton_all_del_Click"   style="width: 63px" OnClientClick="return window.confirm('确定删除多条记录吗?');"  />
                        <span style="float:right">显示 <asp:TextBox ID="PageSize" OnTextChanged="PageSizeTextChanged" AutoPostBack="True" Text=<%#Application["PageSize"] %> runat="server" Width="30px" CssClass="txtInput"></asp:TextBox>条/页</span>
                        <center>
                          <Script Language="JavaScript" type="text/JavaScript" src="/administrator/js/page.js"></Script>
                          <script language="JavaScript">
                            <!--
                              var pg = new showPages('pg');
                              pg.pageCount = <% =ViewState["PageCon"] %>;  // 定义总页数(必要)
                              pg.argName = 'page';  // 定义参数名(可选,默认为page)
                              //document.write('<br>Show Times: ' + pg.showTimes + ', Mood 1');
                              pg.printHtml(1);
                            //-->
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
