using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Web;
using ROYcms.Common;

namespace ROYcms.Templet
{
    /// <summary>
    /// 更新 生成首页类
    /// </summary>
    public class NewIndex:Template
    {
        /// <summary>
        /// 生成首页方法 无参数 News the HTML.
        /// </summary>
        /// <returns></returns>
        public bool NewHtml()
        {
            bool e = false;
            string templatepath = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_file") + "/index.html";             //模版地址
            string HTML = SystemCms.Read_File(HttpContext.Current.Server.MapPath(templatepath), ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"));
            string Path = "~/index.html";                                                              //文件生成地址
            using (StreamWriter sw = new StreamWriter(HttpContext.Current.Server.MapPath(Path), false, Encoding.GetEncoding(ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"))))
            {
                HTML = LoopTag(PublicTag(HTML));
                //创建文件
                try
                {
                    sw.WriteLine(HTML);
                    sw.Flush();
                    e = true;
                }
                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write(ex.Message);
                    HttpContext.Current.Response.End();
                    e = false;
                }
                finally { sw.Close(); }
                return e;
            }
        }
    }
}
