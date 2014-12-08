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
    public partial class InsertBrand : System.Web.UI.Page
    {
        /// <summary>
        /// 
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
            Model.Id = ROYcms.Common.Request.GetQueryInt("Id");
            if (Model.Id > 0)//编辑
            {
                Model = BLL.GetModel(Model.Id);
            }
        }
    }
}