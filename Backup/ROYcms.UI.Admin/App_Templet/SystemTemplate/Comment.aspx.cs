using System;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Comment : ROYcms.BasePage
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }   
        /// <summary>
        /// 绑定数据    Binds this instance.
        /// </summary>
        void Bind()
        {
            try
            {
                ROYcms.Sys.BLL.ROYcms_remark bll = new ROYcms.Sys.BLL.ROYcms_remark();
                Repeater_list.DataSource = bll.GetList(" NewID =" + Request["NewsId"]);
                Repeater_list.DataBind();
            }
            catch { ROYcms.Common.MessageBox.Show(this, "绑定数据错误！"); }
        }
        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <returns></returns>
        public string GetTitle()
        {
            return ___ROYcms_news_Bll.GetTitle(Convert.ToInt32(Request["NewsId"]));
        }
    }
}
