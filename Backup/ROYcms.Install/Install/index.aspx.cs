using System;
using System.Web.UI;

namespace ROYcms.Install.Install
{
    /// <summary>
    /// 
    /// </summary>
    public partial class index : System.Web.UI.Page
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {}
        /// <summary>
        /// Handles the Click event of the Button_Step1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Button_Step1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Install/Step1.aspx");
        }
    }
}
