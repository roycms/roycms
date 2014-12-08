using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ROYcms.UI.Admin.Administrator.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class UGroupConfig : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Repeater_XClass.DataSource = new ROYcms.Sys.BLL.ROYcms_class().GetClassList(3);
            this.Repeater_XClass.DataBind();


            this.Repeater_Workflow.DataSource = new ROYcms.Sys.BLL.ROYcms_Workflow().GetAllList();
            this.Repeater_Workflow.DataBind();
        }

    }
}
