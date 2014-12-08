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

namespace ROYcms.UI.Admin.Administrator.Class
{
    /// <summary>
    /// AJAXInsert
    /// </summary>
    public partial class AJAXInsert : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_class Model = new ROYcms.Sys.Model.ROYcms_class();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_class BLL = new ROYcms.Sys.BLL.ROYcms_class();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            int PRE = Insert();
            Response.ContentType = "text/plain";
            Response.Write(PRE);
        }

        /// <summary>
        /// 添加一个频道
        /// </summary>
        public int Insert()
        {
            Model.Id = ROYcms.Common.Request.GetFormInt("Id");
            if (Model.Id > 0) //   如果是编辑
            {
                Model = BLL._GetModel(Model.Id.ToString());
            }
            else
            {
                Model.ClassId = ROYcms.Common.StringPlus.GetRamCode();
                string ClassList = "";                                                    //栏目包含列表
                string ClassPre = ROYcms.Common.Request.GetFormString("ClassId") == "" ? "0" : ROYcms.Common.Request.GetFormString("ClassId");         //父亲级ID
                int ClassTj = 1;                                                          //栏目深度
                if (ClassPre == "0") //是顶层
                {
                    ClassList = Model.ClassId + ",";
                    ClassTj = 1;
                }
                else
                {
                    DataSet ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassListByClassId(ClassPre);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = ds.Tables[0].Rows[0];
                        ClassList = dr["ClassList"].ToString().Trim() + Model.ClassId + ",";
                        ClassTj = Convert.ToInt32(dr["ClassTj"]) + 1;
                    }
                }
                Model.ClassList = ClassList;
                Model.ClassPre = ClassPre;
                Model.ClassTj = ClassTj;
            }

            Model.ClassName = ROYcms.Common.Request.GetFormString("ClassName");
            Model.ClassKind = ROYcms.Common.Request.GetFormInt("ClassKind");

            Model.ClassOrder = 0;
            Model.ListType = 0;
            Model.GoType = 0;
            Model.ContentType = 0;
            Model.DefaultFile = ROYcms.Common.Request.GetFormString("DefaultFile");
            Model.FilePath = ROYcms.Common.Request.GetFormString("FilePath");
            Model.ColumnsType = ROYcms.Common.Request.GetFormInt("ColumnsType");
            Model.WebsiteUrl = ROYcms.Common.Request.GetFormString("WebsiteUrl");
            Model.TemplateIndex = ROYcms.Common.Request.GetFormString("TemplateIndex");
            Model.TemplateList = ROYcms.Common.Request.GetFormString("TemplateList");
            Model.TemplateShow = ROYcms.Common.Request.GetFormString("TemplateShow");
            Model.ListeRules = ROYcms.Common.Request.GetFormString("ListeRules");
            Model.ShowRules = ROYcms.Common.Request.GetFormString("ShowRules");
            Model.keyword = ROYcms.Common.Request.GetFormString("keyword");
            Model.Description = ROYcms.Common.Request.GetFormString("Description");
            Model.contents = ROYcms.Common.Request.GetFormString("contents");
            if (Model.Id > 0)
            {
                if (!BLL.Exists(Model.FilePath, Model.DefaultFile)) //不存在
                {
                    return BLL.ClassUpdate(Model) == true ? 1 : 0;
                }
                else
                {
                    if (BLL.GetId(Model.FilePath, Model.DefaultFile) == Model.Id)//当前的地址
                    {
                        return BLL.ClassUpdate(Model) == true ? 1 : 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            else
            {
                if (!BLL.Exists(Model.FilePath, Model.DefaultFile))
                {
                    return BLL.ClassAdd(Model) == true ? 1 : 0;
                }
                else
                {
                    return -1;
                }
            }

        }
    }
}
