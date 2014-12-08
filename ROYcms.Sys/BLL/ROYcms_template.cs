using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// 业务逻辑类ROYcms_template 的摘要说明。
	/// </summary>
	public class ROYcms_template
	{
        private readonly ROYcms.Sys.DAL.ROYcms_template dal = new ROYcms.Sys.DAL.ROYcms_template();
        public ROYcms_template()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int bh)
        {
            return dal.Exists(bh);
        }
        /// <summary>
        /// 是否存在del记录
        /// </summary>
        public int Exists()
        {
            return dal.del_Exists();
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_template model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ROYcms.Sys.Model.ROYcms_template model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int bh)
        {

            dal.Delete(bh);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_template GetModel(int bh)
        {

            return dal.GetModel(bh);
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
        public List<ROYcms.Sys.Model.ROYcms_template> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            List<ROYcms.Sys.Model.ROYcms_template> modelList = new List<ROYcms.Sys.Model.ROYcms_template>();
            int rowsCount = ds.Tables[0].Rows.Count;
            if (rowsCount > 0)
            {
                ROYcms.Sys.Model.ROYcms_template model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new ROYcms.Sys.Model.ROYcms_template();
                    if (ds.Tables[0].Rows[n]["bh"].ToString() != "")
                    {
                        model.bh = int.Parse(ds.Tables[0].Rows[n]["bh"].ToString());
                    }
                    model.name = ds.Tables[0].Rows[n]["name"].ToString();
                    model.tag = ds.Tables[0].Rows[n]["tag"].ToString();
                    model.htmlcontent = ds.Tables[0].Rows[n]["htmlcontent"].ToString();
                    if (ds.Tables[0].Rows[n]["htmltimes"].ToString() != "")
                    {
                        model.htmltimes = DateTime.Parse(ds.Tables[0].Rows[n]["htmltimes"].ToString());
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

