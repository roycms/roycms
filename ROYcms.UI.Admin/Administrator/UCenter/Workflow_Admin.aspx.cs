using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Workflow_Admin : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Workflow BLL = new Sys.BLL.ROYcms_Workflow();
        /// <summary>
        /// Page_Load
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                PreIndex();
                Bind();
               
                if (Request["del"] != null)
                {
                    BLL.Delete(Convert.ToInt32(Request["del"]));
                    PreIndex();
                    Bind();
                } 
            }
        }
        /// <summary>
        /// 初始值赋值
        /// </summary>
        public void PreIndex()
        {
            ViewState["Page"] = ROYcms.Common.Request.GetQueryString("Page") == "" ? "1" : ROYcms.Common.Request.GetQueryString("Page");
            //ViewState["PageCon"] = ViewState["PageCon"] ==null:30;
            //ViewState["KeyWord"] = keywords.Value;
            Application["PageSize"] = Application["PageSize"] == null ? "20" : Application["PageSize"];
        }
        /// <summary>
        /// 
        /// </summary>
        void Bind() 
        {
            string where = null;
            where += "id>-1";

            try
            {
                Repeater_list.DataSource = BLL.GetList(Convert.ToInt32(Application["PageSize"]), Convert.ToInt32(ViewState["Page"]), where);
                Repeater_list.DataBind();
                ViewState["PageCon"] = BLL.GetCount(where) / Convert.ToInt32(Application["PageSize"]) + 1;
                ViewState["PageContent"] = BLL.GetCount(where);
            }
            catch //异常处理
            {
                Repeater_list.DataSource = null;
                Repeater_list.DataBind();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void PageSizeTextChanged(object sender, EventArgs e)
        {
            Application["PageSize"] = ((TextBox)Repeater_list.Controls[Repeater_list.Controls.Count - 1].FindControl("PageSize")).Text;
            Bind();
        }
    }
}
