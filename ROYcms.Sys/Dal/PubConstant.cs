using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace ROYcms.Sys.DAL
{
    class PubConstant
    { /// <summary>
        /// 数据库前缀
        /// </summary>
        public static string date_prefix
        {
            get
            {
                string _date_prefix = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("date_prefix");
                return _date_prefix;


            }
        }
        /// <summary>
        /// 获取当前应用程序指定CacheKey的Cache值
        /// </summary>
        /// <param name="CacheKey"></param>
        /// <returns></returns>
        //public static object GetCache(string CacheKey)
        //{
        //    System.Web.Caching.Cache objCache = HttpRuntime.Cache;
        //    return objCache[CacheKey];

        //}
    }
}
