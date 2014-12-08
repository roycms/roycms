<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="user.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator_Enterprise_user" %>
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
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con">
        
        <a href="/ucenter/reg.aspx" title="添加用户" target="_blank"><img align="absmiddle" src="/administrator/images/nv6.png" />添加用户</a> 
        
        <a href="/administrator/ucenter/User.aspx"><img align="absmiddle" src="/administrator/images/nv8.png" />管理用户</a> 
        <a rel="facebox" title="用户统计报告" href='/administrator/ucenter/sum.aspx?date=<%= DateTime.Now.ToString() %>'><img align="absmiddle" src="/administrator/images/nv8.png" />用户统计报告</a> 
        <a rel="facebox" title="群发邮件" href='/administrator/ucenter/send_mail.aspx?date=<%= DateTime.Now.ToString() %>'><img align="absmiddle" src="/administrator/images/nv8.png" />群发邮件</a> 
        
      
        
        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
    
    
    
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
                  <TD nowrap="nowrap"><span class="line">邮箱</span></TD>
                  <TD nowrap="nowrap"><span class="line">qq</span></TD>
                  <TD nowrap="nowrap"><span class="line">权限</span></TD>
                  <TD nowrap="nowrap"><span class="line">IP地址</span></TD>
                  <TD nowrap="nowrap"><span class="line">密码</span></TD>
                  <TD nowrap="nowrap"><span class="line">时间</span></TD>
                  <TD nowrap="nowrap"  width="100"></TD>
                </TR>
         </HeaderTemplate>
          <ItemTemplate>
            <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
              <td nowrap ><asp:CheckBox ID="ID_list" runat="server" /></td>
              <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("bh") %>'></asp:Label></td>
              <td><a href="user_all.aspx?id=<%#Eval("bh") %>"><%#Eval("name")%></a></td>
              <td><a href="user_all.aspx?id=<%#Eval("bh") %>"><%# Eval("email")%></a></td>
              <td nowrap="nowrap"><%#Eval("qq")%></td>
              <td nowrap="nowrap"><%#Eval("quanxian")%></td>
              <td nowrap="nowrap"><a rel="facebox" title="IP详情" href='/app_api/ip.aspx?ip=<%#Eval("IP")%>'><%#Eval("IP")%></a></td>
              <td nowrap="nowrap">
              <a title="密码详情" rel="facebox" href='#password<%#Eval("bh") %>'>*****</a>
                  <div id="password<%#Eval("bh") %>" style="display:none; width:260px;">
                      <h4>当前密码是：<%#ROYcms.Common.DESEncrypt.Decrypt(Convert.ToString(Eval("password")))%></h4>
                  </div>
              </td>
              <td nowrap="nowrap"><%#Eval("login_time")%></td>
              <td align="center" width="100" nowrap ><a href='/ucenter/login.aspx' target="_blank" >登入</a> | 
              <a rel='facebox'  title='编辑<%#Eval("name")%>的资料' href='user_edit.aspx?uid=<%#Eval("bh")%>&UGroup_id=<%#Eval("UgroupID")%>&t=edit' >快捷编辑</a>
                |  <a rel='facebox'  title='设置<%#Eval("name")%>的等级资料' href='SetUserGrade.aspx?UserId=<%#Eval("bh")%>&UGroup_id=<%#Eval("UgroupID")%>&t=edit' >设置等级</a>
             
                   | <a href='#del<%#Eval("bh") %>' rel='facebox' title='确定删除 [<%#Eval("name")%>] 吗?' >删除</a>
                <div id="del<%#Eval("bh") %>" style="display:none; width:260px;">
               <p style="color:Red; margin-bottom:5px;">注意：将级联删除用户的扩展信息。</p>
                  <a href='?t=del&bh=<%#Eval("bh")%>'  class="btnSearch" style="padding:3px;">删除</a> 
                  <a href='?'  class="btnSearch" style="padding:3px;">取消</a> 
                  </div>
              </td>
            </tr>
          </ItemTemplate>
            <FooterTemplate>
              <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"10\">暂无记录</td></tr>" : ""%>

                  <TR>
                      <TD bgColor=#E2F1FC colSpan=10><input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
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
  
</form>
</body>
</html>
