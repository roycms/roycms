using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Blog.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_blog。
	/// </summary>
	public class ROYcms_blog
	{
		public ROYcms_blog()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "ROYcms_blog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ROYcms_blog");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
       

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Blog.Model.ROYcms_blog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ROYcms_blog(");
			strSql.Append("user_id,tag,Title,Keyword,Description,content,Time)");
			strSql.Append(" values (");
			strSql.Append("@user_id,@tag,@Title,@Keyword,@Description,@content,@Time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@tag", SqlDbType.NVarChar,50),
					new SqlParameter("@Title", SqlDbType.NVarChar,100),
					new SqlParameter("@Keyword", SqlDbType.NVarChar,1000),
					new SqlParameter("@Description", SqlDbType.NVarChar,2000),
					new SqlParameter("@content", SqlDbType.Text),
					new SqlParameter("@Time", SqlDbType.DateTime)};
			parameters[0].Value = model.user_id;
			parameters[1].Value = model.tag;
			parameters[2].Value = model.Title;
			parameters[3].Value = model.Keyword;
			parameters[4].Value = model.Description;
			parameters[5].Value = model.content;
			parameters[6].Value = model.Time;

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
		public void Update(ROYcms.Blog.Model.ROYcms_blog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ROYcms_blog set ");
			strSql.Append("user_id=@user_id,");
			strSql.Append("tag=@tag,");
			strSql.Append("Title=@Title,");
			strSql.Append("Keyword=@Keyword,");
			strSql.Append("Description=@Description,");
			strSql.Append("content=@content,");
			strSql.Append("Time=@Time");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@tag", SqlDbType.NVarChar,50),
					new SqlParameter("@Title", SqlDbType.NVarChar,100),
					new SqlParameter("@Keyword", SqlDbType.NVarChar,1000),
					new SqlParameter("@Description", SqlDbType.NVarChar,2000),
					new SqlParameter("@content", SqlDbType.Text),
					new SqlParameter("@Time", SqlDbType.DateTime)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.user_id;
			parameters[2].Value = model.tag;
			parameters[3].Value = model.Title;
			parameters[4].Value = model.Keyword;
			parameters[5].Value = model.Description;
			parameters[6].Value = model.content;
			parameters[7].Value = model.Time;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ROYcms_blog ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Blog.Model.ROYcms_blog GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,user_id,tag,Title,Keyword,Description,content,Time from ROYcms_blog ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			ROYcms.Blog.Model.ROYcms_blog model=new ROYcms.Blog.Model.ROYcms_blog();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["user_id"].ToString()!="")
				{
					model.user_id=int.Parse(ds.Tables[0].Rows[0]["user_id"].ToString());
				}
				model.tag=ds.Tables[0].Rows[0]["tag"].ToString();
				model.Title=ds.Tables[0].Rows[0]["Title"].ToString();
				model.Keyword=ds.Tables[0].Rows[0]["Keyword"].ToString();
				model.Description=ds.Tables[0].Rows[0]["Description"].ToString();
				model.content=ds.Tables[0].Rows[0]["content"].ToString();
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
			strSql.Append("select id,user_id,tag,Title,Keyword,Description,content,Time ");
			strSql.Append(" FROM ROYcms_blog ");
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
			strSql.Append(" id,user_id,tag,Title,Keyword,Description,content,Time ");
			strSql.Append(" FROM ROYcms_blog ");
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
			parameters[0].Value = "ROYcms_blog";
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

