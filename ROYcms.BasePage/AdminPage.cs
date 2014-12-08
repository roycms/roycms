
using ROYcms.Common;
using System.Web;
using System;
namespace ROYcms
{
    /// <summary>
    /// 
    /// </summary>
    public class AdminPage : ROYcms.BasePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminPage"/> class.
        /// </summary>
        public AdminPage()
        { }
        /// <summary>
        /// /pageunload事件，并不是指浏览器关闭，而是指页面关闭，所以刷新的时候，依然会执行以下事件      
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Unload(object sender, EventArgs e)
        { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
            ROYcms.Config.SessionData.SessionKey = "administrator";
            if (!ROYcms.Config.SessionData.IsLogin())
            {
                //这里写 跳转到登陆页面：例如：
                Response.Redirect(string.Format("~/administrator/login.aspx?Page={0}", Request.RawUrl));
            }
            //操作权限判断
            //string URL = Request.RawUrl;
            //if (URL.Contains("?"))
            //{
            //    URL = URL.Substring(0, URL.LastIndexOf("?"));
            //}
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="RoleId"></param>
        /// <param name="ClassId"></param>
        /// <param name="ClassKind"></param>
        public void ISRole(string JID, int ClassId, string ClassKind)
        {
            ROYcms.Sys.BLL.ROYcms_Jurisdiction Bll = new Sys.BLL.ROYcms_Jurisdiction();
            int AdminId = Convert.ToInt32(ROYcms.Common.Session.Get("administrator_id"));
            int Rol = Convert.ToInt32(ROYcms.Common.Session.Get("administrator_Rol"));

            if (Rol > 0) //非全权限管理员
            {
                if (Rol == 1) //部分权限管理员
                {
                    if (!(Bll.GetList(" JID='" + JID + "' AND AdminID=" + AdminId + " AND ClassID=" + ClassId + " AND ClassKind=" + ClassKind).Tables[0].Rows.Count > 0))
                    {
                        Response.Redirect(string.Format("~/administrator/Message.aspx?z=no&message={0}", "没有权限操作！"));
                    }
                }
                else //发布员/审稿员
                {
                    Response.Redirect(string.Format("~/administrator/Message.aspx?z=no&message={0}", "没有系统操作权限！"));
                }
            }

        }
    }
}
