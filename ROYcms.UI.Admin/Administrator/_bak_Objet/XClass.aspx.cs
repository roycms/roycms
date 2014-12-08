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

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_Objet_XClass : AdminPage
    {        
        #region ClassKind属性
        /// <summary>
        /// Gets or sets the kind of the class.
        /// </summary>
        /// <value>The kind of the class.</value>
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
                DdlMenu_bind();
                XClass_bind("");
                
            }
        }       
        #region 数据绑定
        /// <summary>
        /// Xs the class_bind.
        /// </summary>
        /// <param name="classid">The classid.</param>
        void XClass_bind(string classid)
        {
            DataSet ds = new DataSet();
            if (classid != "")
            {
                ds = new ROYcms.Sys.BLL.ROYcms_class().GetSubClassList(classid);
            }
            else
            {
                ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassList(this.ClassKind);
            }
            this.Repeater_XClass.DataSource = ds;
            this.Repeater_XClass.DataBind();
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the Button_add control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Button_add_Click(object sender, EventArgs e)
        {
            string Class = "";
            for (int i = 0; i < Repeater_XClass.Items.Count; i++)
            {
                int id = Convert.ToInt32(((Label)Repeater_XClass.Items[i].FindControl("Label_id")).Text);
                CheckBox CK = (CheckBox)Repeater_XClass.Items[i].FindControl("ID_list");
                if (CK.Checked)
                {
                    Class += "," + id;
                }
               
            }
            //当筛选到最后一一级分类的时候
            if (Repeater_XClass.Items.Count < 1)
            {
                if (DdlMenu.SelectedValue != "")
                {
                    ROYcms.Sys.Model.ROYcms_class Model = new ROYcms.Sys.BLL.ROYcms_class().GetModel(DdlMenu.SelectedValue);
                    Class = "," + Model.Id;
                }
                else
                {
                    ROYcms.Common.MessageBox.Show(this, "没有分类请创建分类！");
                }
            }
            //什么也没有选择
            if (Class != "")
            {
                Class = Class.Substring(1, Class.Length - 1);
                Response.Redirect("Insert.aspx?ClassKind=" + this.ClassKind + "&Class=" + Class);
            }
            else { ROYcms.Common.MessageBox.Show(this, "请在需要发布到的分类上打钩！"); }
            
        }

        #region 数据绑定
        /// <summary>
        /// DDLs the menu_bind.
        /// </summary>
        void DdlMenu_bind()
        {
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassList(this.ClassKind);

            this.DdlMenu.Items.Clear();
            this.DdlMenu.Items.Add(new ListItem("请选择所属分类", ""));
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int ClassTj = Convert.ToInt32(dr["ClassTj"]);
                string Id = dr["ClassId"].ToString().Trim();
                string ClassName = dr["ClassName"].ToString().Trim();

                if (ClassTj == 1)
                {
                    this.DdlMenu.Items.Add(new ListItem(ClassName, Id));

                }
                else
                {
                    ClassName = "├ " + ClassName;
                    ClassName = ROYcms.Common.StringPlus.StringOfChar(ClassTj - 1, "　") + ClassName;

                    this.DdlMenu.Items.Add(new System.Web.UI.WebControls.ListItem(ClassName, Id));
                }
            }

        }
        #endregion

        /// <summary>
        /// Handles the SelectedIndexChanged event of the DdlMenu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void DdlMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            XClass_bind(DdlMenu.SelectedValue);
        }
    }
}
