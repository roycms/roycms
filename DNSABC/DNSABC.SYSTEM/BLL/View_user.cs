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
	/// View_user
	/// </summary>
	public partial class View_user
	{
		private readonly IView_user dal=DataAccess.CreateView_user();
		public View_user()
		{}
		#region  Method

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DNSABC.Model.View_user model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DNSABC.Model.View_user model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DNSABC.Model.View_user GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public DNSABC.Model.View_user GetModelByCache()
		{
			//该表无主键信息，请自定义主键/条件字段
			string CacheKey = "View_userModel-" ;
            object objModel = ROYcms.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel();
					if (objModel != null)
					{
                        int ModelCache = ROYcms.Common.ConfigHelper.GetConfigInt("ModelCache");
                        ROYcms.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (DNSABC.Model.View_user)objModel;
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
		public List<DNSABC.Model.View_user> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DNSABC.Model.View_user> DataTableToList(DataTable dt)
		{
			List<DNSABC.Model.View_user> modelList = new List<DNSABC.Model.View_user>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DNSABC.Model.View_user model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new DNSABC.Model.View_user();
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
					if(dt.Rows[n]["bh"]!=null && dt.Rows[n]["bh"].ToString()!="")
					{
						model.bh=int.Parse(dt.Rows[n]["bh"].ToString());
					}
					if(dt.Rows[n]["RoleID"]!=null && dt.Rows[n]["RoleID"].ToString()!="")
					{
					model.RoleID=dt.Rows[n]["RoleID"].ToString();
					}
					if(dt.Rows[n]["UgroupID"]!=null && dt.Rows[n]["UgroupID"].ToString()!="")
					{
					model.UgroupID=dt.Rows[n]["UgroupID"].ToString();
					}
					if(dt.Rows[n]["name"]!=null && dt.Rows[n]["name"].ToString()!="")
					{
					model.name=dt.Rows[n]["name"].ToString();
					}
					if(dt.Rows[n]["PASSWORD"]!=null && dt.Rows[n]["PASSWORD"].ToString()!="")
					{
					model.PASSWORD=dt.Rows[n]["PASSWORD"].ToString();
					}
					if(dt.Rows[n]["email"]!=null && dt.Rows[n]["email"].ToString()!="")
					{
					model.email=dt.Rows[n]["email"].ToString();
					}
					if(dt.Rows[n]["age"]!=null && dt.Rows[n]["age"].ToString()!="")
					{
						model.age=int.Parse(dt.Rows[n]["age"].ToString());
					}
					if(dt.Rows[n]["login_time"]!=null && dt.Rows[n]["login_time"].ToString()!="")
					{
						model.login_time=DateTime.Parse(dt.Rows[n]["login_time"].ToString());
					}
					if(dt.Rows[n]["sex"]!=null && dt.Rows[n]["sex"].ToString()!="")
					{
					model.sex=dt.Rows[n]["sex"].ToString();
					}
					if(dt.Rows[n]["pic"]!=null && dt.Rows[n]["pic"].ToString()!="")
					{
					model.pic=dt.Rows[n]["pic"].ToString();
					}
					if(dt.Rows[n]["quanxian"]!=null && dt.Rows[n]["quanxian"].ToString()!="")
					{
					model.quanxian=dt.Rows[n]["quanxian"].ToString();
					}
					if(dt.Rows[n]["username"]!=null && dt.Rows[n]["username"].ToString()!="")
					{
					model.username=dt.Rows[n]["username"].ToString();
					}
					if(dt.Rows[n]["GUID"]!=null && dt.Rows[n]["GUID"].ToString()!="")
					{
					model.GUID=dt.Rows[n]["GUID"].ToString();
					}
					if(dt.Rows[n]["IP"]!=null && dt.Rows[n]["IP"].ToString()!="")
					{
					model.IP=dt.Rows[n]["IP"].ToString();
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

