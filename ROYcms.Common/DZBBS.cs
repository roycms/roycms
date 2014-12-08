using System;
using System.Collections.Generic;
using System.Text;

namespace ROYcms.Common
{
    /// <summary>
    /// 
    /// </summary>
  public  class DZBBS
    {
        /// <summary>
        /// Gets the BBS.
        /// </summary>
        /// <param name="URL">The URL.</param>
        /// <param name="BBSurl">The BB surl.</param>
        /// <returns></returns>
        public static string GetBBS(string URL,string gET,string BbsEncoding)
        {
            string content = ROYcms.Common.GetUrlText.GetText(URL + gET, BbsEncoding);
            content = content.Replace("document.write('", "");
            content = content.Replace("');", "");
            content = content.Replace("span", "li");
            content = content.Replace("style=\"background-color: #ffffcc;\"", "");
            content = content.Replace("<a ", "<a target='_blank' ");
            content = content.Replace("../", URL);
            return content;
        }
    }
}
