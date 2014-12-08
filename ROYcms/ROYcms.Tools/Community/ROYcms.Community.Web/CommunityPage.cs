using System;
using System.Collections.Generic;
using System.Web;
using System.Net;

namespace ROYcms
{
    public class CommunityPage : ROYcms.BasePage
    {
        public ROYcms.Community.Model.ROYcms_Community ___ROYcms_Community_model = new ROYcms.Community.Model.ROYcms_Community();
        public ROYcms.Community.BLL.ROYcms_Community ___ROYcms_Community_bll = new ROYcms.Community.BLL.ROYcms_Community();
        public ROYcms.Community.Model.ROYcms_Community_result ___ROYcms_Community_result_model = new ROYcms.Community.Model.ROYcms_Community_result();
        public ROYcms.Community.BLL.ROYcms_Community_result ___ROYcms_Community_result_bll = new ROYcms.Community.BLL.ROYcms_Community_result();
        public static string ___GetConfigValue(string name)
        {
            return UserControlCommunityPage.___GetConfigValue(name);
        }
        public static string ___GetUserDate(string PeopleDate, string userid)
        {
            return UserControlCommunityPage.___GetUserDate(PeopleDate, userid);
        }
        
    }
    public class UserControlCommunityPage : System.Web.UI.UserControl
    {
        public ROYcms.Community.Model.ROYcms_Community ___ROYcms_Community_model = new ROYcms.Community.Model.ROYcms_Community();
        public ROYcms.Community.BLL.ROYcms_Community ___ROYcms_Community_bll = new ROYcms.Community.BLL.ROYcms_Community();
        public ROYcms.Community.Model.ROYcms_Community_result ___ROYcms_Community_result_model = new ROYcms.Community.Model.ROYcms_Community_result();
        public ROYcms.Community.BLL.ROYcms_Community_result ___ROYcms_Community_result_bll = new ROYcms.Community.BLL.ROYcms_Community_result();
        public static string ___GetConfigValue(string name)
        {
            try
            {
                return ROYcms.Common.SystemCms.GetXmlValue(HttpContext.Current.Server.MapPath("~/CommunityConfig.config"), "ROYcms/Config/" + name);
            }
            catch
            {
                return "";
            }
        }
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
    }
}
