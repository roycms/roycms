using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using ROYcms.Common;

namespace ROYcms.UI.Admin.Administrator.Framework
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AddRole : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "角色添加";

        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {

            string strErr = "";
            if (this.txtname.Text == "")
            {
                strErr += "name不能为空！\\n";
            }
            if (this.txtzhaiyao.Text == "")
            {
                strErr += "zhaiyao不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string name = this.txtname.Text;
            string zhaiyao = this.txtzhaiyao.Text;
            DateTime Time = DateTime.Now;

            ROYcms.Sys.Model.ROYcms_Role model = new ROYcms.Sys.Model.ROYcms_Role();
            model.name = name;
            model.zhaiyao = zhaiyao;
            model.Time = Time;

            ROYcms.Sys.BLL.ROYcms_Role bll = new ROYcms.Sys.BLL.ROYcms_Role();
            bll.Add(model);

        }

    }
}
