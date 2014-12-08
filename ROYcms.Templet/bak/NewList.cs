using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Web;
using System.Text.RegularExpressions;
using ROYcms.Common;

namespace ROYcms.Templet
{
    /// <summary>
    /// 文章列表 频道 生成类 
    /// </summary>
   public class NewList:Template
    {
       Template Template = new Template();
       ROYcms.Sys.BLL.ROYcms_news BLL = new ROYcms.Sys.BLL.ROYcms_news();

       public bool err = false;

       private int? _onepage=null;
       private int? _classname=null;
       /// <summary>
       /// 每页分多少 Gets or sets the onepage.
       /// </summary>
       /// <value>The onepage.</value>
       public int? onepage
        {
            get { return _onepage; }
            set { _onepage = value; }
        }
       /// <summary>
       /// 分类 ID Gets or sets the classname.
       /// </summary>
       /// <value>The classname.</value>
       public int? classname
        {
            get { return _classname; }
            set { _classname = value; }
        }

       /// <summary>
       /// 文章列表 频道 生成方法  循环标签的匹配替换 News the HTML.
       /// </summary>
       /// <param name="Model">The model.ROYcms_class 表对象</param>
       /// <returns></returns>
        public bool NewHtml(ROYcms.Sys.Model.ROYcms_class Model)
        {

            //定义参数
            //StreamWriter sw = null;
            Model.FilePath =Model.FilePath.Replace("{cmspath}", "~");
            string Path = "";
            string ShowPath = "";
            string templatepath = null;//模版地址
            string HTML = "";//模版内容
            //最终列表栏目模式
            if (Model.ColumnsType == 0)
            {
                templatepath = Model.TemplateList;//模版地址

                // 生成默认页面开始
                string TemplateIndexHTML = PublicTag(SystemCms.Read_File(HttpContext.Current.Server.MapPath(templatepath), ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language")));
                string TemplateIndexPath = (Model.FilePath + Model.DefaultFile);     //文件生成地址
                NewMain(TemplateIndexPath, TemplateIndexHTML);
                //生成默认页面结束

                int onepage = (this.onepage == null ? 10 : Convert.ToInt32(this.onepage));
                int Count = new ROYcms.Sys.BLL.ROYcms_news().GetCount((this.classname == null ? "" : " classname=" + this.classname));
                int allpages = Count / onepage;
                string Text = "";
                string AllText = "";
                string content = "";
                Regex r = new Regex(@"(\[SG:loop\s+(?<attributes>[^\]]*?)\](?<text>[\s\S]*?)\[/SG:loop\])", RegexOptions.Compiled | RegexOptions.IgnoreCase);

                for (int i = 0; i < (allpages < 1 ? 1 : allpages); i++)
                {
                    HTML = PublicTag(SystemCms.Read_File(HttpContext.Current.Server.MapPath(templatepath), ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language")));
                    Path = (Model.ListeRules.Contains("~/") ? Model.ListeRules : (Model.FilePath + Model.ListeRules));//文件生成地址
                    Path = Path.Replace("{page}", i.ToString());
                    ShowPath = Model.ShowRules;
                    string tempath = Path.Substring(0, Path.LastIndexOf("/") + 1);

                    if (!Directory.Exists(HttpContext.Current.Server.MapPath(tempath)))
                    {
                        Directory.CreateDirectory(HttpContext.Current.Server.MapPath(tempath));
                    }

                    int start = i * onepage;
                    int nextpage = i + 1;
                    int perpage = i - 1;
                    if (nextpage == allpages)
                    {
                        nextpage = i;
                    }
                    if (perpage == -1)
                    {
                        perpage = 0;
                    }
                    string SQL = "SELECT TOP "
                                    + onepage +
                                    " * FROM  [ROYcms_news] WHERE (bh NOT IN (SELECT TOP "
                                    + start +
                                    " bh FROM [ROYcms_news] "
                                    + (this.classname == null ? "" : " where classname=" + this.classname) +
                                    " ORDER BY bh desc ))"
                                    + (this.classname == null ? "" : " and classname=" + this.classname) +
                                    " ORDER BY bh desc ";

                    DataSet ds = BLL.GetDataSet(SQL);
                    DataTable dt = ds.Tables[0];

                    using (StreamWriter sw = new StreamWriter(HttpContext.Current.Server.MapPath(Path), false, Encoding.GetEncoding(ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"))))
                    {

                        #region 对循环的内容进行替换
                        foreach (Match m in r.Matches(HTML))
                        {
                            Text = m.Groups["text"].ToString();             //循环的内容不包含SG:Loop
                            AllText = m.Groups[0].Value.ToString();         //整个匹配的内容包含SG:Loop

                            foreach (DataRow dr in dt.Rows)
                            {
                                string str = Text;
                                string T_ShowPath = ShowPath;
                                str = Template.Replace(str, @"\[SG:Id\]", dr["bh"].ToString());
                                str = Template.Replace(str, @"\[SG:Title\]", dr["title"].ToString());
                                str = Template.Replace(str, @"\[SG:zhaiyao\]", dr["zhaiyao"].ToString());
                                str = Template.Replace(str, @"\[SG:pic\]", dr["pic"].ToString());
                                str = Template.Replace(str, @"\[SG:classname\]", dr["classname"].ToString());
                                str = Template.Replace(str, @"\[SG:author\]", dr["author"].ToString());
                                str = Template.Replace(str, @"\[SG:time\]", dr["time"].ToString());
                                str = Template.Replace(str, @"\[SG:Year\]", Convert.ToDateTime(dr["time"]).ToString("yyyy"));
                                str = Template.Replace(str, @"\[SG:Month\]", Convert.ToDateTime(dr["time"]).ToString("MM"));
                                str = Template.Replace(str, @"\[SG:Day\]", Convert.ToDateTime(dr["time"]).ToString("dd"));

                                T_ShowPath = T_ShowPath.Replace("{yyyy}", Convert.ToDateTime(dr["time"]).ToString("yyyy"));
                                T_ShowPath = T_ShowPath.Replace("{MM}", Convert.ToDateTime(dr["time"]).ToString("MM"));
                                T_ShowPath = T_ShowPath.Replace("{dd}", Convert.ToDateTime(dr["time"]).ToString("dd"));
                                T_ShowPath = T_ShowPath.Replace("{id}", dr["bh"].ToString());
                                str = Template.Replace(str, @"\[SG:Link\]", T_ShowPath);

                                content += AllText.Replace(AllText, str);
                            }
                            HTML = HTML.Replace(AllText, content);

                            HTML = HTML.Replace(@"[SG:PageUp]", Model.ListeRules.Replace("{page}", perpage.ToString()));
                            HTML = HTML.Replace(@"[SG:PageDow]", Model.ListeRules.Replace("{page}", nextpage.ToString()));
                            content = "";
                        }

                        #endregion

                        //创建文件
                        try
                        {
                            sw.WriteLine(HTML);
                            sw.Flush();
                            err = true;
                        }
                        catch (Exception ex)
                        {
                            HttpContext.Current.Response.Write(ex.Message);
                            HttpContext.Current.Response.End();
                            err = false;
                        }
                        finally { sw.Close(); }
                    }
                }

            }
            //封面频道方式
            if (Model.ColumnsType == 1)
            {
                templatepath = Model.TemplateIndex;              //模版地址
                HTML = PublicTag(SystemCms.Read_File(HttpContext.Current.Server.MapPath(templatepath), ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language")));
                Path = (Model.FilePath + Model.DefaultFile);     //文件生成地址

                NewMain(Path, HTML);
                err = true;
            }
            return err;
            
        }

        /// <summary>
        /// 生成默认页 News the template.
        /// </summary>
        /// <returns></returns>
        public bool NewMain(string Path,string HTML) 
        {
            string tempath = Path.Substring(0, Path.LastIndexOf("/") + 1);
            if (!Directory.Exists(HttpContext.Current.Server.MapPath(tempath)))
            {
                Directory.CreateDirectory(HttpContext.Current.Server.MapPath(tempath));
            }
            using (StreamWriter sw = new StreamWriter(HttpContext.Current.Server.MapPath(Path), false, Encoding.GetEncoding(ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"))))
            {
                HTML = Template.LoopTag(HTML);
                //创建文件
                try
                {
                    sw.WriteLine(HTML);
                    sw.Flush();
                    err = true;
                }
                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write(ex.Message);
                    HttpContext.Current.Response.End();
                    err = false;
                }
                finally { sw.Close(); }
            }
            return err;
        }
        /// <summary>
        /// 生成所有栏目 News all HTML.
        /// </summary>
        /// <returns></returns>
        public bool NewAllHtml(int? ClassKind)
        {

            ROYcms.Sys.BLL.ROYcms_class BLL = new ROYcms.Sys.BLL.ROYcms_class();
            ROYcms.Sys.Model.ROYcms_class Model = new ROYcms.Sys.Model.ROYcms_class();

            DataSet ds = new DataSet();
            ds = BLL.GetClassList(Convert.ToInt32(ClassKind));

            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                Model = BLL.GetModel(dr["ClassId"].ToString());
                NewHtml(Model);
                err = true;
            }
            return err;
        }
    }
}
