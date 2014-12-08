using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Blog.Web.App_Blog
{
    public partial class __calendar : UserControlBlogPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BlogCalendar_SelectionChanged(object sender, EventArgs e)
        {
            string URL = string.Format("~/blog-{0}/default.html", Request["user_id"]);
            Response.Redirect(URL);
        }
    }
}