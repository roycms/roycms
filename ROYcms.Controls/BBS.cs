using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using System.ComponentModel;
using System.Web.UI.WebControls;

namespace ROYcms.Controls.Control
{
    [DefaultProperty("")]
    [ToolboxData("<{0}:BBS  runat=server />")]
    public class BBS : Literal
    {
        private string _URL = null;
        private string _gET = null;
        private string _BbsEncoding = "gb2312";

        /// <summary>
        /// 字段名称
        /// </summary>
        /// <value>The name. </value>
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string URL
        {
            get { return _URL; }
            set { _URL = value; }
        }
        public string gET
        {
            get { return _gET; }
            set { _gET = value; }
        }
        public string BbsEncoding
        {
            get { return _BbsEncoding; }
            set { _BbsEncoding = value; }
        }
        /// <summary>
        /// 输出
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void Render(HtmlTextWriter output)
        {
            try
            {
                output.Write(ROYcms.Common.DZBBS.GetBBS(URL, gET, BbsEncoding));
            }
            catch { output.Write("<!--输出错误！-->"); }
        }
    }
}
