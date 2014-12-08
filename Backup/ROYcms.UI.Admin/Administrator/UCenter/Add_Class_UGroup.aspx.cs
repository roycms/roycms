using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Add_Class_UGroup : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Label_GroupName.Text = Server.UrlDecode(Request["UGroup_name"]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int Class_id = int.Parse(this.txtClass_id.Text);
            int UGroup_id = int.Parse(Request["UGroup_id"]);
            int User_id = 0;
            DateTime Time = DateTime.Now;

            ___ROYcms_Class_UGroup_model.Class_id = Class_id;
            ___ROYcms_Class_UGroup_model.UGroup_id = UGroup_id;
            ___ROYcms_Class_UGroup_model.User_id = User_id;
            ___ROYcms_Class_UGroup_model.Time = Time;

            ___ROYcms_Class_UGroup_bll.Add(___ROYcms_Class_UGroup_model);
            Response.Redirect("group_admin.aspx? ");
        }

    }
}
