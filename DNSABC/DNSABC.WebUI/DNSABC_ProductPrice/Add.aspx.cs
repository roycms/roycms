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
namespace DNSABC.Web.DNSABC_ProductPrice
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtProductID.Text))
			{
				strErr+="产品ID 产品ID必须存在格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtGradeID.Text))
			{
				strErr+="等级ID 等级ID和用户ID必格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserID.Text))
			{
				strErr+="用户ID 等级ID和用户ID必格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtRealPrice.Text))
			{
				strErr+="原价 产品原价格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPrice.Text))
			{
				strErr+="价格 销售价格格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMONTH.Text))
			{
				strErr+="月数 产品订购时限格式错误！\\n";	
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
			int ProductID=int.Parse(this.txtProductID.Text);
			int GradeID=int.Parse(this.txtGradeID.Text);
			int UserID=int.Parse(this.txtUserID.Text);
			int RealPrice=int.Parse(this.txtRealPrice.Text);
			int Price=int.Parse(this.txtPrice.Text);
			int MONTH=int.Parse(this.txtMONTH.Text);
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);

			DNSABC.Model.DNSABC_ProductPrice model=new DNSABC.Model.DNSABC_ProductPrice();
			model.ProductID=ProductID;
			model.GradeID=GradeID;
			model.UserID=UserID;
			model.RealPrice=RealPrice;
			model.Price=Price;
			model.MONTH=MONTH;
			model.UpdateTime=UpdateTime;
			model.CreateTime=CreateTime;

			DNSABC.BLL.DNSABC_ProductPrice bll=new DNSABC.BLL.DNSABC_ProductPrice();
			bll.Add(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
