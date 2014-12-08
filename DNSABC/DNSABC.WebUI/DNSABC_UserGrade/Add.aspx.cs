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
namespace DNSABC.Web.DNSABC_UserGrade
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtGradeName.Text.Trim().Length==0)
			{
				strErr+="等级名称不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtisOrder.Text))
			{
				strErr+="权重格式错误！\\n";	
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
			string GradeName=this.txtGradeName.Text;
			int isOrder=int.Parse(this.txtisOrder.Text);
			string Remark=this.txtRemark.Text;

			DNSABC.Model.DNSABC_UserGrade model=new DNSABC.Model.DNSABC_UserGrade();
			model.GradeName=GradeName;
			model.isOrder=isOrder;
			model.Remark=Remark;

			DNSABC.BLL.DNSABC_UserGrade bll=new DNSABC.BLL.DNSABC_UserGrade();
			bll.Add(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
