<%@ Page Language="C#" AutoEventWireup="true"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div>
   <h3>平台充值</h3>
   <hr />
   <div> 所有订单总数:<%= new ROYcms.Sys.BLL.ROYcms_product_order().GetCount("order_status=0 or order_status=1 ")%> </div>
   <div> 所有(已支付)订单总数:<%= new ROYcms.Sys.BLL.ROYcms_product_order().GetCount("order_status=0")%>
   金额: <%= Convert.ToString(ROYcms.DB.DbHelpers.GetSingle("SELECT SUM(order_price)  FROM ROYcms_product_order where order_status=0"))%>   </div>
   <div> 所有(未支付)订单总数:<%= new ROYcms.Sys.BLL.ROYcms_product_order().GetCount("order_status=1")%> </div>
   <div> 今天订单数(已支付):<%= new ROYcms.Sys.BLL.ROYcms_product_order().GetCount("(DATEDIFF(dd, create_time, GETDATE()) = 0) and order_status=0")%>
   金额:<%=Convert.ToString( ROYcms.DB.DbHelpers.GetSingle("SELECT SUM(order_price)  FROM ROYcms_product_order where (DATEDIFF(dd, create_time, GETDATE()) = 0) and order_status=0"))%> </div>
   <div> 昨天订单数(已支付):<%= new ROYcms.Sys.BLL.ROYcms_product_order().GetCount("(DATEDIFF(dd, create_time, GETDATE()) = 1) and order_status=0")%>
   金额:<%= Convert.ToString(ROYcms.DB.DbHelpers.GetSingle("SELECT SUM(order_price)  FROM ROYcms_product_order where (DATEDIFF(dd, create_time, GETDATE()) = 1) and order_status=0"))%> </div>
   
   <h3>游戏币兑换</h3>
   <hr />
   <div> 兑换订单总数:<%= new ROYcms.Sys.BLL.ROYcms_product_order().GetCount("order_status=3 or order_status=4 ")%> </div>
   <div> 所有(已兑换)订单总数:<%= new ROYcms.Sys.BLL.ROYcms_product_order().GetCount("order_status=3")%>
   
   
   金额:<%= Convert.ToString(ROYcms.DB.DbHelpers.GetSingle("SELECT SUM(order_price)  FROM ROYcms_product_order where order_status=3"))%> 
   
   
   
   </div>
   <div> 所有(未兑换)订单总数:<%= new ROYcms.Sys.BLL.ROYcms_product_order().GetCount("order_status=4")%> </div>
   <div> 今天兑换数(已兑换):<%= new ROYcms.Sys.BLL.ROYcms_product_order().GetCount("(DATEDIFF(dd, create_time, GETDATE()) = 0) and order_status=3")%>
   金额:
   <%= Convert.ToString(ROYcms.DB.DbHelpers.GetSingle("SELECT SUM(order_price)  FROM ROYcms_product_order where (DATEDIFF(dd, create_time, GETDATE()) = 0) and order_status=3"))%> 
   
    </div>
   <div> 昨天兑换数(已兑换):<%= new ROYcms.Sys.BLL.ROYcms_product_order().GetCount("(DATEDIFF(dd, create_time, GETDATE()) = 1) and order_status=3")%>
   金额:
   <%= Convert.ToString(ROYcms.DB.DbHelpers.GetSingle("SELECT SUM(order_price)  FROM ROYcms_product_order where (DATEDIFF(dd, create_time, GETDATE()) = 1) and order_status=3"))%> 
   
   
    </div>
  <hr />
   <div><a href='/app_api/send_mail.aspx?url=<%=Request.RawUrl %>' target=_blank>发送到邮箱</a></div>
    
    </div>
    </form>
</body>
</html>
