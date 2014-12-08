using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Blog.Web
{
    public partial class index : BlogPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string BlogUi = ___GetBlogValue(this.User_id, "BlogUi");
            if (BlogUi == "") { BlogUi = "default"; }
            string RequestParameter = string.Format("user_id={0}&Tag={1}&Page={2}",Request["user_id"],Request["Tag"],Request["Page"]);
            string URL = string.Format("~/app_blog/ui/{0}/index.aspx?{1}",BlogUi, RequestParameter);
            Server.Execute(URL, true);

        }
    }
}
