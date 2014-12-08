using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.CMSHelp
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AjaxSynonyms : ROYcms.AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Synonyms BLL = new Sys.BLL.ROYcms_Synonyms();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Synonyms Model = new Sys.Model.ROYcms_Synonyms();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            int editId = 0; //编辑信息的标识ID
            int PRE = 0;    //返回状态ID
            //编辑时绑定数据
            if (Request["id"] != null) { editId = ROYcms.Common.Request.GetFormInt("id"); }

            Model.find = ROYcms.Common.Request.GetFormString("find");
            Model.REPLACE = ROYcms.Common.Request.GetFormString("REPLACE");

            if (editId > 0)//编辑
            {
                Model.id = editId;
                BLL.Update(Model);
                PRE = 1;
            }
            else //添加
            {
                PRE = BLL.Add(Model);
            }
            Response.ContentType = "text/plain";
            Response.Write(PRE);

        }
    }
}