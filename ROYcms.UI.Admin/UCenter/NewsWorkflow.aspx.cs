using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ROYcms.UI.Admin;

namespace ROYcms.UCenter
{
    /// <summary>
    /// /
    /// </summary>
    public partial class NewsWorkflow : UserPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { Bind(); }
        }
        /// <summary>
        /// 
        /// </summary>
        void Bind()
        {
            //Repeater_list.DataSource = ___Page.GetList( ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("date_prefix") + "news", "bh", 30, 1, "switchs=" +Convert.ToInt32(Request["keyId"]));
            //Repeater_list.DataBind();
        }
    }
}
