using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ROYcms.Controls
{
    [DefaultProperty("")]
    [ToolboxData("<{0}:Link runat=server />")]
    public class Link : Literal
    {
        public ROYcms.Templet.GetMyUrl GetMyUrl = new ROYcms.Templet.GetMyUrl();

        private string _Name = null;
        private string _Class = null;
        private string _Rid = null;
        private string _Div = null;
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
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Div
        {
            get { return _Div; }
            set { _Div = value; }
        }
        /// <summary>
        /// 参数值 只读 Request[ParameterName]
        /// </summary>
        /// <value>The id.</value> 
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Class
        {
            get
            {
                if (_Class != null)
                {
                    if (Page.Request["class"] != null)
                    { _Class = _Class.ToLowerInvariant().Replace("{class}", Page.Request["class"]); }
                }
                return _Class;
            }
            set
            {
                _Class = value;
            }
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
            get { return _Rid; }
            set { _Rid = value; }
        }
        /// <summary>
        /// 输出
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void Render(HtmlTextWriter output)
        { 
            string Url = null; //返回地址
            try
            {
                if (this.Class == null)  //文章链接输出
                {
                    Url = GetMyUrl.GetArticle(Convert.ToInt32(this.Rid));
                }
                else  //频道链接输出
                {
                    if (this.Div == "0")
                    {
                        Url = GetMyUrl.GetChannel(Convert.ToInt32(this.Class), 0);
                    }
                    else 
                    {
                        Url = GetMyUrl.GetChannel(Convert.ToInt32(this.Class), 1);
                    }
                }
                output.Write(Url);
            }   
            catch { output.Write("<!--输出错误！-->"); }
        }
    }
}
