using System;
using System.Collections;
using System.Configuration;
using System.Data;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// CMS入口
    /// </summary>
    public partial class Index : ROYcms.BasePage
    {
        /// <summary>
        /// 是否是静态生成
        /// </summary>
        public static bool IsStatic = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("html") == "true" ? true : false; //是否是静态生成
        /// <summary>
        /// 模板编码
        /// </summary>
        public static string EncodIng = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"); //模板编码
        /// <summary>
        /// 域名 格式 www.roycms.cn
        /// </summary>
        public static string DoMain = new ROYcms.Templet.IndexDate().GetDoMain(); //域名
        /// <summary>
        /// 站点域名 格式 www.roycms.cn
        /// </summary>
        public static string CMSDoMain = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host").Replace("http://", "").Replace("/", ""); //域名
        /// <summary>
        /// CMS入口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CMSDoMain != DoMain) //非CMS主域名
            { IsStatic = false; } //禁止静态浏览站点

            if (!IsStatic)//未启用静态浏览
            {
                string HTML = new ROYcms.Templet.Index().CmsMain();
                if (HTML == null)
                {
                    InsertSystemLog("5", "CMS读取模板失败/模板文件不存在或模板标记不正确", "CMS读取模板失败/模板文件不存在或模板标记不正确");
                    HTML = "CMS读取模板失败/模板文件不存在或模板标记不正确";
                }
                Response.Write(HTML);
            }
            else //启用静态
            {
                if (ROYcms.Common.Request.GetQueryString("index") == "Index")
                {
                    Response.Write(ROYcms.Common.SystemCms.Read_File(Server.MapPath("/index.html"), EncodIng));
                }
                else
                {
                
                    Response.Write("CMS后台已经启用静态浏览，该动态地址将无法返回数据。");
                }
            }
        }
    }
}
