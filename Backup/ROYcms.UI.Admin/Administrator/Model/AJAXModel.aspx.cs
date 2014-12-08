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
    public partial class AJAXModel : ROYcms.AdminPage
    {
        /// <summary>
        /// 实例化Bll方法
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Model bll = new ROYcms.Sys.BLL.ROYcms_Model();
        /// <summary>
        /// ROYcms_Field_bll
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Field ROYcms_Field_bll = new ROYcms.Sys.BLL.ROYcms_Field();
        /// <summary>
        /// 实例化Model方法
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Model Model = new ROYcms.Sys.Model.ROYcms_Model();
        /// <summary>
        /// 页面加载...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Model.Name = Request["Name"];
            Model.TableName = "ROYcms_Model_" + Request["TableName"];
            Model.ModelType = Convert.ToInt32(Request["ModelType"]);//可选扩展分类
            Model.ModelDescription = Request["ModelDescription"];
            Model.TIME = DateTime.Now;
            if (Model.Name != null)
            {
                int PRE = bll.Add(Model);
                if (PRE > 0) { ROYcms_Field_bll.FieldInitialization(PRE); }//初始化默认字段数据
               
                Response.ContentType = "text/plain";
                Response.Write(PRE);
                //if (PRE > 0) {  } else { Response.Write("0"); }
            }
        }
    }
}
