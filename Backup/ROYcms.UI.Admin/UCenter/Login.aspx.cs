using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.UCenter
{
    /// <summary>
    /// Login
    /// </summary>
    public partial class Login : BasePage
    {
        ROYcms.Sys.Model.UserLogin Model = new ROYcms.Sys.Model.UserLogin();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.UI.Admin.UCenter.AJAXLogin AJAXLogin = new ROYcms.UI.Admin.UCenter.AJAXLogin();
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
                Model.username = Request["username"];//用户名
                Model.password = Request["password"];//密码
                Model.k = Request["k"];              //是否快捷开关
                Model.valdates = Request["valdates"];//验证码
                Model.Url = Request["HistoryUrl"];//返回地址


                int PER = AJAXLogin.UserLogin(Model);  // 1,0,-1,-2,-8 分别是 验证成功，用户名密码错误，验证码错误，参数不完整，未知错误
                string err = null;
                if (PER == 0) { err = "用户名密码错误"; }
                if (PER == 1) { err = "验证成功"; Response.Redirect("/ucenter/default.aspx"); }
                if (PER == -1) { err = "验证码错误"; }
                if (PER == -2) { err = "参数不完整"; }
                else { err = "未知错误"; }

                //Response.Write(err);
                ROYcms.Common.MessageBox.Show(this, err); 
            //}
            
        }
    }
}
