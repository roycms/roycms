using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// 用户信息扩展表
	/// </summary>
	public partial class ROYcms_UserInfo
	{
		private readonly ROYcms.Sys.DAL.ROYcms_UserInfo dal=new ROYcms.Sys.DAL.ROYcms_UserInfo();
		public ROYcms_UserInfo()
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
		public int  Add(ROYcms.Sys.Model.ROYcms_UserInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_UserInfo model)
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
		public ROYcms.Sys.Model.ROYcms_UserInfo GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_UserInfo GetModelByCache(int Id)
		{
			
			string CacheKey = "ROYcms_UserInfoModel-" + Id;
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
			return (ROYcms.Sys.Model.ROYcms_UserInfo)objModel;
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
		public List<ROYcms.Sys.Model.ROYcms_UserInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_UserInfo> DataTableToList(DataTable dt)
		{
			List<ROYcms.Sys.Model.ROYcms_UserInfo> modelList = new List<ROYcms.Sys.Model.ROYcms_UserInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_UserInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_UserInfo();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["UserId"]!=null && dt.Rows[n]["UserId"].ToString()!="")
					{
						model.UserId=int.Parse(dt.Rows[n]["UserId"].ToString());
					}
					if(dt.Rows[n]["AccountBalance"]!=null && dt.Rows[n]["AccountBalance"].ToString()!="")
					{
						model.AccountBalance=int.Parse(dt.Rows[n]["AccountBalance"].ToString());
					}
					if(dt.Rows[n]["AvilableBalance"]!=null && dt.Rows[n]["AvilableBalance"].ToString()!="")
					{
						model.AvilableBalance=int.Parse(dt.Rows[n]["AvilableBalance"].ToString());
					}
					if(dt.Rows[n]["ConsumedAmount"]!=null && dt.Rows[n]["ConsumedAmount"].ToString()!="")
					{
						model.ConsumedAmount=int.Parse(dt.Rows[n]["ConsumedAmount"].ToString());
					}
					if(dt.Rows[n]["Money"]!=null && dt.Rows[n]["Money"].ToString()!="")
					{
						model.Money=int.Parse(dt.Rows[n]["Money"].ToString());
					}
					if(dt.Rows[n]["GradeID"]!=null && dt.Rows[n]["GradeID"].ToString()!="")
					{
						model.GradeID=int.Parse(dt.Rows[n]["GradeID"].ToString());
					}
					if(dt.Rows[n]["State"]!=null && dt.Rows[n]["State"].ToString()!="")
					{
						model.State=int.Parse(dt.Rows[n]["State"].ToString());
					}
					if(dt.Rows[n]["RealName"]!=null && dt.Rows[n]["RealName"].ToString()!="")
					{
					model.RealName=dt.Rows[n]["RealName"].ToString();
					}
					if(dt.Rows[n]["Qq"]!=null && dt.Rows[n]["Qq"].ToString()!="")
					{
						model.Qq=int.Parse(dt.Rows[n]["Qq"].ToString());
					}
					if(dt.Rows[n]["Mobil"]!=null && dt.Rows[n]["Mobil"].ToString()!="")
					{
					model.Mobil=dt.Rows[n]["Mobil"].ToString();
					}
					if(dt.Rows[n]["Tel"]!=null && dt.Rows[n]["Tel"].ToString()!="")
					{
					model.Tel=dt.Rows[n]["Tel"].ToString();
					}
					if(dt.Rows[n]["Address"]!=null && dt.Rows[n]["Address"].ToString()!="")
					{
					model.Address=dt.Rows[n]["Address"].ToString();
					}
					if(dt.Rows[n]["Postcode"]!=null && dt.Rows[n]["Postcode"].ToString()!="")
					{
					model.Postcode=dt.Rows[n]["Postcode"].ToString();
					}
					if(dt.Rows[n]["Website"]!=null && dt.Rows[n]["Website"].ToString()!="")
					{
					model.Website=dt.Rows[n]["Website"].ToString();
					}
					if(dt.Rows[n]["IDcardNum"]!=null && dt.Rows[n]["IDcardNum"].ToString()!="")
					{
					model.IDcardNum=dt.Rows[n]["IDcardNum"].ToString();
					}
					if(dt.Rows[n]["AccountType"]!=null && dt.Rows[n]["AccountType"].ToString()!="")
					{
						model.AccountType=int.Parse(dt.Rows[n]["AccountType"].ToString());
					}
					if(dt.Rows[n]["SiteID"]!=null && dt.Rows[n]["SiteID"].ToString()!="")
					{
						model.SiteID=int.Parse(dt.Rows[n]["SiteID"].ToString());
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
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
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

