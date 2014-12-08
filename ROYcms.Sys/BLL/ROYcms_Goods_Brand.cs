using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
    /// <summary>
    /// 商品品牌表
    /// </summary>
    public partial class ROYcms_Goods_Brand
    {
        private readonly ROYcms.Sys.DAL.ROYcms_Goods_Brand dal = new ROYcms.Sys.DAL.ROYcms_Goods_Brand();
        public ROYcms_Goods_Brand()
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
        public int Add(ROYcms.Sys.Model.ROYcms_Goods_Brand model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ROYcms.Sys.Model.ROYcms_Goods_Brand model)
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
        public bool DeleteList(string Idlist)
        {
            return dal.DeleteList(Idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Goods_Brand GetModel(int Id)
        {

            return dal.GetModel(Id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Goods_Brand GetModelByCache(int Id)
        {

            string CacheKey = "ROYcms_Goods_BrandModel-" + Id;
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
            return (ROYcms.Sys.Model.ROYcms_Goods_Brand)objModel;
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
        public List<ROYcms.Sys.Model.ROYcms_Goods_Brand> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ROYcms.Sys.Model.ROYcms_Goods_Brand> DataTableToList(DataTable dt)
        {
            List<ROYcms.Sys.Model.ROYcms_Goods_Brand> modelList = new List<ROYcms.Sys.Model.ROYcms_Goods_Brand>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ROYcms.Sys.Model.ROYcms_Goods_Brand model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new ROYcms.Sys.Model.ROYcms_Goods_Brand();
                    if (dt.Rows[n]["Id"] != null && dt.Rows[n]["Id"].ToString() != "")
                    {
                        model.Id = int.Parse(dt.Rows[n]["Id"].ToString());
                    }
                    if (dt.Rows[n]["Name"] != null && dt.Rows[n]["Name"].ToString() != "")
                    {
                        model.Name = dt.Rows[n]["Name"].ToString();
                    }
                    if (dt.Rows[n]["Logo"] != null && dt.Rows[n]["Logo"].ToString() != "")
                    {
                        model.Logo = dt.Rows[n]["Logo"].ToString();
                    }
                    if (dt.Rows[n]["brand_desc"] != null && dt.Rows[n]["brand_desc"].ToString() != "")
                    {
                        model.brand_desc = dt.Rows[n]["brand_desc"].ToString();
                    }
                    if (dt.Rows[n]["site_url"] != null && dt.Rows[n]["site_url"].ToString() != "")
                    {
                        model.site_url = dt.Rows[n]["site_url"].ToString();
                    }
                    if (dt.Rows[n]["sort_order"] != null && dt.Rows[n]["sort_order"].ToString() != "")
                    {
                        model.sort_order = int.Parse(dt.Rows[n]["sort_order"].ToString());
                    }
                    if (dt.Rows[n]["is_show"] != null && dt.Rows[n]["is_show"].ToString() != "")
                    {
                        model.is_show = int.Parse(dt.Rows[n]["is_show"].ToString());
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
        return dal.GetList(PageSize,PageIndex,strWhere);
        }

        #endregion  Method
    }
}

