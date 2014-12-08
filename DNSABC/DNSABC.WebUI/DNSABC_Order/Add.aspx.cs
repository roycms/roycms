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
namespace DNSABC.Web.DNSABC_Order
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtOrderId.Text))
			{
				strErr+="订单号 时间戳格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtProductType.Text))
			{
				strErr+="产品类型 1格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtProductID.Text))
			{
				strErr+="产品ID格式错误！\\n";	
			}
			if(this.txtProductName.Text.Trim().Length==0)
			{
				strErr+="产品名称不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserId.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}
			if(this.txtDomain.Text.Trim().Length==0)
			{
				strErr+="产品标识 对应业务的表示不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPrice.Text))
			{
				strErr+="产品金额格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtState.Text))
			{
				strErr+="订单状态格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="附注说明 生成订单的时候不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFinishTime.Text))
			{
				strErr+="完成时间格式错误！\\n";	
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
			int OrderId=int.Parse(this.txtOrderId.Text);
			int ProductType=int.Parse(this.txtProductType.Text);
			int ProductID=int.Parse(this.txtProductID.Text);
			string ProductName=this.txtProductName.Text;
			int UserId=int.Parse(this.txtUserId.Text);
			string Domain=this.txtDomain.Text;
			int Price=int.Parse(this.txtPrice.Text);
			int State=int.Parse(this.txtState.Text);
			string Remark=this.txtRemark.Text;
			DateTime FinishTime=DateTime.Parse(this.txtFinishTime.Text);
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);

			DNSABC.Model.DNSABC_Order model=new DNSABC.Model.DNSABC_Order();
			model.OrderId=OrderId;
			model.ProductType=ProductType;
			model.ProductID=ProductID;
			model.ProductName=ProductName;
			model.UserId=UserId;
			model.Domain=Domain;
			model.Price=Price;
			model.State=State;
			model.Remark=Remark;
			model.FinishTime=FinishTime;
			model.UpdateTime=UpdateTime;
			model.CreateTime=CreateTime;

			DNSABC.BLL.DNSABC_Order bll=new DNSABC.BLL.DNSABC_Order();
			bll.Add(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
