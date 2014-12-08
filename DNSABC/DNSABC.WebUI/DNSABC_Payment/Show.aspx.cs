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
namespace DNSABC.Web.DNSABC_Payment
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
		DNSABC.BLL.DNSABC_Payment bll=new DNSABC.BLL.DNSABC_Payment();
		DNSABC.Model.DNSABC_Payment model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblUserID.Text=model.UserID.ToString();
		this.lblPaymentType.Text=model.PaymentType;
		this.lblPaymentName.Text=model.PaymentName;
		this.lblPaymentAmount.Text=model.PaymentAmount.ToString();
		this.lblPaymentNum.Text=model.PaymentNum;
		this.lblUpdateTime.Text=model.UpdateTime.ToString();
		this.lblCreateTime.Text=model.CreateTime.ToString();

	}


    }
}
