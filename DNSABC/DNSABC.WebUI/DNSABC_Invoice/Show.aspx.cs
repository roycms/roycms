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
namespace DNSABC.Web.DNSABC_Invoice
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
		DNSABC.BLL.DNSABC_Invoice bll=new DNSABC.BLL.DNSABC_Invoice();
		DNSABC.Model.DNSABC_Invoice model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblUserID.Text=model.UserID.ToString();
		this.lblInvoiceName.Text=model.InvoiceName;
		this.lblPrice.Text=model.Price.ToString();
		this.lblPostType.Text=model.PostType.ToString();
		this.lblRealName.Text=model.RealName;
		this.lblTel.Text=model.Tel;
		this.lblMobil.Text=model.Mobil;
		this.lblAddress.Text=model.Address;
		this.lblPostCode.Text=model.PostCode;
		this.lblRemark.Text=model.Remark;
		this.lblState.Text=model.State.ToString();
		this.lblAdminRemark.Text=model.AdminRemark;
		this.lblCreateTime.Text=model.CreateTime.ToString();

	}


    }
}
