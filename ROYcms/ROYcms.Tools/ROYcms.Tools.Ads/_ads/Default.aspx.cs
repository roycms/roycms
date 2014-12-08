using System;
using System.Web.UI;

namespace ROYcms.Tools.Ads
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindDataSort();
                if (Request.QueryString["id"] != null)
                {
                    BindDataAd(Request.QueryString["id"].ToString());//绑定所属的广告内容
                }

            }
        }

        private void BindDataAd(string getsid)
        {
            AdMsg admsg = new AdMsg();
            RepAdList.DataSource = admsg.GetList("sid=" + getsid);
            RepAdList.DataBind();
        }

        private void BindDataSort()
        {
            AdSort adsort = new AdSort();
            DataListAdSort.DataSource = adsort.GetList("");
            DataListAdSort.DataBind();
        }
    }
}