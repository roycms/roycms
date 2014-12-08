<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Cart.aspx.cs" Inherits="ROYcms.UI.Admin.Shop.Cart" %>
<%@ Register src="Header.ascx" tagname="Header" tagprefix="Header" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>购物中心－ROYcms内容管理系统</title>
<CMS:Include ID="Include1" Path="/App_Templet/Default/Resources.html" runat=server />
</head>
<body>
<form id="Form1" runat=server>
<!--Header-->
<Header:Header ID="Header1" runat="server" />
<!--Header-->
<div class="boxwrap">
  <div class="cart_box"> 
    <!--购物车-->
    <h1 class="main_tit"> 
    <span><a href="javascript:;">清空购物车</a></span>
    我的购物车<strong>Shopping Cart</strong> </h1>
    <div class="cart_step">
      <ul>
        <li class="selected"><span>1</span>放进购物车</li>
        <li><span>2</span>填写订单信息</li>
        <li class="last"><span>3</span>支付/确定订单</li>
      </ul>
    </div>
    <div class="line20"></div>
   
      <asp:Repeater ID="Repeater_Cart" runat="server">
           <HeaderTemplate>
            <table width="100%" border="0" align="center" cellpadding="8" cellspacing="0" class="cart_table">
                <tr>
                <td width="64"></th>
                <td align="left">商品名称</th>
                <td width="80" align="center">单价</td>
                <td width="80" align="center">数量</td>
                <td width="80" align="center">优惠</td>
                <td width="100" align="center">金额小计</td>
                <td width="100" align="center">积分</td>
                <td width="50" align="center">操作</td>
                </tr>
              </HeaderTemplate>
                <ItemTemplate>
                  <tr>
                    <td><a><img src='<%# new ROYcms.Sys.BLL.ROYcms_Goods().GetModel(Convert.ToInt32(Eval("id"))).goods_thumb%>' width="78" height="82" class="img" /></a></td>
                    <td><a target="_blank" href="/Goods-<%#Eval("id")%>.aspx"><%# new ROYcms.Sys.BLL.ROYcms_Goods().GetModel(Convert.ToInt32(Eval("id"))).goods_name%></a></td>
                    <td align="center">￥<%# new ROYcms.Sys.BLL.ROYcms_Goods().GetModel(Convert.ToInt32(Eval("id"))).shop_price%>.00 </td>
                    <td align="center">
                        <a href="javascript:;" class="reduce" title="减一" >减一</a>
                        <input type="text" class="input" style="width:30px;text-align:center;ime-mode:Disabled;" value="<%#Eval("num")%>" />
                        <a href="javascript:;" class="subjoin" title="加一" >加一</a>
                    </td>
                    <td align="center">无</td>
                    <td align="center"><font color="#FF0000" size="2">
                    ￥ <%# new ROYcms.Sys.BLL.ROYcms_Goods().GetModel(Convert.ToInt32(Eval("id"))).shop_price * Convert.ToInt32(Eval("num"))%>.00
                    <input type="hidden" class="SubPrice" value="<%# new ROYcms.Sys.BLL.ROYcms_Goods().GetModel(Convert.ToInt32(Eval("id"))).shop_price * Convert.ToInt32(Eval("num"))%>" />
                    </font></td>
                    <td align="center"><font color="#FF0000" size="2"> +0</font></td>
                    <td align="center"><a href="javascript:;" onclick="DelCp(this,<%#Eval("id")%>);">删除</a></td>
                  </tr>
                </ItemTemplate>
                <FooterTemplate>
                 <tr>
                  <td colspan="8" align="right" class="CarFooder"> 
                    商品件数：<% = ROYcms.Common.ShopCooksCar.GetProductCon() %>件   商品总金额（不含运费）：<font color="#FF0000" size="5">￥
                    <span id="PriceSum"></span>.00</font> 元 
                    </td>
                  </tr>
                </table>
               </FooterTemplate>
              </asp:Repeater>

             <%if (ROYcms.Common.ShopCooksCar.GetProductCon() == 0)
               {%>
                  <table width="100%">
                   <tr><td><center><a href='/'>购物车里没有数据点击继续购物</a></center></td></tr>
                  </table>
             <% }%>
             

                    <script>
                        var con = 0;
                        for (var i = 0; i < $(".SubPrice").size(); i++) {
                            con += parseInt($(".SubPrice:eq(" + i + ")").val());
                        }
                        $("#PriceSum").html(con);

                        //加一
                        $(".subjoin").click(function () {
                           // UpdateCart(3, 1);
                           
                            CartComputNum(this, 3, 1);
                        })
                        //减一
                        $(".reduce").click(function () {
                            CartComputNum(this, 3, 0);
                        })
                    
                        </script>

    <div class="line20"></div>
    <div class="right"> <a class="btn" href="/index.aspx">继续购物</a> <a class="btn btn-success marL10" href="/shop/Order.aspx">马上去结算</a> </div>
    <div class="clear"></div>
    <!--/购物车--> 
    
  </div>
</div>
<div class="clear"></div>
<!--Footer-->
<CMS:Include ID="Include3" Path="/App_Templet/Default/Footer.html" runat=server />
<!--/Footer-->
</form>
</body>
</html>

