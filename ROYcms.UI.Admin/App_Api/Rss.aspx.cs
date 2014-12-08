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

namespace ROYcms.UI.Admin.Administrator.App_Api
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Rss : ROYcms.BasePage
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
                
                if (Request["class"] != null)
                {
                    
                    DataSet ds = ___ROYcms_news_Bll.GetList(" classname='" + Request["class"] + "' ");
                    ___ROYcms_class_Model = ___ROYcms_class_Bll._GetModel(Request["class"]);
                    string strRSS = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
                    strRSS = strRSS + "<rss version=\"2.0\">";
                    strRSS = strRSS + "<channel>";
                    strRSS = strRSS + "<title>" + ___ROYcms_class_Model.ClassName + "</title>";
                    strRSS = strRSS + "<link>" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host") + "</link>";
                    strRSS = strRSS + "<description>" + ___ROYcms_class_Model.Description + "</description>";
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        strRSS = strRSS + "<item>";
                        strRSS = strRSS + "<title><![CDATA[" + ds.Tables[0].Rows[i]["title"].ToString().Trim() + "]]></title>";

                        strRSS = strRSS + "<link>" + (ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host") + GetUrl(ds.Tables[0].Rows[i]["bh"].ToString())).Replace("//","/") + "</link> ";
                        strRSS = strRSS + "<description><![CDATA[" + ds.Tables[0].Rows[i]["zhaiyao"].ToString().Trim() + "]]></description>";
                        strRSS = strRSS + "<copyright>" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("Copyright") + "</copyright>";
                        strRSS = strRSS + "</item>";
                    }
                    strRSS = strRSS + "</channel>";
                    strRSS = strRSS + "</rss>";
                    Response.ContentType = "application/xml"; // 输出并按xml数据显示
                    Response.Write(strRSS);
                }
                else { Response.Write("Request[\"class\"] 参数不正确！"); }
            }
        }

        /// <summary>
        /// XML help?
        /// </summary>
        public string GetUrl(string Id)
        {
            string Url = null;
            ROYcms.Sys.BLL.ROYcms_class ___ROYcms_class = new ROYcms.Sys.BLL.ROYcms_class();
            ROYcms.Sys.BLL.ROYcms_news ___ROYcms_news = new ROYcms.Sys.BLL.ROYcms_news();
            ROYcms.Sys.BLL.ROYcms_Url ___ROYcms_Url = new ROYcms.Sys.BLL.ROYcms_Url();
            int ClassId = Convert.ToInt32(___ROYcms_news.GetField(Convert.ToInt32(Id), "classname"));

            string ShowRules = ___ROYcms_class.GetClassField(ClassId, "ShowRules");

            string jumpurl = ___ROYcms_news.GetField(Convert.ToInt32(Id), "jumpurl").Trim();
            ShowRules = ShowRules.Replace("{id}", Id).Replace("{yyyy}/{MM}/{dd}/", "show_");
            if (jumpurl.Length > 2)
            {
                Url = jumpurl;
            }
            else
            {
                if (___ROYcms_Url.Exists_bh(Convert.ToInt32(Id))) { Url = ___ROYcms_Url.GetUrl(Convert.ToInt32(Id)); }
                else
                {
                    Url = (___ROYcms_class.GetClassField(ClassId, "FilePath").Replace("{cmspath}/", "/")) + ShowRules;
                }
            }
            return Url;
        }
    }
}
