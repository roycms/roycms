/**********************************************************************************
 * Description:     
 * MemberVariable:
 * Functions:       
 * Modify information:     
 * 2008-8-5     New           DuYaoHui     Create Class
 * 
 * ********************************************************************************/
using System;

using ROYcms.Common;
using ROYcms.Config;
using ROYcms.UI.Admin;
namespace ROYcms.UCenter
{
    /// <summary>
    /// XML help?
    /// </summary>
    public partial class Administrator_reg : BasePage
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_user Model = new ROYcms.Sys.Model.ROYcms_user();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.UI.Admin.UCenter.AJAXUserReg AJAXUserReg = new ROYcms.UI.Admin.UCenter.AJAXUserReg();
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {}
        /// <summary>
        /// Handles the Click event of the Button_add control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void UserReg_Click(object sender, EventArgs e)
        {
            
            string name = this.txtname.Value;
            string password = this.txtpassword.Value;
            string email = this.txtemail.Value;
            
            string sex =null;
            if (this.xingbie_0.Checked)
            {
                sex = this.xingbie_0.Value;
            }
            else { sex = this.xingbie_0.Value; }

            //必选
            string valdates = yanzhengma.Value;      //验证码
            Model.name = name;               //用户名
            Model.password = password;       //密码
            Model.email = email;             //邮箱
            //可选
            Model.username = Request["username"];       //昵称
            Model.sex = sex;                 //性别  
            Model.age = int.Parse(Request["age"] == null ? "0" : Request["age"]);                 //年龄
            Model.qq = Request["qq"];                   //QQ
            Model.pic = Request["pic"];                 //头像地址 /开头根目录地址
            //初始赋值
            Model.money = 0;                            //
            Model.GUID = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("guid");//获取配置节GUID
            Model.login_time = DateTime.Now;            // 当前时间
            Model.UgroupID = null;                      // 用户组
            Model.RoleID = null;                        // 权限
            Model.quanxian = "Guest";                   // 权限名称
            Model.ip = ROYcms.Common.SystemCms.GetClientIPv4(); //IP地址


            int PER = AJAXUserReg.UserReg(Model, valdates); //0,1,-1,-2,-3 分别是 注册失败，注册成功，该用户已经存在，验证码错误，缺少参数
            string err = null;
            if (PER == 0) { err = "注册失败"; }
            if (PER == 1) { err = "注册成功"; Response.Redirect("/ucenter/default.aspx"); }
            if (PER == -1) { err = "该用户名已经存在"; }
            if (PER == -2) { err = "验证码错误"; }
            if (PER == -3) { err = "缺少参数"; }

            ROYcms.Common.MessageBox.Show(this, err);

            //Response.ContentType = "text/plain";
            //Response.Write(AJAXUserReg.UserReg(Model, valdates));   

        }
    }
}