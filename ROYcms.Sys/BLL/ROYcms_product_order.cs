using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// ROYcms_product_order
	/// </summary>
	public partial class ROYcms_product_order
	{
        private readonly ROYcms.Sys.DAL.ROYcms_product_order dal = new ROYcms.Sys.DAL.ROYcms_product_order();
		public ROYcms_product_order()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

		/// <summary>
		/// 增加一条数据 
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_product_order model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_product_order model)
		{
			return dal.Update(model);
		}
        /// <summary>
        /// 获取 单个值  单个字段 通过订单号
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetField(string Id, string Field)
        {
           return GetField(Id, Field);
        }
     
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int id)
		{
			dal.Delete(id);
		}
        /// <summary>
        ///  修改订单状态
        /// </summary>
        public void order_status(string order_id, string order_status)
        {
            dal.order_status(order_id, order_status);
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
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}

        /// <summary>
        /// 返回长查询数据总数 （分页用到）
        /// </summary>
        public int GetCount(string strWhere)
        {
            return dal.GetCount(strWhere);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
        /// <summary>
        /// 修改订单状态
        /// </summary>
        public void GetRecordCount(string order_id, string order_status)
        {
             dal.order_status(order_id, order_status);
        }
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(int PageSize, int PageIndex, string strWhere, int OrderType)
		{
            return dal.GetList(PageSize, PageIndex, strWhere, OrderType);
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

