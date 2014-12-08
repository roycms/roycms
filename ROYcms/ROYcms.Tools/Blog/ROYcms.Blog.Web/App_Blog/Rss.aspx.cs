using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ROYcms.Blog.Web.App_Blog
{
    public partial class Rss : BlogPage
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = ___ROYcms_Blog_bll.GetList("user_id="+Request["user_id"]);
                string strRSS = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
                strRSS = strRSS + "<rss version=\"2.0\">";
                strRSS = strRSS + "<channel>";
                strRSS = strRSS + "<title>"+___GetBlogValue(this.User_id,"BlogTitle")+"</title>";
                strRSS = strRSS + "<link>" + ___GetBlogValue(this.User_id, "URL") + "</link>";
                strRSS = strRSS + "<description>" + ___GetBlogValue(this.User_id, "Description") + "</description>";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    strRSS = strRSS + "<item>";
                    strRSS = strRSS + "<title><![CDATA[" + ds.Tables[0].Rows[i]["Title"].ToString().Trim() + "]]></title>";
                    strRSS = strRSS + "<link>/blog-" + this.User_id +"/blog/"+ ds.Tables[0].Rows[i]["id"] + ".html</link> ";
                    strRSS = strRSS + "<description><![CDATA[" + ds.Tables[0].Rows[i]["content"].ToString().Trim() + "]]></description>";
                    strRSS = strRSS + "<copyright></copyright>";
                    strRSS = strRSS + "</item>";
                }
                strRSS = strRSS + "</channel>";
                strRSS = strRSS + "</rss>";
                Response.ContentType = "application/xml"; // 输出并按xml数据显示
                Response.Write(strRSS);

            }
        }
    }
}
