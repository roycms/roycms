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
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using ROYcms.Common;
using ROYcms.Sys.Model;
namespace ROYcms.Templet
{

    /// <summary>
    /// 模板标签处理类
    /// </summary>
    public class Template
    {
        /// <summary>
        /// _Config构造函数
        /// </summary>
        /// <value>The page num.</value>
        /// 
        ROYcms.Sys.BLL.ROYcms_news Bll = new ROYcms.Sys.BLL.ROYcms_news();
        ROYcms.Sys.BLL.ROYcms_template _BLL = new ROYcms.Sys.BLL.ROYcms_template();
        public  ROYcms.Sys.Model.ROYcms_class ROYcms_class_Model = new ROYcms.Sys.Model.ROYcms_class();
        public ROYcms.Sys.BLL.ROYcms_class ROYcms_class_Bll = new ROYcms.Sys.BLL.ROYcms_class();
        /// <summary>
        /// 替换字符
        /// </summary>
        /// <param name="template">要替换的文本</param>
        /// <param name="tag">标签</param>
        /// <param name="value">内容</param>
        /// <returns></returns>
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

        /// <summary>
        /// loop标签的匹配替换
        /// </summary>
        /// <param name="template">模板内容</param>
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
                string classKind = null;
                string Templet = null;       // 模板ID

                Templet = TagVal(Attributes, "Templet");
                Count = TagVal(Attributes, "Count");
                classKind = TagVal(Attributes, "classKind");
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
                        str = Replace(str, @"\[SG:classid\]", dt.Tables[0].Rows[n]["ClassName"].ToString());
                        str = Replace(str, @"\[SG:id\]", dt.Tables[0].Rows[n]["id"].ToString());

                        str = Replace(str, @"\[SG:ClassName\]", dt.Tables[0].Rows[n]["ClassName"].ToString());
                        str = Replace(str, @"\[SG:Link\]", ROYcms_class_Model.DefaultFile);

                        str = Replace(str, @"\[SG:keyword\]", dt.Tables[0].Rows[n]["keyword"].ToString());
                        str = Replace(str, @"\[SG:description\]", dt.Tables[0].Rows[n]["description"].ToString());
                        str = Replace(str, @"\[SG:contents\]", dt.Tables[0].Rows[n]["contents"].ToString());
                        //str = Replace(str, @"\[SG:_Link\]", "list-" + dt.Tables[0].Rows[n]["Id"].ToString() + config.web_forge);
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

        /// <summary>
        /// loop标签的匹配替换
        /// </summary>
        /// <param name="template">模板内容</param>
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
                //string Templet = null;       // 模板ID

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
                    strSql.Append(" * from [ROYcms_news] where ");
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
                ROYcms_class_Model = ROYcms_class_Bll.GetModel(ROYcms_class_Bll.GetClassId(Convert.ToInt32(NewsType)));
                string content = "";
                DataSet dt = Bll.GetDataSet(strSql.ToString());
                if (dt.Tables[0].Rows.Count > 0)
                {
                    int rowsCount = dt.Tables[0].Rows.Count;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        string str = Text;
                        string T_ShowPath = (ROYcms_class_Model.ShowRules == null ? "" : ROYcms_class_Model.ShowRules);
                        str = Replace(str, @"\[SG:Title\]", ROYcms.Common.input.GetSubString(dt.Tables[0].Rows[n]["title"].ToString(), Convert.ToInt32(TitleNum)));
                        str = Replace(str, @"\[SG:_Title\]", dt.Tables[0].Rows[n]["title"].ToString());
                        str = Replace(str, @"\[SG:Id\]", dt.Tables[0].Rows[n]["bh"].ToString());
                        str = Replace(str, @"\[SG:Url\]", dt.Tables[0].Rows[n]["url"].ToString());


                        T_ShowPath = T_ShowPath.Replace("{yyyy}", Convert.ToDateTime(dt.Tables[0].Rows[n]["time"]).ToString("yyyy"));
                        T_ShowPath = T_ShowPath.Replace("{MM}", Convert.ToDateTime(dt.Tables[0].Rows[n]["time"]).ToString("MM"));
                        T_ShowPath = T_ShowPath.Replace("{dd}", Convert.ToDateTime(dt.Tables[0].Rows[n]["time"]).ToString("dd"));
                        T_ShowPath = T_ShowPath.Replace("{id}", dt.Tables[0].Rows[n]["bh"].ToString());
                        str = Replace(str, @"\[SG:Link\]", T_ShowPath);

                        str = Replace(str, @"\[SG:Pic\]", dt.Tables[0].Rows[n]["pic"].ToString());
                        str = Replace(str, @"\[SG:Zhaiyao\]", dt.Tables[0].Rows[n]["zhaiyao"].ToString());
                        str = Replace(str, @"\[SG:Keyword\]", dt.Tables[0].Rows[n]["keyword"].ToString());
                        str = Replace(str, @"\[SG:classname\]", new ROYcms.Sys.BLL.ROYcms_class().GetClassTitle(Convert.ToInt32(dt.Tables[0].Rows[n]["classname"].ToString())));
                     
                        str = Replace(str, @"\[SG:Content\]", dt.Tables[0].Rows[n]["contents"].ToString());
                        str = Replace(str, @"\[SG:Infor\]", dt.Tables[0].Rows[n]["infor"].ToString());
                        str = Replace(str, @"\[SG:Author\]", dt.Tables[0].Rows[n]["author"].ToString());
                        str = Replace(str, @"\[SG:Tag\]", dt.Tables[0].Rows[n]["tag"].ToString());
                        str = Replace(str, @"\[SG:Dig\]", dt.Tables[0].Rows[n]["dig"].ToString());
                        str = Replace(str, @"\[SG:Hits\]", dt.Tables[0].Rows[n]["hits"].ToString());
                        str = Replace(str, @"\[SG:Time\]", dt.Tables[0].Rows[n]["time"].ToString());
                        str = Replace(str, @"\[SG:Year\]", Convert.ToDateTime(dt.Tables[0].Rows[n]["time"]).Date.Year.ToString());
                        str = Replace(str, @"\[SG:Month\]", Convert.ToDateTime(dt.Tables[0].Rows[n]["time"]).Date.Month.ToString());
                        str = Replace(str, @"\[SG:Day\]", Convert.ToDateTime(dt.Tables[0].Rows[n]["time"]).Date.Day.ToString());   
                     
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

        /// <summary>
        /// 公共标签替换Publics the tag.
        /// </summary>
        /// <param name="template">The template.</param>
        /// <returns></returns>
        public  string PublicTag(string template)
        {
            if (template != null)
            {
                //引入外部文件标签
                Regex r = new Regex(@"(\[SG:File\s+Path=" + "\"" + @"(?<Path>[^" + "\"" + "]*)" + "\"" + @"\])", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                foreach (Match m in r.Matches(template))
                {
                    string Path = m.Groups["Path"].ToString();
                    template = template.Replace(m.Groups[0].Value.ToString(), SystemCms.Read_File(HttpContext.Current.Server.MapPath(ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_file") + "/" + Path), ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language")));
                }
                //WEB.config 文件信息替换
                template = Replace(template, @"\[SG:WebPath\]", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host"));
                template = Replace(template, @"\[SG:WebName\]", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_name"));
                template = Replace(template, @"\[SG:WebDescription\]", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("Description"));
                template = Replace(template, @"\[SG:TemplatePath\]", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_file"));
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
                        str = str.Replace(@"[SG:" + dt.Tables[0].Rows[n]["TAG"].ToString().Trim() + "]", dt.Tables[0].Rows[n]["TAG_content"].ToString().Trim());
                        template = str;
                    }
                }
                #endregion
            }
            else { template = "<!--公共标签值为空！-->"; }
            return template;
        }
    }
}