using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.knowledgeForm
{
    /// <summary>
    /// 
    /// </summary>
    public partial class knowledgeForm : AdminPage
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
                Bind(); if (Request["del"] != null) { ___ROYcms_Form_bll.Delete(Convert.ToInt32(Request["del"])); Bind(); }
            }
        }
        /// <summary>
        /// Binds this instance.
        /// </summary>
        void Bind()
        {
            Repeater_admin.DataSource = ___ROYcms_Form_bll.GetAllList();
            Repeater_admin.DataBind();
        }
    }
}
