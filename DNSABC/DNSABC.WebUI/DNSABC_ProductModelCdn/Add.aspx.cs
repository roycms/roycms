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
namespace DNSABC.Web.DNSABC_ProductModelCdn
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
				strErr+="编号ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisHost.Text))
			{
				strErr+="主机个数 0表示主机个数不限制格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisConnection.Text))
			{
				strErr+="连接数 0表示连接数不限制格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisBandwidth.Text))
			{
				strErr+="带宽 0表示带宽不限制格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ProductID=int.Parse(this.txtProductID.Text);
			int isHost=int.Parse(this.txtisHost.Text);
			int isConnection=int.Parse(this.txtisConnection.Text);
			int isBandwidth=int.Parse(this.txtisBandwidth.Text);
			string Remark=this.txtRemark.Text;

			DNSABC.Model.DNSABC_ProductModelCdn model=new DNSABC.Model.DNSABC_ProductModelCdn();
			model.ProductID=ProductID;
			model.isHost=isHost;
			model.isConnection=isConnection;
			model.isBandwidth=isBandwidth;
			model.Remark=Remark;

			DNSABC.BLL.DNSABC_ProductModelCdn bll=new DNSABC.BLL.DNSABC_ProductModelCdn();
			bll.Add(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
