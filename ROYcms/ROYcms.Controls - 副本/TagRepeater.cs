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
    public class TagRepeater : _Repeater
    {

        //私有变量
        private string mstrEmptyText = "<!--DataSource为空！-->";//DataSource为空的时候显示的字
    
        private IList dataSource;//数据源，必须可以转换为IList

        private int intItemCount;




        //自定义绑定
        private int _Top = 10;//显示条数 
        private int _Div = 00;//按层筛选
        private string _Path = null;//查询条件
        private string _ClassKind = null;
        private string _Class = null;
        public int Top
        {
            get { return _Top; }
            set { _Top = value; }
        }
        public int Div
        {
            get { return _Div; }
            set { _Div = value; }
        }
        public string Path
        {
            get {
                if (_Path != null)
                {
                    if (Page.Request["path"] != null)
                    { _Path = _Path.ToLowerInvariant().Replace("{path}", Page.Request["path"]); }
                }
                return _Path;
            }
            set {
                _Path = value; 
            
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
                    if (Page.Request["class"] != null)
                    { _Class = _Class.ToLowerInvariant().Replace("{class}", Page.Request["class"]); }
                }
                return _Class;
            }
            set
            {
                _Class = value;
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
            ROYcms.Sys.BLL.ROYcms_class ___ROYcms_class = new ROYcms.Sys.BLL.ROYcms_class();
            if (ClassKind != null)
            {
                if (Div != 00)
                {
                    dataSource = (IList)(new DataView(((DataSet)(___ROYcms_class.GetClassList(Convert.ToInt32(ClassKind),Div))).Tables[0]));
                }
                else { dataSource = (IList)(new DataView(((DataSet)(___ROYcms_class.GetClassList(Convert.ToInt32(ClassKind)))).Tables[0])); }
            }
            if (Class != null)
            {
                dataSource = (IList)(new DataView(((DataSet)(___ROYcms_class.GetSubClassList(___ROYcms_class.GetClassId(Convert.ToInt32(Class))))).Tables[0]));
            }
            if (Path != null)
            {
                dataSource = (IList)(new DataView(((DataSet)(___ROYcms_class.GetSubClassList(___ROYcms_class.GetClassId(Convert.ToInt32(___ROYcms_class.GetId("{cmspath}/" + Path+"/")))))).Tables[0]));
            }
            //if (base.DataSource != null)
            //{
                intItemCount = dataSource.Count;
                base.DataSource = dataSource;

                base.OnDataBinding(e);
            //}
        }


    }
}
