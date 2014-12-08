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
    public partial class NewAdmin : UserPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["t"] == "del") 
                {
                    ___ROYcms_news_Bll.Delete(Convert.ToInt32(Request["id"]));
                }
                Bind();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        void Bind()
        {
            Repeater_list.DataSource = ___ROYcms_New_User_bll.GetList(30, Convert.ToInt32(Request["page"] == null ? "1" : Request["page"]), "User_id=" + Convert.ToInt32(ROYcms.Common.Session.Get("user_id")), 1);
            Repeater_list.DataBind();
        }
    }
}
