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
namespace DNSABC.Web.DNSABC_MessagesResult
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
		DNSABC.BLL.DNSABC_MessagesResult bll=new DNSABC.BLL.DNSABC_MessagesResult();
		DNSABC.Model.DNSABC_MessagesResult model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblMessagesID.Text=model.MessagesID.ToString();
		this.lblUserID.Text=model.UserID.ToString();
		this.lblAdminID.Text=model.AdminID.ToString();
		this.lblTitle.Text=model.Title;
		this.lblContents.Text=model.Contents;
		this.lblIP.Text=model.IP;
		this.lblCreateTime.Text=model.CreateTime.ToString();

	}


    }
}
