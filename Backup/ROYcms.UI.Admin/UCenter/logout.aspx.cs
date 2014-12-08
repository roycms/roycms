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
    public partial class logout : UserPage
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
                ROYcms.Common.Session.Del("GUID");
                ROYcms.Common.Session.Del("user_id");
                ROYcms.Common.Session.Del("ugroup_id");
                ROYcms.Common.Session.Del("user");
                ROYcms.Common.Session.Del("Users");
                Response.Write(ROYcms.Common.SystemCms.R_MessageBox("注销成功！"));
               
            }
        }
    }
}
