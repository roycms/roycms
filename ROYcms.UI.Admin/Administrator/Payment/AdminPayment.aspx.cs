using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.Payment
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AdminPayment : ROYcms.AdminPage
    {
        ROYcms.Sys.BLL.ROYcms_Payment Bll = new Sys.BLL.ROYcms_Payment();
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PreIndex();
                Bind();
            }
        }
        /// <summary>
        /// 初始值赋值
        /// </summary>
        public void PreIndex()
        {
            ViewState["Page"] = ROYcms.Common.Request.GetQueryString("Page") == "" ? "1" : ROYcms.Common.Request.GetQueryString("Page");
            Application["PageSize"] = Application["PageSize"] == null ? "20" : Application["PageSize"];
        }
        /// <summary>
        /// Binds this instance.
        /// </summary>
        void Bind()
        {
            string where = null;

            if (ViewState["StarTime"] != null && ViewState["EndTime"] != null)
            {
                where += " (CreateTime>'" + ViewState["StarTime"].ToString() + "' AND CreateTime <'" + ViewState["EndTime"].ToString() + "') AND ";
            }

            where += " Id>-1 ";

            try
            {
            Repeater_admin.DataSource = Bll.GetList(Convert.ToInt32(Application["PageSize"]), Convert.ToInt32(ViewState["Page"]), where);
            Repeater_admin.DataBind();
            ViewState["PageCon"] = Bll.GetRecordCount(where) / Convert.ToInt32(Application["PageSize"]) + 1;
            ViewState["PageContent"] = Bll.GetRecordCount(where);
            //Bll.GetList("");
            }
            catch //异常处理
            {
                Repeater_admin.DataSource = null;
                Repeater_admin.DataBind();
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void PageSizeTextChanged(object sender, EventArgs e)
        {
            Application["PageSize"] = ((TextBox)Repeater_admin.Controls[Repeater_admin.Controls.Count - 1].FindControl("PageSize")).Text;
            Bind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.StarTime.Text != "" && this.EndTime.Text != "")
            {

                ViewState["StarTime"] = this.StarTime.Text;
                ViewState["EndTime"] = this.EndTime.Text;

            }
            else {
                ViewState["StarTime"] = null;
                ViewState["EndTime"] = null;
            }
            Bind();
        }
    }
}