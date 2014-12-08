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
    [ToolboxData("<{0}:ClassXmlField  runat=server />")]
    public class ClassXmlField : Literal
    {
        private string _Name = null;
        private string _Rid = null;

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
                    if (Page.Request["class"] != null)
                    {
                        _Rid = _Rid.ToLowerInvariant().Replace("{class}", Page.Request["class"]);
                    }
                }
                else { if (Page.Request["class"] != null) { _Rid = Page.Request["class"]; } }
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

            string XMLCon = GetValue(Convert.ToInt32(Rid), Name);
            try
            {
                output.Write(XMLCon == "" ? "<!--无数据！-->" : XMLCon);
            }
            catch { output.Write("<!--输出错误！-->"); }
        }

        public static string GetValue(int ID, string name)
        {
            try
            {
                ROYcms.Common.XmlControl XmlControl = new ROYcms.Common.XmlControl(HttpContext.Current.Server.MapPath("~/APP_data/Class/" + ID + ".xml"));
                return XmlControl.GetText("ROYcms/Class/" + name);
            }
            catch
            {
                return "";
            }
        }
    }
}
