using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ROYcms.Common;

namespace ROYcms.Controls
{
    [DefaultProperty("")]
    [ToolboxData("<{0}:Include runat=server />")]
    public class Include : Literal
    {
        private string _Path = null;

        /// <summary>
        /// 参数值 只读 Request[ParameterName]
        /// </summary>
        /// <value>The id.</value>
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Path
        {
            get { return _Path; }
            set { _Path = value; }
        }
        /// <summary>
        /// 输出
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void Render(HtmlTextWriter output)
        {
            if (this.Path != null)
            {
                try
                {
                    string htmlCONTENT = null;
                    htmlCONTENT = SystemCms.Read_File(HttpContext.Current.Server.MapPath(this.Path), ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"));
                    output.Write(htmlCONTENT);
                }
                catch { output.Write("<!--浏览信息记入数据库出错！-->"); }
            }
        }
    }
}
