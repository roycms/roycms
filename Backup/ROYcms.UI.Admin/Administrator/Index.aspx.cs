using System;
using ROYcms.Common;
using System.Web;
namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 后台管理框架页面
    /// </summary>
    public partial class Administrator_admin_index : AdminPage
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
                if (Request["admin"] == "out") { 
                    HttpContext.Current.Session.RemoveAll();
                    ROYcms.Common.cooks.ClearCookie("administrator");
                    ROYcms.Common.cooks.ClearCookie("administrators");
                    Response.Redirect("~/administrator/login.aspx");
                }
            }
        }
    }
}