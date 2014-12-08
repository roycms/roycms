using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.Payment
{
    public partial class MyGoods : ROYcms.BasePage
    {
        public ROYcms.Sys.BLL.ROYcms_Goods_Order_Detail Order_Detail_BLL = new Sys.BLL.ROYcms_Goods_Order_Detail();
        protected void Page_Load(object sender, EventArgs e)
        {
            string  OrderId = ROYcms.Common.Request.GetQueryString("OrderId");
            Repeater_MyGoods.DataSource = Order_Detail_BLL.GetList("order_id=" + OrderId);
            Repeater_MyGoods.DataBind();
        }
    }
}