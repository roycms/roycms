using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;//请先添加引用
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_Role。
	/// </summary>
	public class ROYcms_New_User
	{
        public ROYcms_New_User()
		{}
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + PubConstant.date_prefix + "New_User");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_New_User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into "+ PubConstant.date_prefix + "New_User(");
            strSql.Append("New_id,User_id,Time)");
            strSql.Append(" values (");
            strSql.Append("@New_id,@User_id,@Time)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@New_id", SqlDbType.Int,4),
					new SqlParameter("@User_id", SqlDbType.Int,4),
					new SqlParameter("@Time", SqlDbType.DateTime)};
            parameters[0].Value = model.New_id;
            parameters[1].Value = model.User_id;
            parameters[2].Value = model.Time;

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
        public void Update(ROYcms.Sys.Model.ROYcms_New_User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "New_User set ");
            strSql.Append("New_id=@New_id,");
            strSql.Append("User_id=@User_id,");
            strSql.Append("Time=@Time");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@New_id", SqlDbType.Int,4),
					new SqlParameter("@User_id", SqlDbType.Int,4),
					new SqlParameter("@Time", SqlDbType.DateTime)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.New_id;
            parameters[2].Value = model.User_id;
            parameters[3].Value = model.Time;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + PubConstant.date_prefix + "New_User ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string strWhere)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + PubConstant.date_prefix + "New_User ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_New_User GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,New_id,User_id,Time from " + PubConstant.date_prefix + "New_User ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            ROYcms.Sys.Model.ROYcms_New_User model = new ROYcms.Sys.Model.ROYcms_New_User();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["New_id"].ToString() != "")
                {
                    model.New_id = int.Parse(ds.Tables[0].Rows[0]["New_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["User_id"].ToString() != "")
                {
                    model.User_id = int.Parse(ds.Tables[0].Rows[0]["User_id"].ToString());
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
            strSql.Append("select id,New_id,User_id,Time ");
            strSql.Append(" from " + PubConstant.date_prefix + "New_User ");
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
            strSql.Append(" id,New_id,User_id,Time ");
            strSql.Append(" from " + PubConstant.date_prefix + "New_User ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        /// <param name="PageSize">Size of the page.</param>
        /// <param name="PageIndex">Index of the page.</param>
        /// <param name="strWhere">The STR where.</param>
        /// <returns></returns>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, int OrderType)
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
            parameters[0].Value = "" + PubConstant.date_prefix + "new_user";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = OrderType;
            parameters[6].Value = strWhere;
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage", parameters, "ds");
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        /// <param name="PageSize">Size of the page.</param>
        /// <param name="PageIndex">Index of the page.</param>
        /// <param name="strWhere">The STR where.</param>
        /// <returns></returns>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return GetList(PageSize, PageIndex, strWhere, 0);
        }

        #endregion  成员方法
	}
}

