using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.IO;
using System.Xml;
using System.Web.UI.WebControls;

namespace ROYcms.Update
{
    /// <summary>
    /// Update的摘要说明
    /// </summary>
    [WebService(Namespace = "ROYcms_Update")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class Update : System.Web.Services.WebService
    {
        private static string result;
        [WebMethod]
        public byte[] StarUpdate(string path)
        {
            // 未验证 
            if (File.Exists(Server.MapPath(path)))
            {
                return File.ReadAllBytes(Server.MapPath(path));
            }
            else { return null; }
        }

        [WebMethod]
        public string[] GetAllFile(string Dir,string WebHost)
        {
            return GetFiles(new DirectoryInfo(Server.MapPath(Dir)), "*.*",WebHost).Split(';');
        }
        public static string GetFiles(DirectoryInfo directory, string pattern,string WebHost)
        {
            if (directory.Exists || pattern.Trim() != string.Empty)
            {
                foreach (FileInfo info in directory.GetFiles(pattern))
                {
                    if (!info.FullName.Contains("FCKedit") && !info.FullName.Contains("WebUI"))
                    {
                        //判断更新时间
                        if (info.LastWriteTime > File.GetCreationTime(HttpContext.Current.Server.MapPath(WebHost.ToLower().Replace("http://", "").Replace("/", "") + ".xml")))
                        {
                            result = result + info.FullName.Replace(HttpContext.Current.Server.MapPath("~/"), "") + ";";
                        }
                    }
                }

                foreach (DirectoryInfo info in directory.GetDirectories())
                {
                    GetFiles(info, pattern, WebHost);
                }
            }
            string returnString = result;
            return returnString;
        }
        [WebMethod]
        public bool NewXml(string GUID, string WebHost)
        {
            string DirPath = "~/App_Data/";
            WebHost = WebHost.ToLower().Replace("http://", "").Replace("/", "");
            if (!File.Exists(Server.MapPath(DirPath + WebHost + ".xml")))
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                //创建一个根节点（一级） 
                XmlElement root = doc.CreateElement("Root");
                doc.AppendChild(root);
                if (!Directory.Exists(Server.MapPath(DirPath)))//判断是否存在
                {
                    Directory.CreateDirectory(Server.MapPath(DirPath));//创建新路径 
                    doc.Save(Server.MapPath(DirPath + WebHost + ".xml"));
                }
                else
                {
                    doc.Save(Server.MapPath(DirPath + WebHost + ".xml"));
                }
                Console.Write(doc.OuterXml);
                new ROYcms.Common.XmlControl(Server.MapPath(DirPath + WebHost + ".xml")).InsertElement("Root", "UpDate", "GUID,WebHost,Time", GUID + "," + WebHost + "," + System.DateTime.Now.ToString());
                return true;
            }
            else
            {
                new ROYcms.Common.XmlControl(Server.MapPath(DirPath + WebHost + ".xml")).InsertElement("Root", "UpDate", "GUID,WebHost,Time", GUID + "," + WebHost + "," + System.DateTime.Now.ToString());
                return true;
            }
        }

    }


}
