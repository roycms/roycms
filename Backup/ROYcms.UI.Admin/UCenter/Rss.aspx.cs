using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ROYcms.UI.Admin;

namespace ROYcms.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Rss : BasePage
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
                if (Request["del"] != null) { ___ROYcms_Rss_bll.Delete(Convert.ToInt32(Request["del"])); Bind(); }
            }
        }
        /// <summary>
        /// Binds this instance.
        /// </summary>
        void Bind()
        {
           Repeater_list.DataSource = new ROYcms.Sys.BLL.ROYcms_Rss().GetList("User_id=" + Convert.ToInt32(ROYcms.Common.Session.Get("user_id")));
           Repeater_list.DataBind();
        }
    }
}
