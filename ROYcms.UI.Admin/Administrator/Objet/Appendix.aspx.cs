using System;
using System.IO;
using System.Web.UI.WebControls;
using System.Xml;
using ROYcms.Common;

namespace ROYcms.UI.Admin.Administrator.Objet
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Appendix : AdminPage
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
        #region FileRootPath属性
        /// <summary>
        /// 
        /// </summary>
        protected string FileRootPath
        {
            get
            {
                return (string)ViewState["FileRootPath"];
            }
            set
            {
                ViewState["FileRootPath"] = value;
            }
        }
        #endregion
        #region AppendixXmlPath属性
        /// <summary>
        /// 
        /// </summary>
        protected string AppendixXmlPath
        {
            get
            {
                return (string)ViewState["AppendixXmlPath"];
            }
            set
            {
                ViewState["AppendixXmlPath"] = value;
            }
        }
        #endregion

        #region GUID属性
        /// <summary>
        /// 
        /// </summary>
        protected string GUID
        {
            get
            {
                return (string)ViewState["GUID"];
            }
            set
            {
                ViewState["GUID"] = value;
            }
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["t"] == null)
                {
                    this.FileRootPath = "~/App_Appendix/temp/" + Request["ClassKind"] + "/" + Request["GUID"] + "/";
                    this.AppendixXmlPath = "~/app_data/Appendix/temp/" + Request["ClassKind"] + "/";
                    this.GUID = Request["GUID"];
                    Bind();
                }
                else 
                {
                    this.FileRootPath = "~/App_Appendix/" + Request["ClassKind"] + "/" + Request["GUID"] + "/";
                    this.AppendixXmlPath = "~/app_data/Appendix/" + Request["ClassKind"] + "/";
                    this.GUID = Request["GUID"];
                    Bind();
                }
            }
        }
        /// <summary>
        /// 添加信息命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_add_Click(object sender, EventArgs e)
        {
            AddImg();
        }
        /// <summary>
        /// 添加图像命令
        /// </summary>
        void AddImg()
        {
            UP_img up_img = new UP_img();
            if (FileUpload1.HasFile)
            {
                string name = FileUpload1.PostedFile.FileName;       
                string fileContentType = FileUpload1.PostedFile.ContentType;
                string fileContentSize = FileUpload1.PostedFile.ContentLength.ToString();
              
                                      // 客户端文件路径
                    FileInfo file = new FileInfo(name);
                    string fileName = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + name.Substring(name.LastIndexOf("."), name.Length - name.LastIndexOf("."));                                           // 文件名称
                    string webFilePath = Server.MapPath(FileRootPath);               // 服务器端文件路径
                    string webFilePath_s = Server.MapPath(FileRootPath + "s_");　　  // 服务器端缩略图路径
                    if (!Directory.Exists(webFilePath))//判断是否存在
                    {
                        Directory.CreateDirectory(webFilePath);//创建新路径 
                        try
                        {
                            FileUpload1.SaveAs(webFilePath + fileName);                                   // 使用 SaveAs 方法保存文件

                            if (fileContentType == "image/bmp" || fileContentType == "image/gif" || fileContentType == "image/pjpeg" || fileContentType == "image/png")
                            {
                                string[] Size = DropDownList_ImgSize.SelectedValue.Split(',');
                                up_img.MakeThumbnail(webFilePath + fileName, webFilePath_s + fileName, Convert.ToInt32(Size[0]), Convert.ToInt32(Size[1]), "W");          // 生成缩略图方法
                            }
                            XmlNew(fileName, FileRootPath.Replace("~",""), fileContentType, fileContentSize);
                            this.ListBox_img.Items.Add(new ListItem(fileName, fileName));
                        }
                        catch
                        {
                            Response.Write("文件上传失败!");
                        }
                    }
                    else
                    {
                        try
                        {
                            FileUpload1.SaveAs(webFilePath + fileName);                                   // 使用 SaveAs 方法保存文件

                            if (fileContentType == "image/bmp" || fileContentType == "image/gif" || fileContentType == "image/pjpeg" || fileContentType == "image/png")
                            {
                                string[] Size = DropDownList_ImgSize.SelectedValue.Split(',');
                                up_img.MakeThumbnail(webFilePath + fileName, webFilePath_s + fileName, Convert.ToInt32(Size[0]), Convert.ToInt32(Size[1]), "W");          // 生成缩略图方法
                            }
                            XmlNew(fileName, FileRootPath.Replace("~", ""), fileContentType, fileContentSize);
                            this.ListBox_img.Items.Add(new ListItem(fileName, fileName));
                        }
                        catch
                        {
                            Response.Write("文件上传失败!");
                        }
                    }
      
            }
        }

       /// <summary>
       /// 常见XML命令
       /// </summary>
       /// <param name="FileName"></param>
       /// <param name="RootPath"></param>
       /// <param name="fileContentType"></param>
       /// <param name="fileContentSize"></param>
       /// <returns></returns>
        bool XmlNew(string FileName, string RootPath,string fileContentType, string fileContentSize)
        {
            RootPath = RootPath.Replace("/temp", "");
            if (!File.Exists(Server.MapPath(AppendixXmlPath + GUID + ".xml")))
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                //创建一个根节点（一级） 
                XmlElement root = doc.CreateElement("Root");
                doc.AppendChild(root);
                if (!Directory.Exists(Server.MapPath(AppendixXmlPath)))//判断是否存在
                {
                    Directory.CreateDirectory(Server.MapPath(AppendixXmlPath));//创建新路径 
                    doc.Save(Server.MapPath(AppendixXmlPath + GUID + ".xml"));
                }
                else
                {
                    doc.Save(Server.MapPath(AppendixXmlPath + GUID + ".xml"));
                }
                Console.Write(doc.OuterXml);
                new ROYcms.Common.XmlControl(Server.MapPath(AppendixXmlPath + GUID + ".xml")).InsertElement("Root", "Appendix", "RootPath,FileName,fileType,fileContentSize,Time", RootPath + "," + FileName + "," + fileContentType + "," + fileContentSize + "," + System.DateTime.Now.ToString());
                return true;
            }
            else
            {
                new ROYcms.Common.XmlControl(Server.MapPath(AppendixXmlPath + GUID + ".xml")).InsertElement("Root", "Appendix", "RootPath,FileName,fileType,fileContentSize,Time", RootPath + "," + FileName + "," + fileContentType + "," + fileContentSize + "," + System.DateTime.Now.ToString());
                return true;
            }
        }
        /// <summary>
        /// 数据绑定方法
        /// </summary>
        void Bind()
        {
            try
            {
                if (File.Exists(Server.MapPath(AppendixXmlPath + GUID + ".xml")))
                {

                    XmlDataSource xs = new XmlDataSource();
                    xs.DataFile = AppendixXmlPath + GUID + ".xml";
                    this.ListBox_img.DataSource = xs;

                    this.ListBox_img.DataValueField = "FileName"; //绑定ListBox单项的选择值
                    this.ListBox_img.DataTextField = "FileName";//绑定ListBox单项的文字值
                    this.ListBox_img.DataBind();
                    Xml_liulan.DocumentSource = this.AppendixXmlPath + this.GUID + ".XML";
                    Xml_liulan.TransformSource = "~/APP_DATA/Appendix/Appendix.XSL";
                }
            }
            catch { Response.Write("ListBox数据绑定出错！"); }
        }
        /// <summary>
        /// 附件绑定列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ListBox_img_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this, "确实要删除该项的附件吗！");
            try
            {
                new ROYcms.Common.XmlControl(Server.MapPath(AppendixXmlPath + GUID + ".xml")).Delete("Root/Appendix[@FileName=\"" + this.ListBox_img.SelectedValue + "\"]");
            }
            catch { Response.Write("删除XML节点出错！"); }
            try
            {
                File.Delete(Server.MapPath(FileRootPath + this.ListBox_img.SelectedValue));
                File.Delete(Server.MapPath(FileRootPath + "s_" + this.ListBox_img.SelectedValue));
            }
            catch { Response.Write("删除文件出错！"); }

            Bind();
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_add_web_Click(object sender, EventArgs e)
        {
            XmlNew(TextBox_web_url.Text, "Http", "Http", "0");
            Bind();
        }
    }
}
