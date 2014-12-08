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

namespace ROYcms.UI.Admin.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Exists_user : BasePage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (___ROYcms_user_bll.Exists(Request["name"])) { Response.Write("该用户已存在！"); }
            else { Response.Write("恭喜你，该用户可以注册！"); }
        }
    }
}
