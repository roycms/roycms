using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Community.Web.App_Community.Admin
{
    public partial class Administrator :CommunityPage
    {
        protected void Page_Load(object sender, EventArgs e)
        { }
        protected void SAVE_Click(object sender, EventArgs e)
        {
            bool err = ROYcms.Common.SystemCms.NewXml(this, Server.MapPath("~/CommunityConfig.config"), "ROYcms/Config");
            if (err)
            {
                ROYcms.Common.MessageBox.Show(this, "保存成功！");
            }
            else { ROYcms.Common.MessageBox.Show(this, "保存失败！"); }
        }
    }
}
