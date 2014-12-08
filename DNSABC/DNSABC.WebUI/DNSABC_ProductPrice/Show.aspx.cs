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
namespace DNSABC.Web.DNSABC_ProductPrice
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
		DNSABC.BLL.DNSABC_ProductPrice bll=new DNSABC.BLL.DNSABC_ProductPrice();
		DNSABC.Model.DNSABC_ProductPrice model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblProductID.Text=model.ProductID.ToString();
		this.lblGradeID.Text=model.GradeID.ToString();
		this.lblUserID.Text=model.UserID.ToString();
		this.lblRealPrice.Text=model.RealPrice.ToString();
		this.lblPrice.Text=model.Price.ToString();
		this.lblMONTH.Text=model.MONTH.ToString();
		this.lblUpdateTime.Text=model.UpdateTime.ToString();
		this.lblCreateTime.Text=model.CreateTime.ToString();

	}


    }
}
