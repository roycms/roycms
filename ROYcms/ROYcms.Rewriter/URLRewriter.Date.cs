using System;
using System.Configuration;
using System.Collections;
using System.Data;
using System.Web;

namespace ROYcms.URLRewriter
{
    /// <summary>
    /// 
    /// </summary>
    public class UrlsContent
    {

        /// <summary>
        /// 方法主入口
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="SERVER"></param>
        /// <returns></returns>
        public static string IsUrl(string URL, string SERVER)
        {
            string returnUrl = null;

            //截取URL参数组
            string Paramet = null;
            if (URL.Contains("?"))
            {
                Paramet = (URL.Substring(URL.LastIndexOf("?"), URL.Length - URL.LastIndexOf("?")));
                URL = URL.Substring(0, URL.LastIndexOf("?"));
            }
            //详细页面模式
            if (NewModel(URL))
            {
                returnUrl = IsShowUrl(URL) + (Paramet != null ? Paramet.Replace('?', '&') : null);
            }
            else
            {
                //其他匹配

                if (IsIndexUrl(URL, SERVER) != null)
                {
                    returnUrl = IsIndexUrl(URL, SERVER) + (Paramet != null ? Paramet.Replace('?', '&') : null);
                }
                else { returnUrl = URL + Paramet; }
            }
            return returnUrl;



        }
        /// <summary>
        /// 判断解析内容模式
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool NewModel(string url)
        {
            //读取配置文件的详细页面重写模式
            string NewUrlModel = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("new_url_model");
            if (NewUrlModel == "" || NewUrlModel == null) { NewUrlModel = "show"; }
            if (url.Length < 6) 
            { 
                return false;
            }
            else
            {
                if (url.Contains(NewUrlModel.ToLower()))
                {
                    int StarI = url.LastIndexOf("/");
                    if (url.Substring(StarI + 1, 4).ToLower() == NewUrlModel.ToLower())
                    {
                        return true;
                    }
                    else { return false; }
                }
                else { return false; }
            }
        }

        /// <summary>
        /// 目录和分页重写方法
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public static string IsIndexUrl(string URL ,string SERVER)
        {
            ROYcms.Sys.BLL.ROYcms_class ClassBll = new ROYcms.Sys.BLL.ROYcms_class();

            string SQL_where = null;
           
            //判断是主域名
            if (("http://" + SERVER + "/").ToLowerInvariant() != ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host").ToLowerInvariant()) 
            { 
                SQL_where = "FilePath ='" + FormatUrl(URL)[0] + "' and DefaultFile='" + FormatUrl(URL)[1]+"' and WebsiteUrl='" + SERVER.ToLowerInvariant() + "' "; 
            }
            else { SQL_where = "FilePath ='" + FormatUrl(URL)[0] + "' and DefaultFile='" + FormatUrl(URL)[1]+"' and WebsiteUrl='' "; }

            string TemplateIndex = ClassBll.GetClassField(SQL_where, "TemplateIndex");

            if (TemplateIndex != null)
            {
                return TemplateIndex + "?class=" + ClassBll.GetClassField(SQL_where, "id");
            }
            else { return null; }


        }
   
        /// <summary>
        /// 文章详细页面重写
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public static string IsShowUrl(string URL)
        {

            ROYcms.Sys.BLL.ROYcms_news NewBll = new ROYcms.Sys.BLL.ROYcms_news();
            ROYcms.Sys.BLL.ROYcms_class ClassBll = new ROYcms.Sys.BLL.ROYcms_class();
          

            string NewUrlModel = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("new_url_model");
            if (NewUrlModel == "" || NewUrlModel == null) { NewUrlModel = "show"; }

            if (URL.Contains("/" + NewUrlModel + "_"))
            {
                string[] Parameters = URL.Substring(URL.LastIndexOf("/" + NewUrlModel + "_") + 6, URL.LastIndexOf(".") - (URL.LastIndexOf("/" + NewUrlModel + "_") + 6)).Split('_');
                string ClassId = Convert.ToString(NewBll.GetClassName(Convert.ToInt32(Parameters[0])));
             
                string NewPath = ClassBll.GetClassField(Convert.ToInt32(ClassId), "TemplateShow"); ;
                if (NewPath != "")
                {
                    if (Parameters.Length > 1)
                    {
                        NewPath = NewPath + String.Format("?id={0}&class={1}&page={2}", Parameters[0], ClassId, Parameters[1]);
                    }
                    else { NewPath = NewPath + String.Format("?id={0}&class={1}", Parameters[0], ClassId); }

                    return NewPath;
                }
                else { return null; }
            }
            else { return URL; }
        }
     
        /// <summary>
        /// 格式化路径
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public static string[] FormatUrl(string URL)
        {
            int StarI = URL.LastIndexOf("/") + 1;
            string[] U = { "{cmspath}" + URL.Substring(0, StarI), URL.Substring(StarI, URL.Length - StarI) };
            return U;
        }


    }
}