using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.Appendix
{
    public partial class AJAXInsert : System.Web.UI.Page
    {
        /// <summary>
        /// 相册的编辑和删除
        /// </summary>
        ROYcms.Sys.BLL.ROYcms_Appendix BLL = new Sys.BLL.ROYcms_Appendix();
        /// <summary>
        /// 
        /// </summary>
        ROYcms.Sys.Model.ROYcms_Appendix Model = new Sys.Model.ROYcms_Appendix();
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
                    PRE = BLL.Delete("Rid=" + Application["AppendixInt"] + " AND URL='" + ROYcms.Common.Request.GetQueryString("URL") + "' ") == true ? 1 : 0;
                }
            }
            else
            {

                Model.Id = ROYcms.Common.Request.GetQueryInt("Id");
                Model.Rid = Convert.ToInt32(Application["AppendixInt"]);//一个随机的值
                if (ROYcms.Common.Request.GetQueryInt("Rid") != 0)
                {
                    Model.Rid = ROYcms.Common.Request.GetQueryInt("Rid");
                }
                Model.TYPE = ROYcms.Common.Request.GetQueryInt("TYPE");
                Model.Title = ROYcms.Common.Request.GetQueryString("Title") == "undefined" ? "" : ROYcms.Common.Request.GetQueryString("Title");
                Model.TIME = DateTime.Now;
                Model.URL = ROYcms.Common.Request.GetQueryString("URL");
           
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