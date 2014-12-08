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
    [ToolboxData("<{0}:WebConfig runat=server />")]
    public class WebConfig : Literal
    {
        private string _Name = null;
        private string _Config = null;
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
        /// 类型
        /// </summary>
        /// <value>The name.</value>
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Config
        {
            get { return _Config; }
            set { _Config = value; }
        }
        /// <summary>
        /// 输出
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void Render(HtmlTextWriter output)
        {
            try
            {
                if (this.Config != null) { this.Config = "~/administrator/APP_config/" + this.Config; }
                else { this.Config = "~/administrator/APP_config/index.config"; }
                output.Write(ROYcms.Common.SystemCms.GetXmlValue(HttpContext.Current.Server.MapPath(this.Config), "ROYcms/Config/" + this.Name));
            }
            catch { output.Write("<!--输出错误！-->"); }
        }
    }
}
