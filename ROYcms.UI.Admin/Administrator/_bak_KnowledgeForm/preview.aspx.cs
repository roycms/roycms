using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class preview : AdminPage
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
                if (Request["id"] != null) {
                    ___ROYcms_Form_model = ___ROYcms_Form_bll.GetModel(Convert.ToInt32(Request["id"]));
                    Response.Write(___ROYcms_Form_model.Contents);
                }
            }
        }
    }
}
