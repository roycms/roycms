using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Blog.Web.App_Blog
{
    public partial class EditPost : BlogPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Add();
        }
        void Add()
        {
            string user_id = ROYcms.Common.Session.Get("user_id");
            string tag = Request["tag"];
            string Title = Request["title"];
            string keyword = Request["keyword"];
            string Description = Request["description"];
            string content = Request["content"];
            DateTime Time = DateTime.Now;
            if (user_id != null && Title != null)
            {
                ___ROYcms_Blog_model.user_id = int.Parse(user_id);
                ___ROYcms_Blog_model.tag = tag;
                ___ROYcms_Blog_model.Title = Title;
                ___ROYcms_Blog_model.Keyword = keyword;
                ___ROYcms_Blog_model.Description = Description;
                ___ROYcms_Blog_model.content = content;
                ___ROYcms_Blog_model.Time = Time;
                ___ROYcms_Blog_bll.Add(___ROYcms_Blog_model);

                ROYcms.Common.MessageBox.Show(this, "保存成功！");
            }
        }
       public string Show(string filed)
        {
            if (Request["Edit"] != null)
            {
                ___ROYcms_Blog_model = ___ROYcms_Blog_bll.GetModel(Convert.ToInt32(Request["Edit"]));
                filed = filed.Replace("{title}", ___ROYcms_Blog_model.Title);
                filed = filed.Replace("{content}", ___ROYcms_Blog_model.content);
                filed = filed.Replace("{tag}", ___ROYcms_Blog_model.tag);
                filed = filed.Replace("{keyword}", ___ROYcms_Blog_model.Keyword);
                filed = filed.Replace("{description}", ___ROYcms_Blog_model.Description);
            }
            else { filed = ""; }
            return filed;
        }
    }
}
