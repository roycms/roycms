using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.ComponentModel;

namespace ROYcms.Controls
{
    [DefaultProperty("")]
    [ToolboxData("<{0}:UserField  runat=server />")]
    public class UserField : Literal
    {
        private string _Name = "title";
        private string _Rid = null;
        private string _Sessions = null;
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
        public string Sessions
        {
            get { return _Sessions; }
            set { _Sessions = value; }
        }
        /// <summary>
        /// 参数值 只读 Request[ParameterName]
        /// </summary>
        /// <value>The id.</value>
        ///[Bindable(true)]
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
            if (this.Sessions != null) { Rid = HttpContext.Current.Session["user_id"].ToString(); }
            
            ROYcms.Sys.BLL.ROYcms_user ___ROYcms_user = new ROYcms.Sys.BLL.ROYcms_user();
            try
            {
             output.Write(___ROYcms_user.GetField(Convert.ToInt32(Rid), ROYcms.Common.Zn_En.Fy(Name)));
            }
            catch { output.Write("<!--输出错误！-->"); }
        }
    }
}
