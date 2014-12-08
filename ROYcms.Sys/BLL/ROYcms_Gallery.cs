using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
    /// <summary>
    /// 相册表
    /// </summary>
    public partial class ROYcms_Gallery
    {
        private readonly ROYcms.Sys.DAL.ROYcms_Gallery dal = new ROYcms.Sys.DAL.ROYcms_Gallery();
        public ROYcms_Gallery()
        { }
        #region  Method
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
        public int Add(ROYcms.Sys.Model.ROYcms_Gallery model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 确认存储临时数据
        /// </summary>
        /// <param name="Id">正式ID</param>
        /// <param name="GalleryInt">临时ID</param>
        /// <returns></returns>
        public bool ZUpdate(int Id, int GalleryInt)
        {
            return dal.ZUpdate(Id, GalleryInt);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ROYcms.Sys.Model.ROYcms_Gallery model)
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
        /// 删除数据 根据查询条件
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public bool Delete(string where)
        {
            return dal.Delete(where);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            return dal.DeleteList(Idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Gallery GetModel(int Id)
        {

            return dal.GetModel(Id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Gallery GetModelByCache(int Id)
        {

            string CacheKey = "ROYcms_GalleryModel-" + Id;
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
                catch { }
            }
            return (ROYcms.Sys.Model.ROYcms_Gallery)objModel;
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
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ROYcms.Sys.Model.ROYcms_Gallery> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ROYcms.Sys.Model.ROYcms_Gallery> DataTableToList(DataTable dt)
        {
            List<ROYcms.Sys.Model.ROYcms_Gallery> modelList = new List<ROYcms.Sys.Model.ROYcms_Gallery>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ROYcms.Sys.Model.ROYcms_Gallery model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new ROYcms.Sys.Model.ROYcms_Gallery();
                    if (dt.Rows[n]["Id"] != null && dt.Rows[n]["Id"].ToString() != "")
                    {
                        model.Id = int.Parse(dt.Rows[n]["Id"].ToString());
                    }
                    if (dt.Rows[n]["Rid"] != null && dt.Rows[n]["Rid"].ToString() != "")
                    {
                        model.Rid = int.Parse(dt.Rows[n]["Rid"].ToString());
                    }
                    if (dt.Rows[n]["TYPE"] != null && dt.Rows[n]["TYPE"].ToString() != "")
                    {
                        model.TYPE = int.Parse(dt.Rows[n]["TYPE"].ToString());
                    }
                    if (dt.Rows[n]["URL"] != null && dt.Rows[n]["URL"].ToString() != "")
                    {
                        model.URL = dt.Rows[n]["URL"].ToString();
                    }
                    if (dt.Rows[n]["thumb_url"] != null && dt.Rows[n]["thumb_url"].ToString() != "")
                    {
                        model.thumb_url = dt.Rows[n]["thumb_url"].ToString();
                    }
                    if (dt.Rows[n]["Title"] != null && dt.Rows[n]["Title"].ToString() != "")
                    {
                        model.Title = dt.Rows[n]["Title"].ToString();
                    }
                    if (dt.Rows[n]["TIME"] != null && dt.Rows[n]["TIME"].ToString() != "")
                    {
                        model.TIME = DateTime.Parse(dt.Rows[n]["TIME"].ToString());
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
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere);
        }

        #endregion  Method
    }
}

