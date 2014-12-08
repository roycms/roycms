using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.UCenter
{
    public partial class Blogs : System.Web.UI.Page
    {
        ROYcms.Sys.BLL.ROYcms_Message BlogBLL = new ROYcms.Sys.BLL.ROYcms_Message();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        /// <summary>
        /// 
        /// </summary>
        void Bind()
        {
            Repeater_list.DataSource = BlogBLL.GetAllList();
            Repeater_list.DataBind();
        

        }
    }
}