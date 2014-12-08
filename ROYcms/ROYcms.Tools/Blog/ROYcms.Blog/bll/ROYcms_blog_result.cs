using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Blog.Model;
namespace ROYcms.Blog.BLL
{
	/// <summary>
	/// 业务逻辑类ROYcms_blog_result 的摘要说明。
	/// </summary>
	public class ROYcms_blog_result
	{
		private readonly ROYcms.Blog.DAL.ROYcms_blog_result dal=new ROYcms.Blog.DAL.ROYcms_blog_result();
		public ROYcms_blog_result()
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
		/// 增加一条数据
		/// </summary>
		public int  Add(ROYcms.Blog.Model.ROYcms_blog_result model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(ROYcms.Blog.Model.ROYcms_blog_result model)
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
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Blog.Model.ROYcms_blog_result GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public ROYcms.Blog.Model.ROYcms_blog_result GetModelByCache(int id)
		{
			
			string CacheKey = "ROYcms_blog_resultModel-" + id;
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
			return (ROYcms.Blog.Model.ROYcms_blog_result)objModel;
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
		public List<ROYcms.Blog.Model.ROYcms_blog_result> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ROYcms.Blog.Model.ROYcms_blog_result> DataTableToList(DataTable dt)
		{
			List<ROYcms.Blog.Model.ROYcms_blog_result> modelList = new List<ROYcms.Blog.Model.ROYcms_blog_result>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Blog.Model.ROYcms_blog_result model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Blog.Model.ROYcms_blog_result();
					if(dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["blog_id"].ToString()!="")
					{
						model.blog_id=int.Parse(dt.Rows[n]["blog_id"].ToString());
					}
					model.title=dt.Rows[n]["title"].ToString();
					model.content=dt.Rows[n]["content"].ToString();
					model.user_id=dt.Rows[n]["user_id"].ToString();
					model.ip=dt.Rows[n]["ip"].ToString();
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

