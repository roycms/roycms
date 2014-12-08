using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ROYcms.Templet
{
   public  class UrlRewriter
    {
      
        /// <summary>
        /// _s the URL rewriter.//返回重写之前的原始的URL 
        /// </summary>
        /// <param name="UrlRewriter">The URL rewriter.</param>
        /// <returns></returns>
       public static string _UrlRewriter(string UrlRewriter)
        {
            if (UrlRewriter != null)
            {
                ROYcms.Sys.BLL.ROYcms_UrlRewriter BLL = new ROYcms.Sys.BLL.ROYcms_UrlRewriter();
                if (BLL.GetValue("new_url='" + UrlRewriter + "'") != null)
                {
                    return BLL.GetValue("new_url='" + UrlRewriter + "'").ToString();
                }
                else
                {
                    return null;
                }
            }
            else { return null; }
        }
    }
}
