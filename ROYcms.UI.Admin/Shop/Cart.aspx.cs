using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Shop
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Cart : ROYcms.BasePage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            if (ROYcms.Common.ShopCooksCar.GetProductCon() > 0)
            {
                Repeater_Cart.DataSource = ROYcms.Common.ShopCooksCar.GetCar();
                Repeater_Cart.DataBind();
            }
            else {
                Repeater_Cart.DataSource = null;
                Repeater_Cart.DataBind();
            }
        }
    }
}