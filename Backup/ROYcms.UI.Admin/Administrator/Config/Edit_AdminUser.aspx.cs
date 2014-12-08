using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ROYcms.UI.Admin.Administrator.config
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Edit_AdminUser : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Admin Model = new ROYcms.Sys.Model.ROYcms_Admin();
       /// <summary>
       /// 
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null) { 
                
                Model =___ROYcms_Admin_bll.GetModel(Convert.ToInt32(Request["id"]));
                Model.password = ROYcms.Common.DESEncrypt.Decrypt(Model.password);
            }
        }

    }
}
