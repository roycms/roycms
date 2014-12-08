using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.CMS
{
    public partial class ApplyFor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int PRE = 0;
            string Email = ROYcms.Common.Request.GetFormString("email");
            string Title = "ROYcms申请试用邮件通知";
            string Contents = @"
                               <h2>感谢您对ROYcms的关注！</h2>
                                演示站点地址：http://demo.roycms.cn <br>
                                会员中心登录地址：http://www.roycms.cn/ucenter/login.aspx <br>
                                后台登录地址：http://demo.roycms.cn/administrator/login.aspx <br>
                                总管理账户：roy <br>
                                密码：roy <br>
                                会员中心账户：" + Request["name"] + @"<br>
                                密码：" + Request["password"] + @"<br>
                                <hr>
                                公司：北京郎子文化 <br>
                                联系人：杜耀辉 <br>
                                手机：13466551901 <br>
                              ";

            if (ROYcms.Common.SystemCms.SendMail(Title, Contents, Email)) 
            {
                PRE = 1;
            }

            Response.ContentType = "text/plain";
            Response.Write(PRE);

        }
    }
}