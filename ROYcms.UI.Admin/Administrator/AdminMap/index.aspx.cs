using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.AdminMap
{
    /// <summary>
    /// index
    /// </summary>
    public partial class index : ROYcms.AdminPage
    {
        /// <summary>
        /// BLL
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_AdminUrlMap BLL = new Sys.BLL.ROYcms_AdminUrlMap();
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind(); if (Request["del"] != null) { BLL.Delete(Convert.ToInt32(Request["del"])); Bind(); }
            }
        }
        /// <summary>
        /// Binds this instance.
        /// </summary>
       public void Bind()
        {
            Repeater_admin.DataSource = BLL.GetAllList();
            Repeater_admin.DataBind();
        }
    }
}