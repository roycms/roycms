using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_Objet。
	/// </summary>
	public class ROYcms_Objet
	{
		public ROYcms_Objet()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", PubConstant.date_prefix + "Objet"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "Objet");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsClassKind(int ClassKind)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + PubConstant.date_prefix + "Objet");
            strSql.Append(" where ClassKind=@ClassKind ");
            SqlParameter[] parameters = {
					new SqlParameter("@ClassKind", SqlDbType.Int,4)};
            parameters[0].Value = ClassKind;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_Objet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into "+ PubConstant.date_prefix + "Objet(");
            strSql.Append("Title,ClassKind,zhaiyao,logo,AppendixConfig,AppendixPath,Visible,Role,Time)");
			strSql.Append(" values (");
            strSql.Append("@Title,@ClassKind,@zhaiyao,@logo,@AppendixConfig,@AppendixPath,@Visible,@Role,@Time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.VarChar,50),
                    new SqlParameter("@ClassKind", SqlDbType.Int,4),
					new SqlParameter("@zhaiyao", SqlDbType.VarChar,50),
					new SqlParameter("@logo", SqlDbType.VarChar,50),
					new SqlParameter("@AppendixConfig", SqlDbType.VarChar,50),
					new SqlParameter("@AppendixPath", SqlDbType.VarChar,50),
					new SqlParameter("@Visible", SqlDbType.Int,4),
					new SqlParameter("@Role", SqlDbType.VarChar,50),
					new SqlParameter("@Time", SqlDbType.DateTime)};
			parameters[0].Value = model.Title;
            parameters[1].Value = model.ClassKind;
			parameters[2].Value = model.zhaiyao;
			parameters[3].Value = model.logo;
			parameters[4].Value = model.AppendixConfig;
			parameters[5].Value = model.AppendixPath;
			parameters[6].Value = model.Visible;
			parameters[7].Value = model.Role;
			parameters[8].Value = model.Time;

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
		public void Update(ROYcms.Sys.Model.ROYcms_Objet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update "+ PubConstant.date_prefix + "Objet set ");
			strSql.Append("Title=@Title,");
            strSql.Append("ClassKind=@ClassKind,");
			strSql.Append("zhaiyao=@zhaiyao,");
			strSql.Append("logo=@logo,");
			strSql.Append("AppendixConfig=@AppendixConfig,");
			strSql.Append("AppendixPath=@AppendixPath,");
			strSql.Append("Visible=@Visible,");
			strSql.Append("Role=@Role,");
			strSql.Append("Time=@Time");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.VarChar,50),
                    new SqlParameter("@ClassKind", SqlDbType.Int,4),
					new SqlParameter("@zhaiyao", SqlDbType.VarChar,50),
					new SqlParameter("@logo", SqlDbType.VarChar,50),
					new SqlParameter("@AppendixConfig", SqlDbType.VarChar,50),
					new SqlParameter("@AppendixPath", SqlDbType.VarChar,50),
					new SqlParameter("@Visible", SqlDbType.Int,4),
					new SqlParameter("@Role", SqlDbType.VarChar,50),
					new SqlParameter("@Time", SqlDbType.DateTime)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.Title;
            parameters[2].Value = model.ClassKind;
			parameters[3].Value = model.zhaiyao;
			parameters[4].Value = model.logo;
			parameters[5].Value = model.AppendixConfig;
			parameters[6].Value = model.AppendixPath;
			parameters[7].Value = model.Visible;
			parameters[8].Value = model.Role;
			parameters[9].Value = model.Time;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "Objet ");
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
            strSql.Append("delete from " + PubConstant.date_prefix + "Objet  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Objet GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 * from " + PubConstant.date_prefix + "Objet ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			ROYcms.Sys.Model.ROYcms_Objet model=new ROYcms.Sys.Model.ROYcms_Objet();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				model.Title=ds.Tables[0].Rows[0]["Title"].ToString();
                if (ds.Tables[0].Rows[0]["ClassKind"].ToString() != "")
                {
                    model.ClassKind = Convert.ToInt32(ds.Tables[0].Rows[0]["ClassKind"].ToString());
                }
				model.zhaiyao=ds.Tables[0].Rows[0]["zhaiyao"].ToString();
				model.logo=ds.Tables[0].Rows[0]["logo"].ToString();
				model.AppendixConfig=ds.Tables[0].Rows[0]["AppendixConfig"].ToString();
				model.AppendixPath=ds.Tables[0].Rows[0]["AppendixPath"].ToString();
				if(ds.Tables[0].Rows[0]["Visible"].ToString()!="")
				{
					model.Visible=int.Parse(ds.Tables[0].Rows[0]["Visible"].ToString());
				}
				model.Role=ds.Tables[0].Rows[0]["Role"].ToString();
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
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" from " + PubConstant.date_prefix + "Objet ");
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
			strSql.Append(" from " + PubConstant.date_prefix + "Objet ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			parameters[0].Value = PubConstant.date_prefix + "Objet";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}

		#endregion  成员方法
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM " + PubConstant.date_prefix + "Objet ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
    }
}

