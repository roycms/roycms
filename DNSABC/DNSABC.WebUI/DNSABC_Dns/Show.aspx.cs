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
namespace DNSABC.Web.DNSABC_Dns
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
		DNSABC.BLL.DNSABC_Dns bll=new DNSABC.BLL.DNSABC_Dns();
		DNSABC.Model.DNSABC_Dns model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblProductID.Text=model.ProductID.ToString();
		this.lblUserID.Text=model.UserID.ToString();
		this.lblDomain.Text=model.Domain;
		this.lblPASSWORD.Text=model.PASSWORD;
		this.lblStartTime.Text=model.StartTime.ToString();
		this.lblEndTime.Text=model.EndTime.ToString();
		this.lblisHost.Text=model.isHost.ToString();
		this.lblisTtl.Text=model.isTtl.ToString();
		this.lblisMonitor.Text=model.isMonitor.ToString();
		this.lblisGroupID.Text=model.isGroupID.ToString();
		this.lblState.Text=model.State.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblUpdateTime.Text=model.UpdateTime.ToString();
		this.lblCreateTime.Text=model.CreateTime.ToString();

	}


    }
}
