using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Shop
{
    public partial class Goods : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Goods BLL = new Sys.BLL.ROYcms_Goods();
        public ROYcms.Sys.BLL.ROYcms_Gallery GalleryBll = new Sys.BLL.ROYcms_Gallery();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Goods Model = new Sys.Model.ROYcms_Goods();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Model = BLL.GetModel(ROYcms.Common.Request.GetQueryInt("Id"));
            GalleryBind(ROYcms.Common.Request.GetQueryInt("Id"));
        }
        /// <summary>
        /// 编辑状态下相册输出
        /// </summary>
        /// <param name="Rid"></param>
        public void GalleryBind(int Rid)
        {

            Repeater_Gallery.DataSource = GalleryBll.GetList(80, "Rid=" + Rid, " TIME");
            Repeater_Gallery.DataBind();
        }
    }
}