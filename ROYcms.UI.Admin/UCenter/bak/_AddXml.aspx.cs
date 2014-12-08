using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ROYcms.UI.Admin;
using System.Xml;
using System.IO;

namespace ROYcms.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class _AddXml :UserPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ROYcms.Common.Session.Get("user_id") != null)
                {
                    NewXml(Convert.ToInt32(ROYcms.Common.Session.Get("user_id")));
                    Response.Write("录入成功！");
                }
                else { Response.Redirect("/ucenter/login.aspx"); }
            }
        }
        /// <summary>
        /// 创建XML 数据文件
        /// </summary>
        /// <param name="ID">The ID.</param>
        /// <returns></returns>
        public bool NewXml(int ID)
        {

            try
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"), null);
                doc.AppendChild(dec);
                //创建一个根节点（一级） 
                XmlElement root = doc.CreateElement("ROYcms");
                doc.AppendChild(root);
                //创建节点（二级） 
                XmlNode node = doc.CreateElement("User");
                XmlAttribute attr = null;
                attr = doc.CreateAttribute("Time");
                attr.Value = DateTime.Now.ToString();
                node.Attributes.SetNamedItem(attr);
                for (int i = 0; i < Request.Form.Count; i++)
                {
                    //带有"<![CDATA[   ]]>"的元素 
                    if (!Request.Form.GetKey(i).Contains("_"))
                    {
                        XmlElement element = doc.CreateElement(Request.Form.GetKey(i));
                        XmlCDataSection idata = doc.CreateCDataSection("item");
                        idata.InnerText = Request.Form.Get(i);
                        element.AppendChild(idata);
                        node.AppendChild(element);
                    }
                }
                root.AppendChild(node);
                if (!Directory.Exists(Server.MapPath("~/APP_XML/UserXml/")))
                {
                    Directory.CreateDirectory(Server.MapPath("~/APP_XML/UserXml/")); //创建新路径 
                }
                doc.Save(Server.MapPath("~/APP_XML/UserXml/" + ID + ".xml"));
                Console.Write(doc.OuterXml);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
