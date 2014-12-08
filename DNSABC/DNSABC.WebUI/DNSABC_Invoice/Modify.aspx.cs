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
namespace DNSABC.Web.DNSABC_Invoice
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
		DNSABC.BLL.DNSABC_Invoice bll=new DNSABC.BLL.DNSABC_Invoice();
		DNSABC.Model.DNSABC_Invoice model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtUserID.Text=model.UserID.ToString();
		this.txtInvoiceName.Text=model.InvoiceName;
		this.txtPrice.Text=model.Price.ToString();
		this.txtPostType.Text=model.PostType.ToString();
		this.txtRealName.Text=model.RealName;
		this.txtTel.Text=model.Tel;
		this.txtMobil.Text=model.Mobil;
		this.txtAddress.Text=model.Address;
		this.txtPostCode.Text=model.PostCode;
		this.txtRemark.Text=model.Remark;
		this.txtState.Text=model.State.ToString();
		this.txtAdminRemark.Text=model.AdminRemark;
		this.txtCreateTime.Text=model.CreateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUserID.Text))
			{
				strErr+="申领人格式错误！\\n";	
			}
			if(this.txtInvoiceName.Text.Trim().Length==0)
			{
				strErr+="发票抬头不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPrice.Text))
			{
				strErr+="申领金额格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPostType.Text))
			{
				strErr+="邮寄方式格式错误！\\n";	
			}
			if(this.txtRealName.Text.Trim().Length==0)
			{
				strErr+="联系人不能为空！\\n";	
			}
			if(this.txtTel.Text.Trim().Length==0)
			{
				strErr+="电话不能为空！\\n";	
			}
			if(this.txtMobil.Text.Trim().Length==0)
			{
				strErr+="手机不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="邮寄地址不能为空！\\n";	
			}
			if(this.txtPostCode.Text.Trim().Length==0)
			{
				strErr+="邮编不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注 用户申请发票时的备注信息不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtState.Text))
			{
				strErr+="管理员处理状态 0为未处理格式错误！\\n";	
			}
			if(this.txtAdminRemark.Text.Trim().Length==0)
			{
				strErr+="管理员备注 备注发票邮寄方式信不能为空！\\n";	
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
			string InvoiceName=this.txtInvoiceName.Text;
			int Price=int.Parse(this.txtPrice.Text);
			int PostType=int.Parse(this.txtPostType.Text);
			string RealName=this.txtRealName.Text;
			string Tel=this.txtTel.Text;
			string Mobil=this.txtMobil.Text;
			string Address=this.txtAddress.Text;
			string PostCode=this.txtPostCode.Text;
			string Remark=this.txtRemark.Text;
			int State=int.Parse(this.txtState.Text);
			string AdminRemark=this.txtAdminRemark.Text;
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);


			DNSABC.Model.DNSABC_Invoice model=new DNSABC.Model.DNSABC_Invoice();
			model.Id=Id;
			model.UserID=UserID;
			model.InvoiceName=InvoiceName;
			model.Price=Price;
			model.PostType=PostType;
			model.RealName=RealName;
			model.Tel=Tel;
			model.Mobil=Mobil;
			model.Address=Address;
			model.PostCode=PostCode;
			model.Remark=Remark;
			model.State=State;
			model.AdminRemark=AdminRemark;
			model.CreateTime=CreateTime;

			DNSABC.BLL.DNSABC_Invoice bll=new DNSABC.BLL.DNSABC_Invoice();
			bll.Update(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
