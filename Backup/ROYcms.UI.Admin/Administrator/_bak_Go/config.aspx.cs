using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 模块配置设置 自定义表单
    /// </summary>
    public partial class Administrator_Objet_config : AdminPage
    {
        /// <summary>
        /// ClassKind标识
        /// </summary>
        /// <value>The kind of the class.</value>
        protected string ClassKind
        {
            get
            {
                return (string)ViewState["ClassKind"];
            }
            set
            {
                ViewState["ClassKind"] = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        protected string Class
        {
            get
            {
                return (string)ViewState["Class"];
            }
            set
            {
                ViewState["Class"] = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DataRow[] DC;
        /// <summary>
        /// 页面load事件 Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ClassKind = Request["ClassKind"];
                this.Class = Request["Class"];
                try
                {
                    Z_From_Bind();
                }
                catch
                {
                    ROYcms.Common.MessageBox.Show(this, "绑定错误！");
                }
            }
        }
        /// <summary>
        /// 编辑权限按钮
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Button_stup_Role_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 基本表单定义生效按钮  Handles the Click event of the Button_Z_From control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Button_Z_From_Click(object sender, EventArgs e)
        {
            string TextV = "";
            for (int i=1; i < 9; i++)
            {
                CheckBox CK = new CheckBox();
                CK = (CheckBox)Page.FindControl("N" + i);
                
                if (CK.Checked)
                {
                    TextV +="|"+ CK.Text.Trim().Replace("：", "");
                }
            }
            //调用 编辑XML文件
            if (TextV != "")
            {
                if (Z_From_Edit(TextV.Substring(1, TextV.Length - 1)))
                {
                    ROYcms.Common.MessageBox.Show(this, "成功！");
                }
                else { ROYcms.Common.MessageBox.Show(this, "错误！"); }
            }
        }

        /// <summary>
        /// 编辑一个对象更新到配置文件 /app_config/TemplateFrom.xml
        /// </summary>
        /// <returns></returns>
        bool Z_From_Edit(string Visible)
        {
            string Xpath = "/Root/From[@Classkind='" + this.ClassKind + "']";
            if (this.Class != null)
            {
                Xpath = "/Root/From[@Class='" + this.Class + "']";
            }
            bool err = false;
            try
            {
                string filepath = "~/app_config/TemplateFrom.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(Server.MapPath(filepath));
                XmlElement xe = (XmlElement)doc.SelectSingleNode(Xpath);
                if (xe == null)
                {
                    new ROYcms.Common.XmlControl(Server.MapPath(filepath)).InsertElement("Root", "From", "Class,Classkind,Visible,Time", this.Class + "," + this.ClassKind + "," + Visible + "," + System.DateTime.Now.ToString());
                    xe = (XmlElement)doc.SelectSingleNode(Xpath);
                }
                if (xe != null)
                {
                    xe.SetAttribute("Class", this.Class);
                    xe.SetAttribute("Classkind", this.ClassKind);
                    xe.SetAttribute("Visible", Visible);
                    xe.SetAttribute("Time", System.DateTime.Now.ToString());
                    doc.Save(Server.MapPath(filepath));
                }
                err = true;
            }
            catch { err = false; }
            return err;

        }
        /// <summary>
        /// Z_s the from_ bind.
        /// </summary>
        void Z_From_Bind()
        {
            for (int i = 1; i < 9; i++)
            {
                CheckBox CK = new CheckBox();
                CK = (CheckBox)Page.FindControl("N" + i);
                if (IS_IN(CK.Text.Trim().Replace("：", "")))
                {
                    CK.Checked = true;
                }
            }
      
        }
        /// <summary>
        /// 判断该表单项是否显示 Is the s_ IN.
        /// </summary>
        /// <returns></returns>
        public bool IS_IN(string name)
        {
            bool err = false;
            try
            {
                string filepath = "~/app_config/TemplateFrom.xml";
                DataSet DS = new DataSet();
                DS.ReadXml(Server.MapPath(filepath));
                if (DS != null)
                {
                    if (this.Class != null)
                    {
                       DC = DS.Tables[0].Select("Class=" + this.Class + "");
                    }
                    else {  DC = DS.Tables[0].Select("Classkind=" + this.ClassKind + ""); }

                    err = DC[0]["Visible"].ToString().Contains(name);
                }
            }
            catch { err = false; }
            return err;
        }


        /// <summary>
        /// 自定义表单输出  Bind_s the from_ XML.
        /// </summary>
        public string From_Out()
        {
            try
            {
                return "";
               // return ROYcms.Templet.ObjetForm.ReplaceFormDate(ROYcms.Common.SystemCms.Read_File(Server.MapPath("~/App_Data/TemplateFrom/" + this.ClassKind + ".html"), "utf-8"), 1, this.ClassKind);
            }
            catch {

                return "没有创建自定义表单项！";
            }
        }
    
        /// <summary>
        /// Handles the Click event of the Button_From_add control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Button_From_add_Click(object sender, EventArgs e)
        {
            if (FileUpload_From.HasFile)
            {
                if (!Directory.Exists(Server.MapPath("~/App_Data/TemplateFrom/")))//判断是否存在
                {
                    Directory.CreateDirectory(Server.MapPath("~/App_Data/TemplateFrom/"));//创建新路径 

                }
                FileUpload_From.SaveAs(Server.MapPath("~/App_Data/TemplateFrom/" + this.ClassKind + ".html"));
            }
            else {
                ROYcms.Common.MessageBox.Show(this, "请选择文件！");
            }
        }

    }
}
