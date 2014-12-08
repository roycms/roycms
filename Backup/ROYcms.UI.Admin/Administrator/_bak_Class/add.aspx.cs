using System;
using System.Data;
using System.Web.UI;
using ROYcms.Common;
namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class class_add : AdminPage
    {
        ROYcms.Sys.Model.ROYcms_class model = new ROYcms.Sys.Model.ROYcms_class();
        ROYcms.Sys.Model.ROYcms_class _model = new ROYcms.Sys.Model.ROYcms_class();

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

/// <summary>
/// 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
              this.ClassKind = Convert.ToInt32(Request.QueryString["ClassKind"] == null ? "10" : Request.QueryString["ClassKind"]);
              
              //默认模板地址
              txtTemplateIndex.Text = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "default/index.aspx";
              txtTemplateList.Text = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "default/list.aspx";
              txtTemplateShow.Text = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "default/show.aspx";
              if (Request["ClassId"] != null)
              {
                  _model = new ROYcms.Sys.BLL.ROYcms_class().GetModel(Request["ClassId"]);
                  txtFilePath.Text = (_model.FilePath == "" ? "{cmspath}/" : _model.FilePath) + Guid.NewGuid().ToString() + "/";
                  F_Label.Text = _model.ClassName;
              }
             else{
              
               txtFilePath.Text = "{cmspath}/"+ Guid.NewGuid().ToString()+"/";
             
              }
              txtListeRules.Text = "list_{class}" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_forge");
              txtShowRules.Text = "show_{id}" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_forge");
              txtDefaultFile.Text = "index" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_forge");
            }
		}
        #region 添加按钮操作
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int ClassKind = this.ClassKind;            //上一级目录
            string ClassId = ROYcms.Common.StringPlus.GetRamCode();                                //栏目ID
            string ClassName = this.txtClassName.Text.Trim();                                      //栏目名称
            string ClassList = "";                                                                 //栏目包含列表
            string ClassPre = Request["ClassId"] == null ? "0" : Request["ClassId"].Trim();        //上一级目录
            int ClassTj = 1;                                                                       //栏目深度

            if (ClassPre == "0")
            {
                ClassList = ClassId + ",";
                ClassTj = 1;
            }
            else
            {
                DataSet ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassListByClassId(ClassPre);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    ClassList = dr["ClassList"].ToString().Trim() + ClassId + ",";
                    ClassTj = Convert.ToInt32(dr["ClassTj"]) + 1;
                }
            }
            
            model.ClassId = ClassId;
            model.ClassName =ROYcms.Common.input.Htmls(ClassName);
            model.ClassList = ROYcms.Common.input.Htmls(ClassList);
            model.ClassPre = ClassPre;
            model.ClassTj = ClassTj;
            model.ClassKind = ClassKind;

            model.ClassOrder = 0;

            model.ListType = 0;
            model.GoType = 0;
            if (txtDefaultFile.Text != null)
            {
                model.DefaultFile = txtDefaultFile.Text.Trim();
            }
            model.FilePath = txtFilePath.Text;
            model.ColumnsType = Convert.ToInt32(txtColumnsType.SelectedValue);
            model.WebsiteUrl = txtWebsiteUrl.Text;
            model.TemplateIndex = txtTemplateIndex.Text;
            model.TemplateList = txtTemplateList.Text;
            model.TemplateShow = txtTemplateShow.Text;
            model.ListeRules = txtListeRules.Text;
            model.ShowRules = txtShowRules.Text;
            model.keyword = txtkeyword.Text;
            model.Description = txtDescription.Text; ;
            model.contents = Request["content"];


            new ROYcms.Sys.BLL.ROYcms_class().ClassAdd(model);
            this.txtClassName.Text = "";
            ROYcms.Common.MessageBox.Show(this,"添加栏目成功！");
           


        }
        #endregion





        #region 保存栏目信息
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //this.btnEdit.Visible = false;
            //this.btnAdd.Visible = true;
            //string ClassId = this.HidClassId.Value.Trim();
            //string ClassName = this.txtClassName.Text.Trim();
            //string ClassList = "";                                            //栏目包含列表
            //string ClassPre = this.DdlMenu.SelectedValue.Trim();              //上一级目录
            //int ClassTj = 1;                                                  //栏目深度

            //if (ClassPre == "0")
            //{
            //    ClassList = ClassId + ",";
            //    ClassTj = 1;
            //}
            //else
            //{
            //    DataSet ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassListByClassId(ClassPre);

            //    if (ds.Tables[0].Rows.Count > 0)
            //    {
            //        DataRow dr = ds.Tables[0].Rows[0];
            //        ClassList = dr["ClassList"].ToString().Trim() + ClassId + ",";
            //        ClassTj = Convert.ToInt32(dr["ClassTj"]) + 1;
            //    }
            //}
            //model.ClassId = ClassId;
            //model.ClassName = ClassName;
            //model.ClassList = ClassList;
            //model.ClassPre = ClassPre;
            //model.ClassTj = ClassTj;
            
            //model.ClassOrder = 0;
            //model.ClassKind = 0;

            //model.ListType = 0;
            //model.GoType = 0;
            //model.DefaultFile = "";
            //model.ColumnsType = 0;
            //model.WebsiteUrl = "";
            //model.TemplateIndex = "";
            //model.TemplateList = "";
            //model.TemplateShow = "";
            //model.ListeRules = "";
            //model.ShowRules = "";
            //model.keyword = "";
            //model.Description = "";
            //model.contents = "";
            //if (new ROYcms.Sys.BLL.ROYcms_class().ClassSave(model))
            //{
            //    Page.ClientScript.RegisterStartupScript(Page.GetType(), "ajaxjs", "alert('栏目保存成功！')", true);
            //}
            //else
            //{
            //    Page.ClientScript.RegisterStartupScript(Page.GetType(), "ajaxjs", "alert('栏目保存操作失败！')", true);
            //}
            //this.txtClassName.Text = "";
           
        }
        #endregion



	}
}
