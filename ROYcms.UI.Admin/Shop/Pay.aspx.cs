using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Shop
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Pay : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
          string OrderId =  ROYcms.Common.Request.GetQueryString("OrderId");
          int pay_id = ROYcms.Common.Request.GetQueryInt("pay_id");
          string order_amount = ROYcms.Common.Request.GetQueryString("order_amount");
          if (pay_id == 1) //属于在线支付
          {
             //跳转到在线支付的页面
              Mes.Text = String.Format("订单{0}已经成功生成！跳转到支付接口。",OrderId);
          }
          else if (pay_id == 2) 
          {
              Mes.Text = String.Format("订单{0}已经成功生成！请按照公司账户进行转账。", OrderId);
          }
          else if (pay_id == 3) 
          {
              Mes.Text = String.Format("订单{0}已经成功生成！请按照汇款信息进行邮局汇款。", OrderId);
          }
          else {
              Mes.Text = "订单异常！";
          }
        }
    }
}