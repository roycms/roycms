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
    public class ProductRepeater : _Repeater
    {
        //私有变量
        private string mstrEmptyText = "<!--DataSource为空！ROYcms!NT-->";//DataSource为空的时候显示的字
        private IList dataSource;//数据源，必须可以转换为IList
        private int intItemCount;

        //自定义绑定

        private int _Top = 10;//显示条数 
        private string _Son =null;//是否检索子类信息
        private string _Switchs = "0";//审核 
        private string _Tuijian = null;//推荐 
        private string _Ding = null;//置顶
        private string _Tag = null;//标签
        private string _Class = null;//分类ID
        private string _ClassKind = null;
        private string  _StrWhere = null;//查询条件
        private string _SQL = null;//SQL语句
        private string _FiledOrder = "bh DESC";//排序规则

        public int Top
        {
            get { return _Top; }
            set { _Top = value; }
        }
        public string Son
        {
            get { return _Son; }
            set { _Son = value; }
        }
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
        public string StrWhere
        {
            get {
                if (_StrWhere != null)
                {
                    if (Page.Request["path"] != null)
                    { _StrWhere = _StrWhere.ToLowerInvariant().Replace("{path:id}", new ROYcms.Sys.BLL.ROYcms_class().GetId("{cmspath}/" + Page.Request["path"] + "/")); }

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
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Class
        {
            get
            {
                if (_Class != null)
                {
                    if (Page.Request["path"] != null)
                    { _Class = _Class.ToLowerInvariant().Replace("{path:id}", new ROYcms.Sys.BLL.ROYcms_class().GetId("{cmspath}/" + Page.Request["path"] + "/")); }
                    if (Page.Request["class"] != null)
                    { _Class = _Class.ToLowerInvariant().Replace("{class}", Page.Request["class"]); }

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
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
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
        /**//// <summary>
        /// 数据源为空时显示的文本，默认为空
        /// </summary>
        public string EmptyText
        {
            set { mstrEmptyText = value; }
        }
        /**//// <summary>
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

        protected override void OnLoad(EventArgs e)
        {
            if(Visible) 
            {
                this.DataBind();
            }
        }

        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            if(intItemCount == 0)//数据源为空
            {
                writer.Write(mstrEmptyText);
                return;
            }
            base.Render(writer);
        }

        protected override void OnDataBinding(EventArgs e)
        {
            string Strs = null;
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

            DS = new ROYcms.Sys.BLL.ROYcms_news().GetList(Top, Strs, this.FiledOrder);

            dataSource = (IList)(new DataView(((DataSet)(DS)).Tables[0]));
            base.DataSource = dataSource;
            intItemCount = dataSource.Count;
            base.OnDataBinding(e);
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
