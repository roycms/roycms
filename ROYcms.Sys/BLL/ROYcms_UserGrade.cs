using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
using ROYcms.Sys.DAL;
namespace ROYcms.Sys.BLL
{
    /// <summary>
    /// 用户等级扩展表 编号为1的用户等级为初始化数据
    /// </summary>
    public partial class ROYcms_UserGrade
    {
        private readonly IDNSABC_UserGrade dal = DataAccess.CreateDNSABC_UserGrade();
        public ROYcms_UserGrade()
        { }
        #region  Method

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
        public bool Exists(int Id)
        {
            return dal.Exists(Id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ROYcms.Sys.Model.DNSABC_UserGrade model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ROYcms.Sys.Model.DNSABC_UserGrade model)
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
        public ROYcms.Model.DNSABC_UserGrade GetModel(int Id)
        {

            return dal.GetModel(Id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public ROYcms.Model.DNSABC_UserGrade GetModelByCache(int Id)
        {

            string CacheKey = "ROYcms_UserGradeModel-" + Id;
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
            return (ROYcms.Sys.Model.ROYcms_UserGrade)objModel;
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
        public List<ROYcms.Sys.Model.ROYcms_UserGrade> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ROYcms.Sys.Model.ROYcms_UserGrade> DataTableToList(DataTable dt)
        {
            List<ROYcms.Sys.Model.ROYcms_UserGrade> modelList = new List<ROYcms.Sys.Model.DNSABC_UserGrade>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                DNSABC.Model.DNSABC_UserGrade model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new DNSABC.Model.DNSABC_UserGrade();
                    if (dt.Rows[n]["Id"] != null && dt.Rows[n]["Id"].ToString() != "")
                    {
                        model.Id = int.Parse(dt.Rows[n]["Id"].ToString());
                    }
                    if (dt.Rows[n]["GradeName"] != null && dt.Rows[n]["GradeName"].ToString() != "")
                    {
                        model.GradeName = dt.Rows[n]["GradeName"].ToString();
                    }
                    if (dt.Rows[n]["isOrder"] != null && dt.Rows[n]["isOrder"].ToString() != "")
                    {
                        model.isOrder = int.Parse(dt.Rows[n]["isOrder"].ToString());
                    }
                    if (dt.Rows[n]["Remark"] != null && dt.Rows[n]["Remark"].ToString() != "")
                    {
                        model.Remark = dt.Rows[n]["Remark"].ToString();
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
        //    return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        //}
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        //{
        //    return dal.GetList(PageSize, PageIndex, strWhere);
        //}

        #endregion  Method
    }
}

