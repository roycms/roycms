using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ROYcms.UI.Admin;

namespace ROYcms.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AddRss : UserPage
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
        protected void Button_ADDrss_Click(object sender, EventArgs e)
        {
            string name = this.TextBox_rss_name.Text;
            int user_id =Convert.ToInt32(ROYcms.Common.Session.Get("user_id"));
            string zhaiyao = this.TextBox_rss_zhaiyao.Text;
            string Encode = "utf-8";
            string Url = this.TextBox_rss_url.Text;
            DateTime Time = DateTime.Now;

            ___ROYcms_Rss_model.name = name;
            ___ROYcms_Rss_model.User_id = user_id;
            ___ROYcms_Rss_model.zhaiyao = zhaiyao;
            ___ROYcms_Rss_model.Encode = Encode;
            ___ROYcms_Rss_model.Url = Url;
            ___ROYcms_Rss_model.Time = Time;

            ___ROYcms_Rss_bll.Add(___ROYcms_Rss_model);
            Response.Redirect("Rss.aspx?");

        }
    }
}
