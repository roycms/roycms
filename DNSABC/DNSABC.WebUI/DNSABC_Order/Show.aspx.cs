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
namespace DNSABC.Web.DNSABC_Order
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
		DNSABC.BLL.DNSABC_Order bll=new DNSABC.BLL.DNSABC_Order();
		DNSABC.Model.DNSABC_Order model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblOrderId.Text=model.OrderId.ToString();
		this.lblProductType.Text=model.ProductType.ToString();
		this.lblProductID.Text=model.ProductID.ToString();
		this.lblProductName.Text=model.ProductName;
		this.lblUserId.Text=model.UserId.ToString();
		this.lblDomain.Text=model.Domain;
		this.lblPrice.Text=model.Price.ToString();
		this.lblState.Text=model.State.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblFinishTime.Text=model.FinishTime.ToString();
		this.lblUpdateTime.Text=model.UpdateTime.ToString();
		this.lblCreateTime.Text=model.CreateTime.ToString();

	}


    }
}
