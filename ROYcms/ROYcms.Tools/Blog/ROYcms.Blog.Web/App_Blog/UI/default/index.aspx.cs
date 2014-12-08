using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Blog.Web.App_Blog
{
    public partial class index : BlogPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
        }
        void Bind() 
        {
            string Where = "user_id="+this.User_id;

            if (Request["Tag"] != null)
            { Where = "user_id=" + this.User_id + " and tag like '%" + Request["Tag"] + "%' "; }
            Repeater_list.DataSource = ___ROYcms_Blog_bll.GetList(15, Where, "id desc");
            Repeater_list.DataBind();
        }
    }
}
