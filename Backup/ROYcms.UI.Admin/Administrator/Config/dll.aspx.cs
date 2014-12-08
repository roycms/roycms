using System;
using System.IO;
namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_config_dll :AdminPage
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {

            FileInfo[] file = ROYcms.Common.SystemCms.GetFilelist(Server.MapPath("~/bin/"));
            for (int i = 0; i < file.Length; i++)
            {
                Label_bll.Text += file[i].Name + "<BR>";
                //System.Reflection.Assembly o = System.Reflection.Assembly.Load(file[i].Name);
                //Response.Write(o.GetName());       
            }
            try
            {
                FileInfo[] file_no =ROYcms.Common.SystemCms.GetFilelist(Server.MapPath("~/bin/_bin"));
                for (int i = 0; i < file_no.Length; i++)
                {
                    Label_bll_.Text += file_no[i].Name + "<BR>";
                    //System.Reflection.Assembly o = System.Reflection.Assembly.Load(file[i].Name);
                    //Response.Write(o.GetName());       
                }
            }
            catch { Label_bll_.Text = "无未注册DLL<BR>";

            ROYcms.Common.SystemCms.InsertErrLog("无未注册DLL错误！", Request.PhysicalPath);
            }
        }

    }
}