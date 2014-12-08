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
namespace DNSABC.Web.DNSABC_Dns
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
		DNSABC.BLL.DNSABC_Dns bll=new DNSABC.BLL.DNSABC_Dns();
		DNSABC.Model.DNSABC_Dns model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtProductID.Text=model.ProductID.ToString();
		this.txtUserID.Text=model.UserID.ToString();
		this.txtDomain.Text=model.Domain;
		this.txtPASSWORD.Text=model.PASSWORD;
		this.txtStartTime.Text=model.StartTime.ToString();
		this.txtEndTime.Text=model.EndTime.ToString();
		this.txtisHost.Text=model.isHost.ToString();
		this.txtisTtl.Text=model.isTtl.ToString();
		this.txtisMonitor.Text=model.isMonitor.ToString();
		this.txtisGroupID.Text=model.isGroupID.ToString();
		this.txtState.Text=model.State.ToString();
		this.txtRemark.Text=model.Remark;
		this.txtUpdateTime.Text=model.UpdateTime.ToString();
		this.txtCreateTime.Text=model.CreateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtProductID.Text))
			{
				strErr+="产品ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}
			if(this.txtDomain.Text.Trim().Length==0)
			{
				strErr+="域名 域名是唯一的不能为空！\\n";	
			}
			if(this.txtPASSWORD.Text.Trim().Length==0)
			{
				strErr+="域名密码 随机生成w3e4r2r6r6t4不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtStartTime.Text))
			{
				strErr+="服务开始时间格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtEndTime.Text))
			{
				strErr+="服务结束时间格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisHost.Text))
			{
				strErr+="主机个数 0表示主机个数不限制格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisTtl.Text))
			{
				strErr+="最小TTL值 0表示TTL值不限制格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisMonitor.Text))
			{
				strErr+="宕机检测个数 0表示无宕机检测功能格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisGroupID.Text))
			{
				strErr+="服务器组ID 表示默认开通的服务器组格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtState.Text))
			{
				strErr+="解析状态 0为停用格式错误！\\n";	
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
			int ProductID=int.Parse(this.txtProductID.Text);
			int UserID=int.Parse(this.txtUserID.Text);
			string Domain=this.txtDomain.Text;
			string PASSWORD=this.txtPASSWORD.Text;
			DateTime StartTime=DateTime.Parse(this.txtStartTime.Text);
			DateTime EndTime=DateTime.Parse(this.txtEndTime.Text);
			int isHost=int.Parse(this.txtisHost.Text);
			int isTtl=int.Parse(this.txtisTtl.Text);
			int isMonitor=int.Parse(this.txtisMonitor.Text);
			int isGroupID=int.Parse(this.txtisGroupID.Text);
			int State=int.Parse(this.txtState.Text);
			string Remark=this.txtRemark.Text;
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);


			DNSABC.Model.DNSABC_Dns model=new DNSABC.Model.DNSABC_Dns();
			model.Id=Id;
			model.ProductID=ProductID;
			model.UserID=UserID;
			model.Domain=Domain;
			model.PASSWORD=PASSWORD;
			model.StartTime=StartTime;
			model.EndTime=EndTime;
			model.isHost=isHost;
			model.isTtl=isTtl;
			model.isMonitor=isMonitor;
			model.isGroupID=isGroupID;
			model.State=State;
			model.Remark=Remark;
			model.UpdateTime=UpdateTime;
			model.CreateTime=CreateTime;

			DNSABC.BLL.DNSABC_Dns bll=new DNSABC.BLL.DNSABC_Dns();
			bll.Update(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
