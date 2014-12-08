using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Controls
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:Ratings runat=server />")]
    public class Ratings : Literal
    {
         private string _Rid = null;
         private string _DivId = null;
         private string _RatingUrl = null;
         private string _maxvalue = null;
         private string _curvalue = null;
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
        /// <summary>
        /// 字段名称
        /// </summary>
        /// <value>The name.</value>
        public string DivId
        {
            get { if (_DivId == null) { _DivId = "ROYcmsxing"; } return _DivId; }
            set { _DivId = value; }
        }
        public string RatingUrl
        {
            get { if (_RatingUrl == null) { _RatingUrl = "/_Ratings.ashx"; } return _RatingUrl; }
            set { _RatingUrl = value; }
        }
        public string maxvalue
        {
            get { if (_maxvalue == null) { _maxvalue = "10"; } return _maxvalue; }
            set { _maxvalue = value; }
        }
        public string curvalue
        {
            get {
                if (_curvalue == null) { _curvalue = "5"; }
                return _curvalue; 
            }
            set { _curvalue = value; }
        }
        protected override void Render(HtmlTextWriter output)
        {
            string HtmlText = "<div id='" + this.DivId + "'></div> \n";
            HtmlText += "<script type='text/javascript' src='/administrator/webui/jquery_rater/jquery-latest.js'></script> \n";
            HtmlText += "<script type='text/javascript' src='/administrator/webui/jquery_rater/jquery.rater.js'></script> \n";
            HtmlText += "<link rel='stylesheet' type='text/css' href='/administrator/webui/jquery_rater/rater.css' /> \n";
            HtmlText += "<script type='text/javascript'> \n";
            HtmlText +=String.Format("$('#{0}').rater('{1}?id={2}', ",this.DivId,this.RatingUrl,this.Rid);
            HtmlText += "{";
            HtmlText += String.Format(" maxvalue:{0},style: 'basic', curvalue: {1} ",this.maxvalue,this.curvalue);
            HtmlText += "});";
            HtmlText += "\n</script> \n";
            output.Write(HtmlText);
        }
    }
}
