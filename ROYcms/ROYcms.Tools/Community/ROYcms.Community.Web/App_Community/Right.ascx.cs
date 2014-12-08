using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Community.Web.App_Community
{
    public partial class Right : UserControlCommunityPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
        }
        void Bind()
        {
            Repeater_list.DataSource = ___ROYcms_Community_result_bll.GetList(10,"","bh desc");
            Repeater_list.DataBind();
        }
    }
}