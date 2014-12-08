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
    public partial class Workflow_edit : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { ShowInfo(Convert.ToInt32(Request["id"])); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        private void ShowInfo(int id)
        {
            ___ROYcms_Workflow_model = ___ROYcms_Workflow_bll.GetModel(id);

            this.txtkeyId.Text = ___ROYcms_Workflow_model.keyId.ToString().Trim();
            this.txtname.Text = ___ROYcms_Workflow_model.name.Trim();
            this.txtzhaiyao.Text = ___ROYcms_Workflow_model.zhaiyao.Trim();
        }
        /// <summary>
        /// XML help?
        /// </summary>
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["id"]);
            int keyId = int.Parse(this.txtkeyId.Text);
            string name = this.txtname.Text;
            string zhaiyao = this.txtzhaiyao.Text;
            DateTime Time = DateTime.Now;

            ___ROYcms_Workflow_model.id = id;
            ___ROYcms_Workflow_model.keyId = keyId;
            ___ROYcms_Workflow_model.name = name;
            ___ROYcms_Workflow_model.zhaiyao = zhaiyao;
            ___ROYcms_Workflow_model.Time = Time;

            ___ROYcms_Workflow_bll.Update(___ROYcms_Workflow_model);
            Response.Redirect("Workflow_Admin.aspx");
        }
    }
}
