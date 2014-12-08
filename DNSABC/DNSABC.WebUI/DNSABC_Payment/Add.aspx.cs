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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			int UserID=int.Parse(this.txtUserID.Text);
			string PaymentType=this.txtPaymentType.Text;
			string PaymentName=this.txtPaymentName.Text;
			int PaymentAmount=int.Parse(this.txtPaymentAmount.Text);
			string PaymentNum=this.txtPaymentNum.Text;
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);

			DNSABC.Model.DNSABC_Payment model=new DNSABC.Model.DNSABC_Payment();
			model.UserID=UserID;
			model.PaymentType=PaymentType;
			model.PaymentName=PaymentName;
			model.PaymentAmount=PaymentAmount;
			model.PaymentNum=PaymentNum;
			model.UpdateTime=UpdateTime;
			model.CreateTime=CreateTime;

			DNSABC.BLL.DNSABC_Payment bll=new DNSABC.BLL.DNSABC_Payment();
			bll.Add(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
