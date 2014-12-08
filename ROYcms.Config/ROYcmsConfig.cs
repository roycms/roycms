using System.Configuration;
using ROYcms.Common;
using System.Web;

namespace ROYcms.Config
{
    /// <summary>
    /// 得到配置文件信息类 
    /// </summary>
    public class ROYcmsConfig
    {
        /// <summary>
        /// 得到配置文件信息方法  返回 ROYcms.Sys.Model.ROYcmsConfig 
        /// </summary>
        /// <returns></returns>
        public static string GetCmsConfigValue(string name)
        {
            return GetCmsConfigValue(name, "~/administrator/APP_config/index.config");
        }
        public static string GetCmsConfigValue(string name ,string ConfigPath)
        {
            try
            {
                if (HttpContext.Current.Cache["CMSConfig" + name] == null)
                {
                    string ConfigVal = ROYcms.Common.SystemCms.GetXmlValue(HttpContext.Current.Server.MapPath(ConfigPath), "ROYcms/Config/" + name.ToLowerInvariant());
                    HttpContext.Current.Cache.Insert("CMSConfig" + name, ConfigVal);
                }
                return (string)HttpContext.Current.Cache["CMSConfig" + name];
            }
            catch
            {
                return null;
            }
        }

    }
}