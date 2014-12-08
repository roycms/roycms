/**********************************************************************************
 * Description:     
 * MemberVariable:
 * Functions:       
 * Modify information:     
 * 2008-8-5     New           DuYaoHui     Create Class
 * 
 * ********************************************************************************/
using System;
using System.Data;
using System.Web.UI.WebControls;
using ROYcms.Common;
using System.IO;
using System.Xml;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 插入对象类
    /// </summary>
    public partial class Administrator_Objet_add : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        public DataRow[] DC;

        #region ClassKind属性
        /// <summary>
        /// 
        /// </summary>
        protected int ClassKind
        {
            get
            {
                return (int)ViewState["ClassKind"];
            }
            set
            {
                ViewState["ClassKind"] = value;
            }
        }
        #endregion
        #region Class属性
        /// <summary>
        /// 
        /// </summary>
        protected string[] Class
        {
            get
            {
                return (string[])ViewState["Class"];
            }
            set
            {
                ViewState["Class"] = value;
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
        #region AppendixPath属性
        /// <summary>
        /// 
        /// </summary>
        protected string AppendixPath
        {
            get
            {
                return (string)ViewState["AppendixPath"];
            }
            set
            {
                ViewState["AppendixPath"] = value;
            }
        }
        #endregion
        #region WEBSITE_UP_FILES属性
        /// <summary>
        /// 
        /// </summary>
        protected string WEBSITE_UP_FILES
        {
            get
            {
                return (string)ViewState["WEBSITE_UP_FILES"];
            }
            set
            {
                ViewState["WEBSITE_UP_FILES"] = value;
            }
        }
        #endregion
        #region pic属性
        /// <summary>
        /// 
        /// </summary>
        protected string pic
        {
            get
            {
                return (string)ViewState["pic"];
            }
            set
            {
                ViewState["pic"] = value;
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
                this.Class = Request["Class"].Split(',');
                this.WEBSITE_UP_FILES = Config.ROYcmsConfig.GetCmsConfigValue("upload_path");//上传文件目录
                if (GUID == null)
                {
                    GUID = System.Guid.NewGuid().ToString();
                }
  
                if (Request.QueryString["ClassKind"] != null)
                {
                    this.ClassKind = Convert.ToInt32(Request.QueryString["ClassKind"]);
                    this.AppendixPath = "~/App_Appendix/" + this.ClassKind + "/";
                }
                else 
                {
                    Response.Redirect("/administrator/Message.aspx?message=<b>参数ClassKind 错误！</b>&z=no");
                }
                //XmlDataSource_ImgSize_Bind();

                //分组新闻信息
                if (Request["newid"] != null) { this.txttitle.Text = ___ROYcms_news_Bll.GetTitle(Convert.ToInt32(Request["newid"])) + " [分页副标题]"; }
                BindDate();
            }
        }
        /// <summary>
        /// 数据绑定/
        /// </summary>
        public void BindDate()
        {
            if (ROYcms.Common.Session.Get("administrator") != null)
            {
                this.txtauthor.Text = ROYcms.Common.Session.Get("administrator");
            }
            if (ROYcms.Common.Session.Get("user") != null)
            {
                this.txtauthor.Text = ROYcms.Common.Session.Get("user");
                this.switchs.Checked = false;
            }
        }
        /// <summary>
        /// 添加事件  Handles the Click event of the ImageButton_add control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Web.UI.ImageClickEventArgs"/> instance containing the event data.</param>
        protected void ImageButton_add_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            int news_id = 0;
            if (this.Class.Length > 0)
            {
                for (int i = 0; i < this.Class.Length; i++)
                {
                   news_id = add(i);
                }
            }
            if (Request["newid"] != null) {
                ___ROYcms_News_Group_model.index_news_id=Convert.ToInt32(Request["newid"]);
                ___ROYcms_News_Group_model.news_id=news_id;
                ___ROYcms_News_Group_model.Time = DateTime.Now;
                ___ROYcms_News_Group_bll.Add(___ROYcms_News_Group_model);
            }
            Response.Redirect(String.Format("/administrator/Message.aspx?message=<b>录入{0}条信息--成功！</b>&z=yes&new={0},{1},{2},{3}", this.Class.Length, this.ClassKind, this.Class[0], news_id));

        }
        /// <summary>
        /// 添加信息方法  Adds the specified i.
        /// </summary>
        /// <param name="i">The i.</param>
        int add(int i)
        {
            string pic = ROYcms.Common.input.Htmls(this.txtpic.Text);


            string title = ROYcms.Common.input.Htmls(this.txttitle.Text);

            if (this.styles.Value != "")
            {
                title = "[size=" + this.styles.Value + "]" + title + "[/size]";
            }
            if (this.colors.Value != "")
            {
                title = "[color=" + this.colors.Value + "]" + title + "[/color]";
            }

            string keyword = ROYcms.Common.input.Htmls(this.keyword.Text);//默认值
            string zhaiyao = ROYcms.Common.input.Htmls(this.txtzhaiyao.Text);
            int classname = int.Parse(this.Class[i]);
            string contents = FCKeditor1.Value;
            string infor = ROYcms.Common.input.Htmls(this.txtinfor.Text);

            string author = ROYcms.Common.input.Htmls(this.txtauthor.Text.Trim());
            string url = ROYcms.Common.input.Htmls(this.txturl.Text);
            string tag = ROYcms.Common.input.Htmls(this.txttag.Text);
            int hits = int.Parse(this.txthits.Text.Trim());
            int dig = int.Parse(this.txtdig.Text.Trim());

            string jumpurl = "";
            if (this.jumpurl_on_of.Checked)
            {
                jumpurl = ROYcms.Common.input.Htmls(this.jumpurl.Text.Trim());
            }
            int orders = 0;
            if (this.orders.Value != "")
            {
                orders = int.Parse(this.orders.Value);
            }

            int ding = 1;
            if (this.ding.Checked)
            {
                ding = 0;
            }
            int tuijian = 1;
            if (this.tuijian.Checked)
            {
                tuijian = 0;
            }
            int switchs = 1;
            if (this.switchs.Checked)
            {
                switchs = 0;
            }


            ROYcms.Sys.Model.ROYcms_news model = new ROYcms.Sys.Model.ROYcms_news();
            model.pic = pic;
            model.title = title;
            if (keyword == "") { keyword = title; }
            else { model.keyword = keyword; }
            if (zhaiyao == "") { zhaiyao = title; }
            else { model.zhaiyao = zhaiyao; }
            model.classname = classname;
            model.contents = contents;
            model.infor = infor;
            model.jumpurl = jumpurl;
            model.author = author;
            model.url = url;
            model.tag = tag;
            model.orders = orders;
            model.ding = ding;
            model.tuijian = tuijian;
            model.dig = dig;
            model.hits = hits;
            model.switchs = switchs;
            model.link = "";
            model.type = this.ClassKind.ToString();
            model.GUID = this.GUID;
            ROYcms.Sys.Bll.ROYcms_news bll = new ROYcms.Sys.Bll.ROYcms_news();
            
            if (tag != ""){ AddTag(tag);}
            int ID = bll.Add(model);
            if (ID != 1)
            {
                Add_New_User(ID);//添加新闻和作者的关系
                ShearFile();//删除临时附件信息
                NewXml(ID);//创建新闻XML
                
               // NewHtml(ID, classname);//静态生成文件
                if (Request["txttag"] != "") { AddTag(tag); }
                if (Request["Z_url_clk"] == "0") 
                {
                    Add_New_Url(ID, Request["Z_url"]); 
                }
             
            }
            return ID;
        }
        /// <summary>
        ///.添加新闻和作者的关系
        /// </summary>
        public void Add_New_User(int NewId)
        {
            if (ROYcms.Common.Session.Gets("Users") != null)
            {
                ___ROYcms_New_User_model.New_id = NewId;
                ___ROYcms_New_User_model.User_id = Convert.ToInt32(ROYcms.Common.Session.Gets("Users")[1]);
                ___ROYcms_New_User_bll.Add(___ROYcms_New_User_model);
            }
        }
        /// <summary>
        ///.添加新闻和作者的关系
        /// </summary>
        public void Add_New_Url(int NewId, string URL)
        {
            ___ROYcms_Url_model.isurl = 0;
            ___ROYcms_Url_model.bh = NewId;
            ___ROYcms_Url_model.Url = URL;
            ___ROYcms_Url_model.Time = DateTime.Now;
            if (!___ROYcms_Url_bll.Exists_bh(NewId))
            {
                ___ROYcms_Url_bll.Add(___ROYcms_Url_model);
            }
            else
            {
                ___ROYcms_Url_bll.Update_bh(___ROYcms_Url_model);
            }

            //生成文件
            string HtmlText = ROYcms.Common.GetUrlText.GetText(Config.ROYcmsConfig.GetCmsConfigValue("web_host") + "show_" + NewId + ".html", Config.ROYcmsConfig.GetCmsConfigValue("templet_language"));

            if (!Directory.Exists(Server.MapPath(URL.Substring(0, URL.LastIndexOf("/")))))
            {
                Directory.CreateDirectory(Server.MapPath(URL.Substring(0, URL.LastIndexOf("/")))); //创建新路径 
            }

            ROYcms.Common.SystemCms.CreateFile(Server.MapPath(URL), HtmlText, Config.ROYcmsConfig.GetCmsConfigValue("templet_language"));
        }
        /// <summary>
        ///附件数据暂存在临时文件 成功后转移到相应目录  Shears the file.
        /// </summary>
        void ShearFile()
        {
            try
            {
                string oldFile = Server.MapPath("~/app_data/Appendix/temp/" + this.ClassKind + "/" + this.GUID + ".xml");
                string newFile = Server.MapPath("~/app_data/Appendix/" + this.ClassKind + "/" + this.GUID + ".xml");
                string newFilePath = Server.MapPath("~/app_data/Appendix/" + this.ClassKind + "/");
                string oldDir = Server.MapPath("~/App_Appendix/temp/" + this.ClassKind + "/" + this.GUID + "/");
                string newDir = Server.MapPath("~/App_Appendix/" + this.ClassKind + "/" + this.GUID + "/");
                string newDirPath = Server.MapPath("~/App_Appendix/" + this.ClassKind + "/");

                if (Directory.Exists(newFilePath) && Directory.Exists(newDirPath))//判断是否存在
                {
                    File.Move(oldFile, newFile);
                    Directory.Move(oldDir, newDir);
                }
                else
                {
                    Directory.CreateDirectory(newFilePath);//创建新路径 
                    Directory.CreateDirectory(newDirPath);//创建新路径 
                    File.Move(oldFile, newFile);
                    Directory.Move(oldDir, newDir);
                }

            }
            catch
            {
                ROYcms.Common.MessageBox.Show(this, "信息发布成功！文件上传失败！");
            }
        }

        ///// <summary>
        ///// 添加形象图事件 Handles the Click event of the Button_add_img control.
        ///// </summary>
        ///// <param name="sender">The source of the event.</param>
        ///// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        //protected void Button_add_img_Click(object sender, EventArgs e)
        //{
        //    //if (ROYcms.Common.Session.Get("user") != null)
        //    //{
        //    //    AddImg(ROYcms.Common.Session.Get("user") + "/");
        //    //}
        //    //else
        //    //{
        //    //    AddImg((this.txtauthor.Text.Trim() == "" ? "admin" : this.txtauthor.Text.Trim()) + "/");
        //    //}
        //    AddImg("/");
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public bool AddTag(string tag)
        {
            string[] Tag = ROYcms.Common.input.SubGroup(tag);
            for (int i = 0; i < Tag.Length; ++i)
            {
                ___ROYcms_Tag_model.Tag = Tag[i];
                ___ROYcms_Tag_model.type = "News";
                ___ROYcms_Tag_model.Time = DateTime.Now;
                ___ROYcms_Tag_bll.Add(___ROYcms_Tag_model);
            }
            return true;
        } 
        ///// <summary>
        ///// 添加形象图方法 Adds the img.
        ///// </summary>
        ///// <param name="path">The path.</param>
        //void AddImg(string path)
        //{
        //    UP_img up_img = new UP_img();
        //    if (FileUpload1.HasFile)
        //    {
        //        string fileContentType = FileUpload1.PostedFile.ContentType;
        //        if (fileContentType == "image/bmp" || fileContentType == "image/gif" || fileContentType == "image/pjpeg")
        //        {
        //            string name = FileUpload1.PostedFile.FileName;                         // 客户端文件路径
        //            FileInfo file = new FileInfo(name);
        //            string fileName = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + name.Substring(name.LastIndexOf("."), name.Length - name.LastIndexOf("."));                                           // 文件名称
        //            string webFilePath = Server.MapPath(this.WEBSITE_UP_FILES + path);          // 服务器端文件路径

        //            string webFilePath_s = Server.MapPath(this.WEBSITE_UP_FILES + path + "s_");　　  // 服务器端缩略图路径

        //            if (!Directory.Exists(webFilePath))//判断是否存在
        //            {
        //                Directory.CreateDirectory(webFilePath);//创建新路径 
        //            }
        //            try
        //            {
        //                this.FileUpload1.SaveAs(webFilePath + "_" + fileName);                                 // 使用 SaveAs 方法保存文件
        //                string[] Size = DropDownList_ImgSize.SelectedValue.Split(',');
        //                up_img.MakeThumbnail(webFilePath + "_" + fileName, webFilePath_s + fileName, Convert.ToInt32(Size[0]), Convert.ToInt32(Size[1]), "W");          // 生成缩略图方法
        //                up_img.AddWaterPic(webFilePath + "_" + fileName, webFilePath + fileName, Server.MapPath("~/App_Data/Water.png"));
        //                //FCKeditor1.Value = FCKeditor1.Value + "<img src=" + Config.ROYcmsConfig.Get_Config().web_host + this.AppendixPath.Replace("~/", "") + path + fileName + " />";
        //                this.txtpic.Text = fileName;
        //                //this.pic = "<a href='" + this.AppendixPath.Replace("~/", "/") + path + fileName + "' target='_blank'><img src='/pic.gif' alt='查看上传的图片' width='16' height='16' border='0'></a> ";
        //                ROYcms.Common.MessageBox.Show(this, "上载成功!");
        //            }
        //            catch
        //            {
        //                ROYcms.Common.MessageBox.Show(this, "文件上传失败!");
        //               // Response.Write("文件上传失败!");
        //            }
        //        }
        //        else
        //        {
        //            ROYcms.Common.MessageBox.Show(this, "文件类型不符!");
        //           // Response.Write("文件类型不符!");
        //        }
        //    }
        //}    
        
        /// <summary>
        /// 判断该表单项是否显示 Is the s_ IN.
        /// </summary>
        /// <returns></returns>
        public bool IS_IN(string name)
        {
            bool err = false;
            try
            {
                string filepath = "~/app_CONFIG/TemplateFrom.xml";
                DataSet DS = new DataSet();
                DS.ReadXml(Server.MapPath(filepath));
                if (this.Class == null)
                {
                    DC = DS.Tables[0].Select("Classkind=" + this.ClassKind + "");
                }
                else { DC = DS.Tables[0].Select("Class=" + this.Class[0] + ""); }

                err = DC[0]["Visible"].ToString().Contains(name);
            }
            catch { err = false; }
            return err;
        }
        /// <summary>
        /// 自定义表单输出  Bind_s the from_ XML.
        /// </summary>
        public string From_Out()
        {

            string content = null;
            if (___ROYcms_Form_class_classkind_bll.GetModel_class_id(Convert.ToInt32(this.Class[0])) != null)
            {
                content = ___ROYcms_Form_bll.GetModel(Convert.ToInt32(___ROYcms_Form_class_classkind_bll.GetModel_class_id(Convert.ToInt32(this.Class[0])).From_id)).Contents;
            }
            else { content = "<h3>未定义智能表单扩展!</h3>"; }
            return content;
        }
        /// <summary>
        /// 创建XML 数据文件  News the XML.
        /// </summary>
        /// <returns></returns>
        public bool NewXml(int ID)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", Config.ROYcmsConfig.GetCmsConfigValue("templet_language"), null);
                doc.AppendChild(dec);
                //创建一个根节点（一级） 
                XmlElement root = doc.CreateElement("ROYcms");
                doc.AppendChild(root);
                //创建节点（二级） 
                XmlNode node = doc.CreateElement("News");
                XmlAttribute attr = null;
                attr = doc.CreateAttribute("Time");
                attr.Value = DateTime.Now.ToString();
                node.Attributes.SetNamedItem(attr);
                for (int i = 0; i < Request.Form.Count; i++)
                {
                    //Request.Form.Remove("");
                    //带有"<![CDATA[   ]]>"的元素 
                    if (!Request.Form.GetKey(i).Contains("_"))
                    {
                        XmlElement element = doc.CreateElement(Request.Form.GetKey(i));
                        //element.SetAttribute("Name", Request.Form.GetKey(i));
                        ////element.InnerText = "Round Comment";
                        XmlCDataSection idata = doc.CreateCDataSection("item");
                        idata.InnerText = Request.Form.Get(i);
                        element.AppendChild(idata);
                        node.AppendChild(element);
                    }
                }
                root.AppendChild(node);
                if (!Directory.Exists(Server.MapPath("~/APP_XML/" + this.ClassKind + "/")))
                {
                    Directory.CreateDirectory(Server.MapPath("~/APP_XML/" + this.ClassKind + "/")); //创建新路径 
                }
                doc.Save(Server.MapPath("~/APP_XML/" + this.ClassKind + "/" + ID + ".xml"));
                Console.Write(doc.OuterXml);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 生成静态HTML文件 News the HTML.
        /// </summary>
        public void NewHtml(int bh, int classname)
        {
            //if (Config.ROYcmsConfig.GetCmsConfigValue("html") == "true")
            //{
            //    ROYcms.Templet.NewIndex NewIndex = new ROYcms.Templet.NewIndex();
            //    ROYcms.Templet.NewList NewList = new ROYcms.Templet.NewList();
            //    ROYcms.Templet.NewShow NewShow = new ROYcms.Templet.NewShow();
            //    ROYcms.Sys.Bll.ROYcms_class BLL = new ROYcms.Sys.Bll.ROYcms_class();
            //    ROYcms.Sys.Model.ROYcms_class model = BLL.GetModel(BLL.GetClassId(Convert.ToInt32(classname)));

            //    NewList.classname = classname;
            //    NewList.onepage = 30;
            //    NewList.NewHtml(model);

            //    NewList.NewAllHtml(model.ClassKind);

            //    NewShow.bh = bh;
            //    NewShow.NewHtml(model);

            //    NewIndex.NewHtml();
            //}
        }

        ///// <summary>
        ///// XMLs the data source_ img size_ bind.
        ///// </summary>
        //public void XmlDataSource_ImgSize_Bind()
        //{
        //    try
        //    {
        //        string filepath = "~/app_data/ImgSize/" + this.ClassKind + ".xml";
        //        if (!File.Exists(Server.MapPath(filepath)))
        //        {
        //            filepath = "~/app_data/ImgSize/index.xml";
        //        }
        //        XmlDataSource ImgSize = new XmlDataSource();
        //        ImgSize.DataFile = filepath;
        //        this.DropDownList_ImgSize.DataSource = ImgSize;
        //        this.DropDownList_ImgSize.DataValueField = "size"; //
        //        this.DropDownList_ImgSize.DataTextField = "name";//
        //        this.DropDownList_ImgSize.DataBind();

        //    }
        //    catch { Response.Write("数据绑定出错！"); }
        //}
    }
}