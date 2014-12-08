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
    /// AJAXUserReg
    /// </summary>
    public partial class AJAXUserReg : ROYcms.BasePage
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_user Model = new ROYcms.Sys.Model.ROYcms_user();
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //必选
            string valdates = Request["valdates"];      //验证码
            Model.name = Request["name"];               //用户名
            Model.password = Request["password"];       //密码
            Model.email = Request["email"];             //邮箱
            //可选
            Model.username = Request["username"];       //昵称
            Model.sex = Request["sex"];                 //性别  
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

            Response.ContentType = "text/plain";
            Response.Write(UserReg(Model, valdates));   //0,1,-1,-2,-3 分别是 注册失败，注册成功，该用户已经存在，验证码错误，缺少参数

        }
        /// <summary>
        /// UserReg
        /// </summary>
        /// <param name="UserModel"></param>
        /// <param name="valdates"></param>
        /// <returns>0,1,-1,-2,-3 分别是 注册失败，注册成功，该用户已经存在，验证码错误，缺少参数</returns>
        public int UserReg(ROYcms.Sys.Model.ROYcms_user UserModel, string valdates)
        {
            int PER = 0;
            try
            {
                if (UserModel.name != null && UserModel.password != null && UserModel.email != null && valdates != null)
                {
                    if (valdates.Trim().ToUpperInvariant() == ROYcms.Common.Session.Get("code"))
                    {
                        if (!___ROYcms_user_bll.Exists(UserModel.name))
                        {
                            UserModel.password = ROYcms.Common.DESEncrypt.Encrypt(UserModel.password);//对密码进行编码
                            int rt = ___ROYcms_user_bll.Add(UserModel);//添加一条数据返回添加的标识
                            if (rt > 0)
                            {
                                //写入登录日志 
                                this.InsertSystemLog("4", UserModel.name + "新注册会员", UserModel.name + "新注册会员");       //写入日志
                                ROYcms.Common.Session.Add("user_id", rt.ToString());
                                ROYcms.Common.Session.Add("user", UserModel.name);
                                ROYcms.Common.Session.Add("ugroup_id", UserModel.UgroupID);
                                PER = 1;
                            }
                            else { PER = 0; }//注册失败！
                        }
                        else { PER = -1; }//该用户已存在！
                    }
                    else { PER = -2; }//验证码错误！

                }
                else { PER = -3; }//缺少参数！
            }
            catch
            {
                this.InsertSystemLog("5", "普通会员注册失败", "普通会员注册失败");
            }
            return PER;
        }
    }
}
