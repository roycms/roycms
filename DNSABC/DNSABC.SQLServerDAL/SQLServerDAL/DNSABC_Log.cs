using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DNSABC.IDAL;
using ROYcms.DB;
namespace DNSABC.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:DNSABC_Log
	/// </summary>
	public partial class DNSABC_Log:IDNSABC_Log
	{
		public DNSABC_Log()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DNSABC_Log"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DNSABC_Log");
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
		public int Add(DNSABC.Model.DNSABC_Log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DNSABC_Log(");
			strSql.Append("UserID,LogType,Content,Operator,Ip,AdminID,ObjectType,ObjectID,Remark,CreateTime)");
			strSql.Append(" values (");
			strSql.Append("@UserID,@LogType,@Content,@Operator,@Ip,@AdminID,@ObjectType,@ObjectID,@Remark,@CreateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@LogType", SqlDbType.Int,4),
					new SqlParameter("@Content", SqlDbType.VarChar,500),
					new SqlParameter("@Operator", SqlDbType.VarChar,50),
					new SqlParameter("@Ip", SqlDbType.VarChar,20),
					new SqlParameter("@AdminID", SqlDbType.Int,4),
					new SqlParameter("@ObjectType", SqlDbType.VarChar,50),
					new SqlParameter("@ObjectID", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@CreateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.LogType;
			parameters[2].Value = model.Content;
			parameters[3].Value = model.Operator;
			parameters[4].Value = model.Ip;
			parameters[5].Value = model.AdminID;
			parameters[6].Value = model.ObjectType;
			parameters[7].Value = model.ObjectID;
			parameters[8].Value = model.Remark;
			parameters[9].Value = model.CreateTime;

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
		public bool Update(DNSABC.Model.DNSABC_Log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DNSABC_Log set ");
			strSql.Append("UserID=@UserID,");
			strSql.Append("LogType=@LogType,");
			strSql.Append("Content=@Content,");
			strSql.Append("Operator=@Operator,");
			strSql.Append("Ip=@Ip,");
			strSql.Append("AdminID=@AdminID,");
			strSql.Append("ObjectType=@ObjectType,");
			strSql.Append("ObjectID=@ObjectID,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("CreateTime=@CreateTime");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@LogType", SqlDbType.Int,4),
					new SqlParameter("@Content", SqlDbType.VarChar,500),
					new SqlParameter("@Operator", SqlDbType.VarChar,50),
					new SqlParameter("@Ip", SqlDbType.VarChar,20),
					new SqlParameter("@AdminID", SqlDbType.Int,4),
					new SqlParameter("@ObjectType", SqlDbType.VarChar,50),
					new SqlParameter("@ObjectID", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.LogType;
			parameters[2].Value = model.Content;
			parameters[3].Value = model.Operator;
			parameters[4].Value = model.Ip;
			parameters[5].Value = model.AdminID;
			parameters[6].Value = model.ObjectType;
			parameters[7].Value = model.ObjectID;
			parameters[8].Value = model.Remark;
			parameters[9].Value = model.CreateTime;
			parameters[10].Value = model.Id;

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
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DNSABC_Log ");
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
			strSql.Append("delete from DNSABC_Log ");
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
		public DNSABC.Model.DNSABC_Log GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,UserID,LogType,Content,Operator,Ip,AdminID,ObjectType,ObjectID,Remark,CreateTime from DNSABC_Log ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
			parameters[0].Value = Id;

			DNSABC.Model.DNSABC_Log model=new DNSABC.Model.DNSABC_Log();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UserID"]!=null && ds.Tables[0].Rows[0]["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["LogType"]!=null && ds.Tables[0].Rows[0]["LogType"].ToString()!="")
				{
					model.LogType=int.Parse(ds.Tables[0].Rows[0]["LogType"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Content"]!=null && ds.Tables[0].Rows[0]["Content"].ToString()!="")
				{
					model.Content=ds.Tables[0].Rows[0]["Content"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Operator"]!=null && ds.Tables[0].Rows[0]["Operator"].ToString()!="")
				{
					model.Operator=ds.Tables[0].Rows[0]["Operator"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Ip"]!=null && ds.Tables[0].Rows[0]["Ip"].ToString()!="")
				{
					model.Ip=ds.Tables[0].Rows[0]["Ip"].ToString();
				}
				if(ds.Tables[0].Rows[0]["AdminID"]!=null && ds.Tables[0].Rows[0]["AdminID"].ToString()!="")
				{
					model.AdminID=int.Parse(ds.Tables[0].Rows[0]["AdminID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ObjectType"]!=null && ds.Tables[0].Rows[0]["ObjectType"].ToString()!="")
				{
					model.ObjectType=ds.Tables[0].Rows[0]["ObjectType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ObjectID"]!=null && ds.Tables[0].Rows[0]["ObjectID"].ToString()!="")
				{
					model.ObjectID=ds.Tables[0].Rows[0]["ObjectID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null && ds.Tables[0].Rows[0]["Remark"].ToString()!="")
				{
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
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
			strSql.Append("select Id,UserID,LogType,Content,Operator,Ip,AdminID,ObjectType,ObjectID,Remark,CreateTime ");
			strSql.Append(" FROM DNSABC_Log ");
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
			strSql.Append(" Id,UserID,LogType,Content,Operator,Ip,AdminID,ObjectType,ObjectID,Remark,CreateTime ");
			strSql.Append(" FROM DNSABC_Log ");
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
			strSql.Append("select count(1) FROM DNSABC_Log ");
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
			strSql.Append(")AS Row, T.*  from DNSABC_Log T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
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
			parameters[0].Value = "DNSABC_Log";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}

		#endregion  Method

        int IDNSABC_Log.GetMaxId()
        {
            throw new NotImplementedException();
        }

        bool IDNSABC_Log.Exists(int Id)
        {
            throw new NotImplementedException();
        }

        int IDNSABC_Log.Add(Model.DNSABC_Log model)
        {
            throw new NotImplementedException();
        }

        bool IDNSABC_Log.Update(Model.DNSABC_Log model)
        {
            throw new NotImplementedException();
        }

        bool IDNSABC_Log.Delete(int Id)
        {
            throw new NotImplementedException();
        }

        bool IDNSABC_Log.DeleteList(string Idlist)
        {
            throw new NotImplementedException();
        }

        Model.DNSABC_Log IDNSABC_Log.GetModel(int Id)
        {
            throw new NotImplementedException();
        }

        DataSet IDNSABC_Log.GetList(string strWhere)
        {
            throw new NotImplementedException();
        }

        DataSet IDNSABC_Log.GetList(int Top, string strWhere, string filedOrder)
        {
            throw new NotImplementedException();
        }

        DataSet IDNSABC_Log.GetList(int PageSize, int PageIndex, string strWhere)
        {
            throw new NotImplementedException();
        }

        int IDNSABC_Log.GetRecordCount(string strWhere)
        {
            throw new NotImplementedException();
        }
    }
}

