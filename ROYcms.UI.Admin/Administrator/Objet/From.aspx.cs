using System;
using System.Data;
using System.Xml;
using System.IO;

namespace ROYcms.UI.Admin.Administrator.Objet
{
    /// <summary>
    /// 
    /// </summary>
    public partial class From : AdminPage
    {
        #region ClassKind属性
        /// <summary>
        /// 
        /// </summary>
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
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public string XMLpath = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ClassKind = Request["ClassKind"];
            }
        }

        /// <summary>
        /// XMLs the new.
        /// </summary>
        /// <param name="type">类型 The type.</param>
        /// <param name="title">标签 The title.</param>
        /// <param name="name">名称 The name.</param>
        /// <param name="value">默认值 The value.</param>
        /// <param name="size">大小 值大小  The size.</param>
        /// <param name="onjs">关联的JS  The onjs.</param>
        /// <returns></returns>
        bool XmlNew(string type, string title, string name, string value, string size, string onjs)
        {
            string filepath = "~/app_data/TemplateFrom/";
            if (!File.Exists(Server.MapPath(filepath + this.ClassKind + ".xml")))
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                //创建一个根节点（一级） 
                XmlElement root = doc.CreateElement("Root");
                doc.AppendChild(root);
                if (!Directory.Exists(Server.MapPath(filepath)))//判断是否存在
                {
                    Directory.CreateDirectory(Server.MapPath(filepath));//创建新路径 
                    doc.Save(Server.MapPath(filepath + this.ClassKind + ".xml"));
                }
                else
                {
                    doc.Save(Server.MapPath(filepath + this.ClassKind + ".xml"));
                }
                Console.Write(doc.OuterXml);

                new ROYcms.Common.XmlControl(Server.MapPath(filepath + this.ClassKind + ".xml")).InsertElement("Root", "From", "type,title,name,value,size,onjs,Time", type + "," + title + "," + name + "," + value + "," + size + "," + onjs + "," + System.DateTime.Now.ToString());
                return true;
            }
            else
            {
                new ROYcms.Common.XmlControl(Server.MapPath(filepath + this.ClassKind + ".xml")).InsertElement("Root", "From", "type,title,name,value,size,onjs,Time", type + "," + title + "," + name + "," + value + "," + size + "," + onjs + "," + System.DateTime.Now.ToString());
                return true;
            }
        }

        /// <summary>
        /// 创建一个自定义表单按钮
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Button_stup_From_Click(object sender, EventArgs e)
        {
            //创建一个表单字段
            if (XmlNew(T_DropDownList_type.SelectedValue, T_title.Text, T_title.Text, T_value.Text, T_size.Text, T_onjs.Text))
            {
                ROYcms.Common.MessageBox.Show(this, "成功创建一个字段");
            }

        }
    }
}
