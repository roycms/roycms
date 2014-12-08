using System;
using System.Data;
namespace DNSABC.IDAL
{
	/// <summary>
	/// 接口层产品信息表 添加产品的时候需要添加用户等级ID为1的价格信息（0元/月）。删除产品的时候需要删除对应的价格信息和产品扩展信息。添加产品的时候需要添加对应类型的产品扩展信息。删除产品的时候
	/// </summary>
	public interface IDNSABC_ProductInfo
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int Id);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(DNSABC.Model.DNSABC_ProductInfo model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(DNSABC.Model.DNSABC_ProductInfo model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int Id);
		bool DeleteList(string Idlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		DNSABC.Model.DNSABC_ProductInfo GetModel(int Id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
	} 
}
