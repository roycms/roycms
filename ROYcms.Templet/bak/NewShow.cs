using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Web;
using ROYcms.Common;

namespace ROYcms.Templet
{
    /// <summary>
    /// 新闻子页面生成类
    /// </summary>
    public class NewShow:Template
    {
        private int? _bh = null;
        private int? _top=null;
        private int? _star_id=null;
        private int? _end_id=null;
        public int? bh
        {
            get { return _bh; }
            set { _bh = value; }
        }
        public int? top
        {
            get { return _top; }
            set { _top = value; }
        }
        public int? star_id
        {
            get { return _star_id; }
            set { _star_id = value; }
        }
        public int? end_id
        {
            get { return _end_id; }
            set { _end_id = value; }
        }
        public bool err = false;
        Template Template = new Template();
        ROYcms.Sys.BLL.ROYcms_news BLL = new ROYcms.Sys.BLL.ROYcms_news();
        /// <summary>
        /// 新闻子页面生成方法  News the HTML.
        /// </summary>
        /// <param name="Model">The model.</param>
        /// <returns></returns>
        public bool NewHtml(ROYcms.Sys.Model.ROYcms_class Model)
        {
           // StreamWriter sw = null;//定义参数          

            Model.FilePath = Model.FilePath.Replace("{cmspath}", "~");
            string Path = "";
            string templatepath = Model.TemplateShow;//模版地址
            string SQL = null;
            if (this.bh != null)
            {
                SQL = "SELECT * FROM  [ROYcms_news] "
                                + " where bh=" + this.bh + "";
            }
            else
            {
                SQL = "SELECT "
                         + (this.top == null ? "" : "TOP " + this.top) +
                         " * FROM  [ROYcms_news] "
                         + (this.star_id == null ? "" : " where bh>" + this.star_id) +
                         (this.end_id == null ? "" : (this._star_id == null ? " where" : " and ") + "  bh<" + this.end_id) +
                         " ORDER BY bh desc";
            }

            //写文件   
            try
            {
                DataSet ds = BLL.GetDataSet(SQL);
                DataTable dt = ds.Tables[0];
                //读取模版
                string Text = PublicTag(SystemCms.Read_File(HttpContext.Current.Server.MapPath(templatepath), ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language")));
                //列表标签过滤
                Template.ROYcms_class_Model = Model;//全局赋值
                Text = Template.LoopTag(Text);

                foreach (DataRow dr in dt.Rows)
                {

                    Path = (Model.ShowRules.Contains("~/") ? Model.ShowRules : (Model.FilePath + Model.ShowRules));//文件生成地址
                    Path = Path.Replace("{yyyy}", Convert.ToDateTime(dr["time"]).ToString("yyyy"));
                    Path = Path.Replace("{MM}", Convert.ToDateTime(dr["time"]).ToString("MM"));
                    Path = Path.Replace("{dd}", Convert.ToDateTime(dr["time"]).ToString("dd"));
                    Path = Path.Replace("{id}", dr["bh"].ToString());

                    string tempath = Path.Substring(0, Path.LastIndexOf("/") + 1);

                    if (!Directory.Exists(HttpContext.Current.Server.MapPath(tempath)))
                    {
                        Directory.CreateDirectory(HttpContext.Current.Server.MapPath(tempath));
                    }
                    using (StreamWriter sw = new StreamWriter(HttpContext.Current.Server.MapPath(Path), false, Encoding.GetEncoding(ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"))))
                    {
                        try
                        {
                            //sw = new StreamWriter(HttpContext.Current.Server.MapPath(Path), false, Encoding.GetEncoding(config.templet_language));


                            string str = Text;
                            str = Template.Replace(str, @"\[SG:Title\]", dr["title"].ToString());
                            str = Template.Replace(str, @"\[SG:Id\]", dr["bh"].ToString());
                            str = Template.Replace(str, @"\[SG:Url\]", dr["url"].ToString());

                            str = Template.Replace(str, @"\[SG:Pic\]", dr["pic"].ToString());
                            str = Template.Replace(str, @"\[SG:Zhaiyao\]", dr["zhaiyao"].ToString());
                            str = Template.Replace(str, @"\[SG:Keyword\]", dr["keyword"].ToString());
                            str = Template.Replace(str, @"\[SG:classname\]", dr["classname"].ToString());

                            str = Template.Replace(str, @"\[SG:Content\]", dr["contents"].ToString());
                            str = Template.Replace(str, @"\[SG:Infor\]", dr["infor"].ToString());
                            str = Template.Replace(str, @"\[SG:Author\]", dr["author"].ToString());
                            str = Template.Replace(str, @"\[SG:Tag\]", dr["tag"].ToString());
                            str = Template.Replace(str, @"\[SG:Dig\]", dr["dig"].ToString());
                            str = Template.Replace(str, @"\[SG:Hits\]", dr["hits"].ToString());
                            str = Template.Replace(str, @"\[SG:Time\]", dr["time"].ToString());
                            str = Template.Replace(str, @"\[SG:Year\]", Convert.ToDateTime(dr["time"]).ToString("yyyy"));
                            str = Template.Replace(str, @"\[SG:Month\]", Convert.ToDateTime(dr["time"]).ToString("MM"));
                            str = Template.Replace(str, @"\[SG:Day\]", Convert.ToDateTime(dr["time"]).ToString("dd"));

                            // str = Template.Replace(str, @"\[SG:Day\]", Xml.GetValue(Convert.ToInt32(dr["bh"]), dr["type"].ToString(), "o"));


                            sw.WriteLine(str);
                            sw.Flush();
                            err = true;
                        }

                        catch (Exception ex)
                        {
                            HttpContext.Current.Response.Write(ex.Message);
                            HttpContext.Current.Response.End();
                            err = false;
                        }
                        finally
                        {
                            sw.Close();
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write(ex.Message);
                HttpContext.Current.Response.End();
                err = false;
            }
          
            return err;
        }
        /// <summary>
        /// Dels the HTML.
        /// </summary>
        /// <param name="Model">The model.</param>
        /// <returns></returns>
        public void DelHtml(int id)
        {
            try
            {
                ROYcms.Sys.BLL.ROYcms_news BLL = new ROYcms.Sys.BLL.ROYcms_news();
                ROYcms.Sys.BLL.ROYcms_class ClassBLL = new ROYcms.Sys.BLL.ROYcms_class();
                ROYcms.Sys.Model.ROYcms_class Model = ClassBLL.GetModel(ClassBLL.GetClassId(Convert.ToInt32(BLL.GetClassName(id))));
                ROYcms.Sys.Model.ROYcms_news NewModel = BLL.GetModel(id);
                string Path = null;
                Model.FilePath = Model.FilePath.Replace("{cmspath}", "~");
                Path = (Model.ShowRules.Contains("~/") ? Model.ShowRules : (Model.FilePath + Model.ShowRules));  //文件生成地址
                Path = Path.Replace("{yyyy}", Convert.ToDateTime(NewModel.time).ToString("yyyy"));
                Path = Path.Replace("{MM}", Convert.ToDateTime(NewModel.time).ToString("MM"));
                Path = Path.Replace("{dd}", Convert.ToDateTime(NewModel.time).ToString("dd"));
                Path = Path.Replace("{id}", id.ToString());

                using (StreamWriter sw = new StreamWriter(HttpContext.Current.Server.MapPath(Path), false, Encoding.GetEncoding(ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"))))
                {
                    // File.Delete(HttpContext.Current.Server.MapPath(Path));

                    sw.WriteLine("文件已经删除！<a href='/inde.aspx'>到首页</a>");
                    sw.Flush();
                }
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write(ex.Message);
            }
        }
    }
}
