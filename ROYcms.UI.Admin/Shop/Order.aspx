<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Order.aspx.cs" Inherits="ROYcms.UI.Admin.Shop.Order" %>
<%@ Register src="Header.ascx" tagname="Header" tagprefix="Header" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>购物中心－ROYcms内容管理系统</title>
<CMS:Include ID="Include1" Path="/App_Templet/Default/Resources.html" runat=server />
</head>
<body>
<form id="ShopOrderForm" runat=server>
<!--Header-->
<Header:Header ID="Header1" runat="server" />
<!--Header-->
<div class="boxwrap ShopOrderTb" style="padding:15px;">

    <h3>收货人信息 </h3>
    <%
	 string IsDisplay="block";
	 if(ROYcms.Common.Request.GetFormInt("is_real")==0){IsDisplay="none";}//如果是虚拟物品%>
    <table width="100%" border="0" cellspacing="0" cellpadding="0" style="display:<%=IsDisplay%>;">
      <tr>
        <td width="9%" align="right">收货人姓名 </td>
        <td width="91%"><input type="text" class="txtInput" name="consignee" id="consignee" />
手机
  <input type="text" class="txtInput" name="mobile" id="mobile" />
电话
<input type="text" class="txtInput" name="tel" id="tel" />
邮编
<input type="text" class="txtInput" name="zipcode" id="zipcode" /></td>
      </tr>
      <tr>
        <td align="right">所在省份 </td>
        <td>
          <select name="province" class="select" id="province">
            <option value="北京">北京</option>
          </select>
          <select name="city" class="select" id="city">
            <option value="北京市">北京市</option>
          </select>
          <select name="district" class="select" id="district">
            <option value="海淀区">海淀区</option>
          </select>
        <script type="text/javascript">
      addressInit('province', 'city', 'district');
          </script></td>
      </tr>
      <tr>
        <td align="right">详细地址 </td>
        <td><input name="address" type="text" class="txtInput" id="address" size="55" />
标志建筑
  <input name="sign_building" type="text" class="txtInput" id="sign_building" size="20" />
最佳送货时间
<select name="best_time" id="best_time" class="select">
  <option value="0">上午8-12点</option>
  <option value="1" selected="selected">下午1-6点</option>
  <option value="2">中午12点</option>
  <option value="3">晚上21点前</option>
</select></td>
      </tr>
      <tr>
        <td align="right">邮箱 </td>
        <td><input type="text" class="txtInput" name="email" id="email" /></td>
      </tr>
    </table>
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="9%" align="right">支付方式</td>
        <td width="42%"><p>
          <label>
            <input name="pay_id" type="radio" id="pay_id_0" value="1" checked="checked" />
            在线支付</label>
         
          <label>
            <input type="radio" name="pay_id" value="2" id="pay_id_1" />
            公司转账</label>
        
          <label>
            <input type="radio" name="pay_id" value="3" id="pay_id_2" />
            邮局汇款</label>
        
        </p></td>
        <td width="49%">&nbsp;</td>
      </tr>
    </table>
    <table width="100%" border="0" cellspacing="0" cellpadding="0" style="display:<%=IsDisplay%>;">
      <tr>
        <td width="9%" align="right">配送方式</td>
        <td width="91%"><p>
          <label>
            <input name="shipping_id" type="radio" id="shipping_id_0" value="1" checked="checked" />
            快递</label>
        
          <label>
            <input type="radio" name="shipping_id" value="2" id="shipping_id_1" />
            EMS</label>
         
          <label>
            <input type="radio" name="shipping_id" value="3" id="shipping_id_2" />
            平邮</label>
        
          <label>
            <input type="radio" name="shipping_id" value="4" id="shipping_id_3" />
            自取</label>
        
          <label>
            <input type="radio" name="shipping_id" value="5" id="shipping_id_4" />
            货到付款</label>
         
        </p></td>
      </tr>
    </table>
    <table width="100%" border="0" cellspacing="0" cellpadding="0" style="display:<%=IsDisplay%>;">
      <tr>
        <td width="9%" align="right">发票信息 </td>
        <td width="91%"><p>
          <label>
            <input name="RadioGroup1" type="radio" id="RadioGroup1_1" value="2" checked="checked" />
            个人</label>
        
          <label>
            <input type="radio" name="RadioGroup1" value="1" id="RadioGroup1_0" />
            单位 
          </label>
          <input name="inv_payee" type="text" class="txtInput" id="inv_payee" value="单位名称" />
          <input name="inv_content" type="text" class="txtInput" id="inv_content" value="发票内容" />
        </p></td>
      </tr>
    </table>
    
      <h3>商品清单 </h3>
      <table width="100%" border="0" align="center" cellpadding="8" cellspacing="0" class="cart_table">
        <tr>
          <td align="left" bgcolor="#F4F4F4">商品名称 <a href="/shop/cart.aspx">《返回从新修改商品》</a></td>
          <td width="80" align="center" bgcolor="#F4F4F4">单价</td>
          <td width="80" align="center" bgcolor="#F4F4F4">数量</td>
          <td width="80" align="center" bgcolor="#F4F4F4">优惠</td>
          <td width="100" align="center" bgcolor="#F4F4F4">金额小计</td>
        </tr>
        <asp:Repeater ID="Repeater_Cart" runat="server">
          <ItemTemplate>
            <tr>
              <td><a target="_blank" href="/Goods-<%#Eval("id")%>.aspx"> <%# new ROYcms.Sys.BLL.ROYcms_Goods().GetModel(Convert.ToInt32(Eval("id"))).goods_name%></a></td>
              <td align="center">￥<%# new ROYcms.Sys.BLL.ROYcms_Goods().GetModel(Convert.ToInt32(Eval("id"))).shop_price%>.00 </td>
              <td align="center"><%#Eval("num")%></td>
              <td align="center">无</td>
              <td align="center"><font color="#FF0000" size="2"> ￥ <%# new ROYcms.Sys.BLL.ROYcms_Goods().GetModel(Convert.ToInt32(Eval("id"))).shop_price * Convert.ToInt32(Eval("num"))%>.00
                <input type="hidden" class="SubPrice" value="<%# new ROYcms.Sys.BLL.ROYcms_Goods().GetModel(Convert.ToInt32(Eval("id"))).shop_price * Convert.ToInt32(Eval("num"))%>" />
              </font></td>
            </tr>
          </ItemTemplate>
        </asp:Repeater>
      </table>
  
    <h3>订单结算信息 </h3>
    <table width="100%" border="0" cellspacing="0" cellpadding="0" class="ordercon">
      <tr>
        <td width="92%" align="right">商品总金额：</td>
        <td width="8%" nowrap="nowrap"><span id="PriceSum"></span>￥
          <input type="hidden" class="txtInput" name="goods_amount" id="goods_amount" /></td>
      </tr>
      <tr>
        <td align="right">配送费用：</td>
        <td nowrap="nowrap">15￥
          <input type="hidden" class="txtInput" name="shipping_fee" id="shipping_fee" value="15" /></td>
      </tr>
      <tr>
        <td align="right">保价费：</td>
        <td nowrap="nowrap">0￥
          <input type="hidden" class="txtInput" name="insure_fee" id="insure_fee" value="0" /></td>
      </tr>
      <tr>
        <td align="right">应付款金额：</td>
        <td nowrap="nowrap"><span id="order_amount_Sum"></span>￥
          <input type="hidden" class="txtInput" name="order_amount" id="order_amount" /></td>
      </tr>
    </table>
    
 <div class="line20"></div>
    <div class="right"> 
        <asp:Button ID="ShopOrderBT" runat="server" Text="确认提交订单" CssClass="btn" 
            onclick="ShopOrderBT_Click" />
    </div>
    <div class="clear"></div>
    
    
</div>
<div class="clear"></div>


 <script>
     //商品总额
     var con = 0;
     for (var i = 0; i < $(".SubPrice").size(); i++) {
         con += parseInt($(".SubPrice:eq(" + i + ")").val());
     }
     $("#PriceSum").html(con);
     $("#goods_amount").html(con);

     //应付金额
     var order_amount = parseInt(con) + parseInt($("#shipping_fee").val()) + parseInt($("#insure_fee").val());
     $("#order_amount").val(order_amount);
     $("#order_amount_Sum").html(order_amount);
    
	 //提交订单
	 $("#ShopOrderBT").click(function(){
		 ShopOrder();
		 });


 </script>

<!--Footer-->
<CMS:Include ID="Include3" Path="/App_Templet/Default/Footer.html" runat=server />
<!--/Footer-->
</form>
</body>
</html>