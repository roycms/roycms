using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.MyShop
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AJAXGoods : System.Web.UI.Page
    {
        /// <summary>
        /// ROYcms_Goods
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Goods BLL = new Sys.BLL.ROYcms_Goods();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Goods Model = new Sys.Model.ROYcms_Goods();
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            int PRE = 0;
            Model.Id = ROYcms.Common.Request.GetFormInt("Id");
            if (Model.Id > 0)//编辑
            {
                Model = BLL.GetModel(Model.Id);
            }

            Model.goods_type = ROYcms.Common.Request.GetFormInt("goods_type");
            Model.goods_sn = ROYcms.Common.Request.GetFormString("goods_sn");
            Model.goods_name = ROYcms.Common.Request.GetFormString("goods_name");
            Model.goods_name_style = ROYcms.Common.Request.GetFormString("goods_name_style");
            Model.brand_id = ROYcms.Common.Request.GetFormInt("brand_id");
            Model.provider_name = ROYcms.Common.Request.GetFormString("provider_name");
            Model.goods_number = ROYcms.Common.Request.GetFormInt("goods_number");
            Model.goods_weight = ROYcms.Common.Request.GetFormInt("goods_weight");
            Model.market_price = ROYcms.Common.Request.GetFormInt("market_price");
            Model.shop_price = ROYcms.Common.Request.GetFormInt("shop_price");
            Model.promote_price = ROYcms.Common.Request.GetFormInt("promote_price");
            Model.promote_start_date = Convert.ToDateTime(ROYcms.Common.Request.GetFormString("promote_start_date")==""?DateTime.Now.ToString():ROYcms.Common.Request.GetFormString("promote_start_date"));
            Model.promote_end_date = Convert.ToDateTime(ROYcms.Common.Request.GetFormString("promote_end_date") == "" ? DateTime.Now.ToString(): ROYcms.Common.Request.GetFormString("promote_end_date"));
            Model.warn_number = ROYcms.Common.Request.GetFormInt("warn_number");
            Model.keywords = ROYcms.Common.Request.GetFormString("keywords");
            Model.goods_brief = ROYcms.Common.Request.GetFormString("goods_brief");
            Model.goods_desc = ROYcms.Common.Request.GetFormString("goods_desc");
            Model.goods_thumb = ROYcms.Common.Request.GetFormString("goods_thumb");
            Model.goods_img = ROYcms.Common.Request.GetFormString("goods_img");
            Model.original_img = ROYcms.Common.Request.GetFormString("original_img");
            Model.is_real = ROYcms.Common.Request.GetFormInt("is_real");
            Model.extension_code = ROYcms.Common.Request.GetFormString("extension_code");
            Model.is_on_sale = ROYcms.Common.Request.GetFormInt("is_on_sale");
            Model.is_alone_sale = ROYcms.Common.Request.GetFormInt("is_alone_sale");
            Model.integral = ROYcms.Common.Request.GetFormInt("integral");
            
            Model.is_delete = ROYcms.Common.Request.GetFormInt("is_delete");
            Model.is_best = ROYcms.Common.Request.GetFormInt("is_best");
            Model.is_hot = ROYcms.Common.Request.GetFormInt("is_hot");
            Model.is_promote = ROYcms.Common.Request.GetFormInt("is_promote");
            Model.give_integral = ROYcms.Common.Request.GetFormInt("give_integral");
            Model.classkind = ROYcms.Common.Request.GetFormInt("ClassKind");
            Model.last_update = DateTime.Now;
            Model.click_count = 1;
            Model.add_time = DateTime.Now;

            if (Model.Id == 0)//添加
            {
                PRE = this.BLL.Add(this.Model);
                try //将相册的图片数据关联到文章来
                {
                    new ROYcms.Sys.BLL.ROYcms_Gallery().ZUpdate(PRE, Convert.ToInt32(Application["GalleryInt"] == null ? 0 : Application["GalleryInt"]));
                }
                catch
                {
                    new ROYcms.Sys.BLL.ROYcms_Log().InsertSystemLog("3", "将相册的图片数据关联到文章失败", "将相册的图片数据关联到文章失败");//写入日志
                }
            }
            else //编辑
            {
                PRE = this.BLL.Update(this.Model) == true ? 1 : 0;
            }

            Response.ContentType = "text/plain";
            Response.Write(PRE);
        }
    }
}