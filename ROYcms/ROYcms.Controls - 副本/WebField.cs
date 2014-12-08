using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Controls
{
    [DefaultProperty("")]
    [ToolboxData("<{0}:WebField  runat=server />")]
    public class WebField : Literal
    {
        private string _Name = "title";
        private string _Rid = null;

        /// <summary>
        /// 字段名称
        /// </summary>
        /// <value>The name.</value>
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        [Description("字段名称")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        /// <summary>
        /// 参数值 只读 Request[ParameterName]
        /// </summary>
        /// <value>The id.</value>
        ///        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        [Description("ID参数 可选")]
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
        /// <summary>
        /// 输出
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void Render(HtmlTextWriter output)
        {
            ROYcms.Sys.BLL.ROYcms_news ___ROYcms_news = new ROYcms.Sys.BLL.ROYcms_news();
            ROYcms.Sys.BLL.ROYcms_Custom ROYcms_CustomBLL = new ROYcms.Sys.BLL.ROYcms_Custom();

            string MainField = null;

            try
            {
                if (Array.IndexOf(ROYcms.Common.Zn_En.MainField(), Name) != -1) //是默认字段
                {
                    MainField = ___ROYcms_news.GetField(Convert.ToInt32(Rid), ROYcms.Common.Zn_En.Fy(Name));
                }
                else
                {
                    int Class = Convert.ToInt32(___ROYcms_news.GetClassName(Convert.ToInt32(Rid))); //获取Class
                    MainField = ROYcms_CustomBLL.GetVal(Convert.ToInt32(Rid), Class, Name); //获取自定义字段的名字
                }
                output.Write(MainField);
            }
            catch { output.Write("<!--输出错误！-->"); }
        }
    }
}
