using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Community.Web.App_Community
{
    public partial class CommMsgs : CommunityPage
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
                    {
                        ___ROYcms_Community_result_bll.Delete(Convert.ToInt32(Request["del"])); Bind();
                    }
                }
            }
        }
        void Bind()
        {
            if (Request["id"] != null)
            {
                ___ROYcms_Community_model = ___ROYcms_Community_bll.GetModel(Convert.ToInt32(Request["id"]));
                if (___ROYcms_Community_model != null)
                {
                    this.Page.Title = ___ROYcms_Community_model.title +" - "+ ___GetConfigValue("title");
                    this.title.Text = ___ROYcms_Community_model.title;
                    this.content.Text = ___ROYcms_Community_model.content;
                    this.Time.Text = ___ROYcms_Community_model.end_time.ToString();
                    this.ip.Text = ___ROYcms_Community_model.ip;
                    this.user_name.Text = (___ROYcms_Community_model.user_id == "" ? "匿名用户" : ___GetUserDate("{name}", ___ROYcms_Community_model.user_id));
                    
                }
                Repeater_list.DataSource = ___ROYcms_Community_result_bll.GetList("Community_id=" + Request["id"]);
                Repeater_list.DataBind();
            }

            Repeater_list_.DataSource = ___ROYcms_Community_bll.GetList(6, "", "bh desc");
            Repeater_list_.DataBind();
        }
        public void Add()
        {
            string Community_id = Request["Community_id"];
            string title = Request["title"];
            string content = Request["content"];
            string user_id = null;
            if (ROYcms.Common.Session.Get("user_id") != null) { user_id = ROYcms.Common.Session.Get("user_id"); }
            DateTime Time = DateTime.Now;
            string ip = Request.ServerVariables.Get("Remote_Addr").ToString();
            if (title != null && Community_id != null)
            {
                ___ROYcms_Community_result_model.Community_id =  Convert.ToInt32(Community_id);
                ___ROYcms_Community_result_model.title = title;
                ___ROYcms_Community_result_model.content = content;
                ___ROYcms_Community_result_model.user_id = user_id;
                ___ROYcms_Community_result_model.ip = ip;
                ___ROYcms_Community_result_model.Time = Time;

                ___ROYcms_Community_result_bll.Add(___ROYcms_Community_result_model);
            }
        }
    }
}
