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
    public partial class Order_success : System.Web.UI.Page
    {    /// <summary>
        /// XML help?
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["order_id"] != null)
                {
                   
                    //修改订单状态

                    ROYcms.Sys.BLL.ROYcms_product_order ROYcms_product_order = new ROYcms.Sys.BLL.ROYcms_product_order();
                    ROYcms_product_order.order_status(Request["order_id"].Trim(), "0");//付款成功

                    //修改用户积分

                    string user_id = ROYcms.DB.DbHelpers.GetSingle("select user_id from ROYcms_product_order where order_id='" + Request["order_id"].Trim() + "'").ToString();
                    int money = Convert.ToInt32(ROYcms.DB.DbHelpers.GetSingle("select money from [ROYcms_user] where bh='" + user_id + "'") == null ? "0" : ROYcms.DB.DbHelpers.GetSingle("select money from [ROYcms_user] where bh='" + user_id + "'"));

                    ROYcms.DB.DbHelpers.NonQuery("update [ROYcms_user] SET money=" + ((Convert.ToInt32(Request["orderAmount"]) / 10) + money) + "  where bh='" + user_id + "'");


                    if (Request["k"] != null) 
                    {

                        string canshu = "/_add_order.html?orderId=" + Request["order_id"] + "&orderAmount=" + (Convert.ToInt32(Request["orderAmount"]) / 10) + "&productName=英雄王座 充值&productNum=1";
                      if (ROYcms.Common.GetUrlText.GetText(canshu, "utf-8") == "兑换成功")
                      {

                          Response.ContentType = "text/plain";
                          Response.Write("兑换成功");
                      }
                      else 
                      {
                          Response.ContentType = "text/plain";
                          Response.Write("失败！");
                      }
                    
                    }
                    else
                    {
                        Response.ContentType = "text/plain";
                        Response.Write("付款成功");
                    }

                   

                }
                else { Response.Write("订单号码不能为空!"); }
            }
        }
    }
}
