using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Collections;
using System.Data;

namespace ROYcms.Controls
{
    public class WebPageRepeater : _Repeater
    {
        /// <summary>
        /// 
        /// </summary>
        //private const string LINK = "<a href=list_{1}.html class=pageLink>{2}</a>";
        //private const string LINK_NEXT = "<a href=list_{1}.html title='下{2}页' class=pageLink>{3}</a>";
        //private const string LINK_PREV = "<a href=list_{1}.html title='上{2}页' class=pageLink>{3}</a>";

        private const string LINK = "<a href=?{0}={1} class=pageLink>{2}</a>";
        private const string LINK_NEXT = "<a href=?{0}={1} title='下{2}页' class=pageLink>{3}</a>";
        private const string LINK_PREV = "<a href=?{0}={1} title='上{2}页' class=pageLink>{3}</a>";
        //私有变量  roycms
        private string mstrEmptyText = "<!--DataSource为空！-->";//DataSource为空的时候显示的字
        private string mstrPageKey = "page";//在地址栏上显示的页码关键字，比如page=1
        private string mstrPrevPageText = "上一页";//上页文字
        private string mstrNextPageText = "下一页";//下页文字
        private PagerPosition pagePosition = PagerPosition.Bottom;//页码位置，上、下、上下都有
        private PagerMode pageMode = PagerMode.NumericPages;//页导航元素模式
        private int intPageIndexCount = 10;//显示的页码数
        private int intPageSize = 10;//一页显示的记录数
        private string intCurrentPage = "1";//当前页
        private IList dataSource;//数据源，必须可以转换为IList
        private bool blnRealSource = false; //数据源已分页

        private int intItemCount;

        //自定义绑定
        private string _Path = null;//Path
        private string _Son = null;//是否检索子类信息
        private string _Switchs = "0";//审核 
        private string _Tuijian = null;//推荐 
        private string _Ding = null;//置顶
        private string _Tag = null;//标签
        private string _Class = null;//分类ID
        private string _ClassKind = null;
        private string _StrWhere = null;//查询条件
        private string _SQL = null;//SQL语句
        private string _FiledOrder = " bh desc";//排序规则"Create Time desc"

        public string Switchs
        {
            get { return _Switchs; }
            set { _Switchs = value; }
        }
        public string Tuijian
        {
            get { return _Tuijian; }
            set { _Tuijian = value; }
        }
        public string Ding
        {
            get { return _Ding; }
            set { _Ding = value; }
        }
        public string StrWhere
        {
            get {
                if (_StrWhere != null)
                {
                    if (Page.Request["path"] != null)
                    { _StrWhere = _StrWhere.Replace("{path:id}".ToLowerInvariant(), new ROYcms.Sys.BLL.ROYcms_class().GetId("{cmspath}/" + Page.Request["path"] + "/")); }

                    Regex r = new Regex(@"\{(?<Name>\w+)\}", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    foreach (Match m in r.Matches(_StrWhere))
                    {
                        string Name = m.Groups["Name"].ToString();
                        _StrWhere = _StrWhere.Replace("{" + Name.ToLowerInvariant() + "}", Page.Request[Name.ToLowerInvariant()]);
                    }
                }
                return _StrWhere;
            }
            set {
                _StrWhere = value; 
            
            }
        }
        public string Son
        {
            get { return _Son; }
            set { _Son = value; }
        }
        public string SQL
        {
            get
            {
                if (_SQL != null)
                {
                    Regex r = new Regex(@"\{(?<Name>\w+)\}", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    foreach (Match m in r.Matches(_SQL))
                    {
                        string Name = m.Groups["Name"].ToString();
                        _SQL = _SQL.Replace("{" + Name.ToLowerInvariant() + "}", Page.Request[Name.ToLowerInvariant()]);
                    }
                }
                return _SQL;
            }
            set
            {
                _SQL = value;

            }
        }
        public string Path
        {
            get
            {
                if (_Path != null)
                {
                    if (Page.Request["path"] != null)
                    { _Path = _Path.ToLowerInvariant().Replace("{path}", Page.Request["path"]); }
                }
                return _Path;
            }
            set
            {
                _Path = value;
            }
        }
        public string Tag
        {
            get
            {
                if (Page.Request["tag"] != null)
                { _Tag = _Tag.ToLowerInvariant().Replace("{tag}", Page.Request["tag"]); }
                return _Tag;
            }
            set { _Tag = value; }
        }
        public string Class
        {
            get
            {
                if (_Class != null)
                {
                    if (Page.Request["path"] != null)
                    { _Class = _Class.ToLowerInvariant().Replace("{path:id}", new ROYcms.Sys.BLL.ROYcms_class().GetId("{cmspath}/" + Page.Request["path"] + "/")); }
                    if (Page.Request["class"] != null)
                    { _Class = _Class.ToLowerInvariant().Replace("{class}".ToLowerInvariant(), Page.Request["class"]); }

                    //Regex r = new Regex(@"\{(?<Name>\w+)\}", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    //foreach (Match m in r.Matches(Class))
                    //{
                    //    string Name = m.Groups["Name"].ToString();
                    //    _Class = _Class.Replace("{" + Name.ToLowerInvariant() + "}", Page.Request[Name.ToLowerInvariant()]);
                    //}
                }
                return _Class;
            }
            set
            {
                _Class = value;
            }
        }
        public string ClassKind
        {
            get
            {
                if (_ClassKind != null)
                {
                    if (Page.Request["classkind"] != null)
                    { _ClassKind = _ClassKind.ToLowerInvariant().Replace("{classkind}", Page.Request["classkind"]); }
                }
                return _ClassKind;
            }
            set
            {
                _ClassKind = value;
            }
        }
        /// <summary>
        /// 数据源为空时显示的文本，默认为空
        /// </summary>
        public string EmptyText
        {
            set { mstrEmptyText = value; }
        }

        public bool RealSource
        {
            get { return blnRealSource; }
            set { blnRealSource = value; }
        }

        /// <summary>
        /// 获取或设置自定义地址栏上页码标志关键字，默认为Page。
        /// 如果页面有两个MyRepeater，必须定义两个不同的PageKey。
        /// 否则不能正确定位第二个MyRepeater。
        /// </summary>
        public string PageKey
        {
            get { return mstrPageKey; }
            set { mstrPageKey = value; }
        }

        /// <summary>
        /// 获取或设置要在 MyRepeater 控件的单页上显示的项数。
        /// 默认为10项。
        /// </summary>
        public int PageSize
        {
            get { return intPageSize; }
            set { intPageSize = value; }
        }

        /// <summary>
        /// 获取或设置当前显示页的索引。默认为1。
        /// </summary>
        public string CurrentPageIndex
        {
            get {
                if (Page.Request["page"] != null)
                { intCurrentPage = Page.Request["page"]; }
                else { intCurrentPage = "1"; }
                return intCurrentPage; 
            }
            set {
                intCurrentPage = value; 
            }
        }

        /// <summary>
        /// 获取或设置 MyRepeater 控件中页导航元素的位置。
        /// 默认为 TopAndBottom。
        /// </summary>
        public PagerPosition PagePosition
        {
            get { return pagePosition; }
            set { pagePosition = value; }
        }

        /// <summary>
        /// 获取或设置一个值，该值指定页导航元素是显示链接到下一页和前一页的按钮，还是显示直接与某一页链接的数值按钮。
        /// 默认为 NumericPages。
        /// </summary>
        public PagerMode PageMode
        {
            get { return pageMode; }
            set { pageMode = value; }
        }

        /// <summary>
        /// 获取或设置为前一页按钮显示的文本。
        /// </summary>
        public string PrevPageText
        {
            get { return mstrPrevPageText; }
            set { mstrPrevPageText = value; }
        }

        /// <summary>
        /// 获取或设置为下一页按钮显示的文本。
        /// </summary>
        public string NextPageText
        {
            get { return mstrNextPageText; }
            set { mstrNextPageText = value; }
        }

        /// <summary>
        /// 获取显示 MyRepeater 控件中各项所需的总页数。
        /// </summary>
        public int PageCount
        {
            get { return (intItemCount - 1) / intPageSize + 1; }
        }

        /// <summary>
        /// 设置 MyRepeater 控件中页导航元素显示的页码数。
        /// 默认为10。
        /// </summary>
        public int PageIndexCount
        {
            set { intPageIndexCount = value; }
        }
        public string FiledOrder
        {
            get
            {
                return _FiledOrder;
            }
            set
            {
                _FiledOrder = value;
            }
        }
        /// <summary>
        /// 设置 MyRepeater 控件的数据源。
        /// 可以接受 DataSet、DataTable和所以实现了IList借口的数据源。
        /// </summary>
        public override object DataSource
        {
            set
            {
                try
                {
                    if(value == null)
                    {
                        dataSource = null;
                        intItemCount = 0;
                    }
                    else if(value.GetType() == typeof(DataTable))//数据源是DataTable，转化为IList
                    {
                        dataSource = (IList)(new DataView((DataTable)value));
                        intItemCount = dataSource.Count;
                    }
                    else if(value.GetType() == typeof(DataSet))//数据源是DataSet，转化为IList
                    {
                        dataSource = (IList)(new DataView(((DataSet)value).Tables[0]));
                        intItemCount = dataSource.Count;
                    }
                    else
                    {
                        dataSource = (IList)value;
                        intItemCount = dataSource.Count;
                    }
                }
                catch
                {
                    dataSource = null;
                    intItemCount =0;
                }
            }

        }
        //
        protected override void OnLoad(EventArgs e)
        {
            if(Visible) 
            {
                string page = Context.Request[mstrPageKey];//取得页码
                int index = (page != null) ? int.Parse(page) : 1;
                index = index <= 0 ? 1 : index;
                SetPage(index);
                this.DataBind();
            }
        }

        public void SetPage(int index) 
        {
            OnPageIndexChanged(new DataGridPageChangedEventArgs(null, index));
        }


        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            if(intItemCount == 0)//数据源为空
            {
                writer.Write(mstrEmptyText);
                return;
            }

            if (pagePosition != PagerPosition.Bottom)//页导航元素的位置为Top或者TopAndBottom
            {
                WritePages(writer);
            }

            base.Render(writer);

            if (pagePosition != PagerPosition.Top)//页导航元素的位置为Bottom或者TopAndBottom
            {
                WritePages(writer);
            }
        }

        protected override void OnDataBinding(EventArgs e)
        {
            string Strs = null;
           // int Count;
            DataSet DS = null;

            //Tag标签
            if (this.Tag != null)
            {
                Strs += "tag like '%" + this.Tag + "%' and ";
            }
            //审核状态
            if (this.Switchs != null)
            {
                Strs += "Switchs = " + this.Switchs + " and ";
            }
            //置顶状态
            if (this.Ding != null)
            {
                Strs += "Ding = " + this.Ding + " and ";
            }
            //推荐状态
            if (this.Tuijian != null)
            {
                Strs += "Tuijian = " + this.Tuijian + " and ";
            }
            //Class分类ID标识
            if (this.Class != null)
            {
                //是否包含子类内容
                if (this.Son != null)
                {
                    Strs += " classname in (" + ClassWheres() + ") and ";
                }
                else
                {
                    Strs += "classname='" + this.Class + "' and ";
                }
            }

            //ClassKind标识
            if (this.ClassKind != null)
            {
                Strs += "type='" + this.ClassKind + "' and ";
            }
            if (Strs.EndsWith("and "))
            {
                Strs = Strs.Remove(Strs.LastIndexOf("and"), 4);
            }
            //自定义SQL查询条件
            if (this.StrWhere != null) { Strs = this.StrWhere; }
            //自定义SQL语句
            if (this.SQL != null) { Strs = this.SQL; }

            DS = new ROYcms.Sys.BLL.ROYcms_news().GetList(this.PageSize, Convert.ToInt32(this.CurrentPageIndex), Strs,0);


         
            DataView dv = new DataView();
            dv.Table = DS.Tables[0];
            dv.Sort =this.FiledOrder;
            dataSource = (IList)dv;

           // dataSource = (IList)(new DataView(((DataSet)(DS)).Tables[0]));
            //intItemCount = ((IList)(new DataView(((DataSet)(DS1)).Tables[0]))).Count;
            intItemCount = new ROYcms.Sys.BLL.ROYcms_news().GetCount(Strs);
            if (CurrentPageIndex != "1") { this.RealSource = true; }
            if (this.RealSource) //数据源已分页
            {
                base.DataSource = dataSource;
            }
            else//数据源未分页
            {
                int start = (Convert.ToInt32(intCurrentPage) - 1) * intPageSize;
                int size = Math.Min(intPageSize, intItemCount - start);

                IList list = new ArrayList();

                for (int i = 0; i < size; i++)
                {
                    list.Add(dataSource[start + i]);
                }
                base.DataSource = list;
            }
            base.OnDataBinding(e);
        }

        public event DataGridPageChangedEventHandler PageIndexChanged;

        virtual protected void OnPageIndexChanged(DataGridPageChangedEventArgs e) 
        {
            if (PageIndexChanged != null)
            {
                PageIndexChanged(this, e);
            }
        }

        /// <summary>
        /// 写页导航元素。
        /// </summary>
        /// <param name="writer">System.Web.UI.HtmlTextWriter</param>
        virtual protected void WritePages(System.Web.UI.HtmlTextWriter writer)
        {
            
            if(pageMode == PagerMode.NextPrev)//页导航元素为上下页
            {
                intPageIndexCount = 1;
            }

            intPageIndexCount = intPageIndexCount <= 0 ? 1 : intPageIndexCount;
            //开始的页码
            int start = (Convert.ToInt32(intCurrentPage) - 1) / intPageIndexCount;
            start = start * intPageIndexCount + 1;
            //结束的页码
            int end = start + intPageIndexCount - 1;
            end = end > PageCount ? PageCount : end;

            //保留PageKey以外的QueryString
            string query = Context.Request.Url.Query.Replace("?","&");
            Regex rx = new Regex("&" + mstrPageKey + "=\\d+", RegexOptions.None);
            query = rx.Replace(query, string.Empty);


            writer.Write("\n<!--分页开始-->");
            writer.Write("\n<link href='/App_Templet/SystemCss/ListPage.css' rel='stylesheet' type='text/css' />");
            writer.Write("\n<div class='CMS_pageload'>\n");
            //写向前的导航元素
            if (start > 1)
            {
                writer.Write(LINK_PREV, mstrPageKey, (start - 1), intPageIndexCount, mstrPrevPageText);
            }
            else { writer.Write("<a class=pageLink>{0}</a>", mstrPrevPageText); }

            if(pageMode != PagerMode.NextPrev)//页导航元素为上下页
            {
                //写从start到end的页码
                for(int i = start; i <= end; i++)
                {
                    
                    if(i == Convert.ToInt32(intCurrentPage))//当前页没有联接
                    {
                        writer.Write("<u><b>"+i+"</b></u>");
                    }
                    else//不是当前页有链接
                    {    
                        writer.Write(LINK, mstrPageKey, i, i);
                    }
                }
            }

            //写向后的导航元素
            if(end < PageCount)
            {
                writer.Write(LINK_NEXT, mstrPageKey, (end + 1), intPageIndexCount, mstrNextPageText);
            }
            else { writer.Write("<a class=pageLink>{0}</a>", mstrNextPageText); }

            writer.Write("\n</div>\n");
            writer.Write("\n<!--分页结束-->");
        }

        public string Wheres()
        {
            string Strs = null;
            string[] Str = null;
            if (this.Class.Contains("|")) { Str = this.Class.Split('|'); }
            for (int i = 0; i < Str.Length; i++)
            {
                Strs += " (classname='" + Str[i] + "') OR";
            }
            return "(" + Strs.Substring(0, Strs.Length - 2) + ")";
        }
      
        public string ClassWheres()
        {
            string Strs = null;
            ROYcms.Sys.BLL.ROYcms_class Bll = new ROYcms.Sys.BLL.ROYcms_class();
            DataSet DS = Bll.GetSubClassList(Bll.GetClassId(Convert.ToInt32(this.Class)));

            DataTable dt = DS.Tables[0];
            //遍历行
            if (dt.Rows.Count < 1)
            {
                Strs = this.Class + ",";
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Strs += dr["Id"].ToString() + ",";
                }

            }
            Strs = Strs.Substring(0, Strs.Length - 1);
            return Strs;
        }

    }
}
