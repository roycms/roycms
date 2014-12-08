<%@ Page Language="C#" AutoEventWireup="True"  Inherits="ROYcms.UI.Admin.Administrator.go.admin_objet" %>
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
  <div style="margin-bottom:5px;margin-top:5px; display:table; width:100%;"  >
        <table width="100%" border="0" class="tiao_top">
              <tr>
                <td width="77%" nowrap><div  class="tiao_con"><a  href='Insert.aspx' title="添加一个模块" >
                <img align="absmiddle" src="/administrator/images/nv6.png" />添加一个模块</a> 

                
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
                        <td nowrap><span class="line">模块名称</span></td>
                        <td nowrap><span class="line">描述</span></td>
                        <td nowrap><span class="line">显示状态</span></td>
                        <td nowrap><span class="line">时间</span></td>
                        <td width="100" align="center" nowrap></td>
                      </tr>
              </HeaderTemplate>
                <ItemTemplate>
                  <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
                    <td nowrap><asp:CheckBox ID="ID_list" runat="server" onclick="javascript:chkRow(this);" /></td>
                    <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("ClassKind")%>'></asp:Label></td>
                    <td nowrap="nowrap"><img align="absmiddle" src="<%#Eval("logo")%>" /> <%#Eval("title")%></td>
                    <td nowrap="nowrap"><%#Eval("zhaiyao")%></td>
                    <td><%#Eval("Visible").ToString()=="0"?"隐藏":"显示"%></td>
                    <td nowrap="nowrap"><%#Eval("Time")%></td>
                    <td align="center" nowrap>
                    <a href="Insert.aspx?id=<%#Eval("id")%>&Classkind=<%#Eval("ClassKind")%>">编辑</a>
                     | <a href='#del<%#Eval("id")%>' rel="facebox" title='确实要卸载模块 [<%#Eval("title")%>] 吗?'>卸载 </a>
                      </td>
                    <div id="del<%#Eval("id")%>" style="display:none; width:260px;">
                      <p style="color:Red; margin-bottom:5px;">注意：卸载该模块儿将同步删除该模块儿下的所有频道以及频道内的数据。</p>
                      <a href="?del=<%#Eval("id")%>&ClassKind=<%#Eval("ClassKind")%>" class="btnSearch" style="padding:3px;">确认卸载</a>
                      <a href="?" class="btnSearch" style="padding:3px;">取消</a>
                    </div>
                  </tr>
                </ItemTemplate>
                <FooterTemplate>
              <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"8\">暂无记录</td></tr>" : ""%>

                  <TR>
                      <TD bgColor=#E2F1FC colSpan=8><input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
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
