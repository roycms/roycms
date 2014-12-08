using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.Config
{
    /// <summary>
    /// AdminUserConfig
    /// </summary>
    public partial class AdminUserConfig : ROYcms.AdminPage
    {
        /// <summary>
        /// Model
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Admin Model = new ROYcms.Sys.Model.ROYcms_Admin();
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null)
            {

                Model = ___ROYcms_Admin_bll.GetModel(Convert.ToInt32(Request["id"]));
                Model.password = ROYcms.Common.DESEncrypt.Decrypt(Model.password);
            } 
            //绑定数据
                ROYcms.UI.Admin.Administrator.AdminMap.index Index = new AdminMap.index();
                Repeater_admin.DataSource = Index.BLL.GetAllList();
                Repeater_admin.DataBind();
        }
    }
}