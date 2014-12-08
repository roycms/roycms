using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.Ftp
{
    public partial class AJAXUpFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // UpFile("/", "/1.html");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path">上传的目录</param>
        /// <param name="FileName">本地文件</param>
        /// <returns></returns>
        public bool UpFile(string Path, string FileName) 
        {
            string FTPserver = "203.171.234.7";
            int FTPport = 21;
            string FTPuser = "visp";
            string FTPpassword = "123456";
            ROYcms.Common.FTP FTPSys = new Common.FTP(FTPserver, FTPport, FTPuser, FTPpassword);
            if (FTPSys.Connect()) //链接服务器成功
            {
                FTPSys.ChangeDir(Path);
                FTPSys.OpenUpload(Server.MapPath(FileName));
            }


            return false;
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string FTPserver = "203.171.234.7";
            int FTPport = 21;
            string FTPuser = "visp";
            string FTPpassword = "123456";
            ROYcms.Common.FTP FTPSys = new Common.FTP(FTPserver, FTPport, FTPuser, FTPpassword);
            if (FTPSys.Connect()) //链接服务器成功
            {
                Response.Write("连接成功！");
                if (FTPSys.OpenUpload(@"D:\1.txt")) { Response.Write("成功！"); }
                else { Response.Write("失败！"); }
            }
            
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {

        }
    }
}