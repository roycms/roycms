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

namespace ROYcms.UI.Admin.Administrator.config
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Add_AdminUser : AdminPage
    {
        /// <summary>
        /// 页面加载
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

            string name = this.txtname.Text;
            string password = this.txtpassword.Text;
            string classkind = this.txtclasskind.Text;
            int Rol = int.Parse(this.txtRol.Text);

       
            ___ROYcms_Admin_Model.name = name;
            ___ROYcms_Admin_Model.password = ROYcms.Common.DESEncrypt.Encrypt(password);
           
            ___ROYcms_Admin_Model.classkind = classkind;
            ___ROYcms_Admin_Model.Rol = Rol;

            ___ROYcms_Admin_bll.Add(___ROYcms_Admin_Model);

            Response.Redirect("AdminPassword.aspx");

        }
    }
}
