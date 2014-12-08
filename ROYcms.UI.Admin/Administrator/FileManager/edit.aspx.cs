/**********************************************************************************
 * Description:     
 * MemberVariable:
 * Functions:       
 * Modify information:     
 * 2008-8-5     New           DuYaoHui     Create Class
 * 
 * ********************************************************************************/
using System;

using System.IO;
using ROYcms.Common;
namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FileManager_edit : AdminPage
    {

        #region path 属性
        /// <summary>
        /// 
        /// </summary>
        protected string path
        {
            get
            {
                return (string)ViewState["path"];
            }
            set
            {
                ViewState["path"] = value;
            }
        }
        #endregion
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack && Request["page"] != null)
            {
                this.path = Request["page"]; if (type())
                {
                  TextBox_HTML.Text =  HTML();
                  //FCKeditor1.Value = HTML();
                }
                else { ROYcms.Common.MessageBox.Show(this, "你没有权限！"); }
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string HTML()
        {
            string htmlCONTENT = null;
            if (path.Contains(":"))
            {
                htmlCONTENT = SystemCms.Read_File(this.path, ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"));
            }
            else
            {
                htmlCONTENT = SystemCms.Read_File(Server.MapPath(this.path), ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"));
            }
            return htmlCONTENT;
        }
        /// <summary>
        /// Types this instance.
        /// </summary>
        /// <returns></returns>
        public bool type()
        {
            int r = 0;
            string[] RootArray =ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("filemanager_file_type").Split(',');
            for (int i = 0; i < RootArray.Length; i++)
            {
                r += path.IndexOf("." + RootArray[i]);
            }
            if (r > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (path.Contains(":"))
            {
                SystemCms.CreateFile(this.path, TextBox_HTML.Text, ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"));
            }
            else { SystemCms.CreateFile(Server.MapPath(path), TextBox_HTML.Text, ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language")); }

            Response.Redirect("/administrator/Message.aspx?message=更新成功！&z=yes");
        }
    }
}