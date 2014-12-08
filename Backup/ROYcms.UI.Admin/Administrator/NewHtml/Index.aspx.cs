using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ROYcms.UI.Admin.Administrator.NewHtml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Index : ROYcms.AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DdClassKing_bind();
                if (ViewState["ClassKind"] != null)
                {
                    this.DdClass.Visible = true;
                    DdClass_bind();
                }
                else
                {
                   this.DdClass.Visible = false;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DdClassKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.DdClassKind.SelectedValue != "0")
            {
                ViewState["ClassKind"] = this.DdClassKind.SelectedValue;
                this.DdClass.Visible = true;
                DdClass_bind();
            }
            else { 
                ViewState["ClassKind"] = null;
            }
        }
        #region 数据绑定
        void DdClassKing_bind()
        {
            this.DdClassKind.Items.Add(new ListItem("所有模块", "0")); 
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_Objet().GetAllList();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string Id = dr["ClassKind"].ToString().Trim();
                string Name = dr["Title"].ToString().Trim();
                this.DdClassKind.Items.Add(new ListItem(Name, Id)); 
            }
        }
        /// <summary>
        /// 菜单绑定
        /// </summary>
        void DdClass_bind()
        {
            this.DdClass.Items.Clear();
            this.DdClass.Items.Add(new System.Web.UI.WebControls.ListItem("所有频道", "0"));
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassList(Convert.ToInt32(ViewState["ClassKind"]));
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int ClassTj = Convert.ToInt32(dr["ClassTj"]);
                string ClassId = dr["Id"].ToString().Trim();
                string ClassName = dr["ClassName"].ToString().Trim() + "[ID:" + dr["Id"].ToString() + "]";

                if (ClassTj == 1)
                {
                    this.DdClass.Items.Add(new ListItem(ClassName, ClassId));
                }
                else
                {
                    ClassName = "├ " + ClassName;
                    ClassName = ROYcms.Common.StringPlus.StringOfChar(ClassTj - 1, "　") + ClassName;
                    this.DdClass.Items.Add(new System.Web.UI.WebControls.ListItem(ClassName, ClassId));
                }
            }

        }
        #endregion
    }
}