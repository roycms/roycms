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
using ROYcms.Sys.BLL;

namespace ROYcms.UI.Admin.Administrator.App_Api
{
    public partial class search : ROYcms.BasePage
    { 
        #region PageCont属性
        /// <summary>
        /// XML help?
        /// </summary>
        protected int PageCont
        {
            get
            {
                return (int)ViewState["PageCont"];
            }
            set
            {
                ViewState["PageCont"] = value;
            }
        }
        #endregion
        #region keyword属性
        /// <summary>
        /// 
        /// </summary>
        protected string keyword
        {
            get
            {
                return (string)ViewState["keyword"];
            }
            set
            {
                ViewState["keyword"] = value;
            }
        }
        #endregion
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    //Request.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");//设置字符编码
                    this.keyword = Server.UrlDecode(Request["keyword"]);
                    Page.Title = this.keyword + " 的搜索结果 -" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_name");
                    Bind();
                    TextBox_keyword.Text = this.keyword;
                }
            }
            catch { Response.Clear();
            Response.Write("搜索失败！<a href=" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host") + ">返回</a>");
            }
        }
        /// <summary>
        /// Binds this instance.
        /// </summary>
        void Bind()
        {
            if (this.keyword == null || this.keyword=="")
            { this.keyword = "请输入关键字"; }
            int page = 0;
            string where = "";
            if (Request["page"] != null && Request["page"] != "")
            {
                page = Convert.ToInt32(Request["page"]) - 1;
            }
            if (DropDownList_type.SelectedValue != "") { where = DropDownList_type.SelectedValue + " like '%" + this.keyword + "%' "; }
            else { where = " title like '%" + this.keyword + "%' "; }
            this.PageCont = ___ROYcms_news_Bll.GetCount(where) / 30 + 1; //分页的总数          
            PagedDataSource pg = new PagedDataSource();
            pg.DataSource = ___ROYcms_news_Bll.GetList(where + " order by bh desc ").Tables[0].DefaultView;
            pg.AllowPaging = true;
            pg.PageSize = 30;
            pg.CurrentPageIndex = page;
            Repeater_list.DataSource = pg;
            Repeater_list.DataBind();
        }
        /// <summary>
        /// Handles the Click event of the Button_Search control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Button_Search_Click(object sender, EventArgs e)
        {

            this.keyword = TextBox_keyword.Text;
            Page.Title = this.keyword + " 的搜索结果 -" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_name");
            Bind();
        }
    }
}
