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
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using ROYcms.Common;
using System.Xml;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_Objet_edit : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        public DataRow[] DC;
        #region bh属性
        /// <summary>
        /// XML help?
        /// </summary>
        protected string bh
        {
            get
            {
                return (string)ViewState["bh"];
            }
            set
            {
                ViewState["bh"] = value;
            }
        }
        #endregion
        #region ClassKind属性
        /// <summary>
        /// XML help?
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
        /// XML help?
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
        /// XML help?
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
        /// XML help?
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
        #region Date属性
        /// <summary>
        /// XML help?
        /// </summary>
        protected DateTime? Date
        {
            get
            {
                return (DateTime?)ViewState["Date"];
            }
            set
            {
                ViewState["Date"] = value;
            }
        }
        #endregion
       // public DateTime? Date = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                try
                {
                    this.Class = Request["class"];
                    this.WEBSITE_UP_FILES = Config.ROYcmsConfig.GetCmsConfigValue("upload_path");//上传文件目录
                    this.bh = Request["id"];
                    if (Request.QueryString["ClassKind"] != null)
                    {
                        this.ClassKind = Convert.ToInt32(Request.QueryString["ClassKind"]);
                        AppendixPath = "~/App_Appendix/" + this.ClassKind + "/";
                    }
                    DdlMenu_bind();
                   // XmlDataSource_ImgSize_Bind();

                    if (this.bh != null || this.bh.Trim() != "")
                    {
                        string id = this.bh;
                        ShowInfo(Convert.ToInt32(this.bh));
                        UrlBind(Convert.ToInt32(this.bh));
                    }


                    if (ROYcms.Common.Session.Get("user") != null)
                    {
                        this.txtauthor.Text = ROYcms.Common.Session.Get("user");
                    }
                }
                catch { Response.Redirect("/administrator/Message.aspx?message=没有该条信息！ 或信息已经被删除！&z=no"); }

            }
        }

        /// <summary>
        /// Shows the info.绑定数据显示到表单
        /// </summary>
        /// <param name="bh">The bh.</param>
        private void ShowInfo(int bh)
        {
            ROYcms.Sys.Bll.ROYcms_news bll = new ROYcms.Sys.Bll.ROYcms_news();
            ROYcms.Sys.Model.ROYcms_news model = bll.GetModel(bh);

            this.Date = model.time;
            this.txtpic.Text = model.pic;
            this.txttitle.Text = model.title;
            this.DdlMenu.SelectedValue = model.classname.ToString();
            this.keyword.Text = model.keyword;//默认值
            this.txtzhaiyao.Text = model.zhaiyao;
            FCKeditor1.Value = model.contents;
            this.txtinfor.Text = model.infor;
            this.jumpurl.Text = model.jumpurl;
            this.txtauthor.Text = model.author;
            this.txturl.Text = model.url;
            this.txttag.Text = model.tag;
            this.txthits.Text = model.hits.ToString();
            this.txtdig.Text = model.dig.ToString();
            this.orders.Value = model.orders.ToString();
            if (model.jumpurl != "")
            {
                this.jumpurl_on_of.Checked = true;
            }
            if (model.ding == 0)
            {
                this.ding.Checked = true;
            }
            if (model.tuijian == 0)
            {
                this.tuijian.Checked = true;
            }
            if (model.switchs == 0)
            {
                this.switchs.Checked = true;
            }
            //绑定页面视图参数
            this.GUID = model.GUID;
            this.ClassKind =Convert.ToInt32(model.type);
            
            
           // this.Class = model.classname.ToString();
        }
        /// <summary>
        /// 地址信息绑定
        /// </summary>
        /// <param name="NewId">The source of the event.</param>
        public void UrlBind(int NewId)
        {       
            if (___ROYcms_Url_bll.Exists_bh(NewId))
            {
                ___ROYcms_Url_model = ___ROYcms_Url_bll.GetModel_bh(NewId);
                Z_url_clk.Checked = true;
                z_Url.Value = ___ROYcms_Url_model.Url;
            }
        }
        /// <summary>
        /// XML help?
        /// </summary>
        protected void ImageButton_add_Click(object sender, EventArgs e)
        {
            if (ROYcms.Common.Session.Gets("administrators")!=null && ROYcms.Common.Session.Gets("administrators")[2] != "0") 
            { Response.Redirect("/administrator/Message.aspx?message=录入信息--<b></b>--失败！没有权限操作！&z=no"); }
            else
            {
                edit();
            }
            Response.Redirect("/administrator/Message.aspx?message=录入信息--<b></b>--成功！&z=yes");
        }
        /// <summary>
        /// 添加新闻和作者的关系
        /// </summary>
        /// <param name="NewId"></param>
        /// <param name="URL"></param>
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
        ///// <summary>
        /////附件数据暂存在临时文件 成功后转移到相应目录  Shears the file.
        ///// </summary>
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
        /// <summary>
        /// 编辑信息方法 Edits this instance.
        /// </summary>
        protected void edit()
        {

            int bh = Convert.ToInt32(this.bh);
            string pic = this.txtpic.Text;
            string title = this.txttitle.Text;


            if (this.styles.Value != "")
            {
                title = "[size=" + this.styles.Value + "]" + title + "[/size]";
            }
            if (this.colors.Value != "")
            {
                title = "[color=" + this.colors.Value + "]" + title + "[/color]";
            }

            string keyword = this.keyword.Text;//默认值
            string zhaiyao = this.txtzhaiyao.Text;
            // int classname =Convert.ToInt32(this.Class);//////////////////////////////////////////
            int classname = int.Parse(this.DdlMenu.SelectedValue);
            string contents = FCKeditor1.Value;
            string infor = this.txtinfor.Text;

            string author = this.txtauthor.Text.Trim();
            string url = this.txturl.Text;
            string tag = this.txttag.Text;
            int hits = int.Parse(this.txthits.Text.Trim());
            int dig = int.Parse(this.txtdig.Text.Trim());
            int orders = 0;
            string jumpurl = "";
            if (this.jumpurl_on_of.Checked)
            {
                jumpurl = this.jumpurl.Text.Trim();
            }
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
            model.bh = bh;
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
            if (this.Date != null)
            {
                model.time = this.Date;
            }
            else
            {
                model.time = DateTime.Now;
            }
            model.type = this.ClassKind.ToString();
            model.GUID = this.GUID;
            ShearFile();//删除临时附件信息
            NewXml(bh);//生成XML
            if (Request["Z_url_clk"] == "0")
            {
                Add_New_Url(Convert.ToInt32(this.bh), Request["Z_url"]); //修改路径
            }

            ROYcms.Sys.Bll.ROYcms_news bll = new ROYcms.Sys.Bll.ROYcms_news();
            bll.Update(model);
        }
        ///// <summary>
        ///// 添加 形象图 按钮事件 Handles the Click event of the Button_add_img control.
        ///// </summary>
        ///// <param name="sender">The source of the event.</param>
        ///// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        //protected void Button_add_img_Click(object sender, EventArgs e)
        //{

        //    if (ROYcms.Common.Session.Get("user") != null)
        //    {
        //        AddImg(ROYcms.Common.Session.Get("user") + "/");
        //    }
        //    else
        //    {
        //        AddImg((this.txtauthor.Text.Trim() == "" ? "admin" : this.txtauthor.Text.Trim()) + "/");
        //    }
        //}
        ///// <summary>
        ///// 添加 形象图 方法 Adds the img.
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
        //                up_img.AddWaterPic(webFilePath + "_" + fileName, webFilePath + fileName, Server.MapPath("~/App_Data/Water.png"));          // 生成缩略图方法

        //                // FCKeditor1.Value = FCKeditor1.Value + "<img src=" + Config.ROYcmsConfig.Get_Config().web_host + this.AppendixPath.Replace("~/", "") + path + fileName + " />";
        //                txtpic.Text = fileName;
        //                ROYcms.Common.MessageBox.Show(this, "上载成功!");
        //            }
        //            catch
        //            {
        //                ROYcms.Common.MessageBox.Show(this, "文件上传失败!");
        //                // Response.Write("文件上传失败!");
        //            }
        //        }
        //        else
        //        {
        //            ROYcms.Common.MessageBox.Show(this, "文件类型不符!");
        //            // Response.Write("文件类型不符!");
        //        }
        //    }
        //}

        #region 数据绑定
        /// <summary>
        /// DDLs the menu_bind.
        /// </summary>
        void DdlMenu_bind()
        {
            DataSet ds = new ROYcms.Sys.Bll.ROYcms_class().GetClassList(this.ClassKind);

            this.DdlMenu.Items.Clear();
            this.DdlMenu.Items.Add(new ListItem("请选择所属分类", ""));
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int ClassTj = Convert.ToInt32(dr["ClassTj"]);
                string Id = dr["Id"].ToString().Trim();
                string ClassName = dr["ClassName"].ToString().Trim();

                if (ClassTj == 1)
                {
                    this.DdlMenu.Items.Add(new ListItem(ClassName, Id));

                }
                else
                {
                    ClassName = "├ " + ClassName;
                    ClassName = ROYcms.Common.StringPlus.StringOfChar(ClassTj - 1, "　") + ClassName;

                    this.DdlMenu.Items.Add(new System.Web.UI.WebControls.ListItem(ClassName, Id));
                }
            }

        }
        #endregion

        /// <summary>
        /// 创建XML 数据文件  News the XML.
        /// </summary>
        /// <returns></returns>
        public bool NewXml(int ID)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0",  Config.ROYcmsConfig.GetCmsConfigValue("templet_language"), null);
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
                DC = DS.Tables[0].Select("Classkind=" + this.ClassKind + "");

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
            if (___ROYcms_Form_class_classkind_bll.GetModel_class_id(Convert.ToInt32(this.Class)) != null)
            {
               // content = ROYcms.Templet.ObjetForm.ReplaceFormDate(___ROYcms_Form_bll.GetModel(Convert.ToInt32(___ROYcms_Form_class_classkind_bll.GetModel_class_id(Convert.ToInt32(this.Class)).From_id)).Contents, Convert.ToInt32(this.bh), this.ClassKind.ToString());
            }
            else { content = "<h3>未定义智能表单扩展!</h3>"; }
            return content;
           
        }
    }
}