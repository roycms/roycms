using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Xml;

namespace ROYcms.Install.Install
{
    /// <summary>
    /// 
    /// </summary>
    public partial class step1 : System.Web.UI.Page
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ReExamine.Click += new EventHandler(ReExamine_Click);
            NextStep.Click += new EventHandler(NextStep_Click);


            bool webconfigExamine = false; //
            bool APP_DATE = false; //
            bool App_Config = false; //创建新路径 
            bool App_Templet = false; //创建新路径 
            bool App_Appendix = false; //创建新路径 
            bool APP_pic = false;//

            if (CheckFolderWriteable(Server.MapPath("~/App_Config")))
            {
                App_Config = true;
                App_ConfigLi.Attributes["class"] = "True";
                App_ConfigExamine.Text = "App_Config文件夹检测成功";
            }
            else
            {
                App_Config = false;
                App_ConfigLi.Attributes["class"] = "Error";
                App_ConfigExamine.Text = "App_Config文件夹检测失败";
            }

            if (CheckFolderWriteable(Server.MapPath("~/App_Templet")))
            {
                App_Templet = true;
                App_TempletLi.Attributes["class"] = "True";
                App_TempletExamine.Text = "App_Templet文件夹检测成功";
            }
            else
            {
                App_Templet = false;
                App_TempletLi.Attributes["class"] = "Error";
                App_TempletExamine.Text = "App_Templet文件夹检测失败";
            }

            if (CheckFolderWriteable(Server.MapPath("~/App_Appendix")))
            {
                App_Appendix = true;
                App_AppendixLi.Attributes["class"] = "True";
                App_AppendixExamine.Text = "App_Appendix文件夹检测成功";
            }
            else
            {
                App_Appendix = false;
                App_AppendixLi.Attributes["class"] = "Error";
                App_AppendixExamine.Text = "App_Appendix文件夹检测失败";
            }
            if (CheckFolderWriteable(Server.MapPath("~/APP_pic")))
            {
                APP_pic = true;
                APP_picLi.Attributes["class"] = "True";
                APP_picExamine.Text = "APP_pic文件夹检测成功";
            }
            else
            {
                APP_pic = false;
                APP_picLi.Attributes["class"] = "Error";
                APP_picExamine.Text = "APP_pic文件夹检测失败";
            }
            if (CheckFolderWriteable(Server.MapPath("~/APP_DATa")))
            {
                APP_DATE = true;
                APP_DATELi.Attributes["class"] = "True";
                APP_DATEExamine.Text = "App_Data文件夹检测成功";
            }
            else
            {
                APP_pic = false;
                APP_picLi.Attributes["class"] = "Error";
                APP_picExamine.Text = "App_Data文件夹检测失败";
            }

            //检测Web.config是否可用

            System.IO.FileInfo FileInfo = new FileInfo(Server.MapPath("~/Web.config "));
            if (!FileInfo.Exists)
            {
                throw new Exception(string.Format("文件 : {0} 不存在", Server.MapPath("~/Web.config")));
            }
            System.Xml.XmlDocument xmldocument = new System.Xml.XmlDocument();
            xmldocument.Load(FileInfo.FullName);
            try
            {
                XmlNode moduleNode = xmldocument.SelectSingleNode("//httpModules");
                if (moduleNode.HasChildNodes)
                {
                    for (int i = 0; i < moduleNode.ChildNodes.Count; i++)
                    {
                        XmlNode node = moduleNode.ChildNodes[i];
                        if (node.Name == "add")
                        {
                            if (node.Attributes.GetNamedItem("name").Value == "ROYcmsModule")
                            {
                                moduleNode.RemoveChild(node);
                                break;
                            }
                        }
                    }
                }

                xmldocument.Save(FileInfo.FullName);

                //文件可写
                WebConfigExamine.Text = "~/Web.Config 检测成功";
                webconfigExamine = true;
                WebConfigLi.Attributes["class"] = "True";
            }
            catch
            {
                //文件只读
                WebConfigExamine.Text = "请将 Web.Config 设置为可写";
                webconfigExamine = false;
                WebConfigLi.Attributes["class"] = "Error";
            }

            NewDirectory();

            if (webconfigExamine && APP_DATE && App_Config && App_Templet && App_Appendix && APP_pic)
            {
                ReExamine.Enabled = false;
                NextStep.Enabled = true;
            }
            else
            {
                ReExamine.Enabled = true;
                NextStep.Enabled = false;
            }

            
        }

        /// <summary>
        /// Checks the folder writeable.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        bool CheckFolderWriteable(string path)
        {
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
                return true;
            }
            else
            {
                try
                {
                    string testFilePath = string.Format("{0}/test{1}{2}{3}{4}.txt", path, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
                    FileStream TestFile = System.IO.File.Create(testFilePath);
                    TestFile.WriteByte(Convert.ToByte(true));
                    TestFile.Close();
                    System.IO.File.Delete(testFilePath);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 从新检测  Handles the Click event of the ReExamine control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void ReExamine_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Install/Step1.aspx");
        }

        /// <summary>
        /// Handles the Click event of the NextStep control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void NextStep_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Install/Step2.aspx");
        }
        /// <summary>
        /// 创建系统必要目录 News the directory.
        /// </summary>
        void NewDirectory()
        {
            if (!Directory.Exists(Server.MapPath("~/APP_DATa/Appendix/"))) { Directory.CreateDirectory(Server.MapPath("~/APP_DATa/Appendix/")); } //创建新路径 附件XML数据存放目录
            if (!Directory.Exists(Server.MapPath("~/APP_DATa/BAK/"))) { Directory.CreateDirectory(Server.MapPath("~/APP_DATa/BAK/")); } //创建新路径 数据库备份文件存放目录
            if (!Directory.Exists(Server.MapPath("~/APP_DATa/LOG/"))) { Directory.CreateDirectory(Server.MapPath("~/APP_DATa/LOG/")); } //创建新路径 系统日志存放目录
            if (!Directory.Exists(Server.MapPath("~/APP_DATa/TAG/"))) { Directory.CreateDirectory(Server.MapPath("~/APP_DATa/TAG/")); } //创建新路径 标签云XML数据存放目录
            if (!Directory.Exists(Server.MapPath("~/APP_DATa/TemplateFrom/"))) { Directory.CreateDirectory(Server.MapPath("~/APP_DATa/TemplateFrom/")); } //创建新路径 自定义表单模版存放目录
            if (!Directory.Exists(Server.MapPath("~/APP_DATa/XML/"))) { Directory.CreateDirectory(Server.MapPath("~/APP_DATa/TemplateFrom/")); } //创建新路径 文章XML 数据文件存放目录
        }
    }
}
