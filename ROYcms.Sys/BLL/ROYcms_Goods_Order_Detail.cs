using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
    /// <summary>
    /// 订单详情
    /// </summary>
    public partial class ROYcms_Goods_Order_Detail
    {
        private readonly ROYcms.Sys.DAL.ROYcms_Goods_Order_Detail dal = new ROYcms.Sys.DAL.ROYcms_Goods_Order_Detail();
        public ROYcms_Goods_Order_Detail()
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
        public int Add(ROYcms.Sys.Model.ROYcms_Goods_Order_Detail model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ROYcms.Sys.Model.ROYcms_Goods_Order_Detail model)
        {
            return dal.Update(model);
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
        public ROYcms.Sys.Model.ROYcms_Goods_Order_Detail GetModel(int Id)
        {

            return dal.GetModel(Id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Goods_Order_Detail GetModelByCache(int Id)
        {

            string CacheKey = "ROYcms_Goods_Order_DetailModel-" + Id;
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
            return (ROYcms.Sys.Model.ROYcms_Goods_Order_Detail)objModel;
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
        public List<ROYcms.Sys.Model.ROYcms_Goods_Order_Detail> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ROYcms.Sys.Model.ROYcms_Goods_Order_Detail> DataTableToList(DataTable dt)
        {
            List<ROYcms.Sys.Model.ROYcms_Goods_Order_Detail> modelList = new List<ROYcms.Sys.Model.ROYcms_Goods_Order_Detail>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ROYcms.Sys.Model.ROYcms_Goods_Order_Detail model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new ROYcms.Sys.Model.ROYcms_Goods_Order_Detail();
                    if (dt.Rows[n]["Id"] != null && dt.Rows[n]["Id"].ToString() != "")
                    {
                        model.Id = int.Parse(dt.Rows[n]["Id"].ToString());
                    }
                    if (dt.Rows[n]["order_id"] != null && dt.Rows[n]["order_id"].ToString() != "")
                    {
                        model.order_id = dt.Rows[n]["order_id"].ToString();
                    }
                    if (dt.Rows[n]["goods_id"] != null && dt.Rows[n]["goods_id"].ToString() != "")
                    {
                        model.goods_id = int.Parse(dt.Rows[n]["goods_id"].ToString());
                    }
                    if (dt.Rows[n]["goods_name"] != null && dt.Rows[n]["goods_name"].ToString() != "")
                    {
                        model.goods_name = dt.Rows[n]["goods_name"].ToString();
                    }
                    if (dt.Rows[n]["goods_sn"] != null && dt.Rows[n]["goods_sn"].ToString() != "")
                    {
                        model.goods_sn = dt.Rows[n]["goods_sn"].ToString();
                    }
                    if (dt.Rows[n]["goods_number"] != null && dt.Rows[n]["goods_number"].ToString() != "")
                    {
                        model.goods_number = int.Parse(dt.Rows[n]["goods_number"].ToString());
                    }
                    if (dt.Rows[n]["market_price"] != null && dt.Rows[n]["market_price"].ToString() != "")
                    {
                        model.market_price = int.Parse(dt.Rows[n]["market_price"].ToString());
                    }
                    if (dt.Rows[n]["goods_price"] != null && dt.Rows[n]["goods_price"].ToString() != "")
                    {
                        model.goods_price = int.Parse(dt.Rows[n]["goods_price"].ToString());
                    }
                    if (dt.Rows[n]["goods_attr"] != null && dt.Rows[n]["goods_attr"].ToString() != "")
                    {
                        model.goods_attr = dt.Rows[n]["goods_attr"].ToString();
                    }
                    if (dt.Rows[n]["send_number"] != null && dt.Rows[n]["send_number"].ToString() != "")
                    {
                        model.send_number = int.Parse(dt.Rows[n]["send_number"].ToString());
                    }
                    if (dt.Rows[n]["is_real"] != null && dt.Rows[n]["is_real"].ToString() != "")
                    {
                        model.is_real = int.Parse(dt.Rows[n]["is_real"].ToString());
                    }
                    if (dt.Rows[n]["extension_code"] != null && dt.Rows[n]["extension_code"].ToString() != "")
                    {
                        model.extension_code = dt.Rows[n]["extension_code"].ToString();
                    }
                    if (dt.Rows[n]["parent_id"] != null && dt.Rows[n]["parent_id"].ToString() != "")
                    {
                        model.parent_id = int.Parse(dt.Rows[n]["parent_id"].ToString());
                    }
                    if (dt.Rows[n]["is_gift"] != null && dt.Rows[n]["is_gift"].ToString() != "")
                    {
                        model.is_gift = int.Parse(dt.Rows[n]["is_gift"].ToString());
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
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  Method
    }
}

