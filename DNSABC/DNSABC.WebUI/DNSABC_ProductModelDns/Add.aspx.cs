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
namespace DNSABC.Web.DNSABC_ProductModelDns
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
				strErr+="产品ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisHost.Text))
			{
				strErr+="主机个数 0表示主机个数不限制格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisTtl.Text))
			{
				strErr+="TTL值 0表示TTL值不限制格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisMonitor.Text))
			{
				strErr+="宕机检测个数 0表示无宕机检测功能格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisGroupID.Text))
			{
				strErr+="NS组 表示默认开通的服务器组格式错误！\\n";	
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
			int isTtl=int.Parse(this.txtisTtl.Text);
			int isMonitor=int.Parse(this.txtisMonitor.Text);
			int isGroupID=int.Parse(this.txtisGroupID.Text);
			string Remark=this.txtRemark.Text;

			DNSABC.Model.DNSABC_ProductModelDns model=new DNSABC.Model.DNSABC_ProductModelDns();
			model.ProductID=ProductID;
			model.isHost=isHost;
			model.isTtl=isTtl;
			model.isMonitor=isMonitor;
			model.isGroupID=isGroupID;
			model.Remark=Remark;

			DNSABC.BLL.DNSABC_ProductModelDns bll=new DNSABC.BLL.DNSABC_ProductModelDns();
			bll.Add(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
