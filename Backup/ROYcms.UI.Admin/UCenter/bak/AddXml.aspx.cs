using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ROYcms.UI.Admin;
using System.IO;

namespace ROYcms.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AddXml : UserPage
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
                string Path = Server.MapPath("~/app_data/UGroupFrom/" + ROYcms.Common.Session.Get("ugroup_id") + ".html");
                if (File.Exists(Path)) { Response.Write(ROYcms.Common.SystemCms.Read_File(Path, "utf-8")); }
                else { Response.Write("该用户组无扩展属性录入权限！或者未定义扩展信息。"); }
            }
        }
    }
}
