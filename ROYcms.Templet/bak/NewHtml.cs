using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.IO;

namespace ROYcms.Templet
{
   public class NewHtml
    {

        /// <summary>
        /// _s the new HTML.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="config">The config.</param>
       public static void _NewHtml(HttpContext context, ROYcms.Sys.Model.ROYcmsConfig config)
       {
           TemplateTag Template = new TemplateTag(config);
           //判断是否有当前路径如果有添，如果没有新建目录
           if (config.HTML == "true" && context.Request["type"] == "show")
           {
               string Date = context.Request["date"];
               StringBuilder path = new StringBuilder();
               path.Append("~/HTML/");
               if (Date != null)
               {
                   path.Append(Date.Substring(0, 4));
                   path.Append("/");

                   path.Append(Date.Substring(4, 2));
                   path.Append("/");
               }
               if (context.Request["templet"] != null)
               {
                   path.Append(context.Request["templet"]);
                   path.Append("_");
               }
               string tempath = HttpContext.Current.Server.MapPath(path.ToString());
               if (!Directory.Exists(tempath))
               {
                   Directory.CreateDirectory(tempath);
               }
               string file_path = HttpContext.Current.Server.MapPath(path.ToString() + context.Request["id"] + ".html");
               if (!File.Exists(file_path))
               {
                   //不存在
                   context.Response.ContentType = "text/html";
                   context.Response.Write(Template.ArticlsHtml(context));
                   //生成静态文件
                   ROYcms.Common.SystemCms.CreateFile(file_path, Template.ArticlsHtml(context),config.templet_language);
               }
               else
               {
                   //存在
                   context.Server.Execute(path.ToString() + context.Request["id"] + ".html");
               }

           }
           else if (context.Request["type"] == "Dissertation")
           {



           }
           else
           {

               context.Response.ContentType = "text/html";
               context.Response.Write(Template.ArticlsHtml(context));

           }
         
       }
      
    }
}
