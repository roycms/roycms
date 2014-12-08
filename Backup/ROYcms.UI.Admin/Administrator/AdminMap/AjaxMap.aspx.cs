using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.AdminMap
{
    public partial class AjaxMap : ROYcms.AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_AdminUrlMap BLL = new Sys.BLL.ROYcms_AdminUrlMap();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_AdminUrlMap Model = new Sys.Model.ROYcms_AdminUrlMap();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            int PRE = 0;
            Model.Id = ROYcms.Common.Request.GetFormInt("Id");
            Model.Name = ROYcms.Common.Request.GetFormString("Name");
            Model.Path = ROYcms.Common.Request.GetFormString("Path");
            Model.Description = ROYcms.Common.Request.GetFormString("Description");
            Model.TIME = DateTime.Now;

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