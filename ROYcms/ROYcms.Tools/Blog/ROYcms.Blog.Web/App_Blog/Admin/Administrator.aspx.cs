using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

namespace ROYcms.Blog.Web.App_Blog.Admin
{
    public partial class Administrator : BlogPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {}
        protected void SAVE_Click(object sender, EventArgs e)
        {
            bool err = ROYcms.Common.SystemCms.NewXml(this, Server.MapPath("~/BlogConfig.config"), "ROYcms/Config");
            if (err)
            {
                ROYcms.Common.MessageBox.Show(this,"保存成功！");
            }
            else { ROYcms.Common.MessageBox.Show(this, "保存失败！"); }
        }
    }
}
