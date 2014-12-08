using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.Go
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Insert : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Objet Model = new ROYcms.Sys.Model.ROYcms_Objet();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Objet BLL = new Sys.BLL.ROYcms_Objet();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.UI.Admin.Administrator.Model.AdminModel Index = new ROYcms.UI.Admin.Administrator.Model.AdminModel();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater_admin.DataSource = Index.Bll.GetAllList();
            Repeater_admin.DataBind();
            if (Request["id"] != null)
            {
                Model = BLL.GetModel(Convert.ToInt32(Request["id"]));

            }
           
        }
    }
}