using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
    /// 业务逻辑类ROYcms_Class_UGroup的摘要说明。
	/// </summary>
	public class ROYcms_Class_UGroup
	{
		private readonly ROYcms.Sys.DAL.ROYcms_Class_UGroup dal=new ROYcms.Sys.DAL.ROYcms_Class_UGroup();
        public ROYcms_Class_UGroup()
		{}
        #region  成员方法
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
        public int Add(ROYcms.Sys.Model.ROYcms_Class_UGroup model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ROYcms.Sys.Model.ROYcms_Class_UGroup model)
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
        public ROYcms.Sys.Model.ROYcms_Class_UGroup GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中。
        /// </summary>
        //public ROYcms.Sys.Model.ROYcms_Class_UGroup GetModelByCache(int id)
        //{

        //    string CacheKey = PubConstant.date_prefix + "Class_UGroupModel-" + id;
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
        //        catch { }
        //    }
        //    return (ROYcms.Sys.Model.ROYcms_Class_UGroup)objModel;
        //}

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
        public DataSet GetList(int id)
        {
            return dal.GetList(" id="+id);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ROYcms.Sys.Model.ROYcms_Class_UGroup> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ROYcms.Sys.Model.ROYcms_Class_UGroup> DataTableToList(DataTable dt)
        {
            List<ROYcms.Sys.Model.ROYcms_Class_UGroup> modelList = new List<ROYcms.Sys.Model.ROYcms_Class_UGroup>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ROYcms.Sys.Model.ROYcms_Class_UGroup model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new ROYcms.Sys.Model.ROYcms_Class_UGroup();
                    if (dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    if (dt.Rows[n]["Class_id"].ToString() != "")
                    {
                        model.Class_id = int.Parse(dt.Rows[n]["Class_id"].ToString());
                    }
                    if (dt.Rows[n]["UGroup_id"].ToString() != "")
                    {
                        model.UGroup_id = int.Parse(dt.Rows[n]["UGroup_id"].ToString());
                    }
                    if (dt.Rows[n]["User_id"].ToString() != "")
                    {
                        model.User_id = int.Parse(dt.Rows[n]["User_id"].ToString());
                    }
                    if (dt.Rows[n]["Time"].ToString() != "")
                    {
                        model.Time = DateTime.Parse(dt.Rows[n]["Time"].ToString());
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

