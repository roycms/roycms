using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.UCenter
{    /// <summary>
    /// XML help?
    /// </summary>
    public partial class AddGroup : AdminPage
    {    /// <summary>
        /// XML help?
        /// </summary>
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

            string name = this.txtname.Text;
            string zhaiyao = this.txtzhaiyao.Text;
            string RoleID = "0";
            DateTime Time = DateTime.Now;

            ___ROYcms_UGroup_model.name = name;
            ___ROYcms_UGroup_model.zhaiyao = zhaiyao;
            ___ROYcms_UGroup_model.RoleID = RoleID;
            ___ROYcms_UGroup_model.Time = Time;

            ___ROYcms_UGroup_bll.Add(___ROYcms_UGroup_model);
            Response.Redirect("Group_admin.aspx");

        }
    }
}
