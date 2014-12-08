using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.UCenter
{
    public partial class User_all : ROYcms.AdminPage
    {
        public ROYcms.Sys.BLL.ROYcms_user BLL = new ROYcms.Sys.BLL.ROYcms_user();
        public ROYcms.Sys.BLL.ROYcms_UserInfo BLL1 = new ROYcms.Sys.BLL.ROYcms_UserInfo();
        public ROYcms.Sys.Model.ROYcms_user Model = new ROYcms.Sys.Model.ROYcms_user();
        public ROYcms.Sys.Model.ROYcms_UserInfo Model1 = new ROYcms.Sys.Model.ROYcms_UserInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null)
            {
                Model = BLL.GetModel(Convert.ToInt32(Request["id"]));
                Model1 = BLL1.GetModel(Convert.ToInt32(Request["id"]));
            }
        }
    }
}