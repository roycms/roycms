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
namespace DNSABC.Web.DNSABC_Messages
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtId.Text))
			{
				strErr+="编号格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMessagesTypeID.Text))
			{
				strErr+="处理类型ID 系统配置参数格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
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
				strErr+="IP地址不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtState.Text))
			{
				strErr+="状态 0为处理中 1为关闭格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateTime.Text))
			{
				strErr+="更新时间格式错误！\\n";	
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
			int Id=int.Parse(this.txtId.Text);
			int MessagesTypeID=int.Parse(this.txtMessagesTypeID.Text);
			int UserID=int.Parse(this.txtUserID.Text);
			string Title=this.txtTitle.Text;
			string Contents=this.txtContents.Text;
			string IP=this.txtIP.Text;
			int State=int.Parse(this.txtState.Text);
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);

			DNSABC.Model.DNSABC_Messages model=new DNSABC.Model.DNSABC_Messages();
			model.Id=Id;
			model.MessagesTypeID=MessagesTypeID;
			model.UserID=UserID;
			model.Title=Title;
			model.Contents=Contents;
			model.IP=IP;
			model.State=State;
			model.UpdateTime=UpdateTime;
			model.CreateTime=CreateTime;

			DNSABC.BLL.DNSABC_Messages bll=new DNSABC.BLL.DNSABC_Messages();
			bll.Add(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
