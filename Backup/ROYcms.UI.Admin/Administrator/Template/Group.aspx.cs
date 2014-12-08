using System;
using ROYcms.Common;
using System.IO;

namespace ROYcms.UI.Admin.Administrator.template
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Group : System.Web.UI.Page
    {
        ROYcms.Sys.BLL.ROYcms_TemplateGroup bll = new ROYcms.Sys.BLL.ROYcms_TemplateGroup();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LIST_bind();
                ButEdit.Visible = false;
                if (Request["t"] == "del")
                {
                    //删除模板文件夹
                    ROYcms.Sys.Model.ROYcms_TemplateGroup _model = bll.GetModel(Convert.ToInt32(Request["bh"]));
                    Directory.Delete(Server.MapPath("~/"+ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") +"/"+_model.z_path+"/"),true);
                    
                    del(Convert.ToInt32(Request["bh"]));
                }
                if (Request["t"] == "edit")
                {
                    btnAdd.Visible = false;
                    ButEdit.Visible = true;
                    ShowInfo(Convert.ToInt32(Request["bh"]));

                } 
                if (Request["t"] == "show")
                {
                    btnAdd.Visible = false;
                    ButEdit.Visible = false;
                    btnCancel.Visible = false;
                    ShowInfo(Convert.ToInt32(Request["bh"]));

                    this.txtz_name.ReadOnly =true;
                    this.txtz_path.ReadOnly = true;
                    this.txtz_url.ReadOnly = true;
                    this.txtz_content.ReadOnly = true;
                }
            }
        
        }
        /// <summary>
        /// 
        /// </summary>
        void LIST_bind() 
        {
           
           Repeater_list.DataSource = bll.GetAllList();
           Repeater_list.DataBind();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bh"></param>
        void del(int bh) {

            
            bll.Delete(bh); LIST_bind();
        }
        /// <summary>
        /// 
        /// </summary>
        void ADD()
        {   
            /******************************增加窗体代码********************************/

            string strErr = "";
            if (this.txtz_name.Text == "")
            {
                strErr += "模板方案组名称不能为空！\\n";
            }
            if (this.txtz_path.Text == "")
            {
                strErr += "模板文件夹不能为空！\\n";
            }
            if (this.txtz_url.Text == "")
            {
                strErr += "模板绑定地址不能为空！\\n";
            }
            if (this.txtz_content.Text == "")
            {
                strErr += "模板组方案描述不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string z_name = this.txtz_name.Text;
            string z_path = this.txtz_path.Text;
            string z_url = this.txtz_url.Text;
            string z_content = this.txtz_content.Text;
            DateTime z_time = DateTime.Now;


            ROYcms.Sys.Model.ROYcms_TemplateGroup model = new ROYcms.Sys.Model.ROYcms_TemplateGroup();
            model.z_name = z_name;
            model.z_path = z_path;
            model.z_url = z_url;
            model.z_content = z_content;
            model.z_time = z_time;
            
            bll.Add(model);

            ROYcms.Sys.Model.ROYcms_TemplateGroup _model = bll.GetModel(Convert.ToInt32(Request["bh"]));
            if (!Directory.Exists(Server.MapPath("~/" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "/" + z_path + "/")))
            {
                Directory.CreateDirectory(Server.MapPath("~/" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "/" + z_path + "/"));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        void UPDATE()
        {
            /*修改代码-提交更新 */

            string strErr = "";
            if (this.txtz_name.Text == "")
            {
                strErr += "模板方案组名称不能为空！\\n";
            }
            if (this.txtz_path.Text == "")
            {
                strErr += "模板文件夹不能为空！\\n";
            }
            if (this.txtz_url.Text == "")
            {
                strErr += "模板绑定地址不能为空！\\n";
            }
            if (this.txtz_content.Text == "")
            {
                strErr += "模板组方案描述不能为空！\\n";
            }


            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string z_name = this.txtz_name.Text;
            string z_path = this.txtz_path.Text;
            string z_url = this.txtz_url.Text;
            string z_content = this.txtz_content.Text;
            DateTime z_time = DateTime.Now;


            ROYcms.Sys.Model.ROYcms_TemplateGroup model = new ROYcms.Sys.Model.ROYcms_TemplateGroup();
            model.bh =Convert.ToInt32( Request["bh"]);
            model.z_name = z_name;
            model.z_path = z_path;
            model.z_url = z_url;
            model.z_content = z_content;
            model.z_time = z_time;
           
            bll.Update(model);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bh"></param>
        private void ShowInfo(int bh)
        {
            
            ROYcms.Sys.Model.ROYcms_TemplateGroup model = bll.GetModel(bh);
            
            this.txtz_name.Text = model.z_name;
            this.txtz_path.Text = model.z_path;
            this.txtz_url.Text = model.z_url;
            this.txtz_content.Text = model.z_content;
           

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ADD(); LIST_bind();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButEdit_Click(object sender, EventArgs e)
        {
            UPDATE(); LIST_bind();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtz_name.Text = null;
            this.txtz_path.Text = null;
            this.txtz_url.Text = null;
            this.txtz_content.Text = null;
        }
    }
}
