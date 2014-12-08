using System;
using System.Collections.Generic;
using System.Text;
using ROYcms.DB;
using System.Data;
namespace ROYcms.Sys.DAL
{
    public class ROYcms_TemplateGroup
    {
        public ROYcms_TemplateGroup()
        { }
        #region  成员方法

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_TemplateGroup model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into " + PubConstant.date_prefix + "TemplateGroup(");
            strSql.Append("z_name,z_path,z_url,z_content,z_time");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.z_name + "',");
            strSql.Append("'" + model.z_path + "',");
            strSql.Append("'" + model.z_url + "',");
            strSql.Append("'" + model.z_content + "',");
            strSql.Append("'" + model.z_time + "'");
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
        public void Update(ROYcms.Sys.Model.ROYcms_TemplateGroup model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update " + PubConstant.date_prefix + "TemplateGroup set ");
            strSql.Append("z_name='" + model.z_name + "',");
            strSql.Append("z_path='" + model.z_path + "',");
            strSql.Append("z_url='" + model.z_url + "',");
            strSql.Append("z_content='" + model.z_content + "',");
            strSql.Append("z_time='" + model.z_time + "'");
            strSql.Append(" where bh=" + model.bh + " ");
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int bh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete " + PubConstant.date_prefix + "TemplateGroup ");
            strSql.Append(" where bh=" + bh + " ");
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_TemplateGroup GetModel(int bh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" bh,z_name,z_path,z_url,z_content,z_time ");
            strSql.Append(" from " + PubConstant.date_prefix + "TemplateGroup ");
            strSql.Append(" where bh=" + bh + " ");
            ROYcms.Sys.Model.ROYcms_TemplateGroup model = new ROYcms.Sys.Model.ROYcms_TemplateGroup();
            DataSet ds = ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["bh"].ToString() != "")
                {
                    model.bh = int.Parse(ds.Tables[0].Rows[0]["bh"].ToString());
                }
                model.z_name = ds.Tables[0].Rows[0]["z_name"].ToString();
                model.z_path = ds.Tables[0].Rows[0]["z_path"].ToString();
                model.z_url = ds.Tables[0].Rows[0]["z_url"].ToString();
                model.z_content = ds.Tables[0].Rows[0]["z_content"].ToString();
                if (ds.Tables[0].Rows[0]["z_time"].ToString() != "")
                {
                    model.z_time = DateTime.Parse(ds.Tables[0].Rows[0]["z_time"].ToString());
                }
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
            strSql.Append("select bh,z_name,z_path,z_url,z_content,z_time ");
            strSql.Append(" FROM " + PubConstant.date_prefix + "TemplateGroup ");
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
