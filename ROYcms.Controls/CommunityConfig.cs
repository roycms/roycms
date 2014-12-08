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
    [ToolboxData("<{0}:CommunityConfig runat=server />")]
    public class CommunityConfig : Literal
    {
        private string _Name = null;

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
        /// 输出
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void Render(HtmlTextWriter output)
        {
            try
            {
                output.Write(ROYcms.Common.SystemCms.GetXmlValue(HttpContext.Current.Server.MapPath("~/CommunityConfig.config"), "ROYcms/Community/" + this.Name));
            }
            catch { output.Write("<!--输出错误！-->"); }
        }
    }
}
