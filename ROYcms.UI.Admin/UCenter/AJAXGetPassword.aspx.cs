using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.UCenter
{
    public partial class AJAXGetPassword : System.Web.UI.Page
    { 
       public  ROYcms.Sys.BLL.ROYcms_user BLL = new ROYcms.Sys.BLL.ROYcms_user();
       public ROYcms.Sys.Model.ROYcms_user Model = new Sys.Model.ROYcms_user();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "text/plain";
            Response.Write(GETpassword().ToString());//输出
        }

        public int GETpassword() {

            int PER = 0;
            string username = ROYcms.Common.Request.GetFormString("username");
            if (BLL.Exists(username))
            {
                Model = BLL.GetModel(username);
                string md5P = ROYcms.Common.DESEncrypt.Encrypt(username + "," + DateTime.Now);

                bool sendErr = ROYcms.Common.SystemCms.SendMail("找回密码信息", "请点击该链接<a herf='" + Request.Url.Host + "/UCENTER/update_password.aspx?R=" + md5P + "'>" + Request.Url.Host + "/UCENTER/update_password.aspx?R=" + md5P + "</a>", Model.email);//将密码发送到邮箱内
                if (sendErr)
                {
                    PER = 1;
                }
                else
                {
                    PER = -1;
                }
            }
            return PER;
           
        
        }
    }
}