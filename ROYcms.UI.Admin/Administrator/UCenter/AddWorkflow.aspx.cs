using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.Workflow
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AddWorkflow : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int keyId = int.Parse(this.txtkeyId.Text);
            string name = this.txtname.Text;
            string zhaiyao = this.txtzhaiyao.Text;
            DateTime Time = DateTime.Now;
           
            ___ROYcms_Workflow_model.keyId = keyId;
            ___ROYcms_Workflow_model.name = name;
            ___ROYcms_Workflow_model.zhaiyao = zhaiyao;
            ___ROYcms_Workflow_model.Time = Time;

            ___ROYcms_Workflow_bll.Add(___ROYcms_Workflow_model);
            Response.Redirect("Workflow_Admin.aspx");
        }
    }
}
