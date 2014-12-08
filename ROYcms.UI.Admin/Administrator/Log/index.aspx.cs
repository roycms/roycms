using System;
using ROYcms.Common;
using ROYcms.Sys.BLL;
using System.Web.UI.WebControls;
using System.Data;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_log : ROYcms.AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        ROYcms.Sys.BLL.ROYcms_Log BLL = new ROYcms.Sys.BLL.ROYcms_Log();
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
            ViewState["Err_id"] = ViewState["Err_id"] == null ? Type_DropDownList.SelectedValue : ViewState["Err_id"];
            
            ViewState["Page"] = ROYcms.Common.Request.GetQueryString("Page") == "" ? "1" : ROYcms.Common.Request.GetQueryString("Page");
            //ViewState["PageCon"] = ViewState["PageCon"] ==null:30;
            //ViewState["KeyWord"] = keywords.Value;
            Application["PageSize"] = Application["PageSize"] == null ? "20" : Application["PageSize"];
        }
        /// <summary>
        /// Binds this instance.
        /// </summary>
        void Bind()
        {
            string where = null;
            if (ViewState["KeyWord"] != null)
            {
                where = "(Content like '%" + ViewState["KeyWord"].ToString() + "%')  AND ";
            }
            if (ViewState["Err_id"].ToString() != "0")
            {
                where += "Err_id =" + ViewState["Err_id"].ToString() + " AND ";
            }
            where += " id>-1";
            //try
            //{
                Repeater_admin.DataSource = BLL.GetList(Convert.ToInt32(Application["PageSize"]), Convert.ToInt32(ViewState["Page"]), where);
                Repeater_admin.DataBind();
                ViewState["PageCon"] = BLL.GetCount(where) / Convert.ToInt32(Application["PageSize"]) + 1;
                ViewState["PageContent"] = BLL.GetCount(where);
            //}
            //catch //异常处理
            //{
            //    Repeater_admin.DataSource = null;
            //    Repeater_admin.DataBind();
            //}

            keywords.Value = "";
            ViewState["KeyWord"] = null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Type_DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewState["Err_id"] = Type_DropDownList.SelectedValue;
            Bind();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Submit_Click(object sender, EventArgs e)
        {
            ViewState["KeyWord"] = Submit.Text;
            Bind();
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
        /// <summary>
        /// 返回操作人
        /// </summary>
        /// <param name="AdminName"></param>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public string GetEventPepole(string AdminName,string UserName)
        {
            if (UserName != "")
            {
                return "用户:" + new ROYcms.Sys.BLL.ROYcms_user().GetField(Convert.ToInt32(UserName), "name");
            }
            else if (AdminName != "")
            {
                return "管理员:" + new ROYcms.Sys.BLL.ROYcms_Admin().GetModel(Convert.ToInt32(AdminName)).name;
            }
            else { return "System"; }
        }
        /// <summary>
        /// Handles the Click event of the ImageButton_all_del control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Web.UI.ImageClickEventArgs"/> instance containing the event data.</param>
        protected void ImageButton_all_del_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            //批量删除
            int nub = 0;
            for (int i = 0; i < Repeater_admin.Items.Count; i++)
            {
                int id = Convert.ToInt32(((Label)Repeater_admin.Items[i].FindControl("Label_id")).Text);
                CheckBox CK = (CheckBox)Repeater_admin.Items[i].FindControl("ID_list");
                if (CK.Checked)
                {
                    BLL.Delete(id);
                    nub += 1;
                }
            }
            Response.Redirect("/administrator/Message.aspx?message=批量删除<b>" + nub + "</b>条信息成功！&z=yes");
        }
    }
}
