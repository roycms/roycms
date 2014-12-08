using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Ask.Web
{
    public partial class AskList :AskPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { Bind();
            if (Request["del"] != null)
            {
                if (ROYcms.Common.Session.Get("administrator") != null || ROYcms.Common.Session.Get("user_id") != null)
                { ___ROYcms_question_bll.Delete(Convert.ToInt32(Request["del"])); Bind(); }
            }
            }
        }
        void Bind()
        {
            Repeater_list.DataSource = ___ROYcms_question_bll.GetAllList();
            Repeater_list.DataBind();
        }
    }
}
