using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace ROYcms.DB
{
    /// <summary>
    /// 在此层实现不同类型数据库访问
    /// </summary>
    public class DbHelpers
    {
        #region Helpers

        /// <summary>
        /// 通用方法/SQL拼接 非存储过程
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, SqlParameter[] p)
        {
            return DbHelperSQL.Query(sql, p);
        }
        /// <summary>
        /// SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            return DbHelperSQL.Query(sql);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingle(string sql)
        {
            return DbHelperSQL.GetSingle(sql);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static object GetSingle(string sql, SqlParameter[] p)
        {
            return DbHelperSQL.GetSingle(sql,p);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int NonQuery(string sql)
        {
            return DbHelperSQL.ExecuteSql(sql);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int NonQuery(string sql, SqlParameter[] p)
        {
            return DbHelperSQL.ExecuteSql(sql,p);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool Exists(string sql)
        {
            object obj = DbHelpers.GetSingle(sql);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Exists(string sql, SqlParameter[] p)
        {
            object obj = DbHelpers.GetSingle(sql, p);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

    }
}
