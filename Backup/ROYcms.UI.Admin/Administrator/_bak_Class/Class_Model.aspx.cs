using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;

namespace ROYcms.UI.Admin.Administrator.Class
{
    /// <summary>
    /// Class_Model
    /// </summary>
    public partial class Class_Model : System.Web.UI.Page
    {
        /// <summary>
        /// ROYcms_Class_Model
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Model BLL = new ROYcms.Sys.BLL.ROYcms_Model();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Class_Model Class_ModelBll = new ROYcms.Sys.BLL.ROYcms_Class_Model();
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            Repeater_admin.DataSource = BLL.GetAllList();
            Repeater_admin.DataBind();

        }
   
    }
}
