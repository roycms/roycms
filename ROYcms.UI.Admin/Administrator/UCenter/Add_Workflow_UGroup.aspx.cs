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
    public partial class Add_Workflow_UGroup :AdminPage
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Label_GroupName.Text = Server.UrlDecode( Request["UGroup_name"]);
        }
        /// <summary>
        /// Handles the Click event of the btnAdd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {

            int UGroup_id = int.Parse(Request["UGroup_id"]);
            int Workflow_id = int.Parse(DropDownList_Workflow.SelectedValue);
            DateTime Time = DateTime.Now;

            ___ROYcms_UGroup_Workflow_model.UGroup_id = UGroup_id;
            ___ROYcms_UGroup_Workflow_model.Workflow_id = Workflow_id;
            ___ROYcms_UGroup_Workflow_model.Time = Time;

            ___ROYcms_UGroup_Workflow_bll.Add(___ROYcms_UGroup_Workflow_model);
            Response.Redirect("group_admin.aspx? ");

        }
    }
}
