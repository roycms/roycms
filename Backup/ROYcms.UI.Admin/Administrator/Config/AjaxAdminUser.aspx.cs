using System;
using System.Collections;
using System.Configuration;
using System.Data;

namespace ROYcms.UI.Admin.Administrator.Config
{
    /// <summary>
    /// AjaxAdminUser
    /// </summary>
    public partial class AjaxAdminUser : ROYcms.AdminPage
    {
        /// <summary>
        /// 加载...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            int editId = 0; //编辑信息的标识ID
            int PRE = 0;    //返回状态ID
            //编辑时绑定数据
            if (Request["id"] != null) { editId = Convert.ToInt32(Request["id"]); }
            
            ___ROYcms_Admin_Model.name = Request["name"];
            ___ROYcms_Admin_Model.password = ROYcms.Common.DESEncrypt.Encrypt(Request["password"]);
            ___ROYcms_Admin_Model.classkind = Request["classkind"];
            ___ROYcms_Admin_Model.Rol =Convert.ToInt32(Request["Rol"]);


            if (editId > 0)//编辑
            {
                ___ROYcms_Admin_Model.id = editId;
                ___ROYcms_Admin_bll.Update(___ROYcms_Admin_Model);
                PRE = 1;
            }
            else //添加
            {
                PRE = ___ROYcms_Admin_bll.Add(___ROYcms_Admin_Model);
            }
            Response.ContentType = "text/plain";
            Response.Write(PRE);

        }
    }
}
