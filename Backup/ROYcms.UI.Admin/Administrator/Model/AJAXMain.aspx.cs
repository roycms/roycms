using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.Model
{
    /// <summary>
    /// 类
    /// </summary>
    public partial class AJAXMain : ROYcms.AdminPage
    {
        /// <summary>
        /// ROYcms_Custom 逻辑处理类
        /// </summary>
        ROYcms.Sys.BLL.ROYcms_Custom BLL = new ROYcms.Sys.BLL.ROYcms_Custom();
        ROYcms.Sys.Model.ROYcms_Custom Model = new ROYcms.Sys.Model.ROYcms_Custom();
        /// <summary>
        /// 加载...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Model = BLL.SetVal(this,0,0);
            Response.ContentType = "text/plain";
            Model.TableName = "ROYcms_Model_news0001";
            Response.Write(BLL.Update(Model));
            //
        }
    }
}
