using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ROYcms.Update.App_code
{
    public class ZipFile
    {
        ZipOutputStream zos = null;
        String strBaseDir = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            dlZipDir(Server.MapPath("~/"), "temp");
            //网站根目录
        }

        protected void dlZipDir(string strPath, string strFileName)
        {
            MemoryStream ms = null;
            Response.ContentType = "application/octet-stream";
            strFileName = HttpUtility.UrlEncode(strFileName).Replace('+', ' ');
            Response.AddHeader("Content-Disposition", "attachment; filename=" + strFileName + ".zip");
            ms = new MemoryStream();
            zos = new ZipOutputStream(ms);
            strBaseDir = strPath + "\\";
            addZipEntry(strBaseDir);
            zos.Finish();
            zos.Close();
            Response.Clear();
            Response.BinaryWrite(ms.ToArray());
            Response.End();
        }

        protected void addZipEntry(string PathStr)
        {
            DirectoryInfo di = new DirectoryInfo(PathStr);
            foreach (DirectoryInfo item in di.GetDirectories())
            {
                addZipEntry(item.FullName);
            }
            foreach (FileInfo item in di.GetFiles())
            {
                FileStream fs = File.OpenRead(item.FullName);
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                string strEntryName = item.FullName.Replace(strBaseDir, "");
                ZipEntry entry = new ZipEntry(strEntryName);
                zos.PutNextEntry(entry);
                zos.Write(buffer, 0, buffer.Length);
                fs.Close();
            }
        }


    }
}