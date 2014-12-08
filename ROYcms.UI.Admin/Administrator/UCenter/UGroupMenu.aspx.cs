using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ROYcms.UI.Admin.Administrator.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class UGroupMenu :AdminPage
    {    /// <summary>
        /// XML help?
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { Bind(); }
        }
        /// <summary>
        /// 
        /// </summary>
        void Bind() 
        {
            string Path = Server.MapPath("~/App_Data/UGroupMenu/" + Request["UGroup_id"] + ".xml");
            if (File.Exists(Path)) { TextBox_UGroupMenu.Text = ROYcms.Common.SystemCms.Read_File(Path, "utf-8"); }
            else { TextBox_UGroupMenu.Text = ROYcms.Common.SystemCms.Read_File(Server.MapPath("~/App_Data/UGroupMenu/UserNavigation.xml"), "utf-8"); }
        } 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Edit_Click(object sender, EventArgs e)
        {
            string Path = Server.MapPath("~/App_Data/UGroupMenu/" + Request["UGroup_id"] + ".xml");
            if (!Directory.Exists(Server.MapPath("~/App_Data/UGroupMenu/")))//判断是否存在
            {
                Directory.CreateDirectory(Server.MapPath("~/App_Data/UGroupMenu/"));//创建新路径 
            }

            ROYcms.Common.SystemCms.CreateFile(Path, TextBox_UGroupMenu.Text, "utf-8");
            Response.Redirect("Group_admin.aspx");
         
        }
    }
}
