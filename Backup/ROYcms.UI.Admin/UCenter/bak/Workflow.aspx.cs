using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ROYcms.UI.Admin;

namespace ROYcms.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Workflow : UserPage
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        { if (!IsPostBack) { Bind(); } }
        /// <summary>
        /// 
        /// </summary>
        void Bind()
        {
            try
            {
                Repeater_list.DataSource = ___ROYcms_UGroup_Workflow_bll.GetList(" UGroup_id=" + Convert.ToInt32(ROYcms.Common.Session.Get("ugroup_id")));
                Repeater_list.DataBind();
            }
            catch {
                ROYcms.Common.MessageBox.Show(this, "运行出错! 该会员不属于有效的权限小组");
            }
        }
    }
}
