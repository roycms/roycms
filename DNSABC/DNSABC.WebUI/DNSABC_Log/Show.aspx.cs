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
namespace DNSABC.Web.DNSABC_Log
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
		DNSABC.BLL.DNSABC_Log bll=new DNSABC.BLL.DNSABC_Log();
		DNSABC.Model.DNSABC_Log model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblUserID.Text=model.UserID.ToString();
		this.lblLogType.Text=model.LogType.ToString();
		this.lblContent.Text=model.Content;
		this.lblOperator.Text=model.Operator;
		this.lblIp.Text=model.Ip;
		this.lblAdminID.Text=model.AdminID.ToString();
		this.lblObjectType.Text=model.ObjectType;
		this.lblObjectID.Text=model.ObjectID;
		this.lblRemark.Text=model.Remark;
		this.lblCreateTime.Text=model.CreateTime.ToString();

	}


    }
}
