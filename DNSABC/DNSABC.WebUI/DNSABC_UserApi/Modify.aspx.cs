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
using ROYcms.Common;
using LTP.Accounts.Bus;
namespace DNSABC.Web.DNSABC_UserApi
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int Id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(Id);
				}
			}
		}
			
	private void ShowInfo(int Id)
	{
		DNSABC.BLL.DNSABC_UserApi bll=new DNSABC.BLL.DNSABC_UserApi();
		DNSABC.Model.DNSABC_UserApi model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtUserId.Text=model.UserId.ToString();
		this.txtIp.Text=model.Ip;
		this.txtKEY.Text=model.KEY;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUserId.Text))
			{
				strErr+="关联编号格式错误！\\n";	
			}
			if(this.txtIp.Text.Trim().Length==0)
			{
				strErr+="授权IP不能为空！\\n";	
			}
			if(this.txtKEY.Text.Trim().Length==0)
			{
				strErr+="Key密钥不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			int UserId=int.Parse(this.txtUserId.Text);
			string Ip=this.txtIp.Text;
			string KEY=this.txtKEY.Text;


			DNSABC.Model.DNSABC_UserApi model=new DNSABC.Model.DNSABC_UserApi();
			model.Id=Id;
			model.UserId=UserId;
			model.Ip=Ip;
			model.KEY=KEY;

			DNSABC.BLL.DNSABC_UserApi bll=new DNSABC.BLL.DNSABC_UserApi();
			bll.Update(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
