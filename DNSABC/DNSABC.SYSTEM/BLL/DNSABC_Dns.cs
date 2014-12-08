using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using DNSABC.Model;
using DNSABC.DALFactory;
using DNSABC.IDAL;
namespace DNSABC.BLL
{
	/// <summary>
	/// 域名业务表 注意：N
	/// </summary>
	public partial class DNSABC_Dns
	{
		private readonly IDNSABC_Dns dal=DataAccess.CreateDNSABC_Dns();
		public DNSABC_Dns()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

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
		public int  Add(DNSABC.Model.DNSABC_Dns model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DNSABC.Model.DNSABC_Dns model)
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
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(Idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DNSABC.Model.DNSABC_Dns GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public DNSABC.Model.DNSABC_Dns GetModelByCache(int Id)
		{
			
			string CacheKey = "DNSABC_DnsModel-" + Id;
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
				catch{}
			}
			return (DNSABC.Model.DNSABC_Dns)objModel;
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
		/// 获得数据列表
		/// </summary>
		public List<DNSABC.Model.DNSABC_Dns> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DNSABC.Model.DNSABC_Dns> DataTableToList(DataTable dt)
		{
			List<DNSABC.Model.DNSABC_Dns> modelList = new List<DNSABC.Model.DNSABC_Dns>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DNSABC.Model.DNSABC_Dns model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new DNSABC.Model.DNSABC_Dns();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["ProductID"]!=null && dt.Rows[n]["ProductID"].ToString()!="")
					{
						model.ProductID=int.Parse(dt.Rows[n]["ProductID"].ToString());
					}
					if(dt.Rows[n]["UserID"]!=null && dt.Rows[n]["UserID"].ToString()!="")
					{
						model.UserID=int.Parse(dt.Rows[n]["UserID"].ToString());
					}
					if(dt.Rows[n]["Domain"]!=null && dt.Rows[n]["Domain"].ToString()!="")
					{
					model.Domain=dt.Rows[n]["Domain"].ToString();
					}
					if(dt.Rows[n]["PASSWORD"]!=null && dt.Rows[n]["PASSWORD"].ToString()!="")
					{
					model.PASSWORD=dt.Rows[n]["PASSWORD"].ToString();
					}
					if(dt.Rows[n]["StarTime"]!=null && dt.Rows[n]["StarTime"].ToString()!="")
					{
						model.StarTime=DateTime.Parse(dt.Rows[n]["StarTime"].ToString());
					}
					if(dt.Rows[n]["EndTime"]!=null && dt.Rows[n]["EndTime"].ToString()!="")
					{
						model.EndTime=DateTime.Parse(dt.Rows[n]["EndTime"].ToString());
					}
					if(dt.Rows[n]["isHost"]!=null && dt.Rows[n]["isHost"].ToString()!="")
					{
						model.isHost=int.Parse(dt.Rows[n]["isHost"].ToString());
					}
					if(dt.Rows[n]["isTtl"]!=null && dt.Rows[n]["isTtl"].ToString()!="")
					{
						model.isTtl=int.Parse(dt.Rows[n]["isTtl"].ToString());
					}
					if(dt.Rows[n]["isMonitor"]!=null && dt.Rows[n]["isMonitor"].ToString()!="")
					{
						model.isMonitor=int.Parse(dt.Rows[n]["isMonitor"].ToString());
					}
					if(dt.Rows[n]["isGroupID"]!=null && dt.Rows[n]["isGroupID"].ToString()!="")
					{
						model.isGroupID=int.Parse(dt.Rows[n]["isGroupID"].ToString());
					}
					if(dt.Rows[n]["State"]!=null && dt.Rows[n]["State"].ToString()!="")
					{
						model.State=int.Parse(dt.Rows[n]["State"].ToString());
					}
					if(dt.Rows[n]["Remark"]!=null && dt.Rows[n]["Remark"].ToString()!="")
					{
					model.Remark=dt.Rows[n]["Remark"].ToString();
					}
					if(dt.Rows[n]["UpdateTime"]!=null && dt.Rows[n]["UpdateTime"].ToString()!="")
					{
						model.UpdateTime=DateTime.Parse(dt.Rows[n]["UpdateTime"].ToString());
					}
					if(dt.Rows[n]["CreateTime"]!=null && dt.Rows[n]["CreateTime"].ToString()!="")
					{
						model.CreateTime=DateTime.Parse(dt.Rows[n]["CreateTime"].ToString());
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
        //public int GetRecordCount(string strWhere)
        //{
        //    return dal.GetRecordCount(strWhere);
        //}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
        //public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        //{
        //    return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
        //}
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

