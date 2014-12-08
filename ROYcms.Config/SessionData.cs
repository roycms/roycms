using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
namespace ROYcms.Config
{
    /// <summary>    
    /// 所有session中的数据，在该类管理    
    /// </summary>    
    public class SessionData
    {
        public static string SessionKey = null;
        //private static ROYcms.Config.UserInfo _UserInfo;
        //public static ROYcms.Config.UserInfo UserInfo
        //{
        //    set { _UserInfo = value; }
        //    get { return _UserInfo; }
        //}
        
        // <summary>    
        // 获取session 中的 用户信息        
        // </summary>       
        /// <returns></returns>        
        //public static ROYcms.Config.UserInfo GetUserInfo()
        //{
        //    ROYcms.Common.Session.Get(SessionKey);
        //    return ROYcms.Config.UserInfo;
        //}
        /// <summary>        
        /// 重新设置session 中的用户信息  
        /// /// </summary>       
        /// /// <param name="userInfo"></param>     
        public static void SetUserInfo(ROYcms.Config.UserInfo UserInfo)
        {
            ROYcms.Common.Session.Add(SessionKey, (object)UserInfo);
        }
        /// <summary>      
        /// /// 清楚session中用户信息   
        /// /// </summary>       
        public static void ClearUserInfo()
        {
            ROYcms.Common.Session.Del(SessionKey);
        }
        /// <summary>      
        /// /// 是否登入     
        /// /// </summary>     
        /// /// <returns></returns>      
        public static bool IsLogin()
        {
            if (ROYcms.Common.Session.Get(SessionKey) != null)
            {
                if (ROYcms.Common.cooks.GetCookie(SessionKey) == null)
                {
                    ROYcms.Common.cooks.SaveCookie(SessionKey, ROYcms.Common.Session.Get(SessionKey), 2);
                }
                return true;
            }
            else { return false; }
        }
    }
}
