using System;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_go_Issue : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        public string path = "~/App_Config/Object.xml";
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox_name.Text = "新模块名称";
            TextBox_logo.Text = "新模块LOGO图标地址";
            TextBox_TemplateFrom.Text = "新模块表单模版地址";
            TextBox_AppendixConfig.Text = "新模块附件配置文件路径";
            TextBox_AppendixPath.Text = "新模块附件保存路径";
            TextBox_description.Text = "新模块描述";
            TextBox_Classkind.ReadOnly = false;
            Button_add_objet.Text = "确定提交新模块";
        }
        /// <summary>
        /// Handles the Click event of the Button_add_objet control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Button_add_objet_Click(object sender, EventArgs e)
        {
            new ROYcms.Common.XmlControl(Server.MapPath(path)).InsertElement("Root", "Class", "GUID,Classkind,logo,AppendixConfig,AppendixPath,name,description,Visible,Time", Guid.NewGuid().ToString() +

                ","
                + TextBox_Classkind.Text
                + ","
                + "/administrator/images/nv1.png"
                + ","
                + "~/app_data/Classkind/"
                + ","
                + "~/App_AppendixPath/"
                + ","
                + TextBox_name.Text
                + ","
                + TextBox_description.Text
                + ","
                + "true"
                + ","
                + System.DateTime.Now.ToString());

            ROYcms.Common.MessageBox.Show(this, "操作成功！");
        }
    }
}
