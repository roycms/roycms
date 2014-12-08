using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
namespace ROYcms.UI.Admin.Administrator.go
{
    /// <summary>
    /// 类
    /// </summary>
    public partial class AJAXAdd_objet : ROYcms.AdminPage
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

            int ClassKind = Convert.ToInt32(Request["ClassKind"]);

            
            ___ROYcms_Objet_model.Title = Request["Title"];
            ___ROYcms_Objet_model.ClassKind = ClassKind;
            ___ROYcms_Objet_model.zhaiyao = Request["zhaiyao"];
            ___ROYcms_Objet_model.logo = Request["logo"];
            ___ROYcms_Objet_model.AppendixConfig = Request["AppendixConfig"];
            ___ROYcms_Objet_model.AppendixPath = Request["AppendixPath"];
            ___ROYcms_Objet_model.Visible = Convert.ToInt32(Request["Visible"]);
            ___ROYcms_Objet_model.Role = Request["Role"];
            ___ROYcms_Objet_model.Time = DateTime.Now;


            if (editId > 0)//编辑
            {
                ___ROYcms_Objet_model.id = editId;
                ___ROYcms_Objet_bll.Update(___ROYcms_Objet_model); 
                PRE = 1;
            }
            else //添加
            {
                if (!___ROYcms_Objet_bll.ExistsClassKind(ClassKind))
                {
                    PRE = ___ROYcms_Objet_bll.Add(___ROYcms_Objet_model);
                }
            }
            Response.ContentType = "text/plain";
            Response.Write(PRE);

        }


       
    }
}
