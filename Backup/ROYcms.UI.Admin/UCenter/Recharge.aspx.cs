using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.UCenter
{
    public partial class Recharge : System.Web.UI.Page
    {
        public ROYcms.Sys.BLL.ROYcms_UserInfo BLL = new Sys.BLL.ROYcms_UserInfo();
        public ROYcms.Sys.Model.ROYcms_UserInfo Model = new Sys.Model.ROYcms_UserInfo();
        public ROYcms.Sys.BLL.ROYcms_Payment PaymentBLL = new Sys.BLL.ROYcms_Payment();
        public ROYcms.Sys.BLL.ROYcms_Invoice InvoiceBLL = new Sys.BLL.ROYcms_Invoice();
        protected void Page_Load(object sender, EventArgs e)
        {
            Model = BLL.GetModel(Convert.ToInt32(ROYcms.Common.Session.Get("user_id")));
            Bind();
        }
        /// <summary>
        /// 
        /// </summary>
        public void Bind()
        {
            Repeater_admin.DataSource = PaymentBLL.GetList("UserID=" + ROYcms.Common.Session.Get("user_id"));
            Repeater_admin.DataBind();


            Repeater_AdminInvoice.DataSource = InvoiceBLL.GetList("UserID=" + ROYcms.Common.Session.Get("user_id"));
            Repeater_AdminInvoice.DataBind();
        }
    }
}