using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Ask.Web
{
    public partial class Answer : AskPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           Add();
        }
        void Add() 
        {
            int question_id = int.Parse(Request["question_id"]);
            string content = Request["content"];
            string user_id = null;
            if (ROYcms.Common.Session.Get("user_id") != null) { user_id = ROYcms.Common.Session.Get("user_id"); }
            DateTime star_time = DateTime.Now;
            string ip = Request.ServerVariables.Get("Remote_Addr").ToString();

            if (Request["question_id"] != null && content != null)
            {
                ___ROYcms_result_model.question_id = question_id;
                ___ROYcms_result_model.content = content;
                ___ROYcms_result_model.user_id = user_id;
                ___ROYcms_result_model.star_time = star_time;
                ___ROYcms_result_model.ip = ip;

                ___ROYcms_result_bll.Add(___ROYcms_result_model);


                Response.Redirect(string.Format("/ask/ask-{0}.html", Request["question_id"]));
               
            }
        }
    }
}
