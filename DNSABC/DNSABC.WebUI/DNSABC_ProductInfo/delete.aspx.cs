using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DNSABC.Web.DNSABC_ProductInfo
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				DNSABC.BLL.DNSABC_ProductInfo bll=new DNSABC.BLL.DNSABC_ProductInfo();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int Id=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(Id);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}