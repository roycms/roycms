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
    /// 
    /// </summary>
    public partial class AJAXConfigModel : ROYcms.AdminPage
    {
        /// <summary>
        /// 实例化Bll方法
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Field bll = new ROYcms.Sys.BLL.ROYcms_Field();
        /// <summary>
        /// 实例化Model方法
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Field Model = new ROYcms.Sys.Model.ROYcms_Field();
        /// <summary>
        /// 页面加载...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Model.Rid = Convert.ToInt32(Request["Rid"]);
            Model.Name = Request["Name"];
            Model.Lable = Request["Lable"];
            Model.Len = Convert.ToInt32(Request["Len"]);
            Model.InputType = Request["InputType"];
            Model.IsNull = ROYcms.Common.Request.GetFormInt("IsNull");
            Model.IsKey = ROYcms.Common.Request.GetFormInt("IsKey");
            Model.DefaultVal = Request["DefaultVal"];
            Model.Display = ROYcms.Common.Request.GetFormInt("Display");
            Model.Expression = Request["Expression"];
            Model.InputLen = Convert.ToInt32(Request["InputLen"]);
            Model.OrderBy = Convert.ToInt32(Request["OrderBy"]);
            Model.FieldType = ROYcms.Common.Request.GetFormInt("FieldType");

            if (Model.Name != null)
            {
                int PRE = bll.Add(Model);
                Response.ContentType = "text/plain";
                Response.Write(PRE);
            }
        }
    }
}
