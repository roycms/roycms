using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
using ROYcms.DB;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// 业务逻辑类ROYcms_user 的摘要说明。
	/// </summary>
	public class ROYcms_user
	{
		private readonly ROYcms.Sys.DAL.ROYcms_user dal=new ROYcms.Sys.DAL.ROYcms_user();
		public ROYcms_user()
		{}
		#region  成员方法

        ///// <summary>
        ///// 得到最大ID
        ///// </summary>
        //public int GetMaxId()
        //{
        //    return dal.GetMaxId();
        //}
        /// <summary>
        /// 获取 单个值  单个字段
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetField(int Id, string Field)
        {
            return dal.GetField(Id, Field);
        }
        /// 获取 单个值  单个字段 根据用户名
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetField(string name, string Field)
        {
            return dal.GetField(name, Field);
        }
        /// <summary>
        /// 返回长查询数据总数 （分页用到）
        /// </summary>
        public int GetCount(string strWhere)
        {
            return dal.GetCount(strWhere);
        }
        /// <summary>
        /// 验证用户
        /// </summary>
        public bool Exists(string username, string password)
        {
            return dal.Exists(username, password);
        }

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string name)
		{
			return dal.Exists(name);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_user model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(ROYcms.Sys.Model.ROYcms_user model)
		{
			dal.Update(model);
		}
         /// <summary>
        /// 更改用户为普通用户 无权限用户
        /// </summary>
        public void Update(string ugroup_id)
        {
            dal.Update(ugroup_id);
        }
        /// <summary>
        /// 更改用户密码
        /// </summary>
        public void Update_password(int id, string password)
        {
            dal.Update_password(id, password);
        }
        /// <summary>
        /// 更改用户密码 根据用户名
        /// </summary>
        public void Update_password(string user, string password)
        {
            dal.Update_password(user, password);
        }
        /// <summary>
        /// 更改用户积分xinxi
        /// </summary>
        public void Update_moneys(int id, int money)
        {
            Update_moneys(id, money);
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int bh)
		{
			
			dal.Delete(bh);
		}
         /// <summary>
        /// 删除数据
        /// </summary>
        public void Delete(string strWhere)
        {
            dal.Delete(strWhere);
        }
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_user GetModel(int bh)
		{
			
			return dal.GetModel(bh);
		}

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_user GetModel(string username)
        {

            return dal.GetModel(username);
        }
        /// <summary>
        /// 根据邮件获得用户名
        /// </summary>
        public string GetUserName(string email)
        {

            return dal.GetUserName(email);
        }
		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_user GetModelByCache(int bh)
		{
			
			string CacheKey = ROYcms.Sys.DAL.PubConstant.date_prefix + "userModel-" + bh;
			object objModel = ROYcms.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(bh);
					if (objModel != null)
					{
						int ModelCache = ROYcms.Common.ConfigHelper.GetConfigInt("ModelCache");
						ROYcms.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ROYcms.Sys.Model.ROYcms_user)objModel;
		}


		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_user> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<ROYcms.Sys.Model.ROYcms_user> modelList = new List<ROYcms.Sys.Model.ROYcms_user>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_user model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_user();
					if(ds.Tables[0].Rows[n]["bh"].ToString()!="")
					{
						model.bh=int.Parse(ds.Tables[0].Rows[n]["bh"].ToString());
					}
					model.name=ds.Tables[0].Rows[n]["name"].ToString();
					model.password=ds.Tables[0].Rows[n]["password"].ToString();
					if(ds.Tables[0].Rows[n]["money"].ToString()!="")
					{
						model.money=int.Parse(ds.Tables[0].Rows[n]["money"].ToString());
					}
					model.qq=ds.Tables[0].Rows[n]["qq"].ToString();
					model.email=ds.Tables[0].Rows[n]["email"].ToString();
					if(ds.Tables[0].Rows[n]["age"].ToString()!="")
					{
						model.age=int.Parse(ds.Tables[0].Rows[n]["age"].ToString());
					}
					if(ds.Tables[0].Rows[n]["login_time"].ToString()!="")
					{
						model.login_time=DateTime.Parse(ds.Tables[0].Rows[n]["login_time"].ToString());
					}
					model.sex=ds.Tables[0].Rows[n]["sex"].ToString();
					model.pic=ds.Tables[0].Rows[n]["pic"].ToString();
					model.quanxian=ds.Tables[0].Rows[n]["quanxian"].ToString();
					model.username=ds.Tables[0].Rows[n]["username"].ToString();
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
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere);
        }

		#endregion  成员方法
	}
}

