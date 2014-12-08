using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

namespace ROYcms.Blog.Web.App_Blog.Admin
{
    public partial class Config : BlogPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {}
        protected void SAVE_Click(object sender, EventArgs e)
        {
            bool err = false;
            string path = "~/App_Data/Blog/";
            if (!Directory.Exists(Server.MapPath(path)))
            {
                Directory.CreateDirectory(Server.MapPath(path));//创建新路径 
            }
            if (Request["BlogTitle"] != null)
            {
                err = ROYcms.Common.SystemCms.NewXml(this, Server.MapPath(path + ROYcms.Common.Session.Get("user_id") + ".xml"), "ROYcms/Config");
            }
            if (err) 
            {
                SendBlog();
                ROYcms.Common.MessageBox.Show(this, "保存成功！");
            }
            else { ROYcms.Common.MessageBox.Show(this, "保存失败！"); }

        }

        /// <summary>
        /// Sends the blog.//添加到库中 申请博客方法
        /// </summary>
        /// <returns></returns>
        bool SendBlog() 
        {
            string user_id = ROYcms.Common.Session.Get("user_id");
            string BlogTitle = Request["BlogTitle"];
            string Keyword = Request["KeyWord"];
            string Description = Request["Description"];
            DateTime Time = DateTime.Now;
            
            ___ROYcms_Blog_user_model.user_id = int.Parse(user_id);
            ___ROYcms_Blog_user_model.BlogTitle = BlogTitle;
            ___ROYcms_Blog_user_model.Keyword = Keyword;
            ___ROYcms_Blog_user_model.Description = Description;
            ___ROYcms_Blog_user_model.Time = Time;
            if (!___ROYcms_Blog_user_bll.Exists(user_id))
            {
                ___ROYcms_Blog_user_bll.Add(___ROYcms_Blog_user_model);
            }
            else { ___ROYcms_Blog_user_bll.Update_user_id(___ROYcms_Blog_user_model); }
            return true;
        }
    }
}
