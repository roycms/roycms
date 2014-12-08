using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Ask.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_result。
	/// </summary>
	public class ROYcms_result
	{
		public ROYcms_result()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("bh", "ROYcms_result"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int bh)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ROYcms_result");
			strSql.Append(" where bh=@bh ");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
			parameters[0].Value = bh;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Ask.Model.ROYcms_result model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ROYcms_result(");
			strSql.Append("question_id,content,user_id,star_time,ip)");
			strSql.Append(" values (");
			strSql.Append("@question_id,@content,@user_id,@star_time,@ip)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@question_id", SqlDbType.Int,4),
					new SqlParameter("@content", SqlDbType.Text),
					new SqlParameter("@user_id", SqlDbType.VarChar,50),
					new SqlParameter("@star_time", SqlDbType.DateTime),
					new SqlParameter("@ip", SqlDbType.VarChar,100)};
			parameters[0].Value = model.question_id;
			parameters[1].Value = model.content;
			parameters[2].Value = model.user_id;
			parameters[3].Value = model.star_time;
			parameters[4].Value = model.ip;

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
		public void Update(ROYcms.Ask.Model.ROYcms_result model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ROYcms_result set ");
			strSql.Append("question_id=@question_id,");
			strSql.Append("content=@content,");
			strSql.Append("user_id=@user_id,");
			strSql.Append("star_time=@star_time,");
			strSql.Append("ip=@ip");
			strSql.Append(" where bh=@bh ");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@question_id", SqlDbType.Int,4),
					new SqlParameter("@content", SqlDbType.Text),
					new SqlParameter("@user_id", SqlDbType.VarChar,50),
					new SqlParameter("@star_time", SqlDbType.DateTime),
					new SqlParameter("@ip", SqlDbType.VarChar,100)};
			parameters[0].Value = model.bh;
			parameters[1].Value = model.question_id;
			parameters[2].Value = model.content;
			parameters[3].Value = model.user_id;
			parameters[4].Value = model.star_time;
			parameters[5].Value = model.ip;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int bh)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ROYcms_result ");
			strSql.Append(" where bh=@bh ");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
			parameters[0].Value = bh;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Ask.Model.ROYcms_result GetModel(int bh)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 bh,question_id,content,user_id,star_time,ip from ROYcms_result ");
			strSql.Append(" where bh=@bh ");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
			parameters[0].Value = bh;

			ROYcms.Ask.Model.ROYcms_result model=new ROYcms.Ask.Model.ROYcms_result();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["bh"].ToString()!="")
				{
					model.bh=int.Parse(ds.Tables[0].Rows[0]["bh"].ToString());
				}
				if(ds.Tables[0].Rows[0]["question_id"].ToString()!="")
				{
					model.question_id=int.Parse(ds.Tables[0].Rows[0]["question_id"].ToString());
				}
				model.content=ds.Tables[0].Rows[0]["content"].ToString();
				model.user_id=ds.Tables[0].Rows[0]["user_id"].ToString();
				if(ds.Tables[0].Rows[0]["star_time"].ToString()!="")
				{
					model.star_time=DateTime.Parse(ds.Tables[0].Rows[0]["star_time"].ToString());
				}
				model.ip=ds.Tables[0].Rows[0]["ip"].ToString();
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
			strSql.Append("select bh,question_id,content,user_id,star_time,ip ");
			strSql.Append(" FROM ROYcms_result ");
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
			strSql.Append(" bh,question_id,content,user_id,star_time,ip ");
			strSql.Append(" FROM ROYcms_result ");
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
			parameters[0].Value = "ROYcms_result";
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

