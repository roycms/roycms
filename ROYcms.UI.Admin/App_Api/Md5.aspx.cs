#define Index
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
#if (Index)
namespace ROYcms.UI.Admin.Administrator.App_Api
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Md5 : System.Web.UI.Page
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
        protected void MD5Button_Click(object sender, EventArgs e)
        {
            TextBox_fuzhi.Text = ROYcms.Common.DESEncrypt.Encrypt(MD5Text.Text);
        }

    }
}
#endif 