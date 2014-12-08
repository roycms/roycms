using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Ask.Web
{
    public partial class AddAsk : AskPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Add();
        }
        public void Add()
        {

            string title = Request["title"];
            string content = Request["content"];
            string tag = Request["tag"];
            int status = 0;
            int reward = 0;
            string user_id = null;
            if (ROYcms.Common.Session.Get("user_id") != null) { user_id = ROYcms.Common.Session.Get("user_id"); }
            string type_id = null;
            int hits = 0;
            DateTime star_time = DateTime.Now;
            DateTime end_time = DateTime.Now;
            string ip = Request.ServerVariables.Get("Remote_Addr").ToString();
            int switchs = 0;
            if (title != null && content != null)
            {
                ___ROYcms_question_model.title = title;
                ___ROYcms_question_model.content = content;
                ___ROYcms_question_model.tag = tag;
                ___ROYcms_question_model.status = status;
                ___ROYcms_question_model.reward = reward;
                ___ROYcms_question_model.user_id = user_id;
                ___ROYcms_question_model.type_id = type_id;
                ___ROYcms_question_model.hits = hits;
                ___ROYcms_question_model.star_time = star_time;
                ___ROYcms_question_model.end_time = end_time;
                ___ROYcms_question_model.ip = ip;
                ___ROYcms_question_model.switchs = switchs;
                ___ROYcms_question_bll.Add(___ROYcms_question_model);
                //添加标签
                AddTag(tag);

                ROYcms.Common.MessageBox.Show(this,"问题提交成功！请关注您提交的问题。");
               
            }

        }
        public bool AddTag(string tag) 
        {
            string[] Tag =ROYcms.Common.input.SubGroup(tag);
            for (int i = 0; i < Tag.Length; ++i) 
            {
                ___ROYcms_Tag_model.Tag = Tag[i];
                ___ROYcms_Tag_model.type = "ASK";
                ___ROYcms_Tag_model.Time = DateTime.Now;
                ___ROYcms_Tag_bll.Add(___ROYcms_Tag_model);
            }
            return true;
        }
    }
}
