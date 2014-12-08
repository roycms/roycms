using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_knowledge_Form : AdminPage
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
                Bind(); 
            }
        }
        /// <summary>
        /// Binds this instance.
        /// </summary>
        void Bind()
        {
            Repeater_admin.DataSource = ___ROYcms_Form_bll.GetAllList();
            Repeater_admin.DataBind();
        }
        /// <summary>
        /// 创建表单文件
        /// </summary>
        void New_Form(string path,string temple_path)
        {
           
        }

    }
}
