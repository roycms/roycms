using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Community.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_Community。
	/// </summary>
	public class ROYcms_Community
	{
		public ROYcms_Community()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("bh", "ROYcms_Community"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int bh)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ROYcms_Community");
			strSql.Append(" where bh=@bh ");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
			parameters[0].Value = bh;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Community.Model.ROYcms_Community model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ROYcms_Community(");
			strSql.Append("title,content,tag,user_id,type_id,hits,star_time,end_time,ip,switchs)");
			strSql.Append(" values (");
			strSql.Append("@title,@content,@tag,@user_id,@type_id,@hits,@star_time,@end_time,@ip,@switchs)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.VarChar,100),
					new SqlParameter("@content", SqlDbType.Text),
					new SqlParameter("@tag", SqlDbType.VarChar,100),
					new SqlParameter("@user_id", SqlDbType.VarChar,50),
					new SqlParameter("@type_id", SqlDbType.VarChar,50),
					new SqlParameter("@hits", SqlDbType.Int,4),
					new SqlParameter("@star_time", SqlDbType.DateTime),
					new SqlParameter("@end_time", SqlDbType.DateTime),
					new SqlParameter("@ip", SqlDbType.VarChar,100),
					new SqlParameter("@switchs", SqlDbType.Int,4)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.content;
			parameters[2].Value = model.tag;
			parameters[3].Value = model.user_id;
			parameters[4].Value = model.type_id;
			parameters[5].Value = model.hits;
			parameters[6].Value = model.star_time;
			parameters[7].Value = model.end_time;
			parameters[8].Value = model.ip;
			parameters[9].Value = model.switchs;

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
		public void Update(ROYcms.Community.Model.ROYcms_Community model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ROYcms_Community set ");
			strSql.Append("title=@title,");
			strSql.Append("content=@content,");
			strSql.Append("tag=@tag,");
			strSql.Append("user_id=@user_id,");
			strSql.Append("type_id=@type_id,");
			strSql.Append("hits=@hits,");
			strSql.Append("star_time=@star_time,");
			strSql.Append("end_time=@end_time,");
			strSql.Append("ip=@ip,");
			strSql.Append("switchs=@switchs");
			strSql.Append(" where bh=@bh ");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@title", SqlDbType.VarChar,100),
					new SqlParameter("@content", SqlDbType.Text),
					new SqlParameter("@tag", SqlDbType.VarChar,100),
					new SqlParameter("@user_id", SqlDbType.VarChar,50),
					new SqlParameter("@type_id", SqlDbType.VarChar,50),
					new SqlParameter("@hits", SqlDbType.Int,4),
					new SqlParameter("@star_time", SqlDbType.DateTime),
					new SqlParameter("@end_time", SqlDbType.DateTime),
					new SqlParameter("@ip", SqlDbType.VarChar,100),
					new SqlParameter("@switchs", SqlDbType.Int,4)};
			parameters[0].Value = model.bh;
			parameters[1].Value = model.title;
			parameters[2].Value = model.content;
			parameters[3].Value = model.tag;
			parameters[4].Value = model.user_id;
			parameters[5].Value = model.type_id;
			parameters[6].Value = model.hits;
			parameters[7].Value = model.star_time;
			parameters[8].Value = model.end_time;
			parameters[9].Value = model.ip;
			parameters[10].Value = model.switchs;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int bh)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ROYcms_Community ");
			strSql.Append(" where bh=@bh ");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
			parameters[0].Value = bh;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Community.Model.ROYcms_Community GetModel(int bh)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 bh,title,content,tag,user_id,type_id,hits,star_time,end_time,ip,switchs from ROYcms_Community ");
			strSql.Append(" where bh=@bh ");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
			parameters[0].Value = bh;

			ROYcms.Community.Model.ROYcms_Community model=new ROYcms.Community.Model.ROYcms_Community();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["bh"].ToString()!="")
				{
					model.bh=int.Parse(ds.Tables[0].Rows[0]["bh"].ToString());
				}
				model.title=ds.Tables[0].Rows[0]["title"].ToString();
				model.content=ds.Tables[0].Rows[0]["content"].ToString();
				model.tag=ds.Tables[0].Rows[0]["tag"].ToString();
				model.user_id=ds.Tables[0].Rows[0]["user_id"].ToString();
				model.type_id=ds.Tables[0].Rows[0]["type_id"].ToString();
				if(ds.Tables[0].Rows[0]["hits"].ToString()!="")
				{
					model.hits=int.Parse(ds.Tables[0].Rows[0]["hits"].ToString());
				}
				if(ds.Tables[0].Rows[0]["star_time"].ToString()!="")
				{
					model.star_time=DateTime.Parse(ds.Tables[0].Rows[0]["star_time"].ToString());
				}
				if(ds.Tables[0].Rows[0]["end_time"].ToString()!="")
				{
					model.end_time=DateTime.Parse(ds.Tables[0].Rows[0]["end_time"].ToString());
				}
				model.ip=ds.Tables[0].Rows[0]["ip"].ToString();
				if(ds.Tables[0].Rows[0]["switchs"].ToString()!="")
				{
					model.switchs=int.Parse(ds.Tables[0].Rows[0]["switchs"].ToString());
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
			strSql.Append("select bh,title,content,tag,user_id,type_id,hits,star_time,end_time,ip,switchs ");
			strSql.Append(" FROM ROYcms_Community ");
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
			strSql.Append(" bh,title,content,tag,user_id,type_id,hits,star_time,end_time,ip,switchs ");
			strSql.Append(" FROM ROYcms_Community ");
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
			parameters[0].Value = "ROYcms_Community";
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

