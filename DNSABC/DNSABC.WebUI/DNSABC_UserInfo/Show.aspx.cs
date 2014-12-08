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
namespace DNSABC.Web.DNSABC_UserInfo
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
		DNSABC.BLL.DNSABC_UserInfo bll=new DNSABC.BLL.DNSABC_UserInfo();
		DNSABC.Model.DNSABC_UserInfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblUserId.Text=model.UserId.ToString();
		this.lblAccountBalance.Text=model.AccountBalance.ToString();
		this.lblAvilableBalance.Text=model.AvilableBalance.ToString();
		this.lblConsumedAmount.Text=model.ConsumedAmount.ToString();
		this.lblMoney.Text=model.Money.ToString();
		this.lblGradeID.Text=model.GradeID.ToString();
		this.lblState.Text=model.State.ToString();
		this.lblRealName.Text=model.RealName;
		this.lblQq.Text=model.Qq.ToString();
		this.lblMobil.Text=model.Mobil;
		this.lblTel.Text=model.Tel;
		this.lblAddress.Text=model.Address;
		this.lblPostcode.Text=model.Postcode;
		this.lblWebsite.Text=model.Website;
		this.lblIDcardNum.Text=model.IDcardNum;
		this.lblAccountType.Text=model.AccountType.ToString();
		this.lblSiteID.Text=model.SiteID.ToString();

	}


    }
}
