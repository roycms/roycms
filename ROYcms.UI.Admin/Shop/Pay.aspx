<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pay.aspx.cs" Inherits="ROYcms.UI.Admin.Shop.Pay" %>
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
<span style="font-size:16px; color:Red;">
 <asp:Label ID="Mes" runat="server" Text=""></asp:Label>

</span>
   
</div>
<div class="clear"></div>
<!--Footer-->
<CMS:Include ID="Include3" Path="/App_Templet/Default/Footer.html" runat=server />
<!--/Footer-->
</form>
</body>
</html>