using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Shop
{
    public partial class Success : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Goods_Order OrderBLL = new Sys.BLL.ROYcms_Goods_Order();
        public ROYcms.Sys.Model.ROYcms_Goods_Order OrderModel = new Sys.Model.ROYcms_Goods_Order();
        public ROYcms.Sys.BLL.ROYcms_Payment PaymentBLL = new Sys.BLL.ROYcms_Payment();
        public ROYcms.Sys.Model.ROYcms_Payment PaymentModel = new Sys.Model.ROYcms_Payment();
        protected void Page_Load(object sender, EventArgs e)
        {
            //支付成功后的操作
            string OrderId = ROYcms.Common.Request.GetQueryString("OrderId");

            //修改订单状态
            OrderModel = OrderBLL.GetModel(OrderId);
            OrderModel.order_status = 1;//将订单修改为已确认
            OrderModel.pay_status = 2;//修改支付状态 为已付款
            OrderModel.shipping_status = 3;//修改配送状态为 备货中
            OrderBLL.Update(OrderModel);
            //写入在线支付记录
            PaymentModel.PaymentAmount = 0;
            PaymentModel.PaymentName = "";
            PaymentModel.PaymentNum = "";
            PaymentModel.PaymentType = "";
            PaymentModel.UserID = Convert.ToInt32(ROYcms.Common.Session.Get("user_id") == null ? "0" : ROYcms.Common.Session.Get("user_id"));
            PaymentModel.CreateTime = DateTime.Now;
            PaymentModel.UpdateTime = DateTime.Now;
            PaymentBLL.Add(PaymentModel);
            //如果是充值到账户  加正账户余额 加正可用余额
        }
    }
}