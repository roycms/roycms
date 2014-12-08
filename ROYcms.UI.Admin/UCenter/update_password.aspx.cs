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
    public partial class update_password : BasePage
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_user Bll = new ROYcms.Sys.BLL.ROYcms_user();
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
        protected void Button_update_password_Click(object sender, EventArgs e)
        {
            string SessionUserId = ROYcms.Common.Session.Get("user_id");
            string SessionUser = ROYcms.Common.Session.Get("user");
            string PER = null;
            if (SessionUserId != null)
            {
                if (new ROYcms.Sys.BLL.ROYcms_user().Exists(SessionUser, ROYcms.Common.DESEncrypt.Encrypt(old_password.Text)))
                {
                    if (password1.Text == password2.Text)
                    {
                        Bll.Update_password(Convert.ToInt32(SessionUserId), ROYcms.Common.DESEncrypt.Encrypt(password1.Text));//修改为新的密码 
                        PER = "更改密码成功";
                    }
                    else { PER = "重复输入密码不正确"; }
                }
                else { PER = "您输入的原密码不正确！"; }
            }
            else
            {
                old_password.Visible = false;
                if (password1.Text == password2.Text)
                {
                    string md5P = Request["R"];
                    if (md5P != null)
                    {
                        md5P = ROYcms.Common.DESEncrypt.Decrypt(md5P);
                        string username = md5P.Split(',')[0];
                        DateTime datetime = Convert.ToDateTime(md5P.Split(',')[1]);

                        TimeSpan span = datetime.Subtract(DateTime.Now);
                        if (span.Days < 1)//找回密码链接超过一天 24小时即可过期
                        {
                            Bll.Update_password(username, ROYcms.Common.DESEncrypt.Encrypt(password1.Text));  //修改为新的密码 
                            PER = "更改密码成功";
                        }
                        else { PER = "链接过期！"; }

                    }
                    else { PER = "Md5参数错误！"; }
                }
                else { PER = "重复输入密码不正确"; }
            }

            Response.Write(PER);//    输出
        }
    }
}
