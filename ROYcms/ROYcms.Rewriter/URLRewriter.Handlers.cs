using System;
using System.Web;
using System.Text.RegularExpressions;
using System.Configuration;
using URLRewriter.Config;
using System.Data;
using System.Web.UI;
using System.Web.SessionState;

namespace ROYcms.URLRewriter
{





    //public class RewriterHandlers : PageHandlerFactory, IRequiresSessionState
    //{

    //    public RewriterHandlers()
    //    {
    //        //  		// TODO: 在此处添加构造函数逻辑  		//  	
    //    }

    //    //public override IHttpHandler GetHandler(HttpContext context, string requestType, string virtualPath, string path)
    //    //{
    //    //    //进行预先处理的代码       
    //    //    return base.RewriterHandlers(context, requestType, virtualPath, path);
    //    //}

    //    public override IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated)
    //    {
    //        PageHandlerFactory factory = (PageHandlerFactory)Activator.CreateInstance(typeof(PageHandlerFactory), true);
    //        IHttpHandler handler = factory.GetHandler(context, requestType, url, pathTranslated);
    //        Page page = handler as Page;
    //        page.Init += new EventHandler(page_Init);
    //        return handler;
    //    }

    //    void page_Init(object sender, EventArgs e)
    //    {
    //        //直接可以使用HttpContext.Current.Session
    //    }
    //}


    public class RewriterHandlers : IHttpHandler
    {
        /// <summary>
        /// 
        /// </summary>
        public bool IsReusable
        {
            get { return true; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public void ProcessRequest(HttpContext Context)
        {
            string requestedPath = Context.Request.Path;
            string SERVER = Context.Request.Url.Host;
            // get the pattern to look for, and Resolve the Url (convert ~ into the appropriate directory)
            string lookFor = "^" + RewriterUtils.ResolveUrl(Context.Request.ApplicationPath, requestedPath) + "$";
             Regex re = new Regex(lookFor, RegexOptions.IgnoreCase);
             if (re.IsMatch(requestedPath))
             {
                 string Url = ROYcms.URLRewriter.UrlsContent.IsUrl(requestedPath, SERVER);//返回重写后的URL 如果没有返回原始url

                 Context.Server.Execute(Url);
             }

        }
    }


}
