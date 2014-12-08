using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;//请先添加引用
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_template。
	/// </summary>
    public class ROYcms_UGroup
	{
		public ROYcms_UGroup()
		{}
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + PubConstant.date_prefix + "UGroup");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 返回长查询数据总数 （分页用到）
        /// </summary>
        public int GetCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) as H ");
            strSql.Append(" FROM [" + PubConstant.date_prefix + "UGroup] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Convert.ToInt32(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_UGroup model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into "+ PubConstant.date_prefix + "UGroup(");
            strSql.Append("name,zhaiyao,RoleID,Time)");
            strSql.Append(" values (");
            strSql.Append("@name,@zhaiyao,@RoleID,@Time)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@zhaiyao", SqlDbType.VarChar,100),
					new SqlParameter("@RoleID", SqlDbType.VarChar,50),
					new SqlParameter("@Time", SqlDbType.DateTime)};
            parameters[0].Value = model.name;
            parameters[1].Value = model.zhaiyao;
            parameters[2].Value = model.RoleID;
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
        public void Update(ROYcms.Sys.Model.ROYcms_UGroup model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "UGroup set ");
            strSql.Append("name=@name,");
            strSql.Append("zhaiyao=@zhaiyao,");
            strSql.Append("RoleID=@RoleID,");
            strSql.Append("Time=@Time");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@zhaiyao", SqlDbType.VarChar,100),
					new SqlParameter("@RoleID", SqlDbType.VarChar,50),
					new SqlParameter("@Time", SqlDbType.DateTime)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.name;
            parameters[2].Value = model.zhaiyao;
            parameters[3].Value = model.RoleID;
            parameters[4].Value = model.Time;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + PubConstant.date_prefix + "UGroup ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

            /// <summary>
            /// 删除相应的更新关联 
            /// </summary>
            //更改该用户组下的所有用户的 UGroupid=null
            StringBuilder strSql1 = new StringBuilder();
            strSql1.Append("update [" + PubConstant.date_prefix + "user] SET UgroupID = null where  UgroupID='" + id + "'");
            ROYcms.DB.DbHelpers.NonQuery(strSql1.ToString());
            //删除与工作流的关联 
            StringBuilder strSql2 = new StringBuilder();
            strSql2.Append("delete from [" + PubConstant.date_prefix + "UGroup_Workflow] where UGroup_id =" + id);
            DbHelperSQL.ExecuteSql(strSql2.ToString());
            //删除与投递权限的关联 
            StringBuilder strSql3 = new StringBuilder();
            strSql3.Append("delete from [" + PubConstant.date_prefix + "Class_UGroup] where UGroup_id =" + id);
            DbHelperSQL.ExecuteSql(strSql3.ToString());
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_UGroup GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,name,zhaiyao,RoleID,Time from " + PubConstant.date_prefix + "UGroup ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            ROYcms.Sys.Model.ROYcms_UGroup model = new ROYcms.Sys.Model.ROYcms_UGroup();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.name = ds.Tables[0].Rows[0]["name"].ToString();
                model.zhaiyao = ds.Tables[0].Rows[0]["zhaiyao"].ToString();
                model.RoleID = ds.Tables[0].Rows[0]["RoleID"].ToString();
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
            strSql.Append("select id,name,zhaiyao,RoleID,Time ");
            strSql.Append(" from " + PubConstant.date_prefix + "UGroup ");
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
            strSql.Append(" id,name,zhaiyao,RoleID,Time ");
            strSql.Append(" from " + PubConstant.date_prefix + "UGroup ");
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
            parameters[0].Value = PubConstant.date_prefix + "UGroup";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }

        #endregion  成员方法
    }
}

