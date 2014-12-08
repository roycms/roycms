using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Blog.Web.App_Blog.Control
{
    public partial class BlogList : UserControlBlogPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
        }
        void Bind()
        {
            string Where = "";
            Repeater_list.DataSource = ___ROYcms_Blog_user_bll.GetList(30, Where, "id desc");
            Repeater_list.DataBind();
        }
    }
}