using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ROYcms.Controls
{
    [DefaultProperty("")]
    [ToolboxData("<{0}:Paging runat=server />")]
    public class Paging : Literal
    {
        private string _Pattern = null;
        private string _Rid = null;
        private string _Class = null;
        /// <summary>
        /// 参数值 只读 Request[ParameterName]
        /// </summary>
        /// <value>The id.</value>
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Rid
        {
            get
            {
                if (_Rid != null)
                {
                    if (Page.Request["id"] != null)
                    {
                        _Rid = _Rid.ToLowerInvariant().Replace("{id}", Page.Request["id"]);
                    }
                }
                else { if (Page.Request["id"] != null) { _Rid = Page.Request["id"]; } }
                return _Rid;
            }
            set { _Rid = value; }
        }
        public string Class
        {
            get
            {
                if (_Class != null)
                {
                    if (Page.Request["class"] != null)
                    {
                        _Class = _Class.ToLowerInvariant().Replace("{class}", Page.Request["class"]);
                    }
                }
                else { if (Page.Request["class"] != null) { _Class = Page.Request["class"]; } }
                return _Class;
            }
            set { _Class = value; }
        }
        public string Pattern
        {
            get { return _Pattern; }
            set { _Pattern = value; }
        }
        public ROYcms.Sys.BLL.ROYcms_news ROYcms_news_Bll = new ROYcms.Sys.BLL.ROYcms_news();
        
        public ROYcms.Sys.BLL.ROYcms_class ROYcms_class_Bll = new ROYcms.Sys.BLL.ROYcms_class();

        //  获取类的名称
        public string GetClassTitle(int id)
        {
            return ROYcms_class_Bll.GetClassTitle(id);
        }
        //获取上一条信息集合
        public ROYcms.Sys.Model.ROYcms_news u_id(int id,string classname)
        {
            return ROYcms_news_Bll.TopNews(" bh>" + id + "  and  classname='" + classname + "' order by bh ");
        }
        //获取下一条信息集合
        public ROYcms.Sys.Model.ROYcms_news d_id(int id, string classname)
        {
            return ROYcms_news_Bll.TopNews(" bh<" + id + "  and  classname='" + classname + "' order by bh desc ");
        }

        /// <summary>
        /// 输出
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void Render(HtmlTextWriter output)
        {
            ROYcms.Sys.Model.ROYcms_news ROYcms_news_Model = new ROYcms.Sys.Model.ROYcms_news();
            string Url = null;
            if (this.Pattern == "u")
            {
                ROYcms_news_Model = u_id(Convert.ToInt32(this.Rid), this.Class);
            }
            else if (this.Pattern == "d")
            {
                ROYcms_news_Model = d_id(Convert.ToInt32(this.Rid), this.Class);
            }
            if (ROYcms_news_Model != null)
            {
                 Url = "<a href='show_" + ROYcms_news_Model.bh.ToString() + ".html' >" + ROYcms_news_Model.title.ToString() + "</a>";
            }
            else { Url = "<!--无数据！-->"; }
            try
            {
                output.Write(Url);
            }   
            catch { output.Write("<!--输出错误！-->"); }

        }
    }
}
