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
    /// AJAXLogin
    /// </summary>
    public partial class AJAXLogin : ROYcms.BasePage
    {
        ROYcms.Sys.Model.UserLogin Model = new ROYcms.Sys.Model.UserLogin();
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Model.username = Request["username"];//用户名
            if (ROYcms.Common.PageValidate.IsEmail(Model.username)) { Model.username = new ROYcms.Sys.BLL.ROYcms_user().GetUserName(Model.username); } //邮箱
            Model.password = Request["password"];//密码
            Model.k = Request["k"];              //是否快捷开关
            Model.valdates = Request["valdates"];//验证码
            Model.Url = ROYcms.Common.Session.Get("HistoryUrl");//返回地址
            Response.ContentType = "text/plain";
            Response.Write(UserLogin(Model));    // 1,0,-1,-2,-8 分别是 验证成功，用户名密码错误，验证码错误，参数不完整，未知错误
        }
       /// <summary>
       /// 登录接口方法
       /// </summary>
       /// <param name="UserModel"></param>
        /// <returns>1,0,-1,-2,-8 分别是 验证成功，用户名密码错误，验证码错误，参数不完整，未知错误</returns>
        public int UserLogin(ROYcms.Sys.Model.UserLogin UserModel)
        {
            int PER = 0;
            try
            {
                if (UserModel.k != null || ROYcms.Common.Session.Get("code") == null) { UserModel.valdates = "0"; ROYcms.Common.Session.Add("code", "0"); } //快捷登陆
                if (UserModel.username != null && UserModel.password != null && UserModel.valdates != null)
                {
                    UserModel.username = UserModel.username.Trim();
                    if (UserModel.valdates.ToUpperInvariant() == ROYcms.Common.Session.Get("code"))
                    {
                        //子站验证成功
                        bool IsLogin = ___ROYcms_user_bll.Exists(UserModel.username, ROYcms.Common.DESEncrypt.Encrypt(UserModel.password));

                        if (IsLogin)
                        {
                            ___ROYcms_user_model = ___ROYcms_user_bll.GetModel(UserModel.username);     //获取用户数据
                            //创建session
                            ROYcms.Common.Session.Add("GUID", ___ROYcms_user_model.GUID);
                            ROYcms.Common.Session.Add("user_id", ___ROYcms_user_model.bh.ToString());
                            ROYcms.Common.Session.Add("ugroup_id", ___ROYcms_user_model.UgroupID);
                            ROYcms.Common.Session.Add("user", ___ROYcms_user_model.name);
                            //创建session数组
                            string[] UserValue = { ___ROYcms_user_model.GUID, ___ROYcms_user_model.bh.ToString(), ___ROYcms_user_model.UgroupID, ___ROYcms_user_model.name };
                            ROYcms.Common.Session.Adds("Users", UserValue);
                            //写入登录日志 
                            this.InsertSystemLog("2", UserModel.username + "会员登录", UserModel.username + "会员登录");       //写入日志
                            PER = 1;
                        }
                        else { PER = 0; }//用户名或密码错误
                    }
                    else { PER = -1; }//验证码错误！
                }
                else { PER = -2; }//参数不完整
            }
            catch
            {
                //未知错误
                PER = -8;
                //写入登录日志 
                this.InsertSystemLog("5", "会员登录未知错误", "会员登录未知错误");       //写入日志
            }
            return PER;
        }
    }
}
