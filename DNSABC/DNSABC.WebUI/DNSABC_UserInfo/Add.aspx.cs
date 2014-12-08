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
namespace DNSABC.Web.DNSABC_UserInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUserId.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtAccountBalance.Text))
			{
				strErr+="账户余额格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtAvilableBalance.Text))
			{
				strErr+="可用余额格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtConsumedAmount.Text))
			{
				strErr+="已经消费金额格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMoney.Text))
			{
				strErr+="积分格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtGradeID.Text))
			{
				strErr+="用户等级ID 默认值1格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtState.Text))
			{
				strErr+="有效状态 0为停用格式错误！\\n";	
			}
			if(this.txtRealName.Text.Trim().Length==0)
			{
				strErr+="联系人姓名不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtQq.Text))
			{
				strErr+="QQ号码格式错误！\\n";	
			}
			if(this.txtMobil.Text.Trim().Length==0)
			{
				strErr+="联系人手机不能为空！\\n";	
			}
			if(this.txtTel.Text.Trim().Length==0)
			{
				strErr+="电话不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="地址不能为空！\\n";	
			}
			if(this.txtPostcode.Text.Trim().Length==0)
			{
				strErr+="邮编不能为空！\\n";	
			}
			if(this.txtWebsite.Text.Trim().Length==0)
			{
				strErr+="网站不能为空！\\n";	
			}
			if(this.txtIDcardNum.Text.Trim().Length==0)
			{
				strErr+="身份证号码不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtAccountType.Text))
			{
				strErr+="账户类型 企业则对应企业信息表格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSiteID.Text))
			{
				strErr+="站点ID 0为主站 大于0为站格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UserId=int.Parse(this.txtUserId.Text);
			int AccountBalance=int.Parse(this.txtAccountBalance.Text);
			int AvilableBalance=int.Parse(this.txtAvilableBalance.Text);
			int ConsumedAmount=int.Parse(this.txtConsumedAmount.Text);
			int Money=int.Parse(this.txtMoney.Text);
			int GradeID=int.Parse(this.txtGradeID.Text);
			int State=int.Parse(this.txtState.Text);
			string RealName=this.txtRealName.Text;
			int Qq=int.Parse(this.txtQq.Text);
			string Mobil=this.txtMobil.Text;
			string Tel=this.txtTel.Text;
			string Address=this.txtAddress.Text;
			string Postcode=this.txtPostcode.Text;
			string Website=this.txtWebsite.Text;
			string IDcardNum=this.txtIDcardNum.Text;
			int AccountType=int.Parse(this.txtAccountType.Text);
			int SiteID=int.Parse(this.txtSiteID.Text);

			DNSABC.Model.DNSABC_UserInfo model=new DNSABC.Model.DNSABC_UserInfo();
			model.UserId=UserId;
			model.AccountBalance=AccountBalance;
			model.AvilableBalance=AvilableBalance;
			model.ConsumedAmount=ConsumedAmount;
			model.Money=Money;
			model.GradeID=GradeID;
			model.State=State;
			model.RealName=RealName;
			model.Qq=Qq;
			model.Mobil=Mobil;
			model.Tel=Tel;
			model.Address=Address;
			model.Postcode=Postcode;
			model.Website=Website;
			model.IDcardNum=IDcardNum;
			model.AccountType=AccountType;
			model.SiteID=SiteID;

			DNSABC.BLL.DNSABC_UserInfo bll=new DNSABC.BLL.DNSABC_UserInfo();
			bll.Add(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
