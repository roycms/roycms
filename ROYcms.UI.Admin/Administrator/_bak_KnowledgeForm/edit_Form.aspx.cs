using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ROYcms.UI.Admin.Administrator.knowledgeForm
{
    /// <summary>
    /// 
    /// </summary>
    public partial class edit_Form : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { ShowInfo(Convert.ToInt32(Request["id"])); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        private void ShowInfo(int id)
        {
            ___ROYcms_Form_model = ___ROYcms_Form_bll.GetModel(id);

            this.txttitle.Text = ___ROYcms_Form_model.title;
            this.txtzhaiyao.Text = ___ROYcms_Form_model.zhaiyao;
            this.txtSetFrom.Text = ___ROYcms_Form_model.SetFrom;
            this.txtPath.Text = ___ROYcms_Form_model.Path;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnUpdate_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(Request["id"]);
            ___ROYcms_Form_model = ___ROYcms_Form_bll.GetModel(id);

            string title = this.txttitle.Text;
            string zhaiyao = this.txtzhaiyao.Text;
           
            string SetFrom = this.txtSetFrom.Text;
            string Path = this.txtPath.Text;
            string Contents = null;
            DateTime Time = DateTime.Now;
            string GUID = ___ROYcms_Form_model.GUID;


            if (FileUpload_Form.HasFile)
            {
                if (!Directory.Exists(Server.MapPath("~/App_Data/TemplateFrom/")))//判断是否存在
                {
                    Directory.CreateDirectory(Server.MapPath("~/App_Data/TemplateFrom/"));//创建新路径 
                }
                FileUpload_Form.SaveAs(Server.MapPath("~/App_Data/TemplateFrom/" + GUID + ".html"));
                Contents = ROYcms.Common.SystemCms.Read_File(Server.MapPath("~/App_Data/TemplateFrom/" + GUID + ".html"), "utf-8");
            }
            else
            {
                ROYcms.Common.MessageBox.Show(this, "请选择文件！");
            }

            ___ROYcms_Form_model.id = id;
            ___ROYcms_Form_model.title = title;
            ___ROYcms_Form_model.zhaiyao = zhaiyao;
            ___ROYcms_Form_model.SetFrom = SetFrom;
            ___ROYcms_Form_model.Path = Path;
            ___ROYcms_Form_model.Contents = Contents;
            ___ROYcms_Form_model.Time = Time;
            ___ROYcms_Form_model.GUID = GUID;

            ___ROYcms_Form_bll.Update(___ROYcms_Form_model);

            Response.Redirect("knowledgeForm.aspx?");

        }
    }
}
