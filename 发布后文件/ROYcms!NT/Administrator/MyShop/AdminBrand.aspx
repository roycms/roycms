<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminBrand.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.MyShop.AdminBrand" %>


<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html >
<head id="Head1" runat="server">
<title>品牌管理</title>
</head>
<body>
<form id="AdminBrandForm" runat="server">
<Resources:Resources ID="Resources1" runat="server" />
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap>
        <div class="tiao_con">
        <a href="InsertBrand.aspx" title="添加一个品牌"><img align="absmiddle" src="/administrator/images/nv6.png" />添加一个品牌</a> 
        <a href="AdminGoods.aspx" title="管理商品"><img align="absmiddle" src="/administrator/images/nv2.png" />管理商品</a> 
        
        </div>
        </td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>

        <asp:Repeater ID="Repeater_admin" runat="server">
         <HeaderTemplate>
            <TABLE border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
                <TBODY>
                <TR id="tiao_center">
                  <TD width=23 noWrap><input id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></TD>
                  <TD width="28" nowrap="nowrap"><span class="line">编号</span></TD>
                  <TD nowrap><span class="line">品牌名称</span></TD>
                  <TD nowrap><span class="line">Logo</span></TD>
                  <TD nowrap ><span class="line">品牌介绍</span></TD>
                  <TD nowrap><span class="line">网址</span></TD>
                  <TD nowrap><span class="line">创建时间</span></TD>
                  <TD nowrap  width="100"></TD>
                </TR>
         </HeaderTemplate>
          <ItemTemplate>
            <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
              <td nowrap ><asp:CheckBox ID="ID_list" runat="server" /></td>
              <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("Id") %>'></asp:Label></td>
              <td nowrap><a href="InsertBrand.aspx?Id=<%#Eval("Id") %>"><%#Eval("Name")%></a></td>
              <td nowrap><%# Eval("Logo")%></td>
              <td nowrap><%#Eval("brand_desc")%></td>
              <td nowrap><%#Eval("site_url")%></td>
              <td nowrap><%#Eval("TIME")%></td>
              <td align="center" nowrap>
              <a href="InsertBrand.aspx?Id=<%#Eval("Id") %>">编辑</a>
              <a href="#Del<%#Eval("Id") %>" rel='facebox' title='确实要删除[<%#Eval("Name")%>]品牌吗？'>删除</a>
                  <div id="Del<%#Eval("Id") %>" style="display:none; width:360px;">
                      <a class="btnSearch" href="?Del=<%#Eval("Id") %>" style="padding:3px;">提交</a>
                      <a class="btnSearch" href="?" style="padding:3px;">取消</a>
                  </div>
              </td>
            
            </tr>
          </ItemTemplate>
            <FooterTemplate>
              <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"9\">暂无记录</td></tr>" : ""%>

                  <TR>
                      <TD bgColor=#E2F1FC colSpan=9><input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
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

