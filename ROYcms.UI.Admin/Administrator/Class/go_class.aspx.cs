using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin
{    /// <summary>
    /// XML help?
    /// </summary>
	public partial class go_class : AdminPage
    {    /// <summary>
        /// XML help?
        /// </summary>
		protected void Page_Load(object sender, EventArgs e)
		{}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_yd_Click(object sender, EventArgs e)
        {
            ___ROYcms_news_Bll.GoToClass(Convert.ToInt32(ListBox_go.SelectedValue), Convert.ToInt32(ListBox_to.SelectedValue));
            Response.Redirect("index.aspx?classkind=" + Request["classkind"]);
        }
	}
}
