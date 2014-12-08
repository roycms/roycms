using System;
using System.Collections;
using System.Configuration;
using System.Data;

namespace ROYcms.UI.Admin.Administrator.Class
{
    /// <summary>
    /// AJAXClass_Model
    /// </summary>
    public partial class AJAXClass_Model : ROYcms.AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Class_Model BLL = new ROYcms.Sys.BLL.ROYcms_Class_Model();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Class_Model Model = new ROYcms.Sys.Model.ROYcms_Class_Model();
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            int PRE = 0;
            if (Request["Del"] == null)
            {
                int ModelId = Convert.ToInt32(Request["Id"].Split(',')[0]);
                int Class = Convert.ToInt32(Request["Id"].Split(',')[1]);
                PRE = Insert(ModelId, Class);
            }
            else
            {
                int Del = Convert.ToInt32(Request["Del"]);
                PRE = BLL.CidDelete(Del) == true ? 1 : 0;
            }
            Response.ContentType = "text/plain";
            Response.Write(PRE);
        }
        /// <summary>
        /// 添加一个关联
        /// </summary>
        /// <returns></returns>
        public int Insert(int ModelId,int Class)
        {
            int PRE = 0;
            string TableName = new ROYcms.Sys.BLL.ROYcms_Model().GetTableName(ModelId);
            if (new ROYcms.Sys.BLL.CMS().Exists(TableName))
            {
                Model.Cid = Class;
                Model.Mid = ModelId;
                Model.TIME = DateTime.Now;
                if (!BLL.CidExists(Class))
                {
                    PRE = BLL.Add(Model);
                }
                else { PRE = BLL.CidUpdate(Model) == true ? 1 : 0; }
            }
            else { PRE = -1; } //数据表未创建  模型未初始化

            return PRE;
        }
    }
}
