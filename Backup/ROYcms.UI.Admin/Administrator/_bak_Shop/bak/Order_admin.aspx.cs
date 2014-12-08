/**********************************************************************************
 * Description:     
 * MemberVariable:
 * Functions:       
 * Modify information:     
 * 2008-8-5     New           DuYaoHui     Create Class
 * 
 * ********************************************************************************/
using System;
using System.Data;
using System.Web.UI.WebControls;
using ROYcms.Sys.BLL;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_Order_admin : AdminPage
    {
      
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Repeater_admin_bind("id>0 order by id DESC");
                switch (Request["t"])
                {
                    case "del":
                        del(Convert.ToInt32(Request["bh"]));
                        Repeater_admin_bind("id>0 order by id DESC");
                        break;
                    case "pay_yes"://已付款
                        Repeater_admin_bind("order_status=0 order by id DESC");
                        break;
                    case "pay_no"://未付款
                        Repeater_admin_bind("order_status=1 order by id DESC");
                        break;
                    case "consume_yes"://已消费
                        Repeater_admin_bind("order_status=3 order by id DESC");
                        break;
                    case "consume_no"://未消费成功
                        Repeater_admin_bind("order_status=4 order by id DESC");
                        break;
                }
            }
        }
        /// <summary>
        /// Repeater_admin_binds the specified classs.
        /// </summary>
        /// <param name="where">The classs.</param>
        void Repeater_admin_bind(string where)
        {
            ROYcms.Sys.BLL.ROYcms_product_order product_order = new ROYcms.Sys.BLL.ROYcms_product_order();

            Repeater_admin.DataSource = product_order.GetList(where);
            Repeater_admin.DataBind();
            //
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string get_username(int id)
        {
            return new ROYcms.Sys.BLL.ROYcms_user().GetField(id, "name");
        }
        /// <summary>
        /// 作废一条订单
        /// </summary>
        /// <param name="bh"></param>
        void del(int bh)
        {
            new ROYcms.Sys.BLL.ROYcms_product_order().Delete(bh); 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Submit_Click(object sender, EventArgs e)
        {
            Repeater_admin_bind("id>0 and user_id='" + new  ROYcms.Sys.BLL.ROYcms_user().GetField(keywords.Value.Trim(), "bh") + "' order by id DESC");
        }
    }
}