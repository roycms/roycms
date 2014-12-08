using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.UCenter
{    /// <summary>
    /// XML help?
    /// </summary>
    public partial class UCRight : System.Web.UI.UserControl
    {    /// <summary>
        /// XML help?
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        { }
        /// <summary>
        /// XML help?
        /// </summary>
        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Search.ashx?keyword="+Server.UrlEncode(TextBoxSearch.Text));
        }
    }
}