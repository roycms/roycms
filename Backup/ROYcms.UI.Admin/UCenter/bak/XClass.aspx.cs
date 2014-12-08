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
    public partial class XClass : UserPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        { if (!IsPostBack) { _Bind(); } }
        /// <summary>
        /// 
        /// </summary>
        void _Bind()
        {
            try
            {
                Repeater_list.DataSource = ___ROYcms_Class_UGroup_bll.GetList(" UGroup_id=" + Convert.ToInt32(ROYcms.Common.Session.Get("ugroup_id")));
                Repeater_list.DataBind();
            }
            catch { ROYcms.Common.MessageBox.Show(this,"该用户未绑定用户组或者无任何发布信息的权限！"); }
        }

    }
}
