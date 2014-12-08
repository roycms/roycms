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

namespace ROYcms.UI.Admin.Administrator.Objet
{
    /// <summary>
    /// 
    /// </summary>
    public partial class tag : AdminPage
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
                Bind();
                if (Request["del"] != null) { ___ROYcms_Tag_bll.Delete(Convert.ToInt32(Request["del"])); Bind(); }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        void Bind()
        {
            Repeater_Tag.DataSource = ___ROYcms_Tag_bll.GetListY("type='News'");
            Repeater_Tag.DataBind();
        }
    }
}
