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
    [ToolboxData("<{0}:Login  runat=server />")]
    public class Login : Literal
    {
        private string _Url = null;

        /// <summary>
        /// 字段名称
        /// </summary>
        /// <value>The name.</value>
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        [Description("字段名称")]
        public string Url
        {
            get { return _Url; }
            set { _Url = value; }
        }

        /// <summary>
        /// 输出
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void Render(HtmlTextWriter output)
        {
            if (HttpContext.Current.Session["user_id"] == null)
            {
                //output.Write("<script language='javascript' type='text/javascript'>window.location.href='" + this.Url + "';</script>");
                Page.Response.Redirect(this.Url);
            }

        }
     
      
    }
}
