using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
    /// <summary>
    /// 发票记录表
    /// </summary>
    public partial class ROYcms_Invoice
    {
        private readonly ROYcms.Sys.DAL.ROYcms_Invoice dal = new ROYcms.Sys.DAL.ROYcms_Invoice();
        public ROYcms_Invoice()
        { }
        #region  Method
          /// <summary>
        /// 汇总某一列
        /// </summary>
        public int GetFieldCount(string Field, string strWhere) 
        { 
        return dal.GetFieldCount(Field, strWhere);
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
        public int Add(ROYcms.Sys.Model.ROYcms_Invoice model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ROYcms.Sys.Model.ROYcms_Invoice model)
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
        public ROYcms.Sys.Model.ROYcms_Invoice GetModel(int Id)
        {

            return dal.GetModel(Id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Invoice GetModelByCache(int Id)
        {

            string CacheKey = "ROYcms_InvoiceModel-" + Id;
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
            return (ROYcms.Sys.Model.ROYcms_Invoice)objModel;
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
        public List<ROYcms.Sys.Model.ROYcms_Invoice> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ROYcms.Sys.Model.ROYcms_Invoice> DataTableToList(DataTable dt)
        {
            List<ROYcms.Sys.Model.ROYcms_Invoice> modelList = new List<ROYcms.Sys.Model.ROYcms_Invoice>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ROYcms.Sys.Model.ROYcms_Invoice model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new ROYcms.Sys.Model.ROYcms_Invoice();
                    if (dt.Rows[n]["Id"] != null && dt.Rows[n]["Id"].ToString() != "")
                    {
                        model.Id = int.Parse(dt.Rows[n]["Id"].ToString());
                    }
                    if (dt.Rows[n]["UserID"] != null && dt.Rows[n]["UserID"].ToString() != "")
                    {
                        model.UserID = int.Parse(dt.Rows[n]["UserID"].ToString());
                    }
                    if (dt.Rows[n]["InvoiceName"] != null && dt.Rows[n]["InvoiceName"].ToString() != "")
                    {
                        model.InvoiceName = dt.Rows[n]["InvoiceName"].ToString();
                    }
                    if (dt.Rows[n]["Price"] != null && dt.Rows[n]["Price"].ToString() != "")
                    {
                        model.Price = int.Parse(dt.Rows[n]["Price"].ToString());
                    }
                    if (dt.Rows[n]["PostType"] != null && dt.Rows[n]["PostType"].ToString() != "")
                    {
                        model.PostType = int.Parse(dt.Rows[n]["PostType"].ToString());
                    }
                    if (dt.Rows[n]["RealName"] != null && dt.Rows[n]["RealName"].ToString() != "")
                    {
                        model.RealName = dt.Rows[n]["RealName"].ToString();
                    }
                    if (dt.Rows[n]["Tel"] != null && dt.Rows[n]["Tel"].ToString() != "")
                    {
                        model.Tel = dt.Rows[n]["Tel"].ToString();
                    }
                    if (dt.Rows[n]["Mobil"] != null && dt.Rows[n]["Mobil"].ToString() != "")
                    {
                        model.Mobil = dt.Rows[n]["Mobil"].ToString();
                    }
                    if (dt.Rows[n]["Address"] != null && dt.Rows[n]["Address"].ToString() != "")
                    {
                        model.Address = dt.Rows[n]["Address"].ToString();
                    }
                    if (dt.Rows[n]["PostCode"] != null && dt.Rows[n]["PostCode"].ToString() != "")
                    {
                        model.PostCode = dt.Rows[n]["PostCode"].ToString();
                    }
                    if (dt.Rows[n]["Remark"] != null && dt.Rows[n]["Remark"].ToString() != "")
                    {
                        model.Remark = dt.Rows[n]["Remark"].ToString();
                    }
                    if (dt.Rows[n]["State"] != null && dt.Rows[n]["State"].ToString() != "")
                    {
                        model.State = int.Parse(dt.Rows[n]["State"].ToString());
                    }
                    if (dt.Rows[n]["AdminRemark"] != null && dt.Rows[n]["AdminRemark"].ToString() != "")
                    {
                        model.AdminRemark = dt.Rows[n]["AdminRemark"].ToString();
                    }
                    if (dt.Rows[n]["CreateTime"] != null && dt.Rows[n]["CreateTime"].ToString() != "")
                    {
                        model.CreateTime = DateTime.Parse(dt.Rows[n]["CreateTime"].ToString());
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

