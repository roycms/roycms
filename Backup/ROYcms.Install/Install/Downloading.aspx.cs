using System;
using System.Threading;

namespace ROYcms.Install.Install
{
    /// <summary>
    /// 远程下载解压文件
    /// </summary>
    public partial class Downloading : System.Web.UI.Page
    {
        /// <summary>
        ///  Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        { }
        /// <summary>
        /// 下载压缩文件到本地，并解压到相应的目录 Handles the Click event of the Button_ZIP control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Button_ZIP_Click(object sender, EventArgs e)
        {
            ROYcms.Common.DownloadFile Down = new ROYcms.Common.DownloadFile();
            Down.StrUrl = ROYcms.Common.GetUrlText.GetText("http://www.roycms.cn/api/Update.ashx?i=Install_ROYcms_Path", "utf-8");
            Down.StrFileName = Server.MapPath("~/temp.zip");
            Down.Download();

            if (ROYcms.Common.ZIP.UnpackFiles(Server.MapPath("~/temp.zip"), Server.MapPath("~/")))
            { Response.Write("下载解压成功 ！ <a href='/Install/index.aspx'>点击开始安装</a>"); }
            else { Response.Write("解压失败！"); }
        }

    }
}
