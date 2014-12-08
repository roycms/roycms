using System;

namespace ROYcms
{
    /// <summary>
    /// 
    /// </summary>
    public class UserPage : ROYcms.BasePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPage"/> class.
        /// </summary>
        public UserPage()
        {}
        /// <summary>
        /// pageunload事件，并不是指浏览器关闭，而是指页面关闭，所以刷新的时候，依然会执行以下事件       
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Unload(object sender, EventArgs e)
        { }
        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
            ROYcms.Config.SessionData.SessionKey = "user";
            if (!ROYcms.Config.SessionData.IsLogin())
            {
                //这里写 跳转到登陆页面：例如：
                Response.Redirect(string.Format("~/ucenter/login.aspx?Page={0}", Request.Path));
            }
        }
    }
}