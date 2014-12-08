using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ROYcms.UI.Admin.Shop
{
    public partial class Order : System.Web.UI.Page
    {

        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Goods_Order BLL = new Sys.BLL.ROYcms_Goods_Order();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Goods_Order Model = new Sys.Model.ROYcms_Goods_Order();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Goods_Order_Detail Order_Detail_BLL = new Sys.BLL.ROYcms_Goods_Order_Detail();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Goods_Order_Detail Order_Detail_Model = new Sys.Model.ROYcms_Goods_Order_Detail();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Goods Goods_BLL = new Sys.BLL.ROYcms_Goods();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Goods Goods_Model = new Sys.Model.ROYcms_Goods();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ROYcms.Common.ShopCooksCar.GetProductCon() > 0)
            {
                Repeater_Cart.DataSource = ROYcms.Common.ShopCooksCar.GetCar();
                Repeater_Cart.DataBind();
            }
            else {
                Response.Redirect("/shop/index.aspx");
            }
        }
        /// <summary>
        /// 提交订单按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ShopOrderBT_Click(object sender, EventArgs e)
        {
            string OrderId = ROYcms.Common.StringPlus.GetRamCode();
            //InsertOrder(OrderId);//创建订单
            //InsertOrderGoods(OrderId);//将购物车数据保存
            if (InsertOrder(OrderId) > 0 && InsertOrderGoods(OrderId))
            {
                // 清空购物车数据
                ROYcms.Common.ShopCooksCar.RemoveShoppingCar();
                string GOurl = String.Format("/shop/pay.aspx?OrderId={0}&pay_id={1}&order_amount={2}", OrderId, ROYcms.Common.Request.GetFormString("pay_id"), ROYcms.Common.Request.GetFormString("order_amount"));

                Response.Redirect(GOurl);
            }
            else
            {
                Response.Write("订单创建失败！");
            }
          
        }

        /// <summary>
        /// 创建订单
        /// </summary>
        /// <returns></returns>
        public int InsertOrder(string OrderId)
        {
            Model.order_sn = OrderId;

            Model.goods_amount = ROYcms.Common.Request.GetFormInt("goods_amount");
            Model.order_amount = ROYcms.Common.Request.GetFormInt("order_amount");
            Model.user_id = Convert.ToInt32(ROYcms.Common.Session.Get("user_id") == null ? "0" : ROYcms.Common.Session.Get("user_id"));
            Model.order_status = 0;
            Model.shipping_status = 0;
            Model.pay_status = 0;

            Model.consignee = ROYcms.Common.Request.GetFormString("consignee");
            Model.country = ROYcms.Common.Request.GetFormString("country");
            Model.province = ROYcms.Common.Request.GetFormString("province");
            Model.city = ROYcms.Common.Request.GetFormString("city");
            Model.district = ROYcms.Common.Request.GetFormString("district");
            Model.address = ROYcms.Common.Request.GetFormString("address");
            Model.zipcode = ROYcms.Common.Request.GetFormString("zipcode");
            Model.tel = ROYcms.Common.Request.GetFormString("tel");
            Model.mobile = ROYcms.Common.Request.GetFormString("mobile");
            Model.email = ROYcms.Common.Request.GetFormString("email");
            Model.best_time = ROYcms.Common.Request.GetFormInt("best_time");
            Model.sign_building = ROYcms.Common.Request.GetFormString("sign_building");
            Model.postscript = ROYcms.Common.Request.GetFormString("postscript");

            Model.shipping_id = ROYcms.Common.Request.GetFormInt("shipping_id");
            Model.shipping_name = ROYcms.Common.Request.GetFormString("shipping_id");
            Model.pay_id = ROYcms.Common.Request.GetFormInt("pay_id");
            Model.pay_name = ROYcms.Common.Request.GetFormString("pay_id");
            Model.how_oos = 0;
            Model.how_surplus = 0;
            Model.pack_name = ROYcms.Common.Request.GetFormString("pack_name");
            Model.card_name = ROYcms.Common.Request.GetFormString("card_name");
            Model.card_message = ROYcms.Common.Request.GetFormString("card_message");
            Model.inv_payee = ROYcms.Common.Request.GetFormString("inv_payee");
            Model.inv_content = ROYcms.Common.Request.GetFormString("inv_content");

            Model.shipping_fee = ROYcms.Common.Request.GetFormString("shipping_fee");
            Model.insure_fee = ROYcms.Common.Request.GetFormInt("insure_fee");

            Model.pay_fee = null;
            Model.pack_fee = ROYcms.Common.Request.GetFormString("pack_fee");
            Model.card_fee = ROYcms.Common.Request.GetFormString("card_fee");
            Model.money_paid = 0;
            Model.surplus = "0";
            Model.Integeregral = 0;
            Model.Integeregral_money = 0;
            Model.bonus = 0;

            Model.from_ad = 0;
            Model.referer = null;
            Model.add_time = DateTime.Now;
            Model.confirm_time = DateTime.Now;
            Model.pay_time = DateTime.Now;
            Model.shipping_time = DateTime.Now;
            Model.pack_id = 0;
            Model.card_id = 0;
            Model.bonus_id = 0;
            Model.invoice_no = null;
            Model.extension_code = 0;
            Model.extension_id = 0;
            Model.to_buyer = null;
            Model.pay_note = null;
            Model.agency_id = 0;
            Model.inv_type = null;
            Model.tax = null;
            Model.is_separate = 0;
            Model.parent_id = 0;
            Model.discount = null;


            return this.BLL.Add(this.Model);
        }
        /// <summary>
        /// 将购物车数据插入到数据库 
        /// </summary>
        /// <param name="OrderId">订单号</param>
        /// <returns></returns>
        public bool InsertOrderGoods(string OrderId)
        {
            //try
            //{
            DataTable DT = ROYcms.Common.ShopCooksCar.GetAllChoppingCar(); //获取购物车数据
            foreach (DataRow Dr in DT.Rows)
            {
                Goods_Model = Goods_BLL.GetModel(Convert.ToInt32(Dr["Id"]));
                Order_Detail_Model.goods_id = Goods_Model.Id;
                Order_Detail_Model.order_id = OrderId;     //订单商品信息对应的详细信息id，取值order_info的order_id 
                Order_Detail_Model.goods_number = Convert.ToInt32(Dr["num"]); //商品的购买数量
                Order_Detail_Model.goods_id = Goods_Model.Id;     //商品的的id，取值表ecs_goods 的 goods_id 
                Order_Detail_Model.goods_name = Goods_Model.goods_name;   //商品的名称，取值表ecs_goods 
                Order_Detail_Model.goods_sn = Goods_Model.goods_sn;     //商品的唯一货号，取值ecs_goods 
                Order_Detail_Model.market_price = Goods_Model.market_price; //商品的市场售价，取值ecs_goods 
                Order_Detail_Model.goods_price = Goods_Model.shop_price;  //商品的本店售价，取值ecs_goods 
                Order_Detail_Model.send_number = Goods_Model.goods_number;  //是否已发货，0 ，否；1，是
                Order_Detail_Model.is_real = Goods_Model.is_real;      //是否是实物
                Order_Detail_Model.extension_code = Goods_Model.extension_code;//商品的扩展属性，比如像虚拟卡
                Order_Detail_Model.goods_attr = null;   //购买该商品时所选择的属性；
                Order_Detail_Model.parent_id = 0;    //父商品id，取值于ecs_cart的 parent_id；如果有该值则是值多代表的物品的配件
                Order_Detail_Model.is_gift = 0;      //是参加的优惠活动的id
                Order_Detail_BLL.Add(Order_Detail_Model);
            }
            return true;
            //}
            //catch { return false; }

        }

    }
}