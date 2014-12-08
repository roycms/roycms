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
    public partial class Administrator_Objet_admin : ROYcms.AdminPage
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

                ViewState["ClassKind"] = ViewState["ClassKind"] == null ? ROYcms.Common.Request.GetQueryInt("ClassKind") : ViewState["ClassKind"];
                ViewState["Class"] = ViewState["Class"] == null ? ROYcms.Common.Request.GetQueryString("Class") : ViewState["Class"];
            
                DdlMenu_bind();
                DdlMenu.SelectedValue = ViewState["Class"].ToString(); 
                
                PreIndex();
                Repeater_admin_bind();
            }
        }
        /// <summary>
        /// 初始值赋值
        /// </summary>
        public void PreIndex()
        {
         
            ViewState["Page"] = ROYcms.Common.Request.GetQueryString("Page") == "" ? "1" : ROYcms.Common.Request.GetQueryString("Page");
            Application["PageSize"] = Application["PageSize"] == null ? "20" : Application["PageSize"];
            ViewState["State"] = ViewState["State"] == null ? DdState.SelectedValue : ViewState["State"];
            ViewState["Attribute"] = ViewState["Attribute"] == null ? DdAttribute.SelectedValue : ViewState["Attribute"];
            ViewState["Time"] = ViewState["Time"] == null ? DdTime.SelectedValue : ViewState["Time"];
        }
        /// <summary>
        /// Repeater_admin_binds the specified classs.
        /// </summary>
        void Repeater_admin_bind()
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

            string where = "";
            if (ViewState["KeyWord"] != null)
            {
                where = "(title like '%" + ViewState["KeyWord"].ToString() + "%')  AND ";
            }
            if (ViewState["Time"].ToString() != "0") 
            {
                where += "datediff(dd,time,getdate())=" + ViewState["Time"].ToString() + " AND ";
            }
            if (ViewState["State"].ToString() != "0")
            {
                where += "switchs =" + ViewState["State"].ToString() + " AND ";
            }
            if (ViewState["Class"].ToString() != "0" && ViewState["Class"].ToString()!="")
            {
                where += "classname =" + ViewState["Class"].ToString() + " AND ";
            }
            where += "(type = '" + ViewState["ClassKind"].ToString() + "') ";
            
            try
            {
                ROYcms_news Bll = new ROYcms_news();
                Repeater_admin.DataSource = Bll.GetList(Convert.ToInt32(Application["PageSize"]), Convert.ToInt32(ViewState["Page"]), where, 1);
                Repeater_admin.DataBind();
                ViewState["PageCon"] = Bll.GetCount(where) / Convert.ToInt32(Application["PageSize"])+1;
                ViewState["PageContent"] = Bll.GetCount(where);
            }
            catch //异常处理
            {
                Repeater_admin.DataSource = null;
                Repeater_admin.DataBind();
            }

            keywords.Value = "";
            ViewState["KeyWord"] = null;

           // Label1.Text = where;
        }


        #region 数据绑定
        /// <summary>
        /// 菜单绑定
        /// </summary>
        void DdlMenu_bind()
        {
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassList(Convert.ToInt32(ViewState["ClassKind"]));
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
            //NewHtml(null, Convert.ToInt32(Request["class"]));
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
        /// 选择频道
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void DdlMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
               ViewState["Class"] = DdlMenu.SelectedValue;
               Response.Redirect(String.Format("/administrator/objet/admin.aspx?class={0}&classkind={1}", ViewState["Class"], ViewState["ClassKind"]));
               //Repeater_admin_bind();
        }
        /// <summary>
        /// 选择文章状态
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void DdState_SelectedIndexChanged(object sender, EventArgs e)
        {
              ViewState["State"] = DdState.SelectedValue;
             
              Repeater_admin_bind();
        }
        /// <summary>
        /// 选择文章属性
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void DdAttribute_SelectedIndexChanged(object sender, EventArgs e)
        {
              ViewState["Attribute"] = DdAttribute.SelectedValue;
             
              Repeater_admin_bind();
        }
        /// <summary>
        /// 选择文章发布时间
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void DdTime_SelectedIndexChanged(object sender, EventArgs e)
        {
              ViewState["Time"] = DdTime.SelectedValue;
             
              Repeater_admin_bind();
        } 
        /// <summary>
        /// 搜索 根据关键词
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Submit_Click(object sender, EventArgs e)
        {
            ViewState["KeyWord"] = keywords.Value;
          
            Repeater_admin_bind();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void PageSizeTextChanged(object sender, EventArgs e)
        {
            Application["PageSize"] = ((TextBox)Repeater_admin.Controls[Repeater_admin.Controls.Count - 1].FindControl("PageSize")).Text;
            Repeater_admin_bind();
        }
        /// <summary>
        /// Get_classnames the specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public string get_classname(int id) 
        {
            ROYcms.Sys.BLL.ROYcms_class bll = new ROYcms_class();
            return bll.GetClassTitle(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_toclass_Click(object sender, EventArgs e)
        {
           // to_class(Convert.ToInt32(ListBox_to.SelectedValue));
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