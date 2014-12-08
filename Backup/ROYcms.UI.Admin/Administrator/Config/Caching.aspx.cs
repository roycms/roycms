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

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_config_Caching : AdminPage
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            show();
        }

       
        /// <summary>
        ///  //显示所有缓存 Shows this instance.
        /// </summary>
        void show()
        {
            string str = "";
            IDictionaryEnumerator CacheEnum = HttpRuntime.Cache.GetEnumerator();

            while (CacheEnum.MoveNext())
            {
                str += "缓存名<b>[" + CacheEnum.Key + "]</b><br />";
            }
            this.Label1.Text = "当前网站总缓存数:" + HttpRuntime.Cache.Count + "<br />" + str;
        }
        /// <summary>
        /// Handles the delete event of the Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Button_delete(object sender, EventArgs e)
        {
            ROYcms.Common.SystemCms.RemoveAllCache();//清除全局缓存
            show();
        }
    }
}