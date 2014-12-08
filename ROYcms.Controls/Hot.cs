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
    [ToolboxData("<{0}:Hot  runat=server />")]
    public class Hot : Literal
    {
        private string _Rid = null;

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
            if (this.Rid != null)
            {
                ROYcms.Sys.BLL.ROYcms_news ___ROYcms_news = new ROYcms.Sys.BLL.ROYcms_news();
                try
                {
                    if (ROYcms.Common.cooks.GetCookie(this.Rid) == null)
                    {
                        ___ROYcms_news.Hits_news(Convert.ToInt32(this.Rid));
                        ROYcms.Common.cooks.SaveCookie(this.Rid, this.Rid, 30);
                        output.Write("<!--浏览一次！-->");
                    }
                    else { output.Write("<!--重复的信息浏览！-->"); }
                }
                catch { output.Write("<!--浏览信息记入数据库出错！-->"); }
            }
        }
    }
}
