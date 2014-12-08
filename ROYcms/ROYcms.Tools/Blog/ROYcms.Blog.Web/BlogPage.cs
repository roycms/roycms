using System;
using System.Collections.Generic;
using System.Web;
using System.Net;

namespace ROYcms
{
    public class BlogPage : ROYcms.BasePage
    {
        private string _User_id = null;
        /// <summary>
        /// Gets or sets the user_id. 参数  用户id    blog 的 标识信息  /blog-{user_id}/default.html
        /// </summary>
        /// <value>The user_id.</value>
        public string User_id
        {
            get
            {
                if (_User_id != null)
                {
                    if (Page.Request["user_id"] != null)
                    {
                        _User_id = Page.Request["user_id"];
                    }
                }
                else { if (Page.Request["user_id"] != null) { _User_id = Page.Request["user_id"]; } }
                return _User_id;
            }
            set { _User_id = value; }
        }

        public ROYcms.Blog.Model.ROYcms_blog ___ROYcms_Blog_model = new ROYcms.Blog.Model.ROYcms_blog();
        public ROYcms.Blog.BLL.ROYcms_blog ___ROYcms_Blog_bll = new ROYcms.Blog.BLL.ROYcms_blog();
        public ROYcms.Blog.Model.ROYcms_blog_result ___ROYcms_Blog_result_model = new ROYcms.Blog.Model.ROYcms_blog_result();
        public ROYcms.Blog.BLL.ROYcms_blog_result ___ROYcms_Blog_result_bll = new ROYcms.Blog.BLL.ROYcms_blog_result();
        public ROYcms.Blog.Model.ROYcms_Blog_user ___ROYcms_Blog_user_model = new ROYcms.Blog.Model.ROYcms_Blog_user();
        public ROYcms.Blog.BLL.ROYcms_Blog_user ___ROYcms_Blog_user_bll = new ROYcms.Blog.BLL.ROYcms_Blog_user();
        /// <summary>
        /// ___s the get config value. 获取  BlogConfig.config 配置节信息
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static string ___GetConfigValue(string name)
        {
            return UserControlBlogPage.___GetConfigValue(name);
        }
        /// <summary>
        /// ___s the get user date. 获取 用户信息来自 主站 配置信息在 BlogConfig.config 配置节 GetUserDateUrl 配置
        /// </summary>
        /// <param name="PeopleDate">The people date.</param>
        /// <param name="userid">The userid.</param>
        /// <returns></returns>
        public static string ___GetUserDate(string PeopleDate, string userid)
        {
            return UserControlBlogPage.___GetUserDate(PeopleDate, userid); 
        }
        /// <summary>
        /// ___s the get blog value. 获取博客 xml 信息
        /// </summary>
        /// <param name="user_id">The user_id.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static string ___GetBlogValue(string user_id, string name) 
        {
            return UserControlBlogPage.___GetBlogValue(user_id, name);
        }
    }
    public class UserControlBlogPage : System.Web.UI.UserControl
    {
        private string _User_id = null;
        /// <summary>
        /// Gets or sets the user_id.参数  用户id    blog 的 标识信息  /blog-{user_id}/default.html
        /// </summary>
        /// <value>The user_id.</value>
        public string User_id
        {
            get
            {
                if (_User_id != null)
                {
                    if (Page.Request["user_id"] != null)
                    {
                        _User_id = Page.Request["user_id"];
                    }
                }
                else { if (Page.Request["user_id"] != null) { _User_id = Page.Request["user_id"]; } }
                return _User_id;
            }
            set { _User_id = value; }
        }

        public ROYcms.Blog.Model.ROYcms_blog ___ROYcms_Blog_model = new ROYcms.Blog.Model.ROYcms_blog();
        public ROYcms.Blog.BLL.ROYcms_blog ___ROYcms_Blog_bll = new ROYcms.Blog.BLL.ROYcms_blog();
        public ROYcms.Blog.Model.ROYcms_blog_result ___ROYcms_Blog_result_model = new ROYcms.Blog.Model.ROYcms_blog_result();
        public ROYcms.Blog.BLL.ROYcms_blog_result ___ROYcms_Blog_result_bll = new ROYcms.Blog.BLL.ROYcms_blog_result();
        public ROYcms.Blog.Model.ROYcms_Blog_user ___ROYcms_Blog_user_model = new ROYcms.Blog.Model.ROYcms_Blog_user();
        public ROYcms.Blog.BLL.ROYcms_Blog_user ___ROYcms_Blog_user_bll = new ROYcms.Blog.BLL.ROYcms_Blog_user();

        /// <summary>
        /// ___s the get user date. 获取 用户信息来自 主站 配置信息在 BlogConfig.config 配置节 GetUserDateUrl 配置
        /// </summary>
        /// <param name="PeopleDate">The people date.</param>
        /// <param name="userid">The userid.</param>
        /// <returns></returns>
        public static string ___GetUserDate(string PeopleDate, string userid)
        {
            string da = null;
            try
            {
                WebClient client = new WebClient();
                da = client.DownloadString(___GetConfigValue("GetUserDateUrl") + "?GetUserDate=" + PeopleDate + "&user_id=" + userid);
            }
            catch { da = null; }
            return da;
        }
        /// <summary>
        /// ___s the get config value.获取  BlogConfig.config 配置节信息
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static string ___GetConfigValue(string name)
        {
            try
            {
                return ROYcms.Common.SystemCms.GetXmlValue(HttpContext.Current.Server.MapPath("~/BlogConfig.config"), "ROYcms/Config/" + name);
            }
            catch
            {
                return "";
            }
        }
        /// <summary>
        /// ___s the get blog value. 获取博客 xml信息
        /// </summary>
        /// <param name="user_id">The user_id.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static string ___GetBlogValue(string user_id, string name)
        {
            try
            {
                return ROYcms.Common.SystemCms.GetXmlValue(HttpContext.Current.Server.MapPath("~/App_Data/Blog/" + user_id + ".xml"), "ROYcms/Config/" + name); 
            }
            catch
            {
                return "";
            }
        }
    }
}
