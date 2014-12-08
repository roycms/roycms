using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.config
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Tag : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
                if (Request["del"] != null) { ___ROYcms_Tag_bll.Delete(Convert.ToInt32(Request["del"])); Bind(); }
            }
        }
        void Bind() {
            Repeater_tag.DataSource = ___ROYcms_Tag_bll.GetListY(" id>0 ");
            Repeater_tag.DataBind();
        }
    }
}
