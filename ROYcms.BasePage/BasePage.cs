using System;
using System.Web;
using System.Web.UI.WebControls;

namespace ROYcms
{
    /// <summary>
    /// 页面扩展基础类
    /// </summary>
    public class BasePage : System.Web.UI.Page
    {
        /// <summary>
        /// 预先实例化
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_news ___ROYcms_news_Bll = new ROYcms.Sys.BLL.ROYcms_news();
        public ROYcms.Sys.Model.ROYcms_news ___ROYcms_news_Model = new ROYcms.Sys.Model.ROYcms_news();
        public ROYcms.Sys.BLL.ROYcms_class ___ROYcms_class_Bll = new ROYcms.Sys.BLL.ROYcms_class();
        public ROYcms.Sys.Model.ROYcms_class ___ROYcms_class_Model = new ROYcms.Sys.Model.ROYcms_class();
        public ROYcms.Sys.BLL.ROYcms_user ___ROYcms_user_bll = new ROYcms.Sys.BLL.ROYcms_user();
        public ROYcms.Sys.Model.ROYcms_user ___ROYcms_user_model = new ROYcms.Sys.Model.ROYcms_user();
        public ROYcms.Sys.BLL.ROYcms_New_User ___ROYcms_New_User_bll = new ROYcms.Sys.BLL.ROYcms_New_User();
        public ROYcms.Sys.Model.ROYcms_New_User ___ROYcms_New_User_model = new ROYcms.Sys.Model.ROYcms_New_User();
        public ROYcms.Sys.BLL.ROYcms_Class_UGroup ___ROYcms_Class_UGroup_bll = new ROYcms.Sys.BLL.ROYcms_Class_UGroup();
        public ROYcms.Sys.Model.ROYcms_Class_UGroup ___ROYcms_Class_UGroup_model = new ROYcms.Sys.Model.ROYcms_Class_UGroup();
        public ROYcms.Sys.BLL.ROYcms_UGroup ___ROYcms_UGroup_bll = new ROYcms.Sys.BLL.ROYcms_UGroup();
        public ROYcms.Sys.Model.ROYcms_UGroup ___ROYcms_UGroup_model = new ROYcms.Sys.Model.ROYcms_UGroup();
        public ROYcms.Sys.Model.ROYcms_Workflow ___ROYcms_Workflow_model = new ROYcms.Sys.Model.ROYcms_Workflow();
        public ROYcms.Sys.BLL.ROYcms_Workflow ___ROYcms_Workflow_bll = new ROYcms.Sys.BLL.ROYcms_Workflow();
        public ROYcms.Sys.Model.ROYcms_UGroup_Workflow ___ROYcms_UGroup_Workflow_model = new ROYcms.Sys.Model.ROYcms_UGroup_Workflow();
        public ROYcms.Sys.BLL.ROYcms_UGroup_Workflow ___ROYcms_UGroup_Workflow_bll = new ROYcms.Sys.BLL.ROYcms_UGroup_Workflow();
        public ROYcms.Sys.Model.ROYcms_Flash ___ROYcms_Flash_model = new ROYcms.Sys.Model.ROYcms_Flash();
        public ROYcms.Sys.BLL.ROYcms_Flash ___ROYcms_Flash_bll = new ROYcms.Sys.BLL.ROYcms_Flash();
        public ROYcms.Sys.Model.ROYcms_Rss ___ROYcms_Rss_model = new ROYcms.Sys.Model.ROYcms_Rss();
        public ROYcms.Sys.BLL.ROYcms_Rss ___ROYcms_Rss_bll = new ROYcms.Sys.BLL.ROYcms_Rss();
        public ROYcms.Sys.Model.ROYcms_Objet ___ROYcms_Objet_model = new ROYcms.Sys.Model.ROYcms_Objet();
        public ROYcms.Sys.BLL.ROYcms_Objet ___ROYcms_Objet_bll = new ROYcms.Sys.BLL.ROYcms_Objet();
        public ROYcms.Sys.Model.ROYcms_Form ___ROYcms_Form_model = new ROYcms.Sys.Model.ROYcms_Form();
        public ROYcms.Sys.BLL.ROYcms_Form ___ROYcms_Form_bll = new ROYcms.Sys.BLL.ROYcms_Form();
        public ROYcms.Sys.Model.ROYcms_Form_class_classkind ___ROYcms_Form_class_classkind_model = new ROYcms.Sys.Model.ROYcms_Form_class_classkind();
        public ROYcms.Sys.BLL.ROYcms_Form_class_classkind ___ROYcms_Form_class_classkind_bll = new ROYcms.Sys.BLL.ROYcms_Form_class_classkind();
        public ROYcms.Sys.Model.ROYcms_News_Group ___ROYcms_News_Group_model = new ROYcms.Sys.Model.ROYcms_News_Group();
        public ROYcms.Sys.BLL.ROYcms_News_Group ___ROYcms_News_Group_bll = new ROYcms.Sys.BLL.ROYcms_News_Group();
        public ROYcms.Sys.Model.ROYcms_Tag ___ROYcms_Tag_model = new ROYcms.Sys.Model.ROYcms_Tag();
        public ROYcms.Sys.BLL.ROYcms_Tag ___ROYcms_Tag_bll = new ROYcms.Sys.BLL.ROYcms_Tag();
        public ROYcms.Sys.BLL.ROYcms_Admin ___ROYcms_Admin_bll = new ROYcms.Sys.BLL.ROYcms_Admin();
        public ROYcms.Sys.Model.ROYcms_Admin ___ROYcms_Admin_Model = new ROYcms.Sys.Model.ROYcms_Admin();
        public ROYcms.Sys.BLL.ROYcms_Model ___ROYcms_Model_bll = new ROYcms.Sys.BLL.ROYcms_Model();
        public ROYcms.Sys.Model.ROYcms_Model ___ROYcms_Model_Model = new ROYcms.Sys.Model.ROYcms_Model();
        public ROYcms.Sys.BLL.ROYcms_Field ___ROYcms_Field_bll = new ROYcms.Sys.BLL.ROYcms_Field();
        public ROYcms.Sys.Model.ROYcms_Field ___ROYcms_Field_Model = new ROYcms.Sys.Model.ROYcms_Field();
        public ROYcms.Sys.BLL.ROYcms_Custom ___ROYcms_Custom_bll = new ROYcms.Sys.BLL.ROYcms_Custom();
        public ROYcms.Sys.Model.ROYcms_Custom ___ROYcms_Custom_Model = new ROYcms.Sys.Model.ROYcms_Custom();
        public ROYcms.Sys.BLL.ROYcms_Url ___ROYcms_Url_bll = new ROYcms.Sys.BLL.ROYcms_Url();
        public ROYcms.Sys.Model.ROYcms_Url ___ROYcms_Url_model = new ROYcms.Sys.Model.ROYcms_Url();
        public ROYcms.Sys.BLL.ROYcms_CaiRss ___ROYcms_CaiRss_bll = new ROYcms.Sys.BLL.ROYcms_CaiRss();
        public ROYcms.Sys.Model.ROYcms_CaiRss ___ROYcms_CaiRss_model = new ROYcms.Sys.Model.ROYcms_CaiRss();
        public ROYcms.Sys.BLL.ROYcms_Log ___ROYcms_Log_bll = new ROYcms.Sys.BLL.ROYcms_Log();
        public ROYcms.Sys.Model.ROYcms_Log ___ROYcms_Log_model = new ROYcms.Sys.Model.ROYcms_Log();
        /// <summary>
        /// 获得配置文件信息
        /// </summary>
        public string ___CmsConfigValue(string name)
        {
            return ROYcms.Config.ROYcmsConfig.GetCmsConfigValue(name);
        }
        /// <summary>
        /// 覆盖系统默认的错误页
        /// </summary>
        protected override void OnError(EventArgs e)
        {
            HttpContext ctx = HttpContext.Current;
            Exception exception = ctx.Server.GetLastError();
            string MexBoxContent =
                "\r\n<br /><b>发生错误的 URL:</b> <font color=red>" + ctx.Request.Url.ToString() +
                "</font>" +
                "\r\n<br /><b>错误源: </b> <font color=red>" + exception.Source +
                "</font>" +
                "\r\n<br /><b>错误信息: </b> <font color=red>" + exception.Message +
                "</font>" +
                "\r\n<br /><b>Stack trace: </b> <br /><font color=red>" + exception.StackTrace +
                "</font>";

            this.InsertSystemLog("5", ctx.Request.Url.ToString() + "页面运行错误", MexBoxContent);//写入错误日志
            if (___CmsConfigValue("err_k") == "true")//是否输出显示页面错误详细信息
            {
                ctx.Response.Clear();
                ctx.Response.Write(MexBoxContent);
            }
            ctx.Server.ClearError();
            base.OnError(e);
        }
       /// <summary>
        /// 日志写入
       /// </summary>
        /// <param name="Err_id">标识 1管理员登录 2普通会员登录 3管理员操作日志 4普通会员操作日志 5错误日志 </param>
       /// <param name="Event">日志事件名称</param>
        /// <param name="Content">日志内容</param>
        public void InsertSystemLog(string Err_id,string Event,string Content)
        {
           new ROYcms.Sys.BLL.ROYcms_Log().InsertSystemLog(Err_id, Event,Content);//写入日志
        }
        /// <summary>
        ///  页面加载完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BasePage_Load(object sender, EventArgs e)
        {
            //添加底端placeholder
            //control form1 = this.findcontrol("form1");
            //if (form1 != null) form1.controls.add(plhbottomholder);
            //添加页脚的用户自定义控件
            //itemplate footer = page.loadtemplate("~/controls/footer.ascx");
            //this.plhbottomholder.controls.add(footer);
        }
    }
}
