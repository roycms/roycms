using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ROYcms.Sys.BLL
{
   public class ROYcms_TemplateGroup
    {
        private readonly ROYcms.Sys.DAL.ROYcms_TemplateGroup dal = new ROYcms.Sys.DAL.ROYcms_TemplateGroup();
        public ROYcms_TemplateGroup()
        { }
        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_TemplateGroup model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ROYcms.Sys.Model.ROYcms_TemplateGroup model)
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
        public ROYcms.Sys.Model.ROYcms_TemplateGroup GetModel(int bh)
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
