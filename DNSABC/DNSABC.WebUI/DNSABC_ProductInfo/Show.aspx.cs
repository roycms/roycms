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
namespace DNSABC.Web.DNSABC_ProductInfo
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
		DNSABC.BLL.DNSABC_ProductInfo bll=new DNSABC.BLL.DNSABC_ProductInfo();
		DNSABC.Model.DNSABC_ProductInfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblProductType.Text=model.ProductType.ToString();
		this.lblProductName.Text=model.ProductName;
		this.lblProductPic.Text=model.ProductPic;
		this.lblProductDescription.Text=model.ProductDescription;
		this.lblProductTableName.Text=model.ProductTableName;
		this.lblMONTH.Text=model.MONTH.ToString();
		this.lblState.Text=model.State.ToString();
		this.lblisOrder.Text=model.isOrder.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblUpdateTime.Text=model.UpdateTime.ToString();
		this.lblCreateTime.Text=model.CreateTime.ToString();

	}


    }
}
