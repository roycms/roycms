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
namespace DNSABC.Web.DNSABC_MessagesResult
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
		DNSABC.BLL.DNSABC_MessagesResult bll=new DNSABC.BLL.DNSABC_MessagesResult();
		DNSABC.Model.DNSABC_MessagesResult model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtMessagesID.Text=model.MessagesID.ToString();
		this.txtUserID.Text=model.UserID.ToString();
		this.txtAdminID.Text=model.AdminID.ToString();
		this.txtTitle.Text=model.Title;
		this.txtContents.Text=model.Contents;
		this.txtIP.Text=model.IP;
		this.txtCreateTime.Text=model.CreateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMessagesID.Text))
			{
				strErr+="消息ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtAdminID.Text))
			{
				strErr+="【管理员字段】管理员ID格式错误！\\n";	
			}
			if(this.txtTitle.Text.Trim().Length==0)
			{
				strErr+="标题不能为空！\\n";	
			}
			if(this.txtContents.Text.Trim().Length==0)
			{
				strErr+="内容不能为空！\\n";	
			}
			if(this.txtIP.Text.Trim().Length==0)
			{
				strErr+="IP不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateTime.Text))
			{
				strErr+="发布时间格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			int MessagesID=int.Parse(this.txtMessagesID.Text);
			int UserID=int.Parse(this.txtUserID.Text);
			int AdminID=int.Parse(this.txtAdminID.Text);
			string Title=this.txtTitle.Text;
			string Contents=this.txtContents.Text;
			string IP=this.txtIP.Text;
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);


			DNSABC.Model.DNSABC_MessagesResult model=new DNSABC.Model.DNSABC_MessagesResult();
			model.Id=Id;
			model.MessagesID=MessagesID;
			model.UserID=UserID;
			model.AdminID=AdminID;
			model.Title=Title;
			model.Contents=Contents;
			model.IP=IP;
			model.CreateTime=CreateTime;

			DNSABC.BLL.DNSABC_MessagesResult bll=new DNSABC.BLL.DNSABC_MessagesResult();
			bll.Update(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
