using System;
using System.Collections.Generic;
using System.Web;
using System.Net;

namespace ROYcms
{
    public class AskPage : ROYcms.BasePage
    {
        public ROYcms.Ask.Model.ROYcms_question ___ROYcms_question_model = new ROYcms.Ask.Model.ROYcms_question();
        public ROYcms.Ask.BLL.ROYcms_question ___ROYcms_question_bll = new ROYcms.Ask.BLL.ROYcms_question();
        public ROYcms.Ask.Model.ROYcms_result ___ROYcms_result_model = new ROYcms.Ask.Model.ROYcms_result();
        public ROYcms.Ask.BLL.ROYcms_result ___ROYcms_result_bll = new ROYcms.Ask.BLL.ROYcms_result();
        public static string ___GetUserDate(string PeopleDate, string userid)
        {
            string da = null;
            try
            {
                WebClient client = new WebClient();
                da = client.DownloadString(___GetConfigValue("GetUserDateUrl") + "?GetUserDate=" + PeopleDate + "&user_id=" + userid);
            }
            catch { da = null; }
            return da;
        }
        public static string ___GetConfigValue(string name)
        {
            return UserControlAskPage.___GetConfigValue(name);
        }
    }
    public class UserControlAskPage : System.Web.UI.UserControl
    {
        public static string ___GetConfigValue(string name)
        {
            try
            {
                return ROYcms.Common.SystemCms.GetXmlValue(HttpContext.Current.Server.MapPath("~/AskConfig.config"), "ROYcms/Config/" + name);
            }
            catch
            {
                return "";
            }
        }
    }
}
