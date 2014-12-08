using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ROYcms.UI.Admin
{    /// <summary>
    /// XML help?
    /// </summary>
    public partial class Success : System.Web.UI.Page
    {    /// <summary>
        /// XML help?
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ROYcms.Sys.BLL.ROYcms_Goods_Order Goods_Order_BLL = new ROYcms.Sys.BLL.ROYcms_Goods_Order();
                ROYcms.Sys.Model.ROYcms_Goods_Order Goods_Order_Model = new ROYcms.Sys.Model.ROYcms_Goods_Order();
                ROYcms.Sys.BLL.ROYcms_Payment Payment_BLL = new ROYcms.Sys.BLL.ROYcms_Payment();
                ROYcms.Sys.Model.ROYcms_Payment Payment_Model = new ROYcms.Sys.Model.ROYcms_Payment();
                ROYcms.Sys.BLL.ROYcms_user user_BLL = new ROYcms.Sys.BLL.ROYcms_user();
                ROYcms.Sys.Model.ROYcms_user user_Model = new ROYcms.Sys.Model.ROYcms_user();
                string OrderId = Request["order_id"];
                if (OrderId != null)
                {
                    //修改订单状态
                     Goods_Order_Model =  Goods_Order_BLL.GetModel(OrderId);
                     if (Goods_Order_Model == null) { 
                         //订单无效
                         return;
                     }
                     Goods_Order_Model.order_sn = OrderId;
                     Goods_Order_Model.order_status = 1;
                     Goods_Order_BLL.Update_(Goods_Order_Model);
                     //创建支付记录
                     Payment_Model.PaymentAmount = Goods_Order_Model.goods_amount;
                     Payment_Model.PaymentName = "支付接口名称";
                     Payment_Model.PaymentNum = "支付号";
                     Payment_Model.PaymentType = "支付接口类型";
                     Payment_Model.UserID = Goods_Order_Model.user_id;
                     Payment_Model.UpdateTime = DateTime.Now;
                     Payment_BLL.Add(Payment_Model);
                     //修改用户积分
                     user_Model = user_BLL.GetModel(Convert.ToInt32(Goods_Order_Model.user_id));
                     if (user_Model == null)
                     {
                         //用户无效
                         return;
                     }
                     user_Model.money = user_Model.money + Goods_Order_Model.goods_amount;
                 
                }
                else { ROYcms.Common.MessageBox.Show(this,"订单号码不能为空!"); }
            }
        }
    }
}
