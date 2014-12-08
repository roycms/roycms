using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Community.Web.App_Community
{
    public partial class index : CommunityPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Add();
            if (!IsPostBack)
            {
                Bind();
                if (Request["del"] != null)
                {
                    if (ROYcms.Common.Session.Get("administrator") != null || ROYcms.Common.Session.Get("user_id") != null)
                    { ___ROYcms_Community_bll.Delete(Convert.ToInt32(Request["del"])); Bind(); }
                }
            }
            
        }
        void Bind()
        {
            Repeater_list.DataSource = ___ROYcms_Community_bll.GetAllList();
            Repeater_list.DataBind();
        }
        public void Add()
        {
            string title = Request["title"];
            string content = Request["content"];
            string tag = Request["tag"];
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
                ___ROYcms_Community_model.title = title;
                ___ROYcms_Community_model.content = content;
                ___ROYcms_Community_model.tag = tag;
                ___ROYcms_Community_model.user_id = user_id;
                ___ROYcms_Community_model.type_id = type_id;
                ___ROYcms_Community_model.hits = hits;
                ___ROYcms_Community_model.star_time = star_time;
                ___ROYcms_Community_model.end_time = end_time;
                ___ROYcms_Community_model.ip = ip;
                ___ROYcms_Community_model.switchs = switchs;

                ___ROYcms_Community_bll.Add(___ROYcms_Community_model);
            }
        }
    }
}
