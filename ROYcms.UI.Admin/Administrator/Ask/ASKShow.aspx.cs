using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ROYcms.Common;

namespace ROYcms.UI.Admin.Administrator.Ask
{
    public partial class ASKShow : ROYcms.AdminPage
    {
        public ROYcms.Sys.BLL.ROYcms_ASKResult Bll = new Sys.BLL.ROYcms_ASKResult();
        public ROYcms.Sys.Model.ROYcms_ASKResult Model = new Sys.Model.ROYcms_ASKResult();

        public ROYcms.Sys.BLL.ROYcms_ASK ASKBll = new Sys.BLL.ROYcms_ASK();
        public ROYcms.Sys.Model.ROYcms_ASK ASKModel = new Sys.Model.ROYcms_ASK();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ASKModel = ASKBll.GetModel(Convert.ToInt32(Request["Id"]));
              
                PreIndex();
                Bind();
            }
        }
        /// <summary>
        /// 初始值赋值
        /// </summary>
        public void PreIndex()
        {
            ViewState["Page"] = ROYcms.Common.Request.GetQueryString("Page") == "" ? "1" : ROYcms.Common.Request.GetQueryString("Page");
            Application["PageSize"] = Application["PageSize"] == null ? "20" : Application["PageSize"];
        }
        /// <summary>
        /// Binds this instance.
        /// </summary>
        void Bind()
        {
            string where = null;
            where += " Id>-1 ";

            //try
            //{
            Repeater_admin.DataSource = Bll.GetList(Convert.ToInt32(Application["PageSize"]), Convert.ToInt32(ViewState["Page"]), where);
            Repeater_admin.DataBind();
            ViewState["PageCon"] = Bll.GetRecordCount(where) / Convert.ToInt32(Application["PageSize"]) + 1;
            ViewState["PageContent"] = Bll.GetRecordCount(where);
            Bll.GetList("");
            //}
            //catch //异常处理
            //{
            //    Repeater_admin.DataSource = null;
            //    Repeater_admin.DataBind();
            //}

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void PageSizeTextChanged(object sender, EventArgs e)
        {
            Application["PageSize"] = ((TextBox)Repeater_admin.Controls[Repeater_admin.Controls.Count - 1].FindControl("PageSize")).Text;

            Bind();
        }

        protected void Button_save_Click(object sender, EventArgs e)
        {
            string strErr = "";
          
         
            if (this.txtTitle.Text.Trim().Length == 0)
            {
                strErr += "标题不能为空！\\n";
            }
            if (this.txtContents.Text.Trim().Length == 0)
            {
                strErr += "内容不能为空！\\n";
            }
          

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
         
            int ASKID = Convert.ToInt32(Request["Id"]);
            int UserID = 0;
            int AdminID = Convert.ToInt32(ROYcms.Common.Session.Get("administrator_id"));
            string Title = this.txtTitle.Text;
            string Contents = this.txtContents.Text;
            string IP = ROYcms.Common.SystemCms.GetClientIPv4(); //IP地址
            DateTime CreateTime = DateTime.Now;

            ROYcms.Sys.Model.ROYcms_ASKResult model = new ROYcms.Sys.Model.ROYcms_ASKResult();
         
            model.ASKID = ASKID;
            model.UserID = UserID;
            model.AdminID = AdminID;
            model.Title = Title;
            model.Contents = Contents;
            model.IP = IP;
            model.CreateTime = CreateTime;

            ROYcms.Sys.BLL.ROYcms_ASKResult bll = new ROYcms.Sys.BLL.ROYcms_ASKResult();
            bll.Add(model);
            
            Bind();

            ROYcms.Common.MessageBox.Show(this, "保存成功！");

           
        }

    
    }
}