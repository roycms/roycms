using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Ask.Web
{
    public partial class Ask : AskPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { Bind();
            if (Request["del"] != null) {
                if (ROYcms.Common.Session.Get("administrator") != null || ROYcms.Common.Session.Get("user_id") != null)
                {
                    ___ROYcms_result_bll.Delete(Convert.ToInt32(Request["del"])); Bind();
                }
            }
            }
        }
        void Bind()
        {
            if (Request["id"] != null)
            {
                ___ROYcms_question_model = ___ROYcms_question_bll.GetModel(Convert.ToInt32(Request["id"]));
                if (___ROYcms_question_model != null)
                {
                    title.Text = ___ROYcms_question_model.title;
                    content.Text = ___ROYcms_question_model.content;
                    ip.Text = ___ROYcms_question_model.ip;
                    time.Text = ___ROYcms_question_model.end_time.ToString();
                    username.Text =___GetUserDate("{name}", ___ROYcms_question_model.user_id);
                  
                }
                Repeater_list.DataSource = ___ROYcms_result_bll.GetList("question_id=" + Request["id"]);
                Repeater_list.DataBind();
            }
        }
    }
}
