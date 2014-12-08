using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace DNSABC.Web.DNSABC_ProductModelCdn
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int Id=(Convert.ToInt32(strid));
					ShowInfo(Id);
				}
			}
		}
		
	private void ShowInfo(int Id)
	{
		DNSABC.BLL.DNSABC_ProductModelCdn bll=new DNSABC.BLL.DNSABC_ProductModelCdn();
		DNSABC.Model.DNSABC_ProductModelCdn model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblProductID.Text=model.ProductID.ToString();
		this.lblisHost.Text=model.isHost.ToString();
		this.lblisConnection.Text=model.isConnection.ToString();
		this.lblisBandwidth.Text=model.isBandwidth.ToString();
		this.lblRemark.Text=model.Remark;

	}


    }
}
