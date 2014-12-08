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
    public partial class group_edit : AdminPage
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
            ___ROYcms_UGroup_model = ___ROYcms_UGroup_bll.GetModel(id);

            this.txtname.Text = ___ROYcms_UGroup_model.name;
            this.txtzhaiyao.Text = ___ROYcms_UGroup_model.zhaiyao;
            this.txtRoleID.Text = ___ROYcms_UGroup_model.RoleID;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);
            string name = this.txtname.Text;
            string zhaiyao = this.txtzhaiyao.Text;
            string RoleID = this.txtRoleID.Text;
            DateTime Time = DateTime.Now;
            ___ROYcms_UGroup_model.id = id;
            ___ROYcms_UGroup_model.name = name;
            ___ROYcms_UGroup_model.zhaiyao = zhaiyao;
            ___ROYcms_UGroup_model.RoleID = RoleID;
            ___ROYcms_UGroup_model.Time = Time;

            ___ROYcms_UGroup_bll.Update(___ROYcms_UGroup_model);
            Response.Redirect("Group_admin.aspx");
        }
    }
}
