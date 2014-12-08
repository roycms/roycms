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

namespace ROYcms.Install.Install
{
    public partial class Succeed : System.Web.UI.Page
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// 转到前台首页  Handles the Click event of the Button_Succeed control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Button_Succeed_Click(object sender, EventArgs e)
        {
            if (DelInstallFile())
            {
                Page.Response.Redirect("~/index.html");
            }
            else { Response.Write("删除安装目录文件错误！ 请手动删除！"); }
        }

        /// <summary>
        ///转到后台首页  Handles the Click event of the Button_Succeed_admin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Button_Succeed_admin_Click(object sender, EventArgs e)
        {
            if (DelInstallFile())
            {
                Page.Response.Redirect("~/administrator/login.aspx");
            }
            else { Response.Write("删除安装目录文件错误！ 请手动删除！"); }
        }
        /// <summary>
        /// 删除安装目录 Dels the install file.
        /// </summary>
        bool DelInstallFile() 
        {
            bool err = false;
            if (CheckBox_Del.Checked)
            {
                try
                {
                    System.IO.Directory.Delete(Server.MapPath("~/Install/"), true);
                    System.IO.File.Delete(Server.MapPath("~/Bin/ROYcms.Install.dll"));
                    err = true;
                }
                catch
                {
                    err = false;
                }
            }
            else { err = true; }
            return err;
        }
    }
}
