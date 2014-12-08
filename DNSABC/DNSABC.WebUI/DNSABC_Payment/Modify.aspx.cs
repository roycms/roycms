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
namespace DNSABC.Web.DNSABC_Payment
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
		DNSABC.BLL.DNSABC_Payment bll=new DNSABC.BLL.DNSABC_Payment();
		DNSABC.Model.DNSABC_Payment model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtUserID.Text=model.UserID.ToString();
		this.txtPaymentType.Text=model.PaymentType;
		this.txtPaymentName.Text=model.PaymentName;
		this.txtPaymentAmount.Text=model.PaymentAmount.ToString();
		this.txtPaymentNum.Text=model.PaymentNum;
		this.txtUpdateTime.Text=model.UpdateTime.ToString();
		this.txtCreateTime.Text=model.CreateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUserID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}
			if(this.txtPaymentType.Text.Trim().Length==0)
			{
				strErr+="支付接口不能为空！\\n";	
			}
			if(this.txtPaymentName.Text.Trim().Length==0)
			{
				strErr+="支付接口名称不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPaymentAmount.Text))
			{
				strErr+="支付金额格式错误！\\n";	
			}
			if(this.txtPaymentNum.Text.Trim().Length==0)
			{
				strErr+="支付号不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateTime.Text))
			{
				strErr+="更新时间格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateTime.Text))
			{
				strErr+="创建时间格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			int UserID=int.Parse(this.txtUserID.Text);
			string PaymentType=this.txtPaymentType.Text;
			string PaymentName=this.txtPaymentName.Text;
			int PaymentAmount=int.Parse(this.txtPaymentAmount.Text);
			string PaymentNum=this.txtPaymentNum.Text;
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);


			DNSABC.Model.DNSABC_Payment model=new DNSABC.Model.DNSABC_Payment();
			model.Id=Id;
			model.UserID=UserID;
			model.PaymentType=PaymentType;
			model.PaymentName=PaymentName;
			model.PaymentAmount=PaymentAmount;
			model.PaymentNum=PaymentNum;
			model.UpdateTime=UpdateTime;
			model.CreateTime=CreateTime;

			DNSABC.BLL.DNSABC_Payment bll=new DNSABC.BLL.DNSABC_Payment();
			bll.Update(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
