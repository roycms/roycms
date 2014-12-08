<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Caiji.Rss" ValidateRequest="false" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html >
<head id="Head1" runat="server">
<title></title>
</head>
<body>
<form id="form1" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <div style="margin-bottom:5px;margin-top:5px; display:table; width:100%;"  >
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con">
        <a title="添加采集规则" href="RssCollect.aspx" ><img align="absmiddle" src="/administrator/images/nv6.png" />添加采集规则</a> 
      
        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>

        <asp:Repeater ID="Repeater_admin" runat="server">
        <HeaderTemplate>
        <TABLE border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
          <TBODY>
           <TR id="tiao_center">
            <TD width=23 noWrap><input id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></TD>
            <TD width="28"><span class="line">编号</span></TD>
            <TD><span class="line">Rss地址</span></TD>
            <TD><span class="line">编码</span></TD>
            <TD><span class="line">本地地址</span></TD>
            <TD><span class="line">时间</span></TD>
            <TD width="100"></TD>
        </TR>
        </HeaderTemplate>
          <ItemTemplate>
            <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
              <td  nowrap ><asp:CheckBox ID="ID_list" runat="server" /></td>
              <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("id") %>'></asp:Label></td>
              <td><a href='<%#Eval("RssUrl")%>' target=_blank title="点击查看源"><%#Eval("RssUrl")%></a></td>
              <td><%# Eval("encode")%></td>
              <td><%#Eval("path")%></td>
              <td><%#Eval("time")%></td>
              <td align="center" nowrap>
               <a href='RssCollect.aspx?id=<%#Eval("id")%>' rel='facebox' title="编辑采集规则">采集配置</a> | 
               <a href='#del<%#Eval("id") %>' rel='facebox' title='确定删除 [<%#Eval("RssUrl")%>] 吗?' >删除</a>
                <div id="del<%#Eval("id") %>" style="display:none; width:260px;">
                  <a href='?t=del&id=<%#Eval("id")%>' >删除</a><a href='?' >取消</a>
                  </div>
                  </td>
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
                        </center></TD>
                    </TR>
                  </TBODY>
                </TABLE>
          </FooterTemplate>
        </asp:Repeater>
  </div>
</form>
</body>
</html>
