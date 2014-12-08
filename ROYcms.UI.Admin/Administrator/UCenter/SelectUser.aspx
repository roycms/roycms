<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="SelectUser.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator_SelectUser" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html >
<head runat="server">
<title>用户信息编辑</title>
</head>
<body>
<form id="UserForm" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-bottom:0px; margin-top:5px;">
    <tr>
          <td width="15%" align="left" nowrap>
          <img src="/administrator/images/funnel.png" width="16" height="16" align="absmiddle">
          <asp:DropDownList ID="UGroup_DropDownList" runat="server" CssClass="select"  Width="110px" AutoPostBack="True"  onselectedindexchanged="UGroup_DropDownList_SelectedIndexChanged"></asp:DropDownList> 
          <asp:DropDownList ID="DdTime" runat="server" CssClass="select" Width="78px">
              <asp:ListItem Value="0">注册时间</asp:ListItem>
              <asp:ListItem Value="1">1天内注册</asp:ListItem>
              <asp:ListItem Value="2">2天内注册</asp:ListItem>
              <asp:ListItem Value="3">3天内注册</asp:ListItem>
              <asp:ListItem Value="3">更早注册</asp:ListItem>
          </asp:DropDownList>
          </td>
          <td width="60%" align="left" nowrap> </td>
          <td width="25%" align="right" nowrap><table border="0" cellpadding="0" cellspacing="0">
            <tr>
              
              <td nowrap><input name="keywords" id="keywords" type="text" class="txtInput" style="width:120px;height:21px" title="输入用户名进行搜索！" runat="server"></td>
              <td align="right" width="40"> 
                  <asp:Button ID="Submit" CssClass="btnSearch" runat="server" Text="搜索"  onclick="Submit_Click" /></td>
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
                  <TD width="28" nowrap="nowrap"><span class="line">编号</span></TD>
                  <TD nowrap="nowrap"><span class="line">登录名</span></TD>
                     <TD nowrap="nowrap"><span class="line">名称</span></TD>
                  <TD nowrap="nowrap"><span class="line">邮箱</span></TD>
                  <TD nowrap="nowrap"><span class="line">qq</span></TD>
                  <TD nowrap="nowrap"><span class="line">权限</span></TD>
                
                  <TD nowrap="nowrap"><span class="line">时间</span></TD>
                  <TD nowrap="nowrap"  width="100"></TD>
                </TR>
         </HeaderTemplate>
          <ItemTemplate>
            <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
              <td nowrap ><asp:CheckBox ID="ID_list" runat="server" /></td>
              <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("bh") %>'></asp:Label></td>
              <td><%#Eval("name")%></td>
                 <td><%#Eval("username")%></td>
              <td><%# Eval("email")%></td>
              <td nowrap="nowrap"><%#Eval("qq")%></td>
              <td nowrap="nowrap"><%#Eval("quanxian")%></td>
           
              <td nowrap="nowrap"><%#Eval("login_time")%></td>
              <td align="center" width="100" nowrap >
              
              <a  href='javascript:window.parent.SelectUser("<%#Eval("bh") %>","<%#Eval("username")%>")' class="btnSubmit" style="padding:0px;" >选择</a>
              
              </td>
            </tr>
          </ItemTemplate>
            <FooterTemplate>
              <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"11\">暂无记录</td></tr>" : ""%>

                  <TR>
                      <TD bgColor=#E2F1FC colSpan=11><input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
                     
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
  
</form>
</body>
</html>
