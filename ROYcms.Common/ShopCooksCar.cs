using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Web;

namespace ROYcms.Common
{
    public class ShopCooksCar
    {

        #region 添加到购物车AddShoppingCar
        /// <summary>
        /// 添加到购物车AddShoppingCar
        /// </summary>
        /// <param name="num">数量 如果存在产品 负数是减少 
        /// 正数是增加  如果不存在  直接增加</param>
        /// <param name="id">货物ID</param>
        /// <param name="expires">cookies保存的天数</param>
        /// <remarks>这里的方法就是把在原有的Cookie基础上判断是否有
        /// 这个产品 如果有 在原有数量上增加 没有 就直接增加 如果是负
        /// 数 就是减少 如果负数的数量大于等于
        /// 原有数量 设置为0 对应后面的读出操作</remarks>
        public static void AddShoppingCar(string num, string id, int expires)
        {
            if (System.Web.HttpContext.Current.Request.Cookies["Products"] != null)
            {
                System.Web.HttpCookie cookie;
                string cookievalue = System.Web.HttpContext.Current.Request.Cookies["Products"].Value;
                if (System.Web.HttpContext.Current.Request.Cookies["Products"].Values[id.ToString()] == null)
                {
                    cookievalue = cookievalue + "&" + id + "=" + num;

                }
                else
                {
                    int num1 = int.Parse(System.Web.HttpContext.Current.Request.Cookies["Products"].Values[id.ToString()].ToString()) + int.Parse(num);
                    if (num1 > 0)
                    {
                        System.Web.HttpContext.Current.Request.Cookies["Products"].Values[id.ToString()] = num1.ToString();
                    }
                    else
                    {
                        System.Web.HttpContext.Current.Request.Cookies["Products"].Values[id.ToString()] = "0";
                    }
                    cookievalue = System.Web.HttpContext.Current.Request.Cookies["Products"].Value;
                }
                cookie = new System.Web.HttpCookie("Products", cookievalue);
                if (expires != 0)
                {
                    DateTime dt = DateTime.Now;
                    TimeSpan ts = new TimeSpan(expires, 0, 0, 20);
                    cookie.Expires = dt.Add(ts);
                }
                System.Web.HttpContext.Current.Response.AppendCookie(cookie);
            }
            else
            {
                System.Web.HttpCookie newcookie = new HttpCookie("Products");
                if (expires != 0)
                {
                    DateTime dt = DateTime.Now;
                    TimeSpan ts = new TimeSpan(expires, 0, 0, 20);
                    newcookie.Expires = dt.Add(ts);
                }
                newcookie.Values[id.ToString()] = num;
                System.Web.HttpContext.Current.Response.AppendCookie(newcookie);
            }
        }
        #endregion

        #region 添加到购物车AddShoppingCar
        /// <summary>
        /// 添加到购物车AddShoppingCar
        /// </summary>
        /// <param name="num">数量 如果存在产品 负数是减少 
        /// 正数是增加  如果不存在  直接增加</param>
        /// <param name="dt">
        /// 循环读出来的DATATABLE
        /// </param>
        /// <param name="id">货物ID</param>
        /// <param name="expires">cookies保存的天数</param>
        /// <remarks>这里的方法就是把在原有的Cookie基础上判断是否有
        /// 这个产品 如果有 在原有数量上增加 没有 就直接增加 如果是负
        /// 数 就是减少 如果负数的数量大于等于
        /// 原有数量 设置为0 对应后面的读出操作</remarks>
        public static void AddShoppingCar(DataTable dt, int expires)
        {

            if (System.Web.HttpContext.Current.Request.Cookies["Products"] != null)
            {
                System.Web.HttpCookie cookie;
                string cookievalue = System.Web.HttpContext.Current.Request.Cookies["Products"].Value;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (System.Web.HttpContext.Current.Request.Cookies["Products"].Values[dt.Rows[i]["id"].ToString().ToString()] == null)
                    {
                        cookievalue = cookievalue + "&" + dt.Rows[i]["id"].ToString() + "=" + dt.Rows[i]["num"].ToString();
                    }
                    else
                    {
                        int num1 = int.Parse(System.Web.HttpContext.Current.Request.Cookies["Products"].Values[dt.Rows[i]["id"].ToString().ToString()].ToString()) + int.Parse(dt.Rows[i]["num"].ToString());
                        if (num1 > 0)
                        {
                            System.Web.HttpContext.Current.Request.Cookies["Products"].Values[dt.Rows[i]["id"].ToString().ToString()] = num1.ToString();
                        }
                        else
                        {
                            System.Web.HttpContext.Current.Request.Cookies["Products"].Values[dt.Rows[i]["id"].ToString().ToString()] = "0";
                        }
                        cookievalue = System.Web.HttpContext.Current.Request.Cookies["Products"].Value;
                    }
                }
                cookie = new System.Web.HttpCookie("Products", cookievalue);
                if (expires != 0)
                {
                    DateTime time1 = DateTime.Now;
                    TimeSpan ts = new TimeSpan(expires, 0, 0, 20);
                    cookie.Expires = time1.Add(ts);
                }
                System.Web.HttpContext.Current.Response.AppendCookie(cookie);
            }
            else
            {
                System.Web.HttpCookie newcookie = new HttpCookie("Products");
                if (expires != 0)
                {
                    DateTime time1 = DateTime.Now;
                    TimeSpan ts = new TimeSpan(expires, 0, 0, 20);
                    newcookie.Expires = time1.Add(ts);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    newcookie.Values[dt.Rows[i]["id"].ToString()] = dt.Rows[i]["num"].ToString();
                }
                System.Web.HttpContext.Current.Response.AppendCookie(newcookie);
            }

        }
        #endregion

        #region 根据ID删除产品RemoveShoppingCar
        /// <summary>
        /// 根据ID删除产品RemoveShoppingCar
        /// </summary>
        /// <param name="id">产品ID</param>
        /// <remarks>
        /// 就是设置商品数量为0
        /// 本来增加方法可以实现
        /// 但是需要读出来原有数量
        /// 所以为了避免繁琐 有此方法
        /// </remarks>
        public static void RemoveShoppingCar(string id)
        {
            if (System.Web.HttpContext.Current.Request.Cookies["Products"] != null && System.Web.HttpContext.Current.Request.Cookies["Products"].Values[id] != null)
            {
                System.Web.HttpCookie cookie;
                System.Web.HttpContext.Current.Request.Cookies["Products"].Values[id] = "0";
                string cookievalue = System.Web.HttpContext.Current.Request.Cookies["Products"].Value;
                cookie = new System.Web.HttpCookie("Products", cookievalue);
                System.Web.HttpContext.Current.Response.AppendCookie(cookie);
            }
        }
        #endregion

        #region 删除购物车RemoveShoppingCar
        /// <summary>
        /// 删除购物车RemoveShoppingCar
        /// </summary>
        /// <remarks>
        /// 使购物车的Cookie为空
        /// </remarks>
        public static void RemoveShoppingCar()
        {
            if (System.Web.HttpContext.Current.Request.Cookies["Products"] != null && System.Web.HttpContext.Current.Request.Cookies["Products"].Values.Count != 0)
            {
                System.Web.HttpContext.Current.Request.Cookies["Products"].Expires = System.DateTime.Now.AddHours(-1);
                System.Web.HttpContext.Current.Response.AppendCookie(System.Web.HttpContext.Current.Request.Cookies["Products"]);
            }
        }
        #endregion

        #region 根据ID修改产品UpdateShoppingCar
        /// <summary>
        /// 根据ID修改产品UpdateShoppingCar
        /// </summary>
        /// <param name="id">产品ID</param>
        /// <param name="num">产品数量</param>
        /// <remarks>
        /// 更新产品的数量
        /// </remarks>
        public static void UpdateShoppingCar(string id, string num)
        {
            if (System.Web.HttpContext.Current.Request.Cookies["Products"] != null && System.Web.HttpContext.Current.Request.Cookies["Products"].Values[id] != null)
            {
                System.Web.HttpCookie cookie;
                System.Web.HttpContext.Current.Request.Cookies["Products"].Values[id] = num;
                string cookievalue = System.Web.HttpContext.Current.Request.Cookies["Products"].Value;
                cookie = new System.Web.HttpCookie("Products", cookievalue);
                System.Web.HttpContext.Current.Response.AppendCookie(cookie);
            }
        }
        #endregion
        /// <summary>
        /// 得到所有的产品列表GetAllChoppingCar
        /// </summary>
        /// <returns></returns>
        public static DataSet GetCar()
        {
            DataSet dataSet = new DataSet();
            if (GetAllChoppingCar() != null)
            {
                dataSet.Tables.Add(GetAllChoppingCar());
            }
            else { dataSet.Tables.Add(); }
            return dataSet;
        }
        /// <summary>
        /// 获取购物车产品数量
        /// </summary>
        /// <returns></returns>
        public static int GetProductCon()
        {
            if (GetAllChoppingCar() == null)
            {
                return 0; 
            }
            else { return GetAllChoppingCar().Rows.Count;}
        }

        #region 得到所有的产品列表GetAllChoppingCar
        /// <summary>
        /// 得到所有的产品列表GetAllChoppingCar
        /// </summary>
        /// <returns>所有产品的数据集</returns>
        /// <remarks>因为对DataTable操作比较方便(个人喜好)
        /// 这里是把里面的字符串分割为Datatable</remarks>
        public static DataTable GetAllChoppingCar()
        {
            if (System.Web.HttpContext.Current.Request.Cookies["Products"] != null && System.Web.HttpContext.Current.Request.Cookies["Products"].Value.Trim() != "")
            {
                DataColumn dcid = new DataColumn("id");
                DataColumn dcnum = new DataColumn("num");
                DataTable dt = new DataTable();
                dt.Columns.Add(dcid);
                dt.Columns.Add(dcnum);
                string[] str = System.Web.HttpContext.Current.Request.Cookies["Products"].Value.Split('&');
                for (int i = 0; i < str.Length; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["id"] = (str[i].Split('='))[0].ToString();
                    dr["num"] = (str[i].Split('='))[1].ToString();
                    if (int.Parse((str[i].Split('='))[1].ToString()) != 0)
                    {
                        dt.Rows.Add(dr);
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region 关于购物车Cookie里的DataTable的操作GetCookieByDataTable
        /// <summary>
        /// 关于购物车Cookie里的DataTable的操作GetCookieByDataTable
        /// </summary>
        /// <param name="dt"></param>
        /// <remarks>
        /// 把读出来的DataTable转换为字符串
        /// 根据的规则是自己定的 &符号是分开产品
        /// =号是分开产品ID和产品价格
        /// </remarks>
        /// <returns></returns>
        public static String GetCookieByDataTable(DataTable dt)
        {
            String datatable = "";
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    datatable = dt.Rows[i]["id"].ToString() + "=" + dt.Rows[i]["num"].ToString() + "&" + datatable;
                }
            }
            return datatable;
        }
        #endregion

        #region 把字符串转换为datatable  GetDataTable
        /// <summary>
        /// 把字符串转换为datatable  GetDataTable
        /// </summary>
        /// <param name="datatable"></param>
        /// <remarks>
        /// 把Cookie里的字符串转换为DataTable
        /// 是GetCookieByDataTable的反操作
        /// </remarks>
        /// <returns></returns>
        public static DataTable GetDataTable(string datatable)
        {
            DataColumn dcid = new DataColumn("id");
            DataColumn dcnum = new DataColumn("num");
            DataTable dt = new DataTable();
            dt.Columns.Add(dcid);
            dt.Columns.Add(dcnum);
            if (!datatable.StartsWith("&"))
            {
                string[] str = datatable.Split('&');
                for (int i = 0; i < str.Length; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["id"] = (str[i].Split('='))[0].ToString();
                    dr["num"] = (str[i].Split('='))[1].ToString();
                    if (int.Parse((str[i].Split('='))[1].ToString()) != 0)
                    {
                        dt.Rows.Add(dr);
                    }
                }
            }
            else
            {
                DataRow dr = dt.NewRow();
                dr["id"] = (datatable.Split('='))[0].ToString();
                dr["num"] = (datatable.Split('='))[1].ToString();
                if (int.Parse((datatable.Split('='))[1].ToString()) != 0)
                {
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
        #endregion
    }
}
