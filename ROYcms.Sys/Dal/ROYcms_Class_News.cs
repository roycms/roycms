using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_Class_News。
	/// </summary>
	public class ROYcms_Class_News
	{
		public ROYcms_Class_News()
		{}
		#region  成员方法
        /// <summary>
        /// 信息批量转移
        /// </summary>
        public void GoToClass(int go, int to)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "Class_News set ");
            strSql.Append("Class=" + to);
            strSql.Append(" where Class=@go ");
            SqlParameter[] parameters = {
					new SqlParameter("@go", SqlDbType.Int,4)
                                        };
            parameters[0].Value = go;
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);

          //  Update(model);
        }
		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", PubConstant.date_prefix + "Class_News"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "Class_News");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_Class_News model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into "+ PubConstant.date_prefix + "Class_News(");
			strSql.Append("news_id,Class,class_id,class_list,Time,GUID)");
			strSql.Append(" values (");
			strSql.Append("@news_id,@Class,@class_id,@class_list,@Time,@GUID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@news_id", SqlDbType.Int,4),
                    new SqlParameter("@Class", SqlDbType.Int,4),
					new SqlParameter("@class_id", SqlDbType.NVarChar,50),
					new SqlParameter("@class_list", SqlDbType.NVarChar,300),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@GUID", SqlDbType.VarChar,50)};
			parameters[0].Value = model.news_id;
            parameters[1].Value = model.Class;
			parameters[2].Value = model.class_id;
			parameters[3].Value = model.class_list;
			parameters[4].Value = model.Time;
			parameters[5].Value = model.GUID;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public void Update(ROYcms.Sys.Model.ROYcms_Class_News model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update "+ PubConstant.date_prefix + "Class_News set ");
			strSql.Append("news_id=@news_id,");
            strSql.Append("Class=@Class,");
			strSql.Append("class_id=@class_id,");
			strSql.Append("class_list=@class_list,");
			strSql.Append("Time=@Time,");
			strSql.Append("GUID=@GUID");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@news_id", SqlDbType.Int,4),
                    new SqlParameter("@Class", SqlDbType.Int,4),
					new SqlParameter("@class_id", SqlDbType.NVarChar,50),
					new SqlParameter("@class_list", SqlDbType.NVarChar,300),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@GUID", SqlDbType.VarChar,50)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.news_id;
            parameters[2].Value = model.Class;
			parameters[3].Value = model.class_id;
			parameters[4].Value = model.class_list;
			parameters[5].Value = model.Time;
			parameters[6].Value = model.GUID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "Class_News ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string strWhere)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + PubConstant.date_prefix + "Class_News ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Class_News GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 * from " + PubConstant.date_prefix + "Class_News ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			ROYcms.Sys.Model.ROYcms_Class_News model=new ROYcms.Sys.Model.ROYcms_Class_News();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["news_id"].ToString()!="")
				{
					model.news_id=int.Parse(ds.Tables[0].Rows[0]["news_id"].ToString());
				}
                if (ds.Tables[0].Rows[0]["Class"].ToString() != "")
                {
                    model.Class = int.Parse(ds.Tables[0].Rows[0]["Class"].ToString());
                }
				model.class_id=ds.Tables[0].Rows[0]["class_id"].ToString();
				model.class_list=ds.Tables[0].Rows[0]["class_list"].ToString();
				if(ds.Tables[0].Rows[0]["Time"].ToString()!="")
				{
					model.Time=DateTime.Parse(ds.Tables[0].Rows[0]["Time"].ToString());
				}
				model.GUID=ds.Tables[0].Rows[0]["GUID"].ToString();
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" from " + PubConstant.date_prefix + "Class_News ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" * ");
			strSql.Append(" from " + PubConstant.date_prefix + "Class_News ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			parameters[0].Value = PubConstant.date_prefix + "Class_News";
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

