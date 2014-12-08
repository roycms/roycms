using System;
using System.Threading;
using System.IO;
using System.Reflection;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 远程下载解压文件
    /// </summary>
    public partial class Update : AdminPage
    {
        #region UpdatePath属性
        /// <summary>
        /// 
        /// </summary>
        protected string UpdatePath
        {
            get
            {
                return (string)ViewState["UpdatePath"];
            }
            set
            {
                ViewState["UpdatePath"] = value;
            }
        }
        #endregion
                #region Version属性
        /// <summary>
        /// 
        /// </summary>
        protected string Version
        {
            get
            {
                return (string)ViewState["Version"];
            }
            set
            {
                ViewState["Version"] = value;
            }
        }
        #endregion
        /// <summary>
        ///  Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                   this.Version = ROYcms.Common.GetUrlText.GetText(___CmsConfigValue("update_server") + "app_api/Update.ashx?i=Version", "utf-8");
                    if (___CmsConfigValue("version") == this.Version)
                    {
                        Panel_noupdate.Visible = true;
                        Panel_update.Visible = false;
                        Panel_error.Visible = false;
                    }
                    else
                    {

                        this.UpdatePath = ___CmsConfigValue("update_server") + "UpdateFile/" + this.Version + ".zip";
                        Panel_noupdate.Visible = false;
                        Panel_update.Visible = true;
                        Panel_error.Visible = false;

                    }
                }
            }
            catch
            {
                Panel_noupdate.Visible = false;
                Panel_update.Visible = false;
                Panel_error.Visible = true;
            }
        }
        /// <summary>
        /// 下载压缩文件到本地，并解压到相应的目录 Handles the Click event of the Button_ZIP control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Button_ZIP_Click(object sender, EventArgs e)
        {
            ROYcms.Common.DownloadFile Down = new ROYcms.Common.DownloadFile();
            Down.StrUrl = this.UpdatePath;
            Down.StrFileName = Server.MapPath("~/temp.zip");
            if (Down.Download())
            {
                string UpdatePath = Server.MapPath("~/temp.zip");
                bool Error = ROYcms.Common.ZIP.UnpackFiles(UpdatePath, Server.MapPath("~/"));
                if (Error)
                {
                    FileDel(UpdatePath);
                    //修改配置文件的版本信息
                    EditConfig(this.Version);

                    Panel_noupdate.Visible = true;
                    Panel_update.Visible = false;
                    Panel_error.Visible = false;
                }
                else
                {
                    FileDel(UpdatePath);

                    Panel_noupdate.Visible = false;
                    Panel_update.Visible = false;
                    Panel_error.Visible = true;
                }
            }
            else { Response.Write(Down.strError); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        void FileDel(string FileName) { File.Delete(FileName); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="version"></param>
        void EditConfig(string version)
        {
            new ROYcms.Common.XmlControl(Server.MapPath("~/administrator/app_config/index.config")).Replace("ROYcms/Config/version", version);
        }
    }
}
