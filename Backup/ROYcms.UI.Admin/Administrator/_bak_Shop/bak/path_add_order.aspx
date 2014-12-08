<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="path_add_order.aspx.cs" Inherits="ROYcms.UI.Admin.path_add_order" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <!--******************************增加页面代码********************************-->

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		订单号
	：</td>
	<td height="25" width="*" align="left">

	    <asp:Label ID="Label_order_id" runat="server" Text=""></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户名：</td>
	<td height="25" width="*" align="left">
		<asp:Label ID="Label_user_name" runat="server" Text=""></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		订单金额
	：</td>
	<td height="25" width="*" align="left">
		
		<asp:Label ID="Label_order_price" runat="server" Text=""></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		&nbsp;</td>
	<td height="25" width="*" align="left">
		&nbsp;</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		支付方式
	：</td>
	<td height="25" width="*" align="left">
		
	    <asp:DropDownList ID="DropDownList_order_payment" runat="server">
            <asp:ListItem>网银</asp:ListItem>
            <asp:ListItem>支付宝</asp:ListItem>
        </asp:DropDownList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		收件人姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtorder_rec_name" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		收件人地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtorder_rec_address" runat="server" Width="400px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		邮编
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtorder_rec_code" runat="server" Width="100px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		手机号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtorder_rec_phone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		固定电话：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtorder_rec_tel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		配送方式
	：</td>
	<td height="25" width="*" align="left">
		
	    <asp:DropDownList ID="DropDownList_order_shipping" runat="server">
            <asp:ListItem>宅急送</asp:ListItem>
            <asp:ListItem>顺风</asp:ListItem>
            <asp:ListItem>邮政EMS</asp:ListItem>
            <asp:ListItem>货到付款</asp:ListItem>
        </asp:DropDownList>
	    运费说明</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		送达时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtorder_deliveryTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		&nbsp;</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkifdefault" Text="默认地址" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		&nbsp;</td>
	<td height="25" width="*" align="left">
		&nbsp;</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		&nbsp;</td>
	<td height="25" width="*" align="left">
		<asp:Button ID="Order_Button" runat="server" onclick="Order_Button_Click" 
            Text="确认订单" />
        </td></tr>
</table>
    </div>
    </form>
</body>
</html>
