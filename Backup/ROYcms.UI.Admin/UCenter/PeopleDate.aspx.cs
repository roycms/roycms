using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ROYcms.UI.Admin;
using ROYcms.Common;

namespace ROYcms.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PeopleDate : UserPage
    {
        ROYcms.Sys.BLL.ROYcms_Log LogBLL = new ROYcms.Sys.BLL.ROYcms_Log();
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                Bind();
                ShowInfo(); 
                if (Request["pic"] != null)
                {txtpic.Text = Request["pic"];
                btnUpdate_Click(null, null); ShowInfo();}
            }
        }
        /// <summary>
        /// Shows the info.
        /// </summary>
        private void ShowInfo()
        {
            ___ROYcms_user_model = ___ROYcms_user_bll.GetModel(Convert.ToInt32(ROYcms.Common.Session.Get("user_id")));
            //___ROYcms_user_model = ___ROYcms_user_bll.GetModel(2);

            this.txtqq.Text = ___ROYcms_user_model.qq;
            this.txtemail.Text = ___ROYcms_user_model.email;
            this.txtage.Text = ___ROYcms_user_model.age.ToString();

            this.DropDownList_sex.SelectedValue = ___ROYcms_user_model.sex;
            this.txtpic.Text = ___ROYcms_user_model.pic;
            if (___ROYcms_user_model.pic == null || ___ROYcms_user_model.pic == "")
            {
                this.Photo_pic.ImageUrl = "/UCenter/images/nophoto.gif";
            }
            else { this.Photo_pic.ImageUrl = ___ROYcms_user_model.pic; }
            this.txtusername.Text = ___ROYcms_user_model.username;


        }

        /// <summary>
        /// Handles the Click event of the btnUpdate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        public void btnUpdate_Click(object sender, EventArgs e)
        {
            ___ROYcms_user_model = ___ROYcms_user_bll.GetModel(Convert.ToInt32(ROYcms.Common.Session.Get("user_id")));

        

           
            string qq = this.txtqq.Text;
            string email = this.txtemail.Text;
            int age = int.Parse(this.txtage.Text);
            string sex = this.DropDownList_sex.SelectedValue;
            string pic = this.txtpic.Text;
            string username = this.txtusername.Text;


            ___ROYcms_user_model.qq = qq;
            ___ROYcms_user_model.email = email;
            ___ROYcms_user_model.age = age;

            ___ROYcms_user_model.sex = sex;
            ___ROYcms_user_model.pic = pic;

            ___ROYcms_user_model.username = username;
         

            ___ROYcms_user_bll.Update(___ROYcms_user_model);

        }
        /// <summary>
        /// 
        /// </summary>
        public void Bind()
        {
            Repeater_admin.DataSource = LogBLL.GetList("user_id=" + ROYcms.Common.Session.Get("user_id"));
            Repeater_admin.DataBind();

        }
    }
}
