using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_Form_class_classkind。
	/// </summary>
	public class ROYcms_Form_class_classkind
	{
		public ROYcms_Form_class_classkind()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", PubConstant.date_prefix + "Form_class_classkind"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool class_id_Exists(int class_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "Form_class_classkind");
            strSql.Append(" where class_id=@class_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@class_id", SqlDbType.Int,4)};
            parameters[0].Value = class_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + PubConstant.date_prefix + "Form_class_classkind");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_Form_class_classkind model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into "+ PubConstant.date_prefix + "Form_class_classkind(");
			strSql.Append("From_id,From_GUID,class_id,classkind_id,Time)");
			strSql.Append(" values (");
			strSql.Append("@From_id,@From_GUID,@class_id,@classkind_id,@Time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@From_id", SqlDbType.Int,4),
					new SqlParameter("@From_GUID", SqlDbType.NVarChar,50),
					new SqlParameter("@class_id", SqlDbType.Int,4),
					new SqlParameter("@classkind_id", SqlDbType.Int,4),
					new SqlParameter("@Time", SqlDbType.DateTime)};
			parameters[0].Value = model.From_id;
			parameters[1].Value = model.From_GUID;
			parameters[2].Value = model.class_id;
			parameters[3].Value = model.classkind_id;
			parameters[4].Value = model.Time;

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
		public void Update(ROYcms.Sys.Model.ROYcms_Form_class_classkind model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update "+ PubConstant.date_prefix + "Form_class_classkind set ");
			strSql.Append("From_id=@From_id,");
			strSql.Append("From_GUID=@From_GUID,");
			strSql.Append("class_id=@class_id,");
			strSql.Append("classkind_id=@classkind_id,");
			strSql.Append("Time=@Time");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@From_id", SqlDbType.Int,4),
					new SqlParameter("@From_GUID", SqlDbType.NVarChar,50),
					new SqlParameter("@class_id", SqlDbType.Int,4),
					new SqlParameter("@classkind_id", SqlDbType.Int,4),
					new SqlParameter("@Time", SqlDbType.DateTime)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.From_id;
			parameters[2].Value = model.From_GUID;
			parameters[3].Value = model.class_id;
			parameters[4].Value = model.classkind_id;
			parameters[5].Value = model.Time;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void class_id_Update(ROYcms.Sys.Model.ROYcms_Form_class_classkind model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "Form_class_classkind set ");
            strSql.Append("From_id=@From_id,");
            strSql.Append("From_GUID=@From_GUID,");
            strSql.Append("class_id=@class_id,");
            strSql.Append("classkind_id=@classkind_id,");
            strSql.Append("Time=@Time");
            strSql.Append(" where class_id=@class_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@From_id", SqlDbType.Int,4),
					new SqlParameter("@From_GUID", SqlDbType.NVarChar,50),
					new SqlParameter("@class_id", SqlDbType.Int,4),
					new SqlParameter("@classkind_id", SqlDbType.Int,4),
					new SqlParameter("@Time", SqlDbType.DateTime)};
            parameters[0].Value = model.From_id;
            parameters[1].Value = model.From_GUID;
            parameters[2].Value = model.class_id;
            parameters[3].Value = model.classkind_id;
            parameters[4].Value = model.Time;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "Form_class_classkind ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void class_id_Delete(int class_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + PubConstant.date_prefix + "Form_class_classkind ");
            strSql.Append(" where class_id=@class_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@class_id", SqlDbType.Int,4)};
            parameters[0].Value = class_id;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Form_class_classkind GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,From_id,From_GUID,class_id,classkind_id,Time from " + PubConstant.date_prefix + "Form_class_classkind ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			ROYcms.Sys.Model.ROYcms_Form_class_classkind model=new ROYcms.Sys.Model.ROYcms_Form_class_classkind();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["From_id"].ToString()!="")
				{
					model.From_id=int.Parse(ds.Tables[0].Rows[0]["From_id"].ToString());
				}
				model.From_GUID=ds.Tables[0].Rows[0]["From_GUID"].ToString();
				if(ds.Tables[0].Rows[0]["class_id"].ToString()!="")
				{
					model.class_id=int.Parse(ds.Tables[0].Rows[0]["class_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["classkind_id"].ToString()!="")
				{
					model.classkind_id=int.Parse(ds.Tables[0].Rows[0]["classkind_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Time"].ToString()!="")
				{
					model.Time=DateTime.Parse(ds.Tables[0].Rows[0]["Time"].ToString());
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
        public ROYcms.Sys.Model.ROYcms_Form_class_classkind GetModel_class_id(int class_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,From_id,From_GUID,class_id,classkind_id,Time from " + PubConstant.date_prefix + "Form_class_classkind ");
            strSql.Append(" where class_id=@class_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@class_id", SqlDbType.Int,4)};
            parameters[0].Value = class_id;

            ROYcms.Sys.Model.ROYcms_Form_class_classkind model = new ROYcms.Sys.Model.ROYcms_Form_class_classkind();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["From_id"].ToString() != "")
                {
                    model.From_id = int.Parse(ds.Tables[0].Rows[0]["From_id"].ToString());
                }
                model.From_GUID = ds.Tables[0].Rows[0]["From_GUID"].ToString();
                if (ds.Tables[0].Rows[0]["class_id"].ToString() != "")
                {
                    model.class_id = int.Parse(ds.Tables[0].Rows[0]["class_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["classkind_id"].ToString() != "")
                {
                    model.classkind_id = int.Parse(ds.Tables[0].Rows[0]["classkind_id"].ToString());
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,From_id,From_GUID,class_id,classkind_id,Time ");
			strSql.Append(" from " + PubConstant.date_prefix + "Form_class_classkind ");
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
			strSql.Append(" id,From_id,From_GUID,class_id,classkind_id,Time ");
			strSql.Append(" from " + PubConstant.date_prefix + "Form_class_classkind ");
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
			parameters[0].Value = PubConstant.date_prefix + "Form_class_classkind";
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

