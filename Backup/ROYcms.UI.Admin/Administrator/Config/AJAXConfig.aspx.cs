using System;
using System.Collections;
using System.Configuration;
using System.Data;

namespace ROYcms.UI.Admin.Administrator.Config
{
    /// <summary>
    /// AJAXConfig
    /// </summary>
    public partial class AJAXConfig : ROYcms.AdminPage
    {
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            if (ROYcms.Common.SystemCms.NewXml(this, Server.MapPath("~/Administrator/App_Config/" + Request["config"]), "ROYcms/Config"))
            {
                Response.ContentType = "text/plain";
                Response.Write("1"); 
            }
            else {
                Response.ContentType = "text/plain";
                Response.Write("0"); 
            }
        }
    }
}
