<%@ Page Language="C#" AutoEventWireup="True" Inherits="ROYcms.UI.Admin.Administrator_Order_admin" ValidateRequest="false" Codebehind="Order_admin.aspx.cs" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">    
<head>
</head>
<body>
<form runat="server">
<Resources:Resources ID="Resources1" runat="server" />

      <table width="100%" border="0" class="tiao_top">
      <tr>
      

        
         <td width="77%" nowrap><div class="tiao_con"> 
         
         <a><img align="absmiddle" src="/administrator/images/nv6.png" />订单管理</a> 
        <a><img align="absmiddle" src="/administrator/images/nv8.png" />发货管理</a> 
        <a rel="facebox" href='/administrator/shop/sum.aspx?date=<%= DateTime.Now.ToString() %>'><img align="absmiddle" src="/administrator/images/nv8.png" />订单统计报告</a> 

        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
    
    
          <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-bottom:0px; margin-top:5px;">
        <tr>
          <td width="15%" align="left" nowrap>
          <img src="/administrator/images/funnel.png" width="16" height="16" align="absmiddle">
        <a href="?ii=index">全部订单</a> |
        <a href="?t=pay_yes">完成支付订单</a> |
        <a href="?t=pay_no">未完成支付订单</a> |
        <a href="?t=consume_yes">完成消费订单</a> |
        <a href="?t=consume_no">未完成消费订单</a> 
          </td>
          <td width="60%" align="left" nowrap> <img src="/administrator/images/date_magnify.gif" width="16" height="16" align="absmiddle" style="margin-left:10px;">
          
            <a href="?day=0">今天</a> 
            <a href="?day=1">昨天</a> 
            <a href="?day=2">前天</a> 
            <a href="?day=3">更早</a> 
            </td>
          <td width="25%" align="right" nowrap><table border="0" cellpadding="0" cellspacing="0">
            <tr>
              <td nowrap><img src="/administrator/images/cms-ico7.gif" width="12" height="11" align="absmiddle"> 用户名： </td>
              <td nowrap><input name="keywords" id="keywords" type="text" class="input" style="width:120px;height:21px" title="输入用户名进行搜索！" runat="server"></td>
              <td align="right" width="40"> 
                  <asp:Button ID="Submit" CssClass="bt" runat="server" Text="搜索" 
                      onclick="Submit_Click"  /></td>
            </tr>
          </table></td>
        </tr>
      </table>
    
    
    
    
      <table cellpadding="5" cellspacing="1" border="0" width="100%"  class="Tb" style="margin-right:5px; margin-bottom:5px;margin-top:5px;" >
        <tr  id="tiao_center">
          <td width="12" nowrap><input  id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></td>
          <td width="42" nowrap><span class="line">订单号</span></td>
          <td width="42" align="center" nowrap><span class="line">金额</span></td>
       
          <td width="116" nowrap><span class="line">会员</span></td>
          <td width="95" nowrap><span class="line">订单时间</span></td>
          <td width="55" nowrap><span class="line">付款状态</span></td>
          <td width="167" align="center" nowrap><span class="line">操作</span></td>
        </tr>
        
        
          <asp:Repeater ID="Repeater_admin" runat="server">
          <ItemTemplate>
            <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
              <td height="25"  nowrap><asp:CheckBox ID="ID_list" runat="server" onclick="javascript:chkRow(this);" /></td>
              <td nowrap><a><%#Eval("order_id") %></a> [  <%#Eval("order_status").ToString().Trim() == "0" || Eval("order_status").ToString().Trim() == "2" ? "平台充值" : "游戏币兑换消费"%>]</td>
              <td nowrap><%#Eval("order_price") %></td>
             
              <td nowrap>
              <a><%# get_username(Convert.ToInt32(Eval("user_id") == DBNull.Value ? 0 : Eval("user_id")))%></a>
              
              </td>
              <td nowrap><%#Eval("create_time") != null ? Convert.ToDateTime(Eval("create_time")).ToString("yyyy/MM/dd hh:mm") : "00"%></td>
              <td align="center" nowrap><a><b>
              <font color="#FF3300" title="点击关闭。">
              
              
              <%#Eval("order_status").ToString().Trim() == "0" || Eval("order_status").ToString().Trim() == "3" ? "√" : "X"%>
            
              
              </font></b></a> </td>
              <td align="center" nowrap><a href='/app_xml/order/<%#Eval("id") %>.xml' target=_blank>详情</a> | <a href='?t=del&bh=<%#Eval("id") %>'onClick="return window.confirm('确定删除 [<%#Eval("order_id") %>] 吗?');">作废</a></td>
            </tr>
          </ItemTemplate>
        </asp:Repeater>
        
        
        <tr>
          <td height="25" colspan="8" bgcolor="#E2F1FC">
            

            
            <input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute; clip: rect(6 15 15 6)">
            <img src="/administrator/images/cms-ico12.gif" border="0">
          
            
<center>
<Script Language="JavaScript" type="text/JavaScript" src="/Administrator/js/page.js"></Script>
<script language="JavaScript">
<!--
var pg = new showPages('pg');
pg.pageCount =10;  // 定义总页数(必要)
pg.argName = 'page';  // 定义参数名(可选,默认为page)
//document.write('<br>Show Times: ' + pg.showTimes + ', Mood 1');
pg.printHtml(1);
//
-->
</script>
总 [<span class="TabbedPanelsTabHover">10</span>] 条数据
</center>
            
            
          </td>
          </tr>
 </table>


</form>
</body>
</html>