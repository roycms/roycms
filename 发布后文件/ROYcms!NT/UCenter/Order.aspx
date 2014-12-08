<%@ Page Title="" Language="C#" MasterPageFile="~/UCenter/UCenter.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="ROYcms.UI.Admin.UCenter.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script>    $("#news").parent().addClass("hover");</script>
<STYLE>
 .Tb td{
   font-size:12px;
   padding:3px;
 }
</STYLE>
  <div id="Topnav_tags">
      <ul>
        <li>
          <a href="?S=0">最新订单</a>
        </li>
        <li>
          <a href="?S=1">历史订单查询</a>
        </li>

      </ul>
    </div>
     <%if (ROYcms.Common.Request.GetQueryInt("S") == 0)
       {%>
  <asp:Repeater ID="Repeater_admin" runat="server">
         <HeaderTemplate>
            <TABLE border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb">
                <TBODY>
                <TR id="tiao_center">
                 
                  <TD nowrap><span class="line">订单号</span></TD>
                  <TD nowrap><span class="line">产品详情</span></TD>
                  <TD nowrap ><span class="line">订单金额</span></TD>
                  <TD nowrap><span class="line">订单状态</span></TD>
                  <TD nowrap><span class="line">支付状态</span></TD>
                  <TD nowrap><span class="line">配送状态</span></TD>
                  <TD nowrap><span class="line">创建时间</span></TD>
                  <TD nowrap></TD>
                </TR>
         </HeaderTemplate>
          <ItemTemplate>
            <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'" >
       
              <td><%#Eval("Order_sn")%></td>
              <td><a rel=facebox href="/administrator/Payment/MyGoods.aspx?OrderId=<%#Eval("Order_sn") %>" title='订单包含的产品详情'>点击查看</a></td>
              <td><%#Eval("order_amount")%>￥</td>
              <td nowrap="nowrap"><%# Bll.GetOrderStatus(Convert.ToInt32(Eval("order_status")),0)%></td>
              <td nowrap="nowrap"><%# Bll.GetOrderStatus(Convert.ToInt32(Eval("pay_status")), 1)%></td>
              <td nowrap="nowrap"><%# Bll.GetOrderStatus(Convert.ToInt32(Eval("shipping_status")), 2)%></td>
              <td><%#Eval("add_time")%></td>
              <td align="center" nowrap>
              <a rel=facebox href="#S<%#Eval("Id") %>" title='手动处理订单'>处理</a>
              </td>
             <div id="S<%#Eval("Id")%>" style="display:none; width:360px;">
                    <p style="color:Red; margin-bottom:5px;">注意：订单处理状态需要仔细确认后才能操作。</p>
                     <%#Eval("pay_status").ToString()=="0"?"<a href='/shop/pay.aspx?OrderId="+Eval("Order_sn")+"' class='btnSearch' style='padding:3px;'>继续支付</a>":""%>
                      <a href="?Id=<%#Eval("id")%>&Status=2&T=0" class="btnSearch" style="padding:3px;">取消订单</a>
                      <br style=" margin-bottom:5px;" />
                      <a href="?Id=<%#Eval("id")%>&Status=2&T=2" class="btnSearch" style="padding:3px;">确认收货</a>
                      <br style=" margin-bottom:5px;" />
                      <a href="?" class="btnSearch" style="padding:3px;">取消</a>
                    </div>
            </tr>
          </ItemTemplate>
            <FooterTemplate>
              <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"8\">暂无记录</td></tr>" : ""%>
               </TBODY>
                </TABLE>
            </FooterTemplate>
        </asp:Repeater>
        <%}
       else
       { %>
       暂无历史订单
        <%} %>
</asp:Content>
