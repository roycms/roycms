using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Blog.Web.App_Blog
{
    public partial class __comment : UserControlBlogPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
        }
        void Bind()
        {
            Repeater_list.DataSource =___ROYcms_Blog_result_bll.GetList(10, "id>0", "id desc");
            Repeater_list.DataBind();
        }
    }
}