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
    public class WebRepeater : _Repeater
    {
        public ROYcms.Sys.BLL.ROYcms_news NewBll = new Sys.BLL.ROYcms_news();
        public ROYcms.Sys.BLL.ROYcms_class ClassBll = new Sys.BLL.ROYcms_class();
        public ROYcms.Sys.BLL.ROYcms_Custom CustomBll = new Sys.BLL.ROYcms_Custom();
        //私有变量
        private string mstrEmptyText = "<!--DataSource为空！ROYcms!NT-->";//DataSource为空的时候显示的字
        private IList dataSource;//数据源，必须可以转换为IList
        private int intItemCount;
        //自定义绑定
        private int _Top = 10;//显示条数 
        private string _Son = null;//是否检索子类信息
        private string _Switchs = null;//审核 
        private string _Tuijian = null;//推荐 
        private string _Ding = null;//置顶
        private string _Tag = null;//标签
        private string _Type = null;//分类ID
        private string _ClassKind = null;
        private string _StrWhere = null;//查询条件
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
            get
            {
                if (_StrWhere != null)
                {
                    if (Page.Request["path"] != null)
                    { _StrWhere = _StrWhere.ToLowerInvariant().Replace("{path:id}", this.ClassBll.GetId("{cmspath}/" + Page.Request["path"] + "/")); }

                    Regex r = new Regex(@"\{(?<Name>\w+)\}", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    foreach (Match m in r.Matches(_StrWhere))
                    {
                        string Name = m.Groups["Name"].ToString();
                        _StrWhere = _StrWhere.Replace("{" + Name.ToLowerInvariant() + "}", Page.Request[Name.ToLowerInvariant()]);
                    }
                }
                return _StrWhere;
            }
            set
            {
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
        public string Type
        {
            get
            {
                if (_Type != null)
                {
                    //if (Page.Request["path"] != null)
                    //{ _Class = _Class.ToLowerInvariant().Replace("{path:id}", this.ClassBll.GetId("{cmspath}/" + Page.Request["path"] + "/")); }
                    if (Page.Request["Type"] != null)
                    { _Type = _Type.ToLowerInvariant().Replace("{type}", Page.Request["Type"]); }

                }
                return _Type;
            }
            set
            {
                _Type = value;
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
        /// <summary>
        /// 数据源为空时显示的文本，默认为空
        /// </summary>
        public string EmptyText
        {
            set { mstrEmptyText = value; }
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
                    if (value == null)
                    {
                        dataSource = null;
                        intItemCount = 0;
                    }
                    else if (value.GetType() == typeof(DataTable))//数据源是DataTable，转化为IList
                    {
                        dataSource = (IList)(new DataView((DataTable)value));
                        intItemCount = dataSource.Count;
                    }
                    else if (value.GetType() == typeof(DataSet))//数据源是DataSet，转化为IList
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
                    intItemCount = 0;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            if (Visible)
            {
                this.DataBind();
            }
        }

        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            if (intItemCount == 0)//数据源为空
            {
                writer.Write(mstrEmptyText);
                return;
            }
            base.Render(writer);
        }

        protected override void OnDataBinding(EventArgs e)
        {
            string Strs = null;
            if (this.Tag != null)//Tag标签
            {
                Strs += "tag like '%" + this.Tag + "%' AND ";
            }
            if (this.Switchs != null)//审核状态
            {
                Strs += "Switchs = " + this.Switchs + " AND ";
            }
            if (this.Ding != null)//置顶状态
            {
                Strs += "Ding = " + this.Ding + " AND ";
            }
            if (this.Tuijian != null)//推荐状态
            {
                Strs += "Tuijian = " + this.Tuijian + " AND ";
            }
            if (this.Type != null) //Class分类ID标识
            {
                if (this.Son != null)//是否包含子类内容
                {
                    Strs += " classname in (" + new SQLSplitJoint().ClassWheres(this.Type) + ") AND ";
                }
                else if (this.Type.Contains("|"))
                {
                    Strs += new SQLSplitJoint().Wheres(this.Type, "classname") + " AND ";
                }
                else
                {
                    Strs += "classname='" + this.Type + "' AND ";
                }
            }
            if (this.ClassKind != null)//ClassKind标识
            {
                Strs += "type='" + this.ClassKind + "' AND ";
            }
            Strs += "bh>-1 ";

            if (this.StrWhere != null) //自定义SQL查询条件
            {
                Strs = this.StrWhere;
            }
            if (this.SQL != null) //自定义SQL语句
            {
                Strs = this.SQL;
            }
           
            DataSet DS = this.NewBll.GetList(Top, Strs, this.FiledOrder);
            if ((!this.Type.Contains("|")) && this.Type != null)
            {
                //获取智能表单的数据
                string[] TableLists = null;
                TableLists = this.CustomBll.GetTableList(Convert.ToInt32(this.Type));
                //增加几列   文章链接、栏目名称、栏目链接 
                if (DS.Tables[0].Rows.Count > 0)
                {
                    DS.Tables[0].Columns.Add("ShowLink", typeof(System.String));//添加一列数据 文章链接
                    DS.Tables[0].Columns.Add("ChannelName", typeof(System.String));//添加一列数据 栏目名称
                    DS.Tables[0].Columns.Add("ChannelLink", typeof(System.String));//添加一列数据 栏目链接
                    DS.Tables[0].Columns.Add("ChannelListLink", typeof(System.String));//添加一列数据 栏目链接2
                    if (TableLists != null)
                    {
                        for (int i = 0; i < TableLists.Length; i++)
                        {
                            DS.Tables[0].Columns.Add(TableLists[i], typeof(System.String));//添加一列数据 
                        }
                    }
                    foreach (DataRow Dr in DS.Tables[0].Rows)
                    {
                        Dr["ShowLink"] = new ROYcms.Templet.GetMyUrl().GetArticle(Convert.ToInt32(Dr["bh"]));
                        Dr["ChannelName"] = this.ClassBll.GetClassField(Convert.ToInt32(Dr["classname"]), "ClassName");
                        Dr["ChannelLink"] = new ROYcms.Templet.GetMyUrl().GetChannel(Convert.ToInt32(Dr["classname"]), 0);
                        Dr["ChannelListLink"] = new ROYcms.Templet.GetMyUrl().GetChannel(Convert.ToInt32(Dr["classname"]), 1);
                        if (TableLists != null)
                        {
                            for (int i = 0; i < TableLists.Length; i++)
                            {
                                Dr[TableLists[i]] = this.CustomBll.GetVal(Convert.ToInt32(Dr["bh"]), Convert.ToInt32(Dr["classname"]), TableLists[i]); //赋值 Dr["bh"] Dr["classname"]
                            }
                        }
                    }
                }
            }
            dataSource = (IList)(new DataView(((DataSet)(DS)).Tables[0]));
            base.DataSource = dataSource;
            intItemCount = dataSource.Count;
            base.OnDataBinding(e);
        }
    }
}
