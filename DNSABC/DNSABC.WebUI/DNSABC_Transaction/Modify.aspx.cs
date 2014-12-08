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
namespace DNSABC.Web.DNSABC_Transaction
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
		DNSABC.BLL.DNSABC_Transaction bll=new DNSABC.BLL.DNSABC_Transaction();
		DNSABC.Model.DNSABC_Transaction model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtUserId.Text=model.UserId.ToString();
		this.txtTradeType.Text=model.TradeType.ToString();
		this.txtPrice.Text=model.Price.ToString();
		this.txtAccountBalance.Text=model.AccountBalance.ToString();
		this.txtPayentMethord.Text=model.PayentMethord;
		this.txtTradeExplaining.Text=model.TradeExplaining;
		this.txtPaymentLogo.Text=model.PaymentLogo;
		this.txtRemark.Text=model.Remark;
		this.txtCreateTime.Text=model.CreateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUserId.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTradeType.Text))
			{
				strErr+="交易类型 1为在线支付 2为银格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPrice.Text))
			{
				strErr+="交易金额 正数为充值格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtAccountBalance.Text))
			{
				strErr+="账户余额格式错误！\\n";	
			}
			if(this.txtPayentMethord.Text.Trim().Length==0)
			{
				strErr+="支付方式不能为空！\\n";	
			}
			if(this.txtTradeExplaining.Text.Trim().Length==0)
			{
				strErr+="交易说明不能为空！\\n";	
			}
			if(this.txtPaymentLogo.Text.Trim().Length==0)
			{
				strErr+="付款标识不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateTime.Text))
			{
				strErr+="交易时间格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			int UserId=int.Parse(this.txtUserId.Text);
			int TradeType=int.Parse(this.txtTradeType.Text);
			int Price=int.Parse(this.txtPrice.Text);
			int AccountBalance=int.Parse(this.txtAccountBalance.Text);
			string PayentMethord=this.txtPayentMethord.Text;
			string TradeExplaining=this.txtTradeExplaining.Text;
			string PaymentLogo=this.txtPaymentLogo.Text;
			string Remark=this.txtRemark.Text;
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);


			DNSABC.Model.DNSABC_Transaction model=new DNSABC.Model.DNSABC_Transaction();
			model.Id=Id;
			model.UserId=UserId;
			model.TradeType=TradeType;
			model.Price=Price;
			model.AccountBalance=AccountBalance;
			model.PayentMethord=PayentMethord;
			model.TradeExplaining=TradeExplaining;
			model.PaymentLogo=PaymentLogo;
			model.Remark=Remark;
			model.CreateTime=CreateTime;

			DNSABC.BLL.DNSABC_Transaction bll=new DNSABC.BLL.DNSABC_Transaction();
			bll.Update(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
