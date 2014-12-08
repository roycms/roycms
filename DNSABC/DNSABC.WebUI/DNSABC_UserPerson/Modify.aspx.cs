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
namespace DNSABC.Web.DNSABC_UserPerson
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
		DNSABC.BLL.DNSABC_UserPerson bll=new DNSABC.BLL.DNSABC_UserPerson();
		DNSABC.Model.DNSABC_UserPerson model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtUserId.Text=model.UserId.ToString();
		this.txtName.Text=model.Name;
		this.txtPosition.Text=model.Position;
		this.txtMobil.Text=model.Mobil;
		this.txtTel.Text=model.Tel;
		this.txtQq.Text=model.Qq.ToString();
		this.txtEmail.Text=model.Email;
		this.txtRemark.Text=model.Remark;
		this.txtUpdateTime.Text=model.UpdateTime.ToString();
		this.txtCreateTime.Text=model.CreateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUserId.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}
			if(this.txtName.Text.Trim().Length==0)
			{
				strErr+="姓名不能为空！\\n";	
			}
			if(this.txtPosition.Text.Trim().Length==0)
			{
				strErr+="职位不能为空！\\n";	
			}
			if(this.txtMobil.Text.Trim().Length==0)
			{
				strErr+="手机 必须要有联系人手机号码不能为空！\\n";	
			}
			if(this.txtTel.Text.Trim().Length==0)
			{
				strErr+="电话不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtQq.Text))
			{
				strErr+="QQ号码格式错误！\\n";	
			}
			if(this.txtEmail.Text.Trim().Length==0)
			{
				strErr+="邮箱不能为空！\\n";	
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
			int UserId=int.Parse(this.txtUserId.Text);
			string Name=this.txtName.Text;
			string Position=this.txtPosition.Text;
			string Mobil=this.txtMobil.Text;
			string Tel=this.txtTel.Text;
			int Qq=int.Parse(this.txtQq.Text);
			string Email=this.txtEmail.Text;
			string Remark=this.txtRemark.Text;
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);


			DNSABC.Model.DNSABC_UserPerson model=new DNSABC.Model.DNSABC_UserPerson();
			model.Id=Id;
			model.UserId=UserId;
			model.Name=Name;
			model.Position=Position;
			model.Mobil=Mobil;
			model.Tel=Tel;
			model.Qq=Qq;
			model.Email=Email;
			model.Remark=Remark;
			model.UpdateTime=UpdateTime;
			model.CreateTime=CreateTime;

			DNSABC.BLL.DNSABC_UserPerson bll=new DNSABC.BLL.DNSABC_UserPerson();
			bll.Update(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
