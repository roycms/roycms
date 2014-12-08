using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ROYcms.Common;

namespace ROYcms.UI
{
    public partial class Zyewu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
              
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string strErr = "";
        
            if (this.txtName.Text.Trim().Length == 0)
            {
                strErr += "姓名不能为空！\\n";
            }
            if (this.txtaddress.Text.Trim().Length == 0)
            {
                strErr += "地址不能为空！\\n";
            }
            if (this.txtsId.Text.Trim().Length == 0)
            {
                strErr += "证件号码不能为空！\\n";
            }
            if (this.txttel.Text.Trim().Length == 0)
            {
                strErr += "tel不能为空！\\n";
            }

            if (!PageValidate.IsNumber(txtnum.Text))
            {
                strErr += "装表的数量格式错误！\\n";
            }
         


            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            int UserId = Convert.ToInt32(ROYcms.Common.Session.Get("User_id") == null ? "0" : ROYcms.Common.Session.Get("User_id"));
            string Name = this.txtName.Text;
            string address = this.txtaddress.Text;
            string sId = this.txtsId.Text;
            string tel = this.txttel.Text;
            string phone = this.txtphone.Text;
            string email = this.txtemail.Text;
            string qq = this.txtqq.Text;
            int num = int.Parse(this.txtnum.Text);
            string Reason = this.txtReason.Text;
            string Remark = this.txtRemark.Text;
            
            int State = 0;
          

            ROYcms.Model.ZS_baozhuang model = new ROYcms.Model.ZS_baozhuang();
            model.UserId = UserId;
            model.Name = Name;
            model.address = address;
            model.sId = sId;
            model.tel = tel;
            model.phone = phone;
            model.email = email;
            model.qq = qq;
            model.num = num;
            model.Reason = Reason;
            model.Remark = Remark;
            model.State = State;
            model.GreateTime = DateTime.Now;
            model.UId = 0;
            model.AdminRemark = "";

            ROYcms.BLL.ZS_baozhuang bll = new ROYcms.BLL.ZS_baozhuang();
            if (bll.Add(model) > 0)
            {
                ROYcms.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "/zyewu.aspx");
            }
            else { ROYcms.Common.MessageBox.ShowAndRedirect(this, "申请失败！", "/zyewu.aspx"); }
        }

        protected void btnSave2_Click(object sender, EventArgs e)
        {

            if (ROYcms.Common.Session.Get("User_id") == null)
            {
                ROYcms.Common.MessageBox.ShowAndRedirect(this, "请先登录！", "/login.html");
            }

            string strErr = "";
        
            if (this.txtBankAccount.Text.Trim().Length == 0)
            {
                strErr += "开户行不能为空！\\n";
            }
            if (this.txtBankName.Text.Trim().Length == 0)
            {
                strErr += "开户名不能为空！\\n";
            }
            if (this.txtAccount.Text.Trim().Length == 0)
            {
                strErr += "账户不能为空！\\n";
            }
            if (this.txtsId2.Text.Trim().Length == 0)
            {
                strErr += "身份证号不能为空！\\n";
            }
            if (this.txtContact.Text.Trim().Length == 0)
            {
                strErr += "联系人不能为空！\\n";
            }
            if (this.txtTel2.Text.Trim().Length == 0)
            {
                strErr += "Tel不能为空！\\n";
            }
           
       
            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            int UserId = Convert.ToInt32(ROYcms.Common.Session.Get("User_id") == null ? "0" : ROYcms.Common.Session.Get("User_id"));
            string BankAccount = this.txtBankAccount.Text;
            string BankName = this.txtBankName.Text;
            string Account = this.txtAccount.Text;
            string sId = this.txtsId2.Text;
            string Contact = this.txtContact.Text;
            string Tel = this.txtTel2.Text;
            string pic = this.txtpic.Text;
            string pic2 = this.txtpic.Text;
            DateTime GreateTime = DateTime.Now;
            int State = 0;
            int UId = 0;
            string AdminRemark = "";

            ROYcms.Model.ZS_qianyue model = new ROYcms.Model.ZS_qianyue();
            model.UserId = UserId;
            model.BankAccount = BankAccount;
            model.BankName = BankName;
            model.Account = Account;
            model.sId = sId;
            model.Contact = Contact;
            model.Tel = Tel;
            model.pic = pic;
            model.pic2 = pic2;
            model.GreateTime = GreateTime;
            model.State = State;
            model.UId = UId;
            model.AdminRemark = AdminRemark;

            ROYcms.BLL.ZS_qianyue bll = new ROYcms.BLL.ZS_qianyue();
            if (bll.Add(model) > 0)
            {
                ROYcms.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "/zyewu.aspx");
            }
            else { ROYcms.Common.MessageBox.ShowAndRedirect(this, "申请失败！", "/zyewu.aspx"); }
        }
        protected void btnSave3_Click(object sender, EventArgs e)
        {

            if (ROYcms.Common.Session.Get("User_id") == null)
            {
                ROYcms.Common.MessageBox.ShowAndRedirect(this, "请先登录！", "/login.html");
            }

            string strErr = "";
          
            if (this.txtEmail3.Text.Trim().Length == 0)
            {
                strErr += "Email不能为空！\\n";
            }
            if (this.txtContents3.Text.Trim().Length == 0)
            {
                strErr += "Contents不能为空！\\n";
            }

          

          
          

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            int UserId = Convert.ToInt32(ROYcms.Common.Session.Get("User_id") == null ? "0" : ROYcms.Common.Session.Get("User_id"));
            string Email = this.txtEmail3.Text;
            string Contents = this.txtContents3.Text;
            string Remark = this.txtRemark3.Text;
            DateTime GreateTime = DateTime.Now;
            int State = 0;
            int UId = UserId;
            string AdminRemark = "";

            ROYcms.Model.ZS_zdsq model = new ROYcms.Model.ZS_zdsq();
            model.UserId = UserId;
            model.Email = Email;
            model.Contents = Contents;
            model.Remark = Remark;
            model.GreateTime = GreateTime;
            model.State = State;
            model.UId = UId;
            model.AdminRemark = AdminRemark;



            ROYcms.BLL.ZS_zdsq bll = new ROYcms.BLL.ZS_zdsq();
            if (bll.Add(model) > 0)
            {
                ROYcms.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "/zyewu.aspx");
            }
            else { ROYcms.Common.MessageBox.ShowAndRedirect(this, "申请失败！", "/zyewu.aspx"); }
        }
    }
}