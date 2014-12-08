#define Index
using System;
using System.Collections;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
#if (Index)
namespace ROYcms.WebService
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://www.roycms.cn/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class Update : IHttpHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public void ProcessRequest(HttpContext context)
        {
            //获取最新版本号
            if (context.Request["i"] == "Version")
            {
                context.Response.ContentType = "text/plain";
                context.Response.Write("2.77");
            }
            //获取安装压缩包下载地址
            else if (context.Request["i"] == "Install_ROYcms_Path")
            {
                context.Response.ContentType = "text/plain";
                context.Response.Write("http://www.roycms.cn/UpdateFile/Install_ROYcms.zip");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
#endif 