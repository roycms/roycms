using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DNSABC.IDAL;
using ROYcms.DB;
namespace DNSABC.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:DNSABC_Payment
	/// </summary>
	public partial class DNSABC_Payment:IDNSABC_Payment
	{
		public DNSABC_Payment()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DNSABC_Payment"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DNSABC_Payment");
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
		public int Add(DNSABC.Model.DNSABC_Payment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DNSABC_Payment(");
			strSql.Append("UserID,PaymentType,PaymentName,PaymentAmount,PaymentNum,UpdateTime,CreateTime)");
			strSql.Append(" values (");
			strSql.Append("@UserID,@PaymentType,@PaymentName,@PaymentAmount,@PaymentNum,@UpdateTime,@CreateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@PaymentType", SqlDbType.VarChar,50),
					new SqlParameter("@PaymentName", SqlDbType.VarChar,4000),
					new SqlParameter("@PaymentAmount", SqlDbType.Int,4),
					new SqlParameter("@PaymentNum", SqlDbType.VarChar,100),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@CreateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.PaymentType;
			parameters[2].Value = model.PaymentName;
			parameters[3].Value = model.PaymentAmount;
			parameters[4].Value = model.PaymentNum;
			parameters[5].Value = model.UpdateTime;
			parameters[6].Value = model.CreateTime;

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
		public bool Update(DNSABC.Model.DNSABC_Payment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DNSABC_Payment set ");
			strSql.Append("UserID=@UserID,");
			strSql.Append("PaymentType=@PaymentType,");
			strSql.Append("PaymentName=@PaymentName,");
			strSql.Append("PaymentAmount=@PaymentAmount,");
			strSql.Append("PaymentNum=@PaymentNum,");
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("CreateTime=@CreateTime");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@PaymentType", SqlDbType.VarChar,50),
					new SqlParameter("@PaymentName", SqlDbType.VarChar,4000),
					new SqlParameter("@PaymentAmount", SqlDbType.Int,4),
					new SqlParameter("@PaymentNum", SqlDbType.VarChar,100),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.PaymentType;
			parameters[2].Value = model.PaymentName;
			parameters[3].Value = model.PaymentAmount;
			parameters[4].Value = model.PaymentNum;
			parameters[5].Value = model.UpdateTime;
			parameters[6].Value = model.CreateTime;
			parameters[7].Value = model.Id;

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
			strSql.Append("delete from DNSABC_Payment ");
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
			strSql.Append("delete from DNSABC_Payment ");
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
		public DNSABC.Model.DNSABC_Payment GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,UserID,PaymentType,PaymentName,PaymentAmount,PaymentNum,UpdateTime,CreateTime from DNSABC_Payment ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
			parameters[0].Value = Id;

			DNSABC.Model.DNSABC_Payment model=new DNSABC.Model.DNSABC_Payment();
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
				if(ds.Tables[0].Rows[0]["PaymentType"]!=null && ds.Tables[0].Rows[0]["PaymentType"].ToString()!="")
				{
					model.PaymentType=ds.Tables[0].Rows[0]["PaymentType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PaymentName"]!=null && ds.Tables[0].Rows[0]["PaymentName"].ToString()!="")
				{
					model.PaymentName=ds.Tables[0].Rows[0]["PaymentName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PaymentAmount"]!=null && ds.Tables[0].Rows[0]["PaymentAmount"].ToString()!="")
				{
					model.PaymentAmount=int.Parse(ds.Tables[0].Rows[0]["PaymentAmount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PaymentNum"]!=null && ds.Tables[0].Rows[0]["PaymentNum"].ToString()!="")
				{
					model.PaymentNum=ds.Tables[0].Rows[0]["PaymentNum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UpdateTime"]!=null && ds.Tables[0].Rows[0]["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(ds.Tables[0].Rows[0]["UpdateTime"].ToString());
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
			strSql.Append("select Id,UserID,PaymentType,PaymentName,PaymentAmount,PaymentNum,UpdateTime,CreateTime ");
			strSql.Append(" FROM DNSABC_Payment ");
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
			strSql.Append(" Id,UserID,PaymentType,PaymentName,PaymentAmount,PaymentNum,UpdateTime,CreateTime ");
			strSql.Append(" FROM DNSABC_Payment ");
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
			strSql.Append("select count(1) FROM DNSABC_Payment ");
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
			strSql.Append(")AS Row, T.*  from DNSABC_Payment T ");
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
			parameters[0].Value = "DNSABC_Payment";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}

		#endregion  Method
	}
}

