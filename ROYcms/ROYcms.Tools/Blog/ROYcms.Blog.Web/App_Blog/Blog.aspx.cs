using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Blog.Web
{
    public partial class Blog : BlogPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string BlogUi = ___GetBlogValue(this.User_id, "BlogUi");
            if (BlogUi == "") { BlogUi = "default"; }
            string RequestParameter = string.Format("user_id={0}&id={1}", Request["user_id"], Request["id"]);
            string URL = string.Format("~/app_blog/ui/{0}/blog.aspx?{1}",BlogUi, RequestParameter);
            Server.Execute(URL, true);
        }
    }
}
