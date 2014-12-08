using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ROYcms.DB;

namespace ROYcms.Sys.DAL
{
    /// <summary>
    /// 数据访问类ROYcms_UrlRewriter。
    /// </summary>
    public class ROYcms_UrlRewriter
    {
        public ROYcms_UrlRewriter()
        { }
        #region  成员方法

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from  " + PubConstant.date_prefix + "UrlRewriter");
            strSql.Append(" where id=" + id + " ");
            return ROYcms.DB.DbHelpers.Exists(strSql.ToString());
        }
        /// <summary>
        /// 获取单个值
        /// </summary>
        public object GetValue(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select old_url ");
            strSql.Append(" FROM  " + PubConstant.date_prefix + "UrlRewriter ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return ROYcms.DB.DbHelpers.GetSingle(strSql.ToString());
         
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_UrlRewriter model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into  " + PubConstant.date_prefix + "UrlRewriter(");
            strSql.Append("old_url,new_url");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.old_url + "',");
            strSql.Append("'" + model.new_url + "'");
            strSql.Append(")");
            strSql.Append(";select @@IDENTITY");
            object obj = ROYcms.DB.DbHelpers.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ROYcms.Sys.Model.ROYcms_UrlRewriter model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update  " + PubConstant.date_prefix + "UrlRewriter set ");
            strSql.Append("old_url='" + model.old_url + "',");
            strSql.Append("new_url='" + model.new_url + "'");
            strSql.Append(" where id=" + model.id + " ");
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete  " + PubConstant.date_prefix + "UrlRewriter ");
            strSql.Append(" where id=" + id + " ");
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_UrlRewriter GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" id,old_url,new_url ");
            strSql.Append(" from  " + PubConstant.date_prefix + "UrlRewriter ");
            strSql.Append(" where id=" + id + " ");
            ROYcms.Sys.Model.ROYcms_UrlRewriter model = new ROYcms.Sys.Model.ROYcms_UrlRewriter();
            DataSet ds = ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.old_url = ds.Tables[0].Rows[0]["old_url"].ToString();
                model.new_url = ds.Tables[0].Rows[0]["new_url"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,old_url,new_url ");
            strSql.Append(" FROM  " + PubConstant.date_prefix + "UrlRewriter ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
        }

        /*
        */

        #endregion  成员方法
    }
}
