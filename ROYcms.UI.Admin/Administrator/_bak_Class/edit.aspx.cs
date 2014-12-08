using System;
using System.Data;
using System.Web.UI;
using ROYcms.Common;
using System.IO;
using System.Xml;


namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class class_edit : AdminPage
	{ 
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
        protected int Class
        {
            get
            {
                return (int)ViewState["Class"];
            }
            set
            {
                ViewState["Class"] = value;
            }
        }
        #endregion
		ROYcms.Sys.Model.ROYcms_class model = new ROYcms.Sys.Model.ROYcms_class();
        ROYcms.Sys.BLL.ROYcms_class BLL = new ROYcms.Sys.BLL.ROYcms_class();
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
                this.Class = Convert.ToInt32(Request.QueryString["Id"] == null ? "0" : Request.QueryString["Id"]);
                DateBind();
            }
		}
        /// <summary>
        /// 
        /// </summary>
        void DateBind() 
        {
              model = BLL.GetModel(Request["ClassId"]);
              //模板地址
             txtClassName.Text = model.ClassName.Trim();
             if (model.WebsiteUrl != "")
             {
                 txtWebsiteUrl.Text = model.WebsiteUrl.Trim();
             }
             if (model.FilePath != "")
             {
                 txtFilePath.Text = model.FilePath.Trim();
             }
             else 
             {
                 txtFilePath.Text = "{cmspath}/" + Guid.NewGuid().ToString() + "/";
             }

             txtColumnsType.SelectedValue = model.ColumnsType.ToString();
             if (model.TemplateIndex != "")
             {
                 txtTemplateIndex.Text = model.TemplateIndex.Trim();
             }
             else 
             {
                 txtTemplateIndex.Text = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "default/index.aspx";
             }
             if (model.TemplateList != "")
             {
                 txtTemplateList.Text = model.TemplateList.Trim();
             }
             else
             {
                 txtTemplateList.Text = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "default/list.aspx";
             }
             if (model.TemplateShow != "") 
             {
                 txtTemplateShow.Text = model.TemplateShow.Trim();
             }
             else
             {
                 txtTemplateShow.Text = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "default/show.aspx";
             }
             if (model.ListeRules != "")
             {
                 txtListeRules.Text = model.ListeRules.Trim();
             }
             else
             {
                 txtListeRules.Text = "list_{class}" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_forge");
             }
             if (model.ShowRules != "")
             {
                 txtShowRules.Text = model.ShowRules.Trim();
             }
             else
             {
                 txtShowRules.Text = "show_{id}" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_forge");
             }
             if (model.DefaultFile != "")
             {
                 txtDefaultFile.Text = model.DefaultFile.Trim();
             }
             else
             {
                 txtDefaultFile.Text = "index" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_forge");
             }

             txtkeyword.Text = model.keyword;
             txtDescription.Text = model.Description;
             //Fck.Value = model.contents;
        
        }
        #region 编辑保存栏目信息
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Request["Id"]);
            string ClassId = Request["ClassId"];   
            string ClassName = this.txtClassName.Text.Trim();
            string ClassList = "";                                            //栏目包含列表
            string ClassPre = Request["ClassPre"];              //上一级目录
            int ClassTj = 1;                                                  //栏目深度
            int ClassKind = Convert.ToInt32(Request["ClassKind"]);    

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
            model.Id = Id;
            model.ClassId = ClassId;
            model.ClassName = ClassName;
            model.ClassList = ClassList;
            model.ClassPre = ClassPre;
            model.ClassTj = ClassTj;

            model.ClassOrder = 0;
            model.ClassKind = ClassKind;

            model.ListType = 0;
            model.GoType = 0;
            model.DefaultFile = txtDefaultFile.Text;
            model.FilePath = txtFilePath.Text;
            model.ColumnsType =Convert.ToInt32(txtColumnsType.SelectedValue);
            model.WebsiteUrl = txtWebsiteUrl.Text;
            model.TemplateIndex = txtTemplateIndex.Text;
            model.TemplateList = txtTemplateList.Text;
            model.TemplateShow = txtTemplateShow.Text;
            model.ListeRules = txtListeRules.Text;
            model.ShowRules = txtShowRules.Text;
            model.keyword = txtkeyword.Text;
            model.Description = txtDescription.Text; ;
            model.contents = Request["content"];


            if (new ROYcms.Sys.BLL.ROYcms_class().ClassUpdate(model))
            {
                NewXml(model.Id);
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "ajaxjs", "alert('栏目编辑成功！')", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "ajaxjs", "alert('栏目保存操作失败！')", true);
            }
            //this.txtClassName.Text = "";
           
        }
        #endregion


        /// <summary>
        /// 创建XML 数据文件
        /// </summary>
        /// <param name="ID">The ID.</param>
        /// <returns></returns>
        public bool NewXml(int ID)
        {

            try
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"), null);
                doc.AppendChild(dec);
                //创建一个根节点（一级） 
                XmlElement root = doc.CreateElement("ROYcms");
                doc.AppendChild(root);
                //创建节点（二级） 
                XmlNode node = doc.CreateElement("Class");
                XmlAttribute attr = null;
                attr = doc.CreateAttribute("Time");
                attr.Value = DateTime.Now.ToString();
                node.Attributes.SetNamedItem(attr);
                for (int i = 0; i < Request.Form.Count; i++)
                {
                    //带有"<![CDATA[   ]]>"的元素 
                    if (!Request.Form.GetKey(i).Contains("_"))
                    {
                        XmlElement element = doc.CreateElement(Request.Form.GetKey(i));
                        XmlCDataSection idata = doc.CreateCDataSection("item");
                        idata.InnerText = Request.Form.Get(i);
                        element.AppendChild(idata);
                        node.AppendChild(element);
                    }
                }
                root.AppendChild(node);
                if (!Directory.Exists(Server.MapPath("~/APP_data/Class/")))
                {
                    Directory.CreateDirectory(Server.MapPath("~/APP_data/Class/")); //创建新路径 
                }
                doc.Save(Server.MapPath("~/APP_data/Class/" + ID + ".xml"));
                Console.Write(doc.OuterXml);
                return true;
            }
            catch
            {
                return false;
            }
        }

	}
}
