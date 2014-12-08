using System;
using System.Data;
namespace DNSABC.IDAL
{
	/// <summary>
	/// 接口层用户信息 用户表 R
	/// </summary>
	public interface IROYcms_user
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int bh);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(DNSABC.Model.ROYcms_user model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(DNSABC.Model.ROYcms_user model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int bh);
		bool DeleteList(string bhlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		DNSABC.Model.ROYcms_user GetModel(int bh);
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
