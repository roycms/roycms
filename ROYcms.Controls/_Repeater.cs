using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.IO;

namespace ROYcms.Controls
{
    /// <summary>
    /// _Repeater
    /// </summary>
    public class _Repeater : Repeater
    {
        /// <summary>
        /// HtmlTextWriter
        /// </summary>
        /// <param name="writer"></param>
        /// <returns></returns>
        public HtmlTextWriter WriteReplace(System.Web.UI.HtmlTextWriter writer)
        {
            return writer;
        }
    }
}
