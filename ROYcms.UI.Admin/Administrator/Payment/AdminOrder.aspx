<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminOrder.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Payment.AdminOrder" %>

<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html >
<head id="Head1" runat="server">
<title>订单管理</title>
</head>
<body>
<form id="AdminOrderForm" runat="server">
<Resources:Resources ID="Resources1" runat="server" />
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap>
        <div class="tiao_con">
        <a href="AdminOrder.aspx" title="订单管理"><img align="absmiddle" src="/administrator/images/nv6.png" />订单管理</a> 
        </div>
        </td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>


      <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-bottom:0px; margin-top:5px;">
    <tr>
      <td nowrap><img src="/administrator/images/funnel.png" width="16" height="16" align="absmiddle">
          <asp:DropDownList ID="order_status" runat="server" CssClass="select" Width="78px"  AutoPostBack="True">
              <asp:ListItem Value="0">订单状态</asp:ListItem>
              <asp:ListItem Value="0">未确认</asp:ListItem>
              <asp:ListItem Value="1">已确认</asp:ListItem>
              <asp:ListItem Value="2">已取消</asp:ListItem>
              <asp:ListItem Value="3">无效</asp:ListItem>
              <asp:ListItem Value="4">退货</asp:ListItem>
          </asp:DropDownList>
          <asp:DropDownList ID="pay_status" runat="server" CssClass="select" Width="78px"  AutoPostBack="True">
              <asp:ListItem Value="0">支付状态</asp:ListItem>
              <asp:ListItem Value="0">未付款</asp:ListItem>
              <asp:ListItem Value="1">付款中</asp:ListItem>
              <asp:ListItem Value="2">已付款</asp:ListItem>
          </asp:DropDownList>
         <asp:DropDownList ID="shipping_status" runat="server" CssClass="select" Width="78px"  AutoPostBack="True">
              <asp:ListItem Value="0">配送状态</asp:ListItem>
              <asp:ListItem Value="0">未发货</asp:ListItem>
              <asp:ListItem Value="1">已发货</asp:ListItem>
              <asp:ListItem Value="2">已收货</asp:ListItem>
              <asp:ListItem Value="3">备货中</asp:ListItem>
          </asp:DropDownList>
      </td>
      <td width="25%" align="right" nowrap>
        <input name="keywords" id="keywords" type="text" class="txtInput" style="width:120px;height:21px" title="输入订单号码进行搜索！" runat="server">
        <asp:Button ID="Submit" CssClass="btnSearch" runat="server" Text="搜索" />
      </td>
    </tr>
  </table>

        <asp:Repeater ID="Repeater_admin" runat="server">
         <HeaderTemplate>
            <TABLE border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
                <TBODY>
                <TR id="tiao_center">
                  <TD width=23 noWrap><input id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></TD>
                  <TD width="28" nowrap="nowrap"><span class="line">编号</span></TD>
                  <TD nowrap><span class="line">订单号</span></TD>
                  <TD nowrap><span class="line">产品详情</span></TD>
                  <TD nowrap><span class="line">用户ID</span></TD>
                  <TD nowrap ><span class="line">订单金额</span></TD>
                  <TD nowrap><span class="line">订单状态</span></TD>
                  <TD nowrap><span class="line">支付状态</span></TD>
                  <TD nowrap><span class="line">配送状态</span></TD>
                  <TD nowrap><span class="line">创建时间</span></TD>
                  <TD nowrap  width="100"></TD>
                </TR>
         </HeaderTemplate>
          <ItemTemplate>
            <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
              <td nowrap ><asp:CheckBox ID="ID_list" runat="server" /></td>
              <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("Id") %>'></asp:Label></td>
              <td><%#Eval("Order_sn")%></td>
              <td><a rel=facebox href="MyGoods.aspx?OrderId=<%#Eval("Order_sn") %>" title='订单包含的产品详情'>点击查看</a></td>
              <td><%#Eval("user_id")%></td>
              <td><%#Eval("order_amount")%>￥</td>
              <td nowrap="nowrap"><%# Bll.GetOrderStatus(Convert.ToInt32(Eval("order_status")),0)%></td>
              <td nowrap="nowrap"><%# Bll.GetOrderStatus(Convert.ToInt32(Eval("pay_status")), 1)%></td>
              <td nowrap="nowrap"><%# Bll.GetOrderStatus(Convert.ToInt32(Eval("shipping_status")), 2)%></td>


              <td><%#Eval("add_time")%></td>
              <td align="center" nowrap>
              <a rel=facebox href="#S<%#Eval("Id") %>" title='手动处理订单'>手动处理</a>
              </td>
             <div id="S<%#Eval("Id")%>" style="display:none; width:360px;">
                    <p style="color:Red; margin-bottom:5px;">注意：订单处理状态需要仔细确认后才能操作。</p>
                      <a href="?Id=<%#Eval("id")%>&Status=3&T=0" class="btnSearch" style="padding:3px;">标记为无效订单</a>
                      <a href="?Id=<%#Eval("id")%>&Status=4&T=0" class="btnSearch" style="padding:3px;">标记为退货</a>
                      <br style=" margin-bottom:5px;" />
                      <a href="?Id=<%#Eval("id")%>&Status=0&T=2" class="btnSearch" style="padding:3px;">标记为未发货</a>
                      <a href="?Id=<%#Eval("id")%>&Status=1&T=2" class="btnSearch" style="padding:3px;">标记为已发货</a>
                      <a href="?Id=<%#Eval("id")%>&Status=2&T=2" class="btnSearch" style="padding:3px;">标记为已收货</a>
                      <a href="?Id=<%#Eval("id")%>&Status=3&T=2" class="btnSearch" style="padding:3px;">标记为备货中</a>
                      <br style=" margin-bottom:5px;" />
                      <a href="?" class="btnSearch" style="padding:3px;">取消</a>
                    </div>
            </tr>
          </ItemTemplate>
            <FooterTemplate>
              <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"11\">暂无记录</td></tr>" : ""%>

                  <TR>
                      <TD bgColor=#E2F1FC colSpan=11><input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
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


