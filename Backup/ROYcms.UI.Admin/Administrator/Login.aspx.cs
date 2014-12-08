/**********************************************************************************
 * Description:     
 * MemberVariable:
 * Functions:       
 * Modify information:     
 * 2008-8-5     New           DuYaoHui     Create Class
 * 
 * ********************************************************************************/
using System;

using System.Configuration;
//using ROYcms.DB;
using ROYcms.Common;
namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_login_index : BasePage
    {
        /// <summary>
        /// 实例化
        /// </summary>
        ROYcms.Sys.Model.ROYcms_Log ROYcms_Log_model = new ROYcms.Sys.Model.ROYcms_Log();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["page"] = ViewState["page"] == null ? Request["page"] : ViewState["page"];
            }
        }
        /// <summary>
        /// Handles the Click event of the ImageButton1 control.  登录事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Web.UI.ImageClickEventArgs"/> instance containing the event data.</param>
        protected void AdminLogin_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            if (___ROYcms_Admin_bll.Exists(username.Text.Trim(), ROYcms.Common.DESEncrypt.Encrypt(password.Text.Trim())))
            {
                ___ROYcms_Admin_Model = ___ROYcms_Admin_bll.GetModel(username.Text.Trim());

                ROYcms.Common.Session.Add("administrator_id", ___ROYcms_Admin_Model.id.ToString());
                ROYcms.Common.Session.Add("administrator", ___ROYcms_Admin_Model.name);
                string[] administratorValue = { ___ROYcms_Admin_Model.id.ToString(), ___ROYcms_Admin_Model.name, ___ROYcms_Admin_Model.Rol.ToString(), ___ROYcms_Admin_Model.classkind };
                ROYcms.Common.Session.Adds("administrators", administratorValue);
                ROYcms.Common.cooks.SaveCookie("administrator", username.Text.Trim(), 2);
                this.InsertSystemLog("1", username.Text + "管理员登录", username.Text + "管理员登录");       //写入日志
                if (ROYcms.Common.Session.Get("administrator") != null)
                {
                    if (this.ViewState["page"] != null)
                    {
                        Response.Redirect(this.ViewState["page"].ToString());
                    }
                    else
                    {
                        Response.Redirect("~/administrator/index.aspx");
                    }
                }
                else
                {
                    this.InsertSystemLog("5", username.Text + "管理员Session创建失败或者丢失，登录错误", username.Text + "管理员Session创建失败或者丢失，登录错误");       //写入日志
                    MessageBox.Show(this, "未知错误！");
                }
            }
            else
            {
                MessageBox.Show(this, "用户不存在或密码错误！");
            }

        }
    }
}