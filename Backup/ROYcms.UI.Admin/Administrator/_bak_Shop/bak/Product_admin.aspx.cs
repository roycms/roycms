/**********************************************************************************
 * Description:     
 * MemberVariable:
 * Functions:       
 * Modify information:     
 * 2008-8-5     New           DuYaoHui     Create Class
 * 
 * ********************************************************************************/
using System;
using System.Data;
using System.Web.UI.WebControls;
using ROYcms.Sys.BLL;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_Product_admin : AdminPage
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
        #region ClassKind属性
        /// <summary>
        /// 
        /// </summary>
        protected int ClassKind
        {
            get
            {
                return (int)ViewState["ClassKind"];
            }
            set
            {
                ViewState["ClassKind"] = value;
            }
        }
        #endregion
        #region Class属性
        /// <summary>
        /// 
        /// </summary>
        protected string Class
        {
            get
            {
                return (string)ViewState["Class"];
            }
            set
            {
                ViewState["Class"] = value;
            }
        }
        #endregion
        #region keyword属性/
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

            if (!IsPostBack)
            {
                this.ClassKind = Convert.ToInt32(Request.QueryString["ClassKind"]);
                //批量转移

                DdlMenu_bind();
                Repeater_admin_bind(this.Class);
            }
        }
        /// <summary>
        /// Repeater_admin_binds the specified classs.
        /// </summary>
        /// <param name="classs">The classs.</param>
        void Repeater_admin_bind(string classs)
        {
            switch (Request["t"])
            {
                case "del":
                    del_news(Convert.ToInt32(Request["id"]));
                    break;
                case "ding":
                    if (Request["ding"] == "1") { Ding_news(Convert.ToInt32(Request["id"]), 0); }
                    else { Ding_news(Convert.ToInt32(Request["id"]), 1); }
                    break;
                case "tuijian":
                    if (Request["tuijian"] == "1") { Tuijian_news(Convert.ToInt32(Request["id"]), 0); }
                    else { Tuijian_news(Convert.ToInt32(Request["id"]), 1); }
                    break;
                case "K":
                    if (Request["K"] == "0") { K_news(Convert.ToInt32(Request["id"]), 1); }
                    else { K_news(Convert.ToInt32(Request["id"]), 0); }
                    break;
                    
            }


            int page = 0;
            string where = "";
            if (Request["page"] != null && Request["page"]!="")
            {
                page = Convert.ToInt32(Request["page"]) - 1;
            }
            if (this.keyword != null)
            {
                where = " (title like '%" + this.keyword.Trim() + "%') ";
            }

            if (classs != null)
            {
                where = " classname =" + classs;
            }
            if (Request["day"] != null) 
            {
                where = " datediff(dd,time,getdate())=" + Request["day"] ; 
            }

            if (where != "")
            {
                //if (Request["role"] != null && ROYcms.Common.Session.Gets("User") != null)
                //{ where = where + " and bh in(select New_id from ROYcms_new_user where User_id =)" + ROYcms.Common.Session.Gets("Users")[1]; }

                where = where + " and (type = '" + this.ClassKind.ToString() + "') ";
            }
            else
            {
                where = " type = '" + this.ClassKind.ToString() + "' ";
                //if (Request["role"] != null && ROYcms.Common.Session.Gets("User") != null) 
                //{ where = where + " and bh in(select New_id from ROYcms_new_user where User_id =)"+ROYcms.Common.Session.Gets("Users")[1]; }
            }

            ROYcms_news Bll = new ROYcms_news();
            pages = Bll.GetCount(where) / 18 + 1; //分页的总数          
            PagedDataSource pg = new PagedDataSource();
            pg.DataSource = Bll.GetList(where+" order by bh desc ").Tables[0].DefaultView;
            pg.AllowPaging = true;
            pg.PageSize = 18;
            pg.CurrentPageIndex = page;
            Repeater_admin.DataSource = pg;
            Repeater_admin.DataBind();
        }


        #region 数据绑定
        void DdlMenu_bind()
        {

            //this.btnAdd.Attributes.Add("onclick", "return ChkInput()");
            //this.btnEdit.Attributes.Add("onclick", "return ChkInput()");

            DataSet ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassList(this.ClassKind);

            //this.rptMenuList.DataSource = ds.Tables[0].DefaultView;
            //this.rptMenuList.DataBind();

            this.DdlMenu.Items.Clear();
            this.DdlMenu.Items.Add(new ListItem("请选择所属分类", ""));
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int ClassTj = Convert.ToInt32(dr["ClassTj"]);
                string ClassId = dr["Id"].ToString().Trim();
                string ClassName = dr["ClassName"].ToString().Trim() + "[ID:"+dr["Id"].ToString()+"]";

                if (ClassTj == 1)
                {
                    this.DdlMenu.Items.Add(new ListItem(ClassName, ClassId));

                }
                else
                {
                    ClassName = "├ " + ClassName;
                    ClassName = ROYcms.Common.StringPlus.StringOfChar(ClassTj - 1, "　") + ClassName;

                    this.DdlMenu.Items.Add(new System.Web.UI.WebControls.ListItem(ClassName, ClassId));
                }
            }

        }
        #endregion

        /// <summary>
        /// Del_newses the specified bh.
        /// </summary>
        /// <param name="bh">The bh.</param>
        void del_news(int bh)
        {
            //更新静态生成文件
            NewHtml(null, Convert.ToInt32(Request["class"]));
            //删除新闻生成文件
            //new ROYcms.Templet.NewShow().DelHtml(bh);

            ROYcms_news BLL = new ROYcms_news();
            BLL.Delete(bh);

        }
        //  
        /// <summary>
        /// K_newses the specified bh.控制开关 打开 和关闭一条数据
        /// </summary>
        /// <param name="bh">The bh.</param>
        /// <param name="on_of">The on_of.</param>
        void K_news(int bh, int on_of)
        {
            ROYcms_news BLL = new ROYcms_news();
            BLL.K_news(bh, on_of);
        }
       
        /// <summary>
        /// Ding_newses the specified bh. //修改一条数据是否置顶  推荐
        /// </summary>
        /// <param name="bh">The bh.</param>
        /// <param name="ding">The ding.</param>
        void Ding_news(int bh, int ding)
        {

            ROYcms_news BLL = new ROYcms_news();
            BLL.Ding_news(bh, ding);
        }
        /// <summary>
        /// Tuijian_newses the specified bh.
        /// </summary>
        /// <param name="bh">The bh.</param>
        /// <param name="tuijian">The tuijian.</param>
        void Tuijian_news(int bh, int tuijian)
        {

            ROYcms_news BLL = new ROYcms_news();
            BLL.Tuijian_news(bh, tuijian);
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
                    del_news(id);
                    nub += 1;
                }
            }
            Response.Redirect("/administrator/Message.aspx?message=批量删除<b>" + nub + "</b>条信息成功！&z=yes");
        }

        /// <summary>
        /// Handles the Click event of the ImageButton_ding control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Web.UI.ImageClickEventArgs"/> instance containing the event data.</param>
        protected void ImageButton_ding_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            //批量置顶
            int nub = 0;
            for (int i = 0; i < Repeater_admin.Items.Count; i++)
            {
                int id = Convert.ToInt32(((Label)Repeater_admin.Items[i].FindControl("Label_id")).Text);
                CheckBox CK = (CheckBox)Repeater_admin.Items[i].FindControl("ID_list");
                if (CK.Checked)
                {
                    Ding_news(id, 0);
                    nub += 1;
                }
            }
            Response.Redirect("/administrator/Message.aspx?message=批量置顶<b>" + nub + "</b>条信息成功！&z=yes");
        }
        /// <summary>
        /// Handles the Click event of the ImageButton_K control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Web.UI.ImageClickEventArgs"/> instance containing the event data.</param>
        protected void ImageButton_K_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            //批量验证
            int nub = 0;
            for (int i = 0; i < Repeater_admin.Items.Count; i++)
            {
                int id = Convert.ToInt32(((Label)Repeater_admin.Items[i].FindControl("Label_id")).Text);
                CheckBox CK = (CheckBox)Repeater_admin.Items[i].FindControl("ID_list");
                if (CK.Checked)
                {
                    K_news(id, 0);
                    nub += 1;
                }
            }
            Response.Redirect("/administrator/Message.aspx?message=批量验证<b>" + nub + "</b>条信息成功！&z=yes");
        }
        /// <summary>
        /// 批量推荐按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton_tuijian_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            //批量推荐
            int nub = 0;
            for (int i = 0; i < Repeater_admin.Items.Count; i++)
            {
                int id = Convert.ToInt32(((Label)Repeater_admin.Items[i].FindControl("Label_id")).Text);
                CheckBox CK = (CheckBox)Repeater_admin.Items[i].FindControl("ID_list");
                if (CK.Checked)
                {
                    Tuijian_news(id, 0);
                    nub += 1;
                }
            }
            Response.Redirect("/administrator/Message.aspx?message=批量推荐<b>" + nub + "</b>条信息成功！&z=yes");
        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of the DdlMenu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void DdlMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DdlMenu.SelectedValue != "")
            {
                this.Class = DdlMenu.SelectedValue.Trim();
                Repeater_admin_bind(this.Class);
            }

        }

        /// <summary>
        /// Get_classnames the specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public string get_classname(int id) {

            ROYcms.Sys.BLL.ROYcms_class bll = new ROYcms_class();
            
            return bll.GetClassTitle(id);
        
        }
        /// <summary>
        /// 生成静态HTML文件 News the HTML.
        /// </summary>
        public void NewHtml(int? bh, int classname)
        {
            //if (ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("HTML") == "true")
            //{
            //    ROYcms.Templet.NewIndex NewIndex = new ROYcms.Templet.NewIndex();
            //    ROYcms.Templet.NewList NewList = new ROYcms.Templet.NewList();
            //    ROYcms.Templet.NewShow NewShow = new ROYcms.Templet.NewShow();
            //    ROYcms.Sys.BLL.ROYcms_class BLL = new ROYcms.Sys.BLL.ROYcms_class();
            //    ROYcms.Sys.Model.ROYcms_class model = BLL.GetModel(BLL.GetClassId(Convert.ToInt32(classname)));

            //    NewList.classname = classname;
            //    NewList.onepage = 30;
            //    NewList.NewHtml(model);

            //    NewList.NewAllHtml(model.ClassKind);

            //    NewShow.bh = bh;
            //    NewShow.NewHtml(model);

            //    NewIndex.NewHtml();
            //}
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Submit_Click(object sender, EventArgs e)
        {
            this.keyword=this.keywords.Value;
            Repeater_admin_bind(this.Class);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_toclass_Click(object sender, EventArgs e)
        {
            //to_class(Convert.ToInt32(ListBox_to.SelectedValue));
        }
        /// <summary>
        /// 批量转移方法
        /// </summary>
        /// <param name="to_class"></param>
        protected void to_class(int to_class)
        {
            //批量转移信息
            int nub = 0;
            for (int i = 0; i < Repeater_admin.Items.Count; i++)
            {
                int id = Convert.ToInt32(((Label)Repeater_admin.Items[i].FindControl("Label_id")).Text);
                CheckBox CK = (CheckBox)Repeater_admin.Items[i].FindControl("ID_list");
                if (CK.Checked)
                {
                    ___ROYcms_news_Bll.ToClass(to_class, id);
                    nub += 1;
                }
            }
            Response.Redirect("/administrator/Message.aspx?message=批量转移<b>" + nub + "</b>条信息成功！&z=yes");
        }
    }
}