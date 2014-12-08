<script Language="C#" runat="server">

//全局函数
    String rtnUrl = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host") + "administrator/shop/Order_success.aspx";
int rtnOk = 0;
    
void Page_Load(Object sender, EventArgs E){
//获取人民币网关账户号
String merchantAcctId=Request["merchantAcctId"].ToString().Trim();
String version=Request["version"].ToString().Trim();
//获取语言种类.固定选择值。
String language=Request["language"].ToString().Trim();
//签名类型.固定值
String signType=Request["signType"].ToString().Trim();
//获取支付方式
String payType=Request["payType"].ToString().Trim();
//获取银行代码
String bankId=Request["bankId"].ToString().Trim();
//获取商户订单号
String orderId=Request["orderId"].ToString().Trim();
//获取订单提交时间
String orderTime=Request["orderTime"].ToString().Trim();
//获取原始订单金额
String orderAmount=Request["orderAmount"].ToString().Trim();
///获取该交易在快钱的交易号
String dealId=Request["dealId"].ToString().Trim();
//获取银行交易号
String bankDealId=Request["bankDealId"].ToString().Trim();
//获取在快钱交易时间
String dealTime=Request["dealTime"].ToString().Trim();
//获取实际支付金额
String payAmount=Request["payAmount"].ToString().Trim();
//获取交易手续费
String fee=Request["fee"].ToString().Trim();
//获取扩展字段1
String ext1=Request["ext1"].ToString().Trim();
//获取扩展字段2
String ext2=Request["ext2"].ToString().Trim();
//获取处理结果
///10代表 成功; 11代表 失败
String payResult=Request["payResult"].ToString().Trim();
//获取错误代码
String errCode=Request["errCode"].ToString().Trim();
//获取加密签名串
String signMsg=Request["signMsg"].ToString().Trim();

if(payResult=="10")
{
	/*  
				 ' 商户网站逻辑处理，比方更新订单支付状态为成功
				' 特别注意：只有signMsg.ToUpper() == merchantSignMsg.ToUpper()，且payResult=10，才表示支付成功！同时将订单金额与提交订单前的订单金额进行对比校验。
				*/

    if (ROYcms.Common.GetUrlText.GetText(rtnUrl + "?msg=success&order_id=" + orderId + "&orderAmount=" + orderAmount + "&k=" + ext1, "utf-8") == "付款成功")
    {
        //报告给快钱处理结果，并提供将要重定向的地址。
        rtnOk = 1;
        rtnUrl = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host");
    }
    
    
	}
	else{
		rtnUrl=rtnUrl+"?msg=false";
		}
	}
</script>
<result><%=rtnOk %></result><redirecturl><%=rtnUrl %></redirecturl>