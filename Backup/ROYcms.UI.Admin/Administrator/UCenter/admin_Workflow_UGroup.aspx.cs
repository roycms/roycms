using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class admin_Workflow_UGroup : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["del"] != null)
                {
                    
                    ___ROYcms_UGroup_Workflow_bll.Delete(Convert.ToInt32(Request["del"]));
                    Response.Redirect("Group_admin.aspx");
                }
            }
        }
    }
}
