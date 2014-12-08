using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// 业务逻辑类ROYcms_Objet 的摘要说明。
	/// </summary>
	public class ROYcms_Objet
	{
		private readonly ROYcms.Sys.DAL.ROYcms_Objet dal=new ROYcms.Sys.DAL.ROYcms_Objet();
		public ROYcms_Objet()
		{}
		#region  成员方法

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
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsClassKind(int ClassKind)
        {
            return dal.ExistsClassKind(ClassKind);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_Objet model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(ROYcms.Sys.Model.ROYcms_Objet model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int id)
		{
			
			dal.Delete(id);
		}
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string strWhere)
        { 
            return dal.Delete(strWhere);
        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Objet GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
        //public ROYcms.Sys.Model.ROYcms_Objet GetModelByCache(int id)
        //{
			
        //    string CacheKey = PubConstant.date_prefix + "ObjetModel-" + id;
        //    object objModel = ROYcms.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = ROYcms.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                ROYcms.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (ROYcms.Sys.Model.ROYcms_Objet)objModel;
        //}

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
		public List<ROYcms.Sys.Model.ROYcms_Objet> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_Objet> DataTableToList(DataTable dt)
		{
			List<ROYcms.Sys.Model.ROYcms_Objet> modelList = new List<ROYcms.Sys.Model.ROYcms_Objet>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_Objet model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_Objet();
					if(dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					model.Title=dt.Rows[n]["Title"].ToString();
					model.zhaiyao=dt.Rows[n]["zhaiyao"].ToString();
					model.logo=dt.Rows[n]["logo"].ToString();
					model.AppendixConfig=dt.Rows[n]["AppendixConfig"].ToString();
					model.AppendixPath=dt.Rows[n]["AppendixPath"].ToString();
					if(dt.Rows[n]["Visible"].ToString()!="")
					{
						model.Visible=int.Parse(dt.Rows[n]["Visible"].ToString());
					}
					model.Role=dt.Rows[n]["Role"].ToString();
					if(dt.Rows[n]["Time"].ToString()!="")
					{
						model.Time=DateTime.Parse(dt.Rows[n]["Time"].ToString());
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
		/// 获得数据列表
		/// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere);
        }

		#endregion  成员方法
	}
}

