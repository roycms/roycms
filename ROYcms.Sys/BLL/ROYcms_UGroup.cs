using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// 业务逻辑类ROYcms_template 的摘要说明。
	/// </summary>
    public class ROYcms_UGroup
	{
        private readonly ROYcms.Sys.DAL.ROYcms_UGroup dal = new ROYcms.Sys.DAL.ROYcms_UGroup();
       public ROYcms_UGroup()
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
       public int Add(ROYcms.Sys.Model.ROYcms_UGroup model)
       {
           return dal.Add(model);
       }

       /// <summary>
       /// 更新一条数据
       /// </summary>
       public void Update(ROYcms.Sys.Model.ROYcms_UGroup model)
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
       public ROYcms.Sys.Model.ROYcms_UGroup GetModel(int id)
       {

           return dal.GetModel(id);
       }

       /// <summary>
       /// 得到一个对象实体，从缓存中。
       /// </summary>
       //public ROYcms.Sys.Model.Sys.ROYcms_UGroup GetModelByCache(int id)
       //{

       //    string CacheKey = PubConstant.date_prefix + "UGroupModel-" + id;
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
       //    return (ROYcms.Sys.Model.ROYcms_UGroup)objModel;
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
       public DataSet GetList(int Top, string strWhere, string filedOrder)
       {
           return dal.GetList(Top, strWhere, filedOrder);
       }
       /// <summary>
       /// 获得数据列表
       /// </summary>
       public List<ROYcms.Sys.Model.ROYcms_UGroup> GetModelList(string strWhere)
       {
           DataSet ds = dal.GetList(strWhere);
           return DataTableToList(ds.Tables[0]);
       }
       /// <summary>
       /// 获得数据列表
       /// </summary>
       public List<ROYcms.Sys.Model.ROYcms_UGroup> DataTableToList(DataTable dt)
       {
           List<ROYcms.Sys.Model.ROYcms_UGroup> modelList = new List<ROYcms.Sys.Model.ROYcms_UGroup>();
           int rowsCount = dt.Rows.Count;
           if (rowsCount > 0)
           {
               ROYcms.Sys.Model.ROYcms_UGroup model;
               for (int n = 0; n < rowsCount; n++)
               {
                   model = new ROYcms.Sys.Model.ROYcms_UGroup();
                   if (dt.Rows[n]["id"].ToString() != "")
                   {
                       model.id = int.Parse(dt.Rows[n]["id"].ToString());
                   }
                   model.name = dt.Rows[n]["name"].ToString();
                   model.zhaiyao = dt.Rows[n]["zhaiyao"].ToString();
                   model.RoleID = dt.Rows[n]["RoleID"].ToString();
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
       public DataSet GetList(int PageSize, int PageIndex, string strWhere)
       {
           return dal.GetList(PageSize, PageIndex, strWhere);
       }

       #endregion  成员方法

       public int GetCount(string where)
       {
           return dal.GetCount(where);
       }
    }
}

