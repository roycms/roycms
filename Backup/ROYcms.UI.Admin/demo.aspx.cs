using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin
{
    public partial class demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(ROYcms.Common.DESEncrypt.Encrypt("admin123456") + "<hr>");
            Response.Write(ROYcms.Common.DESEncrypt.Encrypt("123") + "<hr>");
        }
    }
}