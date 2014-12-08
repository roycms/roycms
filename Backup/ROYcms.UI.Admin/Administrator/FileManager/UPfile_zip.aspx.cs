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
using System.IO;
using System.Data.SqlClient;
using System.Text;

namespace ROYcms.UI.Admin.Administrator.config
{    /// <summary>
    /// XML help?
    /// </summary>
    public partial class UPfile_zip : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string Path = Server.MapPath("~/temp.zip");
                FileUpload1.PostedFile.SaveAs(Path);
                if (ROYcms.Common.ZIP.UnpackFiles(Path, Server.MapPath("~/"))) { 
                 
                    Response.Redirect("/administrator/Message.aspx?message=<b>上传并解压成功！！</b>&z=yes");
                }
            }
        }
    }
}
