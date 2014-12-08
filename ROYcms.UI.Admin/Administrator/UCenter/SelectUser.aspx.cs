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
    public partial class Administrator_SelectUser : AdminPage
    {
        private int _pages;
        /// <summary>
        /// Gets or sets the pages.
        /// </summary>
        /// <value>The pages.</value>
        public int pages
        {
            set { _pages = value; }
            get { return _pages; }
        }
        /// <summary>
        /// 
        /// </summary>

        ROYcms.Sys.BLL.ROYcms_user Bll = new ROYcms.Sys.BLL.ROYcms_user();
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UGroup_DropDownList_bind();
                PreIndex();
                Bind();
                
                if (Request["t"] == "del")
                {
                    Bll.Delete(Convert.ToInt32(Request["bh"]));
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
            ViewState["UGroup"] = ViewState["UGroup"] == null ? UGroup_DropDownList.SelectedValue : ViewState["UGroup"];
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
                where = "(name like '%" + ViewState["KeyWord"].ToString() + "%')  AND ";
            }
            if (ViewState["UGroup"].ToString() != "0")
            {
                where += "UgroupID ='" + ViewState["UGroup"].ToString() + "' AND ";
            }
            if (ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("ucenter_webserver") == "index")
            {
                where += " GUID='" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("guid") + "' AND ";
            }
            where += " bh>-1 ";

            //try
            //{
                Repeater_admin.DataSource = Bll.GetList(Convert.ToInt32(Application["PageSize"]), Convert.ToInt32(ViewState["Page"]), where);
                Repeater_admin.DataBind();
                ViewState["PageCon"] = Bll.GetCount(where) / Convert.ToInt32(Application["PageSize"]) + 1;
                ViewState["PageContent"] = Bll.GetCount(where);
            //}
            //catch //异常处理
            //{
            //    Repeater_admin.DataSource = null;
            //    Repeater_admin.DataBind();
            //}

        }

        #region 数据绑定
        /// <summary>
        /// DDLs the menu_bind.
        /// </summary>
        void UGroup_DropDownList_bind()
        {
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_UGroup().GetAllList();

            this.UGroup_DropDownList.Items.Clear();
            this.UGroup_DropDownList.Items.Add(new ListItem("所属工作组", "0"));
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string Id = dr["id"].ToString().Trim();
                string Name = dr["name"].ToString().Trim();

                this.UGroup_DropDownList.Items.Add(new ListItem(Name, Id));
            }

        }
        #endregion

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
                    Bll.Delete(id);
                    nub += 1;
                }
            }
            Response.Redirect("/administrator/Message.aspx?message=批量删除<b>" + nub + "</b>条信息成功！&z=yes");
        }

        /// <summary>
        /// Get_s the enterprise.
        /// </summary>
        /// <param name="uid">The uid.</param>
        /// <returns></returns>
        public string get_Enterprise(string uid) 
        {
            string er=null;
            ROYcms.Sys.BLL.ROYcms_Enterprise BLL_Enterprise = new ROYcms.Sys.BLL.ROYcms_Enterprise();
            ROYcms.Sys.Model.ROYcms_Enterprise Model = new ROYcms.Sys.Model.ROYcms_Enterprise();
            if (BLL_Enterprise._GetModel(Convert.ToInt32(uid)) == null)
            {
                er = "未注册公司信息-[X]";
            }
            else
            {
                Model = BLL_Enterprise._GetModel(Convert.ToInt32(uid));
                er = Model.gs_name + "-[√]";
            }
            return er;    
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public string get_ip_city(string ip)
        {
           // ip = ip.Remove(ip.LastIndexOf(".")-1);
            //if (ROYcms.DB.DbHelpers.GetSingle("select city from ROYcms_Ip where ip='" + ip + "'") == null)
            //{ return "其它地区"; }
            //else {  return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle("select city from ROYcms_Ip where ip='" + ip + "'"));}

            return "未知地区";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Submit_Click(object sender, EventArgs e)
        {
            ViewState["KeyWord"] = keywords.Value;

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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void UGroup_DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewState["UGroup"] = UGroup_DropDownList.SelectedValue;
            Bind();
        }
    }
}
