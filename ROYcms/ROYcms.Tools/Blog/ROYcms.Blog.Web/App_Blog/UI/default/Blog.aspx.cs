using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Blog.Web.App_Blog
{
    public partial class Blog : BlogPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {}

        public string Show(string filed)
        {
            ___ROYcms_Blog_model = ___ROYcms_Blog_bll.GetModel(Convert.ToInt32(Request["id"]));
            filed = filed.Replace("{title}", ___ROYcms_Blog_model.Title);
            filed = filed.Replace("{keyword}", ___ROYcms_Blog_model.Keyword);
            filed = filed.Replace("{description}", ___ROYcms_Blog_model.Description);
            filed = filed.Replace("{content}", ___ROYcms_Blog_model.content);
            filed = filed.Replace("{tag}", ___ROYcms_Blog_model.tag);
            filed = filed.Replace("{time}", ___ROYcms_Blog_model.Time.ToString());
            filed = filed.Replace("{user_id}", ___ROYcms_Blog_model.user_id.ToString());
            filed = filed.Replace("{id}", ___ROYcms_Blog_model.id.ToString());
            return filed;
        }
    }
}
