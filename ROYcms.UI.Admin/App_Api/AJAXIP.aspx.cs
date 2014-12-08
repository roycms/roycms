using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ROYcms.UI.Admin.App_Api
{
    /// <summary>
    /// 
    /// </summary>
    public partial class IP : BasePage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
           string con= ROYcms.Common.GetUrlText.GetContent("http://www.ip138.com/ips.asp?ip="+Request["ip"]+"&action=2", "<ul class=\"ul1\"><li>", "</li></ul>", "gb2312");
           Response.Write("<h3>ip138提供数据</h3>");
           Response.Write(con.Replace("</li><li>", "<br>"));
        }
    }
}
