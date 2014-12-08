using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;

namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类:ROYcms_Log
	/// </summary>
	public partial class ROYcms_Log
	{
		public ROYcms_Log()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "Log");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			return ROYcms.DB.DbHelpers.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ROYcms.Sys.Model.ROYcms_Log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into "+ PubConstant.date_prefix + "Log(");
			strSql.Append("User_id,Admin_id,Err_id,Event,Content,Time,Ip)");
			strSql.Append(" values (");
			strSql.Append("@User_id,@Admin_id,@Err_id,@Event,@Content,@Time,@Ip)");
			SqlParameter[] parameters = {
					
					new SqlParameter("@User_id", SqlDbType.Int,4),
					new SqlParameter("@Admin_id", SqlDbType.Int,4),
					new SqlParameter("@Err_id", SqlDbType.VarChar,500),
					new SqlParameter("@Event", SqlDbType.VarChar,500),
					new SqlParameter("@Content", SqlDbType.VarChar,8000),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@Ip", SqlDbType.VarChar,50)};
			
			parameters[0].Value = model.User_id;
			parameters[1].Value = model.Admin_id;
			parameters[2].Value = model.Err_id;
			parameters[3].Value = model.Event;
			parameters[4].Value = model.Content;
			parameters[5].Value = model.Time;
			parameters[6].Value = model.Ip;

            int rows = ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_Log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update "+ PubConstant.date_prefix + "Log set ");
			strSql.Append("User_id=@User_id,");
			strSql.Append("Admin_id=@Admin_id,");
			strSql.Append("Err_id=@Err_id,");
			strSql.Append("Event=@Event,");
			strSql.Append("Content=@Content,");
			strSql.Append("Time=@Time,");
			strSql.Append("Ip=@Ip");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@User_id", SqlDbType.Int,4),
					new SqlParameter("@Admin_id", SqlDbType.Int,4),
					new SqlParameter("@Err_id", SqlDbType.VarChar,500),
					new SqlParameter("@Event", SqlDbType.VarChar,500),
					new SqlParameter("@Content", SqlDbType.VarChar,8000),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@Ip", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.User_id;
			parameters[1].Value = model.Admin_id;
			parameters[2].Value = model.Err_id;
			parameters[3].Value = model.Event;
			parameters[4].Value = model.Content;
			parameters[5].Value = model.Time;
			parameters[6].Value = model.Ip;
			parameters[7].Value = model.id;

			int rows=ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(),parameters);
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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "Log ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			int rows=ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(),parameters);
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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "Log ");
			strSql.Append(" where id in ("+idlist + ")  ");
            int rows = ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
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
		public ROYcms.Sys.Model.ROYcms_Log GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,User_id,Admin_id,Err_id,Event,Content,Time,Ip from " + PubConstant.date_prefix + "Log ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			ROYcms.Sys.Model.ROYcms_Log model=new ROYcms.Sys.Model.ROYcms_Log();
            DataSet ds = ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString(), parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["User_id"]!=null && ds.Tables[0].Rows[0]["User_id"].ToString()!="")
				{
					model.User_id=int.Parse(ds.Tables[0].Rows[0]["User_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Admin_id"]!=null && ds.Tables[0].Rows[0]["Admin_id"].ToString()!="")
				{
					model.Admin_id=int.Parse(ds.Tables[0].Rows[0]["Admin_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Err_id"]!=null && ds.Tables[0].Rows[0]["Err_id"].ToString()!="")
				{
					model.Err_id=ds.Tables[0].Rows[0]["Err_id"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Event"]!=null && ds.Tables[0].Rows[0]["Event"].ToString()!="")
				{
					model.Event=ds.Tables[0].Rows[0]["Event"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Content"]!=null && ds.Tables[0].Rows[0]["Content"].ToString()!="")
				{
					model.Content=ds.Tables[0].Rows[0]["Content"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Time"]!=null && ds.Tables[0].Rows[0]["Time"].ToString()!="")
				{
					model.Time=DateTime.Parse(ds.Tables[0].Rows[0]["Time"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Ip"]!=null && ds.Tables[0].Rows[0]["Ip"].ToString()!="")
				{
					model.Ip=ds.Tables[0].Rows[0]["Ip"].ToString();
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
			strSql.Append("select id,User_id,Admin_id,Err_id,Event,Content,Time,Ip ");
			strSql.Append(" from " + PubConstant.date_prefix + "Log ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
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
			strSql.Append(" id,User_id,Admin_id,Err_id,Event,Content,Time,Ip ");
			strSql.Append(" from " + PubConstant.date_prefix + "Log ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "Log ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            object obj = ROYcms.DB.DbHelpers.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from " + PubConstant.date_prefix + "Log T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
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
			parameters[0].Value = PubConstant.date_prefix + "Log";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 1;
			parameters[6].Value = strWhere;
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage", parameters, "ds");
		}

		#endregion  Method
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int GetCount(string where)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) as H ");
            strSql.Append(" FROM [" + PubConstant.date_prefix + "Log] ");
            if (where.Trim() != "")
            {
                strSql.Append(" where " + where);
            }
            return Convert.ToInt32(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));
        }
    }
}

