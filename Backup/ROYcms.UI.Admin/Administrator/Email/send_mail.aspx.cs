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

namespace ROYcms.UI.Admin.Administrator.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class send_mail : AdminPage
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
        protected void Button_send_mail_Click(object sender, EventArgs e)
        {
            DataSet ds = ___ROYcms_user_bll.GetAllList();
         
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ROYcms.Common.SystemCms.SendMail(Email_title.Text, Email_content.Text, ds.Tables[0].Rows[i]["email"].ToString().Trim());
            }
            Response.Write("群发完毕！");
        }
    }
}
