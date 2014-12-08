using System;
using ROYcms.Common;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_Enterprise_Enterprise : AdminPage
    {
        private int _pages;
        /// <summary>
        /// 分页  标识  第几页Gets or sets the pages.
        /// </summary>
        /// <value>The pages.</value>
        public int pages
        {
            set { _pages = value; }
            get { return _pages; }
        }
        ROYcms.Sys.BLL.ROYcms_user Bll = new ROYcms.Sys.BLL.ROYcms_user();
        /// <summary>
        /// XML help?
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Bind();
                if (Request["t"] == "del")
                {
                    del(Convert.ToInt32(Request["bh"]));
                    Bind();
                }
            }

        }

        /// <summary>
        ///得到数据集合 Binds this instance.
        /// </summary>
        void Bind()
        {
            
            int page = 0;
            if (Request["page"] != null)
            {
                page = Convert.ToInt32(Request["page"]) - 1;
            }

            string where = null;
            if (ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("ucenter_webserver") == "index")
            {
                where = " GUID='" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("guid") + "' AND";
            }
            where += " quanxian='Enterprise' ";
            pages = Bll.GetCount(where) / 18 + 1; //分页的总数          
            PagedDataSource pg = new PagedDataSource();
            pg.DataSource = Bll.GetList(where+" order by bh desc ").Tables[0].DefaultView;
            pg.AllowPaging = true;
            pg.PageSize = 18;
            pg.CurrentPageIndex = page;
            Repeater_admin_user.DataSource = pg;
            Repeater_admin_user.DataBind();
        }

        /// <summary>
        /// 删除一条数据 Dels the specified bh.
        /// </summary>
        /// <param name="bh">The bh.</param>
        void del(int bh)
        {

            Bll.Delete(bh);
           
        }


        /// <summary>
        /// 批量删除事件 Handles the Click event of the ImageButton_all_del control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Web.UI.ImageClickEventArgs"/> instance containing the event data.</param>
        protected void ImageButton_all_del_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            //批量删除
            int nub = 0;
            for (int i = 0; i < Repeater_admin_user.Items.Count; i++)
            {
                int id = Convert.ToInt32(((Label)Repeater_admin_user.Items[i].FindControl("Label_id")).Text);
                CheckBox CK = (CheckBox)Repeater_admin_user.Items[i].FindControl("ID_list");
                if (CK.Checked)
                {
                    del(id);
                    nub += 1;
                }
            }
            Response.Redirect("/administrator/Message.aspx?message=批量删除<b>" + nub + "</b>条信息成功！&z=yes");
        }

        /// <summary>
        /// 判断组织机构性质  Get_s the enterprise.
        /// </summary>
        /// <param name="uid">The uid.用户ID</param>
        /// <returns></returns>
        public string get_Enterprise(string uid) 
        {
            string er=null;
            ROYcms.Sys.BLL.ROYcms_Enterprise BLL_Enterprise = new ROYcms.Sys.BLL.ROYcms_Enterprise();
            ROYcms.Sys.Model.ROYcms_Enterprise Model = new ROYcms.Sys.Model.ROYcms_Enterprise();
            if (BLL_Enterprise._GetModel(Convert.ToInt32(uid)) == null)
            {
                er = "未注册机构信息";
            }
            else
            {
                Model = BLL_Enterprise._GetModel(Convert.ToInt32(uid));
                er = Model.gs_name + "-[已注册组织机构√]";
            }
            return er;    
        }
    }
}
