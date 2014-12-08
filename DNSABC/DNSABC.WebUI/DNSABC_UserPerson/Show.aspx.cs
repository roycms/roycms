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
namespace DNSABC.Web.DNSABC_UserPerson
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
		DNSABC.BLL.DNSABC_UserPerson bll=new DNSABC.BLL.DNSABC_UserPerson();
		DNSABC.Model.DNSABC_UserPerson model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblUserId.Text=model.UserId.ToString();
		this.lblName.Text=model.Name;
		this.lblPosition.Text=model.Position;
		this.lblMobil.Text=model.Mobil;
		this.lblTel.Text=model.Tel;
		this.lblQq.Text=model.Qq.ToString();
		this.lblEmail.Text=model.Email;
		this.lblRemark.Text=model.Remark;
		this.lblUpdateTime.Text=model.UpdateTime.ToString();
		this.lblCreateTime.Text=model.CreateTime.ToString();

	}


    }
}
