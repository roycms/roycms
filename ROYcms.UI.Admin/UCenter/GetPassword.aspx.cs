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

namespace ROYcms.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GetPassword : BasePage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_getpassword_Click(object sender, EventArgs e)
        {
            ROYcms.Sys.BLL.ROYcms_user userBll = new ROYcms.Sys.BLL.ROYcms_user();
            string PER = null;
            string username = TextBox_username.Text.Trim();
            if (!userBll.Exists(username))
            {
                PER = "<font style='color:red'>用户不存在！</font>";
            }
            else
            {
                ROYcms.Sys.Model.ROYcms_user users = userBll.GetModel(username);
                string md5P = ROYcms.Common.DESEncrypt.Encrypt(username + "," + DateTime.Now);

                bool sendErr = ROYcms.Common.SystemCms.SendMail("找回密码信息", "请点击该链接<a herf='" + Request.Url.Host + "/UCENTER/update_password.aspx?R=" + md5P + "'>" + Request.Url.Host + "/UCENTER/update_password.aspx?R=" + md5P + "</a>", users.email);//将密码发送到邮箱内
                if (sendErr)
                {
                    PER = "<font style='color:red'>找回密码信息已经发送至你的邮箱！</font>";
                }
                else
                {
                    PER = "<font style='color:red'>发送失败！</font>";
                }
            }
            Response.Write(PER);//输出
        }
    }
}
