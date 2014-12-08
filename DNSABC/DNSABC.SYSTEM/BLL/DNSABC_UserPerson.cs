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
	/// 用户联系人表
	/// </summary>
	public partial class DNSABC_UserPerson
	{
		private readonly IDNSABC_UserPerson dal=DataAccess.CreateDNSABC_UserPerson();
		public DNSABC_UserPerson()
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
		public int  Add(DNSABC.Model.DNSABC_UserPerson model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DNSABC.Model.DNSABC_UserPerson model)
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
		public DNSABC.Model.DNSABC_UserPerson GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public DNSABC.Model.DNSABC_UserPerson GetModelByCache(int Id)
		{
			
			string CacheKey = "DNSABC_UserPersonModel-" + Id;
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
			return (DNSABC.Model.DNSABC_UserPerson)objModel;
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
		public List<DNSABC.Model.DNSABC_UserPerson> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DNSABC.Model.DNSABC_UserPerson> DataTableToList(DataTable dt)
		{
			List<DNSABC.Model.DNSABC_UserPerson> modelList = new List<DNSABC.Model.DNSABC_UserPerson>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DNSABC.Model.DNSABC_UserPerson model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new DNSABC.Model.DNSABC_UserPerson();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["UserId"]!=null && dt.Rows[n]["UserId"].ToString()!="")
					{
						model.UserId=int.Parse(dt.Rows[n]["UserId"].ToString());
					}
					if(dt.Rows[n]["Name"]!=null && dt.Rows[n]["Name"].ToString()!="")
					{
					model.Name=dt.Rows[n]["Name"].ToString();
					}
					if(dt.Rows[n]["Position"]!=null && dt.Rows[n]["Position"].ToString()!="")
					{
					model.Position=dt.Rows[n]["Position"].ToString();
					}
					if(dt.Rows[n]["Mobil"]!=null && dt.Rows[n]["Mobil"].ToString()!="")
					{
					model.Mobil=dt.Rows[n]["Mobil"].ToString();
					}
					if(dt.Rows[n]["Tel"]!=null && dt.Rows[n]["Tel"].ToString()!="")
					{
					model.Tel=dt.Rows[n]["Tel"].ToString();
					}
					if(dt.Rows[n]["Qq"]!=null && dt.Rows[n]["Qq"].ToString()!="")
					{
						model.Qq=int.Parse(dt.Rows[n]["Qq"].ToString());
					}
					if(dt.Rows[n]["Email"]!=null && dt.Rows[n]["Email"].ToString()!="")
					{
					model.Email=dt.Rows[n]["Email"].ToString();
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
		///</summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //    return dal.GetList(PageSize,PageIndex,strWhere);
        //}

		#endregion  Method
	}
}

