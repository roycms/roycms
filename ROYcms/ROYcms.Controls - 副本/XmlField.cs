using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Controls
{
    [DefaultProperty("")]
    [ToolboxData("<{0}:XmlField  runat=server />")]
    public class XmlField : Literal
    {
        private string _Name = null;
        private string _Rid = null;
        private string _Root = null;
        /// <summary>
        /// 字段名称
        /// </summary>
        /// <value>The name.</value>
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        /// <summary>
        /// 字段名称
        /// </summary>
        /// <value>The name.</value>
        public string Root
        {
            get { return _Root; }
            set { _Root = value; }
        }
        /// <summary>
        /// 参数值 只读 Request[ParameterName]
        /// </summary>
        /// <value>The id.</value>
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Rid
        {
            get
            {
                if (_Rid != null)
                {
                    if (Page.Request["id"] != null)
                    {
                        _Rid = _Rid.ToLowerInvariant().Replace("{id}", Page.Request["id"]);
                    }
                }
                else { if (Page.Request["id"] != null) { _Rid = Page.Request["id"]; } }
                return _Rid;
            }
            set { _Rid = value; }
        }
        /// <summary>
        /// 输出
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void Render(HtmlTextWriter output)
        {
            try
            {
                string XMLCon = null;
                if (this.Root == null)
                {
                    ROYcms.Sys.BLL.ROYcms_news ___ROYcms_news = new ROYcms.Sys.BLL.ROYcms_news();
                    XMLCon = GetValue(Convert.ToInt32(Rid), ___ROYcms_news.GetClassKind(Convert.ToInt32(Rid)), this.Name);
                }
                else { XMLCon = GetXmlValue(this.Rid, this.Root, this.Name); }
                
                output.Write(XMLCon == "" ? "<!--无数据！-->" : XMLCon);
            }
            catch { output.Write("<!--输出错误！-->"); }
        }

        public static string GetValue(int ID, string ClassKind, string name)
        {
            try
            {
                ROYcms.Common.XmlControl XmlControl = new ROYcms.Common.XmlControl(HttpContext.Current.Server.MapPath("~/APP_XML/" + ClassKind + "/" + ID + ".xml"));
                return XmlControl.GetText("ROYcms/News/" + name);
            }
            catch
            {
                return "";
            }
        }
        public static string GetXmlValue(string ID, string Root, string name)
        {
            try
            {
                ROYcms.Common.XmlControl XmlControl = new ROYcms.Common.XmlControl(HttpContext.Current.Server.MapPath("~/APP_XML/Xml/" + Root + "/" + ID + ".xml"));
                return XmlControl.GetText("ROYcms/XML/" + name);
            }
            catch
            {
                return "";
            }
          
        }
    }
}
