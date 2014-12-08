using System;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Remark : AdminPage
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
                if (Request["t"] == "del")
                {
                    ROYcms.Sys.BLL.ROYcms_remark bll = new ROYcms.Sys.BLL.ROYcms_remark();
                    bll.Delete(Convert.ToInt32(Request["id"]));

                    Bind();
                }
            }
        }

        /// <summary>
        /// 绑定数据    Binds this instance.
        /// </summary>
        void Bind()
        {
            ROYcms.Sys.BLL.ROYcms_remark bll = new ROYcms.Sys.BLL.ROYcms_remark();

            if (Request["NewsId"] != null)
            {
                Repeater_admin.DataSource = bll.GetList(" NewID =" + Request["NewsId"]);
                Repeater_admin.DataBind();
            }
            else
            {
                Repeater_admin.DataSource = bll.GetList(" NewID <>0");
                Repeater_admin.DataBind();
            }
        }
    }
}
