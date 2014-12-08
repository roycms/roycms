using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.AdminMap
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Insert : System.Web.UI.Page
    {
        public ROYcms.Sys.BLL.ROYcms_AdminUrlMap BLL = new Sys.BLL.ROYcms_AdminUrlMap();
        public ROYcms.Sys.Model.ROYcms_AdminUrlMap Model = new Sys.Model.ROYcms_AdminUrlMap();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = ROYcms.Common.Request.GetQueryInt("Id");
            if (Id>0){
                Model = BLL.GetModel(Id);
            }
        }
    }
}