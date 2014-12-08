using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
//using System.Web.UI.WebControls;//请先添加引用
namespace ROYcms.Sys.DAL
{
    /// <summary>
    /// 数据访问类ROYcms_news。
    /// </summary>
    public class ROYcms_Url
    {
        public ROYcms_Url()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + PubConstant.date_prefix + "Url");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists_bh(int bh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + PubConstant.date_prefix + "Url");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
            parameters[0].Value = bh;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_Url model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into "+ PubConstant.date_prefix + "Url(");
            strSql.Append("bh,Url,isurl,Time)");
            strSql.Append(" values (");
            strSql.Append("@bh,@Url,@isurl,@Time)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@Url", SqlDbType.NVarChar,200),
					new SqlParameter("@isurl", SqlDbType.Int,4),
					new SqlParameter("@Time", SqlDbType.DateTime)};
            parameters[0].Value = model.bh;
            parameters[1].Value = model.Url;
            parameters[2].Value = model.isurl;
            parameters[3].Value = model.Time;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public void Update(ROYcms.Sys.Model.ROYcms_Url model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "Url set ");
            strSql.Append("bh=@bh,");
            strSql.Append("Url=@Url,");
            strSql.Append("isurl=@isurl,");
            strSql.Append("Time=@Time");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@Url", SqlDbType.NVarChar,200),
					new SqlParameter("@isurl", SqlDbType.Int,4),
					new SqlParameter("@Time", SqlDbType.DateTime)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.bh;
            parameters[2].Value = model.Url;
            parameters[3].Value = model.isurl;
            parameters[4].Value = model.Time;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update_bh(ROYcms.Sys.Model.ROYcms_Url model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "Url set ");
            strSql.Append("bh=@bh,");
            strSql.Append("Url=@Url,");
            strSql.Append("isurl=@isurl,");
            strSql.Append("Time=@Time");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {

					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@Url", SqlDbType.NVarChar,200),
					new SqlParameter("@isurl", SqlDbType.Int,4),
					new SqlParameter("@Time", SqlDbType.DateTime)};

            parameters[0].Value = model.bh;
            parameters[1].Value = model.Url;
            parameters[2].Value = model.isurl;
            parameters[3].Value = model.Time;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + PubConstant.date_prefix + "Url ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 获取 URL地址
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetUrl(int bh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Url from " + PubConstant.date_prefix + "Url");
            strSql.Append(" where bh=" + bh);
            //GetDataSet(strSql.ToString());
            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));

        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Url GetModel_bh(int bh)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,bh,Url,isurl,Time from " + PubConstant.date_prefix + "Url ");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
            parameters[0].Value = bh;

            ROYcms.Sys.Model.ROYcms_Url model = new ROYcms.Sys.Model.ROYcms_Url();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["bh"].ToString() != "")
                {
                    model.bh = int.Parse(ds.Tables[0].Rows[0]["bh"].ToString());
                }
                model.Url = ds.Tables[0].Rows[0]["Url"].ToString();
                if (ds.Tables[0].Rows[0]["isurl"].ToString() != "")
                {
                    model.isurl = int.Parse(ds.Tables[0].Rows[0]["isurl"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Time"].ToString() != "")
                {
                    model.Time = DateTime.Parse(ds.Tables[0].Rows[0]["Time"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Url GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,bh,Url,isurl,Time from " + PubConstant.date_prefix + "Url ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            ROYcms.Sys.Model.ROYcms_Url model = new ROYcms.Sys.Model.ROYcms_Url();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["bh"].ToString() != "")
                {
                    model.bh = int.Parse(ds.Tables[0].Rows[0]["bh"].ToString());
                }
                model.Url = ds.Tables[0].Rows[0]["Url"].ToString();
                if (ds.Tables[0].Rows[0]["isurl"].ToString() != "")
                {
                    model.isurl = int.Parse(ds.Tables[0].Rows[0]["isurl"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Time"].ToString() != "")
                {
                    model.Time = DateTime.Parse(ds.Tables[0].Rows[0]["Time"].ToString());
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
            strSql.Append("select id,bh,Url,isurl,Time ");
            strSql.Append(" from " + PubConstant.date_prefix + "Url ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,bh,Url,isurl,Time ");
            strSql.Append(" from " + PubConstant.date_prefix + "Url ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = PubConstant.date_prefix + "Url";
            parameters[1].Value = "ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  成员方法
    }


}

