using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
using ROYcms.Sys.DAL;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// 业务逻辑类ROYcms_Form_class_classkind 的摘要说明。
	/// </summary>
	public class ROYcms_Form_class_classkind
	{
		private readonly ROYcms.Sys.DAL.ROYcms_Form_class_classkind dal=new ROYcms.Sys.DAL.ROYcms_Form_class_classkind();
		public ROYcms_Form_class_classkind()
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
        public bool class_id_Exists(int class_id)
        {
            return dal.class_id_Exists(class_id);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_Form_class_classkind model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(ROYcms.Sys.Model.ROYcms_Form_class_classkind model)
		{
			dal.Update(model);
		}
          /// <summary>
        /// 更新一条数据
        /// </summary>
        public void class_id_Update(ROYcms.Sys.Model.ROYcms_Form_class_classkind model)
        { dal.class_id_Update(model); }
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
        public void class_id_Delete(int class_id)
        {
            dal.class_id_Delete(class_id);
        }
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Form_class_classkind GetModel(int id)
		{
			
			return dal.GetModel(id);
		}
         /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Form_class_classkind GetModel_class_id(int class_id)
        { return dal.GetModel_class_id(class_id); }
		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Form_class_classkind GetModelByCache(int id)
		{
			
			string CacheKey = PubConstant.date_prefix + "Form_class_classkindModel-" + id;
			object objModel = ROYcms.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(id);
					if (objModel != null)
					{
						int ModelCache = ROYcms.Common.ConfigHelper.GetConfigInt("ModelCache");
						ROYcms.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ROYcms.Sys.Model.ROYcms_Form_class_classkind)objModel;
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
		public List<ROYcms.Sys.Model.ROYcms_Form_class_classkind> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_Form_class_classkind> DataTableToList(DataTable dt)
		{
			List<ROYcms.Sys.Model.ROYcms_Form_class_classkind> modelList = new List<ROYcms.Sys.Model.ROYcms_Form_class_classkind>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_Form_class_classkind model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_Form_class_classkind();
					if(dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["From_id"].ToString()!="")
					{
						model.From_id=int.Parse(dt.Rows[n]["From_id"].ToString());
					}
					model.From_GUID=dt.Rows[n]["From_GUID"].ToString();
					if(dt.Rows[n]["class_id"].ToString()!="")
					{
						model.class_id=int.Parse(dt.Rows[n]["class_id"].ToString());
					}
					if(dt.Rows[n]["classkind_id"].ToString()!="")
					{
						model.classkind_id=int.Parse(dt.Rows[n]["classkind_id"].ToString());
					}
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
		/// 获得数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  成员方法
	}
}

