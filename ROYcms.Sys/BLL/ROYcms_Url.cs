using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
using System.Web.UI.WebControls;
using ROYcms.Sys.DAL;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// 业务逻辑类ROYcms_news 的摘要说明。
	/// </summary>
    public class ROYcms_Url
	{
        private readonly ROYcms.Sys.DAL.ROYcms_Url dal = new ROYcms.Sys.DAL.ROYcms_Url();
		public ROYcms_Url()
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
        /// 是否存在该记录
        /// </summary>
        public bool Exists_bh(int bh)
        {
            return dal.Exists_bh(bh);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_Url model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 获取 URL地址
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetUrl(int bh)
        {
            return dal.GetUrl(bh);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ROYcms.Sys.Model.ROYcms_Url model)
        {
            dal.Update(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update_bh(ROYcms.Sys.Model.ROYcms_Url model)
        {
            dal.Update_bh(model);
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
        public ROYcms.Sys.Model.ROYcms_Url GetModel_bh(int bh)
        {

            return dal.GetModel_bh(bh);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Url GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中。
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Url GetModelByCache(int id)
        {

            string CacheKey = PubConstant.date_prefix + "UrlModel-" + id;
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
                catch { }
            }
            return (ROYcms.Sys.Model.ROYcms_Url)objModel;
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
        public List<ROYcms.Sys.Model.ROYcms_Url> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ROYcms.Sys.Model.ROYcms_Url> DataTableToList(DataTable dt)
        {
            List<ROYcms.Sys.Model.ROYcms_Url> modelList = new List<ROYcms.Sys.Model.ROYcms_Url>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ROYcms.Sys.Model.ROYcms_Url model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new ROYcms.Sys.Model.ROYcms_Url();
                    if (dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    if (dt.Rows[n]["bh"].ToString() != "")
                    {
                        model.bh = int.Parse(dt.Rows[n]["bh"].ToString());
                    }
                    model.Url = dt.Rows[n]["Url"].ToString();
                    if (dt.Rows[n]["isurl"].ToString() != "")
                    {
                        model.isurl = int.Parse(dt.Rows[n]["isurl"].ToString());
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

