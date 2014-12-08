using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DNSABC.Web.ROYcms_user
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				DNSABC.BLL.ROYcms_user bll=new DNSABC.BLL.ROYcms_user();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int bh=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(bh);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}