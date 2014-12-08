using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.Gallery
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AJAXInsert : ROYcms.AdminPage
    {
        /// <summary>
        /// 相册的编辑和删除
        /// </summary>
        ROYcms.Sys.BLL.ROYcms_Gallery BLL = new Sys.BLL.ROYcms_Gallery();
        /// <summary>
        /// 
        /// </summary>
        ROYcms.Sys.Model.ROYcms_Gallery Model = new Sys.Model.ROYcms_Gallery();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            int PRE = 0;
            if (Request["Del"] != null)
            {
                if (ROYcms.Common.Request.GetQueryInt("Del") > 0)
                {
                    PRE = BLL.Delete("Rid=" + ROYcms.Common.Request.GetQueryInt("Del") + " AND URL='" + ROYcms.Common.Request.GetQueryString("URL") + "' ") == true ? 1 : 0;
                }
                else //删除相册临时数据
                {
                    PRE = BLL.Delete("Rid=" + Application["GalleryInt"] + " AND URL='" + ROYcms.Common.Request.GetQueryString("URL") + "' ") == true ? 1 : 0;
                }
            }
            else
            {
                
                Model.Id = ROYcms.Common.Request.GetQueryInt("Id");
                Model.Rid = Convert.ToInt32(Application["GalleryInt"]);//一个随机的值
                if (ROYcms.Common.Request.GetQueryInt("Rid") != 0)
                {
                    Model.Rid = ROYcms.Common.Request.GetQueryInt("Rid");
                }
                Model.TYPE = ROYcms.Common.Request.GetQueryInt("TYPE");
                Model.Title = ROYcms.Common.Request.GetQueryString("Title") == "undefined" ? "" : ROYcms.Common.Request.GetQueryString("Title");
                Model.TIME = DateTime.Now;
                Model.URL = ROYcms.Common.Request.GetQueryString("URL");
                Model.thumb_url = Model.URL.Replace(".", "_thumb.");
                try
                {
                    new ROYcms.Common.UP_img().MakeThumbnail(Server.MapPath(Model.URL), Server.MapPath(Model.thumb_url), 160, 480, "W");//生成缩略图
                }
                catch
                {
                    new ROYcms.Sys.BLL.ROYcms_Log().InsertSystemLog("5", "生成缩略图失败", "生成缩略图失败");//写入日志
                }
                if (Model.Id == 0)//添加
                {
                    PRE = this.BLL.Add(this.Model);
                }
                else //编辑
                {
                    PRE = this.BLL.Update(this.Model) == true ? 1 : 0;
                }
            }

            Response.ContentType = "text/plain";
            Response.Write(PRE);
        }
    }
}