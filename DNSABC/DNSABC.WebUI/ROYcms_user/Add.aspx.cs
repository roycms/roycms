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
namespace DNSABC.Web.ROYcms_user
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtRoleID.Text.Trim().Length==0)
			{
				strErr+="权限ID不能为空！\\n";	
			}
			if(this.txtUgroupID.Text.Trim().Length==0)
			{
				strErr+="用户组ID不能为空！\\n";	
			}
			if(this.txtName.Text.Trim().Length==0)
			{
				strErr+="用户名不能为空！\\n";	
			}
			if(this.txtPASSWORD.Text.Trim().Length==0)
			{
				strErr+="密码不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtmoney.Text))
			{
				strErr+="积分格式错误！\\n";	
			}
			if(this.txtQq.Text.Trim().Length==0)
			{
				strErr+="QQ不能为空！\\n";	
			}
			if(this.txtEmail.Text.Trim().Length==0)
			{
				strErr+="邮件不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtAge.Text))
			{
				strErr+="年龄格式错误！\\n";	
			}
			if(this.txtsex.Text.Trim().Length==0)
			{
				strErr+="性别不能为空！\\n";	
			}
			if(this.txtPic.Text.Trim().Length==0)
			{
				strErr+="头像不能为空！\\n";	
			}
			if(this.txtQuanxian.Text.Trim().Length==0)
			{
				strErr+="权限不能为空！\\n";	
			}
			if(this.txtUsername.Text.Trim().Length==0)
			{
				strErr+="昵称不能为空！\\n";	
			}
			if(this.txtGuid.Text.Trim().Length==0)
			{
				strErr+="全局ID不能为空！\\n";	
			}
			if(this.txtIp.Text.Trim().Length==0)
			{
				strErr+="IP不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLoginTime.Text))
			{
				strErr+="注册时间格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string RoleID=this.txtRoleID.Text;
			string UgroupID=this.txtUgroupID.Text;
			string Name=this.txtName.Text;
			string PASSWORD=this.txtPASSWORD.Text;
			int money=int.Parse(this.txtmoney.Text);
			string Qq=this.txtQq.Text;
			string Email=this.txtEmail.Text;
			int Age=int.Parse(this.txtAge.Text);
			string sex=this.txtsex.Text;
			string Pic=this.txtPic.Text;
			string Quanxian=this.txtQuanxian.Text;
			string Username=this.txtUsername.Text;
			string Guid=this.txtGuid.Text;
			string Ip=this.txtIp.Text;
			DateTime LoginTime=DateTime.Parse(this.txtLoginTime.Text);

			DNSABC.Model.ROYcms_user model=new DNSABC.Model.ROYcms_user();
			model.RoleID=RoleID;
			model.UgroupID=UgroupID;
			model.Name=Name;
			model.PASSWORD=PASSWORD;
			model.money=money;
			model.Qq=Qq;
			model.Email=Email;
			model.Age=Age;
			model.sex=sex;
			model.Pic=Pic;
			model.Quanxian=Quanxian;
			model.Username=Username;
			model.Guid=Guid;
			model.Ip=Ip;
			model.LoginTime=LoginTime;

			DNSABC.BLL.ROYcms_user bll=new DNSABC.BLL.ROYcms_user();
			bll.Add(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
