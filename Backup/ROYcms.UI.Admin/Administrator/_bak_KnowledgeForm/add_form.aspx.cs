using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ROYcms.UI.Admin.Administrator.knowledgeForm
{
    public partial class add_form : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string title = this.txttitle.Text;
            string zhaiyao = this.txtzhaiyao.Text;
            int classname = 0;

            //int ClassKind_id = int.Parse(this.txtClassKind_id.Text);
            //int Class_id = int.Parse(this.txtClass_id.Text);
            
            string SetFrom = this.txtSetFrom.Text;
            string Path = this.txtPath.Text;
            string Contents = null;
            DateTime Time = DateTime.Now;
            string GUID = new Guid().ToString();

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
            ___ROYcms_Form_model.title = title;
            ___ROYcms_Form_model.zhaiyao = zhaiyao;
            ___ROYcms_Form_model.classname = classname;
            ___ROYcms_Form_model.ClassKind_id = 0;
            ___ROYcms_Form_model.Class_id = 0;
            ___ROYcms_Form_model.SetFrom = SetFrom;
            ___ROYcms_Form_model.Path = Path;
            ___ROYcms_Form_model.Contents = Contents;
            ___ROYcms_Form_model.Time = Time;
            ___ROYcms_Form_model.GUID = GUID;

            ___ROYcms_Form_bll.Add(___ROYcms_Form_model);

            Response.Redirect("knowledgeForm.aspx?");

        }
    }
}
