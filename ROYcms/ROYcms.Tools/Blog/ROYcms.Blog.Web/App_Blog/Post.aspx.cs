using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Blog.Web.App_Blog
{
    public partial class Post :BlogPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Add();
        }
        void Add()
        {
            string blog_id = Request["blog_id"];
            string title = Request["CommentTitle"];
            string content = Request["CommentContent"];
            string user_id = Request["user_id"];
            string ip = Request.ServerVariables.Get("Remote_Addr").ToString();
            DateTime Time = DateTime.Now;

            if (blog_id != null && user_id != null && title != null)
            {
                ___ROYcms_Blog_result_model.blog_id = int.Parse(blog_id);
                ___ROYcms_Blog_result_model.title = title;
                ___ROYcms_Blog_result_model.content = content;
                ___ROYcms_Blog_result_model.user_id = user_id;
                ___ROYcms_Blog_result_model.ip = ip;
                ___ROYcms_Blog_result_model.Time = Time;

                ___ROYcms_Blog_result_bll.Add(___ROYcms_Blog_result_model);
                Response.Write("感谢您的评论！");
            }
            else { Response.Write("参数错误！"); }
        }
    }
}
