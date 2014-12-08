using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Shop
{
    public partial class Index : System.Web.UI.Page
    {
        public ROYcms.Sys.BLL.ROYcms_Goods BLL = new Sys.BLL.ROYcms_Goods();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater_admin.DataSource = BLL.GetAllList();
            Repeater_admin.DataBind();
        }
    }
}