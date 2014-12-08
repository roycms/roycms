using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
    /// <summary>
    /// 订单表
    /// </summary>
    public partial class ROYcms_Goods_Order
    {
        private readonly ROYcms.Sys.DAL.ROYcms_Goods_Order dal = new ROYcms.Sys.DAL.ROYcms_Goods_Order();
        public ROYcms_Goods_Order()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            return dal.Exists(Id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_Goods_Order model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_(ROYcms.Sys.Model.ROYcms_Goods_Order model)
        {
            return dal.Update_(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ROYcms.Sys.Model.ROYcms_Goods_Order model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 获取订单状态
        /// </summary>
        /// <param name="Status">状态码</param>
        /// <param name="T">0订单状态1支付状态2配送状态</param>
        /// <returns>中文状态描述</returns>
        public string GetOrderStatus(int Status, int T)
        {
            string Mex = null;
            if (T == 0) //订单状态
            {
                //订单状态。0，未确认；1，已确认；2，已取消；3，无效；4，退货；,
                if (Status == 0){ Mex ="未确认"; }
                else if (Status == 1) { Mex = "已确认"; }
                else if (Status == 2) { Mex = "已取消"; }
                else if (Status == 3) { Mex = "无效"; }
                else if (Status == 4) { Mex = "退货"; }
            }
            else if (T == 1) //支付状态
            {
                //支付状态；0，未付款；1，付款中；2，已付款,
                if (Status == 0) { Mex = "未付款"; }
                else if (Status == 1) { Mex = "付款中"; }
                else if (Status == 2) { Mex = "已付款"; }
            }
            else if (T == 2) //配送状态
            {
                //商品配送情况，0，未发货；1，已发货；2，已收货；3，备货中,
                if (Status == 0) { Mex = "未发货"; }
                else if (Status == 1) { Mex = "已发货"; }
                else if (Status == 2) { Mex = "已收货"; }
                else if (Status == 3) { Mex = "备货中"; }
            }
            return Mex;
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {

            return dal.Delete(Id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            return dal.DeleteList(Idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Goods_Order GetModel(int Id)
        {

            return dal.GetModel(Id);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Goods_Order GetModel(string OrderId)
        {

            return dal.GetModel(OrderId);
        }
        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Goods_Order GetModelByCache(int Id)
        {

            string CacheKey = "ROYcms_Goods_OrderModel-" + Id;
            object objModel = ROYcms.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Id);
                    if (objModel != null)
                    {
                        int ModelCache = ROYcms.Common.ConfigHelper.GetConfigInt("ModelCache");
                        ROYcms.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (ROYcms.Sys.Model.ROYcms_Goods_Order)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ROYcms.Sys.Model.ROYcms_Goods_Order> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ROYcms.Sys.Model.ROYcms_Goods_Order> DataTableToList(DataTable dt)
        {
            List<ROYcms.Sys.Model.ROYcms_Goods_Order> modelList = new List<ROYcms.Sys.Model.ROYcms_Goods_Order>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ROYcms.Sys.Model.ROYcms_Goods_Order model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new ROYcms.Sys.Model.ROYcms_Goods_Order();
                    if (dt.Rows[n]["Id"] != null && dt.Rows[n]["Id"].ToString() != "")
                    {
                        model.Id = int.Parse(dt.Rows[n]["Id"].ToString());
                    }
                    if (dt.Rows[n]["order_sn"] != null && dt.Rows[n]["order_sn"].ToString() != "")
                    {
                        model.order_sn = dt.Rows[n]["order_sn"].ToString();
                    }
                    if (dt.Rows[n]["user_id"] != null && dt.Rows[n]["user_id"].ToString() != "")
                    {
                        model.user_id = int.Parse(dt.Rows[n]["user_id"].ToString());
                    }
                    if (dt.Rows[n]["order_status"] != null && dt.Rows[n]["order_status"].ToString() != "")
                    {
                        model.order_status = int.Parse(dt.Rows[n]["order_status"].ToString());
                    }
                    if (dt.Rows[n]["shipping_status"] != null && dt.Rows[n]["shipping_status"].ToString() != "")
                    {
                        model.shipping_status = int.Parse(dt.Rows[n]["shipping_status"].ToString());
                    }
                    if (dt.Rows[n]["pay_status"] != null && dt.Rows[n]["pay_status"].ToString() != "")
                    {
                        model.pay_status = int.Parse(dt.Rows[n]["pay_status"].ToString());
                    }
                    if (dt.Rows[n]["consignee"] != null && dt.Rows[n]["consignee"].ToString() != "")
                    {
                        model.consignee = dt.Rows[n]["consignee"].ToString();
                    }
                    if (dt.Rows[n]["country"] != null && dt.Rows[n]["country"].ToString() != "")
                    {
                        model.country = dt.Rows[n]["country"].ToString();
                    }
                    if (dt.Rows[n]["province"] != null && dt.Rows[n]["province"].ToString() != "")
                    {
                        model.province = dt.Rows[n]["province"].ToString();
                    }
                    if (dt.Rows[n]["city"] != null && dt.Rows[n]["city"].ToString() != "")
                    {
                        model.city = dt.Rows[n]["city"].ToString();
                    }
                    if (dt.Rows[n]["district"] != null && dt.Rows[n]["district"].ToString() != "")
                    {
                        model.district = dt.Rows[n]["district"].ToString();
                    }
                    if (dt.Rows[n]["address"] != null && dt.Rows[n]["address"].ToString() != "")
                    {
                        model.address = dt.Rows[n]["address"].ToString();
                    }
                    if (dt.Rows[n]["zipcode"] != null && dt.Rows[n]["zipcode"].ToString() != "")
                    {
                        model.zipcode = dt.Rows[n]["zipcode"].ToString();
                    }
                    if (dt.Rows[n]["tel"] != null && dt.Rows[n]["tel"].ToString() != "")
                    {
                        model.tel = dt.Rows[n]["tel"].ToString();
                    }
                    if (dt.Rows[n]["mobile"] != null && dt.Rows[n]["mobile"].ToString() != "")
                    {
                        model.mobile = dt.Rows[n]["mobile"].ToString();
                    }
                    if (dt.Rows[n]["email"] != null && dt.Rows[n]["email"].ToString() != "")
                    {
                        model.email = dt.Rows[n]["email"].ToString();
                    }
                    if (dt.Rows[n]["best_time"] != null && dt.Rows[n]["best_time"].ToString() != "")
                    {
                        model.best_time = int.Parse(dt.Rows[n]["best_time"].ToString());
                    }
                    if (dt.Rows[n]["sign_building"] != null && dt.Rows[n]["sign_building"].ToString() != "")
                    {
                        model.sign_building = dt.Rows[n]["sign_building"].ToString();
                    }
                    if (dt.Rows[n]["postscript"] != null && dt.Rows[n]["postscript"].ToString() != "")
                    {
                        model.postscript = dt.Rows[n]["postscript"].ToString();
                    }
                    if (dt.Rows[n]["shipping_id"] != null && dt.Rows[n]["shipping_id"].ToString() != "")
                    {
                        model.shipping_id = int.Parse(dt.Rows[n]["shipping_id"].ToString());
                    }
                    if (dt.Rows[n]["shipping_name"] != null && dt.Rows[n]["shipping_name"].ToString() != "")
                    {
                        model.shipping_name = dt.Rows[n]["shipping_name"].ToString();
                    }
                    if (dt.Rows[n]["pay_id"] != null && dt.Rows[n]["pay_id"].ToString() != "")
                    {
                        model.pay_id = int.Parse(dt.Rows[n]["pay_id"].ToString());
                    }
                    if (dt.Rows[n]["pay_name"] != null && dt.Rows[n]["pay_name"].ToString() != "")
                    {
                        model.pay_name = dt.Rows[n]["pay_name"].ToString();
                    }
                    if (dt.Rows[n]["how_oos"] != null && dt.Rows[n]["how_oos"].ToString() != "")
                    {
                        model.how_oos = int.Parse(dt.Rows[n]["how_oos"].ToString());
                    }
                    if (dt.Rows[n]["how_surplus"] != null && dt.Rows[n]["how_surplus"].ToString() != "")
                    {
                        model.how_surplus = int.Parse(dt.Rows[n]["how_surplus"].ToString());
                    }
                    if (dt.Rows[n]["pack_name"] != null && dt.Rows[n]["pack_name"].ToString() != "")
                    {
                        model.pack_name = dt.Rows[n]["pack_name"].ToString();
                    }
                    if (dt.Rows[n]["card_name"] != null && dt.Rows[n]["card_name"].ToString() != "")
                    {
                        model.card_name = dt.Rows[n]["card_name"].ToString();
                    }
                    if (dt.Rows[n]["card_message"] != null && dt.Rows[n]["card_message"].ToString() != "")
                    {
                        model.card_message = dt.Rows[n]["card_message"].ToString();
                    }
                    if (dt.Rows[n]["inv_payee"] != null && dt.Rows[n]["inv_payee"].ToString() != "")
                    {
                        model.inv_payee = dt.Rows[n]["inv_payee"].ToString();
                    }
                    if (dt.Rows[n]["inv_content"] != null && dt.Rows[n]["inv_content"].ToString() != "")
                    {
                        model.inv_content = dt.Rows[n]["inv_content"].ToString();
                    }
                    if (dt.Rows[n]["goods_amount"] != null && dt.Rows[n]["goods_amount"].ToString() != "")
                    {
                        model.goods_amount = int.Parse(dt.Rows[n]["goods_amount"].ToString());
                    }
                    if (dt.Rows[n]["shipping_fee"] != null && dt.Rows[n]["shipping_fee"].ToString() != "")
                    {
                        model.shipping_fee = dt.Rows[n]["shipping_fee"].ToString();
                    }
                    if (dt.Rows[n]["insure_fee"] != null && dt.Rows[n]["insure_fee"].ToString() != "")
                    {
                        model.insure_fee = int.Parse(dt.Rows[n]["insure_fee"].ToString());
                    }
                    if (dt.Rows[n]["pay_fee"] != null && dt.Rows[n]["pay_fee"].ToString() != "")
                    {
                        model.pay_fee = dt.Rows[n]["pay_fee"].ToString();
                    }
                    if (dt.Rows[n]["pack_fee"] != null && dt.Rows[n]["pack_fee"].ToString() != "")
                    {
                        model.pack_fee = dt.Rows[n]["pack_fee"].ToString();
                    }
                    if (dt.Rows[n]["card_fee"] != null && dt.Rows[n]["card_fee"].ToString() != "")
                    {
                        model.card_fee = dt.Rows[n]["card_fee"].ToString();
                    }
                    if (dt.Rows[n]["money_paid"] != null && dt.Rows[n]["money_paid"].ToString() != "")
                    {
                        model.money_paid = int.Parse(dt.Rows[n]["money_paid"].ToString());
                    }
                    if (dt.Rows[n]["surplus"] != null && dt.Rows[n]["surplus"].ToString() != "")
                    {
                        model.surplus = dt.Rows[n]["surplus"].ToString();
                    }
                    if (dt.Rows[n]["Integeregral"] != null && dt.Rows[n]["Integeregral"].ToString() != "")
                    {
                        model.Integeregral = int.Parse(dt.Rows[n]["Integeregral"].ToString());
                    }
                    if (dt.Rows[n]["Integeregral_money"] != null && dt.Rows[n]["Integeregral_money"].ToString() != "")
                    {
                        model.Integeregral_money = int.Parse(dt.Rows[n]["Integeregral_money"].ToString());
                    }
                    if (dt.Rows[n]["bonus"] != null && dt.Rows[n]["bonus"].ToString() != "")
                    {
                        model.bonus = int.Parse(dt.Rows[n]["bonus"].ToString());
                    }
                    if (dt.Rows[n]["order_amount"] != null && dt.Rows[n]["order_amount"].ToString() != "")
                    {
                        model.order_amount = int.Parse(dt.Rows[n]["order_amount"].ToString());
                    }
                    if (dt.Rows[n]["from_ad"] != null && dt.Rows[n]["from_ad"].ToString() != "")
                    {
                        model.from_ad = int.Parse(dt.Rows[n]["from_ad"].ToString());
                    }
                    if (dt.Rows[n]["referer"] != null && dt.Rows[n]["referer"].ToString() != "")
                    {
                        model.referer = dt.Rows[n]["referer"].ToString();
                    }
                    if (dt.Rows[n]["add_time"] != null && dt.Rows[n]["add_time"].ToString() != "")
                    {
                        model.add_time = DateTime.Parse(dt.Rows[n]["add_time"].ToString());
                    }
                    if (dt.Rows[n]["confirm_time"] != null && dt.Rows[n]["confirm_time"].ToString() != "")
                    {
                        model.confirm_time = DateTime.Parse(dt.Rows[n]["confirm_time"].ToString());
                    }
                    if (dt.Rows[n]["pay_time"] != null && dt.Rows[n]["pay_time"].ToString() != "")
                    {
                        model.pay_time = DateTime.Parse(dt.Rows[n]["pay_time"].ToString());
                    }
                    if (dt.Rows[n]["shipping_time"] != null && dt.Rows[n]["shipping_time"].ToString() != "")
                    {
                        model.shipping_time = DateTime.Parse(dt.Rows[n]["shipping_time"].ToString());
                    }
                    if (dt.Rows[n]["pack_id"] != null && dt.Rows[n]["pack_id"].ToString() != "")
                    {
                        model.pack_id = int.Parse(dt.Rows[n]["pack_id"].ToString());
                    }
                    if (dt.Rows[n]["card_id"] != null && dt.Rows[n]["card_id"].ToString() != "")
                    {
                        model.card_id = int.Parse(dt.Rows[n]["card_id"].ToString());
                    }
                    if (dt.Rows[n]["bonus_id"] != null && dt.Rows[n]["bonus_id"].ToString() != "")
                    {
                        model.bonus_id = int.Parse(dt.Rows[n]["bonus_id"].ToString());
                    }
                    if (dt.Rows[n]["invoice_no"] != null && dt.Rows[n]["invoice_no"].ToString() != "")
                    {
                        model.invoice_no = dt.Rows[n]["invoice_no"].ToString();
                    }
                    if (dt.Rows[n]["extension_code"] != null && dt.Rows[n]["extension_code"].ToString() != "")
                    {
                        model.extension_code = int.Parse(dt.Rows[n]["extension_code"].ToString());
                    }
                    if (dt.Rows[n]["extension_id"] != null && dt.Rows[n]["extension_id"].ToString() != "")
                    {
                        model.extension_id = int.Parse(dt.Rows[n]["extension_id"].ToString());
                    }
                    if (dt.Rows[n]["to_buyer"] != null && dt.Rows[n]["to_buyer"].ToString() != "")
                    {
                        model.to_buyer = dt.Rows[n]["to_buyer"].ToString();
                    }
                    if (dt.Rows[n]["pay_note"] != null && dt.Rows[n]["pay_note"].ToString() != "")
                    {
                        model.pay_note = dt.Rows[n]["pay_note"].ToString();
                    }
                    if (dt.Rows[n]["agency_id"] != null && dt.Rows[n]["agency_id"].ToString() != "")
                    {
                        model.agency_id = int.Parse(dt.Rows[n]["agency_id"].ToString());
                    }
                    if (dt.Rows[n]["inv_type"] != null && dt.Rows[n]["inv_type"].ToString() != "")
                    {
                        model.inv_type = dt.Rows[n]["inv_type"].ToString();
                    }
                    if (dt.Rows[n]["tax"] != null && dt.Rows[n]["tax"].ToString() != "")
                    {
                        model.tax = dt.Rows[n]["tax"].ToString();
                    }
                    if (dt.Rows[n]["is_separate"] != null && dt.Rows[n]["is_separate"].ToString() != "")
                    {
                        model.is_separate = int.Parse(dt.Rows[n]["is_separate"].ToString());
                    }
                    if (dt.Rows[n]["parent_id"] != null && dt.Rows[n]["parent_id"].ToString() != "")
                    {
                        model.parent_id = int.Parse(dt.Rows[n]["parent_id"].ToString());
                    }
                    if (dt.Rows[n]["discount"] != null && dt.Rows[n]["discount"].ToString() != "")
                    {
                        model.discount = dt.Rows[n]["discount"].ToString();
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere);
        }

        #endregion  Method
    }
}

