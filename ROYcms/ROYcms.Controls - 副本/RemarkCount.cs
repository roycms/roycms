using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Controls
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:RemarkCount runat=server />")]
    public class RemarkCount : Literal
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
                ROYcms.Sys.BLL.ROYcms_remark ___ROYcms_remark = new ROYcms.Sys.BLL.ROYcms_remark();
                try
                {
                    output.Write(___ROYcms_remark.GetCount("NewId="+this.Rid));
                }
                catch { output.Write(0); }
            }
        }
    }
}
