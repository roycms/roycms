using System;
using System.Data;
namespace DNSABC.IDAL
{
	/// <summary>
	/// 接口层View_user
	/// </summary>
	public interface IView_user
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		bool Add(DNSABC.Model.View_user model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(DNSABC.Model.View_user model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete();
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		DNSABC.Model.View_user GetModel();
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
