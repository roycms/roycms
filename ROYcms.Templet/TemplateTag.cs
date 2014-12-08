/**********************************************************************************
 * ClassName:       TemplateTag
 * Description:     处理模板标签类
 * MemberVariable:
 * Functions:       
 * Modify information:     
 * 2008-8-5     New           DuYaoHui     Create Class
 * 
 * ********************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Data;
using System.Web.UI.WebControls;
using System.Web;
using ROYcms.Common;
using ROYcms.Sys.Model;
namespace ROYcms.Templet
{

    /// <summary>
    /// 模板标签处理类
    /// </summary>
    public class TemplateTag
    {
        /// <summary>
        /// _Config构造函数
        /// </summary>
        /// <value>The page num.</value>
        /// 
        ROYcms.Sys.BLL.ROYcms_news Bll = new ROYcms.Sys.BLL.ROYcms_news();
        ROYcms.Sys.BLL.ROYcms_template _BLL = new ROYcms.Sys.BLL.ROYcms_template();
        ROYcms.Sys.Model.ROYcmsConfig config;
        public TemplateTag(ROYcms.Sys.Model.ROYcmsConfig _Configs)
        {
            config = _Configs;
        }
        /// <summary>
        /// 列表数据
        /// </summary>
        private string _templet;        
        private string _type;             
        private string _bh;
        private string _classs;    
        private string _pageNum;
        private string _pageHost;
        private HttpContext Context;
        /// <summary>
        /// 模板编号
        /// </summary>
        /// <value>The templet_id.</value>
        public string templet
        {
            get { return _templet; }
            set { _templet = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <value>The type.</value>
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <value>The type.</value>
        public string classs
        {
            get { return _classs; }
            set { _classs = value; }
        }
        /// <summary>
        /// 新闻页面参数
        /// </summary>
        /// <value>The bh.</value>
        public string bh
        {
            get { return _bh; }
            set { _bh = value; }
        }
        /// <summary>
        /// 页面分页大小
        /// </summary>
        /// <value>The page num.</value>
        public string pageNum
        {
            get { return _pageNum; }
            set { _pageNum = value; }
        }
        /// <summary>
        /// URL地址host
        /// </summary>
        /// <value>The page num.</value>
        public string pageHost
        {
            get { return _pageHost; }
            set { _pageHost = value; }
        }
        /// <summary>
        /// GEs the t_ DATE.
        /// </summary>
        /// <param name="Con">The con.</param>
        /// <returns></returns>
        public  string ArticlsHtml(HttpContext Con)
        {
            //初始化一些参数
            this.Context = Con;
            this.type = Context.Request["type"];
            this.bh = Context.Request["id"];
            this.templet = Context.Request["templet"];
            this.pageNum = Context.Request["page_Num"];    //分页  page 参数
            this.classs = Context.Request["class"];    //list页的分类编号参数
            this.pageHost = Context.Request["host"];   
            //模板URL
            string templet_url = "~/" + config.templet_root + "/" + TemplateZone.TemplateZpath(this.pageHost) + "/" + type + templet + ".html";
            //读取 模板
            StringBuilder HTM = new StringBuilder();

            if (DataCache.GetCache(templet_url) == null)
            {
                try
                {
                    if (SystemCms.Read_File(Context.Server.MapPath(templet_url),config.templet_language) == null)
                    {
                        //目录不存在创建
                        if (!Directory.Exists(Con.Server.MapPath("~/" + config.templet_root + "/" + TemplateZone.TemplateZpath(this.pageHost) + "/")))
                        {
                            Directory.CreateDirectory(Con.Server.MapPath("~/" + config.templet_root + "/" + TemplateZone.TemplateZpath(this.pageHost) + "/"));
                        }

                        if (this.templet != null)
                        {
                            ROYcms.Sys.Model.ROYcms_template model = _BLL.GetModel(Convert.ToInt32(this.templet));
                            HTM.Append(model.htmlcontent);
                            SystemCms.CreateFile(Con.Server.MapPath(templet_url), model.htmlcontent,config.templet_language);
                        }
                        else
                        {
                            HTM.Append("模板不存在！");
                            SystemCms.CreateFile(Con.Server.MapPath(templet_url), "ROYcms!NT  空模板,请编辑",config.templet_language);
                        }
                    }
                    else {

                        HTM.Append(SystemCms.Read_File(Context.Server.MapPath(templet_url),config.templet_language));
                    }
                    DataCache.SetCache(templet_url, (object)SystemCms.Read_File(Context.Server.MapPath(templet_url),config.templet_language));
                }
                catch { HTM.Append("读取模板异常!确定是否有创建文件的权限"); }
            }
            else { HTM.Append(DataCache.GetCache(templet_url).ToString()); }
            if (config.HTML_zip == "true")
            {
                return SystemCms.ZipHtml(LoopClass(loopPage(ShowTag(LoopTag(PublicTag(HTM.ToString()))))));
            }
            else {
                return LoopClass(loopPage(ShowTag(LoopTag(PublicTag(HTM.ToString())))));
            }
        }
      
        ///// <summary>
        ///// 替换字符
        ///// </summary>
        ///// <param name="template">要替换的文本</param>
        ///// <param name="tag">标签</param>
        ///// <param name="value">内容</param>
        ///// <returns></returns>
        public string Replace(string template, string tag, string value)
        {
            if (!string.IsNullOrEmpty(value))
                template = Regex.Replace(template, tag, value, RegexOptions.IgnoreCase);
            else
                template = Regex.Replace(template, tag, "", RegexOptions.IgnoreCase);
            return template;
        }
        /// <summary>
        /// 返回一组标签中指定属性的值小写格式
        /// 属性值必须被双引号括起来。
        /// </summary>
        /// <param name="Tag">一组标签</param>
        /// <param name="TagName">属性名称</param>
        /// <returns>属性的小写值</returns>
        public string TagVal(string tag, string tagName)
        {
            Regex rt = new Regex(@"(?<Keyword>\w+)\s*=\s*(?<Value>" + "\"" + "[^\"]*\")", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (Match mt in rt.Matches(tag))
            {
                if (mt.Groups["Keyword"].ToString().Trim().ToLower() == tagName.ToLower())
                {
                    return mt.Groups["Value"].ToString().ToLower().Replace("\"", "");
                }
            }
            return null;
        }

        ///// <summary>
        ///// loop标签的匹配替换
        ///// </summary>
        ///// <param name="template">模板内容</param>
        public string LoopClass(string template)
        {
            string Attributes = "";
            string Text = "";
            string AllText = "";
            Regex r = new Regex(@"(\[SG:class\s+(?<attributes>[^\]]*?)\](?<text>[\s\S]*?)\[/SG:class\])", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            foreach (Match m in r.Matches(template))
            {
                Attributes = m.Groups["attributes"].ToString(); //循环属性集
                Text = m.Groups["text"].ToString();             //循环的内容不包含SG:Loop
                AllText = m.Groups[0].Value.ToString();         //整个匹配的内容包含SG:Loop

                #region  取得相关属性
                string Count = null;     //调用数量
                string classID = null;
                string Templet = null;       // 模板ID

                Templet = TagVal(Attributes, "Templet");
                Count = TagVal(Attributes, "Count");

                classID = TagVal(Attributes, "classID");

                #endregion

                #region 对循环的内容进行替换
                string content = "";
                ROYcms.Sys.BLL.ROYcms_class bll = new ROYcms.Sys.BLL.ROYcms_class();
                DataSet dt = bll.GetClassList(0);
                if (classID != null)
                {
                    dt = bll.GetSubClassList(bll.GetClassId(Convert.ToInt32(classID)));
                }
                if (dt.Tables[0].Rows.Count > 0)
                {
                    int rowsCount = dt.Tables[0].Rows.Count;
                    if (Count != null && rowsCount>Convert.ToInt32(Count))
                    {
                        rowsCount = Convert.ToInt32(Count);
                    }
                    for (int n = 0; n < rowsCount; n++)
                    {
                        string str = Text;
                        str = Replace(str, @"\[SG:ClassName\]", dt.Tables[0].Rows[n]["ClassName"].ToString());
                        str = Replace(str, @"\[SG:Link\]", config.web_host + TemplateZone.Zpath(this.pageHost) + "list" + Templet + "-" + dt.Tables[0].Rows[n]["Id"].ToString() + config.web_forge);
                        str = Replace(str, @"\[SG:_Link\]", "list-" + dt.Tables[0].Rows[n]["Id"].ToString() + config.web_forge);
                        content += str;
                    }
                }
                else
                {
                    content = "";
                }
                #endregion
                template = template.Replace(AllText, content);
                
            }
            return template;
        }

        ///// <summary>
        ///// loop标签的匹配替换
        ///// </summary>
        ///// <param name="template">模板内容</param>
        public string LoopTag(string template)
        {
            string Attributes = "";
            string Text = "";
            string AllText = "";
            Regex r = new Regex(@"(\[SG:loop\s+(?<attributes>[^\]]*?)\](?<text>[\s\S]*?)\[/SG:loop\])", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            foreach (Match m in r.Matches(template))
            {
                Attributes = m.Groups["attributes"].ToString(); //循环属性集
                Text = m.Groups["text"].ToString();             //循环的内容不包含SG:Loop
                AllText = m.Groups[0].Value.ToString();         //整个匹配的内容包含SG:Loop

                #region  取得相关属性
                string NewsCount = null;     //调用数量
                string TitleNum = null;      //新闻标题的显示字符数量
                string ding = null;
                string tuijian= null;        
                string NewsType = null;      //调用新闻的类型
                string Templet = null;       // 模板ID

                string SQL = null;       

                NewsCount = TagVal(Attributes, "NewsCount");
                if (NewsCount == null)
                {
                    NewsCount = "15";
                }
                TitleNum = TagVal(Attributes, "TitleNum");
                if (TitleNum == null)
                {
                    TitleNum = "100";
                }
                ding = TagVal(Attributes, "ding");
                if (ding == null)
                {
                    ding = "false";
                }
                tuijian = TagVal(Attributes, "tuijian");
                if (tuijian == null)
                {
                    tuijian = "false";
                }
                NewsType = TagVal(Attributes, "NewsType");
                if (NewsType == null)
                {
                    NewsType = "0";
                }

                Templet = TagVal(Attributes, "Templet");

                SQL = TagVal(Attributes, "SQL");
             
                #endregion

                #region 构造 查询SQL语句
                //SQL语句拼接
                string strWher = "";
                StringBuilder strSql = new StringBuilder();
                if (SQL == null)
                {
                    strWher = "classname='" + NewsType + "'"; 
                    strSql.Append("select top ");
                    strSql.Append(NewsCount);
                    strSql.Append(" * from ["+config.date_prefix+"news] where ");
                    strSql.Append(strWher);
                    strSql.Append(" AND switchs='0'");
                    if (ding == "true")
                    {
                        strSql.Append(" AND ding='0'");
                    }
                    if (tuijian == "true")
                    {
                        strSql.Append(" AND tuijian='0'");
                    }
                    strSql.Append(" order by switchs,bh DESC");
                }
                else { strSql.Append(SQL); }

                #endregion

                #region 对循环的内容进行替换
                string content = "";
                DataSet dt = Bll.GetDataSet(strSql.ToString());
                if (dt.Tables[0].Rows.Count > 0)
                {
                    int rowsCount = dt.Tables[0].Rows.Count;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        string str = Text;
                        str = Replace(str, @"\[SG:Title\]",        ROYcms.Common.input.GetSubString(dt.Tables[0].Rows[n]["title"].ToString(),Convert.ToInt32(TitleNum)));
                        str = Replace(str, @"\[SG:Id\]",           dt.Tables[0].Rows[n]["bh"].ToString());
                        str = Replace(str, @"\[SG:Url\]",          dt.Tables[0].Rows[n]["url"].ToString());
                        str = Replace(str, @"\[SG:Link\]", dt.Tables[0].Rows[n]["jumpurl"].ToString() == "" ? (config.web_host + TemplateZone.Zpath(this.pageHost) + "show" + Templet + "-" + dt.Tables[0].Rows[n]["bh"].ToString() + "-" + Convert.ToDateTime(dt.Tables[0].Rows[n]["time"]).ToString("yyyyMM") + config.web_forge) : dt.Tables[0].Rows[n]["jumpurl"].ToString());
                        str = Replace(str, @"\[SG:_Link\]", dt.Tables[0].Rows[n]["jumpurl"].ToString() == "" ? ("show-" + dt.Tables[0].Rows[n]["bh"].ToString() + "-" + Convert.ToDateTime(dt.Tables[0].Rows[n]["time"]).ToString("yyyyMM") + config.web_forge) : dt.Tables[0].Rows[n]["jumpurl"].ToString());
                        str = Replace(str, @"\[SG:Pic\]",          dt.Tables[0].Rows[n]["pic"].ToString());
                        str = Replace(str, @"\[SG:Zhaiyao\]",      dt.Tables[0].Rows[n]["zhaiyao"].ToString());
                        str = Replace(str, @"\[SG:Keyword\]",      dt.Tables[0].Rows[n]["keyword"].ToString());
                        str = Replace(str, @"\[SG:classname\]",    dt.Tables[0].Rows[n]["classname"].ToString());
                        
                        str = Replace(str, @"\[SG:Content\]",      dt.Tables[0].Rows[n]["contents"].ToString());
                        str = Replace(str, @"\[SG:Infor\]",        dt.Tables[0].Rows[n]["infor"].ToString());
                        str = Replace(str, @"\[SG:Author\]",       dt.Tables[0].Rows[n]["author"].ToString());
                        str = Replace(str, @"\[SG:Tag\]",          dt.Tables[0].Rows[n]["tag"].ToString());
                        str = Replace(str, @"\[SG:Dig\]",          dt.Tables[0].Rows[n]["dig"].ToString());
                        str = Replace(str, @"\[SG:Hits\]",         dt.Tables[0].Rows[n]["hits"].ToString());
                        str = Replace(str, @"\[SG:Time\]",         dt.Tables[0].Rows[n]["time"].ToString());   
                        str = Replace(str, @"\[SG:Year\]",         Convert.ToDateTime(dt.Tables[0].Rows[n]["time"]).Date.Year.ToString());
                        str = Replace(str, @"\[SG:Month\]",        Convert.ToDateTime(dt.Tables[0].Rows[n]["time"]).Date.Month.ToString());
                        str = Replace(str, @"\[SG:Day\]",          Convert.ToDateTime(dt.Tables[0].Rows[n]["time"]).Date.Day.ToString());   
                     
                        content += str;
                    }
                }
                else
                {
                    content = "";
                }
                #endregion
                template = template.Replace(AllText, content);
                
            }
            return template;
        }

        ///// <summary>
        ///// loopPage分页标签的匹配替换
        ///// </summary>
        ///// <param name="template">模板内容</param>
        public string loopPage(string template)
        {
            string Attributes = "";
            string Text = "";
            string AllText = "";
            Regex r = new Regex(@"(\[SG:loopPage\s+(?<attributes>[^\]]*?)\](?<text>[\s\S]*?)\[/SG:loopPage\])", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            foreach (Match m in r.Matches(template))
            {
                Attributes = m.Groups["attributes"].ToString(); //循环属性集
                Text = m.Groups["text"].ToString();             //循环的内容不包含SG:Loop
                AllText = m.Groups[0].Value.ToString();         //整个匹配的内容包含SG:Loop

                #region  取得相关属性
                string NewsCount = null;     //调用数量
                string TitleNum = null;      //新闻标题的显示字符数量
                string ding = null;
                string tuijian = null;     
                string NewsType = null;      //调用新闻的类型
                string Templet = null;       // 模板ID
                string Pagesize = null;       // 

                string SQL = null;       

                NewsCount = TagVal(Attributes, "NewsCount");
                if (NewsCount == null)
                {
                    NewsCount = "1000";
                }
                TitleNum = TagVal(Attributes, "TitleNum");
                if (TitleNum == null)
                {
                    TitleNum = "100";
                }
                ding = TagVal(Attributes, "ding");
                if (ding == null)
                {
                    ding = "false";
                }
                tuijian = TagVal(Attributes, "tuijian");
                if (tuijian == null)
                {
                    tuijian = "false";
                }

                NewsType = TagVal(Attributes, "NewsType");
                if (NewsType == null)
                {
                    NewsType = "0";
                }
                if (this.classs != null)
                {
                    NewsType = this.classs;
                }

                Templet = TagVal(Attributes, "Templet");

                Pagesize = TagVal(Attributes, "Pagesize");
                if (Pagesize == null)
                {
                    Pagesize = "30";
                }

                SQL = TagVal(Attributes, "SQL");
                #endregion

                #region 构造 查询SQL语句
                //SQL语句拼接
                string strWher = "";
                StringBuilder strSql = new StringBuilder();
                if (SQL == null)
                {
  
                    strWher = "classname='" + NewsType + "'";

                    strSql.Append("select top ");
                    strSql.Append(NewsCount);
                    strSql.Append(" * from ["+config.date_prefix+"news] where ");
                    strSql.Append(strWher);
                    strSql.Append(" AND switchs='0'");
                    if (ding == "true")
                    {
                        strSql.Append(" AND ding='0'");
                    }
                    if (tuijian == "true")
                    {
                        strSql.Append(" AND tuijian='0'");
                    }
                    strSql.Append(" order by switchs,bh DESC");
                }
                else { strSql.Append(SQL); }


                #endregion
                #region 对循环的内容进行替换
                string content = "";
                DataSet Pa = Bll.GetDataSet(strSql.ToString());
                int PageContent = Pa.Tables[0].Rows.Count;//数据总数 分页用
                int PS =  Convert.ToInt32(Pagesize);
                int p = Convert.ToInt32(pageNum == null ? "1" : pageNum)-1;
                DataTable dt = new DataTable();
                dt = Pa.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    int rowsCount = p * PS + PS;
                    if ((p * PS + PS) - dt.Rows.Count > 0) { rowsCount = dt.Rows.Count; }
                    
                    for (int n = p * PS; n < rowsCount; n++)
                    {
                        string str = Text;
                        str = Replace(str, @"\[SG:Title\]", ROYcms.Common.input.GetSubString(dt.Rows[n]["title"].ToString(), Convert.ToInt32(TitleNum)));
                        str = Replace(str, @"\[SG:Id\]", dt.Rows[n]["bh"].ToString());
                        str = Replace(str, @"\[SG:Url\]", dt.Rows[n]["url"].ToString());

                        str = Replace(str, @"\[SG:Link\]", dt.Rows[n]["jumpurl"].ToString() == "" ? (config.web_host + TemplateZone.Zpath(this.pageHost) + "show" + Templet + "-" + dt.Rows[n]["bh"].ToString() + "-" + Convert.ToDateTime(dt.Rows[n]["time"]).ToString("yyyyMM") + config.web_forge) : dt.Rows[n]["jumpurl"].ToString());
                        str = Replace(str, @"\[SG:_Link\]", dt.Rows[n]["jumpurl"].ToString() == "" ? ("show-" + dt.Rows[n]["bh"].ToString() + "-" + Convert.ToDateTime(dt.Rows[n]["time"]).ToString("yyyyMM") + config.web_forge) : dt.Rows[n]["jumpurl"].ToString());
                        str = Replace(str, @"\[SG:Pic\]", dt.Rows[n]["pic"].ToString());
                        str = Replace(str, @"\[SG:Zhaiyao\]", dt.Rows[n]["zhaiyao"].ToString());
                        str = Replace(str, @"\[SG:Keyword\]", dt.Rows[n]["keyword"].ToString());
                        str = Replace(str, @"\[SG:classname\]", dt.Rows[n]["classname"].ToString());

                        str = Replace(str, @"\[SG:Content\]", dt.Rows[n]["contents"].ToString());
                        str = Replace(str, @"\[SG:Infor\]", dt.Rows[n]["infor"].ToString());
                        str = Replace(str, @"\[SG:Author\]", dt.Rows[n]["author"].ToString());
                        str = Replace(str, @"\[SG:Tag\]", dt.Rows[n]["tag"].ToString());
                        str = Replace(str, @"\[SG:Dig\]", dt.Rows[n]["dig"].ToString());
                        str = Replace(str, @"\[SG:Hits\]", dt.Rows[n]["hits"].ToString());
                        str = Replace(str, @"\[SG:Time\]", dt.Rows[n]["time"].ToString());
                        str = Replace(str, @"\[SG:Year\]", Convert.ToDateTime(dt.Rows[n]["time"]).Date.Year.ToString());
                        str = Replace(str, @"\[SG:Month\]", Convert.ToDateTime(dt.Rows[n]["time"]).Date.Month.ToString());
                        str = Replace(str, @"\[SG:Day\]", Convert.ToDateTime(dt.Rows[n]["time"]).Date.Day.ToString());   

                        content += str;

                    }
                    
                }
                else
                {
                    content = "";
                }
                #endregion
       
                template = template.Replace(AllText, content);
                template = template.Replace(@"[SG:Page]", PageContent.ToString());
                if (this.classs != null)
                {
                    ROYcms.Sys.BLL.ROYcms_class ROYcms_classBLL = new ROYcms.Sys.BLL.ROYcms_class();

                    template = template.Replace(@"[SG:ClassTitle]", ROYcms_classBLL.GetClassTitle(Convert.ToInt32(this.classs)));
                }
                
            }
            return template;
        }

        /// <summary>
        /// 公共标签替换
        /// </summary>
        /// <param name="template">模板内容</param>
        /// <returns></returns>
        /// <summary>
        private string PublicTag(string template)
        {
            //引入外部文件标签
            Regex r = new Regex(@"(\[SG:File\s+Path=" + "\"" + @"(?<Path>[^" + "\"" + "]*)" + "\"" + @"\])", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (Match m in r.Matches(template))
            {
                string Path = m.Groups["Path"].ToString();
                template = template.Replace(m.Groups[0].Value.ToString(), SystemCms.Read_File(Context.Server.MapPath(config.templet_root+ TemplateZone.TemplateZpath(this.pageHost)+"/"+Path),config.templet_language));
            }
            //WEB.config 文件信息替换
            template = Replace(template, @"\[SG:WebPath\]", config.web_host);
            template = Replace(template, @"\[SG:WebName\]", config.web_name);

            template = Replace(template, @"\[SG:TemplatePath\]",config.templet_root + "/" + TemplateZone.TemplateZpath(this.pageHost));
            //用户自定义标签替换
            #region 对循环的内容进行替换
            ROYcms.Sys.BLL.ROYcms_CustomTag bll = new ROYcms.Sys.BLL.ROYcms_CustomTag(); 
            DataSet dt = bll.GetAllList();
            if (dt.Tables[0].Rows.Count > 0)
            {
                int rowsCount = dt.Tables[0].Rows.Count;
                for (int n = 0; n < rowsCount; n++)
                {
                    string str = template;
                    str =str.Replace(@"[SG:" + dt.Tables[0].Rows[n]["TAG"].ToString().Trim() + "]", dt.Tables[0].Rows[n]["TAG_content"].ToString().Trim());
                    template = str;
                }
            }  
            #endregion
            return template;
        }
        /// <summary>
        /// show页面标签 替换
        /// </summary>
        /// <param name="template">模板内容</param>
        /// <returns></returns>
        public string ShowTag(string template)
        {
            if (this.bh != null)
            {
                ROYcms.Sys.BLL.ROYcms_news bll = new ROYcms.Sys.BLL.ROYcms_news();
                
                DataSet dt = bll.GetList("bh = '" + this.bh + "'");
                DataSet pg_Dn = bll.GetList("bh > '" + this.bh + "'");
                DataSet pg_Up = bll.GetList("bh < '" + this.bh + "' order by bh DESC");
                    
                if (pg_Dn.Tables[0].Rows.Count > 0)
                {
                    template = Replace(template, @"\[SG:pg_Dn\]", pg_Dn.Tables[0].Rows[0]["title"].ToString());
                    template = Replace(template, @"\[SG:pg_Dn_Link\]", pg_Dn.Tables[0].Rows[0]["jumpurl"].ToString() == "" ? (config.web_host + TemplateZone.Zpath(this.pageHost) + "show" + this.templet + "-" + pg_Dn.Tables[0].Rows[0]["bh"].ToString() + "-" + Convert.ToDateTime(pg_Dn.Tables[0].Rows[0]["time"]).ToString("yyyyMM") + config.web_forge) : pg_Dn.Tables[0].Rows[0]["jumpurl"].ToString());
                }
                else {
                    template = Replace(template, @"\[SG:pg_Dn\]", "无数据");
                    template = Replace(template, @"\[SG:pg_Dn_Link\]", "#");
                }
                if (pg_Up.Tables[0].Rows.Count > 0)
                {
                    template = Replace(template, @"\[SG:pg_Up\]", pg_Up.Tables[0].Rows[0]["title"].ToString());
                    template = Replace(template, @"\[SG:pg_Up_Link\]", pg_Up.Tables[0].Rows[0]["jumpurl"].ToString() == "" ? (config.web_host + TemplateZone.Zpath(this.pageHost) + "show" + this.templet + "-" + pg_Up.Tables[0].Rows[0]["bh"].ToString() + "-" + Convert.ToDateTime(pg_Up.Tables[0].Rows[0]["time"]).ToString("yyyyMM") + config.web_forge) : pg_Up.Tables[0].Rows[0]["jumpurl"].ToString());
                }
                else {
                    template = Replace(template, @"\[SG:pg_Up\]", "无数据");
                    template = Replace(template, @"\[SG:pg_Up_Link\]", "#");
                }
                template = Replace(template, @"\[SG:UrlPath\]", config.web_host);
                Regex r = new Regex(@"(\[SG:Field\s+name=" + "\"" + @"(?<name>[^" + "\"" + "]*)" + "\"" + @"\])", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                if (dt.Tables[0].Rows.Count > 0)
                {
                    foreach (Match m in r.Matches(template))
                    {
                        string name = m.Groups["name"].ToString().ToLowerInvariant();
                        if (name == "year") { template = template.Replace(m.Groups[0].Value.ToString(), Convert.ToDateTime(dt.Tables[0].Rows[0]["time"]).Date.Year.ToString()); }
                        else if (name == "month") { template = template.Replace(m.Groups[0].Value.ToString(), Convert.ToDateTime(dt.Tables[0].Rows[0]["time"]).Date.Month.ToString()); }
                        else if (name == "day") { template = template.Replace(m.Groups[0].Value.ToString(), Convert.ToDateTime(dt.Tables[0].Rows[0]["time"]).Date.Day.ToString()); }
                        else
                        {
                            try
                            {
                                template = template.Replace(m.Groups[0].Value.ToString(), dt.Tables[0].Rows[0][name].ToString());
                            }
                            catch { return "标签定义出错"; }

                        }
                    }
                }
            }
            else { return template; }
           
            return template;
        }
 

    }
}