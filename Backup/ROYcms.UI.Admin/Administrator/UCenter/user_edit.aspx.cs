using System;
using ROYcms.Common;
using System.IO;
using System.Data;
using System.Web.UI.WebControls;
using System.Xml;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_user_edit_ss : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        ROYcms.Sys.Model.ROYcms_user Model = new ROYcms.Sys.Model.ROYcms_user();

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UGroup_DropDownList_bind();
                ShowInfo(Convert.ToInt32(Request["uid"]));
            }
        }

        /// <summary>
        /// Shows the info.
        /// </summary>
        /// <param name="bh">The bh.</param>
        private void ShowInfo(int bh)
        {
            Model = ___ROYcms_user_bll.GetModel(bh);

            ___ROYcms_user_model = Model;
            this.txtname.Text = ___ROYcms_user_model.name;
            this.txtpassword.Text = ROYcms.Common.DESEncrypt.Decrypt(___ROYcms_user_model.password);
            this.txtpassword2.Text = ROYcms.Common.DESEncrypt.Decrypt(___ROYcms_user_model.password);
            this.txtqq.Text = ___ROYcms_user_model.qq;
            this.txtemail.Text = ___ROYcms_user_model.email;
            this.txtusername.Text = ___ROYcms_user_model.username;
            if (___ROYcms_user_model.UgroupID != null && ___ROYcms_user_model.UgroupID != "")
            {
                try
                {
                    this.UGroup_DropDownList.SelectedValue = ___ROYcms_user_model.UgroupID;
                }
                catch
                {  //删除无效的用户组所属权限
                    ___ROYcms_user_bll.Update(___ROYcms_user_model.UgroupID);
                }
            }

        }
        #region 数据绑定
        /// <summary>
        /// DDLs the menu_bind.
        /// </summary>
        void UGroup_DropDownList_bind()
        {
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_UGroup().GetAllList();

            this.UGroup_DropDownList.Items.Clear();
            this.UGroup_DropDownList.Items.Add(new ListItem("请选择所属分组", ""));
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string Id = dr["id"].ToString().Trim();
                string Name = dr["name"].ToString().Trim();

                this.UGroup_DropDownList.Items.Add(new ListItem(Name, Id));
            }

        }
        #endregion
        /// <summary>
        /// Handles the Click event of the Edit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Edit_Click(object sender, EventArgs e)
        {

            ___ROYcms_user_model = ___ROYcms_user_bll.GetModel(Convert.ToInt32(Request["uid"])); ;//赋值

            string name = this.txtname.Text;
            string password = this.txtpassword.Text;

            string qq = this.txtqq.Text;
            string email = this.txtemail.Text;

            
            string username = this.txtusername.Text;
           
            ___ROYcms_user_model.bh = Convert.ToInt32(Request["uid"]);
           
            ___ROYcms_user_model.name = name;
            ___ROYcms_user_model.password = ROYcms.Common.DESEncrypt.Encrypt(password);
            ___ROYcms_user_model.qq = qq;
            ___ROYcms_user_model.email = email;

            if (this.UGroup_DropDownList.SelectedValue != "")
            {
                ___ROYcms_user_model.UgroupID = this.UGroup_DropDownList.SelectedValue;
            }
           
            ___ROYcms_user_model.username = username;
           
            ___ROYcms_user_bll.Update(___ROYcms_user_model);
           
            Response.Redirect("/administrator/Message.aspx?message=<b>成功！</b>&z=yes");
        }

    }
}