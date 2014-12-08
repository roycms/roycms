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
    [ToolboxData("<{0}:ClassField runat=server />")]
    public class ClassField : Literal
    {
        private string _Name = "ClassName";
        private string _Rid = null;
        //private string _Path = null;
        /// <summary>
        /// 字段名称
        /// </summary>
        /// <value>The name.</value>
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
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
                    if (Page.Request["class"] != null)
                    { _Rid = _Rid.ToLowerInvariant().Replace("{class}", Page.Request["class"]); }
                }
                else 
                {
                    if (Page.Request["class"] != null) { _Rid = Page.Request["class"]; }
                }
                return _Rid;
            }
            set { _Rid = value; }
        }
        /// <summary>
        /// 地址
        /// </summary>
        /// <value>The id.</value>
        //public string Path
        //{
        //    get
        //    {
        //        if (_Path!= null)
        //        {
        //            if (Page.Request["path"] != null)
        //            {
        //                _Path = _Path.Replace("{path}".ToLowerInvariant(), Page.Request["path"]);
        //            }
        //        }
        //        return _Path;
        //    }
        //    set { _Path= value; }
        //}
        /// <summary>
        /// 输出
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void Render(HtmlTextWriter output)
        {
            ROYcms.Sys.BLL.ROYcms_class ___ROYcms_class = new ROYcms.Sys.BLL.ROYcms_class();
            try
            {
                output.Write((___ROYcms_class.GetClassField(Convert.ToInt32(Rid), Name)).Replace("{cmspath}/", "/"));
            }
            catch { output.Write("<!--输出错误！-->"); }
            //if (Path == null)
            //{
            //    try
            //    {
            //        output.Write((___ROYcms_class.GetClassField(Convert.ToInt32(Rid), Name)).Replace("{cmspath}/", "/"));
            //    }
            //    catch { output.Write("<!--输出错误！-->"); }
            //}
            //else
            //{
            //    try
            //    {
            //        output.Write(___ROYcms_class.GetClassField(Convert.ToInt32(___ROYcms_class.GetId("{cmspath}/" + Path + "/")), Name).Replace("{cmspath}/", "/"));   
            //    }
            //    catch { output.Write("<!--输出错误！-->"); }
            //}
        }
    }
}
