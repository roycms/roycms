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
    public partial class AJAXBrand : ROYcms.AdminPage
    {
        /// <summary>
        /// ROYcms_Goods_Brand
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Goods_Brand BLL = new Sys.BLL.ROYcms_Goods_Brand();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Goods_Brand Model = new Sys.Model.ROYcms_Goods_Brand();
       /// <summary>
       /// 
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

            Model.Name = ROYcms.Common.Request.GetFormString("Name");
            Model.Logo = ROYcms.Common.Request.GetFormString("Logo");
            Model.brand_desc = ROYcms.Common.Request.GetFormString("brand_desc");
            Model.site_url = ROYcms.Common.Request.GetFormString("site_url");
            Model.sort_order = ROYcms.Common.Request.GetFormInt("sort_order");
            Model.TIME = DateTime.Now;
            Model.is_show = ROYcms.Common.Request.GetFormInt("is_show");

            if (Model.Id == 0)//添加
            {
                PRE = this.BLL.Add(this.Model);
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