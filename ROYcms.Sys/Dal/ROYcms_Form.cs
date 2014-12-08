using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_Form。
	/// </summary>
	public class ROYcms_Form
	{
		public ROYcms_Form()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", PubConstant.date_prefix + "Form"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "Form");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(ROYcms.Sys.Model.ROYcms_Form model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into "+ PubConstant.date_prefix + "Form(");
			strSql.Append("title,zhaiyao,classname,ClassKind_id,Class_id,SetFrom,Path,Contents,Time,GUID)");
			strSql.Append(" values (");
			strSql.Append("@title,@zhaiyao,@classname,@ClassKind_id,@Class_id,@SetFrom,@Path,@Contents,@Time,@GUID)");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.NVarChar,100),
					new SqlParameter("@zhaiyao", SqlDbType.NVarChar,200),
					new SqlParameter("@classname", SqlDbType.Int,4),
					new SqlParameter("@ClassKind_id", SqlDbType.Int,4),
					new SqlParameter("@Class_id", SqlDbType.Int,4),
					new SqlParameter("@SetFrom", SqlDbType.NVarChar,200),
					new SqlParameter("@Path", SqlDbType.NVarChar,100),
					new SqlParameter("@Contents", SqlDbType.Text),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@GUID", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.zhaiyao;
			parameters[2].Value = model.classname;
			parameters[3].Value = model.ClassKind_id;
			parameters[4].Value = model.Class_id;
			parameters[5].Value = model.SetFrom;
			parameters[6].Value = model.Path;
			parameters[7].Value = model.Contents;
			parameters[8].Value = model.Time;
			parameters[9].Value = model.GUID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(ROYcms.Sys.Model.ROYcms_Form model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update "+ PubConstant.date_prefix + "Form set ");
			strSql.Append("title=@title,");
			strSql.Append("zhaiyao=@zhaiyao,");
			strSql.Append("classname=@classname,");
			strSql.Append("ClassKind_id=@ClassKind_id,");
			strSql.Append("Class_id=@Class_id,");
			strSql.Append("SetFrom=@SetFrom,");
			strSql.Append("Path=@Path,");
			strSql.Append("Contents=@Contents,");
			strSql.Append("Time=@Time,");
			strSql.Append("GUID=@GUID");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@title", SqlDbType.NVarChar,100),
					new SqlParameter("@zhaiyao", SqlDbType.NVarChar,200),
					new SqlParameter("@classname", SqlDbType.Int,4),
					new SqlParameter("@ClassKind_id", SqlDbType.Int,4),
					new SqlParameter("@Class_id", SqlDbType.Int,4),
					new SqlParameter("@SetFrom", SqlDbType.NVarChar,200),
					new SqlParameter("@Path", SqlDbType.NVarChar,100),
					new SqlParameter("@Contents", SqlDbType.Text),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@GUID", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.title;
			parameters[2].Value = model.zhaiyao;
			parameters[3].Value = model.classname;
			parameters[4].Value = model.ClassKind_id;
			parameters[5].Value = model.Class_id;
			parameters[6].Value = model.SetFrom;
			parameters[7].Value = model.Path;
			parameters[8].Value = model.Contents;
			parameters[9].Value = model.Time;
			parameters[10].Value = model.GUID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "Form ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Form GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,title,zhaiyao,classname,ClassKind_id,Class_id,SetFrom,Path,Contents,Time,GUID from " + PubConstant.date_prefix + "Form ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			ROYcms.Sys.Model.ROYcms_Form model=new ROYcms.Sys.Model.ROYcms_Form();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				model.title=ds.Tables[0].Rows[0]["title"].ToString();
				model.zhaiyao=ds.Tables[0].Rows[0]["zhaiyao"].ToString();
				if(ds.Tables[0].Rows[0]["classname"].ToString()!="")
				{
					model.classname=int.Parse(ds.Tables[0].Rows[0]["classname"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ClassKind_id"].ToString()!="")
				{
					model.ClassKind_id=int.Parse(ds.Tables[0].Rows[0]["ClassKind_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Class_id"].ToString()!="")
				{
					model.Class_id=int.Parse(ds.Tables[0].Rows[0]["Class_id"].ToString());
				}
				model.SetFrom=ds.Tables[0].Rows[0]["SetFrom"].ToString();
				model.Path=ds.Tables[0].Rows[0]["Path"].ToString();
				model.Contents=ds.Tables[0].Rows[0]["Contents"].ToString();
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
			strSql.Append("select id,title,zhaiyao,classname,ClassKind_id,Class_id,SetFrom,Path,Contents,Time,GUID ");
			strSql.Append(" from " + PubConstant.date_prefix + "Form ");
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
			strSql.Append(" id,title,zhaiyao,classname,ClassKind_id,Class_id,SetFrom,Path,Contents,Time,GUID ");
			strSql.Append(" from " + PubConstant.date_prefix + "Form ");
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
			parameters[0].Value = PubConstant.date_prefix + "Form";
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

