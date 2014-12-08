using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;

namespace ROYcms.Controls
{
   public class RemarkRepeater : _Repeater
    {
        //私有变量
        private string mstrEmptyText = "<!--DataSource为空！-->";//DataSource为空的时候显示的字
    
        private IList dataSource;//数据源，必须可以转换为IList

        private int intItemCount;




        //自定义绑定
        private int _Top = 10;//
        private string _NewId = null;//查询条件
        private string _FiledOrder = "bh desc";//排序规则
        public int Top
        {
            get { return _Top; }
            set { _Top = value; }
        }
        public string NewId
        {
            get {
                if (_NewId != null)
                {
                    if (Page.Request["id"] != null)
                    { _NewId = _NewId.ToLowerInvariant().Replace("{id}", Page.Request["id"]); }
                }
                else { if (Page.Request["id"] != null) { _NewId = Page.Request["id"]; } }
                return _NewId;
            }
            set {
                _NewId = value; 
            
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
            ROYcms.Sys.BLL.ROYcms_remark ___ROYcms_remark = new ROYcms.Sys.BLL.ROYcms_remark();
            if (NewId != null)
            {
                dataSource = (IList)(new DataView(((DataSet)(___ROYcms_remark.GetList(Top, " NewID = " + NewId, FiledOrder))).Tables[0]));
            }
            else
            {
                dataSource = (IList)(new DataView(((DataSet)(___ROYcms_remark.GetList(Top, " NewID >0 ", FiledOrder))).Tables[0]));
            }
            intItemCount = dataSource.Count;
            base.DataSource = dataSource;

            base.OnDataBinding(e);
        }
    }
}
