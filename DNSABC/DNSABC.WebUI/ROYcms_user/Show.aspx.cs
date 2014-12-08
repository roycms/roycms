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
namespace DNSABC.Web.ROYcms_user
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
					int bh=(Convert.ToInt32(strid));
					ShowInfo(bh);
				}
			}
		}
		
	private void ShowInfo(int bh)
	{
		DNSABC.BLL.ROYcms_user bll=new DNSABC.BLL.ROYcms_user();
		DNSABC.Model.ROYcms_user model=bll.GetModel(bh);
		this.lblbh.Text=model.bh.ToString();
		this.lblRoleID.Text=model.RoleID;
		this.lblUgroupID.Text=model.UgroupID;
		this.lblName.Text=model.Name;
		this.lblPASSWORD.Text=model.PASSWORD;
		this.lblmoney.Text=model.money.ToString();
		this.lblQq.Text=model.Qq;
		this.lblEmail.Text=model.Email;
		this.lblAge.Text=model.Age.ToString();
		this.lblsex.Text=model.sex;
		this.lblPic.Text=model.Pic;
		this.lblQuanxian.Text=model.Quanxian;
		this.lblUsername.Text=model.Username;
		this.lblGuid.Text=model.Guid;
		this.lblIp.Text=model.Ip;
		this.lblLoginTime.Text=model.LoginTime.ToString();

	}


    }
}
