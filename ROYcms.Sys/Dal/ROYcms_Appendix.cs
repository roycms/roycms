using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类:ROYcms_Appendix
	/// </summary>
	public partial class ROYcms_Appendix
	{
		public ROYcms_Appendix()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "ROYcms_Appendix"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ROYcms_Appendix");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_Appendix model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ROYcms_Appendix(");
			strSql.Append("Rid,TYPE,URL,Title,TIME)");
			strSql.Append(" values (");
			strSql.Append("@Rid,@TYPE,@URL,@Title,@TIME)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Rid", SqlDbType.Int,4),
					new SqlParameter("@TYPE", SqlDbType.Int,4),
					new SqlParameter("@URL", SqlDbType.VarChar,500),
					new SqlParameter("@Title", SqlDbType.VarChar,500),
					new SqlParameter("@TIME", SqlDbType.DateTime)};
			parameters[0].Value = model.Rid;
			parameters[1].Value = model.TYPE;
			parameters[2].Value = model.URL;
			parameters[3].Value = model.Title;
			parameters[4].Value = model.TIME;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_Appendix model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ROYcms_Appendix set ");
			strSql.Append("Rid=@Rid,");
			strSql.Append("TYPE=@TYPE,");
			strSql.Append("URL=@URL,");
			strSql.Append("Title=@Title,");
			strSql.Append("TIME=@TIME");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Rid", SqlDbType.Int,4),
					new SqlParameter("@TYPE", SqlDbType.Int,4),
					new SqlParameter("@URL", SqlDbType.VarChar,500),
					new SqlParameter("@Title", SqlDbType.VarChar,500),
					new SqlParameter("@TIME", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Rid;
			parameters[1].Value = model.TYPE;
			parameters[2].Value = model.URL;
			parameters[3].Value = model.Title;
			parameters[4].Value = model.TIME;
			parameters[5].Value = model.Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
        /// <summary>
        /// 删除数据 根据查询条件
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public bool Delete(string where)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ROYcms_Appendix  ");
            strSql.Append(" where " + where);
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ROYcms_Appendix ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
			parameters[0].Value = Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ROYcms_Appendix ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Appendix GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Rid,TYPE,URL,Title,TIME from ROYcms_Appendix ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
			parameters[0].Value = Id;

			ROYcms.Sys.Model.ROYcms_Appendix model=new ROYcms.Sys.Model.ROYcms_Appendix();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Rid"]!=null && ds.Tables[0].Rows[0]["Rid"].ToString()!="")
				{
					model.Rid=int.Parse(ds.Tables[0].Rows[0]["Rid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TYPE"]!=null && ds.Tables[0].Rows[0]["TYPE"].ToString()!="")
				{
					model.TYPE=int.Parse(ds.Tables[0].Rows[0]["TYPE"].ToString());
				}
				if(ds.Tables[0].Rows[0]["URL"]!=null && ds.Tables[0].Rows[0]["URL"].ToString()!="")
				{
					model.URL=ds.Tables[0].Rows[0]["URL"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Title"]!=null && ds.Tables[0].Rows[0]["Title"].ToString()!="")
				{
					model.Title=ds.Tables[0].Rows[0]["Title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["TIME"]!=null && ds.Tables[0].Rows[0]["TIME"].ToString()!="")
				{
					model.TIME=DateTime.Parse(ds.Tables[0].Rows[0]["TIME"].ToString());
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
			strSql.Append("select Id,Rid,TYPE,URL,Title,TIME ");
			strSql.Append(" FROM ROYcms_Appendix ");
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
			strSql.Append(" Id,Rid,TYPE,URL,Title,TIME ");
			strSql.Append(" FROM ROYcms_Appendix ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM ROYcms_Appendix ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from ROYcms_Appendix T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
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
			parameters[0].Value = "ROYcms_Appendix";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

