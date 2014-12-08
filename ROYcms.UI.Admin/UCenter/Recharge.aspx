<%@ Page Title="" Language="C#" MasterPageFile="~/UCenter/UCenter.Master" AutoEventWireup="true" CodeBehind="Recharge.aspx.cs" Inherits="ROYcms.UI.Admin.UCenter.Recharge" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<STYLE>
 .Tb td{
   font-size:12px;
   padding:3px;
 }
</STYLE>
 <div id="Topnav_tags">
      <ul>
        <li>
          <a href="?S=0">财务状况</a>
        </li>
             <li>
          <a href="?S=1">支付记录</a>
        </li>
         <li>
          <a href="?S=2">发票申领</a>
        </li>
      </ul>
    </div>

    <table width="90%" border="0" align="center" cellpadding="0" cellspacing="3">
      <tr>
        <td align="center">
        <%if (ROYcms.Common.Request.GetQueryInt("S") == 0)
          {
              if (Model != null)
              { %>
                账户余额：   <%=Model.AccountBalance%>
                可用余额：<%=Model.AvilableBalance%> 
                已消费金额：<%=Model.ConsumedAmount%>
                积分： <%=Model.Money%>
            <%}
              else
              { %>

                该用户财务信息暂无
             <%}
          }
          else if (ROYcms.Common.Request.GetQueryInt("S") == 1)//支付记录
          { %>

                  <asp:Repeater ID="Repeater_admin" runat="server">
         <HeaderTemplate>
            <TABLE border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
                <TBODY>
                <TR id="tiao_center">
            
                  <TD width="28" nowrap="nowrap"><span class="line">编号</span></TD>
                 
                  <TD nowrap><span class="line">支付接口</span></TD>
                  <TD nowrap><span class="line">支付接口名称</span></TD>
                  <TD nowrap><span class="line">支付金额</span></TD>
                  <TD nowrap><span class="line">支付号</span></TD>
                  <TD nowrap><span class="line">更新时间</span></TD>
                  <TD nowrap><span class="line">创建时间</span></TD>
                </TR>
         </HeaderTemplate>
          <ItemTemplate>
            <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
         
              <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("Id") %>'></asp:Label></td>
             
              <td><%# Eval("PaymentType")%></td>
              <td><%#Eval("PaymentName")%></td>
              <td><%#Eval("PaymentAmount")%></td>
              <td nowrap="nowrap"><%#Eval("PaymentNum")%></td>
              <td><%#Eval("UpdateTime")%></td>
              <td><%#Eval("CreateTime")%></td>
            
            </tr>
          </ItemTemplate>
            <FooterTemplate>
              <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"7\">暂无记录</td></tr>" : ""%>
                  </TBODY>
                </TABLE>
            </FooterTemplate>
        </asp:Repeater>

          <% }
          else if (ROYcms.Common.Request.GetQueryInt("S") == 2)//发票申领
          {%>
                  <asp:Repeater ID="Repeater_AdminInvoice" runat="server">
         <HeaderTemplate>
            <TABLE border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
                <TBODY>
                <TR id="tiao_center">
               
                  <TD width="28" nowrap="nowrap"><span class="line">编号</span></TD>
              
                  <TD nowrap><span class="line">发票抬头</span></TD>
                  <TD nowrap ><span class="line">申领金额</span></TD>
                  <TD nowrap><span class="line">邮寄方式</span></TD>
                  <TD nowrap><span class="line">联系人</span></TD>
                  <TD nowrap><span class="line">电话</span></TD>
                  <TD nowrap><span class="line">手机</span></TD>
                  <TD nowrap><span class="line">创建时间</span></TD>
                  <TD nowrap  width="100"></TD>
                </TR>
         </HeaderTemplate>
          <ItemTemplate>
            <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
           
              <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("Id") %>'></asp:Label></td>
            
              <td nowrap><%# Eval("InvoiceName")%></td>
              <td nowrap><%#Eval("Price")%></td>
              <td nowrap><%#Eval("PostType")%></td>
              <td nowrap><%#Eval("RealName")%></td>
              <td nowrap><%#Eval("Tel")%></td>
              <td nowrap><%#Eval("Mobil")%></td>
              <td nowrap><%#Eval("CreateTime")%></td>
              <td align="center" nowrap>
              <a href="#D<%#Eval("Id") %>" rel='facebox' title='快递并备注发票处理情况'>快递并备注</a>
                  <div id="D<%#Eval("Id") %>" style="display:none; width:360px;">
                      <textarea id="AdminRemark" rows="3" cols="50" name="AdminRemark"></textarea>
                      <input type="submit" class="btnSearch" id="BT<%#Eval("Id") %>" value="提交" name="Submit">
                  </div>
              </td>
            
            </tr>
          </ItemTemplate>
            <FooterTemplate>
              <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"9\">暂无记录</td></tr>" : ""%>

               
                  </TBODY>
                </TABLE>
            </FooterTemplate>
        </asp:Repeater>

          <% }%>
          </td>
      </tr>
      </table>

</asp:Content>
