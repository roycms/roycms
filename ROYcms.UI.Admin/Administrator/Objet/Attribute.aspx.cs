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
using ROYcms.Common;
using System.Xml;
using System.IO;

namespace ROYcms.UI.Admin.Administrator.Objet
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Attribute : AdminPage
    {
        #region ClassKind属性

        /// <summary>
        /// 
        /// </summary>
        protected string ClassKind
        {
            get
            {
                return (string)ViewState["ClassKind"];
            }
            set
            {
                ViewState["ClassKind"] = value;
            }
        }
        #endregion
        #region GUID属性
        /// <summary>
        /// 
        /// </summary>
        protected string GUID
        {
            get
            {
                return (string)ViewState["GUID"];
            }
            set
            {
                ViewState["GUID"] = value;
            }
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public string XMLpath = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ClassKind = Request["ClassKind"];
                this.GUID = Request["GUID"];
                try
                {
                    Xml_From.DocumentSource = "~/App_Data/TemplateFrom/" + this.ClassKind + ".xml";
                    Xml_From.TransformSource = "~/App_Data/TemplateFrom/TemplateFrom.xsl";
                }
                catch { Response.Write("绑定数据出错！文件不存在。"); }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Attribute_Click(object sender, EventArgs e)
        {
            XMLpath = Server.MapPath("~/App_Data/TemplateData/" + this.GUID + ".xml");
            if (NewXml())
            {
                MessageBox.ResponseScript(this, "window.parent.hidePopWin(true);");
                //MessageBox.Show(this, "提交信息成功！");
                
            }
            else
            {
                MessageBox.Show(this, "失败，请和管理员联系！");
            }
        }
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        bool NewXml()
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
                XmlNode node = doc.CreateElement("From");
                XmlAttribute attr = null;
                attr = doc.CreateAttribute("Time");
                attr.Value = DateTime.Now.ToString();
                node.Attributes.SetNamedItem(attr);
                for (int i = 0; i < Request.Form.Count; i++)
                {
                    if (Request.Form.GetKey(i).Contains("ROYcms"))
                    {
                        //带有"<![CDATA[   ]]>"的元素 
                        XmlElement element = doc.CreateElement("Field");
                        element.SetAttribute("Name", Request.Form.GetKey(i).Replace("ROYcms_", ""));
                        ////element.InnerText = "Round Comment";
                        XmlCDataSection idata = doc.CreateCDataSection("item");
                        idata.InnerText = Request.Form.Get(i);
                        element.AppendChild(idata);
                        node.AppendChild(element);
                    }
                }
                root.AppendChild(node);
                doc.Save(XMLpath);
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
