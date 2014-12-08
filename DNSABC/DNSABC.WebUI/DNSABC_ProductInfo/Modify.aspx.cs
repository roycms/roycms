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
namespace DNSABC.Web.DNSABC_ProductInfo
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
		DNSABC.BLL.DNSABC_ProductInfo bll=new DNSABC.BLL.DNSABC_ProductInfo();
		DNSABC.Model.DNSABC_ProductInfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtProductType.Text=model.ProductType.ToString();
		this.txtProductName.Text=model.ProductName;
		this.txtProductPic.Text=model.ProductPic;
		this.txtProductDescription.Text=model.ProductDescription;
		this.txtProductTableName.Text=model.ProductTableName;
		this.txtMONTH.Text=model.MONTH.ToString();
		this.txtState.Text=model.State.ToString();
		this.txtisOrder.Text=model.isOrder.ToString();
		this.txtRemark.Text=model.Remark;
		this.txtUpdateTime.Text=model.UpdateTime.ToString();
		this.txtCreateTime.Text=model.CreateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtProductType.Text))
			{
				strErr+="产品类型 1格式错误！\\n";	
			}
			if(this.txtProductName.Text.Trim().Length==0)
			{
				strErr+="名称不能为空！\\n";	
			}
			if(this.txtProductPic.Text.Trim().Length==0)
			{
				strErr+="产品图片不能为空！\\n";	
			}
			if(this.txtProductDescription.Text.Trim().Length==0)
			{
				strErr+="产品描述 编辑器区域不能为空！\\n";	
			}
			if(this.txtProductTableName.Text.Trim().Length==0)
			{
				strErr+="模型的表格名称 Product不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMONTH.Text))
			{
				strErr+="月数 产品默认订购时限格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtState.Text))
			{
				strErr+="产品状态 0为停用格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisOrder.Text))
			{
				strErr+="权重格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
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
			int ProductType=int.Parse(this.txtProductType.Text);
			string ProductName=this.txtProductName.Text;
			string ProductPic=this.txtProductPic.Text;
			string ProductDescription=this.txtProductDescription.Text;
			string ProductTableName=this.txtProductTableName.Text;
			int MONTH=int.Parse(this.txtMONTH.Text);
			int State=int.Parse(this.txtState.Text);
			int isOrder=int.Parse(this.txtisOrder.Text);
			string Remark=this.txtRemark.Text;
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);


			DNSABC.Model.DNSABC_ProductInfo model=new DNSABC.Model.DNSABC_ProductInfo();
			model.Id=Id;
			model.ProductType=ProductType;
			model.ProductName=ProductName;
			model.ProductPic=ProductPic;
			model.ProductDescription=ProductDescription;
			model.ProductTableName=ProductTableName;
			model.MONTH=MONTH;
			model.State=State;
			model.isOrder=isOrder;
			model.Remark=Remark;
			model.UpdateTime=UpdateTime;
			model.CreateTime=CreateTime;

			DNSABC.BLL.DNSABC_ProductInfo bll=new DNSABC.BLL.DNSABC_ProductInfo();
			bll.Update(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
