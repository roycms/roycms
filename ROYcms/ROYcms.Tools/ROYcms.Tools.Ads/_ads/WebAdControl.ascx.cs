using System;
using System.Web.UI;

namespace ROYcms.Tools.Ads
{
    public partial class Control_WebAdControl : System.Web.UI.UserControl
    {
        private string _adid; //所对应的ID
        public string Adid
        {
            get { return _adid; }
            set { _adid = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindDataAd();
            }
        }

        private void BindDataAd()
        {
            AdMsg admsg = new AdMsg();
            AdMsgInfo minfo = admsg.GetModelAd(int.Parse(_adid));
            if (minfo != null)
            {
                txtAd.Text = "<script src=\"" + minfo.adjs.ToString() + "\"></script>";
            }
        }
    }
}