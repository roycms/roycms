<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyGoods.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Payment.MyGoods" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
</head>
<body>
    <form id="form1" runat="server">
      <table width="500" border="0" align="center" cellpadding="8" cellspacing="0" class="cart_table">
        <tr>
          <td align="left" bgcolor="#F4F4F4">商品名称</td>
          <td width="80" align="center" bgcolor="#F4F4F4">单价</td>
          <td width="80" align="center" bgcolor="#F4F4F4">数量</td>
          <td width="80" align="center" bgcolor="#F4F4F4">优惠</td>
          <td width="100" align="center" bgcolor="#F4F4F4">金额小计</td>
        </tr>
        <asp:Repeater ID="Repeater_MyGoods" runat="server">
          <ItemTemplate>
            <tr>
              <td><a target="_blank" href="/Goods-<%#Eval("goods_id")%>.aspx"> <%#Eval("goods_name")%></a></td>
              <td align="center">￥<%#Eval("goods_price")%>.00 </td>
              <td align="center"><%#Eval("goods_number")%></td>
              <td align="center">无</td>
              <td align="center"><font color="#FF0000" size="2"> ￥ <%# Convert.ToInt32(Eval("goods_price")) * Convert.ToInt32(Eval("goods_number"))%>.00 
              </font></td>
            </tr>
          </ItemTemplate>
        </asp:Repeater>
      </table>
    </form>
</body>
</html>
