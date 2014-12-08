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
namespace DNSABC.Web.DNSABC_Transaction
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
		DNSABC.BLL.DNSABC_Transaction bll=new DNSABC.BLL.DNSABC_Transaction();
		DNSABC.Model.DNSABC_Transaction model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblUserId.Text=model.UserId.ToString();
		this.lblTradeType.Text=model.TradeType.ToString();
		this.lblPrice.Text=model.Price.ToString();
		this.lblAccountBalance.Text=model.AccountBalance.ToString();
		this.lblPayentMethord.Text=model.PayentMethord;
		this.lblTradeExplaining.Text=model.TradeExplaining;
		this.lblPaymentLogo.Text=model.PaymentLogo;
		this.lblRemark.Text=model.Remark;
		this.lblCreateTime.Text=model.CreateTime.ToString();

	}


    }
}
