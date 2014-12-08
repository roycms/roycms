using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.UCenter
{
    public partial class Order : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Goods_Order Bll = new Sys.BLL.ROYcms_Goods_Order();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Goods_Order Model = new Sys.Model.ROYcms_Goods_Order();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
                if (Request["T"] != null)
                {
                    Model = Bll.GetModel(Convert.ToInt32(Request["Id"]));
                    if (Request["T"] == "0")//订单状态
                    {
                        Model.order_status = Convert.ToInt32(Request["Status"]);
                    }
                    else if (Request["T"] == "2")//配送状态
                    {
                        Model.shipping_status = Convert.ToInt32(Request["Status"]);
                    }
                    Bll.Update(Model);
                    Bind();
                }
            }
           
        }
        /// <summary>
        /// 
        /// </summary>
        public void Bind()
        { 
            Repeater_admin.DataSource = Bll.GetAllList();
            Repeater_admin.DataBind();
        }
    }
}