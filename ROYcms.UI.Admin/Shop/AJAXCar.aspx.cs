using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.MyShop
{
    /// <summary>
    /// 生成购物车
    /// </summary>
    public partial class AJAXCar : System.Web.UI.Page
    {
        /// <summary>
        /// 购物车操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            int T = ROYcms.Common.Request.GetQueryInt("T");//0添加，1编辑 2删除
            string Id = ROYcms.Common.Request.GetQueryString("Id");
            string Num = ROYcms.Common.Request.GetQueryString("Num");
            if (T == 1)
            {
                ROYcms.Common.ShopCooksCar.UpdateShoppingCar(Id, Num);//更改产品的数量
            }
            else if (T == 0)
            { 
                  ROYcms.Common.ShopCooksCar.AddShoppingCar(Num, Id, 30);//添加商品到购物车
            }
            else if (T == 2)
            {
                ROYcms.Common.ShopCooksCar.RemoveShoppingCar(Id); //删除产品
            }
            Response.ContentType = "text/plain";
            Response.Write(1);
        }
    }
}